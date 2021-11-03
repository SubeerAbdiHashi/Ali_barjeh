using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Ali_barjeh.CrystalReport;

namespace Ali_barjeh.Forms
{
    public partial class FormSalesReport : Form
    {
        SqlConnection con = new SqlConnection("server=localhost;database=ali_barjeh;integrated security=true");
        public FormSalesReport()
        {
            InitializeComponent();
        }

        private void selectAll()
        {
            try
            {
                con.Open();
                string select = "select * from v_orders where or_id=(select max(or_id)from Orders)";
                SqlCommand cmd = new SqlCommand(select, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                con.Close();
                CR_sales cr = new CR_sales();
                cr.Database.Tables["v_orders"].SetDataSource(dt);
                this.crystalReportViewer1.ReportSource = cr;
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

        private void FormSalesReport_Load(object sender, EventArgs e)
        {
            selectAll();
        }
    }
}
