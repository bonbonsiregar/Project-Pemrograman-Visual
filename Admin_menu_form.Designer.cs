namespace testFinal
{
    partial class Admin_menu_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_menu_form));
            this.button_add_book = new System.Windows.Forms.Button();
            this.button_add_User = new System.Windows.Forms.Button();
            this.button_signout = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button_history = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_add_book
            // 
            this.button_add_book.Location = new System.Drawing.Point(65, 85);
            this.button_add_book.Name = "button_add_book";
            this.button_add_book.Size = new System.Drawing.Size(120, 31);
            this.button_add_book.TabIndex = 0;
            this.button_add_book.Text = "Add Book";
            this.button_add_book.UseVisualStyleBackColor = true;
            this.button_add_book.Click += new System.EventHandler(this.button_add_book_Click);
            // 
            // button_add_User
            // 
            this.button_add_User.Location = new System.Drawing.Point(65, 205);
            this.button_add_User.Name = "button_add_User";
            this.button_add_User.Size = new System.Drawing.Size(120, 28);
            this.button_add_User.TabIndex = 1;
            this.button_add_User.Text = "Add User";
            this.button_add_User.UseVisualStyleBackColor = true;
            this.button_add_User.Click += new System.EventHandler(this.button_add_User_Click);
            // 
            // button_signout
            // 
            this.button_signout.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_signout.ForeColor = System.Drawing.Color.DarkRed;
            this.button_signout.Location = new System.Drawing.Point(341, 205);
            this.button_signout.Name = "button_signout";
            this.button_signout.Size = new System.Drawing.Size(120, 32);
            this.button_signout.TabIndex = 2;
            this.button_signout.Text = "Sign Out";
            this.button_signout.UseVisualStyleBackColor = false;
            this.button_signout.Click += new System.EventHandler(this.button_signout_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(341, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 31);
            this.button1.TabIndex = 3;
            this.button1.Text = "Borrow Book";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(215, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Welcome";
            // 
            // button_history
            // 
            this.button_history.Location = new System.Drawing.Point(211, 136);
            this.button_history.Name = "button_history";
            this.button_history.Size = new System.Drawing.Size(120, 35);
            this.button_history.TabIndex = 5;
            this.button_history.Text = "History Peminjaman";
            this.button_history.UseVisualStyleBackColor = true;
            this.button_history.Click += new System.EventHandler(this.button_history_Click);
            // 
            // Admin_menu_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::testFinal.Properties.Resources.libraries2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(534, 323);
            this.Controls.Add(this.button_history);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_signout);
            this.Controls.Add(this.button_add_User);
            this.Controls.Add(this.button_add_book);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Admin_menu_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin_menu_form";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Admin_menu_form_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_add_book;
        private System.Windows.Forms.Button button_add_User;
        private System.Windows.Forms.Button button_signout;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_history;
    }
}