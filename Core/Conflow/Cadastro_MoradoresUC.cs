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

                rgTbox.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

                MaskedTextBox cpfCnpjDesmascarado;
                if (pessoaFisicaRb.Checked)
                {
                    cpfCnpjDesmascarado = ucPFisica.getCPF();
                }
                else
                {
                    cpfCnpjDesmascarado = ucPJuridica.getCNPJ();
                }

                cpfCnpjDesmascarado.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                

                String dataDia = datanascimentoDtp.Value.Date.Year.ToString();

                if (datanascimentoDtp.Value.Month < 10)
                {
                    dataDia += "0";
                }
                dataDia += datanascimentoDtp.Value.Date.Month.ToString();
                if (datanascimentoDtp.Value.Date.Day < 10)
                {
                    dataDia += "0";
                }
                dataDia += datanascimentoDtp.Value.Date.Day.ToString();

                
                // Criando Morador
                String cmdTxt = "INSERT INTO MORADORES(NOME_MORADOR, RG_MORADOR, DAT_NASCIMENTO_MORADOR ) VALUES(\"" + nomeTbox.Text + "\", \"" + rgTbox.Text + "\", \"" + dataDia + "\" );";
                ExecutarComandoSql(cmdTxt, "Novo morador adicionado com sucesso!", "Não foi possível adicionar o morador.");

                /* ################
                 * PARTE COM ERRO
                 * ################
                 * Descrição do problema:
                 * 
                 * Não consegui encontrar uma maneira de pegar o COD_MORADOR do morador que acabou de ser criado
                 * para criar e vinculá-lo à seu respectivo CPF / CNPJ.
                 * 
                 * Por isso, o morador é criado mas o cpf/cnpj não.
                
                // Obtendo COD_MORADOR do último morador criado
                object codMorador;

                cmdTxt = "SELECT MAX(COD_MORADOR) FROM MORADOR_CPF;";

                MySqlCommand comandoSql = new MySqlCommand(cmdTxt, conn);
                comandoSql.Prepare();

                using (MySqlDataReader leitor = comandoSql.ExecuteReader())
                {
                    while (leitor.Read())
                    {
                        MessageBox.Show("Último Morador criado: " + leitor["COD_MORADOR"]);

                    }
                }

                */
                
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
    }
}

