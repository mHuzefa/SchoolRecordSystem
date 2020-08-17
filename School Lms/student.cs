using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Lms
{
    public partial class student : Form
    {
        public student()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            studentdata stdData = new studentdata();
            this.Hide();
            stdData.Show();
        }

        private void update_Click(object sender, EventArgs e)
        {
            updateData update = new updateData();
            this.Hide();
            update.Show();

        }

        private void back_Click(object sender, EventArgs e)
        {
            Form2 back = new Form2();
            this.Hide();
            back.Show();

        }

        private void delete_Click(object sender, EventArgs e)
        {
            deleteData delete = new deleteData();
            this.Hide();
            delete.Show();

        }

        private void search_Click(object sender, EventArgs e)
        {
            search student = new search();
            this.Hide();
            student.Show();

        }
    }
}
