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
    public partial class UC_stock : UserControl
    {
        SqlConnection con = new SqlConnection("server=localhost;database=ali_barjeh;integrated security=true");
        public UC_stock()
        {
            InitializeComponent();
        }

        private void selectAll()
        {
            try
            {
                con.Open();
                string select = "select * from stock order by Item_id asc";
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

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

            try
            {
                if (txtSearch.Text != "")
                {
                    con.Open();
                    string select = "select * from stock where item_id like'" + txtSearch.Text + "%'or item_name like'" + txtSearch.Text + "%'";
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
                else
                {
                    selectAll();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Message",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void UC_stock_Load(object sender, EventArgs e)
        {
            selectAll();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            selectAll();
        }

        private void btnNewStock_Click(object sender, EventArgs e)
        {

        }

        private void btnnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnTake_Click(object sender, EventArgs e)
        {

        }

        private void btnTake_Click_1(object sender, EventArgs e)
        {
            FormTakeStore ft = new FormTakeStore();
            ft.ShowDialog();
        }
    }
}
