using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Som_Bank
{
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 10;
            if (panel2.Width >= 50 && panel2.Width<=99)
            {
                label1.Text = "Loading.";
            }
            else if (panel2.Width >= 100 && panel2.Width <= 199)
            {
                label1.Text = "Loading..";
            }
            else if (panel2.Width >= 200 && panel2.Width <= 299)
            {
                label1.Text = "Loading...";
            }
            else if (panel2.Width >= 300 && panel2.Width <= 399)
            {
                label1.Text = "Loading.";
            }
            else if (panel2.Width >= 400 && panel2.Width <= 499)
            {
                label1.Text = "Loading..";
            }
            else if (panel2.Width >= 500 && panel2.Width <= 599)
            {
                label1.Text = "Loading...";
            }
            else if (panel2.Width >=670)
            {
                timer1.Stop();
                Form frm = new Main();
                frm.Show();
                

            }
             
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Loading_Load(object sender, EventArgs e)
        {

        }
    }
}
