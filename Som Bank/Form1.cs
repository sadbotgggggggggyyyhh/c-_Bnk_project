using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Som_Bank
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                pass.UseSystemPasswordChar = false;
            }
            else
            {
                pass.UseSystemPasswordChar = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string constring = "Data Source=DESKTOP-LIPS9UU\\SQLEXPRESS;Initial Catalog=sombank;Integrated Security=True;TrustServerCertificate=True";
            string username = user.Text;
            string password = pass.Text;
            string role = this.role1.Text;
            if (string.IsNullOrEmpty(role) || string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("All fields are required");
            }
            else if (role1.Text == role)
            {

                string query = "SELECT COUNT(*) FROM login WHERE username = @username AND password = @password AND role=@Role ";
                SqlConnection con = new SqlConnection(constring);
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@Role", role);
                int count = (int)cmd.ExecuteScalar();
                if (count > 0)
                {
                    if (role =="Manager")
                    {
                        admin frm = new admin();
                        frm.Show();
                        users frms = new users();
                        frms.TopLevel = false;
                        frms.BringToFront();
                        frms.Dock = DockStyle.Fill;
                        frms.FormBorderStyle = FormBorderStyle.None;
                        frm.panel4.Controls.Add(frms);
                        frms.Show();
                    }
                    else if (role == "Employee")
                    {
                        Main frmM = new Main(username);
                        frmM.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Incorrect username or password");
                
                }


            }

            }


        }
    }

