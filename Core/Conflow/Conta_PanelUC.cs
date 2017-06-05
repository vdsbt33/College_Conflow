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
        object cod_conta_conectada = null;

        public Conta_PanelUC(object conta_conectada)
        {
            InitializeComponent();

            this.cod_conta_conectada = conta_conectada;
        }
        
        // Obtem a conta conectada
        public object GetContaConectada
        {
            get
            {
                return cod_conta_conectada;
            }
        }

        // Retorna se está conectado a uma conta ou não
        public bool GetConectado
        {
            get
            {
                if (cod_conta_conectada != null)
                {
                    return true;
                }
                return false;
            }
        }

        // Tenta conectar-se a uma conta e retorna se houve sucesso ou não
        public bool IniciarConexao(String username, String password)
        {
            
            return false;
        }
    }
}
