namespace testFinal
{
    partial class book_request
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
            this.button_back = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.request_pengarang = new System.Windows.Forms.TextBox();
            this.request_judulbuku = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_back
            // 
            this.button_back.Location = new System.Drawing.Point(255, 186);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(106, 25);
            this.button_back.TabIndex = 17;
            this.button_back.Text = "Back";
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(153, 186);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(89, 25);
            this.button_add.TabIndex = 16;
            this.button_add.Text = "Request";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // request_pengarang
            // 
            this.request_pengarang.Location = new System.Drawing.Point(249, 125);
            this.request_pengarang.Name = "request_pengarang";
            this.request_pengarang.Size = new System.Drawing.Size(106, 20);
            this.request_pengarang.TabIndex = 15;
            // 
            // request_judulbuku
            // 
            this.request_judulbuku.Location = new System.Drawing.Point(249, 97);
            this.request_judulbuku.Name = "request_judulbuku";
            this.request_judulbuku.Size = new System.Drawing.Size(106, 20);
            this.request_judulbuku.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(159, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Pengarang";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Judul Buku";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(176, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Book Request";
            // 
            // book_request
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::testFinal.Properties.Resources.libraries2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(501, 404);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.request_pengarang);
            this.Controls.Add(this.request_judulbuku);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "book_request";
            this.Text = "book_request";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.TextBox request_pengarang;
        private System.Windows.Forms.TextBox request_judulbuku;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}