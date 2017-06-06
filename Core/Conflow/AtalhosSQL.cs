using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Conflow
{
    public class AtalhosSQL
    {
        public String str = @"server=127.0.0.1;database=conflow;userid=root;password=123456;";
        public MySqlConnection conn = null;
        public MySqlCommand comandoSql = new MySqlCommand();

        public AtalhosSQL()
        {
            comandoSql.Connection = conn;
        }

        public AtalhosSQL(String db)
        {
            str = db;
            comandoSql.Connection = conn;
        }
        

        // Executa um comando SQL e retorna se houve um erro ou não. True sucesso. False erro.
        // Possui mensagem de erro
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


        // Executa um comando SQL e retorna se houve um erro ou não. True sucesso. False erro.
        // NÃO possui mensagem de erro
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

        // Executa um comando SQL e retorna se houve um erro ou não. True sucesso. False erro.
        // Não exibe nenhuma mensagem
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

        // Retorna a data e hora atual no formato do SQL
        public String current_timestamp
        {
            get
            {
                return String.Format("{0}-{1}-{2} {3}:{4}:{5}", DateTime.Now.Year.ToString(), ConverterDataHora(DateTime.Now.Month.ToString()), ConverterDataHora(DateTime.Now.Day.ToString()), ConverterDataHora(DateTime.Now.Hour.ToString()), ConverterDataHora(DateTime.Now.Minute.ToString()), ConverterDataHora(DateTime.Now.Second.ToString()));
            }
        }

        // Faz com que valores menores que 10 retornem com um zero antes. Ex: 07, 08, 09, 10.
        // Como em datas (03/05/2000)
        public String ConverterDataHora(String valor)
        {
            if (Convert.ToInt32(valor) < 10)
            {
                return "0" + valor;
            }
            return valor;
        }


        // Checa se possui " ou ' no texto. Retorna true se tiver
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
