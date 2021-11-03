namespace Ali_barjeh.Users
{
    partial class backup_and_restore
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backupbutton = new System.Windows.Forms.Button();
            this.browsebutton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.restorebutton = new System.Windows.Forms.Button();
            this.browsebutton1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.backupbutton);
            this.groupBox1.Controls.Add(this.browsebutton);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(59, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(826, 238);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Back up";
            // 
            // backupbutton
            // 
            this.backupbutton.Location = new System.Drawing.Point(460, 116);
            this.backupbutton.Name = "backupbutton";
            this.backupbutton.Size = new System.Drawing.Size(86, 28);
            this.backupbutton.TabIndex = 3;
            this.backupbutton.Text = "Back up";
            this.backupbutton.UseVisualStyleBackColor = true;
            this.backupbutton.Click += new System.EventHandler(this.backupbutton_Click);
            // 
            // browsebutton
            // 
            this.browsebutton.Location = new System.Drawing.Point(460, 72);
            this.browsebutton.Name = "browsebutton";
            this.browsebutton.Size = new System.Drawing.Size(86, 29);
            this.browsebutton.TabIndex = 2;
            this.browsebutton.Text = "Browse";
            this.browsebutton.UseVisualStyleBackColor = true;
            this.browsebutton.Click += new System.EventHandler(this.browsebutton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(216, 80);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(228, 25);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Location";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.restorebutton);
            this.groupBox2.Controls.Add(this.browsebutton1);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(59, 285);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(826, 225);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Restore";
            // 
            // restorebutton
            // 
            this.restorebutton.Location = new System.Drawing.Point(460, 119);
            this.restorebutton.Name = "restorebutton";
            this.restorebutton.Size = new System.Drawing.Size(86, 28);
            this.restorebutton.TabIndex = 3;
            this.restorebutton.Text = "Restore";
            this.restorebutton.UseVisualStyleBackColor = true;
            this.restorebutton.Click += new System.EventHandler(this.restorebutton_Click);
            // 
            // browsebutton1
            // 
            this.browsebutton1.Location = new System.Drawing.Point(460, 75);
            this.browsebutton1.Name = "browsebutton1";
            this.browsebutton1.Size = new System.Drawing.Size(86, 29);
            this.browsebutton1.TabIndex = 2;
            this.browsebutton1.Text = "Browse";
            this.browsebutton1.UseVisualStyleBackColor = true;
            this.browsebutton1.Click += new System.EventHandler(this.browsebutton1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(216, 83);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(228, 25);
            this.textBox2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(105, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Location";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(26, 517);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(421, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Copyrighst © 2021. Allrights Reserved By Students Gollis University.";
            // 
            // backup_and_restore
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "backup_and_restore";
            this.Size = new System.Drawing.Size(954, 539);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button backupbutton;
        private System.Windows.Forms.Button browsebutton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button restorebutton;
        private System.Windows.Forms.Button browsebutton1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
    }
}
