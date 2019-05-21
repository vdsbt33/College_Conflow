using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Conflow.Models.Condominio;

namespace Conflow.Controllers
{
    public class CondominioDao : ICondominioDao
    {
        private List<Condominio> condominios;
        AtalhosSQL sql;

        public CondominioDao()
        {
            condominios = new List<Condominio>();
            sql = new AtalhosSQL();
        }

        public void Adicionar(Condominio condominio)
        {
            String cmdTxt = "INSERT INTO CONDOMINIO(" +
                        "    ID_CONDOMINIO" +
                        "  , TEL_CONTATO_CONDOMINIO" +
                        "  , END_UF_CONDOMINIO" +
                        "  , END_CIDADE_CONDOMINIO" +
                        "  , END_BAIRRO_CONDOMINIO" +
                        "  , END_RUA_CONDOMINIO" +
                        "  , END_NUM_CONDOMINIO" +
                        ") VALUES (" +
                        "    @id" +
                        "  , @tel_contato" +
                        "  , @end_uf" +
                        "  , @end_cidade" +
                        "  , @end_bairro" +
                        "  , @end_rua" +
                        "  , @end_num" +
                        ");";

            sql.comandoSql.Parameters.AddWithValue("id", condominio.ID_CONDOMINIO);
            sql.comandoSql.Parameters.AddWithValue("tel_contato", condominio.TEL_CONTATO_CONDOMINIO);
            sql.comandoSql.Parameters.AddWithValue("end_uf", condominio.END_UF_CONDOMINIO);
            sql.comandoSql.Parameters.AddWithValue("end_cidade", condominio.END_CIDADE_CONDOMINIO);
            sql.comandoSql.Parameters.AddWithValue("end_bairro", condominio.END_BAIRRO_CONDOMINIO);
            sql.comandoSql.Parameters.AddWithValue("end_rua", condominio.END_RUA_CONDOMINIO);
            sql.comandoSql.Parameters.AddWithValue("end_num", condominio.END_NUM_CONDOMINIO);

            sql.ExecutarComandoSql(cmdTxt, "Condomínio adicionado com sucesso.", "Não foi possível adicionar o condomínio");
            
        }

        public void Remover(Condominio condominio)
        {
            String cmdTxt = "REMOVE FROM CONDOMINIO " +
                        "    WHERE COD_CONDOMINIO = @cod;";

            sql.comandoSql.Parameters.AddWithValue("cod", condominio.COD_CONDOMINIO);

            sql.ExecutarComandoSql(cmdTxt, "Condomínio removido com sucesso.", "Não foi possível remover o condomínio");

        }

        public List<Condominio> BuscarTodos()
        {
            String cmdTxt = "SELECT " +
                        "    COD_CONDOMINIO" +
                        "  , ID_CONDOMINIO" +
                        "  , TEL_CONTATO_CONDOMINIO" +
                        "  , END_UF_CONDOMINIO" +
                        "  , END_CIDADE_CONDOMINIO" +
                        "  , END_BAIRRO_CONDOMINIO" +
                        "  , END_RUA_CONDOMINIO" +
                        "  , END_NUM_CONDOMINIO" +
                        "    FROM CONDOMINIO;";
            sql.comandoSql.CommandText = cmdTxt;
            sql.reader = sql.comandoSql.ExecuteReader();

            List<Condominio> resultado = new List<Condominio>();

            while (sql.reader.Read())
            {
                Condominio c = new Condominio();
                c.COD_CONDOMINIO = Convert.ToInt32(sql.reader["COD_CONDOMINIO"].ToString());
                c.ID_CONDOMINIO = sql.reader["ID_CONDOMINIO"].ToString();
                c.TEL_CONTATO_CONDOMINIO = sql.reader["TEL_CONTATO_CONDOMINIO"].ToString();
                c.END_UF_CONDOMINIO = sql.reader["END_UF_CONDOMINIO"].ToString();
                c.END_CIDADE_CONDOMINIO = sql.reader["END_CIDADE_CONDOMINIO"].ToString();
                c.END_BAIRRO_CONDOMINIO = sql.reader["END_BAIRRO_CONDOMINIO"].ToString();
                c.END_RUA_CONDOMINIO = sql.reader["END_RUA_CONDOMINIO"].ToString();
                c.END_NUM_CONDOMINIO = sql.reader["END_NUM_CONDOMINIO"].ToString();

                resultado.Add(c);
            }

            sql.conn.Open();
            

            return condominios;
        }

        public Condominio BuscarPorCod(Int32 cod)
        {
            foreach (Condominio c in condominios)
            {
                if (c.COD_CONDOMINIO == cod)
                {
                    return c;
                }
            }
            return null;
        }

        public List<Condominio> BuscarPorId(String id)
        {
            List<Condominio> resultado = new List<Condominio>();
            foreach (Condominio c in condominios)
            {
                if (c.ID_CONDOMINIO.ToLower() == id.ToLower())
                {
                    resultado.Add(c);
                }
            }

            if (resultado.Count() > 0)
            {
                return resultado;
            }
            else
            {
                return null;
            }
        }

        public bool Salvar()
        {
            throw new NotImplementedException();
        }
    }
}
