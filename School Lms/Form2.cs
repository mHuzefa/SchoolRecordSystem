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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void register_Click(object sender, EventArgs e)
        {
            register reg = new register();
            this.Hide();
            reg.Show();
        }

        private void student_Click(object sender, EventArgs e)
        {
            student std = new student();
            this.Hide();
            std.Show();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void teacher_Click(object sender, EventArgs e)
        {
            Teacher teacher = new Teacher();
            this.Hide();
            teacher.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are successfully logged out!");
            this.Hide();
            Form1 logout = new Form1();
            logout.Show();
            
        }
    }
}
