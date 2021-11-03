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
    public partial class UC_home1 : UserControl
    {
        SqlConnection con = new SqlConnection("server=localhost;database=ali_barjeh;integrated security=true");

        public UC_home1()
        {
            InitializeComponent();
        }

        // method display time is empty
        private void emptyItem()
        {
            try
            {
                int x=0;
                con.Open();
                string select = "select * from item where available=0";
                SqlCommand cmd = new SqlCommand(select, con);
                SqlDataReader dr=cmd.ExecuteReader();
                while (dr.Read())
                {
                    x++;
                }
                //label2.Text = x.ToString();
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
        // methods view  orders
        private void orderView()
        {
            try
            {
                con.Open();
                string select = "select count(id) from OrderLine";
                SqlCommand cmd = new SqlCommand(select, con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lblOrders.Text = dr.GetValue(0).ToString();
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
        // method view customer
        private void customerView()
        {
            try
            {
                con.Open();
                string select = "select count(cus_id) from Customer";
                SqlCommand cmd = new SqlCommand(select, con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lblCustomer.Text = dr.GetValue(0).ToString();
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

        // method view users
        private void userView()
        {
            try
            {
                con.Open();
                string select = "select count(hitNumber) from LoginForm";
                SqlCommand cmd = new SqlCommand(select, con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lblUser.Text = dr.GetValue(0).ToString();
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

        // method view items
        private void itemView()
        {
            try
            {
                con.Open();
                string select = "select count(item_id) from item";
                SqlCommand cmd = new SqlCommand(select, con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                   lblItem.Text= dr.GetValue(0).ToString();
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
        private void loadChart()
        {
            try
            {
                con.Open();
                string select = "select top(5)item_name,Sum_qty from v_chart order by sum_qty desc";
                SqlCommand cmd = new SqlCommand(select, con);
                SqlDataReader dr = cmd.ExecuteReader();
                //int x = 0;
                while (dr.Read())
                {
                        this.chart1.Series["SALES_ITEM"].Points.AddXY(dr.GetValue(0).ToString(), dr.GetValue(1).ToString());
                        //chart2.Series["SALES_ITEM"].IsValueShownAsLabel = true;
                        this.chart2.Series["SALES_ITEM"].Points.AddXY(dr.GetValue(0).ToString(), dr.GetValue(1).ToString());
                        chart3.Series["SALES_ITEM"].IsValueShownAsLabel = true;
                        this.chart3.Series["SALES_ITEM"].Points.AddXY(dr.GetValue(0).ToString(), dr.GetValue(1).ToString());              
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

        private void chart1_Click(object sender, EventArgs e)
        {
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UC_home1_Load(object sender, EventArgs e)
        {
            orderView();
            customerView();
            userView();
            itemView();
            loadChart();
            emptyItem();
        }

        private void btnCus_Click(object sender, EventArgs e)
        {
            UC_Customer uc = new UC_Customer();
            Dashboard db = new Dashboard();
            db.AddPanelControl(uc);
            UC_home1 uh = new UC_home1();
            uh.Hide();
        }

        private void btnAlarm_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string select = "select * from item where available=0";
                SqlCommand cmd = new SqlCommand(select, con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string item = dr.GetValue(1).ToString();
                    MessageBox.Show("The " + item + " is empty please buy new qty", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnLog_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEm_Click(object sender, EventArgs e)
        {
            
        }
    }
}
