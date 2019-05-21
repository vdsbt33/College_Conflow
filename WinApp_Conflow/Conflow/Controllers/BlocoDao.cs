using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Conflow.Models.Bloco;

namespace Conflow.Controllers
{
    public class BlocoDao : IBlocoDao
    {
        private List<Bloco> blocos;

        public BlocoDao()
        {
            blocos = new List<Bloco>();
        }

        public void Adicionar(Bloco bloco)
        {
            blocos.Add(bloco);
        }

        public void Remover(Bloco bloco)
        {
            blocos.Remove(bloco);
        }

        public List<Bloco> BuscarTodos()
        {
            return blocos;
        }

        public Bloco BuscarPorCod(Int32 cod)
        {
            foreach (Bloco b in blocos)
            {
                if (b.COD_BLOCO == cod)
                {
                    return b;
                }
            }
            return null;
        }

        public List<Bloco> BuscarPorId(String id)
        {
            List<Bloco> resultado = new List<Bloco>();
            foreach (Bloco b in blocos)
            {
                if (b.ID_BLOCO.ToLower() == id.ToLower())
                {
                    resultado.Add(b);
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
