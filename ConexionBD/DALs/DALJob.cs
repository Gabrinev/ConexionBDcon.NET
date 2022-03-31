using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConexionBD.CLASES
{
    class DALJob
    {
        Job temp;
        DbConnect cnx;
        List<Job> jobs = new List<Job>();

        public DALJob()
        {
            cnx = new DbConnect();
        }

        public void InsertJob(Job job)
        {
            try
            {
                cnx.OpenConection();
                
                string sql = @"
                INSERT INTO jobs 
                VALUES('" + job.workstation + "', " + job.minSalary + ", " + job.maxSalary + ")";

                SqlCommand cmd = new SqlCommand(sql, cnx.conexion);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Insertado correctamente");
                cnx.CloseConnection();

            }
            catch (Exception ee)
            {

                MessageBox.Show("No se ha podido insertar " + ee);
            }
        }

        public List<Job> SelectJobs()
        {
            try
            {
                cnx.OpenConection();

                string sql = @"
                SELECT *
                FROM jobs";

                SqlCommand cmd = new SqlCommand(sql, cnx.conexion);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    temp = new Job(Convert.ToInt32(dr[0]), dr[1].ToString(), Convert.ToDecimal(dr[2]), Convert.ToInt32(dr[3]));
                    jobs.Add(temp);                   
                   
                }
                dr.Close();
                cnx.CloseConnection();
                return jobs;
            }
            catch (Exception ee)
            {

                MessageBox.Show("No se ha podido insertar " + ee);
                return null;
            }
        }
        public void DelJob(String job)
        {
            try
            {
                cnx.OpenConection();
                string sql = @"
                DELETE
                FROM jobs
                WHERE job_id = " + job;

                

                SqlCommand cmd = new SqlCommand(sql, cnx.conexion);
                cmd.ExecuteNonQuery();
                cnx.CloseConnection();
            }
            catch (Exception ee)
            {

                MessageBox.Show("No se ha podido ejecutar el select " + ee);
            }
        }

    }
}
