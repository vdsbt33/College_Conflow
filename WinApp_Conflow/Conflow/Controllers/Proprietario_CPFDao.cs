using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Conflow.Models.Proprietario;

namespace Conflow.Controllers
{
    public class Proprietario_CPFDao : IProprietario_CPFDao
    {
        private List<Proprietario_CPF> proprietarios_cpf = new List<Proprietario_CPF>();

        public void Adicionar(Proprietario_CPF proprietario_cpf)
        {
            proprietarios_cpf.Add(proprietario_cpf);
        }

        public void Remover(Proprietario_CPF proprietario_cpf)
        {
            proprietarios_cpf.Remove(proprietario_cpf);
        }

        public List<Proprietario_CPF> BuscarTodos()
        {
            return proprietarios_cpf;
        }

        public Proprietario_CPF BuscarPorCod(Int32 cod)
        {
            foreach (Proprietario_CPF p in proprietarios_cpf)
            {
                if (p.COD_PROPRIETARIO == cod)
                {
                    return p;
                }
            }
            return null;
        }

        public Proprietario_CPF BuscarPorCpf(String cpf)
        {
            foreach (Proprietario_CPF p in proprietarios_cpf)
            {
                if (p.CPF_PROPRIETARIO == cpf)
                {
                    return p;
                }
            }
            return null;
        }

    }
}
