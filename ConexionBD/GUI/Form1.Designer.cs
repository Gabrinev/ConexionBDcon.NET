
namespace ConexionBD
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtMaxSalary = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMinSalary = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listJobsSelect = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSelectJobs = new System.Windows.Forms.Button();
            this.btnDelJob = new System.Windows.Forms.Button();
            this.btnInsertJob = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtPuesto = new System.Windows.Forms.TextBox();
            this.insertBox = new System.Windows.Forms.GroupBox();
            this.selectBox = new System.Windows.Forms.GroupBox();
            this.deleteBox = new System.Windows.Forms.GroupBox();
            this.insertBox.SuspendLayout();
            this.selectBox.SuspendLayout();
            this.deleteBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMaxSalary
            // 
            this.txtMaxSalary.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMaxSalary.Location = new System.Drawing.Point(499, 18);
            this.txtMaxSalary.Name = "txtMaxSalary";
            this.txtMaxSalary.Size = new System.Drawing.Size(80, 20);
            this.txtMaxSalary.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Puesto: ";
            // 
            // txtMinSalary
            // 
            this.txtMinSalary.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMinSalary.Location = new System.Drawing.Point(339, 18);
            this.txtMinSalary.Name = "txtMinSalary";
            this.txtMinSalary.Size = new System.Drawing.Size(80, 20);
            this.txtMinSalary.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(434, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "SalarioMax";
            // 
            // listJobsSelect
            // 
            this.listJobsSelect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listJobsSelect.FormattingEnabled = true;
            this.listJobsSelect.Location = new System.Drawing.Point(139, 16);
            this.listJobsSelect.Name = "listJobsSelect";
            this.listJobsSelect.Size = new System.Drawing.Size(302, 82);
            this.listJobsSelect.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(277, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "SalarioMin";
            // 
            // btnSelectJobs
            // 
            this.btnSelectJobs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSelectJobs.Location = new System.Drawing.Point(22, 16);
            this.btnSelectJobs.Name = "btnSelectJobs";
            this.btnSelectJobs.Size = new System.Drawing.Size(75, 23);
            this.btnSelectJobs.TabIndex = 4;
            this.btnSelectJobs.Text = "Select Jobs";
            this.btnSelectJobs.UseVisualStyleBackColor = true;
            this.btnSelectJobs.Click += new System.EventHandler(this.btnSelectJobs_Click);
            // 
            // btnDelJob
            // 
            this.btnDelJob.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelJob.Location = new System.Drawing.Point(23, 41);
            this.btnDelJob.Name = "btnDelJob";
            this.btnDelJob.Size = new System.Drawing.Size(75, 23);
            this.btnDelJob.TabIndex = 11;
            this.btnDelJob.Text = "Remove Job";
            this.btnDelJob.UseVisualStyleBackColor = true;
            this.btnDelJob.Click += new System.EventHandler(this.btnDelJob_Click);
            // 
            // btnInsertJob
            // 
            this.btnInsertJob.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnInsertJob.Location = new System.Drawing.Point(15, 16);
            this.btnInsertJob.Name = "btnInsertJob";
            this.btnInsertJob.Size = new System.Drawing.Size(75, 23);
            this.btnInsertJob.TabIndex = 3;
            this.btnInsertJob.Text = "Insertar Job";
            this.btnInsertJob.UseVisualStyleBackColor = true;
            this.btnInsertJob.Click += new System.EventHandler(this.btnInsertJob_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(140, 41);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(119, 21);
            this.comboBox1.TabIndex = 12;
            // 
            // txtPuesto
            // 
            this.txtPuesto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPuesto.Location = new System.Drawing.Point(181, 18);
            this.txtPuesto.Name = "txtPuesto";
            this.txtPuesto.Size = new System.Drawing.Size(80, 20);
            this.txtPuesto.TabIndex = 6;
            // 
            // insertBox
            // 
            this.insertBox.Controls.Add(this.txtPuesto);
            this.insertBox.Controls.Add(this.label2);
            this.insertBox.Controls.Add(this.label3);
            this.insertBox.Controls.Add(this.txtMinSalary);
            this.insertBox.Controls.Add(this.btnInsertJob);
            this.insertBox.Controls.Add(this.label1);
            this.insertBox.Controls.Add(this.txtMaxSalary);
            this.insertBox.Location = new System.Drawing.Point(81, 32);
            this.insertBox.Name = "insertBox";
            this.insertBox.Size = new System.Drawing.Size(609, 48);
            this.insertBox.TabIndex = 13;
            this.insertBox.TabStop = false;
            this.insertBox.Text = "Insert";
            // 
            // selectBox
            // 
            this.selectBox.Controls.Add(this.listJobsSelect);
            this.selectBox.Controls.Add(this.btnSelectJobs);
            this.selectBox.Location = new System.Drawing.Point(81, 86);
            this.selectBox.Name = "selectBox";
            this.selectBox.Size = new System.Drawing.Size(447, 107);
            this.selectBox.TabIndex = 14;
            this.selectBox.TabStop = false;
            this.selectBox.Text = "Select";
            // 
            // deleteBox
            // 
            this.deleteBox.Controls.Add(this.comboBox1);
            this.deleteBox.Controls.Add(this.btnDelJob);
            this.deleteBox.Location = new System.Drawing.Point(81, 199);
            this.deleteBox.Name = "deleteBox";
            this.deleteBox.Size = new System.Drawing.Size(268, 100);
            this.deleteBox.TabIndex = 15;
            this.deleteBox.TabStop = false;
            this.deleteBox.Text = "Delete";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 326);
            this.Controls.Add(this.deleteBox);
            this.Controls.Add(this.selectBox);
            this.Controls.Add(this.insertBox);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.insertBox.ResumeLayout(false);
            this.insertBox.PerformLayout();
            this.selectBox.ResumeLayout(false);
            this.deleteBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtMaxSalary;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMinSalary;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listJobsSelect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSelectJobs;
        private System.Windows.Forms.Button btnDelJob;
        private System.Windows.Forms.Button btnInsertJob;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtPuesto;
        private System.Windows.Forms.GroupBox insertBox;
        private System.Windows.Forms.GroupBox selectBox;
        private System.Windows.Forms.GroupBox deleteBox;
    }
}

