using System.Data.SqlClient;

namespace ConexionBD.CLASES
{
    public class DbConnect
    {
        private const string connStr = "Data Source=217.71.207.123,54321;Initial Catalog=gabri_employees; Persist Security Info=True;User ID=sa;Password=123456789";
        public SqlConnection conexion;

        public void OpenConection()
        {
            conexion = new SqlConnection(connStr);
            conexion.Open();
            
        }


        public void CloseConnection()
        {
            conexion.Close();
        }
    }
}