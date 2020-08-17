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
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace School_Lms
{
    public partial class search : Form
    {
        public search()
        {
            InitializeComponent();
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            student std = new student();
            std.Show();
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

            SqlConnection connect = new SqlConnection("Data Source=DESKTOP-FOEQKLT\\SQLEXPRESS;Initial Catalog=LMS;Integrated Security=True");
            DataTable datatable = new DataTable();
            SqlDataAdapter SDA = new SqlDataAdapter("SELECT * FROM Student WHERE RollNumber = " + searchbox.Text, connect);
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
            SqlDataAdapter SDA = new SqlDataAdapter("SELECT * FROM Student ", connect);
            SDA.Fill(datatable);
            dataGridView1.DataSource = datatable;
        }

        private void searchbox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
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
        }

        private void pdf_Click(object sender, EventArgs e)
        {
            pdfGenerate();
        }
        private void pdfGenerate()
        {
            Document doc = new Document(iTextSharp.text.PageSize.A4);
            PdfWriter pdf = PdfWriter.GetInstance(doc, new FileStream("Student Record.pdf", FileMode.OpenOrCreate));
            doc.Open();
            PdfPTable table = new PdfPTable(dataGridView1.Columns.Count);
            // Add the headers from the Grid to table
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                table.AddCell(new Phrase(dataGridView1.Columns[i].HeaderText));
            }
            table.HeaderRows = 1;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    if (dataGridView1[j, i].Value != null)
                    {
                        table.AddCell(new Phrase(dataGridView1[j, i].Value.ToString()));
                    }
                }
            }
            doc.Add(table);
            doc.Close();
            System.Diagnostics.Process.Start("C:\\Users\\huzi6\\source\\repos\\School LMS\\bin\\Debug\\Student Record.pdf");
        }
    }
    

}
