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
    public partial class FormUpdateLoan : Form
    {
        SqlConnection con = new SqlConnection("server=localhost;database=ali_barjeh;integrated security=true");
        public FormUpdateLoan()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtId.Text != "" && txtNetTotal.Text!="" && txtReceipt.Text!="" && txtBalance.Text!="")
                {
                    con.Open();

                    string update = "update loan set receipt=" + txtReceipt.Text + ",balance=" + txtBalance.Text + "where or_id=" + txtId.Text + "";
                    SqlCommand cmd = new SqlCommand(update, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Update Successfully", "The Row Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();

                    txtId.Clear();
                    txtNetTotal.Clear();
                    txtReceipt.Clear();
                    txtBalance.Clear();
                }
                else
                {
                    MessageBox.Show("Please Enter Id or Correct Id", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void txtReceipt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtReceipt.Text != "")
                {
                    double total = double.Parse(txtNetTotal.Text);
                    double rec = double.Parse(txtReceipt.Text);
                    double bal = total - rec;
                    txtBalance.Text = bal.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtId.Text != "")
                {
                    con.Open();
                    string select = "select * from loan where or_id=" + txtId.Text + "";
                    SqlCommand cmd = new SqlCommand(select, con);
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        txtNetTotal.Text = dr.GetValue(6).ToString();
                        txtReceipt.Text = dr.GetValue(7).ToString();
                        //txtBalance.Text = dr.GetValue(8).ToString();
                    }

                    con.Close();
                }
                else
                {
                    txtNetTotal.Clear();
                    txtReceipt.Clear();
                    txtBalance.Clear();
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
    }
}
