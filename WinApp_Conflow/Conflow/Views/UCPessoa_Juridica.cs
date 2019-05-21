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
    Classe: UCPessoa_Juridica
    Descrição: Contém os métodos do user control UCPessoa_Juridica.
    */
    public partial class UCPessoa_Juridica : UserControl
    {
        /*
        Construtor: UCPessoa_Juridica()
        Descrição: -.
        */
        public UCPessoa_Juridica()
        {
            InitializeComponent();
        }

        /*
        Função: getCNPJ()
        Descrição: Retorna o CNPJ (sem a máscara) inserido no campo.
        */
        public String getCNPJ()
        {
            cnpjTbox.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            return cnpjTbox.Text;
        }
    }
}
