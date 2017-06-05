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
    public partial class Cadastro_OpcoesUC : UserControl
    {
        Cadastro_ProprietarioUC moradoresUC = new Cadastro_ProprietarioUC();
        Cadastro_PredioUC prediosUC = new Cadastro_PredioUC();
        Cadastro_BlocoUC blocosUC = new Cadastro_BlocoUC();
        Cadastro_CondominioUC condominiosUC = new Cadastro_CondominioUC();

        public Cadastro_OpcoesUC()
        {
            InitializeComponent();

            Cadastrar_CondominioBtn_Click(null, new EventArgs());
        }

        public void ResetarScroll()
        {
            CadastrarOPPanel.VerticalScroll.Value = 0;
            CadastrarOPPanel.HorizontalScroll.Value = 0;
        }

        private void Cadastrar_CondominioBtn_Click(object sender, EventArgs e)
        {
            ResetarScroll();
            CadastrarOPPanel.Controls.Clear();
            CadastrarOPPanel.Controls.Add(condominiosUC);
        }

        private void Cadastrar_BlocoBtn_Click(object sender, EventArgs e)
        {
            ResetarScroll();
            CadastrarOPPanel.Controls.Clear();
            CadastrarOPPanel.Controls.Add(blocosUC);

            blocosUC.AtualizarLocalizacao();
        }

        private void Cadastrar_PredioBtn_Click(object sender, EventArgs e)
        {
            ResetarScroll();
            CadastrarOPPanel.Controls.Clear();
            CadastrarOPPanel.Controls.Add(prediosUC);

            prediosUC.AtualizarLocalizacao();
        }

        private void Cadastrar_MoradorBtn_Click(object sender, EventArgs e)
        {
            ResetarScroll();
            CadastrarOPPanel.Controls.Clear();
            CadastrarOPPanel.Controls.Add(moradoresUC);

            moradoresUC.AtualizarLocalizacao();
        }

        

        

        
    }
}
