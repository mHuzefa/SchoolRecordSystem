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
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            registeration();
        }

        private void textBox4_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                registeration();
            }
        }
        private void registeration()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-FOEQKLT\\SQLEXPRESS;Initial Catalog=LMS;Integrated Security=True");
            con.Open();
            string name = textBox1.Text;
            string designation = textBox2.Text;
            string username = textBox3.Text;
            string password = textBox4.Text;

            SqlCommand cmd = new SqlCommand("INSERT into userpass values(@username, @password, @name, @designation)", con);

            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@designation", designation);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Account is created successfully");
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";



            Form1 start = new Form1();
            con.Close();
            this.Hide();
            start.Show();

        }
    }
}
