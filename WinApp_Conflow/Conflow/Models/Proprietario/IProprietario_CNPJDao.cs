using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Conflow.Models.Proprietario;

namespace Conflow.Models.Proprietario
{
    interface IProprietario_CNPJDao
    {
        void Adicionar(Proprietario_CNPJ proprietario_cnpj);

        void Remover(Proprietario_CNPJ proprietario_cnpj);

        List<Proprietario_CNPJ> BuscarTodos();

        Proprietario_CNPJ BuscarPorCod(Int32 cod);

        Proprietario_CNPJ BuscarPorCnpj(String cnpj);
    }
}
