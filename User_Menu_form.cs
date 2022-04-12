using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace testFinal
{
    public partial class User_Menu_form : Form
    {
        public User_Menu_form()
        {
            InitializeComponent();
        }

        private void User_Menu_form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


        private void button_signout_Click(object sender, EventArgs e)
        {
            Welcome_menu welcome = new Welcome_menu();
            this.Hide();
            this.Close();
            welcome.ShowDialog();
        }

        private void button_personal_identity_Click(object sender, EventArgs e)
        {
            personal_identity pi = new personal_identity();
            this.Hide();
            this.Close();
            pi.ShowDialog();
        }

        private void button_book_search_Click(object sender, EventArgs e)
        {
            book_list book_list = new book_list();
            this.Hide();
            this.Close();
            book_list.ShowDialog();
        }

        private void button_book_request_Click(object sender, EventArgs e)
        {
            book_request req = new book_request();
            this.Hide();
            this.Close();
            req.ShowDialog();
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            ReturnBook ret = new ReturnBook();
            this.Hide();
            this.Close();
            ret.ShowDialog();
        }
    }
}
