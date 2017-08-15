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
    Classe: AtalhosSQL
    Descrição: Contém variáveis e funções para manipular um banco de dados SQL.
    */
    public class AtalhosSQL
    {
        public String str = @"server=127.0.0.1;database=conflow;userid=root;password=admin;"; // O servidor, banco de dados, nome de usuário e senha
        public MySqlConnection conn = null;
        public MySqlCommand comandoSql = new MySqlCommand();


        /*
        Construtor: AtalhosSQL()
        Descrição: Inicializa o objeto com a conexão padrão.
        */
        public AtalhosSQL()
        {
            comandoSql.Connection = conn;
        }


        /*
        Função: AtalhosSQL(String db)
        Descrição: Contém variáveis e funções para manipular um banco de dados SQL.
        */
        public AtalhosSQL(String db)
        {
            str = db;
            comandoSql.Connection = conn;
        }


        /*
        Função: AtalhosSQL(String db)
        Descrição: Executa um comando SQL e retorna se houve um erro (False) ou não (True).
                   Exibe uma mensagem de sucesso e uma mensagem de erro.
        */
        public bool ExecutarComandoSql(String textoCmd, String msgSucesso, String msgExcessao)
        {
            try
            {
                conn = new MySqlConnection(str);
                conn.Open();
                comandoSql.Connection = conn;
                comandoSql.CommandText = textoCmd;
                comandoSql.Prepare();
                comandoSql.ExecuteNonQuery();

                if (msgSucesso.Length > 0)
                {
                    MessageBox.Show(msgSucesso);
                }

                comandoSql.Parameters.Clear();
                return true;
            }
            catch (Exception e)
            {
                comandoSql.Parameters.Clear();
                if (msgExcessao.Length > 0)
                {
                    MessageBox.Show(msgExcessao + "\n\nDescrição: " + e.Message);
                }
                else
                {
                    MessageBox.Show("Erro: Um erro ocorreu e não foi possível realizar a tarefa.");
                }
                return false;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Clone();
                }

                comandoSql.Parameters.Clear();
            }
        }


        /*
        Função: AtalhosSQL(String db)
        Descrição: Executa um comando SQL e retorna se houve um erro (False) ou não (True).
                   Exibe apenas uma mensagem de sucesso.
        */
        public bool ExecutarComandoSql(String textoCmd, String msgSucesso)
        {
            try
            {
                conn = new MySqlConnection(str);
                conn.Open();
                comandoSql.Connection = conn;
                comandoSql.CommandText = textoCmd;
                comandoSql.Prepare();
                comandoSql.ExecuteNonQuery();

                if (msgSucesso.Length > 0)
                {
                    MessageBox.Show(msgSucesso);
                }

                comandoSql.Parameters.Clear();
                return true;
            }
            catch
            {
                comandoSql.Parameters.Clear();
                return false;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Clone();
                }

                comandoSql.Parameters.Clear();
            }
        }


        /*
        Função: AtalhosSQL(String db)
        Descrição: Executa um comando SQL e retorna se houve um erro (False) ou não (True).
                   Não exibe nenhuma mensagem ao terminar.
        */
        public bool ExecutarComandoSql(String textoCmd)
        {
            try
            {
                conn = new MySqlConnection(str);
                conn.Open();
                comandoSql.Connection = conn;
                comandoSql.CommandText = textoCmd;
                comandoSql.Prepare();
                comandoSql.ExecuteNonQuery();

                comandoSql.Parameters.Clear();
                return true;
            }
            catch
            {
                comandoSql.Parameters.Clear();
                return false;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Clone();
                }

                comandoSql.Parameters.Clear();
            }
        }


        /*
        Propriedade: current_timestamp
        Descrição: Retorna a data e hora atual no formato do SQL.
        */
        public String current_timestamp
        {
            get
            {
                return String.Format("{0}-{1}-{2} {3}:{4}:{5}", DateTime.Now.Year.ToString(), ConverterDataHora(DateTime.Now.Month.ToString()), ConverterDataHora(DateTime.Now.Day.ToString()), ConverterDataHora(DateTime.Now.Hour.ToString()), ConverterDataHora(DateTime.Now.Minute.ToString()), ConverterDataHora(DateTime.Now.Second.ToString()));
            }
        }


        /*
        Propriedade: ConverterDataHora(String valor)
        Descrição: Retorna valores menores que 10 com um zero antes. 
                   Ex: 07, 08, 09, 10 como em 03/05/2000
        */
        public String ConverterDataHora(String valor)
        {
            if (Convert.ToInt32(valor) < 10)
            {
                return "0" + valor;
            }
            return valor;
        }


        /*
        Propriedade: ContemSimbolos(String texto)
        Descrição: Chega se possui " ou ' no texto. Retorna true se houver.
        */
        public bool ContemSimbolos(String texto)
        {
            if (texto.Contains(Convert.ToChar("'")) || texto.Contains(Convert.ToChar("\"")))
            {
                return true;
            }
            return false;
        }
    }
}
