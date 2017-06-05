using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conflow
{
    public partial class PrincipalForm : Form
    {
        // Construtor do Form
        public PrincipalForm()
        {
            InitializeComponent();
            FormSelecionado = this.Name;

            contaSQL.PainelLogin(this, contaPanelUC, conectarUC, desconectarUC);
        }

        // Variáveis
        string FormSelecionado; // Armazena qual o nome do form atualmente selecionado
        List<Form> FormLista = new List<Form>();

        static ContasSQL contaSQL = new ContasSQL();

        // User controls
        AvisosUC avisosUC = new AvisosUC();
        Conta_PanelUC contaPanelUC = new Conta_PanelUC(contaSQL);
        Conta_ConectarUC conectarUC = new Conta_ConectarUC(contaSQL);
        Conta_DesconectarUC desconectarUC = new Conta_DesconectarUC(contaSQL);

        Cadastro_OpcoesUC cadastroOpcoesUC = new Cadastro_OpcoesUC();
        Pesquisa_OpcoesUC pesquisaOpcoesUC = new Pesquisa_OpcoesUC();
        ConfigurarUC configurarUC = new ConfigurarUC();
        AjudaUC ajudaUC = new AjudaUC();


        private void AvisosBtn_Click(object sender, EventArgs e)
        {
            FormPanel.Controls.Clear();
            avisosUC.Size = FormPanel.Size;
            FormPanel.Controls.Add(avisosUC);
        }

        private void ConectarBtn_Click(object sender, EventArgs e)
        {
            FormPanel.Controls.Clear();
            contaPanelUC.Size = FormPanel.Size;
            FormPanel.Controls.Add(contaPanelUC);

            if (contaSQL.cod_conta_conectada == null)
            {
                contaPanelUC.Controls.Clear();
                contaPanelUC.Controls.Add(conectarUC);
            }
        }

        private void PesquisarBtn_Click(object sender, EventArgs e)
        {

            FormPanel.Controls.Clear();
            pesquisaOpcoesUC.Size = FormPanel.Size;
            FormPanel.Controls.Add(pesquisaOpcoesUC);
        }

        private void CadastrarBtn_Click(object sender, EventArgs e)
        {
            
            FormPanel.Controls.Clear();
            cadastroOpcoesUC.Size = FormPanel.Size;
            FormPanel.Controls.Add(cadastroOpcoesUC);
        }
        
        private void ConfigurarBtn_Click(object sender, EventArgs e)
        {
            FormPanel.Controls.Clear();
            configurarUC.Size = FormPanel.Size;
            FormPanel.Controls.Add(configurarUC);
        }

        private void AjudaBtn_Click(object sender, EventArgs e)
        {
            FormPanel.Controls.Clear();
            ajudaUC.Size = FormPanel.Size;
            FormPanel.Controls.Add(ajudaUC);
        }


        private void SairBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente encerrar o programa?", "Encerrar programa", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                this.Close();
                Application.Exit();
            }
        }

        private void PrincipalForm_KeyDown(object sender, KeyEventArgs e)
        {
            // Avisos
            if (e.KeyCode == Keys.F1)
            {
                AvisosBtn_Click(null, new EventArgs());
            }
            else if (e.KeyCode == Keys.F2)
            {
                ConectarBtn_Click(null, new EventArgs());
            }
            else if (e.KeyCode == Keys.F3)
            {
                PesquisarBtn_Click(null, new EventArgs());
            }
            else if (e.KeyCode == Keys.F4)
            {
                CadastrarBtn_Click(null, new EventArgs());
            }
            else if (e.KeyCode == Keys.F5)
            {
                ConfigurarBtn_Click(null, new EventArgs());
            }
            else if (e.KeyCode == Keys.F6)
            {
                AjudaBtn_Click(null, new EventArgs());
            }
            else if (e.KeyCode == Keys.F12)
            {
                SairBtn_Click(null, new EventArgs());
            }
        }

        public void AtualizarContaConectada()
        {
            if (contaSQL.cod_conta_conectada != null)
            {
                contaConectadaTTip.Text = "Conta: " + contaSQL.id_conta_contada;
            }
            else
            {
                contaConectadaTTip.Text = "Conta: [Nenhuma]";
            }
            
        }
    }
}
