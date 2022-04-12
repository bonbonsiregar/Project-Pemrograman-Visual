using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace testFinal
{
    public partial class Welcome_menu : Form
    {
        public Welcome_menu()
        {
            InitializeComponent();
            textBox_pass.PasswordChar = '*';
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            int count = 0;
            MySqlConnection connection = new MySqlConnection("server=127.0.0.1; database=perpus_db;username=root; password=;");

            MySqlCommand command = new MySqlCommand("select * from identitas where Nama='" + textBox_userN.Text + "'and Password='" + textBox_pass.Text + "';",connection);


            MySqlDataReader mdr;
            connection.Open();
            mdr = command.ExecuteReader();
            while (mdr.Read()) {
                count++;
            }

            if (textBox_userN.Text == "admin"
                && textBox_pass.Text == "admin")
            {
                Admin_menu_form admin = new Admin_menu_form();

                this.Hide();
                admin.ShowDialog();
            }
            else if(count ==1 ){

                User_Menu_form user = new User_Menu_form();

                this.Hide();
                user.ShowDialog();
            }
            else {               
                MessageBox.Show("username and password incorect","Error");
            }
            connection.Close();
        }
    }
}
