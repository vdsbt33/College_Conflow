using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Conflow.Models.Predio;

namespace Conflow.Controllers
{
    public class PredioDao
    {
        private List<Predio> predios;

        public PredioDao()
        {
            predios = new List<Predio>();
        }

        public void Adicionar(Predio predio)
        {
            predios.Add(predio);
        }

        public void Remover(Predio predio)
        {
            predios.Remove(predio);
        }

        public List<Predio> BuscarTodos()
        {
            return predios;
        }

        public Predio BuscarPorCod(Int32 cod)
        {
            foreach (Predio p in predios)
            {
                if (p.COD_PREDIO == cod)
                {
                    return p;
                }
            }
            return null;
        }

        public List<Predio> BuscarPorId(String id)
        {
            List<Predio> resultado = new List<Predio>();
            foreach (Predio p in predios)
            {
                if (p.ID_PREDIO.ToLower() == id.ToLower())
                {
                    resultado.Add(p);
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
