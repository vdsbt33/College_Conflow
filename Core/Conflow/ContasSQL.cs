using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Conflow
{
    public class ContasSQL
    {
        public object cod_conta_conectada = null;
        public String id_conta_contada = "";

        private PrincipalForm principalForm;
        private Conta_PanelUC contaPanel;
        private Conta_ConectarUC conectarUC;
        private Conta_DesconectarUC desconectarUC;

        // Tenta conectar-se a uma conta e retorna se houve sucesso ou não
        public bool EntrarConta(String username, String password)
        {
            this.cod_conta_conectada = null;
            AtalhosSQL ComandosSQL = new AtalhosSQL();
            try
            {
                ComandosSQL.conn = new MySqlConnection(ComandosSQL.str);
                ComandosSQL.conn.Open();

                String cmdSelect = "SELECT COD_CONTA   " +
                                    "FROM CONTA_SISTEMA " +
                                    "WHERE USERNAME_CONTA = @username AND PASSWORD_CONTA = @password; ";
                MySqlCommand cmd = new MySqlCommand(cmdSelect, ComandosSQL.conn);
                cmd.Parameters.AddWithValue("username", username);
                cmd.Parameters.AddWithValue("password", password);
                cmd.Prepare();
                using (MySqlDataReader leitor = cmd.ExecuteReader())
                {
                    while (leitor.Read())
                    {
                        if (leitor["COD_CONTA"] != null)
                        {
                            this.cod_conta_conectada = Convert.ToInt32(leitor["COD_CONTA"]);
                            this.id_conta_contada = conectarUC.Controls["usernameTbox"].Text;
                            principalForm.AtualizarContaConectada();
                            ComandosSQL.conn.Close();
                            contaPanel.Controls.Clear();
                            contaPanel.Controls.Add(desconectarUC);
                            conectarUC.Controls["usernameTbox"].Text = "";
                            conectarUC.Controls["passwordTbox"].Text = "";
                            MessageBox.Show("Conectado com sucesso!");
                            
                            return true;
                        }
                    }
                }

            }
            catch (Exception exception)
            {
                ComandosSQL.conn.Close();
                MessageBox.Show("Um erro ocorreu ao tentar ler o banco de dados. \nDescrição: " + exception.Message);
                
            }

            ComandosSQL.conn.Close();

            MessageBox.Show("Você inseriu um nome de usuário ou senha inválido.");
            return false;
        }

        // Desconecta-se da conta atualmente conectada
        public void SairConta()
        {
            if (this.cod_conta_conectada != null)
            {
                this.cod_conta_conectada = null;
                this.id_conta_contada = "";
                principalForm.AtualizarContaConectada();
                contaPanel.Controls.Clear();
                contaPanel.Controls.Add(conectarUC);
            }
        }


        // Define o painel onde pode-se conectar a uma conta e desconectar-se
        public void PainelLogin(PrincipalForm principalForm, Conta_PanelUC contaPanel, Conta_ConectarUC conectarUC, Conta_DesconectarUC desconectarUC)
        {
            this.principalForm = principalForm;
            this.contaPanel = contaPanel;
            this.conectarUC = conectarUC;
            this.desconectarUC = desconectarUC;
        }
    }
}
