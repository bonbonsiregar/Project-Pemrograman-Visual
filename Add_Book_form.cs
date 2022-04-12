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
    public partial class Add_Book_form : Form
    {
        public Add_Book_form()
        {
            InitializeComponent();
        }

        private void Add_Book_form_FormClosed(object sender, FormClosedEventArgs e)
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
            MySqlConnection connection = new MySqlConnection("server=127.0.0.1; database=perpus_db;username=root; password=;");

            string insertQuery = "INSERT INTO buku(Id,Judul_buku,Pengarang,stock) VALUES('" + int.Parse(textBox_Id.Text) + "','" + textBox_judulbuku.Text + "','" + textBox_pengarang.Text + "','"+  int.Parse(textBox_stock.Text) +"')";

            connection.Open();

            MySqlCommand command = new MySqlCommand(insertQuery, connection);

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Data Inserted");
                textBox_Id.Text = "";
                textBox_judulbuku.Text = "";
                textBox_pengarang.Text = "";
                textBox_stock.Text = "";
            }
            else
            {
                MessageBox.Show("Data Not Inserted");
            }

            connection.Close();
        }

        private void Add_Book_form_Load(object sender, EventArgs e)
        {

        }
    }
}
