namespace bapers
{
    partial class F_Proc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.jobBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bapersDataSet = new bapers.bapersDataSet();
            this.jobTableAdapter = new bapers.bapersDataSetTableAdapters.jobTableAdapter();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.B_job = new System.Windows.Forms.ListBox();
            this.BT_test = new System.Windows.Forms.Button();
            this.LB_test = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.B_Task = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BT_statUpdata = new System.Windows.Forms.Button();
            this.TB_status = new System.Windows.Forms.TextBox();
            this.jobDeadlineStat = new bapers.JobDeadlineStat();
            this.jobBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.jobTableAdapter1 = new bapers.JobDeadlineStatTableAdapters.jobTableAdapter();
            this.jobDeadlineStatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bapersDataSet1 = new bapers.bapersDataSet1();
            this.jobBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.jobTableAdapter2 = new bapers.bapersDataSet1TableAdapters.jobTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.jobBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bapersDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobDeadlineStat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobDeadlineStatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bapersDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.jobBindingSource2;
            this.listBox1.DisplayMember = "job_number";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 41);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(88, 199);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // jobBindingSource
            // 
            this.jobBindingSource.DataMember = "job";
            this.jobBindingSource.DataSource = this.bapersDataSet;
            this.jobBindingSource.CurrentChanged += new System.EventHandler(this.jobBindingSource_CurrentChanged);
            // 
            // bapersDataSet
            // 
            this.bapersDataSet.DataSetName = "bapersDataSet";
            this.bapersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // jobTableAdapter
            // 
            this.jobTableAdapter.ClearBeforeFill = true;
            // 
            // listBox2
            // 
            this.listBox2.DataSource = this.jobBindingSource2;
            this.listBox2.DisplayMember = "deadline";
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(106, 41);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(69, 199);
            this.listBox2.TabIndex = 1;
            // 
            // B_job
            // 
            this.B_job.DataSource = this.jobBindingSource2;
            this.B_job.DisplayMember = "Status";
            this.B_job.FormattingEnabled = true;
            this.B_job.Location = new System.Drawing.Point(181, 41);
            this.B_job.Name = "B_job";
            this.B_job.Size = new System.Drawing.Size(80, 199);
            this.B_job.TabIndex = 2;
            // 
            // BT_test
            // 
            this.BT_test.Location = new System.Drawing.Point(61, 382);
            this.BT_test.Name = "BT_test";
            this.BT_test.Size = new System.Drawing.Size(75, 23);
            this.BT_test.TabIndex = 3;
            this.BT_test.Text = "Test";
            this.BT_test.UseVisualStyleBackColor = true;
            this.BT_test.Click += new System.EventHandler(this.BT_test_Click);
            // 
            // LB_test
            // 
            this.LB_test.AutoSize = true;
            this.LB_test.Location = new System.Drawing.Point(77, 345);
            this.LB_test.Name = "LB_test";
            this.LB_test.Size = new System.Drawing.Size(35, 13);
            this.LB_test.TabIndex = 4;
            this.LB_test.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Job No.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "DeadLine";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(212, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Status";
            // 
            // B_Task
            // 
            this.B_Task.FormattingEnabled = true;
            this.B_Task.Location = new System.Drawing.Point(312, 53);
            this.B_Task.Name = "B_Task";
            this.B_Task.Size = new System.Drawing.Size(147, 342);
            this.B_Task.TabIndex = 8;
            this.B_Task.SelectedIndexChanged += new System.EventHandler(this.B_Task_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(359, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tasks : Status";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // BT_statUpdata
            // 
            this.BT_statUpdata.Location = new System.Drawing.Point(497, 260);
            this.BT_statUpdata.Name = "BT_statUpdata";
            this.BT_statUpdata.Size = new System.Drawing.Size(97, 24);
            this.BT_statUpdata.TabIndex = 10;
            this.BT_statUpdata.Text = "Update";
            this.BT_statUpdata.UseVisualStyleBackColor = true;
            this.BT_statUpdata.Click += new System.EventHandler(this.BT_statUpdata_Click);
            // 
            // TB_status
            // 
            this.TB_status.Location = new System.Drawing.Point(485, 220);
            this.TB_status.Name = "TB_status";
            this.TB_status.Size = new System.Drawing.Size(122, 20);
            this.TB_status.TabIndex = 11;
            // 
            // jobDeadlineStat
            // 
            this.jobDeadlineStat.DataSetName = "JobDeadlineStat";
            this.jobDeadlineStat.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // jobBindingSource1
            // 
            this.jobBindingSource1.DataMember = "job";
            this.jobBindingSource1.DataSource = this.jobDeadlineStat;
            // 
            // jobTableAdapter1
            // 
            this.jobTableAdapter1.ClearBeforeFill = true;
            // 
            // jobDeadlineStatBindingSource
            // 
            this.jobDeadlineStatBindingSource.DataSource = this.jobDeadlineStat;
            this.jobDeadlineStatBindingSource.Position = 0;
            this.jobDeadlineStatBindingSource.CurrentChanged += new System.EventHandler(this.jobDeadlineStatBindingSource_CurrentChanged);
            // 
            // bapersDataSet1
            // 
            this.bapersDataSet1.DataSetName = "bapersDataSet1";
            this.bapersDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // jobBindingSource2
            // 
            this.jobBindingSource2.DataMember = "job";
            this.jobBindingSource2.DataSource = this.bapersDataSet1;
            // 
            // jobTableAdapter2
            // 
            this.jobTableAdapter2.ClearBeforeFill = true;
            // 
            // F_Proc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TB_status);
            this.Controls.Add(this.BT_statUpdata);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.B_Task);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LB_test);
            this.Controls.Add(this.BT_test);
            this.Controls.Add(this.B_job);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Name = "F_Proc";
            this.Text = "F_Proc";
            this.Load += new System.EventHandler(this.F_Proc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.jobBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bapersDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobDeadlineStat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobDeadlineStatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bapersDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private bapersDataSet bapersDataSet;
        private System.Windows.Forms.BindingSource jobBindingSource;
        private bapersDataSetTableAdapters.jobTableAdapter jobTableAdapter;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox B_job;
        private System.Windows.Forms.Button BT_test;
        private System.Windows.Forms.Label LB_test;
        
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox B_Task;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BT_statUpdata;
        private System.Windows.Forms.TextBox TB_status;
        private JobDeadlineStat jobDeadlineStat;
        private System.Windows.Forms.BindingSource jobBindingSource1;
        private JobDeadlineStatTableAdapters.jobTableAdapter jobTableAdapter1;
        private System.Windows.Forms.BindingSource jobDeadlineStatBindingSource;
        private bapersDataSet1 bapersDataSet1;
        private System.Windows.Forms.BindingSource jobBindingSource2;
        private bapersDataSet1TableAdapters.jobTableAdapter jobTableAdapter2;
    }
}