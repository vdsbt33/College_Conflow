using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Conflow.Views.Cadastro;

namespace Conflow
{
    /*
    Classe: Cadastro_OpcoesUC
    Descrição: Contém os métodos do user control Cadastro_OpcoesUC.
    */
    public partial class Cadastro_OpcoesUC : UserControl
    {
        Cadastro_MoradorUC moradoresUC = new Cadastro_MoradorUC();
        Cadastro_ProprietarioUC proprietariosUC = new Cadastro_ProprietarioUC();
        Cadastro_PredioUC prediosUC = new Cadastro_PredioUC();
        Cadastro_BlocoUC blocosUC = new Cadastro_BlocoUC();
        Cadastro_CondominioUC condominiosUC = new Cadastro_CondominioUC();
        Cadastro_UsuarioUC usuarioUC = new Cadastro_UsuarioUC();


        /*
        Construtor: Cadastro_OpcoesUC()
        Descrição: Inicia automaticamente na tela de Cadastrar Proprietário.
        */
        public Cadastro_OpcoesUC()
        {
            InitializeComponent();

            Cadastrar_ProprietarioBtn_Click(null, new EventArgs());
        }


        /*
        Função: ResetarScroll()
        Descrição: Reseta o scroll do form em CadastrarOPPanel para evitar que o scroll desapareça ao trocar de usercontrol.
        */
        public void ResetarScroll()
        {
            CadastrarOPPanel.VerticalScroll.Value = 0;
            CadastrarOPPanel.HorizontalScroll.Value = 0;
        }


        /*
        Função: Cadastrar_CondominioBtn_Click(object sender, EventArgs e)
        Descrição: Reseta o scroll e abre o usercontrol Cadastrar Condomínio.
        */
        private void Cadastrar_CondominioBtn_Click(object sender, EventArgs e)
        {
            ResetarScroll();
            CadastrarOPPanel.Controls.Clear();
            CadastrarOPPanel.Controls.Add(condominiosUC);

            condominiosUC.AtualizarLocalizacao();
        }


        /*
        Função: Cadastrar_BlocoBtn_Click(object sender, EventArgs e)
        Descrição: Reseta o scroll e abre o usercontrol Cadastrar Bloco.
        */
        private void Cadastrar_BlocoBtn_Click(object sender, EventArgs e)
        {
            ResetarScroll();
            CadastrarOPPanel.Controls.Clear();
            CadastrarOPPanel.Controls.Add(blocosUC);

            blocosUC.AtualizarLocalizacao();
        }


        /*
        Função: Cadastrar_PredioBtn_Click(object sender, EventArgs e)
        Descrição: Reseta o scroll e abre o usercontrol Cadastrar Prédio.
        */
        private void Cadastrar_PredioBtn_Click(object sender, EventArgs e)
        {
            ResetarScroll();
            CadastrarOPPanel.Controls.Clear();
            CadastrarOPPanel.Controls.Add(prediosUC);

            prediosUC.AtualizarLocalizacao();
        }


        /*
        Função: Cadastrar_ProprietarioBtn_Click(object sender, EventArgs e)
        Descrição: Reseta o scroll e abre o usercontrol Cadastrar Proprietário.
        */
        private void Cadastrar_ProprietarioBtn_Click(object sender, EventArgs e)
        {
            ResetarScroll();
            CadastrarOPPanel.Controls.Clear();
            CadastrarOPPanel.Controls.Add(proprietariosUC);

            proprietariosUC.AtualizarLocalizacao();
        }


        /*
        Função: Cadastrar_MoradorBtn_Click(object sender, EventArgs e)
        Descrição: Reseta o scroll e abre o usercontrol Cadastrar Morador.
        */
        private void Cadastrar_MoradorBtn_Click(object sender, EventArgs e)
        {
            ResetarScroll();
            CadastrarOPPanel.Controls.Clear();
            CadastrarOPPanel.Controls.Add(moradoresUC);

            moradoresUC.AtualizarLocalizacao();
        }

        private void Cadastrar_UsuarioBtn_Click(object sender, EventArgs e)
        {
            ResetarScroll();
            CadastrarOPPanel.Controls.Clear();
            CadastrarOPPanel.Controls.Add(usuarioUC);

            usuarioUC.AtualizarLocalizacao();
        }
    }
}
