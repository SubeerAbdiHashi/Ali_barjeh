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
    public partial class FormUpdateSalary : Form
    {
        SqlConnection con = new SqlConnection("server=localhost;database=ali_barjeh;integrated security=true");
        public FormUpdateSalary()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtSalId_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtSalId.Text != "")
                {
                    con.Open();
                    string select = "select * from salary where id =" + txtSalId.Text + "";
                    SqlCommand cmd = new SqlCommand(select, con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        txtEmpId.Text = dr.GetValue(1).ToString();
                        txtAmount.Text = dr.GetValue(2).ToString();
                    }
                    con.Close();
                }
                else
                {
                    txtEmpId.Clear();
                    txtAmount.Clear();
                    txtSalId.Clear();
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
