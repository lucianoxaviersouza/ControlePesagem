using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dados;
using Entidade;

namespace Negocio
{
    public class MaterialBus : IBusiness <Material>
    {
        public Material buscarPorCodigo(int codigo)
        {
           MaterialDao dao = new MaterialDao();
            try
            {
                return dao.buscarPorCodigo(codigo);
            }
            catch (Exception err)
            {
                throw err;
            }
        }

        public void alterar(Material obj)
        {
            MaterialDao dao = new MaterialDao();
            try
            {
                dao.alterar(obj);
            }
            catch (Exception err)
            {
                throw err;
            }

        }

        public void excluir(Material obj)
        {
            MaterialDao dao = new MaterialDao();
            try
            {
                dao.excluir(obj);
            }
            catch (Exception err)
            {
                throw err;
            }
        }

        public void inserir(Material obj)
        {
            MaterialDao dao = new MaterialDao();
            try
            {

                dao.inserir(obj);

            }
            catch (Exception err)
            {
                throw err;
            }

        }

        public List<Material> listar()
        {
            MaterialDao dao = new MaterialDao();
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
