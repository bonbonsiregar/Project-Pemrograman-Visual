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
    public partial class book_list : Form
    {
        public book_list()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            MySqlConnection con = new MySqlConnection("server=127.0.0.1; database=perpus_db;username=root; password=;");
            MySqlDataAdapter list = new MySqlDataAdapter("select * from buku where Judul_buku like '%"+ search.Text+"%'", con);
            DataTable dt1 = new DataTable();
            listView1.Items.Clear();
            list.Fill(dt1);
            for (int i = 0; i < dt1.Rows.Count; i++)
            {
                DataRow dr = dt1.Rows[i];
                ListViewItem listitem = new ListViewItem(dr["Id"].ToString());
                listitem.SubItems.Add(dr["Judul_buku"].ToString());
                listitem.SubItems.Add(dr["pengarang"].ToString());
                listitem.SubItems.Add(dr["stock"].ToString());
                listView1.Items.Add(listitem);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Close();
            this.Hide();
            User_Menu_form user = new User_Menu_form();

            user.ShowDialog();
        }

        private void book_list_Shown(object sender, EventArgs e)
        {
            listView1.View = View.Details;
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
                listView1.Items.Add(listitem);
            }
        }
    }
}
