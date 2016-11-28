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
            SqlConnection objConexao = ConnectionFactory.getConexao();
            SqlParameter[] param = new SqlParameter[8]
            {
                new SqlParameter("@codigo", SqlDbType.Int),
                new SqlParameter("@idCliente", SqlDbType.Int),
                new SqlParameter("@placa", SqlDbType.NVarChar),
                new SqlParameter("@cor", SqlDbType.NVarChar),
                new SqlParameter("@modelo", SqlDbType.NVarChar),
                new SqlParameter("@ativo", SqlDbType.Int),
                new SqlParameter("@dataAlteracao", SqlDbType.DateTime),
                new SqlParameter("@usuarioAlteracao", SqlDbType.Int)
                
            };

            param[0].Value = obj.Codigo;
            param[1].Value = obj.Cliente.Codigo;
            param[2].Value = obj.Placa;
            param[3].Value = obj.Cor;
            param[4].Value = obj.Modelo;
            param[5].Value = obj.Ativo;
            param[6].Value = obj.DataAlteracao;
            param[7].Value = obj.UsuarioAlteracao.Codigo;

            string strQuery = "Update Veiculo set "
                + "idCliente = @idCliente, "
                + "placa = @placa, "
                + "cor = @cor, "
                + "modelo= @modelo, "
                + "ativo= @ativo, "
                + "dataAlteracao= @dataAlteracao, "
                + "usuarioAlteracao= @usuarioAlteracao "
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

        public void excluir(Veiculo obj)
        {
            SqlConnection objConexao = ConnectionFactory.getConexao();
            SqlParameter param = new SqlParameter("@codigo", obj.Codigo);
            string strQuery = "Delete from Veiculo where codigo=@codigo";
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

        public void inserir(Veiculo obj)
        {
            SqlConnection objConexao = ConnectionFactory.getConexao();
            SqlParameter[] param = new SqlParameter[7]
            {
                
                new SqlParameter("@idCliente", SqlDbType.Int),
                new SqlParameter("@placa", SqlDbType.NVarChar),
                new SqlParameter("@cor", SqlDbType.NVarChar),
                new SqlParameter("@modelo", SqlDbType.NVarChar),
                new SqlParameter("@ativo", SqlDbType.Int),
                new SqlParameter("@usuarioInclusao", SqlDbType.Int),
                new SqlParameter("@dataInclusao", SqlDbType.DateTime)
                
            };

            param[0].Value = obj.Cliente.Codigo;
            param[1].Value = obj.Placa;
            param[2].Value = obj.Cor;
            param[3].Value = obj.Modelo;
            param[4].Value = obj.Ativo;
            param[5].Value = obj.UsuarioInclusao.Codigo;
            param[6].Value = obj.DataInclusao;

            string strQuery = "Insert into Veiculo(" +
                " idCliente, placa,cor,modelo, ativo,usuarioInclusao,dataInclusao)" +
                " values(@idCliente,@placa, @cor,@modelo, @ativo,@usuarioInclusao,@dataInclusao)";
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

        public List<Veiculo> listar()
        {
            throw new NotImplementedException();
        }
    }
}
