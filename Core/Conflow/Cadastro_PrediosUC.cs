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
    public partial class Cadastro_PrediosUC : UserControl
    {
        public Cadastro_PrediosUC()
        {
            InitializeComponent();
        }
        
        AtalhosSQL ComandosSQL = new AtalhosSQL();

        public List<Int32> dadosCodsCondominio = new List<Int32>();
        public List<Int32> dadosCodsBloco = new List<int>();
        
        private void CriarBtn_Click(object sender, EventArgs e)
        {
            String timestamp_criacao = ComandosSQL.current_timestamp;

            MessageBox.Show("Qtd bloco list: " + blocoList.Items.Count + "dadosCodsBloco: " + dadosCodsBloco.Count);

            if (identificadorTbox.Text.Length > 0 && valorMensalidadeNud.Value > 0 && blocoList.SelectedIndex != -1)
            {
                
                String cmdTxt = "INSERT INTO PREDIO(                " +
                                "    ID_PREDIO,                     " +
                                "    VAL_MENSALIDADES_PREDIO,       " +
                                "    COD_BLOCO,                     " +
                                "    ULTIMA_MODIFICACAO             " +
                                ") VALUES(                          " +
                                "    '" + identificadorTbox.Text + "', " +
                                "    " + Convert.ToSingle(valorMensalidadeNud.Value)         + ", " +
                                "    " + dadosCodsBloco[blocoList.SelectedIndex]             + ", " +
                                "    '" + timestamp_criacao                                  + "' " +
                                ");                                 ";

                ComandosSQL.ExecutarComandoSql(cmdTxt, "Novo prédio adicionado com sucesso!", "Não foi possível adicionar o prédio.");

                // Inserindo apartamentos no prédio
                cmdTxt = "INSERT INTO APARTAMENTO(          " +
                                "    COD_PREDIO             " +
                                ") VALUES (                 " +
                                "    (SELECT COD_PREDIO FROM PREDIO WHERE ID_PREDIO = '" + identificadorTbox.Text + "' AND ULTIMA_MODIFICACAO = '" + timestamp_criacao + "' )" +
                                ");                         ";
                
                for (int contador = 0; contador < (int) qtdApartamentosNud.Value; contador++)
                {
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

            ComandosSQL.conn = new MySqlConnection(ComandosSQL.str);
            ComandosSQL.conn.Open();

            // Condominios
            condominioList.Items.Clear();
            

            String cmdSelect = "SELECT COD_CONDOMINIO, ID_CONDOMINIO FROM CONDOMINIO";
            MySqlCommand cmd = new MySqlCommand(cmdSelect, ComandosSQL.conn);
            cmd.Prepare();
            using (MySqlDataReader leitor = cmd.ExecuteReader())
            {
                while (leitor.Read())
                {
                    condominioList.Items.Add(String.Format("{0}", leitor["ID_CONDOMINIO"]));
                    dadosCodsCondominio.Add(Convert.ToInt32(leitor["COD_CONDOMINIO"]));
                }
            }

            dadosCodsBloco.Clear();
            blocoList.Items.Clear();
            AtualizarBlocos();
        }

        public void AtualizarBlocos()
        {
            // Blocos
            blocoList.Items.Clear();
            dadosCodsBloco.Clear();

            String cmdSelect = "SELECT BLO.COD_BLOCO 'BLO_COD_BLOCO', BLO.ID_BLOCO, BLO.COD_CONDOMINIO 'BLO-COD_CONDOMINIO' FROM BLOCO BLO, CONDOMINIO CON WHERE BLO.COD_CONDOMINIO = CON.COD_CONDOMINIO;";
            MySqlCommand cmd = new MySqlCommand(cmdSelect, ComandosSQL.conn);
            cmd.Prepare();
            using (MySqlDataReader leitor = cmd.ExecuteReader())
            {
                while (leitor.Read())
                {
                    try
                    {
                        if (condominioList.SelectedIndex != -1 && dadosCodsCondominio[condominioList.SelectedIndex] == (int)leitor["BLO-COD_CONDOMINIO"])
                        {
                            MessageBox.Show("condominioList i: " + condominioList.SelectedIndex.ToString()  + " / blocoList i: " + blocoList.SelectedIndex.ToString());
                            blocoList.Items.Add(String.Format("{0}", leitor["ID_BLOCO"]));
                            dadosCodsBloco.Add(Convert.ToInt32(leitor["BLO_COD_BLOCO"]));
                            MessageBox.Show(dadosCodsBloco[dadosCodsBloco.Last()].ToString());
                        }
                    }
                    catch
                    {

                    }

                }
            }
        }

        private void condominioList_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizarBlocos();
        }
    }
}
