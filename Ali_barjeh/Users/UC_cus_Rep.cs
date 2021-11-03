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
    public partial class UC_cus_Rep : UserControl
    {
        SqlConnection con = new SqlConnection("server=localhost;database=ali_barjeh;integrated security=true");
        public UC_cus_Rep()
        {
            InitializeComponent();
        }

        private void txtSearch_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txtId.Text != "")
                {
                    con.Open();
                    string select = "select * from v_orders where or_date between'" + dateTimePicker1.Text + "'and'"
                        + dateTimePicker2.Text + "'and cus_id=" + txtId.Text + "";
                    SqlCommand cmd = new SqlCommand(select, con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    con.Close();

                    CrystalFullReport cr = new CrystalFullReport();
                    cr.Database.Tables["v_orders"].SetDataSource(dt);
                    this.crystalReportViewer1.ReportSource = cr;
                }
                else
                {
                    MessageBox.Show("Please enter Customer id","Message",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
