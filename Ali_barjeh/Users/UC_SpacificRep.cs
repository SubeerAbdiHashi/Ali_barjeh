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
using Ali_barjeh.CrystalReport;

namespace Ali_barjeh.Users
{
    public partial class UC_SpacificRep : UserControl
    {
        SqlConnection con = new SqlConnection("server=localhost;database=ali_barjeh;integrated security=true");
        public UC_SpacificRep()
        {
            InitializeComponent();
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtId.Text != "")
                {
                    con.Open();
                    string select = "select * from v_orders where or_id=" + txtId.Text + "";
                    SqlCommand cmd = new SqlCommand(select, con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    con.Close();
                    CR_sales cr = new CR_sales();
                    cr.Database.Tables["v_orders"].SetDataSource(dt);
                    this.crystalReportViewer1.ReportSource = cr;
                }
                else
                {
                    MessageBox.Show("Please enter Order id", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
