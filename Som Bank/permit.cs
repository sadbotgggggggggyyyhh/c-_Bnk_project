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
    public partial class permit : Form
    {
        public permit()
        {
            InitializeComponent();
        }

        private void permit_Load(object sender, EventArgs e)
        {
            string constring = "Data Source=DESKTOP-LIPS9UU\\SQLEXPRESS;Initial Catalog=sombank;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM login", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Table.DataSource = dt;
        }
    }
}
