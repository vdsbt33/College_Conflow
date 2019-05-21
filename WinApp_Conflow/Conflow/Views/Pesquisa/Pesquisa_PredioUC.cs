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
    public partial class Pesquisa_PredioUC : UserControl
    {
        AtalhosSQL ComandosSQL = new AtalhosSQL();

        public Pesquisa_PredioUC()
        {
            InitializeComponent();
        }

        private void pesquisarBtn_Click(object sender, EventArgs e)
        {
            if (filtroTipoCoB.SelectedIndex != -1)
            {
                String cmdSelect;

                try
                {
                    MySqlCommand cmd = new MySqlCommand();

                    cmdSelect = "SELECT PRE.COD_PREDIO, PRE.ID_PREDIO, BLO.COD_BLOCO, BLO.ID_BLOCO, CON.COD_CONDOMINIO, CON.ID_CONDOMINIO, (SELECT COUNT(APA.COD_APARTAMENTO) FROM APARTAMENTO APA WHERE APA.COD_PREDIO = PRE.COD_PREDIO) AS QTD_APARTAMENTOS " +
                                "FROM PREDIO PRE " +
                                "LEFT JOIN BLOCO BLO ON PRE.COD_BLOCO = BLO.COD_BLOCO " +
                                "LEFT JOIN CONDOMINIO CON ON BLO.COD_CONDOMINIO = CON.COD_CONDOMINIO ";

                    switch (filtroTipoCoB.Text)
                    {

                        case "Identificador":
                            // Seleciona o bloco e seus dados
                            cmdSelect += "WHERE PRE.ID_PREDIO LIKE @nome; ";

                            cmd.Parameters.AddWithValue("nome", filtroValorTbox.Text + "%");

                            break;
                        case "Bloco que percence":
                            // Seleciona o bloco e seus dados
                            cmdSelect += "WHERE BLO.ID_BLOCO LIKE @nome; ";

                            cmd.Parameters.AddWithValue("nome", filtroValorTbox.Text + "%");

                            break;
                        case "Condomínio que pertence":
                            // Seleciona o bloco e seus dados
                            cmdSelect += "WHERE CON.ID_CONDOMINIO LIKE @nome; ";

                            cmd.Parameters.AddWithValue("nome", filtroValorTbox.Text + "%");

                            break;

                        default:
                            cmdSelect = "";
                            MessageBox.Show("Um tipo de filtro e um valor devem ser inseridos para fazer a pesquisa.");
                            break;
                    };

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
                                linhaTabela.Cells["P_COD_PREDIO"].Value = Convert.ToInt32(leitor["COD_PREDIO"]);
                                linhaTabela.Cells["P_ID_PREDIO"].Value = leitor["ID_PREDIO"];
                                linhaTabela.Cells["P_COD_BLOCO"].Value = Convert.ToInt32(leitor["COD_BLOCO"]);
                                linhaTabela.Cells["P_ID_BLOCO"].Value = leitor["ID_BLOCO"];
                                linhaTabela.Cells["P_COD_CONDOMINIO"].Value = Convert.ToInt32(leitor["COD_CONDOMINIO"]);
                                linhaTabela.Cells["P_ID_CONDOMINIO"].Value = leitor["ID_CONDOMINIO"];
                                linhaTabela.Cells["P_QTD_APARTAMENTOS"].Value = leitor["QTD_APARTAMENTOS"];
                                

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

        private void pesquisaList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                DataGridViewSelectedRowCollection linhaSelecionada = pesquisaList.SelectedRows;

                if (Convert.ToInt32(linhaSelecionada[0].Cells["P_QTD_APARTAMENTOS"].Value) > 0)
                {
                    if (MessageBox.Show("Deseja remover o Prédio e todos seus Apartamentos?", "", MessageBoxButtons.YesNo) == DialogResult.Yes) { 


                        ComandosSQL.ExecutarComandoSql("DELETE FROM APARTAMENTO WHERE COD_PREDIO = " + linhaSelecionada[0].Cells["P_COD_PREDIO"].Value + ";");
                        ComandosSQL.ExecutarComandoSql("DELETE FROM PREDIO WHERE COD_PREDIO = " + linhaSelecionada[0].Cells["P_COD_PREDIO"].Value + ";");

                        pesquisaList.Rows.Remove(linhaSelecionada[0]);
                        MessageBox.Show("Proprietário removido com sucesso!");
                    }
                }

            }

        }
    }
}

