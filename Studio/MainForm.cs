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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void SetDataTime()
        {

            Godzina.Text = DateTime.Now.ToLongTimeString();
            Data.Text = DateTime.Now.ToLongDateString();
        }

       

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Payments payments = new Payments();
            payments.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void AddMember_Click(object sender, EventArgs e)
        {
            AddMember addMember = new AddMember();
            addMember.Show();
            this.Hide();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SetDataTime();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            ViewMembers viewMembers = new ViewMembers();
            viewMembers.Show();
            this.Hide();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            UpdateDelete updateDelete = new UpdateDelete();
            updateDelete.Show();
            this.Hide();
        }

        // Data
        private void Data_Click(object sender, EventArgs e)
        {
            
        }
    }
}
