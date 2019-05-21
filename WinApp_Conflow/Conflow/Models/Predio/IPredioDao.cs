using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Conflow.Models.Predio;

namespace Conflow.Models.Predio
{
    interface IPredioDao
    {
        void Adicionar(Predio predio);

        void Remover(Predio predio);

        List<Predio> BuscarTodos();

        Predio BuscarPorCod(Int32 cod);

        List<Predio> BuscarPorId(String id);
    }
}
