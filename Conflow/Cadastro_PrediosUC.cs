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

        public String str = @"server=127.0.0.1;database=conflow;userid=root;password=123456;"; // YEEEE BOOOI
        public MySqlConnection conn = null;

        private void AtualizarDgView()
        {
            try
            {
                conn = new MySqlConnection(str);
                conn.Open();

                String textoCmd = "SELECT ID_PREDIO, QTD_APARTAMENTOS_PREDIO, VAL_MENSALIDADES_PREDIO, VAL_FRACAO_IDEAL_PREDIO FROM PREDIOS;";

                MySqlCommand comandoSql = new MySqlCommand(textoCmd, conn);
                comandoSql.Prepare();

                dgView.Rows.Clear();

                using (MySqlDataReader leitor = comandoSql.ExecuteReader())
                {
                    while (leitor.Read())
                    {
                        int index = dgView.Rows.Add();
                        DataGridViewRow linhaTabela = dgView.Rows[index];
                        linhaTabela.Cells["ID_PREDIO"].Value = leitor["ID_PREDIO"];
                        linhaTabela.Cells["QTD_APARTAMENTOS_PREDIO"].Value = leitor["QTD_APARTAMENTOS_PREDIO"];
                        linhaTabela.Cells["VAL_MENSALIDADES_PREDIO"].Value = String.Format("R${0}", Convert.ToInt32(leitor["VAL_MENSALIDADES_PREDIO"]) * 1.00m);
                        linhaTabela.Cells["VAL_FRACAO_IDEAL_PREDIO"].Value = String.Format("R${0}", Convert.ToInt32(leitor["VAL_FRACAO_IDEAL_PREDIO"]) * 1.00m);
                        
                    }
                }

            }
            catch
            {
                MessageBox.Show("Erro: Não foi possível acessar o banco de dados para recuperar os dados.");
            }
            finally
            {
                if (conn != null)
                {
                    conn.Clone();
                }
            }
        }

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
                
                String cmdTxt = "INSERT INTO PREDIOS ( ID_PREDIO, QTD_APARTAMENTOS_PREDIO, VAL_MENSALIDADES_PREDIO, VAL_FRACAO_IDEAL_PREDIO ) VALUES ( \"" + identificadorTbox.Text + "\", " + (int) qtdApartamentosNud.Value + ", " + valorMensalidadeNud.Value + ", " + 0.00f + " );";

                ExecutarComandoSql(cmdTxt, "Novo prédio adicionado com sucesso!", "Não foi possível adicionar o prédio.");

                AtualizarDgView();
            }
            else
            {
                MessageBox.Show("Erro: Um ou mais campos não foram preenchidos.");
            }
        }

        private void LerBtn_Click(object sender, EventArgs e)
        {
            AtualizarDgView();
        }

        private void Cadastro_PrediosUC_Load(object sender, EventArgs e)
        {
            AtualizarDgView();
        }
    }
}
