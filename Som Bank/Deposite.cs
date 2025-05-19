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
using static System.Net.Mime.MediaTypeNames;

namespace Som_Bank
{
    public partial class Deposite : Form
    {
        public Deposite()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Sach_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-LIPS9UU\\SQLEXPRESS;Initial Catalog=sombank;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"; // Replace with your connection string.
            string sql = "SELECT FirstName, LastName, Address, PhoneNumber FROM clients WHERE AccountNumber = @AccountNumber";

            try
            {
                string accountNumber= accountXT.Text;
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
                                fullnameXT.Text = reader["FirstName"].ToString() + " " + reader["LastName"].ToString();
                                PhoneXT.Text = reader["PhoneNumber"].ToString();

                                addressXT.Text = reader["Address"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("Account Number not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error retrieving data: " + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, 
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private string loggedInUsername;
        public Deposite(string username)
        {
            InitializeComponent();
            loggedInUsername = username;
        }
        private void withdrawBTN_Click(object sender, EventArgs e)
        {
            string accountNumber = accountXT.Text; 
            decimal depositAmount = Convert.ToDecimal(AmountXT.Text);  
            string employeeName = loggedInUsername;
            string description = descriptionXT.Text;

         
            if (string.IsNullOrWhiteSpace(accountNumber) || depositAmount <= 0)
            {
                MessageBox.Show("Please enter a valid Account Number and Deposit Amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            string connectionString = "Data Source=DESKTOP-LIPS9UU\\SQLEXPRESS;Initial Catalog=sombank;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";  //  <-----------------------  IMPORTANT:  Replace this!
            SqlConnection connection = new SqlConnection(connectionString);
            SqlTransaction transaction = null;

            try
            {
                
                connection.Open();

                transaction = connection.BeginTransaction();

                SqlCommand depositCommand = new SqlCommand(
                    "INSERT INTO Transactions (AccountNumber, TransactionDate, TransactionType, Amount, EmployeeName, Description) " +
                    "VALUES (@AccountNumber, GETDATE(), 'Deposit', @Amount, @EmployeeName, @Description)", connection);
                depositCommand.Transaction = transaction; 

                depositCommand.Parameters.AddWithValue("@AccountNumber", accountNumber);
                depositCommand.Parameters.AddWithValue("@Amount", depositAmount);
                depositCommand.Parameters.AddWithValue("@EmployeeName", employeeName);
                depositCommand.Parameters.AddWithValue("@Description", description);

                int rowsAffectedDeposit = depositCommand.ExecuteNonQuery();

                if (rowsAffectedDeposit <= 0)
                {
                    throw new Exception("Failed to record the deposit transaction.");
                }

                SqlCommand balanceCommand = new SqlCommand(
                    "UPDATE Clients SET Balance = Balance + @Amount WHERE AccountNumber = @AccountNumber", connection);
                balanceCommand.Transaction = transaction; // Attach the transaction.
                balanceCommand.Parameters.AddWithValue("@AccountNumber", accountNumber);
                balanceCommand.Parameters.AddWithValue("@Amount", depositAmount);

                int rowsAffectedBalance = balanceCommand.ExecuteNonQuery();

                if (rowsAffectedBalance <= 0)
                {
                    throw new Exception("Failed to update the account balance.  Account Number not found.");
                }

                
                transaction.Commit();
                MessageBox.Show("Deposit successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm(); 

            }
            catch (Exception ex)
            {
                if (transaction != null)
                {
                    transaction.Rollback();
                }
                MessageBox.Show("Error processing deposit: " + ex.Message, "Transaction Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }
        private void ClearForm()
        {
            accountXT.Text = "";
            AmountXT.Text = "";
            descriptionXT.Text = "";
        }
    }
}
