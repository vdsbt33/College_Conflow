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
            if (identificadorTbox.Text.Length > 0 && qtdApartamentosNud.Value > 0 && valorMensalidadeNud.Value > 0)
            {
                
                String cmdTxt = "INSERT INTO PREDIOS ( ID_PREDIO, QTD_APARTAMENTOS_PREDIO, VAL_MENSALIDADES_PREDIO, VAL_QUOTACONDOMINIAL_PREDIO, VAL_FRACAO_IDEAL_PREDIO ) VALUES ( \"" + identificadorTbox.Text + "\", " + (int) qtdApartamentosNud.Value + ", " + valorMensalidadeNud.Value + ", " + valorQuotaCondominialNud.Value + ", " + 0.00f + " );";

                ExecutarComandoSql(cmdTxt, "Novo prédio adicionado com sucesso!", "Não foi possível adicionar o prédio.");
                
            }
            else
            {
                MessageBox.Show("Erro: Um ou mais campos não foram preenchidos.");
            }
        }
    }
}
