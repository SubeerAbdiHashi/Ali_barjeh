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
    public partial class UC_Employee : UserControl
    {
        SqlConnection con = new SqlConnection("server=localhost;database=Ali_barjeh;integrated security=true");
        public UC_Employee()
        {
            InitializeComponent();
        }

        private void UC_Employee_Load(object sender, EventArgs e)
        {
            selectAll();
        }

        private void selectAll()
        {
            try
            {
                con.Open();
                string select = "select * from Employee";
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

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string select = "select * from Employee where em_id like'" + txtSearch.Text + "%'or em_firstname like'" +
                    txtSearch.Text + "%'or em_middlename like'" + txtSearch.Text + "%'or em_type like'" 
                    + txtSearch.Text + "%'or em_lastname like'"+ txtSearch.Text + "%'or phone like'"
                    + txtSearch.Text + "%' or em_address like'" + txtSearch.Text + "%'";
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

        private void btnNewEm_Click(object sender, EventArgs e)
        {
            FormAddEmployee fe = new FormAddEmployee();
            fe.ShowDialog();
        }

        private void btnnUpdate_Click(object sender, EventArgs e)
        {
            FormUpdateEmployee fu = new FormUpdateEmployee();
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
                    string delete = "delete from Employee where em_id=" + de + "";
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
