using Dados;
using Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class TipoMaterialBus : IBusiness <TipoMaterial>

    {

        public TipoMaterial buscarPorCodigo(int codigo)
        {
            TipoMaterialDao dao = new TipoMaterialDao();
            try
            {
                return dao.buscarPorCodigo(codigo);
            }
            catch (Exception err)
            {
                throw err;
            }
        }

        public void alterar(TipoMaterial obj)
        {
            TipoMaterialDao dao = new TipoMaterialDao();
            try
            {
                dao.alterar(obj);
            }
            catch (Exception err)
            {
                throw err;
            }

        }

        public void excluir(TipoMaterial obj)
        {
            TipoMaterialDao dao = new TipoMaterialDao();
            try
            {
                dao.excluir(obj);
            }
            catch (Exception err)
            {
                throw err;
            }
        }

        public void inserir(TipoMaterial obj)
        {
            TipoMaterialDao dao = new TipoMaterialDao();
            try
            {

                dao.inserir(obj);

            }
            catch (Exception err)
            {
                throw err;
            }

        }

        public List<TipoMaterial> listar()
        {
            TipoMaterialDao dao = new TipoMaterialDao();
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
