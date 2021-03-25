using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Studio
{
    public partial class Payments : Form
    {
        public Payments()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\meshu\source\repos\Studio\Studio\StudioDb.mdf;Integrated Security=True");

        private void FillUsers()
        {
            conn.Open();
            string query = $"SELECT Name FROM UserTbl";
            SqlCommand sqlCommand = new SqlCommand(query, conn);
            SqlDataReader reader;
            reader = sqlCommand.ExecuteReader();
            DataTable table = new DataTable();
            table.Columns.Add("Name", typeof(string));
            table.Load(reader);
            UserCb.ValueMember = "Name";
            UserCb.DataSource = table;
            sqlCommand.ExecuteNonQuery();
            conn.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        // back button 
        private void guna2Button3_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void Payments_Load(object sender, EventArgs e)
        {
            FillUsers();
        }

        private void UserCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // pay button 
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (UserCb.Text == "" && AmountTb.Text == "")
                {
                    MessageBox.Show("Uzupełnij informacje.");
                }
                else
                {
                    conn.Open();
                    string Data1 = MonthCb.Value.ToString();
                    string query = $"INSERT into PaymentsTbl Values ('{UserCb.Text}',{AmountTb.Text},'{Data1}');";
                    SqlCommand sqlCommand = new SqlCommand(query, conn);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show($"Płatność została wykonana.");
                    conn.Close();
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }
    }
}
