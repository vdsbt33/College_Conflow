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
    public partial class Conta_DesconectarUC : UserControl
    {
        public ContasSQL contaSQL;

        public Conta_DesconectarUC(ContasSQL contaSQL)
        {
            InitializeComponent();

            this.contaSQL = contaSQL;
        }

        private void DesconectarBtn_Click(object sender, EventArgs e)
        {
            contaSQL.SairConta();
        }
    }
}
