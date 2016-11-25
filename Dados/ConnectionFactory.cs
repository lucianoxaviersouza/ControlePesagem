using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public class ConnectionFactory
    {
        //String de conexão com o banco
        private String strCon =
        //    "Data Source=localhost\\NOTE-LXS;Initial Catalog=ControlePesagem;Integrated Security=True";
        //    "Server=127.0.0.1:1433\NOTE-LXS;Database=ControlePesagem;User Id=sa;Password=mogi@012;
        "Data Source=127.0.0.1;Initial Catalog=ControlePesagem;MultipleActiveResultSets=True;Integrated Security=SSPI;User ID=NOTE-LXS\\sa;Password=mogi@012";
       //"Data Source=127.0.0.1;Initial Catalog=ControlePesagem;Integrated Security=SSPI;User ID=WIN-U5B82DOANL5\\sa;Password=mogi@012";

        //Objeto de conexão
        private static SqlConnection objConexao = null;
        //Construtor
        public ConnectionFactory()
        {
            objConexao = new SqlConnection();
            objConexao.ConnectionString = strCon;
            objConexao.Open();
        }
        //Método estátio que estabelece a conexao com o banco
        public static SqlConnection getConexao()
        {
            if (objConexao == null)
            {
                new ConnectionFactory();
            }
            return objConexao;
        }
        //Método estático que fecha a conexao com o banco
        public static void fecharConexao()
        {
            objConexao.Close();
        }
    }
}
