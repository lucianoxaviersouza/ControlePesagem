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
    public class MotoristaDao  : IDataAccessObject <Motorista>
    {
        public Motorista buscarPorCodigo(int codigo)
        {
            throw new NotImplementedException();
        }

        public void alterar(Motorista obj)
        {
            SqlConnection objConexao = ConnectionFactory.getConexao();
            SqlParameter[] param = new SqlParameter[9]
            {
                new SqlParameter("@codigo", SqlDbType.Int),
                new SqlParameter("@idCliente", SqlDbType.Int),
                new SqlParameter("@nome", SqlDbType.NVarChar),
                new SqlParameter("@sobreNome", SqlDbType.NVarChar),
                new SqlParameter("@nomeConhecido", SqlDbType.NVarChar),
                new SqlParameter("@cpf", SqlDbType.NVarChar),
                new SqlParameter("@ativo", SqlDbType.Int),
                new SqlParameter("@dataAlteracao", SqlDbType.DateTime),
                new SqlParameter("@usuarioAlteracao", SqlDbType.Int)
                
            };
            
            param[0].Value = obj.Codigo;
            param[1].Value = obj.Cliente.Codigo;
            param[2].Value = obj.Nome;
            param[3].Value = obj.Sobrenome;
            param[4].Value = obj.nomeConhecido;
            param[5].Value = obj.CPF;
            param[6].Value = obj.Ativo;
            param[7].Value = obj.DataAlteracao;
            param[8].Value = obj.UsuarioAlteracao.Codigo;

            string strQuery = "Update Motorista set "
                + "idCliente = @idCliente, "
                + "nome = @nome, "
                + "sobreNome= @sobreNome, "
                + "nomeConhecido= @nomeConhecido, "
                + "cpf= @cpf, "
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

        public void excluir(Motorista obj)
        {
            SqlConnection objConexao = ConnectionFactory.getConexao();
            SqlParameter param = new SqlParameter("@codigo", obj.Codigo);
            string strQuery = "Delete from Motorista where codigo=@codigo";
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

        public void inserir(Motorista obj)
        {
            SqlConnection objConexao = ConnectionFactory.getConexao();
            SqlParameter[] param = new SqlParameter[8]
            {
                
                
                
                new SqlParameter("@idCliente", SqlDbType.Int),
                new SqlParameter("@nome", SqlDbType.NVarChar),
                new SqlParameter("@sobreNome", SqlDbType.NVarChar),
                new SqlParameter("@nomeConhecido", SqlDbType.NVarChar),
                new SqlParameter("@cpf", SqlDbType.NVarChar),
                new SqlParameter("@ativo", SqlDbType.Int),
                new SqlParameter("@usuarioInclusao", SqlDbType.Int),
                new SqlParameter("@dataInclusao", SqlDbType.DateTime)
                
            };

            param[0].Value = obj.Cliente.Codigo;
            param[1].Value = obj.Nome;
            param[2].Value = obj.Sobrenome;
            param[3].Value = obj.nomeConhecido;
            param[4].Value = obj.CPF;
            param[5].Value = obj.Ativo;
            param[6].Value = obj.UsuarioInclusao.Codigo;
            param[7].Value = obj.DataInclusao;


            string strQuery = "Insert into Motorista(" +
                " idCliente, nome,sobrenome,nomeConhecido,cpf,ativo,usuarioInclusao,dataInclusao)" +
                " values(@idCliente,@nome, @sobrenome,@nomeConhecido,@cpf,@ativo,@usuarioInclusao,@dataInclusao)";
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

        public List<Motorista> listar()
        {
            throw new NotImplementedException();
        }
    }
}
