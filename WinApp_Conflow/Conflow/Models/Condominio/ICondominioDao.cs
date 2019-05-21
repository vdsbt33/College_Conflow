using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conflow.Models.Condominio
{
    interface ICondominioDao
    {
        void Adicionar(Condominio condominio);
        void Remover(Condominio condominio);
        List<Condominio> BuscarTodos();
        Condominio BuscarPorCod(Int32 cod);
        List<Condominio> BuscarPorId(String id);
    }
}
