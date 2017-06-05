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
    public partial class Pesquisa_ProprietariosUC : UserControl
    {
        public Pesquisa_ProprietariosUC()
        {
            InitializeComponent();

            pessoaFisicaRb.Checked = true;
            MudarTipoPessoa();
        }




        private UCPessoa_Fisica ucPFisica = new UCPessoa_Fisica();
        private UCPessoa_Juridica ucPJuridica = new UCPessoa_Juridica();


        AtalhosSQL ComandosSQL = new AtalhosSQL();
        

        private void GuardarBtn_Click(object sender, EventArgs e)
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


                // Atualizando Morador
                String cmdTxt = "";
                String timestamp_criacao = ComandosSQL.current_timestamp;
                cmdTxt =    "UPDATE PROPRIETARIO SET        " +
                            "NOME_PROPRIETARIO = @nome, " +
                            "RG_PROPRIETARIO = @rg," +
                            "SEXO_PROPRIETARIO = @sexo,       " +
                            "DAT_NASCIMENTO_PROPRIETARIO = @dat_nasc,  " +
                            "END_UF_PROPRIETARIO = @end_uf,         " +
                            "END_CIDADE_PROPRIETARIO = @end_cidade,      " +
                            "END_BAIRRO_PROPRIETARIO = @end_bairro,  " +
                            "END_RUA_PROPRIETARIO = @end_rua," +
                            "END_NUM_PROPRIETARIO = @end_num,                 " +
                            "COD_APARTAMENTO_PROPRIETARIO = @cod_apartamento,        " +
                            "ULTIMA_MODIFICACAO = @timestamp_criacao " +
                            "WHERE COD_PROPRIETARIO = @cod_proprietario; ";

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
                ComandosSQL.comandoSql.Parameters.AddWithValue("cod_proprietario", linhaSelecionada[0].Cells["COD_PROPRIETARIO"].Value);
                // Problema aqui nessa linha: O COD do Proprietário não fica na tabela Apartamento, mas sim em Proprietário.

                ComandosSQL.ExecutarComandoSql(cmdTxt);
                // Atualizando CPF / CNPJ do Morador
                if (pessoaFisicaRb.Checked)
                {
                    cmdTxt =    "UPDATE PROPRIETARIO_CPF SET       " +
                                "   CPF_PROPRIETARIO = @cpf        " +
                                "WHERE COD_PROPRIETARIO = @cod;    ";

                    ComandosSQL.comandoSql.Parameters.AddWithValue("cpf", cpfCnpjDesmascarado);
                    ComandosSQL.comandoSql.Parameters.AddWithValue("cod", linhaSelecionada[0].Cells["COD_PROPRIETARIO"].Value);

                }
                else
                {
                    cmdTxt = "UPDATE PROPRIETARIO_CNPJ SET          " +
                                "   CNPJ_PROPRIETARIO = @cnpj      " +
                                "WHERE COD_PROPRIETARIO = @cod;    ";

                    ComandosSQL.comandoSql.Parameters.AddWithValue("cnpj", cpfCnpjDesmascarado);
                    ComandosSQL.comandoSql.Parameters.AddWithValue("cod", linhaSelecionada[0].Cells["COD_PROPRIETARIO"].Value);
                    
                }


                ComandosSQL.ExecutarComandoSql(cmdTxt, "", "Não foi possível atualizar o CPF/CNPJ do proprietário.");

                // Adicionado contatos do proprietario


                foreach (object o in contatoList.Items)
                {
                    
                    cmdTxt = "INSERT INTO PROPRIETARIO_CONTATO(     " +
                                "   COD_PROPRIETARIO                " +
                                "  ,DSC_CONTATO                     " +
                                ") VALUES(                          " +
                                "   (SELECT COD_PROPRIETARIO FROM PROPRIETARIO WHERE NOME_PROPRIETARIO = @nome AND ULTIMA_MODIFICACAO = @timestamp_criacao)" +
                                "  ,@contato                        " +
                                ");                                 ";

                    ComandosSQL.comandoSql.Parameters.AddWithValue("nome", nomeTbox.Text);
                    ComandosSQL.comandoSql.Parameters.AddWithValue("timestamp_criacao", timestamp_criacao);
                    ComandosSQL.comandoSql.Parameters.AddWithValue("contato", o.ToString());

                    ComandosSQL.ExecutarComandoSql(cmdTxt, "");

                }
                MessageBox.Show("Proprietário atualizado com sucesso!");
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
                
                cpfCnpjPanel.Controls.Add(ucPFisica);
                ucPFisica.Show();

                ucPJuridica.Hide();
            }
            else if (pessoaJuridicaRb.Checked == true)
            {
                
                cpfCnpjPanel.Controls.Add(ucPJuridica);
                ucPJuridica.Show();

                ucPFisica.Hide();
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

                String cmdSelect = "SELECT COD_PREDIO, ID_PREDIO " +
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

        // Botão Pesquisar
        private void pesquisarBtn_Click(object sender, EventArgs e)
        {
            if (filtroTipoCoB.SelectedIndex != -1)
            {
                String cmdSelect;
                DataGridViewSelectedRowCollection linhaSelecionada = apartamentoList.SelectedRows;
                

                try
                {
                    MySqlCommand cmd = new MySqlCommand();

                    switch (filtroTipoCoB.Text)
                    {
                        case "Nome":

                            cmdSelect = "SELECT  PRO.COD_PROPRIETARIO               " +
                                               ",PRO.NOME_PROPRIETARIO              " +
                                               ",PRO.DAT_NASCIMENTO_PROPRIETARIO    " +
                                               ",PRO.SEXO_PROPRIETARIO              " +
                                               ",PRO.RG_PROPRIETARIO                " +
                                               ",COALESCE(CPF.CPF_PROPRIETARIO, 'Não possui') 'PROPRIETARIO-CPF_PROPRIETARIO'       " +
                                               ",COALESCE(CNPJ.CNPJ_PROPRIETARIO, 'Não possui') 'PROPRIETARIO-CNPJ_PROPRIETARIO'    " +
                                               ",PRO.END_UF_PROPRIETARIO        " +
                                               ",PRO.END_CIDADE_PROPRIETARIO    " +
                                               ",PRO.END_BAIRRO_PROPRIETARIO    " +
                                               ",PRO.END_RUA_PROPRIETARIO       " +
                                               ",PRO.END_NUM_PROPRIETARIO       " +
                                               ",APA.COD_APARTAMENTO 'PROPRIETARIO-COD_APARTAMENTO' " +
                                               ",APA.NUM_APARTAMENTO 'PROPRIETARIO-NUM_APARTAMENTO' " +
                                               ",PRE.COD_PREDIO 'PROPRIETARIO-COD_PREDIO'" +
                                               ",PRE.ID_PREDIO  'PROPRIETARIO-ID_PREDIO'            " +
                                               ",BLO.ID_BLOCO 'PROPRIETARIO-ID_BLOCO'               " +
                                               ",CON.ID_CONDOMINIO 'PROPRIETARIO-ID_CONDOMINIO'     " +
                                           "FROM PROPRIETARIO PRO           " +
                                           "LEFT JOIN PROPRIETARIO_CPF CPF ON CPF.COD_PROPRIETARIO = PRO.COD_PROPRIETARIO       " +
                                           "LEFT JOIN PROPRIETARIO_CNPJ CNPJ ON CNPJ.COD_PROPRIETARIO = PRO.COD_PROPRIETARIO    " +
                                           "LEFT JOIN APARTAMENTO APA ON APA.COD_APARTAMENTO = PRO.COD_APARTAMENTO_PROPRIETARIO " +
                                           "LEFT JOIN PREDIO PRE ON PRE.COD_PREDIO = APA.COD_PREDIO " +
                                           "LEFT JOIN BLOCO BLO ON BLO.COD_BLOCO = PRE.COD_BLOCO    " +
                                           "LEFT JOIN CONDOMINIO CON ON CON.COD_CONDOMINIO = BLO.COD_CONDOMINIO " +
                                           "WHERE PRO.NOME_PROPRIETARIO LIKE @nome;                ";

                            cmd.Parameters.AddWithValue("nome", filtroValorTbox.Text+"%");

                            break;

                        case "RG":
                            cmdSelect = "SELECT  PRO.COD_PROPRIETARIO               " +
                                               ",PRO.NOME_PROPRIETARIO              " +
                                               ",PRO.DAT_NASCIMENTO_PROPRIETARIO    " +
                                               ",PRO.SEXO_PROPRIETARIO              " +
                                               ",PRO.RG_PROPRIETARIO                " +
                                               ",COALESCE(CPF.CPF_PROPRIETARIO, 'Não possui') 'PROPRIETARIO-CPF_PROPRIETARIO'       " +
                                               ",COALESCE(CNPJ.CNPJ_PROPRIETARIO, 'Não possui') 'PROPRIETARIO-CNPJ_PROPRIETARIO'    " +
                                               ",PRO.END_UF_PROPRIETARIO        " +
                                               ",PRO.END_CIDADE_PROPRIETARIO    " +
                                               ",PRO.END_BAIRRO_PROPRIETARIO    " +
                                               ",PRO.END_RUA_PROPRIETARIO       " +
                                               ",PRO.END_NUM_PROPRIETARIO       " +
                                               ",APA.COD_APARTAMENTO 'PROPRIETARIO-COD_APARTAMENTO' " +
                                               ",APA.NUM_APARTAMENTO 'PROPRIETARIO-NUM_APARTAMENTO' " +
                                               ",PRE.COD_PREDIO 'PROPRIETARIO-COD_PREDIO'" +
                                               ",PRE.ID_PREDIO  'PROPRIETARIO-ID_PREDIO'            " +
                                               ",BLO.ID_BLOCO 'PROPRIETARIO-ID_BLOCO'               " +
                                               ",CON.ID_CONDOMINIO 'PROPRIETARIO-ID_CONDOMINIO'     " +
                                           "FROM PROPRIETARIO PRO           " +
                                           "LEFT JOIN PROPRIETARIO_CPF CPF ON CPF.COD_PROPRIETARIO = PRO.COD_PROPRIETARIO       " +
                                           "LEFT JOIN PROPRIETARIO_CNPJ CNPJ ON CNPJ.COD_PROPRIETARIO = PRO.COD_PROPRIETARIO    " +
                                           "LEFT JOIN APARTAMENTO APA ON APA.COD_APARTAMENTO = PRO.COD_APARTAMENTO_PROPRIETARIO " +
                                           "LEFT JOIN PREDIO PRE ON PRE.COD_PREDIO = APA.COD_PREDIO " +
                                           "LEFT JOIN BLOCO BLO ON BLO.COD_BLOCO = PRE.COD_BLOCO    " +
                                           "LEFT JOIN CONDOMINIO CON ON CON.COD_CONDOMINIO = BLO.COD_CONDOMINIO " +
                                           "WHERE PRO.RG_PROPRIETARIO = @rg;                ";
                            rgTbox.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                            cmd.Parameters.AddWithValue("rg", filtroValorTbox.Text);
                            
                            break;

                        case "CPF":
                            cmdSelect = "SELECT  PRO.COD_PROPRIETARIO               " +
                                               ",PRO.NOME_PROPRIETARIO              " +
                                               ",PRO.DAT_NASCIMENTO_PROPRIETARIO    " +
                                               ",PRO.SEXO_PROPRIETARIO              " +
                                               ",PRO.RG_PROPRIETARIO                " +
                                               ",COALESCE(CPF.CPF_PROPRIETARIO, 'Não possui') 'PROPRIETARIO-CPF_PROPRIETARIO'       " +
                                               ",COALESCE(CNPJ.CNPJ_PROPRIETARIO, 'Não possui') 'PROPRIETARIO-CNPJ_PROPRIETARIO'    " +
                                               ",PRO.END_UF_PROPRIETARIO        " +
                                               ",PRO.END_CIDADE_PROPRIETARIO    " +
                                               ",PRO.END_BAIRRO_PROPRIETARIO    " +
                                               ",PRO.END_RUA_PROPRIETARIO       " +
                                               ",PRO.END_NUM_PROPRIETARIO       " +
                                               ",APA.COD_APARTAMENTO 'PROPRIETARIO-COD_APARTAMENTO' " +
                                               ",APA.NUM_APARTAMENTO 'PROPRIETARIO-NUM_APARTAMENTO' " +
                                               ",PRE.COD_PREDIO 'PROPRIETARIO-COD_PREDIO'" +
                                               ",PRE.ID_PREDIO  'PROPRIETARIO-ID_PREDIO'            " +
                                               ",BLO.ID_BLOCO 'PROPRIETARIO-ID_BLOCO'               " +
                                               ",CON.ID_CONDOMINIO 'PROPRIETARIO-ID_CONDOMINIO'     " +
                                           "FROM PROPRIETARIO PRO           " +
                                           "LEFT JOIN PROPRIETARIO_CPF CPF ON CPF.COD_PROPRIETARIO = PRO.COD_PROPRIETARIO       " +
                                           "LEFT JOIN PROPRIETARIO_CNPJ CNPJ ON CNPJ.COD_PROPRIETARIO = PRO.COD_PROPRIETARIO    " +
                                           "LEFT JOIN APARTAMENTO APA ON APA.COD_APARTAMENTO = PRO.COD_APARTAMENTO_PROPRIETARIO " +
                                           "LEFT JOIN PREDIO PRE ON PRE.COD_PREDIO = APA.COD_PREDIO " +
                                           "LEFT JOIN BLOCO BLO ON BLO.COD_BLOCO = PRE.COD_BLOCO    " +
                                           "LEFT JOIN CONDOMINIO CON ON CON.COD_CONDOMINIO = BLO.COD_CONDOMINIO " +
                                           "WHERE CPF.CPF_PROPRIETARIO = @cpf;                ";
                            cmd.Parameters.AddWithValue("cpf", filtroValorTbox.Text);
                            break;

                        case "CNPJ":
                            cmdSelect = "SELECT  PRO.COD_PROPRIETARIO               " +
                                               ",PRO.NOME_PROPRIETARIO              " +
                                               ",PRO.DAT_NASCIMENTO_PROPRIETARIO    " +
                                               ",PRO.SEXO_PROPRIETARIO              " +
                                               ",PRO.RG_PROPRIETARIO                " +
                                               ",COALESCE(CPF.CPF_PROPRIETARIO, 'Não possui') 'PROPRIETARIO-CPF_PROPRIETARIO'       " +
                                               ",COALESCE(CNPJ.CNPJ_PROPRIETARIO, 'Não possui') 'PROPRIETARIO-CNPJ_PROPRIETARIO'    " +
                                               ",PRO.END_UF_PROPRIETARIO        " +
                                               ",PRO.END_CIDADE_PROPRIETARIO    " +
                                               ",PRO.END_BAIRRO_PROPRIETARIO    " +
                                               ",PRO.END_RUA_PROPRIETARIO       " +
                                               ",PRO.END_NUM_PROPRIETARIO       " +
                                               ",APA.COD_APARTAMENTO 'PROPRIETARIO-COD_APARTAMENTO' " +
                                               ",APA.NUM_APARTAMENTO 'PROPRIETARIO-NUM_APARTAMENTO' " +
                                               ",PRE.COD_PREDIO 'PROPRIETARIO-COD_PREDIO'" +
                                               ",PRE.ID_PREDIO  'PROPRIETARIO-ID_PREDIO'            " +
                                               ",BLO.ID_BLOCO 'PROPRIETARIO-ID_BLOCO'               " +
                                               ",CON.ID_CONDOMINIO 'PROPRIETARIO-ID_CONDOMINIO'     " +
                                           "FROM PROPRIETARIO PRO           " +
                                           "LEFT JOIN PROPRIETARIO_CPF CPF ON CPF.COD_PROPRIETARIO = PRO.COD_PROPRIETARIO       " +
                                           "LEFT JOIN PROPRIETARIO_CNPJ CNPJ ON CNPJ.COD_PROPRIETARIO = PRO.COD_PROPRIETARIO    " +
                                           "LEFT JOIN APARTAMENTO APA ON APA.COD_APARTAMENTO = PRO.COD_APARTAMENTO_PROPRIETARIO " +
                                           "LEFT JOIN PREDIO PRE ON PRE.COD_PREDIO = APA.COD_PREDIO " +
                                           "LEFT JOIN BLOCO BLO ON BLO.COD_BLOCO = PRE.COD_BLOCO    " +
                                           "LEFT JOIN CONDOMINIO CON ON CON.COD_CONDOMINIO = BLO.COD_CONDOMINIO " +
                                           "WHERE CNPJ.CNPJ_PROPRIETARIO = @cnpj;                ";
                            cmd.Parameters.AddWithValue("cnpj", filtroValorTbox.Text);
                            break;

                        default:
                            cmdSelect = "";
                            MessageBox.Show("Um tipo de filtro e um valor devem ser inseridos para fazer a pesquisa.");
                            break;
                    }

                    ComandosSQL.conn = new MySqlConnection(ComandosSQL.str);
                    ComandosSQL.conn.Open();

                    //
                    cmd.CommandText = cmdSelect;
                    cmd.Connection = ComandosSQL.conn;


                    // lista pesquisa
                    pesquisaList.Rows.Clear();

                    cmd.Prepare();

                    using (MySqlDataReader leitor = cmd.ExecuteReader())
                    {
                        while (leitor.Read())
                        {
                            int index = pesquisaList.Rows.Add();
                            DataGridViewRow linhaTabela = pesquisaList.Rows[index];
                            linhaTabela.Cells["P_COD_PROPRIETARIO"].Value = Convert.ToInt32(leitor["COD_PROPRIETARIO"]);
                            linhaTabela.Cells["P_NOME_PROPRIETARIO"].Value = leitor["NOME_PROPRIETARIO"];
                            linhaTabela.Cells["P_DAT_NASCIMENTO_PROPRIETARIO"].Value = Convert.ToDateTime(leitor["DAT_NASCIMENTO_PROPRIETARIO"]).ToShortDateString();
                            linhaTabela.Cells["P_SEXO_PROPRIETARIO"].Value = leitor["SEXO_PROPRIETARIO"];
                            linhaTabela.Cells["P_RG_PROPRIETARIO"].Value = leitor["RG_PROPRIETARIO"];
                            linhaTabela.Cells["P_CPF_PROPRIETARIO"].Value = leitor["PROPRIETARIO-CPF_PROPRIETARIO"];
                            linhaTabela.Cells["P_CNPJ_PROPRIETARIO"].Value = leitor["PROPRIETARIO-CNPJ_PROPRIETARIO"];
                            linhaTabela.Cells["P_END_UF_PROPRIETARIO"].Value = leitor["END_UF_PROPRIETARIO"];
                            linhaTabela.Cells["P_END_CIDADE_PROPRIETARIO"].Value = leitor["END_CIDADE_PROPRIETARIO"];
                            linhaTabela.Cells["P_END_BAIRRO_PROPRIETARIO"].Value = leitor["END_BAIRRO_PROPRIETARIO"];
                            linhaTabela.Cells["P_END_RUA_PROPRIETARIO"].Value = leitor["END_RUA_PROPRIETARIO"];
                            linhaTabela.Cells["P_END_NUM_PROPRIETARIO"].Value = leitor["END_NUM_PROPRIETARIO"];
                            linhaTabela.Cells["P_COD_APARTAMENTO"].Value = leitor["PROPRIETARIO-COD_APARTAMENTO"];
                            linhaTabela.Cells["P_NUM_APARTAMENTO"].Value = leitor["PROPRIETARIO-NUM_APARTAMENTO"];
                            linhaTabela.Cells["P_COD_PREDIO"].Value = leitor["PROPRIETARIO-COD_PREDIO"];
                            linhaTabela.Cells["P_ID_PREDIO"].Value = leitor["PROPRIETARIO-ID_PREDIO"];
                            linhaTabela.Cells["P_ID_BLOCO"].Value = leitor["PROPRIETARIO-ID_BLOCO"];
                            linhaTabela.Cells["P_ID_CONDOMINIO"].Value = leitor["PROPRIETARIO-ID_CONDOMINIO"];


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

        private void apagarBtn_Click(object sender, EventArgs e)
        {
            nomeTbox.Clear();
            sexoMRBtn.Checked = true;
            datanascimentoDtp.Value = DateTime.Now;
            rgTbox.Clear();
            pessoaFisicaRb.Checked = true;
            ucPFisica.Controls["cpfTbox"].Text = "";
            ucPJuridica.Controls["cnpjTbox"].Text = "";
            estadoCBox.SelectedIndex = -1;
            cidadeTBox.Clear();
            bairroTbox.Clear();
            ruaTBox.Clear();
            localNumeroNud.Value = 0;
            numeroestacionamentoNud.Value = 0;
            contatoList.Items.Clear();
            tipoContatoCB.SelectedIndex = -1;
            contatoTbox.Clear();
            apartamentoList.Rows.Clear();
            AtualizarLocalizacao();

            DataGridViewSelectedRowCollection linhaSelecionada = pesquisaList.SelectedRows;

            if (linhaSelecionada[0].Cells["P_CPF_PROPRIETARIO"].Value.ToString() != "Não possui")
            {
                ComandosSQL.ExecutarComandoSql("DELETE FROM PROPRIETARIO_CPF WHERE COD_PROPRIETARIO = " + linhaSelecionada[0].Cells["P_COD_PROPRIETARIO"].Value + ";");
            }
            else
            {
                ComandosSQL.ExecutarComandoSql("DELETE FROM PROPRIETARIO_CNPJ WHERE COD_PROPRIETARIO = " + linhaSelecionada[0].Cells["P_COD_PROPRIETARIO"].Value + ";");
            }
            ComandosSQL.ExecutarComandoSql("DELETE FROM PROPRIETARIO_CONTATO WHERE COD_PROPRIETARIO = " + linhaSelecionada[0].Cells["P_COD_PROPRIETARIO"].Value + ";");
            ComandosSQL.ExecutarComandoSql("DELETE FROM PROPRIETARIO WHERE COD_PROPRIETARIO = " + linhaSelecionada[0].Cells["P_COD_PROPRIETARIO"].Value + ";");

            pesquisaList.Rows.Remove(linhaSelecionada[0]);
            MessageBox.Show("Proprietário removido com sucesso!");
        }

        // Comando ao clicar no botão Editar
        private void pesquisaList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewSelectedRowCollection linhaSelecionada = pesquisaList.SelectedRows;

            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                nomeTbox.Text = pesquisaList["P_NOME_PROPRIETARIO", e.RowIndex].Value.ToString();
                if (pesquisaList["P_SEXO_PROPRIETARIO", e.RowIndex].Value.ToString() == "M")
                {
                    sexoMRBtn.Checked = true;
                }
                else
                {
                    sexoFRBtn.Checked = true;
                }
                datanascimentoDtp.Value = Convert.ToDateTime(pesquisaList["P_DAT_NASCIMENTO_PROPRIETARIO", e.RowIndex].Value.ToString());
                rgTbox.Text = pesquisaList["P_RG_PROPRIETARIO", e.RowIndex].Value.ToString();
                if (pesquisaList["P_CPF_PROPRIETARIO", e.RowIndex].Value.ToString() == "Não possui")
                {
                    pessoaJuridicaRb.Checked = true;
                    ucPJuridica.Controls["cnpjTbox"].Text = pesquisaList["P_CNPJ_PROPRIETARIO", e.RowIndex].Value.ToString();
                    
                }
                else if (pesquisaList["P_CNPJ_PROPRIETARIO", e.RowIndex].Value.ToString() == "Não possui")
                {
                    pessoaFisicaRb.Checked = true;
                    ucPFisica.Controls["cpfTbox"].Text = pesquisaList["P_CPF_PROPRIETARIO", e.RowIndex].Value.ToString();

                }
                // Selecionando o Estado correto
                int index = 0;
                foreach (object o in estadoCBox.Items)
                {
                    index++;
                    if (o.ToString() == pesquisaList["P_END_UF_PROPRIETARIO", e.RowIndex].Value.ToString())
                    {
                        estadoCBox.SelectedIndex = index;
                        estadoCBox.Text = pesquisaList["P_END_UF_PROPRIETARIO", e.RowIndex].Value.ToString();
                    }
                }
                cidadeTBox.Text = pesquisaList["P_END_CIDADE_PROPRIETARIO", e.RowIndex].Value.ToString();
                bairroTbox.Text = pesquisaList["P_END_BAIRRO_PROPRIETARIO", e.RowIndex].Value.ToString();
                ruaTBox.Text = pesquisaList["P_END_RUA_PROPRIETARIO", e.RowIndex].Value.ToString();
                localNumeroNud.Value = Convert.ToInt32(pesquisaList["P_END_NUM_PROPRIETARIO", e.RowIndex].Value.ToString());

                // Colocando os Contatos na List
                try
                {
                    ComandosSQL.conn = new MySqlConnection(ComandosSQL.str);
                    ComandosSQL.conn.Open();

                    String cmdSelect =  "SELECT DSC_CONTATO             " +
                                        "FROM PROPRIETARIO_CONTATO      " +
                                        "WHERE COD_PROPRIETARIO = @cod; ";
                    MySqlCommand cmd = new MySqlCommand(cmdSelect, ComandosSQL.conn);
                    cmd.Parameters.AddWithValue("cod", linhaSelecionada[0].Cells["P_COD_PROPRIETARIO"].Value);

                    // Lista Pesquisa
                    contatoList.Items.Clear();

                    cmd.Prepare();

                    // Adicionando cada um dos meios de contato à lista
                    using (MySqlDataReader leitor = cmd.ExecuteReader())
                    {
                        index = 0;
                        while (leitor.Read())
                        {
                            contatoList.Items.Add(leitor["DSC_CONTATO"].ToString());
                            
                        }
                    }

                }
                catch (Exception excessao)
                {
                    MessageBox.Show("Um erro ocorreu ao tentar ler o banco de dados. \nDescrição: " + excessao.Message);
                }

                ComandosSQL.conn.Close();

                // Auto selecionando o Prédio e Apartamento do Proprietário
                predioList.Update();
                for (index = 0; index < predioList.Rows.Count; index++)
                {

                    if (Convert.ToInt32(linhaSelecionada[0].Cells["P_COD_PREDIO"].Value) == Convert.ToInt32(predioList.Rows[index].Cells["COD_PREDIO"].Value))
                    {
                        predioList.Rows[index].Selected = true;
                        
                        break;
                    }
                }
                
                predioList_RowEnter(null, new DataGridViewCellEventArgs(linhaSelecionada[0].Index, Convert.ToInt32(linhaSelecionada[0].Cells["P_COD_PREDIO"].Value)));

                for (index = 0; index < apartamentoList.Rows.Count; index++)
                {
                    if (Convert.ToInt32(linhaSelecionada[0].Cells["P_COD_APARTAMENTO"].Value) == Convert.ToInt32(apartamentoList.Rows[index].Cells["COD_APARTAMENTO"].Value))
                    {
                        apartamentoList.Rows[index].Selected = true;

                        break;
                    }
                }
                
            }
        }
    }
}
