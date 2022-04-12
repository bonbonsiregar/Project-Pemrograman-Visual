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
    public partial class Add_User_form : Form
    {
        

        public Add_User_form()
        {
            InitializeComponent();
            textBox_pass.PasswordChar = '*';
        }

        private void Add_User_form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Hide();
            Admin_menu_form admin = new Admin_menu_form();

            admin.ShowDialog();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            if (textBox_pass == textBox_confpass)
            {
                MySqlConnection connection = new MySqlConnection("server=127.0.0.1; database=perpus_db;username=root; password=;");

                string insertQuery = "INSERT INTO identitas(Nama,Nim,Jurusan,Email,Angkatan,No_telpn,Password) VALUES('" + textBox_nama.Text + "','" + textBox_nim.Text + "','" + comboBox_jurusan.Text + "','" + textBox_email.Text + "','" + comboBox_angkatan.Text + "','" + textBox_telpn.Text + "','" + textBox_pass.Text + "')";

                connection.Open();

                MySqlCommand command = new MySqlCommand(insertQuery, connection);

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Data Inserted");
                    textBox_nama.Text = "";
                    textBox_nim.Text = "";
                    comboBox_jurusan.Text = "";
                    textBox_email.Text = "";
                    comboBox_angkatan.Text = "";
                    textBox_telpn.Text = "";
                    textBox_pass.Text = "";
                }
                else
                {
                    MessageBox.Show("Data Not Inserted");
                }
           
            connection.Close();
             }
            else MessageBox.Show("Incorrect password");


        }

        private void textBox_jurusan_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
