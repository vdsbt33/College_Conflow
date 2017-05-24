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

    public partial class Cadastro_MoradoresUC : UserControl
    {
        private UCPessoa_Fisica ucPFisica = null;
        private UCPessoa_Juridica ucPJuridica = null;

        public Cadastro_MoradoresUC()
        {
            InitializeComponent();
            pessoaFisicaRb.Checked = true;
            MudarTipoPessoa();
        }

        // Retorna a data e hora atual no formato do SQL
        private String current_timestamp
        {
            get
            {
                return String.Format("{0}-{1}-{2} {3}:{4}:{5}", DateTime.Now.Year.ToString(), ConverterDataHora(DateTime.Now.Month.ToString()), ConverterDataHora(DateTime.Now.Day.ToString()), ConverterDataHora(DateTime.Now.Hour.ToString()), ConverterDataHora(DateTime.Now.Minute.ToString()), ConverterDataHora(DateTime.Now.Second.ToString()));
            }
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
            catch (Exception e)
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
            
            if (nomeTbox.Text.Length > 0 && rgTbox.Text.Length > 0 && numeroestacionamentoNud.Value > 0)
            {
                String cpfcnpjPessoa = "";
                if (pessoaFisicaRb.Checked == true)
                {
                    cpfcnpjPessoa = ucPFisica.Controls["cpfTbox"].Text;
                }
                else if (pessoaJuridicaRb.Checked == true)
                {
                    cpfcnpjPessoa = ucPJuridica.Controls["cnpjTbox"].Text;
                }

                // Retira a máscara do CPF / CNPJ
                rgTbox.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

                String cpfCnpjDesmascarado;
                if (pessoaFisicaRb.Checked)
                {
                    cpfCnpjDesmascarado = ucPFisica.getCPF();
                }
                else
                {
                    cpfCnpjDesmascarado = ucPJuridica.getCNPJ();
                }

                String dataNascimento = datanascimentoDtp.Value.Date.Year.ToString();
                dataNascimento += ConverterDataHora(datanascimentoDtp.Value.Date.Month.ToString());
                dataNascimento += ConverterDataHora(datanascimentoDtp.Value.Date.Day.ToString());


                // Criando Morador
                String cmdTxt = "";
                String timestamp_criacao = current_timestamp;
                   cmdTxt = "INSERT INTO MORADOR(               " +
                            "    NOME_MORADOR,                  " +
                            "    RG_MORADOR,                    " +
                            "    DAT_NASCIMENTO_MORADOR,        " +
                            "    ULTIMA_MODIFICACAO             " +
                            ") VALUES(                          " +
                            "    '" + nomeTbox.Text + "',       " +
                            "    '" + rgTbox.Text + "',         " +
                            "    '" + dataNascimento + "',      " +
                            "    '" + timestamp_criacao + "'    " +
                            ");                                 ";

                ExecutarComandoSql(cmdTxt, "Novo morador adicionado com sucesso!", "Não foi possível adicionar o morador.");
                // Criando CPF / CNPJ do Morador
                if (pessoaFisicaRb.Checked)
                {
                    cmdTxt = "INSERT INTO MORADOR_CPF(   " +
                             "    COD_MORADOR,           " +
                             "    CPF_MORADOR            " +
                             ") VALUES(                  " +
                             "    (SELECT COD_MORADOR FROM MORADOR WHERE NOME_MORADOR = '" + nomeTbox.Text + "' AND ULTIMA_MODIFICACAO = '" + timestamp_criacao + "')," +
                             "    '" + cpfCnpjDesmascarado +"'" +
                             ");                         ";
                }
                else
                {
                    cmdTxt = "INSERT INTO MORADOR_CNPJ(   " +
                             "    COD_MORADOR,           " +
                             "    CNPJ_MORADOR            " +
                             ") VALUES(                  " +
                             "    (SELECT COD_MORADOR FROM MORADOR WHERE NOME_MORADOR = '" + nomeTbox.Text + "' AND ULTIMA_MODIFICACAO = '" + timestamp_criacao + "')," +
                             "    '" + cpfCnpjDesmascarado + "'" +
                             ");                         ";
                }

                if (!ExecutarComandoSql(cmdTxt, "", "Não foi possível adicionar o CPF/CNPJ do morador."))
                {
                    cmdTxt =    "DELETE FROM MORADOR                                                " +
                                "WHERE COD_MORADOR = (SELECT COD_MORADOR                            " +
                                "FROM MORADOR                                                       " +
                                "WHERE NOME_MORADOR = '" + nomeTbox.Text + "' AND ULTIMA_MODIFICACAO = '" + timestamp_criacao + "');  ";
                    ExecutarComandoSql(cmdTxt, "");
                }



            }
            else
            {
                MessageBox.Show("Erro: Um ou mais campos não foram preenchidos.");
            }


        }
        
        //


        private void MudarTipoPessoa()
        {
            if (pessoaFisicaRb.Checked == true)
            {
                if (ucPFisica == null)
                {
                    ucPFisica = new UCPessoa_Fisica();
                }

                cpfRgPanel.Controls.Add(ucPFisica);
                ucPFisica.Show();

                if (ucPJuridica != null)
                {
                    ucPJuridica.Hide();
                }
            }
            else if (pessoaJuridicaRb.Checked == true)
            {
                if (ucPJuridica == null)
                {
                    ucPJuridica = new UCPessoa_Juridica();
                }

                cpfRgPanel.Controls.Add(ucPJuridica);
                ucPJuridica.Show();

                if (ucPFisica != null)
                {
                    ucPFisica.Hide();
                }
            }
        }

        private void pessoaFisicaRb_CheckedChanged(object sender, EventArgs e)
        {
            MudarTipoPessoa();
        }

        private void pessoaJuridicaRb_CheckedChanged(object sender, EventArgs e)
        {
            MudarTipoPessoa();
        }

        

        // Faz com que valores menores que 10 retornem com um zero antes. Ex: 07, 08, 09, 10.
        private String ConverterDataHora(String valor)
        {
            if (Convert.ToInt32(valor) < 10)
            {
                return "0" + valor;
            }
            return valor;
        }
        
    }
}

