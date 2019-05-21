using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Conflow.Models.Usuario;

namespace Conflow.Models.Usuario
{
    interface IUsuarioDao
    {
        void Adicionar(Usuario usuario);

        void Remover(Usuario usuario);

        List<Usuario> BuscarTodos();

        Usuario BuscarPorCod(Int32 cod);

        List<Usuario> BuscarPorId(String id);

        List<Usuario> BuscarPorNivel(Int32 nivel);
    }
}
