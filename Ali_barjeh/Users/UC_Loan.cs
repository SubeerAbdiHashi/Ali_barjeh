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
using Ali_barjeh.Forms;

namespace Ali_barjeh.Users
{
    public partial class UC_Loan : UserControl
    {
        SqlConnection con = new SqlConnection("server=localhost;database=Ali_barjeh;integrated security=true");
        public UC_Loan()
        {
            InitializeComponent();
        }

        private void selectAll()
        {
            try
            {
                con.Open();
                string select = "select * from loan";
                SqlCommand cmd = new SqlCommand(select,con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
                int sum = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    sum += int.Parse(dataGridView1.Rows[i].Cells[8].Value.ToString());
                }
                lblTotal.Text = sum.ToString();
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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            selectAll();
        }

        private void UC_Loan_Load(object sender, EventArgs e)
        {
            selectAll();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string select = "select * from loan where phone like'"+txtSearch.Text+"%' or cus_firstname like'"
                    +txtSearch.Text+"%' or or_id like '"+txtSearch.Text+"%'";
                SqlCommand cmd = new SqlCommand(select, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
                int sum = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    sum += int.Parse(dataGridView1.Rows[i].Cells[8].Value.ToString());
                }
                lblTotal.Text = sum.ToString();
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

        private void btnnUpdate_Click(object sender, EventArgs e)
        {
            FormUpdateLoan fl = new FormUpdateLoan();
            fl.ShowDialog();
        }
    }
}
