using Ali_barjeh.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ali_barjeh.Forms
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        public void movePanel(Control btn)
        {
            pnlMove.Top = btn.Top;
            pnlMove.Height = pnlMove.Height;
        }

        public void AddPanelControl(Control c)
        {
            c.Dock = DockStyle.Fill;
            pnlCenter.Controls.Clear();
            pnlCenter.Controls.Add(c);

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            pnlMove.Show();
            movePanel(btnHome);
            //Us_home uh = new Us_home();
            UC_home1 uh = new UC_home1();
            AddPanelControl(uh);
            lblShow.Text = "Home";
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            pnlMove.Show();
            movePanel(btnOrders);
            UC_sales us = new UC_sales();
            AddPanelControl(us);
            lblShow.Text = "Sales";
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            pnlMove.Show();
            movePanel(btnCustomer);
            UC_Customer uc = new UC_Customer();
            AddPanelControl(uc);
            lblShow.Text = "Customers";
        }

        private void btnItems_Click(object sender, EventArgs e)
        {
            pnlMove.Show();
            movePanel(btnItems);
            UC_items ui = new UC_items();
            AddPanelControl(ui);
            lblShow.Text = "Stock";
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            pnlMove.Show();
            movePanel(btnSupplier);
            UC_Supplier us = new UC_Supplier();
            AddPanelControl(us);
            lblShow.Text = "Suppliers";
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            pnlMove.Show();
            movePanel(btnEmployee);
            UC_Employee ue = new UC_Employee();
            AddPanelControl(ue);
            lblShow.Text = "Employee";
        }

        private void btnSalary_Click(object sender, EventArgs e)
        {
            pnlMove.Show();
            movePanel(btnSalary);
            UC_Salary us = new UC_Salary();
            AddPanelControl(us);
            lblShow.Text = "Salary";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            lblTime.Text = dt.ToString("HH:MM:ss");
        }

        private void pnlCenter_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormDashboad_Load(object sender, EventArgs e)
        {
            movePanel(btnHome);
            //Us_home uh = new Us_home();
            UC_home1 uh = new UC_home1();
            AddPanelControl(uh);
            timer1.Start();
        }

        private void btnExpenses_Click(object sender, EventArgs e)
        {
            UC_Expenses ue = new UC_Expenses();
            AddPanelControl(ue);
            lblShow.Text = "Expenses";
            pnlMove.Hide();
        }

        private void btnLoan_Click(object sender, EventArgs e)
        {
            UC_Loan ul = new UC_Loan();
            AddPanelControl(ul);
            lblShow.Text = "Loan Book";
            pnlMove.Hide();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            pnlMove.Show();
            UC_userManage uu = new UC_userManage();
            AddPanelControl(uu);
            lblShow.Text="User Manage";
            movePanel(btnUser);
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            pnlMove.Show();
            backup_and_restore br = new backup_and_restore();
            AddPanelControl(br);
            movePanel(btnBackup);
            lblShow.Text = "Back up";
        }

        private void fullReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UCFullReport uf = new UCFullReport();
            AddPanelControl(uf);
            lblShow.Text = "FullReport";
        }

        private void customerReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UC_cus_Rep ur = new UC_cus_Rep();
            AddPanelControl(ur);
            lblShow.Text = "Customer Report";
        }

        private void spacificReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UC_SpacificRep us = new UC_SpacificRep();
            AddPanelControl(us);
            lblShow.Text = "Specific Report";            
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            Form_login fl = new Form_login();
            fl.Show();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            pnlMove.Show();
            UC_stock us = new UC_stock();
            AddPanelControl(us);
            movePanel(btnStock);
            lblShow.Text = "Items";
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlMove.Hide();
        }

        private void pnlCenter_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
