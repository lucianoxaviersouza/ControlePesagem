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
    public class ClienteDao  : IDataAccessObject <Cliente>
    {

        public Cliente buscarPorCodigo(int codigo)
        {
            SqlConnection objConexao = ConnectionFactory.getConexao();
            SqlParameter param = new SqlParameter("codigo", codigo);
            string strQuery = "SELECT * FROM Cliente WHERE codigo=@codigo";
            SqlCommand objCommand = new SqlCommand(strQuery, objConexao);
            objCommand.Parameters.Add(param);
            try
            {
                SqlDataReader objReader = objCommand.ExecuteReader();
                Cliente objCliente = null;
                if (objReader.Read())
                {
                    objCliente = new Cliente();
                    objCliente.Codigo = Convert.ToInt16(objReader["codigo"]);
                    objCliente.RazaoSocial = Convert.ToString(objReader["razaoSocial"]);
                    objCliente.NomeFantasia = Convert.ToString(objReader["nomeFantasia"]);
                    objCliente.CNPJ = Convert.ToString(objReader["cnpj"]);
                    objCliente.Telefone1 = Convert.ToString(objReader["telefone1"]);
                    objCliente.Telefone2 = Convert.ToString(objReader["telefone2"]);
                    objCliente.Ativo = Convert.ToUInt16(objReader["ativo"]);
                    objCliente.email = Convert.ToString(objReader["email"]);

                    objCliente.DataInclusao = Convert.ToDateTime((objReader["dataInclusao"] == DBNull.Value) ? null : objReader["dataInclusao"]);
                    objCliente.DataAlteracao = Convert.ToDateTime((objReader["dataAlteracao"] == DBNull.Value) ? null : objReader["dataAlteracao"]);

                    UsuarioDao usuInc = new UsuarioDao();
                    objCliente.UsuarioInclusao = usuInc.buscarPorCodigo(Convert.ToInt16((objReader["usuarioInclusao"] == DBNull.Value) ? null : objReader["usuarioInclusao"]));
                    UsuarioDao usuAlt = new UsuarioDao();
                    objCliente.UsuarioAlteracao = usuAlt.buscarPorCodigo(Convert.ToInt16((objReader["usuarioalteracao"] == DBNull.Value) ? null : objReader["usuarioAlteracao"]));

                }
                objReader.Close();
                return objCliente;
            }
            catch (Exception err)
            {
                throw err;
            }
        }

        public void alterar(Cliente obj)
        {
            SqlConnection objConexao = ConnectionFactory.getConexao();
            SqlParameter[] param = new SqlParameter[10]
            {

                new SqlParameter("@codigo", SqlDbType.Int),
                new SqlParameter("@razaoSocial", SqlDbType.NVarChar),
                new SqlParameter("@nomeFantasia", SqlDbType.NVarChar),
                new SqlParameter("@cnpj", SqlDbType.NVarChar),
                new SqlParameter("@telefone1", SqlDbType.NVarChar),
                new SqlParameter("@telefone2", SqlDbType.NVarChar),
                new SqlParameter("@email", SqlDbType.NVarChar),
                new SqlParameter("@ativo", SqlDbType.Int),
                new SqlParameter("@dataAlteracao", SqlDbType.DateTime),
                new SqlParameter("@usuarioAlteracao", SqlDbType.Int)
            };

            param[0].Value = obj.Codigo;
            param[1].Value = obj.RazaoSocial;
            param[2].Value = obj.NomeFantasia;
            param[3].Value = obj.CNPJ;
            param[4].Value = obj.Telefone1;
            param[5].Value = obj.Telefone2;
            param[6].Value = obj.email;
            param[7].Value = obj.Ativo;
            param[8].Value = obj.DataAlteracao;
            param[9].Value = obj.UsuarioAlteracao.Codigo;

            string strQuery = "Update Cliente set "
                + "razaoSocial = @razaoSocial, "
                + "nomeFantasia = @nomeFantasia, "
                + "cnpj = @cnpj, "
                + "telefone1 = @telefone1, "
                + "telefone2 = @telefone2, "
                + "email = @email, "
                + "ativo= @ativo,"
                + "usuarioAlteracao= @usuarioAlteracao,"
                + "dataAlteracao= @dataAlteracao "
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

        public void excluir(Cliente obj)
        {
            SqlConnection objConexao = ConnectionFactory.getConexao();
            SqlParameter param = new SqlParameter("@codigo", obj.Codigo);
            string strQuery = "Delete from Cliente where codigo=@codigo";
            SqlCommand objCommand = new SqlCommand(strQuery, objConexao);
            objCommand.Parameters.Add(param);
            try
            {
                objCommand.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw err;
            }
        }

        public void inserir(Cliente obj)
        {
            SqlConnection objConexao = ConnectionFactory.getConexao();
            SqlParameter[] param = new SqlParameter[9]
            {
                new SqlParameter("@razaoSocial", SqlDbType.NVarChar),
                new SqlParameter("@nomeFantasia", SqlDbType.NVarChar),
                new SqlParameter("@cnpj", SqlDbType.NVarChar),
                new SqlParameter("@telefone1", SqlDbType.NVarChar),
                new SqlParameter("@telefone2", SqlDbType.NVarChar),
                new SqlParameter("@email", SqlDbType.NVarChar),
                new SqlParameter("@ativo", SqlDbType.Int),
                new SqlParameter("@usuarioInclusao", SqlDbType.Int),
                new SqlParameter("@dataInclusao", SqlDbType.DateTime)
                
            };

            param[0].Value = obj.RazaoSocial;
            param[1].Value = obj.NomeFantasia;
            param[2].Value = obj.CNPJ;
            param[3].Value = obj.Telefone1;
            param[4].Value = obj.Telefone2;
            param[5].Value = obj.email;
            param[6].Value = obj.Ativo;
            param[7].Value = obj.UsuarioInclusao.Codigo;
            param[8].Value = obj.DataInclusao;

            string strQuery = "Insert into Cliente(" +
                " razaoSocial, nomeFantasia, cnpj,telefone1,telefone2,email,ativo,usuarioInclusao,dataInclusao)" +
                " values(@razaoSocial, @nomeFantasia,@cnpj,@telefone1,@telefone2,@email,@ativo, @usuarioInclusao, @dataInclusao)";
            SqlCommand objCommand = new SqlCommand(strQuery, objConexao);
            objCommand.Parameters.AddRange(param);
            try
            {
                objCommand.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw err;
            }
        }

        public List<Cliente> listar()
        {
            List<Cliente> clientes = new List<Cliente>();
            SqlConnection objConexao = ConnectionFactory.getConexao();
            string strQuery = "SELECT * FROM Cliente";
            SqlCommand objCommand = new SqlCommand(strQuery, objConexao);
            try
            {
                SqlDataReader objReader = objCommand.ExecuteReader();
                while (objReader.Read())
                {

                    Cliente objCliente = new Cliente();

                    objCliente.Codigo = Convert.ToInt16(objReader["codigo"]);
                    objCliente.RazaoSocial = Convert.ToString(objReader["razaoSocial"]);
                    objCliente.NomeFantasia = Convert.ToString(objReader["nomeFantasia"]);
                    objCliente.CNPJ = Convert.ToString(objReader["cnpj"]);
                    objCliente.Telefone1 = Convert.ToString(objReader["telefone1"]);
                    objCliente.Telefone2 = Convert.ToString(objReader["telefone2"]);
                    objCliente.Ativo = Convert.ToInt16(objReader["ativo"]);
                    objCliente.DataInclusao = Convert.ToDateTime((objReader["dataInclusao"] == DBNull.Value) ? null : objReader["dataInclusao"]);
                    
                    clientes.Add(objCliente);
                }
                objReader.Close();
                return clientes;
            }
            catch (Exception err)
            {
                throw err;
            }
        }
    }
}
