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
    public class PesagemDao : IDataAccessObject<Pesagem>
    {
        public Pesagem buscarPorCodigo(int codigo)
        {
            SqlConnection objConexao = ConnectionFactory.getConexao();
            SqlParameter param = new SqlParameter("codigo", codigo);
            string strQuery = "SELECT * FROM Pesagem WHERE codigo=@codigo";
            SqlCommand objCommand = new SqlCommand(strQuery, objConexao);
            objCommand.Parameters.Add(param);


            try
            {
                SqlDataReader objReader = objCommand.ExecuteReader();
                Pesagem objPesagem = null;
                if (objReader.Read())
                {
                    objPesagem = new Pesagem();
                    objPesagem.codigo = Convert.ToInt16(objReader["codigo"]);
                    objPesagem.observacoes = Convert.ToString(objReader["observacoes"]);
                    objPesagem.pesoEntrada = Convert.ToDecimal(objReader["pesoEntrada"]);
                    objPesagem.pesoSaida = Convert.ToDecimal(objReader["pesoSaida"]);
                    objPesagem.DataInclusao = Convert.ToDateTime(objReader["dataInclusao"]);
                    objPesagem.DataAlteracao = Convert.ToDateTime((objReader["dataAlteracao"] == DBNull.Value) ? null : objReader["dataAlteracao"]);
                                                
                    objPesagem.dataHoraEntrada = Convert.ToDateTime(objReader["dataHoraEntrada"]);
                    objPesagem.dataHoraSaida = Convert.ToDateTime((objReader["dataHoraSaida"] == DBNull.Value) ? null : objReader["dataHoraSaida"]); 
                    objPesagem.tipoOperacao = Convert.ToString(objReader["tipoOperacao"]);
                    objPesagem.status = Convert.ToString(objReader["status"]);

                    UsuarioDao usuInc = new UsuarioDao();
                    objPesagem.UsuarioInclusao = usuInc.buscarPorCodigo(Convert.ToInt16((objReader["usuarioInclusao"] == DBNull.Value) ? null : objReader["usuarioInclusao"]));

                    UsuarioDao usuAlt = new UsuarioDao();
                    objPesagem.UsuarioAlteracao = usuAlt.buscarPorCodigo(Convert.ToInt16((objReader["usuarioalteracao"] == DBNull.Value) ? null : objReader["usuarioAlteracao"]));

                    ClienteDao cliente = new ClienteDao();
                    objPesagem.cliente = cliente.buscarPorCodigo(Convert.ToInt16((objReader["codigoCliente"] == DBNull.Value) ? null : objReader["codigoCliente"]));

                    MotoristaDao motorista = new MotoristaDao();
                    objPesagem.motorista = motorista.buscarPorCodigo(Convert.ToInt16((objReader["codigomotorista"] == DBNull.Value) ? null : objReader["codigomotorista"]));

                    VeiculoDao veiculo = new VeiculoDao();
                    objPesagem.veiculo = veiculo.buscarPorCodigo(Convert.ToInt16((objReader["codigoVeiculo"] == DBNull.Value) ? null : objReader["codigoVeiculo"]));

                    MaterialDao material = new MaterialDao();
                    objPesagem.material = material.buscarPorCodigo(Convert.ToInt16((objReader["codigoMaterial"] == DBNull.Value) ? null : objReader["codigoMaterial"]));


                }
                objReader.Close();
                return objPesagem;
            }
            catch (Exception err)
            {
                throw err;
            }
        }

        public void alterar(Pesagem obj)
        {
            
            
            if (!obj.status.Equals("Cancelada"))
            {
            SqlConnection objConexao = ConnectionFactory.getConexao();
            SqlParameter[] param = new SqlParameter[7]
            {
                
                new SqlParameter("@codigo", SqlDbType.Int),
                new SqlParameter("@dataHoraSaida", SqlDbType.DateTime),
                new SqlParameter("@pesoSaida", SqlDbType.Decimal),
                new SqlParameter("@status", SqlDbType.NChar),
                new SqlParameter("@observacoes", SqlDbType.NChar),
                new SqlParameter("@usuarioAlteracao", SqlDbType.Int),
                new SqlParameter("@dataAlteracao", SqlDbType.DateTime)
            };
            param[0].Value = obj.codigo;
            param[1].Value = obj.dataHoraSaida;
            param[2].Value = obj.pesoSaida;
            param[3].Value = obj.status;
            param[4].Value = obj.observacoes;
            param[5].Value = obj.UsuarioAlteracao.Codigo;
            param[6].Value = obj.DataAlteracao;

            string strQuery = "Update Pesagem set "
                + "dataHoraSaida = @dataHoraSaida, "
                + "pesoSaida = @pesoSaida, "
                + "status= @status,"
                + "observacoes= @observacoes,"
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

            }else {

                SqlConnection objConexao = ConnectionFactory.getConexao();
                SqlParameter[] param = new SqlParameter[5]
            {
                
                new SqlParameter("@codigo", SqlDbType.Int),
                new SqlParameter("@status", SqlDbType.NChar),
                new SqlParameter("@observacoes", SqlDbType.NChar),
                new SqlParameter("@usuarioAlteracao", SqlDbType.Int),
                new SqlParameter("@dataAlteracao", SqlDbType.DateTime)
            };
                param[0].Value = obj.codigo;
                param[1].Value = obj.status;
                param[2].Value = obj.observacoes;
                param[3].Value = obj.UsuarioAlteracao.Codigo;
                param[4].Value = obj.DataAlteracao;

                string strQuery = "Update Pesagem set "
                    + "status= @status,"
                    + "observacoes= @observacoes,"
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
            
            
            
            
        }


        public void excluir(Pesagem obj)
        {
            throw new NotImplementedException();
        }

        public void inserir(Pesagem obj)
        {
            SqlConnection objConexao = ConnectionFactory.getConexao();
            SqlParameter[] param = new SqlParameter[11]
            {
                
                new SqlParameter("@codigoCliente", SqlDbType.Int), 
                new SqlParameter("@codigoMotorista", SqlDbType.Int),
                new SqlParameter("@codigoVeiculo", SqlDbType.Int),
                new SqlParameter("@codigoMaterial", SqlDbType.Int),
                new SqlParameter("@dataHoraEntrada", SqlDbType.DateTime),
                new SqlParameter("@pesoEntrada", SqlDbType.Decimal),
                new SqlParameter("@usuarioInclusao", SqlDbType.Int),
                new SqlParameter("@dataInclusao", SqlDbType.DateTime),
                new SqlParameter("@tipoOperacao", SqlDbType.NVarChar),
                new SqlParameter("@status", SqlDbType.NVarChar),
                new SqlParameter("@observacoes", SqlDbType.NVarChar)
                
            };

            param[0].Value = obj.cliente.Codigo;
            param[1].Value = obj.motorista.Codigo;
            param[2].Value = obj.veiculo.Codigo;
            param[3].Value = obj.material.Codigo;
            param[4].Value = obj.dataHoraEntrada;
            param[5].Value = obj.pesoEntrada;
            param[6].Value = obj.UsuarioInclusao.Codigo;
            param[7].Value = obj.DataInclusao;
            param[8].Value = obj.tipoOperacao;
            param[9].Value = obj.status;
            param[10].Value = obj.observacoes;

            string strQuery = "Insert into Pesagem(" +
                "codigoCliente, codigoMotorista, codigoVeiculo, codigoMaterial, " +
                "dataHoraEntrada, pesoEntrada, " +
                "usuarioInclusao, dataInclusao, " +
                "tipoOperacao, status, observacoes) values ( " +
                "@codigoCliente, @codigoMotorista, @codigoVeiculo, @codigoMaterial, " +
                "@dataHoraEntrada, @pesoEntrada, " +
                "@usuarioInclusao, @dataInclusao, " +
                "@tipoOperacao, @status, @observacoes)";
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

        public List<Pesagem> listar()
        {
            throw new NotImplementedException();
        }
    }
}
