using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Conflow
{

    public partial class Cadastro_MoradoresUC : UserControl
    {
        private UCPessoa_Fisica ucPFisica = null;
        private UCPessoa_Juridica ucPJuridica = null;

        public List<Int32> dadosCodsCondominio = new List<Int32>();
        public List<Int32> dadosCodsBloco = new List<int>();
        public List<Int32> dadosCodsPredio = new List<int>();
        public List<Int32> dadosCodsApartamento = new List<int>();

        AtalhosSQL ComandosSQL = new AtalhosSQL();

        public Cadastro_MoradoresUC()
        {
            InitializeComponent();
            pessoaFisicaRb.Checked = true;
            MudarTipoPessoa();
            
        }
        

        private void CriarBtn_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection linhaSelecionada = apartamentoList.SelectedRows;
            if (nomeTbox.Text.Length > 0 && rgTbox.Text.Length > 0 && numeroestacionamentoNud.Value > 0 && linhaSelecionada != null)
            {
                
                String cpfcnpjPessoa = "";
                if (pessoaFisicaRb.Checked == true)
                {
                    cpfcnpjPessoa = ucPFisica.Controls["cpfTbox"].Text;
                }
                else if (pessoaJuridicaRb.Checked == true)
                {
                    cpfcnpjPessoa = ucPJuridica.Controls["cnpjTbox"].Text;
                }

                // Retira a máscara do CPF / CNPJ
                rgTbox.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

                String cpfCnpjDesmascarado;
                if (pessoaFisicaRb.Checked)
                {
                    cpfCnpjDesmascarado = ucPFisica.getCPF();
                }
                else
                {
                    cpfCnpjDesmascarado = ucPJuridica.getCNPJ();
                }

                String dataNascimento = datanascimentoDtp.Value.Date.Year.ToString();
                dataNascimento += ComandosSQL.ConverterDataHora(datanascimentoDtp.Value.Date.Month.ToString());
                dataNascimento += ComandosSQL.ConverterDataHora(datanascimentoDtp.Value.Date.Day.ToString());

                
                // Criando Morador
                String cmdTxt = "";
                String timestamp_criacao = ComandosSQL.current_timestamp;
                   cmdTxt = "INSERT INTO PROPRIETARIO(          " +
                            "    NOME_PROPRIETARIO,             " +
                            "    RG_PROPRIETARIO,               " +
                            "    SEXO_PROPRIETARIO,             " +
                            "    DAT_NASCIMENTO_PROPRIETARIO,   " +
                            "    END_UF_PROPRIETARIO,           " +
                            "    END_CIDADE_PROPRIETARIO,       " +
                            "    END_BAIRRO_PROPRIETARIO,       " +
                            "    END_RUA_PROPRIETARIO,          " +
                            "    END_NUM_PROPRIETARIO,          " +
                            "    COD_APARTAMENTO_PROPRIETARIO,  " +
                            "    ULTIMA_MODIFICACAO             " +
                            ") VALUES(                          " +
                            "    @nome                          " +
                            "   ,@rg                            " +
                            "   ,@sexo                          " +
                            "   ,@dat_nasc                      " +
                            "   ,@end_uf                        " +
                            "   ,@end_cidade                    " +
                            "   ,@end_bairro                    " +
                            "   ,@end_rua                       " +
                            "   ,@end_num                       " +
                            "   ,@cod_apartamento               " +
                            "   ,@timestamp_criacao             " +
                            ");                                 ";
                ComandosSQL.comandoSql.Parameters.AddWithValue("nome", nomeTbox.Text);
                ComandosSQL.comandoSql.Parameters.AddWithValue("rg", rgTbox.Text);
                if (sexoMRBtn.Checked)
                {
                    ComandosSQL.comandoSql.Parameters.AddWithValue("sexo", "M");
                }
                else
                {
                    ComandosSQL.comandoSql.Parameters.AddWithValue("sexo", "F");
                }
                ComandosSQL.comandoSql.Parameters.AddWithValue("dat_nasc", dataNascimento);
                ComandosSQL.comandoSql.Parameters.AddWithValue("end_uf", estadoCBox.Text);
                ComandosSQL.comandoSql.Parameters.AddWithValue("end_cidade", cidadeTBox.Text);
                ComandosSQL.comandoSql.Parameters.AddWithValue("end_bairro", bairroTbox.Text);
                ComandosSQL.comandoSql.Parameters.AddWithValue("end_rua", ruaTBox.Text);
                ComandosSQL.comandoSql.Parameters.AddWithValue("end_num", Convert.ToInt32(localNumeroNud.Value));
                ComandosSQL.comandoSql.Parameters.AddWithValue("cod_apartamento", linhaSelecionada[0].Cells["COD_APARTAMENTO"].Value);
                ComandosSQL.comandoSql.Parameters.AddWithValue("timestamp_criacao", timestamp_criacao);

                ComandosSQL.ExecutarComandoSql(cmdTxt);
                // Criando CPF / CNPJ do Morador
                if (pessoaFisicaRb.Checked)
                {
                    cmdTxt = "INSERT INTO PROPRIETARIO_CPF(   " +
                             "    COD_PROPRIETARIO,           " +
                             "    CPF_PROPRIETARIO            " +
                             ") VALUES(                       " +
                             "    (SELECT COD_PROPRIETARIO FROM PROPRIETARIO WHERE NOME_PROPRIETARIO = '" + nomeTbox.Text + "' AND ULTIMA_MODIFICACAO = '" + timestamp_criacao + "')," +
                             "    @cpf                        " +
                             ");                              ";

                    ComandosSQL.comandoSql.Parameters.AddWithValue("cpf", cpfCnpjDesmascarado);
                }
                else
                {
                    cmdTxt = "INSERT INTO PROPRIETARIO_CNPJ(        " +
                             "    COD_PROPRIETARIO,                 " +
                             "    CNPJ_PROPRIETARIO                 " +
                             ") VALUES(                             " +
                             "    (SELECT COD_PROPRIETARIO FROM PROPRIETARIO WHERE NOME_PROPRIETARIO = '" + nomeTbox.Text + "' AND ULTIMA_MODIFICACAO = '" + timestamp_criacao + "')," +
                             "    @cnpj                             " +
                             ");                                    ";

                    ComandosSQL.comandoSql.Parameters.AddWithValue("cnpj", cpfCnpjDesmascarado);
                }

                if (!ComandosSQL.ExecutarComandoSql(cmdTxt, "", "Não foi possível adicionar o CPF/CNPJ do morador."))
                {
                    cmdTxt =    "DELETE FROM PROPRIETARIO                                                " +
                                "WHERE COD_MORADOR = (SELECT COD_PROPRIETARIO                            " +
                                "FROM PROPRIETARIO                                                       " +
                                "WHERE NOME_PROPRIETARIO = '" + nomeTbox.Text + "' AND ULTIMA_MODIFICACAO = '" + timestamp_criacao + "');  ";
                    
                    ComandosSQL.ExecutarComandoSql(cmdTxt, "");
                }
                
                // Adicionado contatos do proprietario
                foreach (object o in contatoList.Items)
                {
                    cmdTxt =    "INSERT INTO PROPRIETARIO_CONTATO(  " +
                                "   COD_PROPRIETARIO                " +
                                "  ,DSC_CONTATO                     " +
                                ") VALUES(                          " +
                                "   (SELECT COD_PROPRIETARIO FROM PROPRIETARIO WHERE NOME_PROPRIETARIO = @nome AND ULTIMA_MODIFICACAO = @timestamp_criacao)" +
                                "  ,@contato                        " +
                                ");                                 " ;

                    ComandosSQL.comandoSql.Parameters.AddWithValue("nome", nomeTbox.Text);
                    ComandosSQL.comandoSql.Parameters.AddWithValue("timestamp_criacao", timestamp_criacao);
                    ComandosSQL.comandoSql.Parameters.AddWithValue("contato", o.ToString());

                    ComandosSQL.ExecutarComandoSql(cmdTxt, "");
                    
                }
                MessageBox.Show("Proprietário adicionado com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro: Um ou mais campos não foram preenchidos.");
            }
            
        }
        
        //


        private void MudarTipoPessoa()
        {
            if (pessoaFisicaRb.Checked == true)
            {
                if (ucPFisica == null)
                {
                    ucPFisica = new UCPessoa_Fisica();
                }

                cpfRgPanel.Controls.Add(ucPFisica);
                ucPFisica.Show();

                if (ucPJuridica != null)
                {
                    ucPJuridica.Hide();
                }
            }
            else if (pessoaJuridicaRb.Checked == true)
            {
                if (ucPJuridica == null)
                {
                    ucPJuridica = new UCPessoa_Juridica();
                }

                cpfRgPanel.Controls.Add(ucPJuridica);
                ucPJuridica.Show();

                if (ucPFisica != null)
                {
                    ucPFisica.Hide();
                }
            }
        }

        private void pessoaFisicaRb_CheckedChanged(object sender, EventArgs e)
        {
            MudarTipoPessoa();
        }

        private void pessoaJuridicaRb_CheckedChanged(object sender, EventArgs e)
        {
            MudarTipoPessoa();
        }

        
        // Atualiza as listas do grupo Localização
        public void AtualizarLocalizacao()
        {
            try
            {
                ComandosSQL.conn = new MySqlConnection(ComandosSQL.str);
                ComandosSQL.conn.Open();

                // Predio
                predioList.Rows.Clear();

                String cmdSelect =  "SELECT COD_PREDIO, ID_PREDIO " +
                                    "FROM PREDIO";
                
                MySqlCommand cmd = new MySqlCommand(cmdSelect, ComandosSQL.conn);
                cmd.Prepare();
                using (MySqlDataReader leitor = cmd.ExecuteReader())
                {
                    while (leitor.Read())
                    {
                        int index = predioList.Rows.Add();
                        DataGridViewRow linhaTabela = predioList.Rows[index];
                        linhaTabela.Cells["COD_PREDIO"].Value = Convert.ToInt32(leitor["COD_PREDIO"]);
                        linhaTabela.Cells["ID_PREDIO"].Value = leitor["ID_PREDIO"];
                    }
                }

            }
            catch (Exception excessao)
            {
                MessageBox.Show("Um erro ocorreu ao tentar ler o banco de dados. \nDescrição: " + excessao.Message);
            }

            ComandosSQL.conn.Close();
        }

        private void adicionarContatoBtn_Click(object sender, EventArgs e)
        {
            if (contatoTbox.Text.Length > 0 && tipoContatoCB.SelectedIndex != -1)
            {
                contatoList.Items.Add(contatoTbox.Text);
            }
            
        }

        private void removerContatoBtn_Click(object sender, EventArgs e)
        {
            if (contatoList.SelectedIndex >= 0)
            {
                contatoList.Items.RemoveAt(contatoList.SelectedIndex);
            }
        }

        private void tipoContatoCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            contatoTbox.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            if (tipoContatoCB.Text == "Telefone")
            {
                contatoTbox.Mask = "(00) 0000-0000";
            }
            else
            {
                contatoTbox.Mask = "";
            }

        }


        private void predioList_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (predioList.SelectedRows.Count > 0)
            {
                dadosCodsCondominio.Clear();
                try
                {
                    ComandosSQL.conn = new MySqlConnection(ComandosSQL.str);
                    ComandosSQL.conn.Open();

                    // Apartamentos
                    apartamentoList.Rows.Clear();

                    String cmdSelect = "SELECT COD_APARTAMENTO, NUM_APARTAMENTO " +
                                        "FROM APARTAMENTO " +
                                        "WHERE COD_PREDIO = @cod;";

                    MySqlCommand cmd = new MySqlCommand(cmdSelect, ComandosSQL.conn);

                    DataGridViewSelectedRowCollection linhaSelecionada = predioList.SelectedRows;
                    
                    cmd.Parameters.AddWithValue("cod", Convert.ToInt32(linhaSelecionada[0].Cells["COD_PREDIO"].Value));


                    cmd.Prepare();
                    using (MySqlDataReader leitor = cmd.ExecuteReader())
                    {
                        while (leitor.Read())
                        {

                            int index = apartamentoList.Rows.Add();
                            DataGridViewRow linhaTabela = apartamentoList.Rows[index];
                            linhaTabela.Cells["COD_APARTAMENTO"].Value = Convert.ToInt32(leitor["COD_APARTAMENTO"]);
                            linhaTabela.Cells["NUM_APARTAMENTO"].Value = Convert.ToInt32(leitor["NUM_APARTAMENTO"]);
                        }
                    }

                }
                catch (Exception excessao)
                {
                    MessageBox.Show("Um erro ocorreu ao tentar ler o banco de dados. \nDescrição: " + excessao.Message);
                }

                ComandosSQL.conn.Close();
            }
            
        }
        
    }
}

