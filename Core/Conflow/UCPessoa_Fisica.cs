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
    public partial class UCPessoa_Fisica : UserControl
    {
        public UCPessoa_Fisica()
        {
            InitializeComponent();
        }

        public MaskedTextBox getCPF()
        {
            return cpfTbox;
        }
    }
}
