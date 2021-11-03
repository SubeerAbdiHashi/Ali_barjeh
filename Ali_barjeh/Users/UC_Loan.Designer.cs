namespace Ali_barjeh.Users
{
    partial class UC_Loan
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.oridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cusfirstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cusmiddleNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalamountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nettotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receiptDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.balanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ali_barjehDataSet2 = new Ali_barjeh.ali_barjehDataSet2();
            this.loanTableAdapter = new Ali_barjeh.ali_barjehDataSet2TableAdapters.loanTableAdapter();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ali_barjehDataSet2)).BeginInit();
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
            this.label1.Location = new System.Drawing.Point(699, 22);
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
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(12, 10);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(966, 56);
            this.panel5.TabIndex = 14;
            // 
            // btnRefresh
            // 
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Image = global::Ali_barjeh.Properties.Resources.Refresh_25px1;
            this.btnRefresh.Location = new System.Drawing.Point(160, 6);
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
            this.btnnUpdate.Location = new System.Drawing.Point(17, 8);
            this.btnnUpdate.Name = "btnnUpdate";
            this.btnnUpdate.Size = new System.Drawing.Size(114, 44);
            this.btnnUpdate.TabIndex = 1;
            this.btnnUpdate.Text = "Update";
            this.btnnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnnUpdate.UseVisualStyleBackColor = true;
            this.btnnUpdate.Click += new System.EventHandler(this.btnnUpdate_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(12, 488);
            this.panel2.TabIndex = 13;
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
            this.label2.Location = new System.Drawing.Point(783, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 19);
            this.label2.TabIndex = 18;
            this.label2.Text = "Total Lend:";
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(978, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 488);
            this.panel3.TabIndex = 10;
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
            this.panel4.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(14, 3);
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
            this.panel1.TabIndex = 12;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.oridDataGridViewTextBoxColumn,
            this.cusfirstNameDataGridViewTextBoxColumn,
            this.cusmiddleNameDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.totalamountDataGridViewTextBoxColumn,
            this.discountDataGridViewTextBoxColumn,
            this.nettotalDataGridViewTextBoxColumn,
            this.receiptDataGridViewTextBoxColumn,
            this.balanceDataGridViewTextBoxColumn,
            this.ordateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.loanBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(12, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(966, 432);
            this.dataGridView1.TabIndex = 17;
            // 
            // oridDataGridViewTextBoxColumn
            // 
            this.oridDataGridViewTextBoxColumn.DataPropertyName = "or_id";
            this.oridDataGridViewTextBoxColumn.HeaderText = "ORDER ID";
            this.oridDataGridViewTextBoxColumn.Name = "oridDataGridViewTextBoxColumn";
            // 
            // cusfirstNameDataGridViewTextBoxColumn
            // 
            this.cusfirstNameDataGridViewTextBoxColumn.DataPropertyName = "cus_firstName";
            this.cusfirstNameDataGridViewTextBoxColumn.HeaderText = "FIRST NAME";
            this.cusfirstNameDataGridViewTextBoxColumn.Name = "cusfirstNameDataGridViewTextBoxColumn";
            // 
            // cusmiddleNameDataGridViewTextBoxColumn
            // 
            this.cusmiddleNameDataGridViewTextBoxColumn.DataPropertyName = "cus_middleName";
            this.cusmiddleNameDataGridViewTextBoxColumn.HeaderText = "MIDDLE NAME";
            this.cusmiddleNameDataGridViewTextBoxColumn.Name = "cusmiddleNameDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "PHONE";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // totalamountDataGridViewTextBoxColumn
            // 
            this.totalamountDataGridViewTextBoxColumn.DataPropertyName = "total_amount";
            this.totalamountDataGridViewTextBoxColumn.HeaderText = "TOTAL";
            this.totalamountDataGridViewTextBoxColumn.Name = "totalamountDataGridViewTextBoxColumn";
            // 
            // discountDataGridViewTextBoxColumn
            // 
            this.discountDataGridViewTextBoxColumn.DataPropertyName = "discount";
            this.discountDataGridViewTextBoxColumn.HeaderText = "DISCOUNT";
            this.discountDataGridViewTextBoxColumn.Name = "discountDataGridViewTextBoxColumn";
            // 
            // nettotalDataGridViewTextBoxColumn
            // 
            this.nettotalDataGridViewTextBoxColumn.DataPropertyName = "net_total";
            this.nettotalDataGridViewTextBoxColumn.HeaderText = "NET TOTAL";
            this.nettotalDataGridViewTextBoxColumn.Name = "nettotalDataGridViewTextBoxColumn";
            // 
            // receiptDataGridViewTextBoxColumn
            // 
            this.receiptDataGridViewTextBoxColumn.DataPropertyName = "receipt";
            this.receiptDataGridViewTextBoxColumn.HeaderText = "RECEIPT";
            this.receiptDataGridViewTextBoxColumn.Name = "receiptDataGridViewTextBoxColumn";
            // 
            // balanceDataGridViewTextBoxColumn
            // 
            this.balanceDataGridViewTextBoxColumn.DataPropertyName = "balance";
            this.balanceDataGridViewTextBoxColumn.HeaderText = "BALANCE";
            this.balanceDataGridViewTextBoxColumn.Name = "balanceDataGridViewTextBoxColumn";
            // 
            // ordateDataGridViewTextBoxColumn
            // 
            this.ordateDataGridViewTextBoxColumn.DataPropertyName = "or_date";
            this.ordateDataGridViewTextBoxColumn.HeaderText = "DATE";
            this.ordateDataGridViewTextBoxColumn.Name = "ordateDataGridViewTextBoxColumn";
            // 
            // loanBindingSource
            // 
            this.loanBindingSource.DataMember = "loan";
            this.loanBindingSource.DataSource = this.ali_barjehDataSet2;
            // 
            // ali_barjehDataSet2
            // 
            this.ali_barjehDataSet2.DataSetName = "ali_barjehDataSet2";
            this.ali_barjehDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loanTableAdapter
            // 
            this.loanTableAdapter.ClearBeforeFill = true;
            // 
            // UC_Loan
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UC_Loan";
            this.Size = new System.Drawing.Size(988, 523);
            this.Load += new System.EventHandler(this.UC_Loan_Load);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ali_barjehDataSet2)).EndInit();
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource loanBindingSource;
        private ali_barjehDataSet2 ali_barjehDataSet2;
        private ali_barjehDataSet2TableAdapters.loanTableAdapter loanTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn oridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cusfirstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cusmiddleNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalamountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nettotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn receiptDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn balanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordateDataGridViewTextBoxColumn;
        public System.Windows.Forms.Button btnnUpdate;
    }
}
