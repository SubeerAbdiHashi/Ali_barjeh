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
    public partial class UCFullReport : UserControl
    {
        SqlConnection con = new SqlConnection("server=localhost;database=ali_barjeh;integrated security=true");
        public UCFullReport()
        {
            InitializeComponent();
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string select = "select * from v_orders where or_date between'" + dateTimePicker1.Text + "'and'" + dateTimePicker2.Text + "'";
                SqlCommand cmd = new SqlCommand(select, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                con.Close();

                CrystalFullReport cr = new CrystalFullReport();
                cr.Database.Tables["v_orders"].SetDataSource(dt);
                this.crystalReportViewer1.ReportSource = cr;
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
