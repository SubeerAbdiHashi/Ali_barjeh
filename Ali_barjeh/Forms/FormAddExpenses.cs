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
    public partial class FormAddExpenses : Form
    {
        SqlConnection con = new SqlConnection("server=localhost;database=ali_barjeh;integrated security=true");
        public FormAddExpenses()
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
                if (txtAmount.Text != "" && txtType.Text != "")
                {
                    con.Open();
                    string save = "insert into Expenses(ex_type,ex_amount,ex_date) values('" + txtType.Text + "',"
                        + txtAmount.Text + ",'" + dateTimePicker1.Text + "')";
                    SqlCommand cmd = new SqlCommand(save, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Save Successfully", "Message Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtAmount.Clear();
                    txtType.Clear();
                }
                else
                {
                    MessageBox.Show("Please Fill in the Blank", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtType.Focus();
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
