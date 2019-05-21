using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Conflow.Models.Proprietario;

namespace Conflow.Controllers
{
    public class Proprietario_ContatoDao : IProprietario_ContatoDao
    {
        List<Proprietario_Contato> proprietarios_contato;

        public Proprietario_ContatoDao()
        {
            proprietarios_contato = new List<Proprietario_Contato>();
        }

        public void Adicionar(Proprietario_Contato proprietario_contato)
        {
            proprietarios_contato.Add(proprietario_contato);
        }

        public void Remover(Proprietario_Contato proprietario_contato)
        {
            proprietarios_contato.Remove(proprietario_contato);
        }

        public List<Proprietario_Contato> BuscarTodos()
        {
            return proprietarios_contato;
        }

        public Proprietario_Contato BuscarPorCod(Int32 cod)
        {
            foreach (Proprietario_Contato p in proprietarios_contato)
            {
                if (p.COD_PROPRIETARIO == cod)
                {
                    return p;
                }
            }
            return null;
        }

        public Proprietario_Contato BuscarPorDsc(String dsc)
        {
            foreach (Proprietario_Contato p in proprietarios_contato)
            {
                if (p.DSC_CONTATO == dsc)
                {
                    return p;
                }
            }
            return null;
        }

        public bool Salvar()
        {
            throw new NotImplementedException();
        }

    }
}
