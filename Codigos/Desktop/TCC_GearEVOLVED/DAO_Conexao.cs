using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC_GearEVOLVED
{
    class DAO_Conexao
    {
        public static MySqlConnection con;

        public static Boolean getConexao(String local, String banco, String usuario, String senha)
        {
            Boolean retorno = false;
            try
            {
                con = new MySqlConnection("server="+local+";User ID="+usuario+";database="+banco+";password="+senha+";SslMode = none");
                con.Open();
                retorno = true;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                con.Close();
            }
            finally
            {
                con.Close();
            }
            return retorno;
        }
    }
}
