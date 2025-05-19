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
    public partial class View_acc : Form
    {
        public View_acc()
        {
            InitializeComponent();
        }
        private void LoadClientsData()
        {
            string connectionString = "Data Source=DESKTOP-LIPS9UU\\SQLEXPRESS;Initial Catalog=sombank;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
            string sql = "SELECT AccountNumber, FirstName, LastName, Gender, " +
                "DateOfBirth, Nationality, InitialDeposit, AccountType, Address, " +
                "PhoneNumber, Email, CompanyName, Occupation, City FROM clients ORDER BY CreationDate DESC";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);
                        Table.DataSource = dataTable;
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error loading client data: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        private void View_acc_Load(object sender, EventArgs e)
        {
            LoadClientsData();
        }
    }
}
