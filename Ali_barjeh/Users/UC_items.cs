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
    public partial class UC_items : UserControl
    {
        SqlConnection con = new SqlConnection("server=localhost;database=ali_barjeh;integrated security=true");
        public UC_items()
        {
            InitializeComponent();
        }

        private void selectAll()
        {
            try
            {
                con.Open();
                string select = "select * from v_item";
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
                string select = "select * from v_item where item_id like'"+txtSearch.Text+"%'or item_name like'"+txtSearch.Text+"%'";
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

        private void UC_items_Load(object sender, EventArgs e)
        {
            selectAll();
        }

        private void btnNewItem_Click(object sender, EventArgs e)
        {
            FormAdd_Item fi = new FormAdd_Item();
            fi.ShowDialog();
        }

        private void btnnUpdate_Click(object sender, EventArgs e)
        {
            FormUpdate_Item fu = new FormUpdate_Item();
            fu.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int de = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());

                DialogResult dr = MessageBox.Show("Are sure to delete the row you selected", "message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    con.Open();
                    string select = "delete from item where item_id =" + de + "";
                    SqlCommand cmd = new SqlCommand(select, con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("The record deleted", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            FormTransfer fr = new FormTransfer();
            fr.ShowDialog();
        }
    }
}
