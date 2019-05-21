using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Conflow.Models.Proprietario;

namespace Conflow.Models.Proprietario
{
    interface IProprietario_CPFDao
    {
        void Adicionar(Proprietario_CPF proprietario_cpf);

        void Remover(Proprietario_CPF proprietario_cpf);

        List<Proprietario_CPF> BuscarTodos();

        Proprietario_CPF BuscarPorCod(Int32 cod);

        Proprietario_CPF BuscarPorCpf(String cpf);
    }
}
