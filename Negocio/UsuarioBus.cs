using Dados;
using Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class UsuarioBus : IBusiness <Usuario>

    {
        public Usuario buscarPorCodigo(int codigo)
        {
            UsuarioDao dao = new UsuarioDao();
            try
            {
                return dao.buscarPorCodigo(codigo);
            }
            catch (Exception err)
            {
                throw err;
            }
        }

        public Usuario validaLogin(string usuario,string senha)
        {
            UsuarioDao dao = new UsuarioDao();
            try
            {
                return dao.validaLogin(usuario, senha);
            }
            catch (Exception err)
            {
                throw err;
            }
        }

        public void alterar(Usuario obj)
        {
            UsuarioDao dao = new UsuarioDao();
            try
            {
                dao.alterar(obj);
            }
            catch (Exception err)
            {
                throw err;
            }

        }

        public void excluir(Usuario obj)
        {
            UsuarioDao dao = new UsuarioDao();
            try
            {
                dao.excluir(obj);
            }
            catch (Exception err)
            {
                throw err;
            }
        }

        public void inserir(Usuario obj)
        {
            UsuarioDao dao = new UsuarioDao();
            try
            {
                
                dao.inserir(obj);
                
            }
            catch (Exception err)
            {
                throw err;
            }

        }

        public List<Usuario> listar()
        {
            UsuarioDao dao = new UsuarioDao();
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
