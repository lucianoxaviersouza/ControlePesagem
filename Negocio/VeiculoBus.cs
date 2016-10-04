using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidade;
using Dados;

namespace Negocio
{
    public class VeiculoBus: IBusiness <Veiculo>
    {
        public Veiculo buscarPorCodigo(int codigo)
        {
            VeiculoDao dao = new VeiculoDao();
            try
            {
                return dao.buscarPorCodigo(codigo);
            }
            catch (Exception err)
            {
                throw err;
            }
        }

        public void alterar(Veiculo obj)
        {
            VeiculoDao dao = new VeiculoDao();
            try
            {
                dao.alterar(obj);
            }
            catch (Exception err)
            {
                throw err;
            }
        }

        public void excluir(Veiculo obj)
        {
            VeiculoDao dao = new VeiculoDao();
            try
            {
                dao.excluir(obj);
            }
            catch (Exception err)
            {
                throw err;
            }
        }

        public void inserir(Veiculo obj)
        {
            VeiculoDao dao = new VeiculoDao();
            try
            {

                dao.inserir(obj);

            }
            catch (Exception err)
            {
                throw err;
            }
        }

        public List<Veiculo> listar()
        {
            VeiculoDao dao = new VeiculoDao();
            try
            {
                return dao.listar();
            }
            catch (Exception err)
            {
                throw err;
            }
        }
    }
}
