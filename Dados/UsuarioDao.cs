using Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace Dados
{
    public class UsuarioDao : IDataAccessObject <Usuario>
    {
        public Usuario buscarPorCodigo(int codigo)
        {
            SqlConnection objConexao = ConnectionFactory.getConexao();
            SqlParameter param = new SqlParameter("codigo", codigo);
            string strQuery = "SELECT * FROM Usuario WHERE codigo=@codigo";
            SqlCommand objCommand = new SqlCommand(strQuery, objConexao);
            objCommand.Parameters.Add(param);
            try
            {
                SqlDataReader objReader = objCommand.ExecuteReader();
                Usuario objUsuario = null;
                if (objReader.Read())
                {
                    objUsuario = new Usuario();
                    objUsuario.Codigo = Convert.ToInt16(objReader["codigo"]);
                    objUsuario.Login = Convert.ToString(objReader["login"]);
                    objUsuario.Senha = Convert.ToString(objReader["senha"]);
                    objUsuario.Nome = Convert.ToString(objReader["nome"]);
                    objUsuario.Ativo = Convert.ToInt16(objReader["ativo"]);
                    objUsuario.DataInclusao = Convert.ToDateTime(objReader["dataInclusao"]);
                    objUsuario.DataAlteracao = Convert.ToDateTime(objReader["dataAlteracao"]);
                    //TESTE COMIT 2
                    
                }
                objReader.Close();
                return objUsuario;
            }
            catch (SqlException err)
            {
                throw err;
            }
        }

        public Usuario validaLogin(string usuario,string senha)
        {
            SqlConnection objConexao = ConnectionFactory.getConexao();
            SqlParameter[] param = new SqlParameter[2]
             {
                new SqlParameter("@login", SqlDbType.NVarChar),
                new SqlParameter("@senha", SqlDbType.NVarChar)
             };
            param[0].Value = usuario;
            param[1].Value = senha;

            string strQuery = "SELECT * FROM Usuario WHERE login = @login and senha = @senha";

            SqlCommand objCommand = new SqlCommand(strQuery, objConexao);
            objCommand.Parameters.AddRange(param);

            try
            {
                SqlDataReader objReader = objCommand.ExecuteReader();
                Usuario objUsuario = null;
                if (objReader.Read())
                {
                    objUsuario = new Usuario();
                    objUsuario.Codigo = Convert.ToInt16(objReader["codigo"]);
                    objUsuario.Login = Convert.ToString(objReader["login"]);
                    objUsuario.Senha = Convert.ToString(objReader["senha"]);
                    objUsuario.Nome = Convert.ToString(objReader["nome"]);
                    objUsuario.Ativo = Convert.ToInt16(objReader["ativo"]);
                    objUsuario.DataInclusao = Convert.ToDateTime(objReader["dataInclusao"]);
                    objUsuario.DataAlteracao = Convert.ToDateTime(objReader["dataAlteracao"]);
                    
                }
                objReader.Close();
                return objUsuario;
            }
            catch (SqlException err)
            {
                throw err;
            }
        }
        public void alterar(Usuario obj)
        {
            SqlConnection objConexao = ConnectionFactory.getConexao();
            SqlParameter[] param = new SqlParameter[6]
            {
                new SqlParameter("@codigo", SqlDbType.Int),
                new SqlParameter("@login", SqlDbType.NVarChar),
                new SqlParameter("@senha", SqlDbType.NVarChar),
                new SqlParameter("@nome", SqlDbType.NVarChar),
                new SqlParameter("@dataAlteracao", SqlDbType.DateTime),
                new SqlParameter("@ativo", SqlDbType.Int)
            };
            param[0].Value = obj.Codigo;
            param[1].Value = obj.Login;
            param[2].Value = obj.Senha;
            param[3].Value = obj.Nome;
            param[4].Value = obj.DataAlteracao;
            param[5].Value = obj.Ativo;


            string strQuery = "Update Usuario set "
                + "login = @login, "
                + "senha = @senha, "
                + "nome = @nome, "
                + "dataAlteracao= getdate(), "
                + "ativo= @ativo"
                + " where codigo=@codigo";

            SqlCommand objCommand = new SqlCommand(strQuery, objConexao);
            objCommand.Parameters.AddRange(param);
            try
            {
                objCommand.ExecuteNonQuery();
            }
            catch (SqlException err)
            {
                throw err;
            }
        }

        public void excluir(Usuario obj)
        {
            SqlConnection objConexao = ConnectionFactory.getConexao();
            SqlParameter param = new SqlParameter("@codigo", obj.Codigo);
            string strQuery = "Delete from Usuario where codigo=@codigo";
            SqlCommand objCommand = new SqlCommand(strQuery, objConexao);
            objCommand.Parameters.Add(param);
            try
            {
                objCommand.ExecuteNonQuery();
            }
            catch (SqlException err)
            {
                throw err;
            }
        }

        public void inserir(Usuario obj)
        {
            SqlConnection objConexao = ConnectionFactory.getConexao();
            SqlParameter[] param = new SqlParameter[5]
            {
                new SqlParameter("@login", SqlDbType.NVarChar),
                new SqlParameter("@senha", SqlDbType.NVarChar),
                new SqlParameter("@nome", SqlDbType.NVarChar),
                new SqlParameter("@dataInclusao", SqlDbType.DateTime),
                new SqlParameter("@ativo", SqlDbType.Int)
            };

            param[0].Value = obj.Login;
            param[1].Value = obj.Senha;
            param[2].Value = obj.Nome;
            param[3].Value = obj.DataInclusao;
            param[4].Value = obj.Ativo;


            string strQuery = "Insert into Usuario(" +
                " login, senha, nome,dataInclusao)" +
                " values(@login, @senha, @nome, @dataInclusao)";
            SqlCommand objCommand = new SqlCommand(strQuery, objConexao);
            objCommand.Parameters.AddRange(param);
            try
            {
                objCommand.ExecuteNonQuery();
            }
            catch (SqlException err)
            {
                throw err;
            }
        }

        public List<Usuario> listar()
        {
            List<Usuario> usuarios = new List<Usuario>();
            SqlConnection objConexao = ConnectionFactory.getConexao();
            string strQuery = "SELECT * FROM Usuario";
            SqlCommand objCommand = new SqlCommand(strQuery, objConexao);
            try
            {
                SqlDataReader objReader = objCommand.ExecuteReader();
                while (objReader.Read())
                {

                    Usuario objUsuario = new Usuario();

                    objUsuario.Codigo = Convert.ToInt16(objReader["codigo"]);
                    objUsuario.Login = Convert.ToString(objReader["login"]);
                    objUsuario.Senha = Convert.ToString(objReader["senha"]);
                    objUsuario.Nome = Convert.ToString(objReader["nome"]);
                    objUsuario.Ativo = Convert.ToInt16(objReader["ativo"]);
                    objUsuario.DataInclusao = Convert.ToDateTime((objReader["dataInclusao"] == DBNull.Value) ? null : objReader["dataInclusao"]); 
                    objUsuario.DataAlteracao = Convert.ToDateTime((objReader["dataAlteracao"] == DBNull.Value) ? null : objReader["dataAlteracao"]);
                    usuarios.Add(objUsuario);
                }
                objReader.Close();
                return usuarios;
            }
            catch (Exception err)
            {
                throw err;
            }
        }
    }
}
