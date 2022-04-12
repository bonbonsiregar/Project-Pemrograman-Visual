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
    public partial class Admin_menu_form : Form
    {
        public Admin_menu_form()
        {
            InitializeComponent();
        }

        private void Admin_menu_form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button_add_book_Click(object sender, EventArgs e)
        {
            Add_Book_form addbook = new Add_Book_form();

            this.Hide();
            addbook.ShowDialog();
        }

        private void button_add_User_Click(object sender, EventArgs e)
        {
            Add_User_form adduser = new Add_User_form();

            this.Hide();
            adduser.ShowDialog();
        }

        private void button_signout_Click(object sender, EventArgs e)
        {
            Welcome_menu welcome = new Welcome_menu();
            this.Hide();
            this.Close();
            welcome.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PinjamBuku pinjam = new PinjamBuku();
            this.Hide();
            this.Close();
            pinjam.ShowDialog();
        }

        private void button_history_Click(object sender, EventArgs e)
        {
            history his = new history();
            this.Hide();
            this.Close();
            his.ShowDialog();
        }
    }
}
