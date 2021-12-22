using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Aksesuar
{
    public partial class Form3 : Form
    {
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-FRPNK3P;Initial Catalog=aksesuar;Integrated Security=True");
        public Form3()
        {
            InitializeComponent();
        }
        public Form1 form1;
        private void delbtn_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("delete from alis where id=@id", baglan);
            komut.Parameters.AddWithValue("@id", idtxt.Text);
            komut.ExecuteNonQuery();
            baglan.Close();
            form1.show();
            form1.Show();
            this.Hide();
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            form1.Show();
        }
    }
}
