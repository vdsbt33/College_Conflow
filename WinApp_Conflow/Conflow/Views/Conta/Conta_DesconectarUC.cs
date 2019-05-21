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
    Classe: Conta_DesconectarUC
    Descrição: Contém os métodos do user control Conta_DesconectarUC.
    */
    public partial class Conta_DesconectarUC : UserControl
    {
        public ContasSQL contaSQL;


        /*
        Construtor: Conta_DesconectarUC(ContasSQL contaSQL)
        Descrição: Recebe qual a conta conectada.
        */
        public Conta_DesconectarUC(ContasSQL contaSQL)
        {
            InitializeComponent();

            this.contaSQL = contaSQL;
        }


        /*
        Função: DesconectarBtn_Click(object sender, EventArgs e)
        Descrição: Desconecta o usuário da conta.
        */
        private void DesconectarBtn_Click(object sender, EventArgs e)
        {
            contaSQL.SairConta();
        }
    }
}

