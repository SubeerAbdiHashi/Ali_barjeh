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
    public partial class FormAddSupplier : Form
    {
        SqlConnection con = new SqlConnection("server=localhost;database=ali_barjeh;integrated security=true");
        public FormAddSupplier()
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
                if (txtName.Text != "" && txtPhone.Text != "" && txtAddress.Text != "")
                {
                    con.Open();
                    string save = "insert into supplier(sup_name,phone,sup_address) values('" + txtName.Text + "'," + txtPhone.Text + ",'" + txtAddress.Text + "')";
                    SqlCommand cmd = new SqlCommand(save, con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record save successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();

                    txtAddress.Clear();
                    txtName.Clear();
                    txtPhone.Clear();
                    txtAddress.Clear();
                }
                else
                {
                    MessageBox.Show("Please Fill th blank", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtName.Focus();
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
