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

namespace Som_Bank
{
    public partial class users : Form
    {
        public users()
        {
            InitializeComponent();
        }

        private string gender;
        private void createBTN_Click(object sender, EventArgs e)
        {
            string fullname = fullnameXT.Text;
            string role = role1XT.Text;
            string username = userXT.Text;
            string password = passXT.Text;
            string phone = phoneXT.Text;
            string salary = salaryXT.Text;

            if (string.IsNullOrEmpty(fullname) || string.IsNullOrEmpty(role) || string.IsNullOrEmpty(username)
                || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(salary)
                || (!maleXT.Checked && !femaleXT.Checked)
                )
            {
                MessageBox.Show("All fields are required");
            }
            else
            {
                try
                {
                    string constring = "Data Source=DESKTOP-LIPS9UU\\SQLEXPRESS;Initial Catalog=sombank;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
                    using (SqlConnection con = new SqlConnection(constring))
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("INSERT INTO login (Fullname,Role,Username,Password,Gender,Phone,salary)" +
                                                        " VALUES(@fullname,@role,@username,@password,@gender,@phone,@salary)", con);
                        cmd.Parameters.AddWithValue("@fullname", fullname);
                        cmd.Parameters.AddWithValue("@role", role);
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        if (maleXT.Checked)
                        {
                            cmd.Parameters.AddWithValue("@gender", "Male");
                        }
                        else if (femaleXT.Checked)
                        {
                            cmd.Parameters.AddWithValue("@gender", "Female");
                        }
                        cmd.Parameters.AddWithValue("@phone", phone);
                        cmd.Parameters.AddWithValue("@salary", salary);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show($"Added New User {fullname}");
                    } 
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void maleXT_CheckedChanged(object sender, EventArgs e)
        {
            if (maleXT.Checked)
            {                
                gender = "Male";
                femaleXT.Checked = false;
            }
        }

        private void femaleXT_CheckedChanged(object sender, EventArgs e)
        {
            if (femaleXT.Checked)
            {
                gender = "Female";
                maleXT.Checked = false;
            }
        }

        private void phoneXT_TextChanged(object sender, EventArgs e)
        {

        }

        private void users_Load(object sender, EventArgs e)
        {
            string constring = "Data Source=DESKTOP-LIPS9UU\\SQLEXPRESS;Initial Catalog=sombank;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM login", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Table.DataSource = dt;
        }
    }
    }

