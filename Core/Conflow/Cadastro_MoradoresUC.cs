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
            
            if (nomeTbox.Text.Length > 0 && rgTbox.Text.Length > 0 && numeroestacionamentoNud.Value > 0)
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
                   cmdTxt = "INSERT INTO MORADOR(               " +
                            "    NOME_MORADOR,                  " +
                            "    RG_MORADOR,                    " +
                            "    DAT_NASCIMENTO_MORADOR,        " +
                            "    ULTIMA_MODIFICACAO             " +
                            ") VALUES(                          " +
                            "    @nome                          " +
                            "    @rg                            " +
                            "    @dat_nasc                      " +
                            "    @timestamp_criacao             " +
                            ");                                 ";

                ComandosSQL.comandoSql.Parameters.AddWithValue("nome", nomeTbox.Text);
                ComandosSQL.comandoSql.Parameters.AddWithValue("rg", rgTbox.Text);
                ComandosSQL.comandoSql.Parameters.AddWithValue("dat_nasc", dataNascimento);
                ComandosSQL.comandoSql.Parameters.AddWithValue("timestamp_criacao", timestamp_criacao);


                ComandosSQL.ExecutarComandoSql(cmdTxt, "Novo morador adicionado com sucesso!", "Não foi possível adicionar o morador.");
                // Criando CPF / CNPJ do Morador
                if (pessoaFisicaRb.Checked)
                {
                    cmdTxt = "INSERT INTO MORADOR_CPF(   " +
                             "    COD_MORADOR,           " +
                             "    CPF_MORADOR            " +
                             ") VALUES(                  " +
                             "    (SELECT COD_MORADOR FROM MORADOR WHERE NOME_MORADOR = '" + nomeTbox.Text + "' AND ULTIMA_MODIFICACAO = '" + timestamp_criacao + "')," +
                             "    @cpf                   " +
                             ");                         ";

                    ComandosSQL.comandoSql.Parameters.AddWithValue("cpf", cpfCnpjDesmascarado);
                }
                else
                {
                    cmdTxt = "INSERT INTO MORADOR_CNPJ(     " +
                             "    COD_MORADOR,              " +
                             "    CNPJ_MORADOR              " +
                             ") VALUES(                     " +
                             "    (SELECT COD_MORADOR FROM MORADOR WHERE NOME_MORADOR = '" + nomeTbox.Text + "' AND ULTIMA_MODIFICACAO = '" + timestamp_criacao + "')," +
                             "    @cnpj                     " +
                             ");                            ";

                    ComandosSQL.comandoSql.Parameters.AddWithValue("cnpj", cpfCnpjDesmascarado);
                }

                if (!ComandosSQL.ExecutarComandoSql(cmdTxt, "", "Não foi possível adicionar o CPF/CNPJ do morador."))
                {
                    cmdTxt =    "DELETE FROM MORADOR                                                " +
                                "WHERE COD_MORADOR = (SELECT COD_MORADOR                            " +
                                "FROM MORADOR                                                       " +
                                "WHERE NOME_MORADOR = '" + nomeTbox.Text + "' AND ULTIMA_MODIFICACAO = '" + timestamp_criacao + "');  ";
                    
                    ComandosSQL.ExecutarComandoSql(cmdTxt, "");
                }
                

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
            dadosCodsCondominio.Clear();
            try
            {
                ComandosSQL.conn = new MySqlConnection(ComandosSQL.str);
                ComandosSQL.conn.Open();

                // Condominios
                apartamentoList.Rows.Clear();

                String cmdSelect =  "SELECT AP.COD_APARTAMENTO, AP.NUM_APARTAMENTO, PRE.ID_PREDIO, BLO.ID_BLOCO, CON.ID_CONDOMINIO " +
                                    "FROM APARTAMENTO AP " +
                                    "LEFT JOIN PREDIO PRE ON PRE.COD_PREDIO = AP.COD_PREDIO " +
                                    "LEFT JOIN BLOCO BLO ON BLO.COD_BLOCO = PRE.COD_BLOCO " +
                                    "LEFT JOIN CONDOMINIO CON ON CON.COD_CONDOMINIO = BLO.COD_CONDOMINIO;";

                MySqlCommand cmd = new MySqlCommand(cmdSelect, ComandosSQL.conn);
                cmd.Prepare();
                using (MySqlDataReader leitor = cmd.ExecuteReader())
                {
                    while (leitor.Read())
                    {
                        int index = apartamentoList.Rows.Add();
                        DataGridViewRow linhaTabela = apartamentoList.Rows[index];
                        linhaTabela.Cells["COD_APARTAMENTO"].Value = Convert.ToInt32(leitor["COD_APARTAMENTO"]);
                        linhaTabela.Cells["NUM_APARTAMENTO"].Value = Convert.ToInt32(leitor["NUM_APARTAMENTO"]);
                        linhaTabela.Cells["ID_PREDIO"].Value = leitor["ID_PREDIO"];
                        linhaTabela.Cells["ID_BLOCO"].Value = leitor["ID_BLOCO"];
                        linhaTabela.Cells["ID_CONDOMINIO"].Value = leitor["ID_CONDOMINIO"];
                    }
                }

            }
            catch (Exception e)
            {
                MessageBox.Show("Um erro ocorreu ao tentar ler o banco de dados. \nDescrição: " + e.Message);
            }

            ComandosSQL.conn.Close();

        }
        

    }
}

