namespace testFinal
{
    partial class history
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.judul_buku = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.student_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tanggal_pinjam = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button_search = new System.Windows.Forms.Button();
            this.button_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(119, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "History Peminjaman";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.judul_buku,
            this.student_name,
            this.tanggal_pinjam});
            this.listView1.Location = new System.Drawing.Point(57, 71);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(385, 188);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // judul_buku
            // 
            this.judul_buku.Text = "Judul Buku";
            this.judul_buku.Width = 123;
            // 
            // student_name
            // 
            this.student_name.Text = "Nama Peminjam";
            this.student_name.Width = 135;
            // 
            // tanggal_pinjam
            // 
            this.tanggal_pinjam.Text = "Tanggal Peminjaman";
            this.tanggal_pinjam.Width = 118;
            // 
            // button_search
            // 
            this.button_search.Location = new System.Drawing.Point(124, 285);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(108, 23);
            this.button_search.TabIndex = 2;
            this.button_search.Text = "Search";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_back_Click);
            // 
            // button_back
            // 
            this.button_back.Location = new System.Drawing.Point(256, 285);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(108, 23);
            this.button_back.TabIndex = 3;
            this.button_back.Text = "Back";
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.button_back_Click_1);
            // 
            // history
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 320);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Name = "history";
            this.Text = "history";
            this.Load += new System.EventHandler(this.history_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader judul_buku;
        private System.Windows.Forms.ColumnHeader student_name;
        private System.Windows.Forms.ColumnHeader tanggal_pinjam;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.Button button_back;

    }
}