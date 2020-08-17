namespace School_Lms
{
    partial class deleteData
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rollno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fathername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classgrade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bform = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phonenumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.city = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.province = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.religion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feestatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonback = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.deleteBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rollno,
            this.firstname,
            this.lastname,
            this.fathername,
            this.classgrade,
            this.dob,
            this.bform,
            this.phonenumber,
            this.address,
            this.city,
            this.province,
            this.religion,
            this.gender,
            this.feestatus});
            this.dataGridView1.Location = new System.Drawing.Point(-1, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1333, 456);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // rollno
            // 
            this.rollno.HeaderText = "Roll Number";
            this.rollno.Name = "rollno";
            // 
            // firstname
            // 
            this.firstname.HeaderText = "First Name";
            this.firstname.Name = "firstname";
            // 
            // lastname
            // 
            this.lastname.HeaderText = "Last Name";
            this.lastname.Name = "lastname";
            // 
            // fathername
            // 
            this.fathername.HeaderText = "Father Name";
            this.fathername.Name = "fathername";
            // 
            // classgrade
            // 
            this.classgrade.HeaderText = "Class Grade";
            this.classgrade.Name = "classgrade";
            // 
            // dob
            // 
            this.dob.HeaderText = "Date of Birth";
            this.dob.Name = "dob";
            // 
            // bform
            // 
            this.bform.HeaderText = "B. Form";
            this.bform.Name = "bform";
            // 
            // phonenumber
            // 
            this.phonenumber.HeaderText = "Phone Number\'";
            this.phonenumber.Name = "phonenumber";
            // 
            // address
            // 
            this.address.HeaderText = "Address";
            this.address.Name = "address";
            // 
            // city
            // 
            this.city.HeaderText = "City";
            this.city.Name = "city";
            // 
            // province
            // 
            this.province.HeaderText = "Province";
            this.province.Name = "province";
            // 
            // religion
            // 
            this.religion.HeaderText = "Religion";
            this.religion.Name = "religion";
            // 
            // gender
            // 
            this.gender.HeaderText = "Gender";
            this.gender.Name = "gender";
            // 
            // feestatus
            // 
            this.feestatus.HeaderText = "Fee Status";
            this.feestatus.Name = "feestatus";
            // 
            // buttonback
            // 
            this.buttonback.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonback.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonback.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonback.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonback.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonback.Location = new System.Drawing.Point(682, 17);
            this.buttonback.Name = "buttonback";
            this.buttonback.Size = new System.Drawing.Size(96, 29);
            this.buttonback.TabIndex = 13;
            this.buttonback.Text = "Back";
            this.buttonback.UseVisualStyleBackColor = false;
            this.buttonback.Click += new System.EventHandler(this.buttonback_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.deleteButton.Location = new System.Drawing.Point(580, 17);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(96, 29);
            this.deleteButton.TabIndex = 12;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // deleteBox
            // 
            this.deleteBox.Location = new System.Drawing.Point(88, 23);
            this.deleteBox.Name = "deleteBox";
            this.deleteBox.Size = new System.Drawing.Size(485, 20);
            this.deleteBox.TabIndex = 11;
            // 
            // deleteData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonback);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.deleteBox);
            this.Name = "deleteData";
            this.Text = "deleteData";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rollno;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstname;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn fathername;
        private System.Windows.Forms.DataGridViewTextBoxColumn classgrade;
        private System.Windows.Forms.DataGridViewTextBoxColumn dob;
        private System.Windows.Forms.DataGridViewTextBoxColumn bform;
        private System.Windows.Forms.DataGridViewTextBoxColumn phonenumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn city;
        private System.Windows.Forms.DataGridViewTextBoxColumn province;
        private System.Windows.Forms.DataGridViewTextBoxColumn religion;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn feestatus;
        private System.Windows.Forms.Button buttonback;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TextBox deleteBox;
    }
}