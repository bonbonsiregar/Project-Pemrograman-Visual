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
    public partial class ReturnBook : Form
    {
        public ReturnBook()
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

        private void button_return_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("server=127.0.0.1; database=perpus_db;username=root; password=;");

            string returnQuery = "delete from peminjaman_buku where student_name like '" + text_name.Text + "' AND judul_buku like '" + text_judul.Text + "'";

            connection.Open();

            MySqlCommand command = new MySqlCommand(returnQuery, connection);

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Thank you for returning your book");
                text_name.Text = "";
                text_judul.Text = "";
            }
            else
            {
                MessageBox.Show("Data Not valid");
            }

            connection.Close();
        }
    }
}
