using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Conflow
{
    /*
    Classe: ContasSQL
    Descrição: Contém variáveis e funções para manipular contas salvas em um banco de dados SQL.
    */
    public class ContasSQL
    {
        public object ID_conectada = null;
        public String id_conta_contada = "";

        private PrincipalForm principalForm;
        private Conta_PanelUC contaPanel;
        private Conta_ConectarUC conectarUC;
        private Conta_DesconectarUC desconectarUC;


        /*
        Função: EntrarConta(String username, String password)
        Descrição: Tenta conectar-se a uma conta e retorna se houve sucesso ou não.
        */
        public bool EntrarConta(String username, String password)
        {
            this.ID_conectada = null;
            AtalhosSQL ComandosSQL = new AtalhosSQL();
            try
            {
                ComandosSQL.conn = new MySqlConnection(AtalhosSQL.str);
                ComandosSQL.conn.Open();

                String cmdSelect = "SELECT COD_USUARIO   " +
                                    "FROM USUARIO " +
                                    "WHERE NOME_USUARIO = @username AND SENHA_USUARIO = @password AND NIVEL_USUARIO > 0;";
                MySqlCommand cmd = new MySqlCommand(cmdSelect, ComandosSQL.conn);
                cmd.Parameters.AddWithValue("username", username);
                cmd.Parameters.AddWithValue("password", password);
                cmd.Prepare();
                using (MySqlDataReader leitor = cmd.ExecuteReader())
                {
                    while (leitor.Read())
                    {
                        if (leitor["COD_USUARIO"] != null)
                        {
                            this.ID_conectada = Convert.ToInt32(leitor["COD_USUARIO"]);
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
                        else
                        {
                            MessageBox.Show("Não foi possível conectar na conta. Verifique o nome de usuário e a senha.");
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


        /*
        Função: SairConta()
        Descrição: Desconecta-se da conta atualmente conectada.
        */
        public void SairConta()
        {
            if (this.ID_conectada != null)
            {
                this.ID_conectada = null;
                this.id_conta_contada = "";
                principalForm.AtualizarContaConectada();
                contaPanel.Controls.Clear();
                contaPanel.Controls.Add(conectarUC);
            }
        }


        /*
        Função: PainelLogin(PrincipalForm principalForm, Conta_PanelUC contaPanel, Conta_ConectarUC conectarUC, Conta_DesconectarUC desconectarUC)
        Descrição: Define o painel onde pode-se conectar a uma conta e desconectar-se.
        */
        public void PainelLogin(PrincipalForm principalForm, Conta_PanelUC contaPanel, Conta_ConectarUC conectarUC, Conta_DesconectarUC desconectarUC)
        {
            this.principalForm = principalForm;
            this.contaPanel = contaPanel;
            this.conectarUC = conectarUC;
            this.desconectarUC = desconectarUC;
        }
    }
}
