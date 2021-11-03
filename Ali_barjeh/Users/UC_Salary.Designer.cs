namespace Ali_barjeh.Users
{
    partial class UC_Salary
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnnUpdate = new System.Windows.Forms.Button();
            this.btnNewSal = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emfirstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emmiddleNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salarydateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vsalaryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ali_barjehDataSet12 = new Ali_barjeh.ali_barjehDataSet12();
            this.v_salaryTableAdapter = new Ali_barjeh.ali_barjehDataSet12TableAdapters.V_salaryTableAdapter();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vsalaryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ali_barjehDataSet12)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(768, 18);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(195, 27);
            this.txtSearch.TabIndex = 11;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(700, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Search:";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Goldenrod;
            this.panel5.Controls.Add(this.txtSearch);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.btnRefresh);
            this.panel5.Controls.Add(this.btnnUpdate);
            this.panel5.Controls.Add(this.btnNewSal);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(12, 10);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(966, 56);
            this.panel5.TabIndex = 32;
            // 
            // btnRefresh
            // 
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Image = global::Ali_barjeh.Properties.Resources.Refresh_25px1;
            this.btnRefresh.Location = new System.Drawing.Point(370, 9);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(101, 44);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnnUpdate
            // 
            this.btnnUpdate.FlatAppearance.BorderSize = 0;
            this.btnnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnUpdate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnnUpdate.Image = global::Ali_barjeh.Properties.Resources.Restart_25px;
            this.btnnUpdate.Location = new System.Drawing.Point(224, 6);
            this.btnnUpdate.Name = "btnnUpdate";
            this.btnnUpdate.Size = new System.Drawing.Size(114, 44);
            this.btnnUpdate.TabIndex = 1;
            this.btnnUpdate.Text = "Update";
            this.btnnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnnUpdate.UseVisualStyleBackColor = true;
            this.btnnUpdate.Click += new System.EventHandler(this.btnnUpdate_Click);
            // 
            // btnNewSal
            // 
            this.btnNewSal.FlatAppearance.BorderSize = 0;
            this.btnNewSal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewSal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewSal.ForeColor = System.Drawing.Color.White;
            this.btnNewSal.Image = global::Ali_barjeh.Properties.Resources.Money_25px;
            this.btnNewSal.Location = new System.Drawing.Point(6, 6);
            this.btnNewSal.Name = "btnNewSal";
            this.btnNewSal.Size = new System.Drawing.Size(212, 44);
            this.btnNewSal.TabIndex = 0;
            this.btnNewSal.Text = "Add New Salary";
            this.btnNewSal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNewSal.UseVisualStyleBackColor = true;
            this.btnNewSal.Click += new System.EventHandler(this.btnNewSal_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(12, 488);
            this.panel2.TabIndex = 31;
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(874, 2);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(27, 19);
            this.lblTotal.TabIndex = 17;
            this.lblTotal.Text = "00";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(772, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 19);
            this.label2.TabIndex = 18;
            this.label2.Text = "Total Salary:";
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(978, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 488);
            this.panel3.TabIndex = 28;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.lblTotal);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 498);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(988, 25);
            this.panel4.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(20, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(421, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "Copyrighst © 2021. Allrights Reserved By Students Gollis University.";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(988, 10);
            this.panel1.TabIndex = 30;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.emfirstNameDataGridViewTextBoxColumn,
            this.emmiddleNameDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.salaryAmountDataGridViewTextBoxColumn,
            this.salarydateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vsalaryBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(12, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(966, 432);
            this.dataGridView1.TabIndex = 33;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "SALARY ID";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emfirstNameDataGridViewTextBoxColumn
            // 
            this.emfirstNameDataGridViewTextBoxColumn.DataPropertyName = "Em_firstName";
            this.emfirstNameDataGridViewTextBoxColumn.HeaderText = "FIRST NAME";
            this.emfirstNameDataGridViewTextBoxColumn.Name = "emfirstNameDataGridViewTextBoxColumn";
            this.emfirstNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emmiddleNameDataGridViewTextBoxColumn
            // 
            this.emmiddleNameDataGridViewTextBoxColumn.DataPropertyName = "Em_middleName";
            this.emmiddleNameDataGridViewTextBoxColumn.HeaderText = "MIDDLE NAME";
            this.emmiddleNameDataGridViewTextBoxColumn.Name = "emmiddleNameDataGridViewTextBoxColumn";
            this.emmiddleNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "PHONE";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // salaryAmountDataGridViewTextBoxColumn
            // 
            this.salaryAmountDataGridViewTextBoxColumn.DataPropertyName = "Salary_Amount";
            this.salaryAmountDataGridViewTextBoxColumn.HeaderText = "AMOUNT";
            this.salaryAmountDataGridViewTextBoxColumn.Name = "salaryAmountDataGridViewTextBoxColumn";
            this.salaryAmountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // salarydateDataGridViewTextBoxColumn
            // 
            this.salarydateDataGridViewTextBoxColumn.DataPropertyName = "Salary_date";
            this.salarydateDataGridViewTextBoxColumn.HeaderText = "DATE";
            this.salarydateDataGridViewTextBoxColumn.Name = "salarydateDataGridViewTextBoxColumn";
            this.salarydateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vsalaryBindingSource
            // 
            this.vsalaryBindingSource.DataMember = "V_salary";
            this.vsalaryBindingSource.DataSource = this.ali_barjehDataSet12;
            // 
            // ali_barjehDataSet12
            // 
            this.ali_barjehDataSet12.DataSetName = "ali_barjehDataSet12";
            this.ali_barjehDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // v_salaryTableAdapter
            // 
            this.v_salaryTableAdapter.ClearBeforeFill = true;
            // 
            // UC_Salary
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UC_Salary";
            this.Size = new System.Drawing.Size(988, 523);
            this.Load += new System.EventHandler(this.UC_Salary_Load);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vsalaryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ali_barjehDataSet12)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Button btnnUpdate;
        public System.Windows.Forms.Button btnNewSal;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emfirstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emmiddleNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salarydateDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource vsalaryBindingSource;
        private ali_barjehDataSet12 ali_barjehDataSet12;
        private ali_barjehDataSet12TableAdapters.V_salaryTableAdapter v_salaryTableAdapter;
    }
}
