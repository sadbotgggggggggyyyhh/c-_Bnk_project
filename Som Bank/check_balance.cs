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
    public partial class check_balance : Form
    {
        public check_balance()
        {
            InitializeComponent();
        }

        private void checkBTN_Click(object sender, EventArgs e)
        {
            string accountNumber = accountXT.Text; 
            string connectionString = "Data Source=DESKTOP-LIPS9UU\\SQLEXPRESS;Initial Catalog=sombank;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";  //  <-----------------------  IMPORTANT:  Replace this!
            SqlConnection connection = new SqlConnection(connectionString);
            SqlTransaction transaction = null;
            try
            {
                connection.Open();
                transaction = connection.BeginTransaction();
                SqlCommand balanceCommand = new SqlCommand(
                    "SELECT FirstName, LastName, Balance FROM Clients WHERE AccountNumber = @AccountNumber", connection);
                balanceCommand.Transaction = transaction;
                balanceCommand.Parameters.AddWithValue("@AccountNumber", accountNumber);

                SqlDataReader reader = balanceCommand.ExecuteReader();


                if (reader.HasRows)
                {
                    reader.Read();
                    string firstName = reader["FirstName"].ToString();
                    string lastName = reader["LastName"].ToString();
                    decimal balance = Convert.ToDecimal(reader["Balance"]);
                    firstnameXT.Text = firstName;
                    lastnameXT.Text = lastName;
                    balanceXT.Text = balance.ToString();
                    accountXT.Text = accountNumber;
                }
                else
                {
                    MessageBox.Show("Account Number not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                reader.Close();
                transaction.Commit(); 
            }
            catch (Exception ex)
            {
                if (transaction != null)
                {
                    transaction.Rollback();
                }
                MessageBox.Show("Error processing request: " + ex.Message, "Transaction Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                firstnameXT.Text = "Error";
                lastnameXT.Text = "Error";
                balanceXT.Text = "Error";
                accountXT.Text = "Error";
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }
    }
}
