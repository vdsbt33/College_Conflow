using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Conflow
{
    public partial class AjudaUC : UserControl
    {
        public AjudaUC()
        {
            InitializeComponent();

            Uri linkAjuda = new Uri(Directory.GetCurrentDirectory() + "\\web\\Ajuda.html");
            webBrowser.Url = linkAjuda;;
        }
    }
}
