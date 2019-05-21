using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace WebApp_Conflow
{
    public partial class usuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void conectarBtn_onClick(object sender, EventArgs e)
        {
            Session["COD_USUARIO"] = null;
            Session["NOME_USUARIO"] = null;
            try { 
                MySqlConnection conn = new MySqlConnection("server = 127.0.0.1; database = conflow; userid = root; password = admin; Connection Timeout = 30");

                String str = "SELECT COD_USUARIO, NOME_USUARIO FROM USUARIO WHERE NOME_USUARIO = @nome AND SENHA_USUARIO = @senha AND NIVEL_USUARIO >= 0";
                MySqlCommand cmd = new MySqlCommand(str, conn);
                cmd.Parameters.AddWithValue("nome", nomeTbox.Text);
                cmd.Parameters.AddWithValue("senha", senhaTbox.Text);

                conn.Open();
                cmd.Prepare();

                using (MySqlDataReader leitor = cmd.ExecuteReader())
                {
                    while (leitor.Read())
                    {
                        if (leitor["COD_USUARIO"] != null)
                        {
                            Session.Add("COD_USUARIO", leitor["COD_USUARIO"].ToString());
                            Session.Add("NOME_USUARIO", leitor["NOME_USUARIO"].ToString());

                        }
                    }
                }

                conn.Close();
            } catch
            {
                avisoLabel.Text = "Não foi possível estabelecer uma conexão.";
            }


            if (Session["COD_USUARIO"] == null)
            {
                avisoLabel.Text = "Usuário ou senha inválidos.";
            }
            else
            {
                avisoLabel.Text = "Conectado com sucesso ao usuário " + Session["NOME_USUARIO"].ToString();
            }
            
        }
    }
}