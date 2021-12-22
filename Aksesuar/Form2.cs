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
    public partial class Form2 : Form
    {
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-FRPNK3P;Initial Catalog=aksesuar;Integrated Security=True");
        public Form2()
        {
            InitializeComponent();
        }

        public Form1 form1;
        public int boolean = 0;
        /*//public string id = "";
        public string cesid = "";
        public string marka = "";
        public string getirilme_tarixi = "";
        public string sayi = "";
        public string alis_qiymeti = "";
        public string satis_qiymeti = "";
        public string elave_melumat = "";*/
        private void Form2_Load(object sender, EventArgs e)
        {
            cesidtxt.Text = General.Alis.cesid;
            markatxt.Text = General.Alis.marka;
            getirilme_tarixitxt.Text = General.Alis.getirilme_tarixi;
            sayitxt.Text = General.Alis.sayi;
            alis_qiymetitxt.Text = General.Alis.alis_qiymeti;
            satis_qiymetitxt.Text = General.Alis.satis_qiymeti;
            elave_melumattxt.Text = General.Alis.elave_melumat;
            /*cesidtxt.Text = cesid;
            markatxt.Text = marka;
            getirilme_tarixitxt.Text = getirilme_tarixi;
            sayitxt.Text = sayi;
            alis_qiymetitxt.Text = alis_qiymeti;
            satis_qiymetitxt.Text = satis_qiymeti;
            elave_melumattxt.Text = elave_melumat;*/
            if (boolean == 1) addorupdbtn.Text = "Əlavə et";
            else if (boolean == 2) addorupdbtn.Text = "Yenilə";
        }

        private void addorupdbtn_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut;
            if(!(cesidtxt.Text == "" || sayitxt.Text == "" || alis_qiymetitxt.Text == "" | satis_qiymetitxt.Text == ""))
            {
                if (Convert.ToInt32(sayitxt.Text) > 0 && Convert.ToInt32(satis_qiymetitxt.Text) > 0)
                {
                    if (boolean == 1)
                    {
                        komut = new SqlCommand("insert into alis(cesid,marka,getirilme_tarixi,sayi,alis_qiymeti,satis_qiymeti,elave_melumat) values(@cesid,@marka,@getirilme_tarixi,@sayi,@alis_qiymeti,@satis_qiymeti,@elave_melumat)", baglan);
                        komut.Parameters.AddWithValue("@cesid", cesidtxt.Text);
                        komut.Parameters.AddWithValue("@marka", markatxt.Text);
                        if (getirilme_tarixitxt.Text == "")
                        {
                            getirilme_tarixitxt.Text = DateTime.Now.ToString("yyyy'-'MM'-'dd");
                        }
                        komut.Parameters.AddWithValue("@getirilme_tarixi", getirilme_tarixitxt.Text);
                        komut.Parameters.AddWithValue("@sayi", sayitxt.Text);
                        komut.Parameters.AddWithValue("@alis_qiymeti", alis_qiymetitxt.Text);
                        komut.Parameters.AddWithValue("@satis_qiymeti", satis_qiymetitxt.Text);
                        komut.Parameters.AddWithValue("@elave_melumat", elave_melumattxt.Text);
                        komut.ExecuteNonQuery();
                    }
                    else if (boolean == 2)
                    {
                        komut = new SqlCommand("update alis set cesid=@cesid,marka=@marka,getirilme_tarixi=@getirilme_tarixi,sayi=@sayi,alis_qiymeti=@alis_qiymeti,satis_qiymeti=@satis_qiymeti,elave_melumat=@elave_melumat where id=@id", baglan);
                        komut.Parameters.AddWithValue("@id", General.Alis.id);
                        //komut.Parameters.AddWithValue("@id", id);
                        komut.Parameters.AddWithValue("@cesid", cesidtxt.Text);
                        komut.Parameters.AddWithValue("@marka", markatxt.Text);
                        komut.Parameters.AddWithValue("@getirilme_tarixi", getirilme_tarixitxt.Text);
                        komut.Parameters.AddWithValue("@sayi", sayitxt.Text);
                        komut.Parameters.AddWithValue("@alis_qiymeti", alis_qiymetitxt.Text);
                        komut.Parameters.AddWithValue("@satis_qiymeti", satis_qiymetitxt.Text);
                        komut.Parameters.AddWithValue("@elave_melumat", elave_melumattxt.Text);
                        komut.ExecuteNonQuery();
                    }
                    form1.show();
                    form1.Show();
                    this.Hide();
                }
                else MessageBox.Show("Müsbət ədəd daxil etdiyinizdən əmin olun!");
            }
            else MessageBox.Show("Boş yerləri doldurun!");
            baglan.Close();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            form1.Show();
        }
    }
}
