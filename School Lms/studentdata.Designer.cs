namespace School_Lms
{
    partial class studentdata
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
            this.backbutton = new System.Windows.Forms.Button();
            this.std_inf_label = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.feestatus = new System.Windows.Forms.ComboBox();
            this.genderlabel = new System.Windows.Forms.Label();
            this.femaleradio = new System.Windows.Forms.RadioButton();
            this.maleradio = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.religioncombo = new System.Windows.Forms.ComboBox();
            this.religion = new System.Windows.Forms.Label();
            this.province_label = new System.Windows.Forms.Label();
            this.std_city = new System.Windows.Forms.Label();
            this.citybox = new System.Windows.Forms.TextBox();
            this.std_address = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.bform_characters = new System.Windows.Forms.Label();
            this.std_phone = new System.Windows.Forms.Label();
            this.std_phonebox = new System.Windows.Forms.TextBox();
            this.bform = new System.Windows.Forms.Label();
            this.b_formbox = new System.Windows.Forms.TextBox();
            this.dateExample = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.classLabel = new System.Windows.Forms.Label();
            this.classgrade = new System.Windows.Forms.TextBox();
            this.fatherlable = new System.Windows.Forms.Label();
            this.fathername = new System.Windows.Forms.TextBox();
            this.LName = new System.Windows.Forms.Label();
            this.lastname = new System.Windows.Forms.TextBox();
            this.FName = new System.Windows.Forms.Label();
            this.firstname = new System.Windows.Forms.TextBox();
            this.RollNo = new System.Windows.Forms.Label();
            this.rollnumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // backbutton
            // 
            this.backbutton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.backbutton.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.backbutton.Location = new System.Drawing.Point(12, 8);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(96, 34);
            this.backbutton.TabIndex = 70;
            this.backbutton.Text = "Back";
            this.backbutton.UseVisualStyleBackColor = false;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // std_inf_label
            // 
            this.std_inf_label.AutoSize = true;
            this.std_inf_label.BackColor = System.Drawing.SystemColors.ControlDark;
            this.std_inf_label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.std_inf_label.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.std_inf_label.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.std_inf_label.Location = new System.Drawing.Point(280, 5);
            this.std_inf_label.Name = "std_inf_label";
            this.std_inf_label.Size = new System.Drawing.Size(269, 27);
            this.std_inf_label.TabIndex = 69;
            this.std_inf_label.Text = "Student Inforation Form";
            // 
            // saveButton
            // 
            this.saveButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.saveButton.Location = new System.Drawing.Point(0, 400);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(800, 50);
            this.saveButton.TabIndex = 68;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(461, 355);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 21);
            this.label2.TabIndex = 67;
            this.label2.Text = "Fee Status";
            // 
            // feestatus
            // 
            this.feestatus.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feestatus.FormattingEnabled = true;
            this.feestatus.Items.AddRange(new object[] {
            "Paid",
            "Unpaid"});
            this.feestatus.Location = new System.Drawing.Point(566, 355);
            this.feestatus.Name = "feestatus";
            this.feestatus.Size = new System.Drawing.Size(150, 27);
            this.feestatus.TabIndex = 66;
            // 
            // genderlabel
            // 
            this.genderlabel.AutoSize = true;
            this.genderlabel.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderlabel.Location = new System.Drawing.Point(112, 355);
            this.genderlabel.Name = "genderlabel";
            this.genderlabel.Size = new System.Drawing.Size(66, 21);
            this.genderlabel.TabIndex = 65;
            this.genderlabel.Text = "Gender";
            // 
            // femaleradio
            // 
            this.femaleradio.AutoSize = true;
            this.femaleradio.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.femaleradio.Location = new System.Drawing.Point(275, 355);
            this.femaleradio.Name = "femaleradio";
            this.femaleradio.Size = new System.Drawing.Size(75, 23);
            this.femaleradio.TabIndex = 64;
            this.femaleradio.TabStop = true;
            this.femaleradio.Text = "Female";
            this.femaleradio.UseVisualStyleBackColor = true;
            // 
            // maleradio
            // 
            this.maleradio.AutoSize = true;
            this.maleradio.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maleradio.Location = new System.Drawing.Point(203, 355);
            this.maleradio.Name = "maleradio";
            this.maleradio.Size = new System.Drawing.Size(60, 23);
            this.maleradio.TabIndex = 63;
            this.maleradio.TabStop = true;
            this.maleradio.Text = "Male";
            this.maleradio.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Punjab",
            "Sindh",
            "KPK",
            "Balochistan"});
            this.comboBox1.Location = new System.Drawing.Point(566, 282);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(150, 27);
            this.comboBox1.TabIndex = 62;
            // 
            // religioncombo
            // 
            this.religioncombo.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.religioncombo.FormattingEnabled = true;
            this.religioncombo.Items.AddRange(new object[] {
            "Islam",
            "Christain",
            "Hindu"});
            this.religioncombo.Location = new System.Drawing.Point(566, 317);
            this.religioncombo.Name = "religioncombo";
            this.religioncombo.Size = new System.Drawing.Size(150, 27);
            this.religioncombo.TabIndex = 61;
            // 
            // religion
            // 
            this.religion.AutoSize = true;
            this.religion.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.religion.Location = new System.Drawing.Point(461, 317);
            this.religion.Name = "religion";
            this.religion.Size = new System.Drawing.Size(71, 21);
            this.religion.TabIndex = 60;
            this.religion.Text = "Religion";
            // 
            // province_label
            // 
            this.province_label.AutoSize = true;
            this.province_label.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.province_label.Location = new System.Drawing.Point(461, 279);
            this.province_label.Name = "province_label";
            this.province_label.Size = new System.Drawing.Size(75, 21);
            this.province_label.TabIndex = 59;
            this.province_label.Text = "Province";
            // 
            // std_city
            // 
            this.std_city.AutoSize = true;
            this.std_city.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.std_city.Location = new System.Drawing.Point(487, 245);
            this.std_city.Name = "std_city";
            this.std_city.Size = new System.Drawing.Size(39, 21);
            this.std_city.TabIndex = 58;
            this.std_city.Text = "City";
            // 
            // citybox
            // 
            this.citybox.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.citybox.Location = new System.Drawing.Point(566, 242);
            this.citybox.Margin = new System.Windows.Forms.Padding(5);
            this.citybox.Name = "citybox";
            this.citybox.Size = new System.Drawing.Size(150, 24);
            this.citybox.TabIndex = 57;
            // 
            // std_address
            // 
            this.std_address.AutoSize = true;
            this.std_address.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.std_address.Location = new System.Drawing.Point(112, 242);
            this.std_address.Name = "std_address";
            this.std_address.Size = new System.Drawing.Size(70, 21);
            this.std_address.TabIndex = 56;
            this.std_address.Text = "Address";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(203, 242);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(225, 96);
            this.richTextBox1.TabIndex = 55;
            this.richTextBox1.Text = "";
            // 
            // bform_characters
            // 
            this.bform_characters.AutoSize = true;
            this.bform_characters.Location = new System.Drawing.Point(629, 192);
            this.bform_characters.Name = "bform_characters";
            this.bform_characters.Size = new System.Drawing.Size(103, 13);
            this.bform_characters.TabIndex = 54;
            this.bform_characters.Text = "(max. 13 characters)";
            // 
            // std_phone
            // 
            this.std_phone.AutoSize = true;
            this.std_phone.Cursor = System.Windows.Forms.Cursors.Default;
            this.std_phone.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.std_phone.Location = new System.Drawing.Point(68, 210);
            this.std_phone.Name = "std_phone";
            this.std_phone.Size = new System.Drawing.Size(127, 21);
            this.std_phone.TabIndex = 53;
            this.std_phone.Text = "Phone Number";
            // 
            // std_phonebox
            // 
            this.std_phonebox.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.std_phonebox.Location = new System.Drawing.Point(203, 210);
            this.std_phonebox.Margin = new System.Windows.Forms.Padding(5);
            this.std_phonebox.Name = "std_phonebox";
            this.std_phonebox.Size = new System.Drawing.Size(150, 24);
            this.std_phonebox.TabIndex = 52;
            // 
            // bform
            // 
            this.bform.AutoSize = true;
            this.bform.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bform.Location = new System.Drawing.Point(461, 166);
            this.bform.Name = "bform";
            this.bform.Size = new System.Drawing.Size(65, 21);
            this.bform.TabIndex = 51;
            this.bform.Text = "B Form";
            // 
            // b_formbox
            // 
            this.b_formbox.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_formbox.Location = new System.Drawing.Point(566, 163);
            this.b_formbox.Margin = new System.Windows.Forms.Padding(5);
            this.b_formbox.Name = "b_formbox";
            this.b_formbox.Size = new System.Drawing.Size(150, 24);
            this.b_formbox.TabIndex = 50;
            // 
            // dateExample
            // 
            this.dateExample.AutoSize = true;
            this.dateExample.Location = new System.Drawing.Point(272, 187);
            this.dateExample.Name = "dateExample";
            this.dateExample.Size = new System.Drawing.Size(81, 13);
            this.dateExample.TabIndex = 49;
            this.dateExample.Text = "(YYYY-MM-DD)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 21);
            this.label1.TabIndex = 48;
            this.label1.Text = "Date of Birth";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(203, 158);
            this.textBox1.Margin = new System.Windows.Forms.Padding(5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 24);
            this.textBox1.TabIndex = 47;
            // 
            // classLabel
            // 
            this.classLabel.AutoSize = true;
            this.classLabel.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classLabel.Location = new System.Drawing.Point(440, 129);
            this.classLabel.Name = "classLabel";
            this.classLabel.Size = new System.Drawing.Size(99, 21);
            this.classLabel.TabIndex = 46;
            this.classLabel.Text = "Class Grade";
            // 
            // classgrade
            // 
            this.classgrade.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classgrade.Location = new System.Drawing.Point(566, 126);
            this.classgrade.Margin = new System.Windows.Forms.Padding(5);
            this.classgrade.Name = "classgrade";
            this.classgrade.Size = new System.Drawing.Size(150, 24);
            this.classgrade.TabIndex = 45;
            // 
            // fatherlable
            // 
            this.fatherlable.AutoSize = true;
            this.fatherlable.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fatherlable.Location = new System.Drawing.Point(77, 124);
            this.fatherlable.Name = "fatherlable";
            this.fatherlable.Size = new System.Drawing.Size(110, 21);
            this.fatherlable.TabIndex = 44;
            this.fatherlable.Text = "Father Name";
            // 
            // fathername
            // 
            this.fathername.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fathername.Location = new System.Drawing.Point(203, 121);
            this.fathername.Margin = new System.Windows.Forms.Padding(5);
            this.fathername.Name = "fathername";
            this.fathername.Size = new System.Drawing.Size(150, 24);
            this.fathername.TabIndex = 43;
            // 
            // LName
            // 
            this.LName.AutoSize = true;
            this.LName.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LName.Location = new System.Drawing.Point(448, 89);
            this.LName.Name = "LName";
            this.LName.Size = new System.Drawing.Size(91, 21);
            this.LName.TabIndex = 42;
            this.LName.Text = "Last Name";
            // 
            // lastname
            // 
            this.lastname.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastname.Location = new System.Drawing.Point(566, 87);
            this.lastname.Margin = new System.Windows.Forms.Padding(5);
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(150, 24);
            this.lastname.TabIndex = 41;
            // 
            // FName
            // 
            this.FName.AutoSize = true;
            this.FName.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FName.Location = new System.Drawing.Point(89, 91);
            this.FName.Name = "FName";
            this.FName.Size = new System.Drawing.Size(93, 21);
            this.FName.TabIndex = 40;
            this.FName.Text = "First Name";
            // 
            // firstname
            // 
            this.firstname.Location = new System.Drawing.Point(203, 91);
            this.firstname.Margin = new System.Windows.Forms.Padding(5);
            this.firstname.Name = "firstname";
            this.firstname.Size = new System.Drawing.Size(150, 20);
            this.firstname.TabIndex = 39;
            // 
            // RollNo
            // 
            this.RollNo.AutoSize = true;
            this.RollNo.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RollNo.Location = new System.Drawing.Point(282, 55);
            this.RollNo.Name = "RollNo";
            this.RollNo.Size = new System.Drawing.Size(106, 21);
            this.RollNo.TabIndex = 38;
            this.RollNo.Text = "Roll Number";
            // 
            // rollnumber
            // 
            this.rollnumber.BackColor = System.Drawing.SystemColors.Window;
            this.rollnumber.Location = new System.Drawing.Point(396, 55);
            this.rollnumber.Margin = new System.Windows.Forms.Padding(5);
            this.rollnumber.Name = "rollnumber";
            this.rollnumber.Size = new System.Drawing.Size(150, 20);
            this.rollnumber.TabIndex = 37;
            // 
            // studentdata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backbutton);
            this.Controls.Add(this.std_inf_label);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.feestatus);
            this.Controls.Add(this.genderlabel);
            this.Controls.Add(this.femaleradio);
            this.Controls.Add(this.maleradio);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.religioncombo);
            this.Controls.Add(this.religion);
            this.Controls.Add(this.province_label);
            this.Controls.Add(this.std_city);
            this.Controls.Add(this.citybox);
            this.Controls.Add(this.std_address);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.bform_characters);
            this.Controls.Add(this.std_phone);
            this.Controls.Add(this.std_phonebox);
            this.Controls.Add(this.bform);
            this.Controls.Add(this.b_formbox);
            this.Controls.Add(this.dateExample);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.classLabel);
            this.Controls.Add(this.classgrade);
            this.Controls.Add(this.fatherlable);
            this.Controls.Add(this.fathername);
            this.Controls.Add(this.LName);
            this.Controls.Add(this.lastname);
            this.Controls.Add(this.FName);
            this.Controls.Add(this.firstname);
            this.Controls.Add(this.RollNo);
            this.Controls.Add(this.rollnumber);
            this.Name = "studentdata";
            this.Text = "studentdata";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backbutton;
        private System.Windows.Forms.Label std_inf_label;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox feestatus;
        private System.Windows.Forms.Label genderlabel;
        private System.Windows.Forms.RadioButton femaleradio;
        private System.Windows.Forms.RadioButton maleradio;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox religioncombo;
        private System.Windows.Forms.Label religion;
        private System.Windows.Forms.Label province_label;
        private System.Windows.Forms.Label std_city;
        private System.Windows.Forms.TextBox citybox;
        private System.Windows.Forms.Label std_address;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label bform_characters;
        private System.Windows.Forms.Label std_phone;
        private System.Windows.Forms.TextBox std_phonebox;
        private System.Windows.Forms.Label bform;
        private System.Windows.Forms.TextBox b_formbox;
        private System.Windows.Forms.Label dateExample;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label classLabel;
        private System.Windows.Forms.TextBox classgrade;
        private System.Windows.Forms.Label fatherlable;
        private System.Windows.Forms.TextBox fathername;
        private System.Windows.Forms.Label LName;
        private System.Windows.Forms.TextBox lastname;
        private System.Windows.Forms.Label FName;
        private System.Windows.Forms.TextBox firstname;
        private System.Windows.Forms.Label RollNo;
        private System.Windows.Forms.TextBox rollnumber;
    }
}