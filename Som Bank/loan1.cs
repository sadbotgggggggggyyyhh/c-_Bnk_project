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
    public partial class loan1 : Form
    {
        private Loans _parentLoansForm;
        public loan1(Loans parentForm)
        {
            InitializeComponent();
            _parentLoansForm = parentForm;
        }
        public loan1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string selectedFile = openFileDialog1.FileName;
                textBoxFilePath2.Text = selectedFile;
                openFileDialog1.OpenFile();


            }
            else
            {
                textBoxFilePath2.Text = "";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (_parentLoansForm != null && !_parentLoansForm.IsDisposed)
            {
                Loans form= new Loans();
                payments frm = new payments(_parentLoansForm); 
                frm.TopLevel = false;
                frm.BringToFront();
                frm.Dock = DockStyle.Fill;
                frm.FormBorderStyle = FormBorderStyle.None;
                _parentLoansForm.panel4.Controls.Clear(); 
                _parentLoansForm.panel4.Controls.Add(frm); 
                frm.Show();
            }
            else
            {
                
                MessageBox.Show("The parent Loans form is no longer accessible.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
