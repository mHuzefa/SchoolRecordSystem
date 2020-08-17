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
    public partial class DeleteTeacher : Form
    {
        public DeleteTeacher()
        {
            InitializeComponent();
            populateGrid();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            int deletestudent = Convert.ToInt32(teacherId.Text);
            teacherId.Text = deletestudent.ToString();
            if (delete.Text == "")
            {
                MessageBox.Show("Nothing to delete from Grid");
            }
            else
            {
                deleteTeacher();
                
            }
            delete.Text = "";

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
        private void deleteTeacher()
        {

            
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-FOEQKLT\\SQLEXPRESS;Initial Catalog=LMS;Integrated Security=True");
            connection.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM teacher WHERE TeacherId = @teacherId", connection);
            cmd.Parameters.AddWithValue("@teacherId", teacherId.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Information deleted successfully");
            connection.Close();
            populateGrid();
            
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Teacher teach = new Teacher();
            teach.Show();
        }

        private void teacherId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
