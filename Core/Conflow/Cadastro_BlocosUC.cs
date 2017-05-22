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

        public String str = @"server=127.0.0.1;database=conflow;userid=root;password=123456;"; // YEEEE BOOOI
        public MySqlConnection conn = null;


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
            if (identificadorTbox.Text.Length > 0 && qtdPrediosNud.Value > 0)
            {
                
                String cmdTxt = "INSERT INTO BLOCOS( ID_BLOCO, QTD_PREDIOS_BLOCO, COD_CONDOMINIO ) VALUES ( \"" + identificadorTbox.Text + "\", " + qtdPrediosNud +", "+ condominioList.SelectedIndex +" );";

                ExecutarComandoSql(cmdTxt, "Novo bloco adicionado com sucesso!", "Não foi possível adicionar o bloco.");
                
            }
            else
            {
                MessageBox.Show("Erro: Um ou mais campos não foram preenchidos.");
            }
        }
        
    }
}
