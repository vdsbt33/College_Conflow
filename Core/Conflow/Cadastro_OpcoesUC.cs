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
        Cadastro_MoradoresUC moradoresUC = new Cadastro_MoradoresUC();
        Cadastro_PrediosUC prediosUC = new Cadastro_PrediosUC();
        Cadastro_BlocosUC blocosUC = new Cadastro_BlocosUC();
        Cadastro_CondominioUC condominiosUC = new Cadastro_CondominioUC();

        public Cadastro_OpcoesUC()
        {
            InitializeComponent();
        }

        private void Cadastrar_MoradorBtn_Click(object sender, EventArgs e)
        {

            CadastrarOPPanel.Controls.Clear();
            CadastrarOPPanel.Controls.Add(moradoresUC);
        }

        private void Cadastrar_PredioBtn_Click(object sender, EventArgs e)
        {
            CadastrarOPPanel.Controls.Clear();
            CadastrarOPPanel.Controls.Add(prediosUC);
        }

        private void Cadastrar_BlocoBtn_Click(object sender, EventArgs e)
        {
            CadastrarOPPanel.Controls.Clear();
            CadastrarOPPanel.Controls.Add(blocosUC);
        }

        private void Cadastrar_CondominioBtn_Click(object sender, EventArgs e)
        {
            CadastrarOPPanel.Controls.Clear();
            CadastrarOPPanel.Controls.Add(condominiosUC); 
        }
    }
}
