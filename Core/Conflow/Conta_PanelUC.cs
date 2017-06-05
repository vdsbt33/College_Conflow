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
    public partial class Conta_PanelUC : UserControl
    {
        public ContasSQL contaSQL;

        public Conta_PanelUC(ContasSQL contaSQL)
        {
            InitializeComponent();

            this.contaSQL = contaSQL;
        }
        
    }
}
