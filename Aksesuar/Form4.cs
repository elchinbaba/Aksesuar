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
    public partial class Form4 : Form
    {
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-FRPNK3P;Initial Catalog=aksesuar;Integrated Security=True");
        public Form4()
        {
            InitializeComponent();
        }

        public Form1 form1;

        public void show()
        {
            satisdGV.DataSource = General.Show("satis");
        }

        private void shwbtn_Click(object sender, EventArgs e)
        {
            show();
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            Form5 yeni = new Form5();
            yeni.form4 = this;
            yeni.boolean = 1;
            yeni.Show();
            this.Hide();
        }

        private void satisdGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = satisdGV.SelectedCells[0].RowIndex;

            Form5 yeni = new Form5();
            yeni.form4 = this;
            General.Satis.satisid = satisdGV.Rows[secilen].Cells[0].Value.ToString();
            General.Satis.alisid = satisdGV.Rows[secilen].Cells[1].Value.ToString();
            General.Satis.sayi = satisdGV.Rows[secilen].Cells[2].Value.ToString();
            General.Satis.qiymeti = satisdGV.Rows[secilen].Cells[3].Value.ToString();
            General.Satis.tarixi = satisdGV.Rows[secilen].Cells[4].Value.ToString();
            /*yeni.satisid = satisdGV.Rows[secilen].Cells[0].Value.ToString();
            yeni.alisid = satisdGV.Rows[secilen].Cells[1].Value.ToString();
            yeni.sayi = satisdGV.Rows[secilen].Cells[2].Value.ToString();
            yeni.qiymeti = satisdGV.Rows[secilen].Cells[3].Value.ToString();
            yeni.tarixi = satisdGV.Rows[secilen].Cells[4].Value.ToString();*/
            yeni.boolean = 2;
            yeni.Show();
        }

        private void srchbtn_Click(object sender, EventArgs e)
        {
            string search = srchtxt.Text;
            SqlDataAdapter da = new SqlDataAdapter("select * from satis where satisid like '%"+search+"%' or alisid like '%"+search+"%' or sayi like '%"+search+"%' or qiymeti like '%"+search+"%' or tarixi like '%"+search+"%'", baglan);
            DataSet ds = new DataSet();
            da.Fill(ds);
            satisdGV.DataSource = ds.Tables[0];
        }

        private void delbtn_Click(object sender, EventArgs e)
        {
            Form6 yeni = new Form6();
            yeni.form4 = this;
            yeni.Show();
            this.Hide();
        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            form1.Show();
        }

        private void qruplaşdırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select alisid, sum(sayi) as Sayi, sum(sayi*qiymeti) as Qiymeti, sum(sayi*qiymeti)/sum(sayi) as Ortalama from satis group by alisid", baglan);
            DataSet ds = new DataSet();
            da.Fill(ds);
            satisdGV.DataSource=ds.Tables[0];
        }
    }
}
