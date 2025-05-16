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
    public partial class payments : Form
    {
        private Loans _parentLoansForm;

        public payments(Loans parentForm)
        {
            InitializeComponent();
            _parentLoansForm = parentForm;
        }

        public payments()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (_parentLoansForm != null && !_parentLoansForm.IsDisposed)
            {
                loan1 frm = new loan1(_parentLoansForm);
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
