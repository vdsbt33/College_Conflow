using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conflow
{
    public partial class Pesquisa_OpcoesUC : UserControl
    {
        Pesquisa_CondominioUC condominioUC = new Pesquisa_CondominioUC();
        Pesquisa_BlocoUC blocoUC = new Pesquisa_BlocoUC();
        Pesquisa_PredioUC predioUC = new Pesquisa_PredioUC();
        Pesquisa_ProprietarioUC proprietarioUC = new Pesquisa_ProprietarioUC();


        public Pesquisa_OpcoesUC()
        {
            InitializeComponent();

            Pesquisar_CondominioBtn_Click(null, new EventArgs());
        }

        public void ResetarScroll()
        {
            PesquisarOPPanel.VerticalScroll.Value = 0;
            PesquisarOPPanel.HorizontalScroll.Value = 0;
        }

        private void Pesquisar_CondominioBtn_Click(object sender, EventArgs e)
        {
            ResetarScroll();
            PesquisarOPPanel.Controls.Clear();
            PesquisarOPPanel.Controls.Add(condominioUC);

            proprietarioUC.AtualizarLocalizacao();
        }

        private void Cadastrar_BlocoBtn_Click(object sender, EventArgs e)
        {
            ResetarScroll();
            PesquisarOPPanel.Controls.Clear();
            PesquisarOPPanel.Controls.Add(blocoUC);

            proprietarioUC.AtualizarLocalizacao();
        }

        private void Cadastrar_PredioBtn_Click(object sender, EventArgs e)
        {
            ResetarScroll();
            PesquisarOPPanel.Controls.Clear();
            PesquisarOPPanel.Controls.Add(predioUC);

            proprietarioUC.AtualizarLocalizacao();
        }

        private void Pesquisar_MoradorBtn_Click(object sender, EventArgs e)
        {
            ResetarScroll();
            PesquisarOPPanel.Controls.Clear();
            PesquisarOPPanel.Controls.Add(proprietarioUC);

            proprietarioUC.AtualizarLocalizacao();
        }
    }
}
