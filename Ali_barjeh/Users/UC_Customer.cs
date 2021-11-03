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
    public partial class UC_Customer : UserControl
    {
        SqlConnection con = new SqlConnection("server=localhost;database=ali_barjeh;integrated security=true;");
        public UC_Customer()
        {
            InitializeComponent();
        }

        private void selectAll()
        {
            try
            {
                con.Open();
                string select = "select * from Customer";
                SqlCommand cmd = new SqlCommand(select, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
                int sum = 0;
                for (int i = 0; i <= dataGridView1.Rows.Count; i++)
                {
                    sum = i;
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

        private void UC_Customer_Load(object sender, EventArgs e)
        {
            selectAll();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
          try
            {
                con.Open();
                string select = "select * from Customer where cus_id like'"+txtSearch.Text+"%'or cus_firstname like'"+txtSearch.Text+"%'or Phone like'"+
                   txtSearch.Text+"%'or cus_middleName like '"+txtSearch.Text+"%' or cus_lastName like'"+txtSearch.Text+"%'or cus_address like '"+txtSearch.Text+"%'";
                SqlCommand cmd = new SqlCommand(select, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
                int sum = 0;
                for (int i = 0; i <= dataGridView1.Rows.Count; i++)
                {
                    sum = i;
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

        private void btnNewCus_Click(object sender, EventArgs e)
        {
            FormAddCustomer fc = new FormAddCustomer();
            fc.ShowDialog();
        }

        private void btnnUpdate_Click(object sender, EventArgs e)
        {
            FormUpdateCustomer fu = new FormUpdateCustomer();
            fu.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int de = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                DialogResult dr = MessageBox.Show("Are sure to delete the row you selected", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    con.Open();
                    string delete = "delete from Customer where cus_id=" + de + "";
                    SqlCommand cmd = new SqlCommand(delete, con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("The row deleted", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
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
