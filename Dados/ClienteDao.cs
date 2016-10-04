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
            throw new NotImplementedException();
        }

        public void alterar(Cliente obj)
        {
            throw new NotImplementedException();
        }

        public void excluir(Cliente obj)
        {
            throw new NotImplementedException();
        }

        public void inserir(Cliente obj)
        {
            throw new NotImplementedException();
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
                    objCliente.UsuarioInclusao = Convert.ToInt16((objReader["usuarioInclusao"] == DBNull.Value) ? null : objReader["usuarioInclusao"]);
                    objCliente.DataAlteracao = Convert.ToDateTime((objReader["dataAlteracao"] == DBNull.Value) ? null : objReader["dataAlteracao"]);
                    objCliente.UsuarioInclusao = Convert.ToInt16((objReader["usuarioalteracao"] == DBNull.Value) ? null : objReader["usuarioAlteracao"]);

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
