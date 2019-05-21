using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Conflow.Models.Proprietario;
using MySql.Data.MySqlClient;

namespace Conflow.Controllers
{
    public class ProprietarioDao
    {
        AtalhosSQL ComandosSQL = new AtalhosSQL();
        private List<Proprietario> Proprietarios = new List<Proprietario>();

        public void Refresh()
        {
            Proprietarios.Clear();

            String cmdSelect;

            try
            {
                MySqlCommand cmd = new MySqlCommand();

                cmdSelect = "SELECT  PRO.COD_PROPRIETARIO               " +
                                               ",PRO.NOME_PROPRIETARIO              " +
                                               ",PRO.DAT_NASCIMENTO_PROPRIETARIO    " +
                                               ",PRO.SEXO_PROPRIETARIO              " +
                                               ",PRO.RG_PROPRIETARIO                " +
                                               ",COALESCE(CPF.CPF_PROPRIETARIO, 'Não possui') 'PROPRIETARIO-CPF_PROPRIETARIO'       " +
                                               ",COALESCE(CNPJ.CNPJ_PROPRIETARIO, 'Não possui') 'PROPRIETARIO-CNPJ_PROPRIETARIO'    " +
                                               ",PRO.END_UF_PROPRIETARIO        " +
                                               ",PRO.END_CIDADE_PROPRIETARIO    " +
                                               ",PRO.END_BAIRRO_PROPRIETARIO    " +
                                               ",PRO.END_RUA_PROPRIETARIO       " +
                                               ",PRO.END_NUM_PROPRIETARIO       " +
                                               ",APA.COD_APARTAMENTO 'PROPRIETARIO-COD_APARTAMENTO' " +
                                               ",APA.NUM_APARTAMENTO 'PROPRIETARIO-NUM_APARTAMENTO' " +
                                               ",PRE.COD_PREDIO 'PROPRIETARIO-COD_PREDIO'" +
                                               ",PRE.ID_PREDIO  'PROPRIETARIO-ID_PREDIO'            " +
                                               ",BLO.ID_BLOCO 'PROPRIETARIO-ID_BLOCO'               " +
                                               ",CON.ID_CONDOMINIO 'PROPRIETARIO-ID_CONDOMINIO'     " +
                                           "FROM PROPRIETARIO PRO           " +
                                           "LEFT JOIN PROPRIETARIO_CPF CPF ON CPF.COD_PROPRIETARIO = PRO.COD_PROPRIETARIO       " +
                                           "LEFT JOIN PROPRIETARIO_CNPJ CNPJ ON CNPJ.COD_PROPRIETARIO = PRO.COD_PROPRIETARIO    " +
                                           "LEFT JOIN APARTAMENTO APA ON APA.COD_APARTAMENTO = PRO.COD_APARTAMENTO_PROPRIETARIO " +
                                           "LEFT JOIN PREDIO PRE ON PRE.COD_PREDIO = APA.COD_PREDIO " +
                                           "LEFT JOIN BLOCO BLO ON BLO.COD_BLOCO = PRE.COD_BLOCO    " +
                                           "LEFT JOIN CONDOMINIO CON ON CON.COD_CONDOMINIO = BLO.COD_CONDOMINIO ";


                if (cmdSelect != "")
                {
                    ComandosSQL.conn = new MySqlConnection(AtalhosSQL.str);
                    ComandosSQL.conn.Open();

                    //
                    cmd.CommandText = cmdSelect;
                    cmd.Connection = ComandosSQL.conn;


                    cmd.Prepare();

                    using (MySqlDataReader leitor = cmd.ExecuteReader())
                    {
                        while (leitor.Read())
                        {
                            if (leitor["PROPRIETARIO-CPF_PROPRIETARIO"].ToString() != "Não possui")
                            {
                                // Lê o DB e salva os dados na DataGridView
                                Proprietarios.Add(new Proprietario(Convert.ToInt32(leitor["COD_PROPRIETARIO"]),
                                                                    Convert.ToString(leitor["NOME_PROPRIETARIO"]),
                                                                    Convert.ToString(leitor["RG_PROPRIETARIO"]),
                                                                    Convert.ToString(leitor["PROPRIETARIO-CPF_PROPRIETARIO"]),
                                                                    Convert.ToString(leitor["SEXO_PROPRIETARIO"]),
                                                                    Convert.ToDateTime(leitor["DAT_NASCIMENTO_PROPRIETARIO"]).ToShortDateString(),
                                                                    Convert.ToString(leitor["END_UF_PROPRIETARIO"]),
                                                                    Convert.ToString(leitor["END_CIDADE_PROPRIETARIO"]),
                                                                    Convert.ToString(leitor["END_BAIRRO_PROPRIETARIO"]),
                                                                    Convert.ToString(leitor["END_RUA_PROPRIETARIO"]),
                                                                    Convert.ToString(leitor["END_NUM_PROPRIETARIO"]),
                                                                    Convert.ToString(leitor["PROPRIETARIO-ID_CONDOMINIO"]),
                                                                    Convert.ToString(leitor["PROPRIETARIO-ID_BLOCO"]),
                                                                    Convert.ToString(leitor["PROPRIETARIO-ID_PREDIO"]),
                                                                    Convert.ToInt32(leitor["PROPRIETARIO-NUM_APARTAMENTO"]))
                                                                    );
                            }
                            else
                            {
                                // Lê o DB e salva os dados na DataGridView
                                Proprietarios.Add(new Proprietario(Convert.ToInt32(leitor["COD_PROPRIETARIO"]),
                                                                    Convert.ToString(leitor["NOME_PROPRIETARIO"]),
                                                                    Convert.ToString(leitor["RG_PROPRIETARIO"]),
                                                                    Convert.ToString(leitor["PROPRIETARIO-CNPJ_PROPRIETARIO"]),
                                                                    Convert.ToString(leitor["SEXO_PROPRIETARIO"]),
                                                                    Convert.ToDateTime(leitor["DAT_NASCIMENTO_PROPRIETARIO"]).ToShortDateString(),
                                                                    Convert.ToString(leitor["END_UF_PROPRIETARIO"]),
                                                                    Convert.ToString(leitor["END_CIDADE_PROPRIETARIO"]),
                                                                    Convert.ToString(leitor["END_BAIRRO_PROPRIETARIO"]),
                                                                    Convert.ToString(leitor["END_RUA_PROPRIETARIO"]),
                                                                    Convert.ToString(leitor["END_NUM_PROPRIETARIO"]),
                                                                    Convert.ToString(leitor["PROPRIETARIO-ID_CONDOMINIO"]),
                                                                    Convert.ToString(leitor["PROPRIETARIO-ID_BLOCO"]),
                                                                    Convert.ToString(leitor["PROPRIETARIO-ID_PREDIO"]),
                                                                    Convert.ToInt32(leitor["PROPRIETARIO-NUM_APARTAMENTO"]))
                                                                    );
                            }
                            
                            
                        }
                    }
                }

            }
            catch (Exception ee)
            {
                System.Windows.Forms.MessageBox.Show(ee.Message);
            }

            ComandosSQL.conn.Close();


        }


        public List<Proprietario> GetAll()
        {
            return Proprietarios;
        }

    }
}
