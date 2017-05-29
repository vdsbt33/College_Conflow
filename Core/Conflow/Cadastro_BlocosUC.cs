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
    public partial class Cadastro_BlocosUC : UserControl
    {
        public Cadastro_BlocosUC()
        {
            InitializeComponent();
        }

        AtalhosSQL ComandosSQL = new AtalhosSQL();

        public List<Int32> dadosCodsCondominio = new List<Int32>();
        
        
        private void CriarBtn_Click(object sender, EventArgs e)
        {
            if (identificadorTbox.Text.Length > 0)
            {
                int cod_condominio = dadosCodsCondominio[condominioList.SelectedIndex];
                String cmdTxt = "INSERT INTO BLOCO(" +
                                "    ID_BLOCO" +
                                "  , COD_CONDOMINIO" +
                                ") VALUES(" +
                                String.Format(" '{0}' ", identificadorTbox.Text) +
                                String.Format(", {0}  ", dadosCodsCondominio[condominioList.SelectedIndex]) +
                                ");";

                ComandosSQL.ExecutarComandoSql(cmdTxt, "Novo bloco adicionado com sucesso!", "Não foi possível adicionar o bloco.");
                
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

            ComandosSQL.conn.Close();
        }

    }
}
