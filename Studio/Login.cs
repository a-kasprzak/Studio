using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Studio
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //login button
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (LoginNameTb.Text == "admin" && PasswordTb.Text == "admin")
            {
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide();
            }
            else if (LoginNameTb.Text == "" && PasswordTb.Text == "")
            {
                MessageBox.Show("Uzupełnij brakujące pola");
            }
            else
            {
                MessageBox.Show("Nie poprawny login lub hasło");
            }
        }
    }
}
