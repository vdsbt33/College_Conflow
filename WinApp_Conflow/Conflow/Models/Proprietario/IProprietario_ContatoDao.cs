using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Conflow.Models.Proprietario;

namespace Conflow.Models.Proprietario
{
    interface IProprietario_ContatoDao
    {
        void Adicionar(Proprietario_Contato proprietario_contato);

        void Remover(Proprietario_Contato proprietario_contato);

        List<Proprietario_Contato> BuscarTodos();

        Proprietario_Contato BuscarPorCod(Int32 cod);

        Proprietario_Contato BuscarPorDsc(String dsc);
    }
}
