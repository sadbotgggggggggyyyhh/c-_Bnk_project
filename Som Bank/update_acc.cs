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
    public partial class Manage : Form
    {
        public Manage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void updateBTN_Click(object sender, EventArgs e)
        {

        }

        private void Manage_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string accountNumber = acc_numXT.Text;
            if (!string.IsNullOrEmpty(accountNumber))
            {
                PopulateData(accountNumber);
            }
        }
        private void PopulateData(string accountNumber)
        {
            string connectionString = "Data Source=DESKTOP-LIPS9UU\\SQLEXPRESS;Initial Catalog=sombank;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"; // Replace with your connection string.
            string sql = "SELECT FirstName, LastName, Gender, DateOfBirth, Nationality, InitialDeposit, AccountType, Address, PhoneNumber, Email, CompanyName, Occupation, City FROM clients WHERE AccountNumber = @AccountNumber";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@AccountNumber", accountNumber);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                firstnameXT.Text = reader["FirstName"].ToString();
                                lastnameXT.Text = reader["LastName"].ToString();
                                maleXT.Checked = reader["Gender"].ToString() == "Male";
                                femaleXT.Checked = reader["Gender"].ToString() == "Female";
                                if (reader["DateOfBirth"] != DBNull.Value)
                                {
                                    DateXT.Value = (DateTime)reader["DateOfBirth"];
                                }
                                nationXT.Text = reader["Nationality"].ToString();
                                inDepositeXT.Text = reader["InitialDeposit"].ToString();
                                typeXT.Text = reader["AccountType"].ToString();
                                addrXT.Text = reader["Address"].ToString();
                                numXT.Text = reader["PhoneNumber"].ToString();
                                emailXT.Text = reader["Email"].ToString();
                                CnameXT.Text = reader["CompanyName"].ToString();
                                jopXT.Text = reader["Occupation"].ToString();
                                cityXT.Text = reader["City"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("Account Number not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                ClearForm(); 
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error retrieving data: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void updateBTN_Click_1(object sender, EventArgs e)
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
            string email = emailXT.Text;
            string companyName = CnameXT.Text;
            string occupation = jopXT.Text;
            string city = cityXT.Text;

            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName) ||
               string.IsNullOrWhiteSpace(accountNumber) || string.IsNullOrWhiteSpace(gender) ||
               string.IsNullOrWhiteSpace(initialDeposit.ToString()) || string.IsNullOrWhiteSpace(nationality) ||
               string.IsNullOrWhiteSpace(accountType) || string.IsNullOrWhiteSpace(address) ||
               string.IsNullOrWhiteSpace(phoneNumber) || string.IsNullOrWhiteSpace(email) ||
               string.IsNullOrWhiteSpace(companyName) || string.IsNullOrWhiteSpace(occupation) || string.IsNullOrWhiteSpace(city))
            {
                MessageBox.Show("Please fill in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }

           
            string sql = "UPDATE clients SET FirstName = @FirstName, LastName = @LastName, Gender = @Gender, DateOfBirth = @DateOfBirth, Nationality = @Nationality, " +
                         "InitialDeposit = @InitialDeposit, AccountType = @AccountType, Address = @Address, PhoneNumber = @PhoneNumber, Email = @Email, CompanyName = @CompanyName, Occupation = @Occupation, City = @City " +
                         "WHERE AccountNumber = @AccountNumber";

            
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

                        int rowsAffected = command.ExecuteNonQuery(); 
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Account updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearForm();
                        }
                        else
                        {
                            MessageBox.Show("Failed to update account.  Account Number not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error updating account: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteBTN_Click(object sender, EventArgs e)
        {
            string accountNumber = acc_numXT.Text;

            if (string.IsNullOrWhiteSpace(accountNumber))
            {
                MessageBox.Show("Please enter the Account Number to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }

            string sql = "DELETE FROM clients WHERE AccountNumber = @AccountNumber";

            string connectionString = "Data Source=DESKTOP-LIPS9UU\\SQLEXPRESS;Initial Catalog=sombank;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";  
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        
                        command.Parameters.AddWithValue("@AccountNumber", accountNumber);

                        int rowsAffected = command.ExecuteNonQuery(); 
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Account deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearForm();
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete account. Account Number not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                
                MessageBox.Show("Error deleting account: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
