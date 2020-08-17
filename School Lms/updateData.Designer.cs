namespace School_Lms
{
    partial class updateData
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
            this.buttonback = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.updatingBox = new System.Windows.Forms.TextBox();
            this.asking = new System.Windows.Forms.ComboBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.updateBox = new System.Windows.Forms.TextBox();
            this.back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonback
            // 
            this.buttonback.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonback.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonback.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonback.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonback.Location = new System.Drawing.Point(-154, 10);
            this.buttonback.Name = "buttonback";
            this.buttonback.Size = new System.Drawing.Size(96, 34);
            this.buttonback.TabIndex = 24;
            this.buttonback.Text = "Back";
            this.buttonback.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(451, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Update your data here ->";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Choose your option:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Roll Number";
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
            this.dataGridView1.Location = new System.Drawing.Point(-1, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1230, 399);
            this.dataGridView1.TabIndex = 20;
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
            // updatingBox
            // 
            this.updatingBox.Location = new System.Drawing.Point(582, 15);
            this.updatingBox.Name = "updatingBox";
            this.updatingBox.Size = new System.Drawing.Size(236, 20);
            this.updatingBox.TabIndex = 19;
            // 
            // asking
            // 
            this.asking.FormattingEnabled = true;
            this.asking.Items.AddRange(new object[] {
            "Fee Status",
            "B Form",
            "First Name",
            "Last Name",
            "Father Name",
            "Section",
            "Date of Birth",
            "Address",
            "Phone Number"});
            this.asking.Location = new System.Drawing.Point(298, 14);
            this.asking.Name = "asking";
            this.asking.Size = new System.Drawing.Size(121, 21);
            this.asking.TabIndex = 18;
            // 
            // updateButton
            // 
            this.updateButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.updateButton.Location = new System.Drawing.Point(824, 12);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 17;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // updateBox
            // 
            this.updateBox.Location = new System.Drawing.Point(85, 12);
            this.updateBox.Name = "updateBox";
            this.updateBox.Size = new System.Drawing.Size(100, 20);
            this.updateBox.TabIndex = 16;
            // 
            // back
            // 
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.back.Location = new System.Drawing.Point(905, 12);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 25;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // updateData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 450);
            this.Controls.Add(this.back);
            this.Controls.Add(this.buttonback);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.updatingBox);
            this.Controls.Add(this.asking);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.updateBox);
            this.Name = "updateData";
            this.Text = "updateData";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonback;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.TextBox updatingBox;
        private System.Windows.Forms.ComboBox asking;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.TextBox updateBox;
        private System.Windows.Forms.Button back;
    }
}