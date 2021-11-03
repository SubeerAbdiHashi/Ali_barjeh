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

namespace Ali_barjeh.Forms
{
    public partial class FormUpdateExpenses : Form
    {
        SqlConnection con = new SqlConnection("server=localhost;database=Ali_barjeh;integrated security=true");
        public FormUpdateExpenses()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtId.Text != "")
                {
                    con.Open();
                    string select = "select * from expenses where id=" + txtId.Text + "";
                    SqlCommand cmd = new SqlCommand(select, con);
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        txtAmount.Text = dr.GetValue(2).ToString();
                        txtType.Text = dr.GetValue(1).ToString();
                    }
                    con.Close();
                }
                else
                {
                    txtType.Clear();
                    txtAmount.Clear();
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
             try
            {
                if (txtId.Text != "" && txtType.Text != "" && txtAmount.Text!="")
                {
                    con.Open();
                    string update = "update Expenses set Ex_type='" + txtType.Text + "',Ex_amount=" + txtAmount.Text + " where id=" + txtId.Text + "";
                    SqlCommand cmd = new SqlCommand(update, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Update Successfully", "Message update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                    txtId.Clear();
                    txtAmount.Clear();
                    txtType.Clear();
                }
                else
                {
                    MessageBox.Show("Please Enter ID or Correct ID", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtId.Focus();
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
