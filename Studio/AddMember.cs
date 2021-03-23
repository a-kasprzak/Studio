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
    public partial class AddMember : Form
    {
        public AddMember()
        {
            InitializeComponent();
        }


        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\meshu\source\repos\Studio\Studio\StudioDb.mdf;Integrated Security=True");

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            
            if (NameTb.Text == "" || PhoneTb.Text == "" || AmountTb.Text == "" || AgeTb.Text == "" || GenderTb.Text == "" || TimingTb.Text == "")
            {
                MessageBox.Show("Uzupełnij brakujące dane.");
            }
            else
            {
                
                try
                {
                    conn.Open();
                    string query = $"Insert into UserTbl values ('{NameTb.Text}','{PhoneTb.Text}','{GenderTb.Text}',{AgeTb.Text},{AmountTb.Text},'{TimingTb.Text}')";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Użytkownik został pomyślnie dodany.");

                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            NameTb.Text = "";
            PhoneTb.Text = "";
            AmountTb.Text = "";
            AgeTb.Text = "";
            GenderTb.Items.Clear();
            TimingTb.Items.Clear();


            
         }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }
    }
}

