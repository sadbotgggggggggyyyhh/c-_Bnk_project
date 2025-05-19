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
    public partial class Withdraw : Form
    {
        public Withdraw()
        {
            InitializeComponent();
        }

        private void Sach_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-LIPS9UU\\SQLEXPRESS;Initial Catalog=sombank;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"; // Replace with your connection string.
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
        public Withdraw(string username)
        {
            InitializeComponent();
            loggedInUsername = username;
        }
        private void withdrawBTN_Click(object sender, EventArgs e)
        {
            string accountNumber = accountXT.Text;
            decimal withdrawalAmount = Convert.ToDecimal(AmountXT.Text);  
            string employeeName = loggedInUsername;
            string description = descriptionXT.Text;

            if (string.IsNullOrWhiteSpace(accountNumber) || withdrawalAmount <= 0)
            {
                MessageBox.Show("Please enter a valid Account Number and Withdrawal Amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string connectionString = "Data Source=DESKTOP-LIPS9UU\\SQLEXPRESS;Initial Catalog=sombank;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";  
            SqlConnection connection = new SqlConnection(connectionString);
            SqlTransaction transaction = null;

            try
            {
                connection.Open();

                transaction = connection.BeginTransaction();

                SqlCommand withdrawCommand = new SqlCommand(
                    "INSERT INTO Transactions (AccountNumber, TransactionDate, TransactionType, Amount, EmployeeName, Description) " +
                    "VALUES (@AccountNumber, GETDATE(), 'Withdrawal', @Amount, @EmployeeName, @Description)", connection);
                withdrawCommand.Transaction = transaction; 
                withdrawCommand.Parameters.AddWithValue("@AccountNumber", accountNumber);
                withdrawCommand.Parameters.AddWithValue("@Amount", withdrawalAmount);
                withdrawCommand.Parameters.AddWithValue("@EmployeeName", employeeName);
                withdrawCommand.Parameters.AddWithValue("@Description", description);

                int rowsAffectedWithdrawal = withdrawCommand.ExecuteNonQuery();

                if (rowsAffectedWithdrawal <= 0)
                {
                    throw new Exception("Failed to record the withdrawal transaction.");
                }

                SqlCommand balanceCommand = new SqlCommand(
                    "UPDATE Clients SET Balance = Balance - @Amount WHERE AccountNumber = @AccountNumber", connection);
                balanceCommand.Transaction = transaction; 
                balanceCommand.Parameters.AddWithValue("@AccountNumber", accountNumber);
                balanceCommand.Parameters.AddWithValue("@Amount", withdrawalAmount);

                int rowsAffectedBalance = balanceCommand.ExecuteNonQuery();

                if (rowsAffectedBalance <= 0)
                {
                    throw new Exception("Failed to update the account balance.  Account Number not found or balance insufficient.");
                }

                transaction.Commit();
                MessageBox.Show("Withdrawal successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearWithdrawForm(); 

            }
            catch (Exception ex)
            {
                if (transaction != null)
                {
                    transaction.Rollback();
                }
                MessageBox.Show("Error processing withdrawal: " + ex.Message, "Transaction Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }
        private void ClearWithdrawForm()
        {
            accountXT.Text = "";
            AmountXT.Text = "";
            descriptionXT.Text = "";
        }
    }
}
