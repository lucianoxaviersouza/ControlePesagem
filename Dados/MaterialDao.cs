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
    public class MaterialDao : IDataAccessObject <Material>

    {
        public Material buscarPorCodigo(int codigo)
        {
            SqlConnection objConexao = ConnectionFactory.getConexao();
            SqlParameter param = new SqlParameter("codigo", codigo);
            string strQuery = "SELECT * FROM Material WHERE codigo=@codigo";
            SqlCommand objCommand = new SqlCommand(strQuery, objConexao);
            objCommand.Parameters.Add(param);
            try
            {
                SqlDataReader objReader = objCommand.ExecuteReader();
                Material objMaterial = null;
                if (objReader.Read())
                {
                    objMaterial = new Material();
                    objMaterial.Codigo = Convert.ToInt16(objReader["codigo"]);
                    objMaterial.Descricao = Convert.ToString(objReader["descricao"]);
                    objMaterial.TipoMaterial.Codigo = Convert.ToInt16(objReader["idTipoMaterial"]);
                    objMaterial.Ativo = Convert.ToInt16(objReader["ativo"]);
                    objMaterial.DataInclusao = Convert.ToDateTime(objReader["dataInclusao"]);

                    UsuarioDao usuInc = new UsuarioDao();
                    objMaterial.UsuarioInclusao = usuInc.buscarPorCodigo(Convert.ToInt16((objReader["usuarioInclusao"] == DBNull.Value) ? null : objReader["usuarioInclusao"])); 
                    
                    
                    objMaterial.DataAlteracao = Convert.ToDateTime(objReader["dataAlteracao"]);

                    UsuarioDao usuAlt = new UsuarioDao();
                    objMaterial.UsuarioAlteracao = usuAlt.buscarPorCodigo(Convert.ToInt16((objReader["usuarioalteracao"] == DBNull.Value) ? null : objReader["usuarioAlteracao"]));

                }
                objReader.Close();
                return objMaterial;
            }
            catch (Exception err)
            {
                throw err;
            }
        }

        public void alterar(Material obj)
        {
            SqlConnection objConexao = ConnectionFactory.getConexao();
            SqlParameter[] param = new SqlParameter[6]
            {
                new SqlParameter("@codigo", SqlDbType.Int),
                new SqlParameter("@descricao", SqlDbType.NVarChar),
                new SqlParameter("@idTipoMaterial", SqlDbType.Int),
                new SqlParameter("@ativo", SqlDbType.Int),
                new SqlParameter("@dataAlteracao", SqlDbType.DateTime),
                new SqlParameter("@usuarioAlteracao", SqlDbType.Int)
                
            };
            param[0].Value = obj.Codigo;
            param[1].Value = obj.Descricao;
            param[2].Value = obj.TipoMaterial.Codigo;
            param[3].Value = obj.Ativo;
            param[4].Value = obj.DataAlteracao;
            param[5].Value = obj.UsuarioAlteracao.Codigo;

            string strQuery = "Update Material set "
                + "descricao = @descricao, "
                + "idTipoMaterial = @idTipoMaterial, "
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
            catch (Exception err)
            {
                throw err;
            }
        }

        public void excluir(Material obj)
        {
            SqlConnection objConexao = ConnectionFactory.getConexao();
            SqlParameter param = new SqlParameter("@codigo", obj.Codigo);
            string strQuery = "Delete from Material where codigo=@codigo";
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

        public void inserir(Material obj)
        {
            SqlConnection objConexao = ConnectionFactory.getConexao();
            SqlParameter[] param = new SqlParameter[5]
            {
                new SqlParameter("@descricao", SqlDbType.NVarChar),
                new SqlParameter("@idTipoMaterial", SqlDbType.Int),
                new SqlParameter("@ativo", SqlDbType.Int),
                new SqlParameter("@usuarioInclusao", SqlDbType.Int),
                new SqlParameter("@dataInclusao", SqlDbType.DateTime)
                
            };

            param[0].Value = obj.Descricao;
            param[1].Value = obj.TipoMaterial.Codigo;
            param[2].Value = obj.Ativo;
            param[3].Value = obj.UsuarioInclusao.Codigo;
            param[4].Value = obj.DataInclusao;


            string strQuery = "Insert into Material(" +
                " descricao, idTipoMaterial, ativo,usuarioInclusao,dataInclusao)" +
                " values(@descricao, @idTipoMaterial,@ativo, @usuarioInclusao, @dataInclusao)";
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

        public void validar(Material obj)
        {
            throw new NotImplementedException();
        }

        public List<Material> listar()
        {
            List<Material> materiais = new List<Material>();
            SqlConnection objConexao = ConnectionFactory.getConexao();
            string strQuery = "SELECT * FROM Material";
            SqlCommand objCommand = new SqlCommand(strQuery, objConexao);
            try
            {
                SqlDataReader objReader = objCommand.ExecuteReader();
                while (objReader.Read())
                {

                    Material objMaterial = new Material();

                    objMaterial.Codigo = Convert.ToInt16(objReader["codigo"]);
                    objMaterial.Descricao = Convert.ToString(objReader["descricao"]);
                    objMaterial.TipoMaterial.Codigo = Convert.ToInt16(objReader["idTipoMaterial"]);
                    objMaterial.Ativo = Convert.ToInt16(objReader["ativo"]);
                    objMaterial.DataInclusao = Convert.ToDateTime((objReader["dataInclusao"] == DBNull.Value) ? null : objReader["dataInclusao"]);
                    objMaterial.DataAlteracao = Convert.ToDateTime((objReader["dataAlteracao"] == DBNull.Value) ? null : objReader["dataAlteracao"]);
                    

                    UsuarioDao usuInc = new UsuarioDao();
                    objMaterial.UsuarioInclusao = usuInc.buscarPorCodigo(Convert.ToInt16((objReader["usuarioInclusao"] == DBNull.Value) ? null : objReader["usuarioInclusao"]));
                    UsuarioDao usuAlt = new UsuarioDao();
                    objMaterial.UsuarioAlteracao = usuAlt.buscarPorCodigo(Convert.ToInt16((objReader["usuarioalteracao"] == DBNull.Value) ? null : objReader["usuarioAlteracao"]));

                    materiais.Add(objMaterial);
                }
                objReader.Close();
                return materiais;
            }
            catch (Exception err)
            {
                throw err;
            }
        }

    }
}
