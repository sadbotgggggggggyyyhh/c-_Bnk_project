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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Som_Bank
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        private string loggedInUsername;
        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public Main(string username)
        {
            InitializeComponent();
            loggedInUsername = username; 
        }
        private void Main_Load(object sender, EventArgs e)
        {
            string username;
            username = loggedInUsername;
            this.Bounds = Screen.PrimaryScreen.WorkingArea;
            label2.BackColor = Color.White;
            label8.Text = username;
            /*create_acc.Enabled = false;
            manage_acc.Enabled = false;
            view_acc.Enabled = false;
            transactions.Enabled = false;
            deposit.Enabled = false;
            withdraw.Enabled = false;
            transfers.Enabled = false;
            check_balance.Enabled = false;
            loans.Enabled = false;
            this.Bounds = Screen.PrimaryScreen.WorkingArea;
            label2.BackColor = Color.White;
            string constring = "Data Source=DESKTOP-LIPS9UU\\SQLEXPRESS;Initial Catalog=sombank;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
            try
            {
                string query = @"SELECT create_acc, manage_acc, view_acc, transactions,
                             deposit, withdraw, transfers, check_balance, loans
                             FROM permit WHERE username = @username";

                using (SqlConnection con = new SqlConnection(constring))
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@username", loggedInUsername);
                    con.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Access the buttons through the panel's Controls collection
                            foreach (Control ctrl in panel3.Controls) // Replace permissionsPanel with the actual name of your panel
                            {
                                if (ctrl is Button)
                                {
                                    switch (ctrl.Name)
                                    {
                                        case "create_acc":
                                            ctrl.Enabled = reader["create_acc"].ToString().ToLower() == "y";
                                            MessageBox.Show("yes");
                                            break;
                                        case "manage_acc":
                                            ctrl.Enabled = reader["manage_acc"].ToString().ToLower() == "y";
                                            break;
                                        case "view_acc":
                                            ctrl.Enabled = reader["view_acc"].ToString().ToLower() == "y";
                                            break;
                                        case "transactions":
                                            ctrl.Enabled = reader["transactions"].ToString().ToLower() == "y";
                                            break;
                                        case "deposit":
                                            ctrl.Enabled = reader["deposit"].ToString().ToLower() == "y";
                                            break;
                                        case "withdraw":
                                            ctrl.Enabled = reader["withdraw"].ToString().ToLower() == "y";
                                            break;
                                        case "transfers":
                                            ctrl.Enabled = reader["transfers"].ToString().ToLower() == "y";
                                            break;
                                        case "check_balance":
                                            ctrl.Enabled = reader["check_balance"].ToString().ToLower() == "y";
                                            break;
                                        case "loans":
                                            ctrl.Enabled = reader["loans"].ToString().ToLower() == "y";
                                            break;
                                    }
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show($"No permissions found for user: {loggedInUsername}");
                            DisableAllButtons();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading permissions: {ex.Message}");
                DisableAllButtons();
            }*/

        }

        private void DisableAllButtons()
        {
            /*if (panel3 != null) // Ensure the panel exists
            {
                foreach (Control ctrl in panel3.Controls)
                {
                    if (ctrl is Button)
                    {
                        ctrl.Enabled = false;
                    }
                }
            }*/

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
            Form frm = new Deposite(loggedInUsername);
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
            Form frm = new Withdraw(loggedInUsername);
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
            Form frm = new Transfer(loggedInUsername);
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
