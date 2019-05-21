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

namespace Conflow.Views
{
    public partial class CotaCondominialUC : UserControl
    {
        public CotaCondominialUC()
        {
            InitializeComponent();
            
        }

        AtalhosSQL ComandosSQL = new AtalhosSQL();

        private void pesquisarBtn_Click(object sender, EventArgs e)
        {
            
            if (filtroTipoCoB.SelectedIndex != -1)
            {
                String cmdSelect;
                DataGridViewSelectedRowCollection linhaSelecionada = pesquisaList.SelectedRows;


                try
                {
                    MySqlCommand cmd = new MySqlCommand();

                    switch (filtroTipoCoB.Text)
                    {
                        case "Nome":
                            // Seleciona o proprietário e seus dados
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

                            cmd.Parameters.AddWithValue("nome", filtroValorTbox.Text + "%");

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

                    ComandosSQL.conn = new MySqlConnection(AtalhosSQL.str);
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
                            // Lê o DB e salva os dados na DataGridView
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

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex == 0)
            {

            }
        }

        
    }
}
