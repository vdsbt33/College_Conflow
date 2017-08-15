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
    /*
    Classe: Conta_PanelUC
    Descrição: Contém os métodos do user control Conta_PanelUC.
    */
    public partial class Conta_PanelUC : UserControl
    {
        public ContasSQL contaSQL;

        /*
        Construtor: Conta_PanelUC(ContasSQL contaSQL)
        Descrição: Recebe qual a conta conectada.
        */
        public Conta_PanelUC(ContasSQL contaSQL)
        {
            InitializeComponent();

            this.contaSQL = contaSQL;
        }
        
    }
}
