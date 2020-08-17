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
    public partial class Teacher : Form
    {
        public Teacher()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 teacherback = new Form2();
            teacherback.Show();
        }

        private void add_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_Teacher add = new Add_Teacher();
            add.Show();
        }

        private void update_Click(object sender, EventArgs e)
        {
            this.Hide();
            Update_Teacher update = new Update_Teacher();
            update.Show();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeleteTeacher delete = new DeleteTeacher();
            delete.Show();

        }

        private void search_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchTeacher search = new SearchTeacher();
            search.Show();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }
    }
}
