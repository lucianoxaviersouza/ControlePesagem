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
    public class VeiculoDao  : IDataAccessObject <Veiculo>
    {
        public Veiculo buscarPorCodigo(int codigo)
        {
            SqlConnection objConexao = ConnectionFactory.getConexao();
            SqlParameter param = new SqlParameter("codigo", codigo);
            string strQuery = "SELECT * FROM Veiculo WHERE codigo=@codigo";
            SqlCommand objCommand = new SqlCommand(strQuery, objConexao);
            objCommand.Parameters.Add(param);
            try
            {
                SqlDataReader objReader = objCommand.ExecuteReader();
                Veiculo objVeiculo = null;

                if (objReader.Read())
                {
                    objVeiculo = new Veiculo();
                    objVeiculo.Codigo = Convert.ToInt16(objReader["codigo"]);
                    objVeiculo.Placa = Convert.ToString(objReader["placa"]);
                    objVeiculo.Cor = Convert.ToString(objReader["cor"]);
                    objVeiculo.Modelo = Convert.ToString(objReader["modelo"]);
                    objVeiculo.Ativo = Convert.ToUInt16(objReader["ativo"]);

                    objVeiculo.DataInclusao = Convert.ToDateTime((objReader["dataInclusao"] == DBNull.Value) ? null : objReader["dataInclusao"]);
                    objVeiculo.DataAlteracao = Convert.ToDateTime((objReader["dataAlteracao"] == DBNull.Value) ? null : objReader["dataAlteracao"]);


                    ClienteDao cli = new ClienteDao();
                    objVeiculo.Cliente = cli.buscarPorCodigo(Convert.ToInt16((objReader["idCliente"] == DBNull.Value) ? null : objReader["idCliente"]));

                    UsuarioDao usuInc = new UsuarioDao();
                    objVeiculo.UsuarioInclusao = usuInc.buscarPorCodigo(Convert.ToInt16((objReader["usuarioInclusao"] == DBNull.Value) ? null : objReader["usuarioInclusao"]));
                    UsuarioDao usuAlt = new UsuarioDao();
                    objVeiculo.UsuarioAlteracao = usuAlt.buscarPorCodigo(Convert.ToInt16((objReader["usuarioalteracao"] == DBNull.Value) ? null : objReader["usuarioAlteracao"]));

                }
                objReader.Close();
                return objVeiculo;
            }
            catch (Exception err)
            {
                throw err;
            }
        }

        public void alterar(Veiculo obj)
        {
            throw new NotImplementedException();
        }

        public void excluir(Veiculo obj)
        {
            throw new NotImplementedException();
        }

        public void inserir(Veiculo obj)
        {
            throw new NotImplementedException();
        }

        public List<Veiculo> listar()
        {
            throw new NotImplementedException();
        }
    }
}
