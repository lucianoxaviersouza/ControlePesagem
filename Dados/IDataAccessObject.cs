using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dados
{
    
    interface IDataAccessObject<T> where T : new()
    {
        T buscarPorCodigo(int codigo);

        void alterar(T obj);

        void excluir(T obj);

        void inserir(T obj);

        List<T> listar();
    }
}
