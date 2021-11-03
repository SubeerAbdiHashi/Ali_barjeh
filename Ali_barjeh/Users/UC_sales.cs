using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Ali_barjeh.Forms;

namespace Ali_barjeh.Users
{
    public partial class UC_sales : UserControl
    {
        SqlConnection con = new SqlConnection("server=localhost;database=ali_barjeh;integrated security=true");
        public UC_sales()
        {
            InitializeComponent();
        }
        private void selectAll()
        {
            try
            {
                con.Open();
                string select = "select * from Stock";
                SqlCommand cmd = new SqlCommand(select, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
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
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtSearch.Text == "")
                {
                    label13.Show();
                }
                else
                {
                    label13.Hide();
                }

                con.Open();
                string select = "select * from Stock where item_id like'" + txtSearch.Text + "%'or item_name like'" + txtSearch.Text + "%'";
                SqlCommand cmd = new SqlCommand(select, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            selectAll();
        }

        private void UC_sales_Load(object sender, EventArgs e)
        {
            selectAll();
            this.Refresh();
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtItemId.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                txtItemName.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                txtAvailableQty.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                txtPrice.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                txtQuantity.Text = "1";
                //calcuting total
                int qty = int.Parse(txtQuantity.Text);
                double price = int.Parse(txtPrice.Text);
                double total = price * qty;
                txtTotal.Text = total.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtQuantity.Text != "")
                {
                    int qty = int.Parse(txtQuantity.Text);
                    double price = int.Parse(txtPrice.Text);
                    double total = price * qty;
                    txtTotal.Text = total.ToString();
                }
                else
                {
                    txtTotal.Text = "0";
                }
             
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // update qty
        private void updateQty()
        {
            try
            {
                int id = int.Parse(txtItemId.Text);
                int a_qty = int.Parse(txtAvailableQty.Text);
                int qty = int.Parse(txtQuantity.Text);
                int l_qty = a_qty - qty;

                con.Open();
                string update = "update stock set available=" + l_qty + " where item_id=" + id + "";
                SqlCommand cmd = new SqlCommand(update, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                con.Close();
                selectAll();
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
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int a_qty = int.Parse(txtAvailableQty.Text);
                int qty = int.Parse(txtQuantity.Text);
                int n_qty = a_qty - qty;

                if (a_qty==0)
                {
                    MessageBox.Show("The item quantity is not available\nplease take new quantity from stcok", "Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtItemName.Clear();
                    txtQuantity.Clear();
                    txtPrice.Clear();
                    txtTotal.Clear();
                }
                else if (a_qty < qty)
                {
                    MessageBox.Show("The item quantity is less than new quantity\nplease take more quantity from stck", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtItemName.Clear();
                    txtQuantity.Clear();
                    txtPrice.Clear();
                    txtTotal.Clear();
                    txtAvailableQty.Clear();
                    txtItemId.Clear();


                }
                else if (n_qty < 5)
                {
                    MessageBox.Show("The item quantity is less than 5\nplease add new quantity from stock", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dataGridView2.Rows.Add(txtItemId.Text, txtItemName.Text, txtPrice.Text, txtQuantity.Text, txtTotal.Text, "Delete", txtAvailableQty.Text);
                    // method call update qty
                    updateQty();

                    int sum = 0;
                    for (int rows = 0; rows < dataGridView2.Rows.Count; rows++)
                    {
                        sum += int.Parse(dataGridView2.Rows[rows].Cells[4].Value.ToString());
                    }
                    txtTotalAmount.Text = sum.ToString();
                    txtSubtotal.Text = sum.ToString();
                    txtDiscount.Text = "0";
                    txtItemName.Clear();
                    txtQuantity.Clear();
                    txtTotal.Clear();
                    txtPrice.Clear();
                    txtItemId.Clear();
                    txtAvailableQty.Clear();
                }
                else
                {
                    dataGridView2.Rows.Add(txtItemId.Text, txtItemName.Text, txtPrice.Text, txtQuantity.Text, txtTotal.Text, "Delete", txtAvailableQty.Text);
                    // method call update qty
                    updateQty();

                    int sum = 0;
                    for (int rows = 0; rows < dataGridView2.Rows.Count; rows++)
                    {
                        sum += int.Parse(dataGridView2.Rows[rows].Cells[4].Value.ToString());
                    }
                    txtTotalAmount.Text = sum.ToString();
                    txtSubtotal.Text = sum.ToString();
                    txtDiscount.Text = "0";
                    txtItemName.Clear();
                    txtQuantity.Clear();
                    txtTotal.Clear();
                    txtPrice.Clear();
                    txtItemId.Clear();
                    txtAvailableQty.Clear();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtDiscount.Text != "")
                {
                    double total = double.Parse(txtTotalAmount.Text);
                    double discount = double.Parse(txtDiscount.Text);
                    double tot = total - discount;
                    txtSubtotal.Text = tot.ToString();
                }
                else
                {
                    txtSubtotal.Text = "0";
                    txtReceipt.Clear();
                    txtBalance.Clear();
                }
         
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtReceipt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtReceipt.Text!="")
                {
                    double subt = double.Parse(txtSubtotal.Text);
                    double rec = double.Parse(txtReceipt.Text);
                    double bal = subt - rec;
                    txtBalance.Text = bal.ToString();
                }
                else
                {
                    txtBalance.Text = "";
                }
            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // method
        private void save()
        {
            try
            {
                if (txtCusId.Text != "")
                {
                    con.Open();
                    string save = "insert into orders(cus_id,or_date)values(" + txtCusId.Text + ",'" + dateTimePicker1.Text + "')select @@identity";
                    SqlCommand cmd = new SqlCommand(save, con);
                    int id = int.Parse(cmd.ExecuteScalar().ToString());

                    // declared variables
                    int qty = 0;
                    int total = 0;
                    string item_name;

                    for (int row = 0; row < dataGridView2.Rows.Count; row++)
                    {
                        int item_id = int.Parse(dataGridView2.Rows[row].Cells[0].Value.ToString());
                        qty = int.Parse(dataGridView2.Rows[row].Cells[3].Value.ToString());
                        total = int.Parse(dataGridView2.Rows[row].Cells[4].Value.ToString());
                        item_name = dataGridView2.Rows[row].Cells[1].Value.ToString();

                        string insert = "insert into orderLine(or_id,item_id,qty,total)values(" + id + "," + item_id + "," + qty + "," + total + ")";
                        SqlCommand cmd2 = new SqlCommand(insert, con);
                        cmd2.ExecuteNonQuery();
                    }

                    string save2 = "insert into payment(total_amount,discount,net_total,receipt,or_id,balance)values(" + txtTotalAmount.Text + ","
                        + txtDiscount.Text + "," + txtSubtotal.Text + "," + txtReceipt.Text + "," + id + "," + txtBalance.Text + ")";
                    SqlCommand cmd3 = new SqlCommand(save2, con);
                    cmd3.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Sales Compeleted Successfull", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Please Enter Customer Id", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnPrint_Click(object sender, EventArgs e)
        {
            save();
            if (txtCusId.Text != "")
            {
                FormSalesReport fs = new FormSalesReport();
                fs.Show();
            }
        }
        // method updated qty delete
        private void updateQtyDeleted()
        {
            try
            {
           
            int qty = int.Parse(txtAvailableQty.Text);
            con.Open();
            string select = "select * from Stock where item_id=" + txtItemId.Text + "";
            SqlCommand cmd = new SqlCommand(select, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txtitemQty.Text = dr.GetValue(3).ToString();       
            }
            con.Close();
            int a_qty = int.Parse(txtitemQty.Text);
            int l_qty = a_qty + qty;
            con.Open();
            string update = "update Stock set available=" + l_qty + "where item_id=" + txtItemId.Text+ "";
            SqlCommand cmd1 = new SqlCommand(update, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd1);
            cmd1.ExecuteNonQuery();
            con.Close();
            selectAll();


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

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are sure to delete", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                txtItemId.Text = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
                txtAvailableQty.Text=dataGridView2.SelectedRows[0].Cells[3].Value.ToString();
                int sum = 0;
                if (e.ColumnIndex == dataGridView2.Columns["DELETE"].Index && e.RowIndex >= 0)
                {
                    dataGridView2.Rows.Remove(dataGridView2.Rows[e.RowIndex]);


                    for (int rows = 0; rows < dataGridView2.Rows.Count; rows++)
                    {
                        sum += int.Parse(dataGridView2.Rows[rows].Cells[4].Value.ToString());
                    }
                    updateQtyDeleted();
                    txtTotalAmount.Text = sum.ToString();
                    txtSubtotal.Text = sum.ToString();
                    txtDiscount.Text = "0";
                }
            }
     
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtItemName.Clear();
            txtQuantity.Clear();
            txtTotal.Clear();
            txtPrice.Clear();
            txtItemId.Clear();
            txtAvailableQty.Clear();
       
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
