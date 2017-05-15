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
        }

        // Variáveis
        string FormSelecionado; // Armazena qual o nome do form atualmente selecionado
        List<Form> FormLista = new List<Form>();

        // User controls
        Cadastro_OpcoesUC cadastroOpcoesUC;


        // Lista de nome de formulários
        List<string> NomesForms = new List<string>();
        private void InicializarNomesForms()
        {
            NomesForms.Add("AvisosForm");
            NomesForms.Add("ConectarForm");
            NomesForms.Add("PesquisarForm");
            NomesForms.Add("CadastrarForm");
            NomesForms.Add("ConfigurarForm");
            NomesForms.Add("AjudaForm");
            NomesForms.Add("SairForm");
        }


        // Troca os controles do painel, bem como a variável FormSelecionado, para os/as do Form especificado
        public void TrocarForm(string nomeForm)
        {
            FormSelecionado = nomeForm;

            // Busca pelo nome do formulário
            foreach (string s in NomesForms)
            {
                if (nomeForm == s)
                {
                    // Já que o nome do Form é conhecido, busca ele na lista
                    foreach (Form f in FormLista)
                    {
                        if (f.Name == nomeForm)
                        {
                            // Recria os controles do form no painel
                            FormPanel.Controls.Clear();
                            foreach (Control c in f.Controls)
                            {
                                FormPanel.Controls.Add(c);
                            }
                        }
                    }
                    
                }
            }
        }

        // Cria o Form de acordo com o nome dele
        public void CriarForm(string nomeForm)
        {
            /*
                NomesForms.Add("AvisosForm");
                NomesForms.Add("ConectarForm");
                NomesForms.Add("PesquisarForm");
                NomesForms.Add("CadastrarForm");
                NomesForms.Add("ConfigurarForm");
                NomesForms.Add("AjudaForm");
                NomesForms.Add("SairForm");
             * */
            //
            if (nomeForm == "AvisosForm")
            {
                
            }
            else if (nomeForm == "ConectarForm")
            {

            }
            else if (nomeForm == "PesquisarForm")
            {

            }
            else if (nomeForm == "CadastrarForm")
            {

            }
            else if (nomeForm == "ConfigurarForm")
            {

            }
            else if (nomeForm == "AjudaForm")
            {

            }
            else if (nomeForm == "SairForm")
            {
        
            }
        }

        private void CadastrarBtn_Click(object sender, EventArgs e)
        {
            if (cadastroOpcoesUC == null)
            {
                cadastroOpcoesUC = new Cadastro_OpcoesUC();
            }

            FormPanel.Controls.Clear();
            cadastroOpcoesUC.Size = FormPanel.Size;
            FormPanel.Controls.Add(cadastroOpcoesUC);
        }

        private void SairBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente encerrar o programa?", "Encerrar programa", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                this.Close();
                Application.Exit();
            }
        }
    }
}
