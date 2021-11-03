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
using Ali_barjeh.Users;

namespace Ali_barjeh.Forms
{
    public partial class Form_login : Form
    {
        SqlConnection con = new SqlConnection("server=localhost;database=ali_barjeh;integrated security=true");
        public Form_login()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                btnShow.Hide();
                txtPass.PasswordChar = none;
                txtPass.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            try
            {
                btnShow.Show();
                txtPass.PasswordChar = '*';
                txtPass.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public char none { get; set; }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
            if (txtUser.Text != "")
            {
                lblUser.Hide();
            }
            else
            {
                lblUser.Show();
            }
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            if (txtPass.Text != "")
            {
                lblPass.Hide();
            }
            else
            {
                lblPass.Show();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkBox1.Checked)
                {
                    string role = "admin";
                    con.Open();
                    string select = "select * from loginForm where username='" + txtUser.Text + "' and pass='" + txtPass.Text + "'and userRole='"+role+"'";
                    SqlCommand cmd = new SqlCommand(select, con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    con.Close();
                    if (dt.Rows.Count == 1)
                    {
                        Dashboard fd = new Dashboard();
                        fd.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Username, Password or Role please check", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtUser.Focus();
                    } 
                }
                else if (checkBox2.Checked)
                {
                    string role="user";
                    con.Open();
                    string select = "select * from loginForm where username='" + txtUser.Text + "' and pass='" + txtPass.Text + "'and userRole='"+role+"'";
                    SqlCommand cmd = new SqlCommand(select, con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    con.Close();

                    if (dt.Rows.Count == 1)
                    {
                        Dashboard fd = new Dashboard();
                        fd.Show();
                        fd.btnUser.Enabled = false; ;
                        fd.btnSupplier.Enabled = false;
                        fd.btnSalary.Enabled = false;
                        fd.btnItems.Enabled = false;
                        fd.btnEmployee.Enabled = false;
                        fd.btnExpenses.Enabled = false;
                        fd.btnLoan.Enabled = false;
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Username, Password or Role please check", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtUser.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Please fill the blank or check your Role", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                con.Close();
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox2.Checked = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                checkBox1.Checked = false;
            }
        }

        private void Form_login_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            FormForget ff = new FormForget();
            ff.Show();
        }
    }
}
