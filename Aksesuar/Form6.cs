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
    public partial class Form6 : Form
    {
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-FRPNK3P;Initial Catalog=aksesuar;Integrated Security=True");
        public Form6()
        {
            InitializeComponent();
        }

        public Form4 form4;

        private void delbtn_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("delete from satis where satisid=@satisid", baglan);
            komut.Parameters.AddWithValue("@satisid", satisidtxt.Text);
            komut.ExecuteNonQuery();
            baglan.Close();
            form4.show();
            form4.Show();
            this.Hide();
        }

        private void Form6_FormClosed(object sender, FormClosedEventArgs e)
        {
            form4.Show();
        }
    }
}
