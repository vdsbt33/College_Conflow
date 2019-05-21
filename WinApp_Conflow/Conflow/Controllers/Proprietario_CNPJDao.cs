using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Conflow.Models.Proprietario;

namespace Conflow.Controllers
{
    public class Proprietario_CNPJDao : IProprietario_CNPJDao
    {
        List<Proprietario_CNPJ> proprietarios_cnpj;

        public Proprietario_CNPJDao()
        {
            proprietarios_cnpj = new List<Proprietario_CNPJ>();
        }

        public void Adicionar(Proprietario_CNPJ proprietario_cnpj)
        {
            proprietarios_cnpj.Add(proprietario_cnpj);
        }

        public void Remover(Proprietario_CNPJ proprietario_cnpj)
        {
            proprietarios_cnpj.Remove(proprietario_cnpj);
        }

        public List<Proprietario_CNPJ> BuscarTodos()
        {
            return proprietarios_cnpj;
        }

        public Proprietario_CNPJ BuscarPorCod(Int32 cod)
        {
            foreach (Proprietario_CNPJ p in proprietarios_cnpj)
            {
                if (p.COD_PROPRIETARIO == cod)
                {
                    return p;
                }
            }
            return null;
        }

        public Proprietario_CNPJ BuscarPorCnpj(String cnpj)
        {
            foreach (Proprietario_CNPJ p in proprietarios_cnpj)
            {
                if (p.CNPJ_PROPRIETARIO == cnpj)
                {
                    return p;
                }
            }
            return null;
        }
    }
}
