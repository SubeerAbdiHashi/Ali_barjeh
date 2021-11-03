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

namespace Ali_barjeh
{
    public partial class Form2Rep : Form
    {
        SqlConnection con = new SqlConnection("server=localhost;database=ali_barjeh;integrated security=true");
        public Form2Rep()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string select = "select * from V_orders where or_id=" + textBox1.Text+ "";
                SqlCommand cmd = new SqlCommand(select, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                con.Close();

                CrystalReport1 cr = new CrystalReport1();
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
    }
}
