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

                string sql = @"INSERT INTO jobs (job_title, min_salary, max_salary)
                VALUES(@puesto, @min, @max)";

                SqlCommand cmd = new SqlCommand(sql, cnx.conexion);
                                
                SqlParameter min = new SqlParameter("@min", job.minSalary);
                SqlParameter max = new SqlParameter("@max", job.maxSalary);

                SqlParameter puesto = new SqlParameter("@puesto", System.Data.SqlDbType.NVarChar, 50);
                puesto.Value = job.workstation;
                cmd.Parameters.Add(puesto);
                cmd.Parameters.Add(min);
                cmd.Parameters.Add(max);
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
                WHERE job_id = @id";

                

                SqlCommand cmd = new SqlCommand(sql, cnx.conexion);
                SqlParameter min = new SqlParameter("@id", Convert.ToInt32(job));
                cmd.Parameters.Add(min);
                cmd.ExecuteNonQuery();
                cnx.CloseConnection();
            }
            catch (Exception ee)
            {

                MessageBox.Show("No se ha podido ejecutar el select " + ee);
            }
        }

        public void UpdateJob(Job job)
        {
            try
            {
                cnx.OpenConection();

                string sql = @"UPDATE jobs
                                SET job_title = '@puesto', min_salary = @min, max_salary = @max
                                WHERE  job_id = @id";

                SqlCommand cmd = new SqlCommand(sql, cnx.conexion);

                SqlParameter min = new SqlParameter("@min", job.minSalary);
                SqlParameter max = new SqlParameter("@max", job.maxSalary);
                SqlParameter id = new SqlParameter("@id", job.id);

                SqlParameter puesto = new SqlParameter("@puesto", System.Data.SqlDbType.NVarChar, 50);
                puesto.Value = job.workstation;
                cmd.Parameters.Add(puesto);
                cmd.Parameters.Add(min);
                cmd.Parameters.Add(max);
                cmd.Parameters.Add(id);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Actualizado correctamente");
                cnx.CloseConnection();

            }
            catch (Exception ee)
            {

                MessageBox.Show("No se ha podido actualizar " + ee);
            }
        }

    }
}
