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
    public partial class Loans : Form
    {
        public Loans()
        {
            InitializeComponent();
        }

        private void lastnameXT_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxFilePath2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

       

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void Loans_Load(object sender, EventArgs e)
        {
            string constring = "Data Source=DESKTOP-LIPS9UU\\SQLEXPRESS;Initial Catalog=sombank;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Loans", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Table.DataSource = dt;
        }
    }
}
