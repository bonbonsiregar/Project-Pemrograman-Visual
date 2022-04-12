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
    public partial class PinjamBuku : Form
    {
        public PinjamBuku()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("server=127.0.0.1; database=perpus_db;username=root; password=;");

            string insertQuery = "INSERT INTO peminjaman_buku(student_name,tanggal_pinjam,tanggal_balikin,judul_buku) VALUES('" + text_student.Text + "','" + dateTimePicker1.Text + "','" + dateTimePicker2.Text + "','" + text_judul.Text + "')";
            string insertHistory = "INSERT INTO history(judul_buku,student_name,tanggal_pinjam) VALUES('" + text_judul.Text + "','" + text_student.Text + "','" + dateTimePicker1.Text + "')";
            connection.Open();

            MySqlCommand command = new MySqlCommand(insertQuery, connection);
            MySqlCommand command2 = new MySqlCommand(insertHistory, connection);

            if (command.ExecuteNonQuery() == 1 && command2.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Data Inserted");
                text_student.Text = "";
                text_judul.Text = "";
            }
            else
            {
                MessageBox.Show("Data Not Inserted");
            }

            connection.Close();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_back_Click(object sender, EventArgs e)
        {

            this.Close();
            this.Hide();
            Admin_menu_form user = new Admin_menu_form();

            user.ShowDialog();
        }

        private void PinjamBuku_Shown(object sender, EventArgs e)
        {
            listView2.View = View.Details;
            MySqlConnection con = new MySqlConnection("server=127.0.0.1; database=perpus_db;username=root; password=;");
            MySqlDataAdapter ada = new MySqlDataAdapter("select * from buku", con);
            DataTable dt = new DataTable();
            ada.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                ListViewItem listitem = new ListViewItem(dr["Id"].ToString());
                listitem.SubItems.Add(dr["Judul_buku"].ToString());
                listitem.SubItems.Add(dr["pengarang"].ToString());
                listView2.Items.Add(listitem);
            }
        }

        private void search_judul_Click(object sender, EventArgs e)
        {
            listView2.View = View.Details;
            MySqlConnection con = new MySqlConnection("server=127.0.0.1; database=perpus_db;username=root; password=;");
            MySqlDataAdapter list = new MySqlDataAdapter("select * from buku where Judul_buku like '%" + text_judul.Text + "%'", con);
            DataTable dt1 = new DataTable();
            listView2.Items.Clear();
            list.Fill(dt1);
            for (int i = 0; i < dt1.Rows.Count; i++)
            {
                DataRow dr = dt1.Rows[i];
                ListViewItem listitem = new ListViewItem(dr["Id"].ToString());
                listitem.SubItems.Add(dr["Judul_buku"].ToString());
                listitem.SubItems.Add(dr["pengarang"].ToString());
                //listitem.SubItems.Add(dr["stock"].ToString());
                listView2.Items.Add(listitem);
            }
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
