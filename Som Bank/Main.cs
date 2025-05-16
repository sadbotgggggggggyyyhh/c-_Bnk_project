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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            this.Bounds = Screen.PrimaryScreen.WorkingArea;
            label2.BackColor=Color.White;
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frm = new new_acc();
            frm.TopLevel = false;
            frm.BringToFront();
            frm.Dock = DockStyle.Fill;
            frm.FormBorderStyle= FormBorderStyle.None;
            panel4.Controls.Clear();
            panel4.Controls.Add(frm);
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form frm = new Manage();
            frm.TopLevel = false;
            frm.BringToFront();
            frm.Dock = DockStyle.Fill;
            frm.FormBorderStyle = FormBorderStyle.None;
            panel4.Controls.Clear();
            panel4.Controls.Add(frm);
            frm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form frm = new View_acc();
            frm.TopLevel = false;
            frm.BringToFront();
            frm.Dock = DockStyle.Fill;
            frm.FormBorderStyle = FormBorderStyle.None;
            panel4.Controls.Clear();
            panel4.Controls.Add(frm);
            frm.Show();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form frm = new Transaction();
            frm.TopLevel = false;
            frm.BringToFront();
            frm.Dock = DockStyle.Fill;
            frm.FormBorderStyle = FormBorderStyle.None;
            panel4.Controls.Clear();
            panel4.Controls.Add(frm);
            frm.Show();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            panel3.BackColor= Color.LightGray;
            panel4.BackColor = Color.LightGray;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form frm = new Deposite();
            frm.TopLevel = false;
            frm.BringToFront();
            frm.Dock = DockStyle.Fill;
            frm.FormBorderStyle = FormBorderStyle.None;
            panel4.Controls.Clear();
            panel4.Controls.Add(frm);
            frm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form frm = new Withdraw();
            frm.TopLevel = false;
            frm.BringToFront();
            frm.Dock = DockStyle.Fill;
            frm.FormBorderStyle = FormBorderStyle.None;
            panel4.Controls.Clear();
            panel4.Controls.Add(frm);
            frm.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form frm = new Transfer();
            frm.TopLevel = false;
            frm.BringToFront();
            frm.Dock = DockStyle.Fill;
            frm.FormBorderStyle = FormBorderStyle.None;
            panel4.Controls.Clear();
            panel4.Controls.Add(frm);
            frm.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form frm = new check_balance();
            frm.TopLevel = false;
            frm.BringToFront();
            frm.Dock = DockStyle.Fill;
            frm.FormBorderStyle = FormBorderStyle.None;
            panel4.Controls.Clear();
            panel4.Controls.Add(frm);
            frm.Show();
        }

        private void time_Tick(object sender, EventArgs e)
        {
            hr.Text = DateTime.Now.ToString("HH");
            min.Text = DateTime.Now.ToString("mm");
            sec.Text= DateTime.Now.ToString("ss");
            label4.Text = DateTime.Now.ToString("dddd-dd-MMMM-yyyy");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Loans frm = new Loans();
            frm.TopLevel = false;
            frm.BringToFront();
            frm.Dock = DockStyle.Fill;
            frm.FormBorderStyle = FormBorderStyle.None;
            panel4.Controls.Clear();
            panel4.Controls.Add(frm);
            frm.Show();

            loan1 frm1 = new loan1(frm);
            frm1.TopLevel = false;
            frm1.BringToFront();
            frm1.Dock = DockStyle.Fill;
            frm1.FormBorderStyle = FormBorderStyle.None;
            frm.panel4.Controls.Clear();
            frm.panel4.Controls.Add(frm1);
            frm1.Show();
        }
    }
}
