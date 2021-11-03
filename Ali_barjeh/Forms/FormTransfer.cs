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
    public partial class FormTransfer : Form
    {
        SqlConnection con = new SqlConnection("server=localhost;database=ali_barjeh;integrated security=true");
        public FormTransfer()
        {
            InitializeComponent();
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text != "" && txtQty.Text != "" && txtCost.Text != "" && txtPrice.Text != "" && txtItemId.Text != "" && txtTranQty.Text != "")
                {
                    int a_qty=int.Parse(txtQty.Text);
                    int qty=int.Parse(txtTranQty.Text);
                    int l_qty=a_qty-qty;
                    if (a_qty == 0)
                    {
                        MessageBox.Show("The item is empty please buy new item qty", "Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else if (a_qty >= qty)

                    {
                        con.Open();
                        string save = "insert into stock(item_id,item_name,available,item_cost,item_price)values(" + txtItemId.Text + ",'" + txtName.Text + "'," + txtTranQty.Text + "," +
                            txtCost.Text + "," + txtPrice.Text + ")";
                        SqlCommand cmd = new SqlCommand(save, con);
                        cmd.ExecuteNonQuery();

                        string update = "update item set available=" + l_qty + "where item_id="+txtItemId.Text;
                        SqlCommand cmd1 = new SqlCommand(update, con);
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        cmd1.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Record save successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        txtName.Clear();
                        txtPrice.Clear();
                        txtQty.Clear();
                        txtCost.Clear();
                        txtItemId.Clear();
                        txtTranQty.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Stock qty is less than transfer qty", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    
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

        private void txtItemId_TextChanged(object sender, EventArgs e)
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
                        txtName.Text = dr.GetValue(1).ToString();
                        txtQty.Text = dr.GetValue(2).ToString();
                        txtCost.Text = dr.GetValue(3).ToString();
                        txtPrice.Text = dr.GetValue(4).ToString();

                    }
               ;
                }
                else
                {
                    txtName.Clear();
                    txtPrice.Clear();
                    txtQty.Clear();
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
