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
    public partial class FormAddEmployee : Form
    {
        SqlConnection con = new SqlConnection("server=localhost;database=ali_barjeh;integrated security=true");
        public FormAddEmployee()
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
                if (txtFname.Text != "" && txtPhone.Text != "" && txtMname.Text != "" && txtLname.Text!="")
                {
                    con.Open();
                    string save = "insert into Employee (em_firstname,em_middlename,em_lastname,em_type,phone,Salary,em_address)values('" + txtFname.Text + "','" +
                        txtMname.Text + "','" + txtLname.Text + "','" +txtType.Text+"',"+ txtPhone.Text +","+txtSalary.Text +",'" + txtAddress.Text + "')";
                    SqlCommand cmd = new SqlCommand(save, con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record save successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();

                    txtAddress.Clear();
                    txtFname.Clear();
                    txtMname.Clear();
                    txtType.Clear();
                    txtLname.Clear();
                    txtPhone.Clear();
                    txtSalary.Clear();
                }
                else
                {
                    MessageBox.Show("Please Enter First Name , Middle Name ,last Name and Phone", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtLname.Focus();
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
