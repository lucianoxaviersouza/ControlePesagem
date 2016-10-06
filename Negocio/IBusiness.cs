using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public interface IBusiness<T> where T : new()
    {
        T buscarPorCodigo(int codigo);

        void alterar(T obj);

        void excluir(T obj);

        void inserir(T obj);

        List<T> listar();
        
    }
}
