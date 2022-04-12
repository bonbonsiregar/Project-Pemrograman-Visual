namespace testFinal
{
    partial class ReturnBook
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
            this.return_name = new System.Windows.Forms.Label();
            this.ret_judul = new System.Windows.Forms.Label();
            this.text_name = new System.Windows.Forms.TextBox();
            this.text_judul = new System.Windows.Forms.TextBox();
            this.button_return = new System.Windows.Forms.Button();
            this.button_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // return_name
            // 
            this.return_name.AutoSize = true;
            this.return_name.Location = new System.Drawing.Point(92, 46);
            this.return_name.Name = "return_name";
            this.return_name.Size = new System.Drawing.Size(75, 13);
            this.return_name.TabIndex = 0;
            this.return_name.Text = "Student Name";
            // 
            // ret_judul
            // 
            this.ret_judul.AutoSize = true;
            this.ret_judul.Location = new System.Drawing.Point(92, 107);
            this.ret_judul.Name = "ret_judul";
            this.ret_judul.Size = new System.Drawing.Size(60, 13);
            this.ret_judul.TabIndex = 1;
            this.ret_judul.Text = "Judul Buku";
            // 
            // text_name
            // 
            this.text_name.Location = new System.Drawing.Point(190, 46);
            this.text_name.Name = "text_name";
            this.text_name.Size = new System.Drawing.Size(140, 20);
            this.text_name.TabIndex = 2;
            // 
            // text_judul
            // 
            this.text_judul.Location = new System.Drawing.Point(190, 100);
            this.text_judul.Name = "text_judul";
            this.text_judul.Size = new System.Drawing.Size(140, 20);
            this.text_judul.TabIndex = 3;
            // 
            // button_return
            // 
            this.button_return.Location = new System.Drawing.Point(190, 171);
            this.button_return.Name = "button_return";
            this.button_return.Size = new System.Drawing.Size(75, 23);
            this.button_return.TabIndex = 4;
            this.button_return.Text = "Return";
            this.button_return.UseVisualStyleBackColor = true;
            this.button_return.Click += new System.EventHandler(this.button_return_Click);
            // 
            // button_back
            // 
            this.button_back.Location = new System.Drawing.Point(190, 209);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(75, 23);
            this.button_back.TabIndex = 5;
            this.button_back.Text = "Back";
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // ReturnBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 288);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.button_return);
            this.Controls.Add(this.text_judul);
            this.Controls.Add(this.text_name);
            this.Controls.Add(this.ret_judul);
            this.Controls.Add(this.return_name);
            this.Name = "ReturnBook";
            this.Text = "ReturnBook";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label return_name;
        private System.Windows.Forms.Label ret_judul;
        private System.Windows.Forms.TextBox text_name;
        private System.Windows.Forms.TextBox text_judul;
        private System.Windows.Forms.Button button_return;
        private System.Windows.Forms.Button button_back;
    }
}