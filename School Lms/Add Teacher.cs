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
    public partial class Add_Teacher : Form
    {
        public Add_Teacher()
        {
            InitializeComponent();
        }

        private void Add_Teacher_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-FOEQKLT\\SQLEXPRESS;Initial Catalog=LMS;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into teacher(class_id, TeacherName, TeacherFather,CNIC,Teacher_DOB, Teacher_Phone, Teacher_Address) values(@class, @name, @fathername,@cnic,@dob, @phonenumber,@address)", con);
            cmd.Parameters.AddWithValue("@name", name.Text);
            cmd.Parameters.AddWithValue("@fathername", fathername.Text);
            cmd.Parameters.AddWithValue("@CNIC", cnic.Text);
            cmd.Parameters.AddWithValue("@class", classGrade.Text);
            cmd.Parameters.AddWithValue("@dob", dob.Text);
            cmd.Parameters.AddWithValue("@phonenumber", phone.Text);
            cmd.Parameters.AddWithValue("@address", address.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data saved successfully");
            con.Close();
            name.Text = "";
            fathername.Text = "";
            cnic.Text = "";
            classGrade.Text = "";
            dob.Text = "";
            phone.Text = "";
            address.Text = "";
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Teacher teacher = new Teacher();
            teacher.Show();
        }
    }
}
