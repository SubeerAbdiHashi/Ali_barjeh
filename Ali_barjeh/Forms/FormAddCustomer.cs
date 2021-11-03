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
    public partial class FormAddCustomer : Form
    {
        SqlConnection con = new SqlConnection("server=localhost;database=ali_barjeh;integrated security=true");
        public FormAddCustomer()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFname.Text != "" && txtPhone.Text != "" && txtMname.Text != "")
                {
                    con.Open();
                    string save = "insert into customer (cus_firstname,cus_middlename,cus_lastname,phone,cus_address)values('" + txtFname.Text + "','" +
                        txtMname.Text + "','" + txtLname.Text + "'," + txtPhone.Text + ",'" + txtAddress.Text + "')";
                    SqlCommand cmd = new SqlCommand(save, con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record save successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();

                    txtAddress.Clear();
                    txtFname.Clear();
                    txtMname.Clear();
                    txtLname.Clear();
                    txtPhone.Clear();
                }
                else
                {
                    MessageBox.Show("Please Enter First Name , Middle Name and Phone", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtFname.Focus();
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
