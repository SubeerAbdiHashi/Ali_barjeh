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
    public partial class FormUpdateSupplier : Form
    {
        SqlConnection con = new SqlConnection("server=localhost;database=Ali_barjeh;integrated security=true");
        public FormUpdateSupplier()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "")
                {
                    con.Open();
                    string select = "select * from supplier where sup_id=" + textBox1.Text + "";
                    SqlCommand cmd = new SqlCommand(select, con);
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        txtName.Text = dr.GetValue(1).ToString();
                        txtPhone.Text = dr.GetValue(2).ToString();
                        txtAddress.Text = dr.GetValue(3).ToString();
                    }
                    con.Close();
                }
                else
                {
                    txtAddress.Clear();
                    txtName.Clear();
                    txtPhone.Clear();
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
                if (txtName.Text != "" && txtPhone.Text != "" && txtAddress.Text != "" && textBox1.Text!="")
                {
                    con.Open();
                    string save = "update supplier set sup_name='"+txtName.Text+"',phone="+txtPhone.Text+",sup_address='"
                        +txtAddress.Text+"'where sup_id="+textBox1.Text+"";
                    SqlCommand cmd = new SqlCommand(save, con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record Update successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();

                    txtAddress.Clear();
                    txtName.Clear();
                    txtPhone.Clear();
                    txtAddress.Clear();
                    textBox1.Clear();
                }
                else
                {
                    MessageBox.Show("Please Enter Supplier Id or Correct", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox1.Focus();
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
