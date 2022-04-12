namespace testFinal
{
    partial class PinjamBuku
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_issue = new System.Windows.Forms.Button();
            this.text_judul = new System.Windows.Forms.TextBox();
            this.button_back = new System.Windows.Forms.Button();
            this.text_student = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.listView2 = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Judul_buku = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Pengarang = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.search_judul = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Judul Buku";
            this.label1.Click += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tanggal Pinjam";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tanggal Kembali";
            // 
            // button_issue
            // 
            this.button_issue.Location = new System.Drawing.Point(131, 323);
            this.button_issue.Name = "button_issue";
            this.button_issue.Size = new System.Drawing.Size(75, 23);
            this.button_issue.TabIndex = 6;
            this.button_issue.Text = "Issue Book";
            this.button_issue.UseVisualStyleBackColor = true;
            this.button_issue.Click += new System.EventHandler(this.button1_Click);
            // 
            // text_judul
            // 
            this.text_judul.Location = new System.Drawing.Point(174, 263);
            this.text_judul.Name = "text_judul";
            this.text_judul.Size = new System.Drawing.Size(200, 20);
            this.text_judul.TabIndex = 7;
            this.text_judul.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button_back
            // 
            this.button_back.Location = new System.Drawing.Point(299, 323);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(75, 23);
            this.button_back.TabIndex = 8;
            this.button_back.Text = "Back";
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // text_student
            // 
            this.text_student.Location = new System.Drawing.Point(174, 52);
            this.text_student.Name = "text_student";
            this.text_student.Size = new System.Drawing.Size(200, 20);
            this.text_student.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Student Name";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(174, 86);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(174, 122);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 12;
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.Judul_buku,
            this.Pengarang});
            this.listView2.Location = new System.Drawing.Point(78, 148);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(296, 109);
            this.listView2.TabIndex = 13;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.SelectedIndexChanged += new System.EventHandler(this.listView2_SelectedIndexChanged);
            // 
            // id
            // 
            this.id.Text = "ID";
            // 
            // Judul_buku
            // 
            this.Judul_buku.Text = "Judul buku";
            // 
            // Pengarang
            // 
            this.Pengarang.Text = "Pengarang";
            // 
            // search_judul
            // 
            this.search_judul.Location = new System.Drawing.Point(174, 289);
            this.search_judul.Name = "search_judul";
            this.search_judul.Size = new System.Drawing.Size(75, 23);
            this.search_judul.TabIndex = 14;
            this.search_judul.Text = "Search";
            this.search_judul.UseVisualStyleBackColor = true;
            this.search_judul.Click += new System.EventHandler(this.search_judul_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(169, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 25);
            this.label5.TabIndex = 15;
            this.label5.Text = "Borrow Book";
            // 
            // PinjamBuku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::testFinal.Properties.Resources.libraries2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(464, 358);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.search_judul);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.text_student);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.text_judul);
            this.Controls.Add(this.button_issue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PinjamBuku";
            this.Text = "PinjamBuku";
            this.Shown += new System.EventHandler(this.PinjamBuku_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_issue;
        private System.Windows.Forms.TextBox text_judul;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.TextBox text_student;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Button search_judul;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader Judul_buku;
        private System.Windows.Forms.ColumnHeader Pengarang;
    }
}