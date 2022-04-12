namespace testFinal
{
    partial class Add_Book_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Book_form));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Id = new System.Windows.Forms.TextBox();
            this.textBox_judulbuku = new System.Windows.Forms.TextBox();
            this.textBox_pengarang = new System.Windows.Forms.TextBox();
            this.button_add = new System.Windows.Forms.Button();
            this.button_back = new System.Windows.Forms.Button();
            this.textBox_stock = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Judul Buku";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pengarang";
            // 
            // textBox_Id
            // 
            this.textBox_Id.Location = new System.Drawing.Point(199, 102);
            this.textBox_Id.Name = "textBox_Id";
            this.textBox_Id.Size = new System.Drawing.Size(106, 20);
            this.textBox_Id.TabIndex = 3;
            // 
            // textBox_judulbuku
            // 
            this.textBox_judulbuku.Location = new System.Drawing.Point(199, 134);
            this.textBox_judulbuku.Name = "textBox_judulbuku";
            this.textBox_judulbuku.Size = new System.Drawing.Size(106, 20);
            this.textBox_judulbuku.TabIndex = 4;
            // 
            // textBox_pengarang
            // 
            this.textBox_pengarang.Location = new System.Drawing.Point(199, 162);
            this.textBox_pengarang.Name = "textBox_pengarang";
            this.textBox_pengarang.Size = new System.Drawing.Size(106, 20);
            this.textBox_pengarang.TabIndex = 5;
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(97, 239);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(89, 25);
            this.button_add.TabIndex = 6;
            this.button_add.Text = "add";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_back
            // 
            this.button_back.Location = new System.Drawing.Point(199, 239);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(106, 25);
            this.button_back.TabIndex = 7;
            this.button_back.Text = "back";
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // textBox_stock
            // 
            this.textBox_stock.Location = new System.Drawing.Point(199, 188);
            this.textBox_stock.Name = "textBox_stock";
            this.textBox_stock.Size = new System.Drawing.Size(106, 20);
            this.textBox_stock.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(109, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Jumlah Stock";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(194, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Add Book";
            // 
            // Add_Book_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::testFinal.Properties.Resources.libraries2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(466, 363);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_stock);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.textBox_pengarang);
            this.Controls.Add(this.textBox_judulbuku);
            this.Controls.Add(this.textBox_Id);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Add_Book_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add_Book_form";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Add_Book_form_FormClosed);
            this.Load += new System.EventHandler(this.Add_Book_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Id;
        private System.Windows.Forms.TextBox textBox_judulbuku;
        private System.Windows.Forms.TextBox textBox_pengarang;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.TextBox textBox_stock;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}