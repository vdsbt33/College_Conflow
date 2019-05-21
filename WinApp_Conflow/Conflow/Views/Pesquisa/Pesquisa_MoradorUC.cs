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
    /*
    Classe: Pesquisa_MoradorUC
    Descrição: Contém os métodos do user control Pesquisa_MoradorUC.
    */
    public partial class Pesquisa_MoradorUC : UserControl
    {
        AtalhosSQL ComandosSQL = new AtalhosSQL();

        /*
        Construtor: Pesquisa_MoradorUC()
        Descrição: -.
        */
        public Pesquisa_MoradorUC()
        {
            InitializeComponent();
        }

        /*
        Função: AtualizarLocalizacao()
        Descrição: Atualiza as listas do grupo Localização.
        */
        public void AtualizarLocalizacao()
        {
            try
            {
                nomeTbox.Focus();

                ComandosSQL.conn = new MySqlConnection(AtalhosSQL.str);
                ComandosSQL.conn.Open();

                // Limpando listas
                condominioList.Rows.Clear();
                predioList.Rows.Clear();
                apartamentoList.Rows.Clear();

                String cmdSelect = "SELECT COD_CONDOMINIO, ID_CONDOMINIO " +
                                    "FROM CONDOMINIO;";

                MySqlCommand cmd = new MySqlCommand(cmdSelect, ComandosSQL.conn);
                cmd.Prepare();
                using (MySqlDataReader leitor = cmd.ExecuteReader())
                {
                    while (leitor.Read())
                    {
                        int index = condominioList.Rows.Add();
                        DataGridViewRow linhaTabela = condominioList.Rows[index];
                        linhaTabela.Cells["COD_CONDOMINIO"].Value = Convert.ToInt32(leitor["COD_CONDOMINIO"]);
                        linhaTabela.Cells["ID_CONDOMINIO"].Value = leitor["ID_CONDOMINIO"];
                    }
                }

            }
            catch (Exception excessao)
            {
                MessageBox.Show("Um erro ocorreu ao tentar ler o banco de dados. \nDescrição: " + excessao.Message);
            }

            ComandosSQL.conn.Close();
        }

        // Botão Pesquisar
        private void pesquisarBtn_Click(object sender, EventArgs e)
        {
            if (filtroTipoCoB.SelectedIndex != -1)
            {
                String cmdSelect;

                try
                {
                    MySqlCommand cmd = new MySqlCommand();

                    cmdSelect = "SELECT MOR.COD_MORADOR, MOR.NOME_MORADOR, MOR.DAT_NASCIMENTO_MORADOR, MOR.DAT_NASCIMENTO_MORADOR, MOR.SEXO_MORADOR, MOR.COD_APARTAMENTO_MORADOR, APA.NUM_APARTAMENTO, PRE.COD_PREDIO, PRE.ID_PREDIO, BLO.ID_BLOCO, CON.ID_CONDOMINIO " +
                                "FROM MORADOR MOR " +
                                "LEFT JOIN APARTAMENTO APA ON APA.COD_APARTAMENTO = MOR.COD_APARTAMENTO_MORADOR " +
                                "LEFT JOIN PREDIO PRE ON PRE.COD_PREDIO = APA.COD_PREDIO " +
                                "LEFT JOIN BLOCO BLO ON BLO.COD_BLOCO = PRE.COD_BLOCO " +
                                "LEFT JOIN CONDOMINIO CON ON CON.COD_CONDOMINIO = BLO.COD_CONDOMINIO ";



                    switch (filtroTipoCoB.Text)
                    {

                        case "Nome":
                            // Seleciona o proprietário e seus dados
                            cmdSelect += "WHERE MOR.NOME_MORADOR LIKE @nome; ";

                            cmd.Parameters.AddWithValue("nome", filtroValorTbox.Text + "%");

                            break;

                        default:
                            cmdSelect = "";
                            MessageBox.Show("Um tipo de filtro e um valor devem ser inseridos para fazer a pesquisa.");
                            break;
                    }

                    if (cmdSelect != "")
                    {
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
                                linhaTabela.Cells["P_COD_MORADOR"].Value = Convert.ToInt32(leitor["COD_MORADOR"]);
                                linhaTabela.Cells["P_NOME_MORADOR"].Value = leitor["NOME_MORADOR"];
                                linhaTabela.Cells["P_DAT_NASCIMENTO_MORADOR"].Value = Convert.ToDateTime(leitor["DAT_NASCIMENTO_MORADOR"]).ToShortDateString();
                                linhaTabela.Cells["P_SEXO_MORADOR"].Value = leitor["SEXO_MORADOR"];
                                linhaTabela.Cells["P_COD_APARTAMENTO_MORADOR"].Value = Convert.ToInt32(leitor["COD_APARTAMENTO_MORADOR"]);
                                linhaTabela.Cells["P_NUM_APARTAMENTO"].Value = Convert.ToInt32(leitor["NUM_APARTAMENTO"]);
                                linhaTabela.Cells["P_COD_PREDIO"].Value = Convert.ToInt32(leitor["COD_PREDIO"]);
                                linhaTabela.Cells["P_ID_PREDIO"].Value = leitor["ID_PREDIO"];
                                linhaTabela.Cells["P_ID_BLOCO"].Value = leitor["ID_BLOCO"];
                                linhaTabela.Cells["P_ID_CONDOMINIO"].Value = leitor["ID_CONDOMINIO"];

                            }
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

        /*
        Função: condominioList_RowEnter()
        Descrição: Atualiza a lista de Prédios ao trocar o Condomínio selectionado.
        */
        private void condominioList_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (condominioList.SelectedRows.Count > 0)
            {

                try
                {
                    ComandosSQL.conn = new MySqlConnection(AtalhosSQL.str);
                    ComandosSQL.conn.Open();

                    // Limpando listas
                    predioList.Rows.Clear();
                    apartamentoList.Rows.Clear();

                    String cmdSelect = "SELECT PRE.COD_PREDIO, PRE.ID_PREDIO " +
                                       "FROM PREDIO PRE " +
                                       "LEFT JOIN BLOCO BLO ON PRE.COD_BLOCO = BLO.COD_BLOCO " +
                                       "LEFT JOIN CONDOMINIO CON ON BLO.COD_CONDOMINIO = CON.COD_CONDOMINIO " +
                                       "WHERE CON.COD_CONDOMINIO = @cod;";

                    MySqlCommand cmd = new MySqlCommand(cmdSelect, ComandosSQL.conn);

                    DataGridViewSelectedRowCollection linhaSelecionada = condominioList.SelectedRows;

                    cmd.Parameters.AddWithValue("cod", Convert.ToInt32(linhaSelecionada[0].Cells["COD_CONDOMINIO"].Value));


                    cmd.Prepare();
                    using (MySqlDataReader leitor = cmd.ExecuteReader())
                    {
                        while (leitor.Read())
                        {

                            int index = predioList.Rows.Add();
                            DataGridViewRow linhaTabela = predioList.Rows[index];
                            linhaTabela.Cells["COD_PREDIO"].Value = Convert.ToInt32(leitor["COD_PREDIO"]);
                            linhaTabela.Cells["ID_PREDIO"].Value = Convert.ToString(leitor["ID_PREDIO"]);
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

        /*
        Função: predioList_RowEnter()
        Descrição: Atualiza a lista de Apartamentos ao trocar o Prédio selecionado.
        */
        private void predioList_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (predioList.SelectedRows.Count > 0)
            {

                try
                {
                    ComandosSQL.conn = new MySqlConnection(AtalhosSQL.str);
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
