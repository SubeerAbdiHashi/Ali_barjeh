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
    public partial class FormForget : Form
    {
        SqlConnection con = new SqlConnection("server=localhost;database=ali_barjeh;integrated security=true");
        public FormForget()
        {
            InitializeComponent();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            try
            {
                string phone = "";
                string pho = txtPhone1.Text;
                if (txtusername1.Text != "" && txtPass1.Text != "" && txtPhone1.Text != "" && comboBox2.Text != "")
                {
                    con.Open();
                    string select = "select*from loginForm where hitNumber =" + txtPhone1.Text + "";
                    SqlCommand cmd = new SqlCommand(select, con);
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        phone = dr.GetValue(3).ToString();
                    }
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Please fill blank", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (phone == pho)
                {
                    if (txtPhone1.Text != "")
                    {
                        con.Open();
                        string update = "update loginForm set username='" + txtusername1.Text + "',pass='" + txtPass1.Text + "',UserRole='"
                            + comboBox2.Text + "'where hitNumber=" + txtPhone1.Text + "";
                        SqlCommand cmd1 = new SqlCommand(update, con);
                        SqlDataAdapter da = new SqlDataAdapter(cmd1);
                        cmd1.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("You changed the acount", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Form_login fl = new Form_login();
                        fl.Show();
                        this.Close();
                        txtusername1.Clear();
                        txtPass1.Clear();
                        txtPhone1.Clear();
                        comboBox2.Text = "";
                    }

                }
                else
                {
                    MessageBox.Show("Please correct the phone", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Incorect Current number please correct", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnShow1_Click(object sender, EventArgs e)
        {
            txtPass1.PasswordChar = none;
            btnShow1.Hide();
        }

        public char none { get; set; }

        private void btnHide1_Click(object sender, EventArgs e)
        {
            txtPass1.PasswordChar = '*';
            btnShow1.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormForget_Load(object sender, EventArgs e)
        {
            txtPhone1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
