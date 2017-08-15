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
    /*
    Classe: AjudaUC
    Descrição: Contém os métodos do user control AjudaUC.
    */
    public partial class AjudaUC : UserControl
    {
        /*
        Construtor: AjudaUC()
        Descrição: Exibe a página HTML de ajuda ao criar uma instância da classe.
        */
        public AjudaUC()
        {
            InitializeComponent();

            Uri linkAjuda = new Uri(Directory.GetCurrentDirectory() + "\\web\\Ajuda.html");
            webBrowser.Url = linkAjuda;;
        }
    }
}
