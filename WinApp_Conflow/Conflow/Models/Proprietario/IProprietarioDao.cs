using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Conflow.Models.Proprietario;

namespace Conflow.Models.Proprietario
{
    interface IProprietarioDao
    {
        void Adicionar(Proprietario proprietario);

        void Remover(Proprietario proprietario);

        List<Proprietario> BuscarTodos();

        Proprietario BuscarPorCod(Int32 cod);

        List<Proprietario> BuscarPorId(String id);
    }
}
