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

namespace School_Lms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {
            logIn();
        }

        private void pwBox_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                logIn();
            }
        }

        private void logIn()
        {

            string username = unBox.Text;
            string password = pwBox.Text;
            
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-FOEQKLT\\SQLEXPRESS;Initial Catalog=LMS;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from userpass where username ='" + unBox.Text + "'and pw='" + pwBox.Text + "'", con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if(unBox.Text == "admin" && pwBox.Text == "admin")
            {
                Teacher_Page teacher = new Teacher_Page();
                this.Hide();
                teacher.Show();
            }
            else if (dt.Rows.Count > 0)
            {
                MessageBox.Show("You are successfully logged in");
                Form2 start = new Form2();
                this.Hide();
                start.Show();

            }
            else
            {
                MessageBox.Show("Invalid Login please check username and password");
            }
            con.Close();
            unBox.Text = "";
            pwBox.Text = "";
           
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pwBox_TextChanged(object sender, EventArgs e)
        {
            
            pwBox.ForeColor = Color.Black;
            pwBox.PasswordChar = '●';
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
