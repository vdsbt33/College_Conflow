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
    Classe: UCPessoa_Fisica
    Descrição: Contém os métodos do user control UCPessoa_Fisica.
    */
    public partial class UCPessoa_Fisica : UserControl
    {
        /*
        Construtor: UCPessoa_Fisica()
        Descrição: -.
        */
        public UCPessoa_Fisica()
        {
            InitializeComponent();
        }


        /*
        Função: getCPF()
        Descrição: Retorna o CPF (sem a máscara) inserido no campo.
        */
        public String getCPF()
        {
            cpfTbox.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            return cpfTbox.Text;
        }
    }
}
