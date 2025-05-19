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
    public partial class new_acc : Form
    {
        public new_acc()
        {
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void createBTN_Click(object sender, EventArgs e)
        {

        }

        private void new_acc_Load(object sender, EventArgs e)
        {

        }
      

        private void ClearForm()
        {
            
            firstnameXT.Text = "";
            lastnameXT.Text = "";
            acc_numXT.Text = "";
            maleXT.Checked = false;
            femaleXT.Checked = false;
            DateXT.Value = DateTime.Now;
            nationXT.Text = "";
            inDepositeXT.Text = "";
            typeXT.Text = "";
            addrXT.Text = "";
            numXT.Text = "";
            emailXT.Text = "";
            CnameXT.Text = "";
            jopXT.Text = "";
            cityXT.Text = "";
        }
        private void createBTN_Click_1(object sender, EventArgs e)
        {
            string firstName = firstnameXT.Text;
            string lastName = lastnameXT.Text;
            string accountNumber = acc_numXT.Text;
            string gender = (maleXT.Checked) ? "Male" : "Female";
            DateTime? dateOfBirth = DateXT.Value;
            string nationality = nationXT.Text;
            decimal initialDeposit = Convert.ToDecimal(inDepositeXT.Text);
            string accountType = typeXT.Text;
            string address = addrXT.Text;
            string phoneNumber = numXT.Text;
            string email =emailXT.Text;
            string companyName = CnameXT.Text;
            string occupation = jopXT.Text;
            string city = cityXT.Text;
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) ||
                string.IsNullOrEmpty(accountNumber) || string.IsNullOrEmpty(gender) ||
                string.IsNullOrEmpty(nationality) ||
                string.IsNullOrWhiteSpace(accountType) || string.IsNullOrEmpty(address) ||
                string.IsNullOrEmpty(phoneNumber) || string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(companyName) || string.IsNullOrEmpty(occupation) 
                || string.IsNullOrEmpty(city))
            {
                MessageBox.Show("Please fill in all required fields ");
                return;
                
            }

            string sql = "INSERT INTO clients (FirstName, LastName, AccountNumber," +
                " Gender, DateOfBirth, Nationality, InitialDeposit, AccountType," +
                " Address, PhoneNumber, Email, CompanyName, Occupation, City, Balance) " +
                         "VALUES (@FirstName, @LastName, @AccountNumber, @Gender," +
                         " @DateOfBirth, @Nationality, @InitialDeposit, @AccountType," +
                         " @Address, @PhoneNumber, @Email, @CompanyName, @Occupation, @City, @Balance)";

            string connectionString = "Data Source=DESKTOP-LIPS9UU\\SQLEXPRESS;Initial Catalog=sombank;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@FirstName", firstName);
                        command.Parameters.AddWithValue("@LastName", lastName);
                        command.Parameters.AddWithValue("@AccountNumber", accountNumber);
                        command.Parameters.AddWithValue("@Gender", gender);
                        if (dateOfBirth.HasValue)
                        {
                            command.Parameters.AddWithValue("@DateOfBirth", dateOfBirth.Value);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@DateOfBirth", DBNull.Value);
                        }

                        command.Parameters.AddWithValue("@Nationality", nationality);
                        command.Parameters.AddWithValue("@InitialDeposit", initialDeposit);
                        command.Parameters.AddWithValue("@AccountType", accountType);
                        command.Parameters.AddWithValue("@Address", address);
                        command.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@CompanyName", companyName);
                        command.Parameters.AddWithValue("@Occupation", occupation);
                        command.Parameters.AddWithValue("@City", city);
                        command.Parameters.AddWithValue("@Balance", initialDeposit);


                        int rowsAffected = command.ExecuteNonQuery(); 
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Account created successfully!", "Success",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            
                            ClearForm();
                        }
                        else
                        {
                            MessageBox.Show("Failed to create account.", "Error", 
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error creating account: " + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
