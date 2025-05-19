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
    public partial class Transfer : Form
    {
        public Transfer()
        {
            InitializeComponent();
        }
        private string loggedInUsername;
        public Transfer(string username)
        {
            InitializeComponent();
            loggedInUsername = username;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            string fromAccountNumber = accountXT.Text;
            string toAccountNumber = accountXXT.Text; 
            decimal transferAmount = Convert.ToDecimal(amountXT.Text);
            string employeeName = loggedInUsername;
            string description = descriptionXT.Text;

            
            if (string.IsNullOrWhiteSpace(fromAccountNumber) || string.IsNullOrWhiteSpace(toAccountNumber) || transferAmount <= 0)
            {
                MessageBox.Show("Please enter valid 'From Account', 'To Account', and Transfer Amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

           
            string connectionString = "Data Source=DESKTOP-LIPS9UU\\SQLEXPRESS;Initial Catalog=sombank;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlTransaction transaction = null;

            try
            {
                
                connection.Open();

                
                transaction = connection.BeginTransaction();

                
                SqlCommand transferCommand = new SqlCommand(
                    "INSERT INTO Transactions (AccountNumber, TransactionDate, TransactionType, Amount, EmployeeName, Description, SourceAccountNumber, DestinationAccountNumber) " +
                    "VALUES (@FromAccountNumber, GETDATE(), 'Transfer', @Amount, @EmployeeName, @Description, @FromAccountNumber, @ToAccountNumber)", connection);
                transferCommand.Transaction = transaction;
                transferCommand.Parameters.AddWithValue("@FromAccountNumber", fromAccountNumber);
                transferCommand.Parameters.AddWithValue("@ToAccountNumber", toAccountNumber);
                transferCommand.Parameters.AddWithValue("@Amount", transferAmount);
                transferCommand.Parameters.AddWithValue("@EmployeeName", employeeName);
                transferCommand.Parameters.AddWithValue("@Description", description);

                
                int rowsAffectedTransfer = transferCommand.ExecuteNonQuery();
                if (rowsAffectedTransfer <= 0)
                {
                    throw new Exception("Failed to record the transfer transaction.");
                }

                
                SqlCommand fromBalanceCommand = new SqlCommand(
                    "UPDATE Clients SET Balance = Balance - @Amount WHERE AccountNumber = @AccountNumber", connection);
                fromBalanceCommand.Transaction = transaction;
                fromBalanceCommand.Parameters.AddWithValue("@AccountNumber", fromAccountNumber);
                fromBalanceCommand.Parameters.AddWithValue("@Amount", transferAmount);
                int rowsAffectedFromBalance = fromBalanceCommand.ExecuteNonQuery();
                if (rowsAffectedFromBalance <= 0)
                {
                    throw new Exception("Failed to update the balance of the source account. Account Number not found or balance insufficient.");
                }

                
                SqlCommand toBalanceCommand = new SqlCommand(
                    "UPDATE Clients SET Balance = Balance + @Amount WHERE AccountNumber = @AccountNumber", connection);
                toBalanceCommand.Transaction = transaction;
                toBalanceCommand.Parameters.AddWithValue("@AccountNumber", toAccountNumber);
                toBalanceCommand.Parameters.AddWithValue("@Amount", transferAmount);
                int rowsAffectedToBalance = toBalanceCommand.ExecuteNonQuery();
                if (rowsAffectedToBalance <= 0)
                {
                    throw new Exception("Failed to update the balance of the destination account. Account Number not found.");
                }

                
                transaction.Commit();
                MessageBox.Show("Transfer successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();

            }
            catch (Exception ex)
            {
                
                if (transaction != null)
                {
                    transaction.Rollback();
                }
                MessageBox.Show("Error processing transfer: " + ex.Message, "Transaction Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            accountXXT.Text = "";
            amountXT.Text = "";
            descriptionXT.Text = "";
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
        string connectionString = "Data Source=DESKTOP-LIPS9UU\\SQLEXPRESS;Initial Catalog=sombank;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"; // Replace with your connection string.

        private void fromSach_Click(object sender, EventArgs e)
        {
            string sql = "SELECT FirstName, LastName, Address, PhoneNumber FROM clients WHERE AccountNumber = @AccountNumber";

            try
            {
                string accountNumber = accountXT.Text;
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
                                phoneXT.Text = reader["PhoneNumber"].ToString();

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

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "SELECT FirstName, LastName, Address, PhoneNumber FROM clients WHERE AccountNumber = @AccountNumber";

            try
            {
                string accountNumber = accountXT.Text;
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
                                fullnameXXT.Text = reader["FirstName"].ToString() + " " + reader["LastName"].ToString();
                                phoneXXT.Text = reader["PhoneNumber"].ToString();

                                addressXXT.Text = reader["Address"].ToString();
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
    }
}
