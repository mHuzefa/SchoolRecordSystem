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
    public partial class SearchTeacher : Form
    {
        public SearchTeacher()
        {
            InitializeComponent();
        }

        private void searchbutton_Click(object sender, EventArgs e)
        {
            if (searchbox.Text == "")
            {
                MessageBox.Show("No Data is entered");
            }
            else
            {
                searchFunction();
            }

        }
        private void searchFunction()
        {
            string id = searchbox.Text;
            string cnic = searchbox.Text;
            SqlConnection connect = new SqlConnection("Data Source=DESKTOP-FOEQKLT\\SQLEXPRESS;Initial Catalog=LMS;Integrated Security=True");
            DataTable datatable = new DataTable();
            SqlDataAdapter SDA = new SqlDataAdapter("SELECT * FROM teacher WHERE teacherId = " + id, connect);
    
            SDA.Fill(datatable);
           
            dataGridView1.DataSource = datatable;
            if (dataGridView1.Rows.Count == 1)
            {
                MessageBox.Show("Record is not found");
            }
            searchbox.Text = "";

        }

        private void display_Click(object sender, EventArgs e)
        {

            SqlConnection connect = new SqlConnection("Data Source=DESKTOP-FOEQKLT\\SQLEXPRESS;Initial Catalog=LMS;Integrated Security=True");
            DataTable datatable = new DataTable();
            SqlDataAdapter SDA = new SqlDataAdapter("SELECT * FROM teacher ", connect);
            SDA.Fill(datatable);
            dataGridView1.DataSource = datatable;
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Teacher back = new Teacher();
            back.Show();
        }
    }
}
