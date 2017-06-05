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
    public partial class Cadastro_PredioUC : UserControl
    {
        public Cadastro_PredioUC()
        {
            InitializeComponent();
        }
        
        AtalhosSQL ComandosSQL = new AtalhosSQL();

        public List<Int32> dadosCodsCondominio = new List<Int32>();
        
        private void CriarBtn_Click(object sender, EventArgs e)
        {
            String timestamp_criacao = ComandosSQL.current_timestamp;


            DataGridViewSelectedRowCollection linhaSelecionada = blocoList.SelectedRows;

            if (identificadorTbox.Text.Length > 0)
            {

                String cmdTxt = "INSERT INTO PREDIO(                " +
                                "    ID_PREDIO,                     " +
                                "    COD_BLOCO,                     " +
                                "    ULTIMA_MODIFICACAO             " +
                                ") VALUES(                          " +
                                "    @id                            " +
                                "   ,@cod                           " +
                                "   ,@ult_mod                       " +
                                ");                                 ";

                ComandosSQL.comandoSql.Parameters.AddWithValue("id", identificadorTbox.Text);
                ComandosSQL.comandoSql.Parameters.AddWithValue("cod", linhaSelecionada[0].Cells["COD_BLOCO"].Value);
                ComandosSQL.comandoSql.Parameters.AddWithValue("ult_mod", timestamp_criacao);

                ComandosSQL.ExecutarComandoSql(cmdTxt, "Novo prédio adicionado com sucesso!", "Não foi possível adicionar o prédio.");


                // Inserindo apartamentos no prédio
                int num_apartamento = 0;
                int num_andar = 0;
                for (int contador = 0; num_apartamento != qtdAPAndarNud.Value && num_andar != qtdAndaresNud.Value; contador++)
                {

                    num_apartamento++;


                    cmdTxt =    "INSERT INTO APARTAMENTO(          " +
                                "    COD_PREDIO             " +
                                "   ,NUM_APARTAMENTO        " +
                                ") VALUES (                 " +
                                "   (SELECT COD_PREDIO FROM PREDIO WHERE ID_PREDIO = '" + identificadorTbox.Text + "' AND ULTIMA_MODIFICACAO = '" + timestamp_criacao + "' )" +
                                "   ,'" + (num_apartamento + (num_andar * 10)) + "' " +
                                ");                         ";

                    if (num_apartamento == qtdAPAndarNud.Value && num_andar < qtdAndaresNud.Value)
                    {
                        num_apartamento = 0;
                        num_andar++;
                    }

                    ComandosSQL.ExecutarComandoSql(cmdTxt);
                }
            }
            else
            {
                MessageBox.Show("Erro: Um ou mais campos não foram preenchidos.");
            }
            
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
                blocoList.Rows.Clear();

                String cmdSelect =      "SELECT BLO.COD_BLOCO, BLO.ID_BLOCO, BLO.COD_CONDOMINIO 'CONDOMINIO', CON.ID_CONDOMINIO " +
                                        "FROM BLOCO BLO " +
                                        "LEFT JOIN CONDOMINIO CON ON CON.COD_CONDOMINIO = BLO.COD_CONDOMINIO; ";
                MySqlCommand cmd = new MySqlCommand(cmdSelect, ComandosSQL.conn);
                cmd.Prepare();
                using (MySqlDataReader leitor = cmd.ExecuteReader())
                {
                    while (leitor.Read())
                    {
                        int index = blocoList.Rows.Add();
                        DataGridViewRow linhaTabela = blocoList.Rows[index];
                        linhaTabela.Cells["COD_BLOCO"].Value = leitor["COD_BLOCO"];
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
