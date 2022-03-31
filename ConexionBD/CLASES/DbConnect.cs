using System.Data.SqlClient;

namespace ConexionBD.CLASES
{
    public class DbConnect
    {
        public SqlConnection conexion;

        public void OpenConection()
        {
            conexion = new SqlConnection(Properties.Settings.Default.connstr);
            conexion.Open();
            
        }


        public void CloseConnection()
        {
            conexion.Close();
        }
    }
}