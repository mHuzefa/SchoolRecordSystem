namespace School_Lms
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.student = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.teacher = new System.Windows.Forms.Button();
            this.classButton = new System.Windows.Forms.Button();
            this.subjects = new System.Windows.Forms.Button();
            this.register = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // student
            // 
            this.student.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.student.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.student.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.student.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.student.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.student.Location = new System.Drawing.Point(136, 139);
            this.student.Name = "student";
            this.student.Size = new System.Drawing.Size(84, 33);
            this.student.TabIndex = 0;
            this.student.Text = "Student";
            this.student.UseVisualStyleBackColor = false;
            this.student.Click += new System.EventHandler(this.student_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(219, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(356, 34);
            this.label2.TabIndex = 7;
            this.label2.Text = "Data you want to add for";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(132, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(535, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "You can also give access to any other user by clicking register button";
            // 
            // teacher
            // 
            this.teacher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.teacher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.teacher.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.teacher.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacher.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.teacher.Location = new System.Drawing.Point(288, 139);
            this.teacher.Name = "teacher";
            this.teacher.Size = new System.Drawing.Size(84, 33);
            this.teacher.TabIndex = 9;
            this.teacher.Text = "Teacher";
            this.teacher.UseVisualStyleBackColor = false;
            this.teacher.Click += new System.EventHandler(this.teacher_Click);
            // 
            // classButton
            // 
            this.classButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.classButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.classButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.classButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.classButton.Location = new System.Drawing.Point(433, 139);
            this.classButton.Name = "classButton";
            this.classButton.Size = new System.Drawing.Size(85, 33);
            this.classButton.TabIndex = 10;
            this.classButton.Text = "Class";
            this.classButton.UseVisualStyleBackColor = false;
            // 
            // subjects
            // 
            this.subjects.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.subjects.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.subjects.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.subjects.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjects.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.subjects.Location = new System.Drawing.Point(580, 139);
            this.subjects.Name = "subjects";
            this.subjects.Size = new System.Drawing.Size(85, 33);
            this.subjects.TabIndex = 11;
            this.subjects.Text = "Subjects";
            this.subjects.UseVisualStyleBackColor = false;
            // 
            // register
            // 
            this.register.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.register.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.register.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.register.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.register.Location = new System.Drawing.Point(363, 230);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(86, 33);
            this.register.TabIndex = 12;
            this.register.Text = "Register";
            this.register.UseVisualStyleBackColor = false;
            this.register.Click += new System.EventHandler(this.register_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exit.Location = new System.Drawing.Point(363, 359);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(86, 33);
            this.exit.TabIndex = 13;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(702, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 33);
            this.button1.TabIndex = 14;
            this.button1.Text = "Log out";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.register);
            this.Controls.Add(this.subjects);
            this.Controls.Add(this.classButton);
            this.Controls.Add(this.teacher);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.student);
            this.Name = "Form2";
            this.Text = "Start";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button student;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button teacher;
        private System.Windows.Forms.Button classButton;
        private System.Windows.Forms.Button subjects;
        private System.Windows.Forms.Button register;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button button1;
    }
}