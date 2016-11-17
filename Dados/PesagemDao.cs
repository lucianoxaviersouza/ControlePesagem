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
            throw new NotImplementedException();
        }

        public void alterar(Pesagem obj)
        {
            throw new NotImplementedException();
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
