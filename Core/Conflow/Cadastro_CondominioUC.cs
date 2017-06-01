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
    public partial class Cadastro_CondominioUC : UserControl
    {
        public Cadastro_CondominioUC()
        {
            InitializeComponent();
        }

        AtalhosSQL ComandosSQL = new AtalhosSQL();
        

        private void CriarBtn_Click(object sender, EventArgs e)
        {
            if (nomeDoCondominioTbox.Text.Length > 0 && telefoneTbox.Text.Length > 0 && estadoCBox.SelectedIndex != -1 && bairroTbox.Text.Length > 0 && ruaTBox.Text.Length > 0)
            {
                telefoneTbox.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

                String cmdTxt = "INSERT INTO CONDOMINIO(" +
                                "    ID_CONDOMINIO" +
                                "  , TEL_CONTATO_CONDOMINIO" +
                                "  , END_UF_CONDOMINIO" +
                                "  , END_CIDADE_CONDOMINIO" +
                                "  , END_BAIRRO_CONDOMINIO" +
                                "  , END_RUA_CONDOMINIO" +
                                "  , END_NUM_CONDOMINIO" +
                                ") VALUES(" +
                                String.Format(" '{0}' ", nomeDoCondominioTbox.Text) +
                                String.Format(",'{0}' ", telefoneTbox.Text) +
                                String.Format(",'{0}' ", estadoCBox.Text) +
                                String.Format(",'{0}' ", cidadeTBox.Text) +
                                String.Format(",'{0}' ", bairroTbox.Text) +
                                String.Format(",'{0}' ", ruaTBox.Text) +
                                String.Format(",'{0}' ", localNumeroNud.Text) +
                                ");";

                ComandosSQL.ExecutarComandoSql(cmdTxt, "Novo condomínio cadastrado com sucesso!", "Não foi possível cadastrar o condomínio.");
            }
            else
            {
                MessageBox.Show("Erro: Um ou mais campos não foram preenchidos.");
            }
            
        }
    }
}
