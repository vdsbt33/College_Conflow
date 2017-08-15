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
    /*
    Classe: Pesquisa_OpcoesUC
    Descrição: Contém os métodos do user control Pesquisa_OpcoesUC.
    */
    public partial class Pesquisa_OpcoesUC : UserControl
    {
        Pesquisa_CondominioUC condominioUC = new Pesquisa_CondominioUC();
        Pesquisa_BlocoUC blocoUC = new Pesquisa_BlocoUC();
        Pesquisa_PredioUC predioUC = new Pesquisa_PredioUC();
        Pesquisa_ProprietarioUC proprietarioUC = new Pesquisa_ProprietarioUC();
        Pesquisa_MoradorUC moradorUC = new Pesquisa_MoradorUC();


        /*
        Construtor: Pesquisa_OpcoesUC()
        Descrição: -.
        */
        public Pesquisa_OpcoesUC()
        {
            InitializeComponent();

            Pesquisar_ProprietarioBtn_Click(null, new EventArgs());
        }


        /*
        Função: ResetarScroll()
        Descrição: Reseta o scroll do form em PesquisarOPPanel para evitar que o scroll desapareça ao trocar de usercontrol.
        */
        public void ResetarScroll()
        {
            PesquisarOPPanel.VerticalScroll.Value = 0;
            PesquisarOPPanel.HorizontalScroll.Value = 0;
        }


        /*
        Função: Pesquisar_CondominioBtn_Click(object sender, EventArgs e)
        Descrição: Reseta o scroll e abre o usercontrol Pesquisar Condomínio.
        */
        private void Pesquisar_CondominioBtn_Click(object sender, EventArgs e)
        {
            ResetarScroll();
            PesquisarOPPanel.Controls.Clear();
            PesquisarOPPanel.Controls.Add(condominioUC);
            
        }


        /*
        Função: Cadastrar_BlocoBtn_Click(object sender, EventArgs e)
        Descrição: Reseta o scroll e abre o usercontrol Pesquisar Bloco.
        */
        private void Cadastrar_BlocoBtn_Click(object sender, EventArgs e)
        {
            ResetarScroll();
            PesquisarOPPanel.Controls.Clear();
            PesquisarOPPanel.Controls.Add(blocoUC);
            
        }


        /*
        Função: Cadastrar_PredioBtn_Click(object sender, EventArgs e)
        Descrição: Reseta o scroll e abre o usercontrol Pesquisar Predio.
        */
        private void Cadastrar_PredioBtn_Click(object sender, EventArgs e)
        {
            ResetarScroll();
            PesquisarOPPanel.Controls.Clear();
            PesquisarOPPanel.Controls.Add(predioUC);
            
        }


        /*
        Função: Pesquisar_ProprietarioBtn_Click(object sender, EventArgs e)
        Descrição: Reseta o scroll e abre o usercontrol Pesquisar Proprietário.
        */
        private void Pesquisar_ProprietarioBtn_Click(object sender, EventArgs e)
        {
            ResetarScroll();
            PesquisarOPPanel.Controls.Clear();
            PesquisarOPPanel.Controls.Add(proprietarioUC);

            proprietarioUC.AtualizarLocalizacao();
        }


        /*
        Função: Pesquisar_MoradorBtn_Click(object sender, EventArgs e)
        Descrição: Reseta o scroll e abre o usercontrol Pesquisar Morador.
        */
        private void Pesquisar_MoradorBtn_Click(object sender, EventArgs e)
        {
            ResetarScroll();
            PesquisarOPPanel.Controls.Clear();
            PesquisarOPPanel.Controls.Add(moradorUC);
            
        }
    }
}
