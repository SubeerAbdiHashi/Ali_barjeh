using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Ali_barjeh.Users
{
    public partial class backup_and_restore : UserControl
    {

        SqlConnection con = new SqlConnection("server=localhost;database=ali_barjeh;integrated security=true");
        public backup_and_restore()
        {
            InitializeComponent();
        }

        private void browsebutton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = dlg.SelectedPath;
                backupbutton.Enabled = true;
            }
        }

        private void backupbutton_Click(object sender, EventArgs e)
        {
            string database = con.Database.ToString();
            try
            {
                if (textBox1.Text == string.Empty)
                {
                    MessageBox.Show("please enter backup file location");
                }
                else
                {
                    string cmd = "BACKUP DATABASE [" + database + "] TO DISK='" + textBox1.Text + "\\" + "database" + "-" + DateTime.Now.ToString("yyyy-MM-dd--HH-mm-ss") + ".bak'";

                    using (SqlCommand command = new SqlCommand(cmd, con))
                    {
                        if (con.State != ConnectionState.Open)
                        {
                            con.Open();
                        }
                        command.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("database backup done successefully");
                        backupbutton.Enabled = false;
                    }
                }

            }
            catch
            {

            }
        }

        private void browsebutton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = " SQL SERVER database ackup file |*.bak";
            dlg.Title = "Database Restore";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                textBox2.Text = dlg.FileName;
                textBox2.Enabled = true;
            }
        }

        private void restorebutton_Click(object sender, EventArgs e)
        {
            string database = con.Database.ToString();
    if (con.State != ConnectionState.Open)
    {
        con.Open();
    }
    try
    {
        string sqlStmt2 = string.Format("ALTER DATABASE [" + database + "] SET SINGLE_USER WITH ROLLBACK IMMEDIATE");
        SqlCommand bu2 = new SqlCommand(sqlStmt2, con);
        bu2.ExecuteNonQuery();

        string sqlStmt3 = "USE MASTER RESTORE DATABASE [" + database + "] FROM DISK='" + textBox2.Text + "'WITH REPLACE;";
        SqlCommand bu3 = new SqlCommand(sqlStmt3, con);
        bu3.ExecuteNonQuery();

        string sqlStmt4 = string.Format("ALTER DATABASE [" + database + "] SET MULTI_USER");
        SqlCommand bu4 = new SqlCommand(sqlStmt4, con);
        bu4.ExecuteNonQuery();

        MessageBox.Show("database restoration done successefully");
        con.Close();

   }
   catch (Exception ex)
   {
        MessageBox.Show(ex.ToString());
   }
}
    }




        }
    