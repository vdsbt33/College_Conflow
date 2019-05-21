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
    Classe: Pesquisa_CondominioUC
    Descrição: Contém os métodos do user control Pesquisa_CondominioUC.
    */
    public partial class Pesquisa_CondominioUC : UserControl
    {
        AtalhosSQL ComandosSQL = new AtalhosSQL();

        /*
        Construtor: Pesquisa_CondominioUC()
        Descrição: -.
        */
        public Pesquisa_CondominioUC()
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

                    cmdSelect = "SELECT CON.COD_CONDOMINIO, CON.ID_CONDOMINIO, (SELECT COUNT(BLO.COD_CONDOMINIO) FROM BLOCO BLO WHERE BLO.COD_CONDOMINIO = CON.COD_CONDOMINIO) AS QTD_BLOCOS " +
                                "FROM CONDOMINIO CON ";

                    switch (filtroTipoCoB.Text)
                    {

                        case "Identificador":
                            // Seleciona o proprietário e seus dados
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
                                linhaTabela.Cells["P_COD_CONDOMINIO"].Value = Convert.ToInt32(leitor["COD_CONDOMINIO"]);
                                linhaTabela.Cells["P_ID_CONDOMINIO"].Value = leitor["ID_CONDOMINIO"];
                                linhaTabela.Cells["P_QTD_BLOCOS"].Value = Convert.ToInt32(leitor["QTD_BLOCOS"]);


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

                if (Convert.ToInt32(linhaSelecionada[0].Cells["P_QTD_BLOCOS"].Value) > 0)
                {
                    MessageBox.Show("Antes de remover o Condomínio, é necessário remover seus Blocos.");
                }
                else
                {
                    ComandosSQL.ExecutarComandoSql("DELETE FROM CONDOMINIO WHERE COD_CONDOMINIO = " + linhaSelecionada[0].Cells["P_COD_CONDOMINIO"].Value + ";");

                    pesquisaList.Rows.Remove(linhaSelecionada[0]);
                    MessageBox.Show("Proprietário removido com sucesso!");
                }
                
            }
        }


    }
}
