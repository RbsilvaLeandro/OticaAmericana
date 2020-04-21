using System;
using System.Data.SqlClient;

namespace OticaAmericana
{
    class Conexao
    {
        public static SqlConnection getConexao()
        {
            SqlConnection conn = null;
            string strConexao;

            try
            {
                //nomeServidor = "CLIENTE";
                //nomeBanco = "SQLEXPRESS";
                //usuario = "elexandre";
                //senha = "luciane";

                strConexao = "Data Source=DESKTOP-M3A5JSV\\SQLEXPRESS; Initial Catalog=Otica_Americana;User id=sa;Password=nigt@c#524897";
                conn = new SqlConnection(strConexao);
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();
            }
            catch (Exception)
            {
                return null;
            }
            return conn;
        }
    }
}
