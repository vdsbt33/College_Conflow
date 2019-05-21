using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;
using System.Configuration;
using Conflow.Models.Morador;
using Conflow.Reporting;
using Conflow.Controllers;

namespace Conflow.Controllers
{

    public class MoradorDao
    {
        AtalhosSQL ComandosSQL = new AtalhosSQL();
        private List<Morador> Moradores = new List<Morador>();

        public void Refresh()
        {
            Moradores.Clear();

            String cmdSelect;

            try
            {
                MySqlCommand cmd = new MySqlCommand();

                cmdSelect = "SELECT MOR.COD_MORADOR, MOR.NOME_MORADOR, MOR.DAT_NASCIMENTO_MORADOR, MOR.DAT_NASCIMENTO_MORADOR, MOR.SEXO_MORADOR, MOR.COD_APARTAMENTO_MORADOR, APA.NUM_APARTAMENTO, PRE.COD_PREDIO, PRE.ID_PREDIO, BLO.ID_BLOCO, CON.ID_CONDOMINIO " +
                            "FROM MORADOR MOR " +
                            "LEFT JOIN APARTAMENTO APA ON APA.COD_APARTAMENTO = MOR.COD_APARTAMENTO_MORADOR " +
                            "LEFT JOIN PREDIO PRE ON PRE.COD_PREDIO = APA.COD_PREDIO " +
                            "LEFT JOIN BLOCO BLO ON BLO.COD_BLOCO = PRE.COD_BLOCO " +
                            "LEFT JOIN CONDOMINIO CON ON CON.COD_CONDOMINIO = BLO.COD_CONDOMINIO ;";
                

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
                            // Lê o DB e salva os dados na DataGridView
                            Moradores.Add(new Morador(Convert.ToInt32(leitor["COD_MORADOR"]),
                                        Convert.ToString(leitor["NOME_MORADOR"]),
                                        Convert.ToDateTime(leitor["DAT_NASCIMENTO_MORADOR"]).ToShortDateString(),
                                        Convert.ToString(leitor["SEXO_MORADOR"]),
                                        Convert.ToInt32(leitor["COD_APARTAMENTO_MORADOR"]),
                                        Convert.ToInt32(leitor["NUM_APARTAMENTO"]),
                                        Convert.ToInt32(leitor["COD_PREDIO"]),
                                        Convert.ToString(leitor["ID_PREDIO"]),
                                        Convert.ToString(leitor["ID_BLOCO"]),
                                        Convert.ToString(leitor["ID_CONDOMINIO"]))
                                        );
                            
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
        

        public List<Morador> GetAll()
        {
            return Moradores;
        }


    }
}
