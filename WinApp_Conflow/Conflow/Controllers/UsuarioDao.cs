using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Conflow.Models.Usuario;

namespace Conflow.Controllers
{
    public class UsuarioDao : IUsuarioDao
    {
        private List<Usuario> usuarios;

        public UsuarioDao()
        {
            usuarios = new List<Usuario>();
        }

        public void Adicionar(Usuario usuario)
        {
            usuarios.Add(usuario);
        }

        public void Remover(Usuario usuario)
        {
            usuarios.Remove(usuario);
        }

        public List<Usuario> BuscarTodos()
        {
            return usuarios;
        }

        public Usuario BuscarPorCod(Int32 cod)
        {
            foreach (Usuario u in usuarios)
            {
                if (u.COD_USUARIO == cod)
                {
                    return u;
                }
            }
            return null;
        }

        public List<Usuario> BuscarPorId(String id)
        {
            List<Usuario> resultado = new List<Usuario>();
            foreach (Usuario u in usuarios)
            {
                if (u.NOME_USUARIO == id)
                {
                    resultado.Add(u);
                }
            }
            return resultado;
        }

        public List<Usuario> BuscarPorNivel(Int32 nivel)
        {
            List<Usuario> resultado = new List<Usuario>();
            foreach (Usuario u in usuarios)
            {
                if (u.NIVEL_USUARIO == nivel)
                {
                    resultado.Add(u);
                }
            }
            return resultado;
        }

    }
}
