using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicativo_de_Cadastro_de_Serie.Interfaces
{
    internal interface IRepositorio<T>
    {
        List<T> Lista();
        T RetornaPorId(int id);
        void Insere(T entidade);
        void Exclui(int id);
        void Atualiza(int id, T entidade);
        int ProximoId();
    }
}
