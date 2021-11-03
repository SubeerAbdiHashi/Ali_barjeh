using Ali_barjeh.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ali_barjeh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel1.Width += 3;
            if (panel1.Width >= 539)
            {
                timer1.Stop();
                Form_login fl = new Form_login();
                fl.Show();
                this.Refresh();
                this.Hide();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
