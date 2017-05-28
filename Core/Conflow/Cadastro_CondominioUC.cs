﻿using System;
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
    public partial class Cadastro_CondominioUC : UserControl
    {
        public Cadastro_CondominioUC()
        {
            InitializeComponent();
        }

        public String str = @"server=127.0.0.1;database=conflow;userid=root;password=123456;";
        public MySqlConnection conn = null;

        // Executa um comando SQL e retorna se houve um erro ou não. True sucesso. False erro.
        // Possui mensagem de erro
        private bool ExecutarComandoSql(String textoCmd, String msgSucesso, String msgExcessao)
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
                return true;
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
                return false;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Clone();
                }
            }
        }

        // Executa um comando SQL e retorna se houve um erro ou não. True sucesso. False erro.
        // NÃO possui mensagem de erro
        private bool ExecutarComandoSql(String textoCmd, String msgSucesso)
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
                return true;
            }
            catch
            {
                return false;
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
            if (nomeDoCondominioTbox.Text.Length > 0 && telefoneTbox.Text.Length > 0 && estadoCBox.SelectedIndex != -1 && bairroTbox.Text.Length > 0 && ruaTBox.Text.Length > 0)
            {
                telefoneTbox.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

                String cmdTxt = "INSERT INTO CONDOMINIO(                            " +
                                "    ID_CONDOMINIO,                                 " +
                                "    DESPESA_MENSAL_CONDOMINIO,                     " +
                                "    TEL_CONTATO_CONDOMINIO,                        " +
                                "    END_ESTADO_CONDOMINIO,                         " +
                                "    END_BAIRRO_CONDOMINIO,                         " +
                                "    END_RUA_CONDOMINIO,                            " +
                                "    END_NUMERO_CONDOMINIO                          " +
                                ") VALUES (                                         " +
                                "    '" + nomeDoCondominioTbox.Text + "', " +
                                "    '" + Convert.ToSingle(custoMensalNud.Value) + "', " +
                                "    '" + telefoneTbox.Text + "', " +
                                "    '" + estadoCBox.Text + "', " +
                                "    '" + bairroTbox.Text + "', " +
                                "    '" + ruaTBox.Text + "', " +
                                "    '" + Convert.ToInt32(localNumeroNud.Value) + "'" +
                                ");                                                 ";

                ExecutarComandoSql(cmdTxt, "Novo condomínio cadastrado com sucesso!", "Não foi possível cadastrar o condomínio.");
            }
            else
            {
                MessageBox.Show("Erro: Um ou mais campos não foram preenchidos.");
            }
            
        }
    }
}
