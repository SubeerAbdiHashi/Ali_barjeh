namespace Ali_barjeh.Users
{
    partial class UC_Employee
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.emidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emfirstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emmiddleNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emlastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emtypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emaddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ali_barjehDataSet14 = new Ali_barjeh.ali_barjehDataSet14();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnnUpdate = new System.Windows.Forms.Button();
            this.btnNewEm = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.employeeTableAdapter = new Ali_barjeh.ali_barjehDataSet14TableAdapters.EmployeeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ali_barjehDataSet14)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
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
            this.emidDataGridViewTextBoxColumn,
            this.emfirstNameDataGridViewTextBoxColumn,
            this.emmiddleNameDataGridViewTextBoxColumn,
            this.emlastNameDataGridViewTextBoxColumn,
            this.emtypeDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.salaryDataGridViewTextBoxColumn,
            this.emaddressDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.employeeBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(12, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(966, 432);
            this.dataGridView1.TabIndex = 27;
            // 
            // emidDataGridViewTextBoxColumn
            // 
            this.emidDataGridViewTextBoxColumn.DataPropertyName = "Em_id";
            this.emidDataGridViewTextBoxColumn.HeaderText = "ID";
            this.emidDataGridViewTextBoxColumn.Name = "emidDataGridViewTextBoxColumn";
            this.emidDataGridViewTextBoxColumn.ReadOnly = true;
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
            // emlastNameDataGridViewTextBoxColumn
            // 
            this.emlastNameDataGridViewTextBoxColumn.DataPropertyName = "Em_lastName";
            this.emlastNameDataGridViewTextBoxColumn.HeaderText = "LAST NAME";
            this.emlastNameDataGridViewTextBoxColumn.Name = "emlastNameDataGridViewTextBoxColumn";
            this.emlastNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emtypeDataGridViewTextBoxColumn
            // 
            this.emtypeDataGridViewTextBoxColumn.DataPropertyName = "Em_type";
            this.emtypeDataGridViewTextBoxColumn.HeaderText = "TYPE";
            this.emtypeDataGridViewTextBoxColumn.Name = "emtypeDataGridViewTextBoxColumn";
            this.emtypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "PHONE";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // salaryDataGridViewTextBoxColumn
            // 
            this.salaryDataGridViewTextBoxColumn.DataPropertyName = "Salary";
            this.salaryDataGridViewTextBoxColumn.HeaderText = "SALARY";
            this.salaryDataGridViewTextBoxColumn.Name = "salaryDataGridViewTextBoxColumn";
            this.salaryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emaddressDataGridViewTextBoxColumn
            // 
            this.emaddressDataGridViewTextBoxColumn.DataPropertyName = "Em_address";
            this.emaddressDataGridViewTextBoxColumn.HeaderText = "ADDRESS";
            this.emaddressDataGridViewTextBoxColumn.Name = "emaddressDataGridViewTextBoxColumn";
            this.emaddressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.ali_barjehDataSet14;
            // 
            // ali_barjehDataSet14
            // 
            this.ali_barjehDataSet14.DataSetName = "ali_barjehDataSet14";
            this.ali_barjehDataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.label1.Location = new System.Drawing.Point(702, 22);
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
            this.panel5.Controls.Add(this.btnDelete);
            this.panel5.Controls.Add(this.btnnUpdate);
            this.panel5.Controls.Add(this.btnNewEm);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(12, 10);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(966, 56);
            this.panel5.TabIndex = 26;
            // 
            // btnRefresh
            // 
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Image = global::Ali_barjeh.Properties.Resources.Refresh_25px1;
            this.btnRefresh.Location = new System.Drawing.Point(468, 6);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(101, 44);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = global::Ali_barjeh.Properties.Resources.Delete_25px;
            this.btnDelete.Location = new System.Drawing.Point(349, 6);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(101, 44);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
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
            // btnNewEm
            // 
            this.btnNewEm.FlatAppearance.BorderSize = 0;
            this.btnNewEm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewEm.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewEm.ForeColor = System.Drawing.Color.White;
            this.btnNewEm.Image = global::Ali_barjeh.Properties.Resources.User_Group_Man_Man_25px;
            this.btnNewEm.Location = new System.Drawing.Point(6, 6);
            this.btnNewEm.Name = "btnNewEm";
            this.btnNewEm.Size = new System.Drawing.Size(212, 44);
            this.btnNewEm.TabIndex = 0;
            this.btnNewEm.Text = "Add New Employee";
            this.btnNewEm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNewEm.UseVisualStyleBackColor = true;
            this.btnNewEm.Click += new System.EventHandler(this.btnNewEm_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(12, 488);
            this.panel2.TabIndex = 25;
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
            this.label2.Location = new System.Drawing.Point(688, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 19);
            this.label2.TabIndex = 18;
            this.label2.Text = "Number Of Employee:";
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(978, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 488);
            this.panel3.TabIndex = 22;
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
            this.panel4.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(15, 4);
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
            this.panel1.TabIndex = 24;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // UC_Employee
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
            this.Name = "UC_Employee";
            this.Size = new System.Drawing.Size(988, 523);
            this.Load += new System.EventHandler(this.UC_Employee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ali_barjehDataSet14)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnnUpdate;
        private System.Windows.Forms.Button btnNewEm;
        private System.Windows.Forms.DataGridViewTextBoxColumn emidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emfirstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emmiddleNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emlastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emtypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emaddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private ali_barjehDataSet14 ali_barjehDataSet14;
        private ali_barjehDataSet14TableAdapters.EmployeeTableAdapter employeeTableAdapter;
    }
}
