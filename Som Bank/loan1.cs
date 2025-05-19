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
    public partial class loan1 : Form
    {
        private Loans _parentLoansForm;
        public loan1(Loans parentForm)
        {
            InitializeComponent();
            _parentLoansForm = parentForm;
        }
        public loan1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string selectedFile = openFileDialog1.FileName;
                textBoxFilePath2.Text = selectedFile;
                openFileDialog1.OpenFile();


            }
            else
            {
                textBoxFilePath2.Text = "";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (_parentLoansForm != null && !_parentLoansForm.IsDisposed)
            {
                Loans form = new Loans();
                payments frm = new payments(_parentLoansForm);
                frm.TopLevel = false;
                frm.BringToFront();
                frm.Dock = DockStyle.Fill;
                frm.FormBorderStyle = FormBorderStyle.None;
                _parentLoansForm.panel4.Controls.Clear();
                _parentLoansForm.panel4.Controls.Add(frm);
                frm.Show();
            }
            else
            {

                MessageBox.Show("The parent Loans form is no longer accessible.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string selectedFile = openFileDialog1.FileName;
                textBoxFilePath1.Text = selectedFile;
                openFileDialog1.OpenFile();


            }
            else
            {
                textBoxFilePath2.Text = "";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string selectedFile = openFileDialog1.FileName;
                textBoxFilePath3.Text = selectedFile;
                openFileDialog1.OpenFile();


            }
            else
            {
                textBoxFilePath2.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        private string connectionString = "Data Source=DESKTOP-LIPS9UU\\SQLEXPRESS;Initial Catalog=sombank;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        public void SaveLoanData()

        {
            string fullName = nameXT.Text;
            string accountNo = accNoXT.Text;
            string phoneNo = pNnoXT.Text;
            string nationalID = IDXT.Text;
            string bankStatementPath = textBoxFilePath2.Text;
            decimal amount = decimal.Parse(amountXT.Text);
            string purpose = puposeXT.Text;
            int durationInMonths = int.Parse(durationXT.Text);
            string cosignerFullName = nameXXT.Text;
            string cosignerAccountNo = accXXt.Text;
            string cosignerPhoneNo = pNoXXT.Text;
            string cosignerNationalID = IDXXT.Text;
            string cosignerBankStatementPath = textBoxFilePath1.Text;
            string cosignerAgreementProofPath = textBoxFilePath3.Text;
            decimal monthlyInstallment = amount / durationInMonths;
            DateTime startDate = DateTime.Now;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = @"INSERT INTO Loans (FullName, AccountNo, PhoneNo, NationalID, BankStatement, Amount, Purpose, DurationInMonths, MonthlyInstallment, StartDate, Date, InstallmentStatus,
                                                 CosignerFullName, CosignerAccountNo, CosignerPhoneNo, CosignerNationalID, CosignerBankStatement, CosignerAgreementProof) 
                           VALUES (@FullName, @AccountNo, @PhoneNo, @NationalID, @BankStatement, @Amount, @Purpose, @DurationInMonths, @MonthlyInstallment, @StartDate, @Date, @InstallmentStatus,
                                   @CosignerFullName, @CosignerAccountNo, @CosignerPhoneNo, @CosignerNationalID, @CosignerBankStatement, @CosignerAgreementProof)";
                SqlTransaction transaction = connection.BeginTransaction(); 

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@FullName", fullName);
                    command.Parameters.AddWithValue("@AccountNo", accountNo);
                    command.Parameters.AddWithValue("@PhoneNo", phoneNo);
                    command.Parameters.AddWithValue("@NationalID", nationalID);
                    command.Parameters.AddWithValue("@BankStatement", bankStatementPath);
                    command.Parameters.AddWithValue("@Amount", amount);
                    command.Parameters.AddWithValue("@Purpose", purpose);
                    command.Parameters.AddWithValue("@DurationInMonths", durationInMonths);
                    command.Parameters.AddWithValue("@MonthlyInstallment", monthlyInstallment);
                    command.Parameters.AddWithValue("@StartDate", startDate);
                    command.Parameters.AddWithValue("@Date", startDate);
                    command.Parameters.AddWithValue("@InstallmentStatus", amount > 0 ? "Not Paid ❌" : "Paid ✅");
                    command.Parameters.AddWithValue("@CosignerFullName", cosignerFullName);
                    command.Parameters.AddWithValue("@CosignerAccountNo", cosignerAccountNo);
                    command.Parameters.AddWithValue("@CosignerPhoneNo", cosignerPhoneNo);
                    command.Parameters.AddWithValue("@CosignerNationalID", cosignerNationalID);
                    command.Parameters.AddWithValue("@CosignerBankStatement", cosignerBankStatementPath);
                    command.Parameters.AddWithValue("@CosignerAgreementProof", cosignerAgreementProofPath);
                    command.ExecuteNonQuery();
                }
                string updateBalanceQuery = "UPDATE Accounts SET Balance = Balance + @Amount WHERE AccountNo = @AccountNo";
                using (SqlCommand updateCommand = new SqlCommand(updateBalanceQuery, connection, transaction)) // Pass the transaction
                {
                    updateCommand.Parameters.AddWithValue("@Amount", amount);
                    updateCommand.Parameters.AddWithValue("@AccountNo", accountNo);
                    updateCommand.ExecuteNonQuery();
                }

                transaction.Commit();
            }
            MessageBox.Show("Loan data saved successfully.");
        }

        private void p_noXT_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
