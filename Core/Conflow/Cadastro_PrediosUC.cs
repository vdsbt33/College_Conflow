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

        public String str = @"server=127.0.0.1;database=conflow;userid=root;password=123456;";
        public MySqlConnection conn = null;

        public List<Int32> dadosCodsCondominio = new List<Int32>();
        public List<Int32> dadosCodsBloco = new List<int>();

        private void ExecutarComandoSql(String textoCmd, String msgSucesso, String msgExcessao)
        {
            try
            {
                conn = new MySqlConnection(str);
                conn.Open();
                MySqlCommand comandoSql = new MySqlCommand(textoCmd, conn);
                comandoSql.Prepare();
                comandoSql.ExecuteNonQuery();
                if (msgSucesso.Length > 0)
                {
                    MessageBox.Show(msgSucesso);
                }
            }
            catch (Exception e)
            {
                if (msgExcessao.Length > 0)
                {
                    MessageBox.Show(msgExcessao + "\n\nDescrição: " + e.Message);
                }
                else
                {
                    MessageBox.Show("Erro: Um erro ocorreu e não foi possível realizar a tarefa.");
                }
            }
            finally
            {
                if (conn != null)
                {
                    conn.Clone();
                }
            }
        }

        private void CriarBtn_Click(object sender, EventArgs e)
        {
            if (identificadorTbox.Text.Length > 0 && valorMensalidadeNud.Value > 0 && blocoList.SelectedIndex != -1)
            {
                
                String cmdTxt = "INSERT INTO PREDIO ( ID_PREDIO, VAL_MENSALIDADES_PREDIO, VAL_QUOTACONDOMINIAL_PREDIO, VAL_FRACAO_IDEAL_PREDIO ) VALUES ( \"" + identificadorTbox.Text + "\", " + valorMensalidadeNud.Value + ", " + valorQuotaCondominialNud.Value + ", " + 0.00f + " );";

                ExecutarComandoSql(cmdTxt, "Novo prédio adicionado com sucesso!", "Não foi possível adicionar o prédio.");

                // Inserindo apartamentos no prédio
                for (int contador = 0; contador < (int) qtdApartamentosNud.Value; contador++)
                {
                    cmdTxt = "INSERT INTO PREDIO ( ID_PREDIO, VAL_MENSALIDADES_PREDIO, VAL_QUOTACONDOMINIAL_PREDIO, VAL_FRACAO_IDEAL_PREDIO ) VALUES ( \"" + identificadorTbox.Text + "\", " + valorMensalidadeNud.Value + ", " + valorQuotaCondominialNud.Value + ", " + 0.00f + " );";
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

            conn = new MySqlConnection(str);
            conn.Open();

            // Condominios
            condominioList.Items.Clear();

            String cmdSelect = "SELECT COD_CONDOMINIO, ID_CONDOMINIO FROM CONDOMINIO";
            MySqlCommand cmd = new MySqlCommand(cmdSelect, conn);
            cmd.Prepare();
            using (MySqlDataReader leitor = cmd.ExecuteReader())
            {
                while (leitor.Read())
                {
                    condominioList.Items.Add(String.Format("{0}", leitor["ID_CONDOMINIO"]));
                    dadosCodsCondominio.Add(Convert.ToInt32(leitor["COD_CONDOMINIO"]));
                }
            }

            AtualizarBlocos();
        }

        public void AtualizarBlocos()
        {
            // Blocos
            blocoList.Items.Clear();

            String cmdSelect = "SELECT BLO.COD_BLOCO, BLO.ID_BLOCO, BLO.COD_CONDOMINIO 'BLO_CODCON', CON.COD_CONDOMINIO FROM BLOCO BLO, CONDOMINIO CON WHERE BLO.COD_CONDOMINIO = CON.COD_CONDOMINIO;";
            MySqlCommand cmd = new MySqlCommand(cmdSelect, conn);
            cmd.Prepare();
            using (MySqlDataReader leitor = cmd.ExecuteReader())
            {
                while (leitor.Read())
                {
                    try
                    {
                        if (dadosCodsCondominio[condominioList.SelectedIndex] == (int)leitor["BLO_CODCON"])
                        {
                            blocoList.Items.Add(String.Format("{0}", leitor["ID_BLOCO"]));
                            dadosCodsBloco.Add(Convert.ToInt32(leitor["COD_BLOCO"]));
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
