using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace testFinal
{
    public partial class book_request : Form
    {
        public book_request()
        {
            InitializeComponent();
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Hide();
            User_Menu_form user = new User_Menu_form();

            user.ShowDialog();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("server=127.0.0.1; database=perpus_db;username=root; password=;");

            string insertQuery = "INSERT INTO request_buku(judul_buku, pengarang) VALUES('"+ request_judulbuku.Text +"','" + request_pengarang.Text +"')";

            connection.Open();

            MySqlCommand command = new MySqlCommand(insertQuery, connection);

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Thank you for your request");
                request_judulbuku.Text = "";
                request_pengarang.Text = "";
            }
            else
            {
                MessageBox.Show("Data Not Inserted");
            }

            connection.Close();
        }
    }
}
