using ConexionBD.CLASES;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConexionBD
{
    public partial class Form1 : Form
    {
        Job temp = null;
        List<Job> jobslist;
       
        public Form1()
        {
            InitializeComponent();
        }

       

        


        private void btnInsertJob_Click(object sender, EventArgs e)
        {
            temp = new Job(txtPuesto.Text, Convert.ToDecimal(txtMinSalary.Text), Convert.ToDecimal(txtMaxSalary.Text));

            DALJob dalJob = new DALJob();
            dalJob.InsertJob(temp);
            


        }

        private void btnSelectJobs_Click(object sender, EventArgs e)
        {

            DALJob daljob = new DALJob();
            jobslist = daljob.SelectJobs();

            foreach (Job j in jobslist)
            {
                listJobsSelect.Items.Add(j.ToString());
                comboBox1.Items.Add(j.id);
            }           
           
        }

        private void btnDelJob_Click(object sender, EventArgs e)
        {

            DALJob daljob = new DALJob();

            daljob.DelJob(comboBox1.SelectedItem.ToString());
            comboBox1.Items.Remove(comboBox1.SelectedItem.ToString());

        }
    }
}
