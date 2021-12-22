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
    public partial class Form1 : Form
    {
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-FRPNK3P;Initial Catalog=aksesuar;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }
        public void show()
        {
            alisdGV.DataSource = General.Show("alis");
        }
        private void shwbtn_Click(object sender, EventArgs e)
        {
            show();
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            Form2 yeni = new Form2();
            yeni.form1 = this;
            yeni.boolean = 1;
            yeni.Show();
            this.Hide();
        }

        private void delbtn_Click(object sender, EventArgs e)
        {
            Form3 yeni = new Form3();
            yeni.form1 = this;
            yeni.Show();
            this.Hide();
        }

        private void srchbtn_Click(object sender, EventArgs e)
        {
            string search = srchtxt.Text;
            SqlDataAdapter da = new SqlDataAdapter("Select * from alis where id like '%" + search + "%' or cesid like '%" + search + "%' or marka like '%" + search + "%' or getirilme_tarixi like '%" + search + "%' or sayi like '%" + search + "%' or alis_qiymeti like '%" + search + "%' or satis_qiymeti like '%" + search + "%' or elave_melumat like '%" + search + "%'", baglan);
            DataSet ds = new DataSet();
            da.Fill(ds);
            alisdGV.DataSource = ds.Tables[0];
        }

        private void anbardGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = alisdGV.SelectedCells[0].RowIndex;

            Form2 yeni = new Form2();
            yeni.form1 = this;
            General.Alis.id = alisdGV.Rows[secilen].Cells[0].Value.ToString();
            General.Alis.cesid = alisdGV.Rows[secilen].Cells[1].Value.ToString();
            General.Alis.marka = alisdGV.Rows[secilen].Cells[2].Value.ToString();
            General.Alis.getirilme_tarixi = alisdGV.Rows[secilen].Cells[3].Value.ToString();
            General.Alis.sayi = alisdGV.Rows[secilen].Cells[4].Value.ToString();
            General.Alis.alis_qiymeti = alisdGV.Rows[secilen].Cells[5].Value.ToString();
            General.Alis.satis_qiymeti = alisdGV.Rows[secilen].Cells[6].Value.ToString();
            General.Alis.elave_melumat = alisdGV.Rows[secilen].Cells[7].Value.ToString();
            /*yeni.id = alisdGV.Rows[secilen].Cells[0].Value.ToString();
            yeni.cesid = alisdGV.Rows[secilen].Cells[1].Value.ToString();
            yeni.marka = alisdGV.Rows[secilen].Cells[2].Value.ToString();
            yeni.getirilme_tarixi = alisdGV.Rows[secilen].Cells[3].Value.ToString();
            yeni.sayi = alisdGV.Rows[secilen].Cells[4].Value.ToString();
            yeni.alis_qiymeti = alisdGV.Rows[secilen].Cells[5].Value.ToString();
            yeni.satis_qiymeti = alisdGV.Rows[secilen].Cells[6].Value.ToString();
            yeni.elave_melumat = alisdGV.Rows[secilen].Cells[7].Value.ToString();*/
            yeni.boolean = 2;
            yeni.Show();
        }

        private void sellwdwbtn_Click(object sender, EventArgs e)
        {
            Form4 yeni = new Form4();
            yeni.form1 = this;
            yeni.Show();
            this.Hide();
        }
    }
}
