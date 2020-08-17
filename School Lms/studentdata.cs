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
    public partial class studentdata : Form
    {
        public studentdata()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            saveData();
        }
        private void saveData()
        {
            string rollno = rollnumber.Text;
            string first_name = firstname.Text;
            string last_name = lastname.Text;
            string father_name = fathername.Text;
            string class_grade = classgrade.Text;
            string dob = textBox1.Text;
            string bform = b_formbox.Text;
            string phonenumber = std_phonebox.Text;
            string address = richTextBox1.Text;
            string city = citybox.Text;
            string province = comboBox1.Text;
            string religion = religioncombo.Text;
            string gender1 = maleradio.Text;
            string gender2 = femaleradio.Text;
            string fee_status = feestatus.Text;
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-FOEQKLT\\SQLEXPRESS;Initial Catalog=LMS;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Student values(@rollnumber, @firstname, @lastname,@fathername,@classgrade,@dob,@bform, @phonenumber,@address,@city,@province,@religion,@gender,@fee)", con);
            cmd.Parameters.AddWithValue("@rollnumber", rollno);
            cmd.Parameters.AddWithValue("@firstname", first_name);
            cmd.Parameters.AddWithValue("@lastname", last_name);
            cmd.Parameters.AddWithValue("@fathername", father_name);
            cmd.Parameters.AddWithValue("@classgrade", class_grade);
            cmd.Parameters.AddWithValue("@dob", dob);
            cmd.Parameters.AddWithValue("@bform", bform);
            cmd.Parameters.AddWithValue("@phonenumber", phonenumber);
            cmd.Parameters.AddWithValue("@address", address);
            cmd.Parameters.AddWithValue("@city", city);
            cmd.Parameters.AddWithValue("@province", province);
            cmd.Parameters.AddWithValue("@religion", religion);
            if (maleradio.Checked == true)
            {

                cmd.Parameters.AddWithValue("@gender", gender1);
            }
            if (femaleradio.Checked == true)
            {

                cmd.Parameters.AddWithValue("@gender", gender2);
            }
            cmd.Parameters.AddWithValue("@fee", fee_status);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data is successfully stored");
            con.Close();
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            student std = new student();
            std.Show();

        }
    }
}
