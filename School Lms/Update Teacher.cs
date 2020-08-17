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
    public partial class Update_Teacher : Form
    {
        public Update_Teacher()
        {
            InitializeComponent();
            populateGrid();
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (teacherId.Text == "" || options.Text == "" || updateBox.Text == "")
            {
                MessageBox.Show(" No Data is entered for updation");
            }
            else
            {
                updateData();
            }
        }

        private void populateGrid()
        {
            dataGridView1.Rows.Clear();
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-FOEQKLT\\SQLEXPRESS;Initial Catalog=LMS;Integrated Security=True");
            con.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM teacher", con);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataSet db = new DataSet();
            adapter.Fill(db);
            for (int i = 0; i < db.Tables[0].Rows.Count; i++)
            {
                string teacherId = db.Tables[0].Rows[i].ItemArray[0].ToString();
                string Name = db.Tables[0].Rows[i].ItemArray[1].ToString();
                string fathername = db.Tables[0].Rows[i].ItemArray[2].ToString();
                string cnic = db.Tables[0].Rows[i].ItemArray[3].ToString();
                string classgrade = db.Tables[0].Rows[i].ItemArray[4].ToString();
                string dob = db.Tables[0].Rows[i].ItemArray[5].ToString();
                string phonenumber = db.Tables[0].Rows[i].ItemArray[6].ToString();
                string address = db.Tables[0].Rows[i].ItemArray[7].ToString();


                DataGridViewRow row1 = new DataGridViewRow();
                row1.CreateCells(dataGridView1);
                row1.Cells[0].Value = teacherId;
                row1.Cells[1].Value = Name;
                row1.Cells[2].Value = fathername;
                row1.Cells[3].Value = cnic;
                row1.Cells[4].Value = classgrade;
                row1.Cells[5].Value = dob;
                row1.Cells[6].Value = phonenumber;
                row1.Cells[7].Value = address;
 
                dataGridView1.Rows.Add(row1);
            }
        }
        private void updateData()
        {

            string updating = updateBox.Text;
            SqlConnection connect = new SqlConnection("Data Source=DESKTOP-FOEQKLT\\SQLEXPRESS;Initial Catalog=LMS;Integrated Security=True");
            connect.Open();
            if (options.Text == "Name")
            {

                SqlCommand cmd = new SqlCommand("Update teacher SET TeacherName = @name WHERE TeacherId = " + teacherId.Text, connect);
                cmd.Parameters.AddWithValue("@name", updating);
                cmd.ExecuteNonQuery();

            }
            else if (options.Text == "Father Name")
            {

                SqlCommand cmd = new SqlCommand("Update teacher SET TeacherFather = @fathername WHERE TeacherId = " + teacherId.Text, connect);
                cmd.Parameters.AddWithValue("@fathername", updating);
                cmd.ExecuteNonQuery();

            }
            else if (options.Text == "CNIC")
            {

                SqlCommand cmd = new SqlCommand("Update teacher SET CNIC = @cnic WHERE TeacherId = " + teacherId.Text, connect);
                cmd.Parameters.AddWithValue("@cnic", updating);
                cmd.ExecuteNonQuery();

            }
            else if (options.Text == "Address")
            {

                SqlCommand cmd = new SqlCommand("Update teacher SET Teacher_Address = @address WHERE TeacherId = " + teacherId.Text, connect);
                cmd.Parameters.AddWithValue("@address", updating);
                cmd.ExecuteNonQuery();

            }
            else if (options.Text == "Phone Number")
            {
                SqlCommand cmd = new SqlCommand("Update teacher SET Teacher_Phone = @phone WHERE TeacherId = " + teacherId.Text, connect);
                cmd.Parameters.AddWithValue("@phone", updating);
                cmd.ExecuteNonQuery();
            }
            else if (options.Text == "Date of Birth")
            {

                SqlCommand cmd = new SqlCommand("Update teacher SET DOB = @dob WHERE TeacherId = " + teacherId.Text, connect);
                cmd.Parameters.AddWithValue("@dob", updating);
                cmd.ExecuteNonQuery();

            }
            else if (options.Text == "Class Grade")
            {
                SqlCommand cmd = new SqlCommand("Update teacher SET class_id = @classgrade WHERE TeacherId = " + teacherId.Text, connect);
                cmd.Parameters.AddWithValue("@classgrade", updating);
                cmd.ExecuteNonQuery();
            }
            connect.Close();
            MessageBox.Show("Data is successfully updated");
            populateGrid();
            teacherId.Text = "";
            updateBox.Text = "";
            options.Text = "";
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Teacher teacher = new Teacher();
            teacher.Show();
        }
    }
}
