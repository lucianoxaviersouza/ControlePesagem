using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidade;
using System.Data.SqlClient;
using System.Data;

namespace Dados
{
    public class PesagemDao : IDataAccessObject<Pesagem>
    {
        public Pesagem buscarPorCodigo(int codigo)
        {
            throw new NotImplementedException();
        }

        public void alterar(Pesagem obj)
        {
            throw new NotImplementedException();
        }

        public void excluir(Pesagem obj)
        {
            throw new NotImplementedException();
        }

        public void inserir(Pesagem obj)
        {
            throw new NotImplementedException();
        }

        public List<Pesagem> listar()
        {
            throw new NotImplementedException();
        }
    }
}
