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
    public partial class UpdateDelete : Form
    {
        public UpdateDelete()
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
        

        // xD
        private void label8_Click(object sender, EventArgs e)
        {
            

        }

        // Back button
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        int key = 0;
        // USerList
        private void Userlist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            key = int.Parse(Userlist.SelectedRows[0].Cells[0].Value.ToString());
            NameTb.Text = Userlist.SelectedRows[0].Cells[1].Value.ToString();
            PhoneTb.Text = Userlist.SelectedRows[0].Cells[2].Value.ToString();
            GenderCb.Text = Userlist.SelectedRows[0].Cells[3].ToString();
            AgeTb.Text = Userlist.SelectedRows[0].Cells[4].Value.ToString();
            AmountTb.Text = Userlist.SelectedRows[0].Cells[5].Value.ToString();
            TimingCb.Text = Userlist.SelectedRows[0].Cells[6].Value.ToString();
            
        }


        private void GenderCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        // Reset button
        private void guna2Button4_Click(object sender, EventArgs e)
        {
            NameTb.Text = "";
            PhoneTb.Text = "";
            GenderCb.Text = "";
            AgeTb.Text = "";
            AmountTb.Text = "";
            TimingCb.Text = "";
        }

        // delete button 
        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (key == 0 )
            {
                MessageBox.Show("Zaznacz użytkownika do usunięcia.");

            }   
            else
            {
                try
                {
                    conn.Open();
                    string query = $"Delete from UserTbl Where Id = {key};";
                    SqlCommand sqlCommand = new SqlCommand(query,conn);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Użytkownik został pomyślnie usunięty.");
                    conn.Close();
                    
                }
                catch(Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    SelectAllUsers();
                }
                
                
            }
        }

        private void UpdateDelete_Load(object sender, EventArgs e)
        {
            SelectAllUsers();
        }

        // update button
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (NameTb.Text == "" || PhoneTb.Text == "" || AmountTb.Text == "" || AgeTb.Text == "" || GenderCb.Text == "" || TimingCb.Text == "")
            {
                MessageBox.Show("Uzupełnij brakujące dane.");
            }
            else
            {
                try
                {
                    conn.Open();
                    string query = $"UPDATE UserTbl SET Name = '{NameTb.Text}', Phone = '{PhoneTb.Text}', Gender = '{GenderCb.Text}', Age = {AgeTb.Text}, Amount = {AmountTb.Text}, Timing = '{TimingCb.Text}' WHERE Id = {key}; ";
                    SqlCommand sqlCommand = new SqlCommand(query, conn);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Użytkownik został pomyślnie zaktualizowany.");
                    conn.Close();

                }
                catch (Exception ex)
                {

                    throw ex;
                }
                finally
                {
                    SelectAllUsers();
                }
            }
        }
    }
}
