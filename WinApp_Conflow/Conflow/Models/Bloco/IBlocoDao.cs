using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Conflow.Models.Bloco;

namespace Conflow.Models.Bloco
{
    interface IBlocoDao
    {
        void Adicionar(Bloco bloco);

        void Remover(Bloco bloco);

        List<Bloco> BuscarTodos();

        Bloco BuscarPorCod(Int32 cod);

        List<Bloco> BuscarPorId(String id);
    }
}
