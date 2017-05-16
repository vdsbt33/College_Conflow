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

        public String str = @"server=127.0.0.1;database=conflow;userid=root;password=123456;"; // YEEEE BOOOI
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

        private void AtualizarDgView()
        {
            try
            {
                conn = new MySqlConnection(str);
                conn.Open();

                String textoCmd = "SELECT NOME_MORADOR, RG_MORADOR, CPF_MORADOR, DAT_NASCIMENTO_MORADOR FROM MORADORES;";

                MySqlCommand comandoSql = new MySqlCommand(textoCmd, conn);
                comandoSql.Prepare();

                dgView.Rows.Clear();

                using (MySqlDataReader leitor = comandoSql.ExecuteReader())
                {
                    while (leitor.Read())
                    {
                        int index = dgView.Rows.Add();
                        DataGridViewRow linhaTabela = dgView.Rows[index];
                        linhaTabela.Cells["NOME_MORADOR"].Value = leitor["NOME_MORADOR"];
                        linhaTabela.Cells["RG_MORADOR"].Value = leitor["RG_MORADOR"];
                        linhaTabela.Cells["CPF_MORADOR"].Value = leitor["CPF_MORADOR"];

                        DateTime dataNascimento = Convert.ToDateTime(leitor["DAT_NASCIMENTO_MORADOR"]);

                        linhaTabela.Cells["DAT_NASCIMENTO_MORADOR"].Value = dataNascimento.Date.ToShortDateString();
                        
                    }
                }

            }
            catch (Exception e)
            {
                MessageBox.Show("Erro: Não foi possível acessar o banco de dados para recuperar os dados. \n\nDescrição: " + e.Message.ToString());
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
                

                String cmdTxt = "INSERT INTO MORADORES(NOME_MORADOR, RG_MORADOR, CPF_MORADOR, DAT_NASCIMENTO_MORADOR ) VALUES(\"" + nomeTbox.Text + "\", \"" + rgTbox.Text + "\", \"" + cpfCnpjDesmascarado.Text + "\", \"" + dataDia + "\" );";

                ExecutarComandoSql(cmdTxt, "Novo usuário adicionado com sucesso!", "Não foi possível adicionar o usuário.");

                AtualizarDgView();
            }
            else
            {
                MessageBox.Show("Erro: Um ou mais campos não foram preenchidos.");
            }
        }

        private void Cadastro_MoradoresUC_Load(object sender, EventArgs e)
        {
            AtualizarDgView();
        }

        private void LerBtn_Click(object sender, EventArgs e)
        {
            AtualizarDgView();
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

