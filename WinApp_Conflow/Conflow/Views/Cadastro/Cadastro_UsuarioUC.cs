using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Conflow.Controllers;

namespace Conflow.Views.Cadastro
{
    public partial class Cadastro_UsuarioUC : UserControl
    {
        public Cadastro_UsuarioUC()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!exibirSenhaCbox.Checked)
            {
                senhaTbox.PasswordChar = Convert.ToChar("*");
            }
            else
            {
                senhaTbox.PasswordChar = Convert.ToChar(0);
            }
        }

        private void CriarBtn_Click(object sender, EventArgs e)
        {
            if (nomeTbox.Text.Length > 0 && senhaTbox.Text.Length > 0 && prioridadeCombobox.SelectedItem != null) { 
                AtalhosSQL sql = new AtalhosSQL();
                sql.comandoSql.Parameters.AddWithValue("nome", nomeTbox.Text);
                sql.comandoSql.Parameters.AddWithValue("senha", senhaTbox.Text);
                if (prioridadeCombobox.SelectedItem.ToString() == "Administrador")
                {
                    sql.comandoSql.Parameters.AddWithValue("prioridade", 2);
                }
                else if (prioridadeCombobox.SelectedItem.ToString() == "Funcionário")
                {
                    sql.comandoSql.Parameters.AddWithValue("prioridade", 1);
                }
                else
                {
                    sql.comandoSql.Parameters.AddWithValue("prioridade", 0);
                }
            
                sql.ExecutarComandoSql("INSERT INTO usuario ( NOME_USUARIO, SENHA_USUARIO, NIVEL_USUARIO ) VALUES ( @nome, @senha, @prioridade );", "Usuário adicionado com sucesso.", "erro");

            }
            else
            {
                MessageBox.Show("É obrigatório preencher todos os campos.");
            }
        }

        public void AtualizarLocalizacao()
        {
            nomeTbox.Focus();
        }
    }
}
