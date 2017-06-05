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
        Pesquisa_ProprietariosUC moradorUC = new Pesquisa_ProprietariosUC();


        public Pesquisa_OpcoesUC()
        {
            InitializeComponent();
        }

        private void Pesquisar_MoradorBtn_Click(object sender, EventArgs e)
        {
            PesquisarOPPanel.Controls.Clear();
            PesquisarOPPanel.Controls.Add(moradorUC);

            moradorUC.AtualizarLocalizacao();
        }

        private void Pesquisar_CondominioBtn_Click(object sender, EventArgs e)
        {

        }


        public void ResetarScroll()
        {
            PesquisarOPPanel.VerticalScroll.Value = 0;
            PesquisarOPPanel.HorizontalScroll.Value = 0;
        }

    }
}
