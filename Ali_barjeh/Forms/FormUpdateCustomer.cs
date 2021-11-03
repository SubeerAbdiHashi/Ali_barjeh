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
    public partial class FormUpdateCustomer : Form
    {
        SqlConnection con = new SqlConnection("server=localhost;database=ali_barjeh;integrated security=true");
        public FormUpdateCustomer()
        {
            InitializeComponent();
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtId.Text != "")
                {
                    con.Open();
                    string select = "select * from Customer where cus_id="+txtId.Text+"";
                    SqlCommand cmd = new SqlCommand(select, con);
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        txtFname.Text = dr.GetValue(1).ToString();
                        txtMname.Text = dr.GetValue(2).ToString();
                        txtLname.Text = dr.GetValue(3).ToString();
                        txtPhone.Text = dr.GetValue(4).ToString();
                        txtAddress.Text = dr.GetValue(5).ToString();
                    }
                    con.Close();
                }
                else
                {
                    txtId.Clear();
                    txtFname.Clear();
                    txtMname.Clear();
                    txtLname.Clear();
                    txtPhone.Clear();
                    txtAddress.Clear();
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
                if (txtFname.Text != "" && txtPhone.Text != "" && txtMname.Text != "")
                {
                    con.Open();
                    string update = "update customer set cus_firstname='" + txtFname.Text + "',cus_middleName='" + txtMname.Text + "',cus_lastName='"
                        + txtLname.Text + "',Phone=" + txtPhone.Text + ",cus_address='" + txtAddress.Text + "'where cus_id="+txtId.Text+"";
                    SqlCommand cmd = new SqlCommand(update, con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record Update successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();

                    txtId.Clear();
                    txtAddress.Clear();
                    txtFname.Clear();
                    txtMname.Clear();
                    txtLname.Clear();
                    txtPhone.Clear();
                }
                else
                {
                    MessageBox.Show("Please Enter Cusotmer Id or Correct","Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
