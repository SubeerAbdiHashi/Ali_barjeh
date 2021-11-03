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
    public partial class FormAddSalary : Form
    {
        SqlConnection con = new SqlConnection("server=localhost;database=ali_barjeh;integrated security=true");
        public FormAddSalary()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtEmId.Text != "" && txtAmount.Text != "")
                {
                    con.Open();
                    string save = "insert into salary(em_id,salary_amount,salary_date) values(" + txtEmId.Text + "," + txtAmount.Text +",'"+
                        dateTimePicker1.Text+"')";
                    SqlCommand cmd = new SqlCommand(save, con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record save successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();

                    txtAmount.Clear();
                    txtEmId.Clear();
                }
                else
                {
                    MessageBox.Show("Please Fill the blank", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtEmId.Focus();
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

        private void txtEmId_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtEmId.Text != "")
                {
                    con.Open();
                    string select = "select*from employee where em_id=" + txtEmId.Text + "";
                    SqlCommand cmd = new SqlCommand(select, con);
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        txtFname.Text = dr.GetValue(1).ToString();
                        txtMname.Text = dr.GetValue(2).ToString();
                        txtLname.Text = dr.GetValue(3).ToString();
                        txtAmount.Text = dr.GetValue(7).ToString();
                    }
                    con.Close();
                }
                else
                {
                    txtEmId.Clear();
                    txtFname.Clear();
                    txtMname.Clear();
                    txtLname.Clear();
                    txtAmount.Clear();
                }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                }
        }
    }
}
