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
            comboBox1.Items.Add(temp.id);
            comboBoxUpdate.Items.Add(temp.id);

            updateListView(sender, e);
        }

        private void updateListView(object sender, EventArgs e)
        {

            DALJob daljob = new DALJob();
            jobslist = daljob.SelectJobs();

            foreach (Job j in jobslist)
            {
                listJobsSelect.Items.Add(j.ToString());
                comboBox1.Items.Add(j.id);
                comboBoxUpdate.Items.Add(j.id);
            }                   
        }

        private void btnDelJob_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
                    return;
            
            DALJob daljob = new DALJob();

            daljob.DelJob(comboBox1.SelectedItem.ToString());
            comboBox1.Items.Remove(comboBox1.SelectedItem.ToString());
            comboBoxUpdate.Items.Remove(comboBoxUpdate.SelectedItem.ToString());
            updateListView(sender, e);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            updateListView(sender, e);
            btnUpdate.Enabled = false;
        }

        private void comboBoxUpdate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxUpdate.SelectedItem.ToString() != "0")
            {
                btnInsertJob.Enabled = false;
                btnUpdate.Enabled = true;
                foreach (Job j in jobslist)
                {
                    if (j.id == Convert.ToInt32(comboBoxUpdate.SelectedItem.ToString()))
                    {
                        txtPuesto.Text = j.workstation;
                        txtMinSalary.Text = j.minSalary.ToString();
                        txtMaxSalary.Text = j.maxSalary.ToString();
                    }
                }
            }else
            {
                btnInsertJob.Enabled = true;
                btnUpdate.Enabled = false;

                txtPuesto.Clear();
                txtMinSalary.Clear();
                txtMaxSalary.Clear();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (comboBoxUpdate.SelectedItem == null)
                return;
            DALJob daljob = new DALJob();
            foreach (Job j in jobslist)
            {
                if (j.id == Convert.ToInt32(comboBoxUpdate.SelectedItem.ToString()))
                {
                    daljob.UpdateJob(j);
                }
            }
            updateListView(sender, e);
        }
    }
}
