namespace School_Lms
{
    partial class search
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
            this.backbutton = new System.Windows.Forms.Button();
            this.searchbox = new System.Windows.Forms.TextBox();
            this.searchbutton = new System.Windows.Forms.Button();
            this.display = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pdf = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1206, 451);
            this.dataGridView1.TabIndex = 43;
            // 
            // backbutton
            // 
            this.backbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.backbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backbutton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.backbutton.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.backbutton.Location = new System.Drawing.Point(12, 11);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(66, 26);
            this.backbutton.TabIndex = 42;
            this.backbutton.Text = "Back";
            this.backbutton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.backbutton.UseVisualStyleBackColor = false;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // searchbox
            // 
            this.searchbox.Location = new System.Drawing.Point(281, 13);
            this.searchbox.Name = "searchbox";
            this.searchbox.Size = new System.Drawing.Size(394, 20);
            this.searchbox.TabIndex = 40;
            this.searchbox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.searchbox_KeyUp);
            // 
            // searchbutton
            // 
            this.searchbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.searchbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchbutton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbutton.ForeColor = System.Drawing.SystemColors.Control;
            this.searchbutton.Location = new System.Drawing.Point(681, 9);
            this.searchbutton.Name = "searchbutton";
            this.searchbutton.Size = new System.Drawing.Size(85, 26);
            this.searchbutton.TabIndex = 41;
            this.searchbutton.Text = "Search";
            this.searchbutton.UseVisualStyleBackColor = false;
            this.searchbutton.Click += new System.EventHandler(this.searchbutton_Click);
            // 
            // display
            // 
            this.display.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.display.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.display.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.display.Location = new System.Drawing.Point(772, 9);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(111, 26);
            this.display.TabIndex = 44;
            this.display.Text = "Display All";
            this.display.UseVisualStyleBackColor = false;
            this.display.Click += new System.EventHandler(this.display_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(126, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 19);
            this.label1.TabIndex = 45;
            this.label1.Text = "Enter Roll Number:";
            // 
            // pdf
            // 
            this.pdf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pdf.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pdf.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pdf.Location = new System.Drawing.Point(889, 10);
            this.pdf.Name = "pdf";
            this.pdf.Size = new System.Drawing.Size(111, 26);
            this.pdf.TabIndex = 46;
            this.pdf.Text = "Create PDF";
            this.pdf.UseVisualStyleBackColor = false;
            this.pdf.Click += new System.EventHandler(this.pdf_Click);
            // 
            // search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 450);
            this.Controls.Add(this.pdf);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.display);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.backbutton);
            this.Controls.Add(this.searchbutton);
            this.Controls.Add(this.searchbox);
            this.Name = "search";
            this.Text = "Search ";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button backbutton;
        private System.Windows.Forms.TextBox searchbox;
        private System.Windows.Forms.Button searchbutton;
        private System.Windows.Forms.Button display;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button pdf;
    }
}