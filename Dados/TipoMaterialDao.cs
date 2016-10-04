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
    public class TipoMaterialDao: IDataAccessObject <TipoMaterial>
    {
        public TipoMaterial buscarPorCodigo(int codigo)
        {
            SqlConnection objConexao = ConnectionFactory.getConexao();
            SqlParameter param = new SqlParameter("codigo", codigo);
            string strQuery = "SELECT * FROM TipoMaterial WHERE codigo=@codigo";
            SqlCommand objCommand = new SqlCommand(strQuery, objConexao);
            objCommand.Parameters.Add(param);
            try
            {
                SqlDataReader objReader = objCommand.ExecuteReader();
                TipoMaterial objTipoMaterial = null;
                if (objReader.Read())
                {
                    objTipoMaterial = new TipoMaterial();
                    objTipoMaterial.Codigo = Convert.ToInt16(objReader["codigo"]);
                    objTipoMaterial.Descricao = Convert.ToString(objReader["descricao"]);
                    objTipoMaterial.Ativo = Convert.ToInt16(objReader["ativo"]);
                    objTipoMaterial.DataInclusao = Convert.ToDateTime(objReader["dataInclusao"]);

                    UsuarioDao usuInc = new UsuarioDao();
                    objTipoMaterial.UsuarioInclusao = usuInc.buscarPorCodigo(Convert.ToInt16((objReader["usuarioInclusao"] == DBNull.Value) ? null : objReader["usuarioInclusao"])); 
                    
                    objTipoMaterial.DataAlteracao = Convert.ToDateTime(objReader["dataAlteracao"]);
                    
                    UsuarioDao usuAlt = new UsuarioDao();
                    objTipoMaterial.UsuarioAlteracao= usuAlt.buscarPorCodigo(Convert.ToInt16((objReader["usuarioalteracao"] == DBNull.Value) ? null : objReader["usuarioAlteracao"]));
                }

                objReader.Close();

                return objTipoMaterial;

            }
            catch (SqlException err)
            {
                throw err;
            }
        }

        public void alterar(TipoMaterial obj)
        {
            SqlConnection objConexao = ConnectionFactory.getConexao();
            SqlParameter[] param = new SqlParameter[5]
            {
                new SqlParameter("@codigo", SqlDbType.Int),
                new SqlParameter("@descricao", SqlDbType.NVarChar),
                new SqlParameter("@ativo", SqlDbType.Int),
                new SqlParameter("@dataAlteracao", SqlDbType.DateTime),
                new SqlParameter("@usuarioAlteracao", SqlDbType.Int)
            };
            param[0].Value = obj.Codigo;
            param[1].Value = obj.Descricao;
            param[2].Value = obj.Ativo;
            param[3].Value = obj.DataAlteracao;
            param[3].Value = obj.UsuarioAlteracao.Codigo;

            string strQuery = "Update TipoMaterial set "
                + "descricao = @descricao, "
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

        public void excluir(TipoMaterial obj)
        {
            SqlConnection objConexao = ConnectionFactory.getConexao();
            SqlParameter param = new SqlParameter("@codigo", obj.Codigo);

            string strQuery = "Delete from TipoMaterial where codigo=@codigo";
            
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

        public void inserir(TipoMaterial obj)
        {
            SqlConnection objConexao = ConnectionFactory.getConexao();
            SqlParameter[] param = new SqlParameter[4]
            {
                new SqlParameter("@descricao", SqlDbType.NVarChar),
                new SqlParameter("@ativo", SqlDbType.Int),
                new SqlParameter("@dataInclusao", SqlDbType.DateTime),
                new SqlParameter("@usuarioInclusao", SqlDbType.Int)
                
            };

            param[0].Value = obj.Descricao;
            param[1].Value = obj.Ativo;
            param[2].Value = obj.DataInclusao;
            param[3].Value = obj.UsuarioInclusao.Codigo;


            string strQuery = "Insert into TipoMaterial(" +
                " descricao, ativo, dataInclusao,usuarioInclusao)" +
                " values(@descricao, @ativo, @dataInclusao, @usuarioInclusao)";
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

        public List<TipoMaterial> listar()
        {
            List<TipoMaterial> tipoMateriais = new List<TipoMaterial>();
            SqlConnection objConexao = ConnectionFactory.getConexao();
            string strQuery = "SELECT * FROM TipoMaterial";
            SqlCommand objCommand = new SqlCommand(strQuery, objConexao);
            try
            {
                SqlDataReader objReader = objCommand.ExecuteReader();
                while (objReader.Read())
                {

                    TipoMaterial objTipoMaterial = new TipoMaterial();

                    objTipoMaterial.Codigo = Convert.ToInt16(objReader["codigo"]);
                    objTipoMaterial.Descricao = Convert.ToString(objReader["descricao"]);
                    objTipoMaterial.Ativo = Convert.ToInt16(objReader["ativo"]);
                    objTipoMaterial.DataInclusao = Convert.ToDateTime((objReader["dataInclusao"] == DBNull.Value) ? null : objReader["dataInclusao"]);
                    objTipoMaterial.DataAlteracao = Convert.ToDateTime((objReader["dataAlteracao"] == DBNull.Value) ? null : objReader["dataAlteracao"]);

                    UsuarioDao usuInc = new UsuarioDao();
                    objTipoMaterial.UsuarioInclusao = usuInc.buscarPorCodigo(Convert.ToInt16((objReader["usuarioInclusao"] == DBNull.Value) ? null : objReader["usuarioInclusao"]));
                    UsuarioDao usuAlt = new UsuarioDao();
                    objTipoMaterial.UsuarioAlteracao = usuAlt.buscarPorCodigo(Convert.ToInt16((objReader["usuarioalteracao"] == DBNull.Value) ? null : objReader["usuarioAlteracao"]));


                    tipoMateriais.Add(objTipoMaterial);
                }
                objReader.Close();
                return tipoMateriais;
            }
            catch (Exception err)
            {
                throw err;
            }
        }
    }
}
