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
    public partial class FormUpdate_Item : Form
    {
        SqlConnection con = new SqlConnection("server=localhost;database=ali_barjeh;integrated security=true");
        public FormUpdate_Item()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text != "" && txtQty.Text != "" && txtCost.Text != "" && txtPrice.Text != "")
                {
                    con.Open();
                    string update = "update item set item_name='" + txtName.Text + "',Available=" + txtQty.Text + ",item_cost=" + txtCost.Text + ",item_price="
                        + txtPrice.Text + "where item_id="+txtId.Text+"";
                    SqlCommand cmd = new SqlCommand(update, con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record update successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();

                    txtName.Clear();
                    txtPrice.Clear();
                    txtId.Clear();
                    txtQty.Clear();
                    txtCost.Clear();
                }
                else
                {
                    MessageBox.Show("Please Enter Item id or Correct", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void txtId_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtId.Text != "")
                {
                    con.Open();
                    string select = "select * from item where item_id =" + txtId.Text + "";
                    SqlCommand cmd = new SqlCommand(select, con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        txtName.Text = dr.GetValue(1).ToString();
                        txtQty.Text = dr.GetValue(2).ToString();
                        txtCost.Text = dr.GetValue(3).ToString();
                        txtPrice.Text = dr.GetValue(4).ToString();
                    }
                    con.Close();
                }
                else
                {
                    txtName.Clear();
                    txtPrice.Clear();
                    txtCost.Clear();
                    txtQty.Clear();
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
