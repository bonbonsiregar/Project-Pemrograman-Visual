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
    public partial class history : Form
    {
        public history()
        {
            InitializeComponent();
        }

        private void history_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_back_Click(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            MySqlConnection con = new MySqlConnection("server=127.0.0.1; database=perpus_db;username=root; password=;");
            MySqlDataAdapter list = new MySqlDataAdapter("select * from history", con);
            DataTable dt = new DataTable();
            list.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                ListViewItem listitem = new ListViewItem(dr["judul_buku"].ToString());
                listitem.SubItems.Add(dr["student_name"].ToString());
                listitem.SubItems.Add(dr["tanggal_pinjam"].ToString());
                listView1.Items.Add(listitem);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button_back_Click_1(object sender, EventArgs e)
        {
            this.Close();
            this.Hide();
            Admin_menu_form user = new Admin_menu_form();

            user.ShowDialog();
        }
    }
}
