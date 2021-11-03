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
    public partial class UC_Salary : UserControl
    {
        SqlConnection con = new SqlConnection("server=localhost;database=ali_barjeh;integrated security=true");
        public UC_Salary()
        {
            InitializeComponent();
        }

        private void selectAll()
        {
            try
            {
                con.Open();
                string select = "select * from V_salary";
                SqlCommand cmd = new SqlCommand(select, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
                int sum = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    sum += int.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString());
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

        private void UC_Salary_Load(object sender, EventArgs e)
        {
            selectAll();
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
                string select = "select * from V_salary where id like'" + txtSearch.Text + "%'or em_firstname like'"
                    + txtSearch.Text + "%'or em_middlename like'" + txtSearch.Text + "%'or phone like'"+txtSearch.Text+"%'";
                SqlCommand cmd = new SqlCommand(select, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();

                int sum = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    sum += int.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString());
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

        private void btnNewSal_Click(object sender, EventArgs e)
        {
            FormAddSalary fs = new FormAddSalary();
            fs.ShowDialog();
        }

        private void btnnUpdate_Click(object sender, EventArgs e)
        {
            FormUpdateSalary fs = new FormUpdateSalary();
            fs.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
           
        }
    }
}
