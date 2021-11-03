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
    public partial class FormTakeStore : Form
    {
        SqlConnection con = new SqlConnection("server=localhost;database=ali_barjeh;integrated security=true");
        public FormTakeStore()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void readStock()
        {
            try
            {
                if (txtItemId.Text != "")
                {
                    con.Open();
                    string select = "select * from item where item_id =" + txtItemId.Text + "";
                    SqlCommand cmd = new SqlCommand(select, con);
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        txtStock.Text = dr.GetValue(2).ToString();
                    }
                    
                }
                else
                {
                    txtName.Clear();
                    txtPrice.Clear();
                    txtAvQty.Clear();
                    txtCost.Clear();
                    txtItemId.Clear();
                    txtTranQty.Clear();
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
        private void txtItemId_TextChanged(object sender, EventArgs e)
        {
            try
            {
                readStock();
                if (txtItemId.Text != "")
                {
                    con.Open();
                    string select = "select * from stock where item_id =" + txtItemId.Text + "";
                    SqlCommand cmd = new SqlCommand(select, con);
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        txtName.Text = dr.GetValue(2).ToString();
                        txtAvQty.Text = dr.GetValue(3).ToString();
                        txtCost.Text = dr.GetValue(4).ToString();
                        txtPrice.Text = dr.GetValue(5).ToString();

                    }
                    ;
                }
                else
                {
                    txtName.Clear();
                    txtPrice.Clear();
                    txtAvQty.Clear();
                    txtCost.Clear();
                    txtItemId.Clear();
                    txtTranQty.Clear();
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                int a_qty = int.Parse(txtAvQty.Text);
                int st_qty = int.Parse(txtStock.Text);
                int t_qty = int.Parse(txtTranQty.Text);
                int l_qty = a_qty + t_qty;
                int l_s_qty = st_qty - t_qty;

                if (st_qty ==0)
                {
                    MessageBox.Show("The "+txtName.Text+" is not available", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (st_qty < t_qty)
                {
                    MessageBox.Show("The stock qty is less than transfer qty", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    con.Open();
                    string update = "update stock set available=" + l_qty + "where item_id=" + txtItemId.Text + "";
                    SqlCommand cmd = new SqlCommand(update, con);
                    cmd.ExecuteNonQuery();

                    string update1 = "update item set available=" + l_s_qty + "where item_id=" + txtItemId.Text + "";
                    SqlCommand cmd1 = new SqlCommand(update1, con);
                    cmd1.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("The "+txtName.Text+" added "+txtTranQty.Text+ "", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtItemId.Clear();
                    txtName.Clear();
                    txtPrice.Clear();
                    txtCost.Clear();
                    txtAvQty.Clear();
                    txtTranQty.Clear();
                    txtStock.Clear();
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
