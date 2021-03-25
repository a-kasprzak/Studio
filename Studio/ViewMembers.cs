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
    public partial class ViewMembers : Form
    {
        public ViewMembers()
        {
            InitializeComponent();
            
        }

        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\meshu\source\repos\Studio\Studio\StudioDb.mdf;Integrated Security=True");

        private void SelectAllUsers()
        {
            if (conn.State == ConnectionState.Open) conn.Open();

            try
            {
                conn.Close();
                string query = "Select * from UserTbl";

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, conn);
                SqlCommandBuilder builder = new SqlCommandBuilder();

                var dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                Userlist.DataSource = dataSet.Tables[0];


            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }
        }


        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Userlist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ViewMembers_Load(object sender, EventArgs e)
        {
            SelectAllUsers();
        }
    }
}
