using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dados;
using Entidade;

namespace Negocio
{
    public class MotoristaBus: IBusiness <Motorista>
    {
        public Motorista buscarPorCodigo(int codigo)
        {
            MotoristaDao dao = new MotoristaDao();
            try
            {
                return dao.buscarPorCodigo(codigo);
            }
            catch (Exception err)
            {
                throw err;
            }
        }

        public void alterar(Motorista obj)
        {
            MotoristaDao dao = new MotoristaDao();
            try
            {
                dao.alterar(obj);
            }
            catch (Exception err)
            {
                throw err;
            }
        }

        public void excluir(Motorista obj)
        {
            MotoristaDao dao = new MotoristaDao();
            try
            {
                dao.excluir(obj);
            }
            catch (Exception err)
            {
                throw err;
            }
        }

        public void inserir(Motorista obj)
        {
            MotoristaDao dao = new MotoristaDao();
            try
            {

                dao.inserir(obj);

            }
            catch (Exception err)
            {
                throw err;
            }
        }

        public List<Motorista> listar()
        {
            MotoristaDao dao = new MotoristaDao();
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
