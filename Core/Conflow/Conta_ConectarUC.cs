using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Conflow
{
    public partial class Conta_ConectarUC : UserControl
    {
        public ContasSQL contaSQL;

        public Conta_ConectarUC(ContasSQL contaSQL)
        {
            InitializeComponent();

            this.contaSQL = contaSQL;
        }

        private void ConectarBtn_Click(object sender, EventArgs e)
        {
            passwordTbox.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            contaSQL.EntrarConta(usernameTbox.Text, passwordTbox.Text);
            passwordTbox.TextMaskFormat = MaskFormat.IncludeLiterals;
        }
    }
}
