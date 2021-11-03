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
    public partial class UC_Expenses : UserControl
    {
        SqlConnection con = new SqlConnection("server=localhost;database=ali_barjeh;integrated security=true");
        public UC_Expenses()
        {
            InitializeComponent();
        }
        private void selectAll()
        {
            try
            {
                con.Open();
                string select = "select * from expenses";
                SqlCommand cmd = new SqlCommand(select, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
                int sum = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    sum += int.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString());
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

        private void UC_Expenses_Load(object sender, EventArgs e)
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
                if (txtSearch.Text != "")
                {
                    con.Open();
                    string select = "select * from expenses where id like'" + txtSearch.Text + "%' or ex_type like '" + txtSearch.Text + "%'";
                    SqlCommand cmd = new SqlCommand(select, con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    con.Close();
                    int sum = 0;
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        sum += int.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString());
                    }
                    lblTotal.Text = sum.ToString();
                }
                else
                {
                    selectAll();
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            FormAddExpenses fe = new FormAddExpenses();
            fe.ShowDialog();
        }

        private void btnnUpdate_Click(object sender, EventArgs e)
        {
            FormUpdateExpenses fu = new FormUpdateExpenses();
            fu.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                DialogResult dr = MessageBox.Show("Are sure to delete the row you selected", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr==DialogResult.Yes)
                {
                    con.Open();
                    string select = "delete from expenses where id=" +id+"";
                    SqlCommand cmd = new SqlCommand(select, con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
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
