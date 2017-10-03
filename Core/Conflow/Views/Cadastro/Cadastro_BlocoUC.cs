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
    Classe: Cadastro_BlocoUC
    Descrição: Contém os métodos do user control Cadastro_BlocoUC.
    */
    public partial class Cadastro_BlocoUC : UserControl
    {
        /*
        Construtor: AjudaUC()
        Descrição: -.
        */
        public Cadastro_BlocoUC()
        {
            InitializeComponent();
        }

        AtalhosSQL ComandosSQL = new AtalhosSQL();

        /*
        Função: CriarBtn_Click(object sender, EventArgs e)
        Descrição: Adiciona o Bloco ao Banco de Dados.
        */
        private void CriarBtn_Click(object sender, EventArgs e)
        {

            DataGridViewSelectedRowCollection linhaSelecionada = condominioList.SelectedRows;
            
            // Insere um novo bloco no DB
            if (identificadorTbox.Text.Length > 0 && condominioList.SelectedRows.Count > 0)
            {
                
                String cmdTxt = "INSERT INTO BLOCO(" +
                                "    ID_BLOCO" +
                                "  , COD_CONDOMINIO" +
                                ") VALUES(" +
                                    "@id" +
                                  ", @cod" +
                                ");";

                ComandosSQL.comandoSql.Parameters.AddWithValue("id", identificadorTbox.Text);
                ComandosSQL.comandoSql.Parameters.AddWithValue("cod", linhaSelecionada[0].Cells["COD_CONDOMINIO"].Value);

                // Limpa os campos
                identificadorTbox.Clear();
                AtualizarLocalizacao();
                ComandosSQL.ExecutarComandoSql(cmdTxt, "Novo bloco adicionado com sucesso!", "Não foi possível adicionar o bloco.");
                
            }
            else
            {
                MessageBox.Show("Erro: Um ou mais campos não foram preenchidos.");
            }

            
        }


        /*
        Função: AtualizarLocalizacao()
        Descrição: Atualiza as listas do grupo Localização.
        */
        public void AtualizarLocalizacao()
        {
            

            try
            {
                ComandosSQL.conn = new MySqlConnection(AtalhosSQL.str);
                ComandosSQL.conn.Open();

                // Condominios
                condominioList.Rows.Clear();

                String cmdSelect = "SELECT COD_CONDOMINIO, ID_CONDOMINIO FROM CONDOMINIO";
                MySqlCommand cmd = new MySqlCommand(cmdSelect, ComandosSQL.conn);
                cmd.Prepare();
                using (MySqlDataReader leitor = cmd.ExecuteReader())
                {
                    while (leitor.Read())
                    {
                        int index = condominioList.Rows.Add();
                        DataGridViewRow linhaTabela = condominioList.Rows[index];
                        linhaTabela.Cells["COD_CONDOMINIO"].Value = leitor["COD_CONDOMINIO"];
                        linhaTabela.Cells["ID_CONDOMINIO"].Value = leitor["ID_CONDOMINIO"];
                    }
                }
                
            }
            catch (Exception e)
            {
                MessageBox.Show("Um erro ocorreu ao tentar ler o banco de dados. \nDescrição: " + e.Message);
            }

            ComandosSQL.conn.Close();

        }

    }
}
