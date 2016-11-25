using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidade;
using Dados;

namespace Negocio
{
    public class PesagemBus : IBusiness<Pesagem>
    {

        public Pesagem buscarPorCodigo(int codigo)
        {
            PesagemDao dao = new PesagemDao();
            try
            {
                return dao.buscarPorCodigo(codigo);
            }
            catch (Exception err)
            {
                throw err;
            }
        }

        public void alterar(Pesagem obj)
        {
            PesagemDao dao = new PesagemDao();
            try
            {

                dao.alterar(obj);

            }
            catch (Exception err)
            {
                throw err;
            }
        }

        public void excluir(Pesagem obj)
        {
            throw new NotImplementedException();
        }

        public void inserir(Pesagem obj)
        {
            PesagemDao dao = new PesagemDao();
            try
            {

                dao.inserir(obj);

            }
            catch (Exception err)
            {
                throw err;
            }
        }

        public List<Pesagem> listar()
        {
            throw new NotImplementedException();
        }
    }
}
