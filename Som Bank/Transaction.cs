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
    public partial class Transaction : Form
    {
        public Transaction()
        {
            InitializeComponent();
        }

        private void Table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void rpt_Click(object sender, EventArgs e)
        {
            DisplayTransactions();
        }
        private void DisplayTransactions()
        {
            string connectionString = "Data Source=DESKTOP-LIPS9UU\\SQLEXPRESS;Initial Catalog=sombank;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
            SqlConnection connection = new SqlConnection(connectionString);

            try
            {
                // 2. Open the connection.
                connection.Open();

                // 3. Build the SQL query.
                string query = "SELECT * FROM Transactions WHERE 1=1";

                // 4. Add filters based on user input.
                string selectedType = (typeComboBox.SelectedIndex > -1) ? typeComboBox.SelectedItem.ToString() : null;
                string searchAccountNumber = searchAccount.Text;


                // 5.  Dynamically add filters to the query.
                if (!string.IsNullOrEmpty(selectedType))
                {
                    query += " AND TransactionType = @TransactionType";
                }
                if (!string.IsNullOrEmpty(searchAccountNumber))
                {
                    query += " AND AccountNumber = @AccountNumber";
                }



                // 6.  Create the SqlCommand.
                SqlCommand command = new SqlCommand(query, connection);

                // 7.  Add parameters to the SqlCommand.  This is CRUCIAL for security and preventing SQL injection.
                if (!string.IsNullOrEmpty(selectedType))
                {
                    command.Parameters.AddWithValue("@TransactionType", selectedType);
                }
                if (!string.IsNullOrEmpty(searchAccountNumber))
                {
                    command.Parameters.AddWithValue("@AccountNumber", searchAccountNumber);
                }



                // 8.  Create a SqlDataAdapter to fetch the data.
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                // 9.  Create a DataTable to hold the data.
                System.Data.DataTable dataTable = new System.Data.DataTable();
                dataTable.Locale = System.Globalization.CultureInfo.InvariantCulture;

                // 10. Fill the DataTable with the results from the query.
                adapter.Fill(dataTable);

                // 11. Bind the DataTable to the DataGridView.  ***REPLACE dataGridView1 WITH YOUR ACTUAL DATAGRIDVIEW NAME.***
                Table.DataSource = dataTable;

            }
            catch (Exception ex)
            {
                // 12. Handle any errors.
                MessageBox.Show("Error retrieving transactions: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // 13. Close the connection.  Ensure the connection is closed, even if there's an error.
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }
    }
}
