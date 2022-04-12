namespace testFinal
{
    partial class User_Menu_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User_Menu_form));
            this.button_book_search = new System.Windows.Forms.Button();
            this.button_book_request = new System.Windows.Forms.Button();
            this.button_personal_identity = new System.Windows.Forms.Button();
            this.button_signout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_book_search
            // 
            this.button_book_search.Location = new System.Drawing.Point(81, 214);
            this.button_book_search.Name = "button_book_search";
            this.button_book_search.Size = new System.Drawing.Size(126, 27);
            this.button_book_search.TabIndex = 1;
            this.button_book_search.Text = "Book Search ";
            this.button_book_search.UseVisualStyleBackColor = true;
            this.button_book_search.Click += new System.EventHandler(this.button_book_search_Click);
            // 
            // button_book_request
            // 
            this.button_book_request.Location = new System.Drawing.Point(200, 176);
            this.button_book_request.Name = "button_book_request";
            this.button_book_request.Size = new System.Drawing.Size(126, 27);
            this.button_book_request.TabIndex = 2;
            this.button_book_request.Text = "Book Request";
            this.button_book_request.UseVisualStyleBackColor = true;
            this.button_book_request.Click += new System.EventHandler(this.button_book_request_Click);
            // 
            // button_personal_identity
            // 
            this.button_personal_identity.Location = new System.Drawing.Point(81, 138);
            this.button_personal_identity.Name = "button_personal_identity";
            this.button_personal_identity.Size = new System.Drawing.Size(125, 28);
            this.button_personal_identity.TabIndex = 0;
            this.button_personal_identity.Text = "Personal Identity";
            this.button_personal_identity.UseVisualStyleBackColor = true;
            this.button_personal_identity.Click += new System.EventHandler(this.button_personal_identity_Click);
            // 
            // button_signout
            // 
            this.button_signout.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_signout.ForeColor = System.Drawing.Color.DarkRed;
            this.button_signout.Location = new System.Drawing.Point(325, 209);
            this.button_signout.Name = "button_signout";
            this.button_signout.Size = new System.Drawing.Size(124, 32);
            this.button_signout.TabIndex = 3;
            this.button_signout.Text = "Sign Out";
            this.button_signout.UseVisualStyleBackColor = false;
            this.button_signout.Click += new System.EventHandler(this.button_signout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(211, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Welcome";
            // 
            // buttonReturn
            // 
            this.buttonReturn.Location = new System.Drawing.Point(325, 139);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(126, 27);
            this.buttonReturn.TabIndex = 5;
            this.buttonReturn.Text = "Return Book";
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // User_Menu_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::testFinal.Properties.Resources.libraries2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(509, 385);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_signout);
            this.Controls.Add(this.button_personal_identity);
            this.Controls.Add(this.button_book_request);
            this.Controls.Add(this.button_book_search);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "User_Menu_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User_Menu_form";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.User_Menu_form_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_book_search;
        private System.Windows.Forms.Button button_book_request;
        private System.Windows.Forms.Button button_personal_identity;
        private System.Windows.Forms.Button button_signout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonReturn;
    }
}