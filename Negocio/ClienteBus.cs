using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dados;
using Entidade;


namespace Negocio
{
    public class ClienteBus: IBusiness <Cliente>
    {
        public Cliente buscarPorCodigo(int codigo)
        {
            ClienteDao dao = new ClienteDao();
            try
            {
                return dao.buscarPorCodigo(codigo);
            }
            catch (Exception err)
            {
                throw err;
            }

        }

        public void alterar(Cliente obj)
        {
            ClienteDao dao = new ClienteDao();
            try
            {
                dao.alterar(obj);
            }
            catch (Exception err)
            {
                throw err;
            }

        }

        public void excluir(Cliente obj)
        {
            ClienteDao dao = new ClienteDao();
            try
            {
                dao.excluir(obj);
            }
            catch (Exception err)
            {
                throw err;
            }

        }

        public void inserir(Cliente obj)
        {
            ClienteDao dao = new ClienteDao();
            try
            {

                dao.inserir(obj);

            }
            catch (Exception err)
            {
                throw err;
            }

        }

        public List<Cliente> listar()
        {
           ClienteDao dao = new ClienteDao();
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
