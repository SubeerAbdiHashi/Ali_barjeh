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
    public partial class FormAdd_Item : Form
    {
        SqlConnection con = new SqlConnection("server=localhost;database=ali_barjeh;integrated security=true");
        public FormAdd_Item()
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
                if (txtName.Text != "" && txtQty.Text != "" && txtCost.Text != "" && txtPrice.Text!="" && txtSupId.Text!=""&&txtSupName.Text!="")
                {
                    con.Open();
                    string save = "insert into item(item_name,available,item_cost,item_price)values('" + txtName.Text + "'," + txtQty.Text + "," +
                        txtCost.Text + "," + txtPrice.Text + ")select @@identity";
                    SqlCommand cmd = new SqlCommand(save, con);
                   int id=int.Parse( cmd.ExecuteScalar().ToString());

                   string insert = "insert into purchase(item_id,sup_id)values(" + id + "," + txtSupId.Text + ")";
                   SqlCommand cmd1 = new SqlCommand(insert, con);
                   SqlDataAdapter da = new SqlDataAdapter(cmd1);
                    cmd1.ExecuteNonQuery();
                    MessageBox.Show("Record save successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();

                    txtName.Clear();
                    txtPrice.Clear();
                    txtQty.Clear();
                    txtCost.Clear();
                    txtSupId.Clear();
                }
                else
                {
                    MessageBox.Show("Please Fill the blank", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void txtSupId_TextChanged(object sender, EventArgs e)
        {
            if (txtSupId.Text != "")
            {
                try
                {
                    con.Open();
                    string select = "select*from supplier where sup_id="+txtSupId.Text+"";
                    SqlCommand cmd = new SqlCommand(select, con);
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        txtSupName.Text = dr.GetValue(1).ToString();
                    }
                    con.Close();
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
            else
            {
                txtSupName.Clear();
            }

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
