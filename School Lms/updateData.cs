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
    public partial class updateData : Form
    {
        public updateData()
        {
            InitializeComponent();
            populate_data();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (updatingBox.Text == "" || asking.Text == "" || updateBox.Text == "")
            {
                MessageBox.Show(" No Data is entered for updation");
            }
            else
            {
                update();
                populate_data();
            }

        }

        private void update()
        {

            string updating = updatingBox.Text;
            SqlConnection connect = new SqlConnection("Data Source=DESKTOP-FOEQKLT\\SQLEXPRESS;Initial Catalog=LMS;Integrated Security=True");
            connect.Open();
            if (asking.Text == "First Name")
            {

                SqlCommand cmd = new SqlCommand("Update Student SET FName = @firstname WHERE RollNumber = " + updateBox.Text, connect);
                cmd.Parameters.AddWithValue("@firstname", updating);
                cmd.ExecuteNonQuery();

            }
            else if (asking.Text == "Last Name")
            {

                SqlCommand cmd = new SqlCommand("Update Student SET LName = @lastname WHERE RollNumber = " + updateBox.Text, connect);
                cmd.Parameters.AddWithValue("@lastname", updating);
                cmd.ExecuteNonQuery();

            }
            else if (asking.Text == "Father Name")
            {

                SqlCommand cmd = new SqlCommand("Update Student SET fathername = @fathername WHERE RollNumber = " + updateBox.Text, connect);
                cmd.Parameters.AddWithValue("@fathername", updating);
                cmd.ExecuteNonQuery();

            }
            else if (asking.Text == "Address")
            {

                SqlCommand cmd = new SqlCommand("Update Student SET Std_Address = @address WHERE RollNumber = " + updateBox.Text, connect);
                cmd.Parameters.AddWithValue("@address", updating);
                cmd.ExecuteNonQuery();

            }
            else if (asking.Text == "Fee Status")
            {
                SqlCommand cmd = new SqlCommand("Update Student SET FeeStatus = @feestatus WHERE RollNumber = " + updateBox.Text, connect);
                cmd.Parameters.AddWithValue("@feestatus", updating);
                cmd.ExecuteNonQuery();
            }
            else if (asking.Text == "Section")
            {

                SqlCommand cmd = new SqlCommand("Update Student SET class_id = @section WHERE RollNumber = " + updateBox.Text, connect);
                cmd.Parameters.AddWithValue("@section", updating);
                cmd.ExecuteNonQuery();

            }
            else if (asking.Text == "Date of Birth")
            {

                SqlCommand cmd = new SqlCommand("Update Student SET DOB = @dob WHERE RollNumber = " + updateBox.Text, connect);
                cmd.Parameters.AddWithValue("@dob", updating);
                cmd.ExecuteNonQuery();

            }
            else if (asking.Text == "B Form")
            {
                SqlCommand cmd = new SqlCommand("Update Student SET bform = @bform WHERE RollNumber = " + updateBox.Text, connect);
                cmd.Parameters.AddWithValue("@bform", updating);
                cmd.ExecuteNonQuery();

            }
            else if (asking.Text == "Phone Number")
            {

                SqlCommand cmd = new SqlCommand("Update Student SET Phone = @phone WHERE RollNumber = " + updateBox.Text, connect);
                cmd.Parameters.AddWithValue("@phone", updating);
                cmd.ExecuteNonQuery();

            }
            connect.Close();
            MessageBox.Show("Data is successfully updated");
            populate_data();
            updateBox.Text = "";
            updatingBox.Text = "";
            asking.Text = "";
        }
        private void populate_data()
        {
            dataGridView1.Rows.Clear();
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-FOEQKLT\\SQLEXPRESS;Initial Catalog=LMS;Integrated Security=True");
            con.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM Student", con);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataSet db = new DataSet();
            adapter.Fill(db);
            for (int i = 0; i < db.Tables[0].Rows.Count; i++)
            {
                string rollnumber = db.Tables[0].Rows[i].ItemArray[0].ToString();
                string firstname = db.Tables[0].Rows[i].ItemArray[1].ToString();
                string lastname = db.Tables[0].Rows[i].ItemArray[2].ToString();
                string fathername = db.Tables[0].Rows[i].ItemArray[3].ToString();
                string classgrade = db.Tables[0].Rows[i].ItemArray[4].ToString();
                string dob = db.Tables[0].Rows[i].ItemArray[5].ToString();
                string bform = db.Tables[0].Rows[i].ItemArray[6].ToString();
                string phonenumber = db.Tables[0].Rows[i].ItemArray[7].ToString();
                string address = db.Tables[0].Rows[i].ItemArray[8].ToString();
                string city = db.Tables[0].Rows[i].ItemArray[9].ToString();
                string province = db.Tables[0].Rows[i].ItemArray[10].ToString();
                string religion = db.Tables[0].Rows[i].ItemArray[11].ToString();
                string gender = db.Tables[0].Rows[i].ItemArray[12].ToString();
                string feestatus = db.Tables[0].Rows[i].ItemArray[13].ToString();

                DataGridViewRow row1 = new DataGridViewRow();
                row1.CreateCells(dataGridView1);
                row1.Cells[0].Value = rollnumber;
                row1.Cells[1].Value = firstname;
                row1.Cells[2].Value = lastname;
                row1.Cells[3].Value = fathername;
                row1.Cells[4].Value = classgrade;
                row1.Cells[5].Value = dob;
                row1.Cells[6].Value = bform;
                row1.Cells[7].Value = phonenumber;
                row1.Cells[8].Value = address;
                row1.Cells[9].Value = city;
                row1.Cells[10].Value = province;
                row1.Cells[11].Value = religion;
                row1.Cells[12].Value = gender;
                row1.Cells[13].Value = feestatus;
                dataGridView1.Rows.Add(row1);
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            student std = new student();
            std.Show();
        }
    }
}
