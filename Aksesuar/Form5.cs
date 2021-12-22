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
    public partial class Form5 : Form
    {
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-FRPNK3P;Initial Catalog=aksesuar;Integrated Security=True");
        public Form5()
        {
            InitializeComponent();
        }

        public Form4 form4;
        public int boolean = 0;
        /*public string satisid = "";
        public string alisid = "";
        public string sayi = "";
        public string qiymeti = "";
        public string tarixi = "";*/

        private void addorupdbtn_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut;
            if (!(alisidtxt.Text == "" || sayitxt.Text == "" || qiymetitxt.Text == ""))
            {
                if (Convert.ToInt32(sayitxt.Text) > 0 && Convert.ToInt32(qiymetitxt.Text) > 0)
                {
                    bool q = false;
                    SqlCommand sqlCommand = new SqlCommand("select id from alis", baglan);
                    SqlDataReader sqldr = sqlCommand.ExecuteReader();
                    while (sqldr.Read())
                    {
                        if (alisidtxt.Text == sqldr[0].ToString())
                        {
                            q = true;
                        }
                    }
                    sqldr.Close();
                    if (baglan.State == ConnectionState.Closed) baglan.Open();
                    if (q)
                    {
                        if (boolean == 1)
                        {
                            komut = new SqlCommand("insert into satis(alisid,sayi,qiymeti,tarixi) values(@alisid,@sayi,@qiymeti,@tarixi)", baglan);
                            komut.Parameters.AddWithValue("@alisid", alisidtxt.Text);
                            komut.Parameters.AddWithValue("@sayi", sayitxt.Text);
                            {
                                int say = Convert.ToInt32(sayitxt.Text);
                                SqlCommand command = new SqlCommand("select sayi from satis where alisid=" + alisidtxt.Text, baglan);
                                SqlDataReader dr = command.ExecuteReader();
                                while (dr.Read())
                                {
                                    say += Convert.ToInt32(dr[0]);
                                }
                                command = new SqlCommand("select sayi from alis where id=" + alisidtxt.Text, baglan);
                                dr.Close();
                                dr = command.ExecuteReader();
                                int limit = 0;
                                while (dr.Read())
                                {
                                    limit = Convert.ToInt32(dr[0]);
                                }
                                dr.Close();
                                baglan.Close();
                                if (say > limit)
                                {
                                    MessageBox.Show("Anbarda yetərincə mal yoxdur!");
                                    return;
                                }
                            }
                            komut.Parameters.AddWithValue("@qiymeti", qiymetitxt.Text);
                            if (tarixitxt.Text == "")
                            {
                                tarixitxt.Text = DateTime.Now.ToString("yyyy'-'MM'-'dd");
                            }
                            komut.Parameters.AddWithValue("@tarixi", tarixitxt.Text);
                            if (baglan.State == ConnectionState.Closed) baglan.Open();
                            komut.ExecuteNonQuery();
                        }
                        else if (boolean == 2)
                        {
                            komut = new SqlCommand("update satis set alisid=@alisid, sayi=@sayi, qiymeti=@qiymeti,tarixi=@tarixi where satisid=@satisid", baglan);
                            komut.Parameters.AddWithValue("@alisid", alisidtxt.Text);
                            komut.Parameters.AddWithValue("@sayi", sayitxt.Text);
                            if (Convert.ToInt32(sayitxt.Text) > Convert.ToInt32(General.Satis.sayi))
                            //if (Convert.ToInt32(sayitxt.Text) > Convert.ToInt32(sayi))
                            {
                                int say = Convert.ToInt32(sayitxt.Text);
                                SqlCommand command = new SqlCommand("select sayi from satis where alisid=" + alisidtxt.Text, baglan);
                                SqlDataReader dr = command.ExecuteReader();
                                while (dr.Read())
                                {
                                    say += Convert.ToInt32(dr[0]);
                                }
                                command = new SqlCommand("select sayi from alis where id=" + alisidtxt.Text, baglan);
                                dr.Close();
                                dr = command.ExecuteReader();
                                int limit = 0;
                                while (dr.Read())
                                {
                                    limit = Convert.ToInt32(dr[0]);
                                }
                                dr.Close();
                                baglan.Close();
                                if (say > limit)
                                {
                                    MessageBox.Show("Anbarda yetərincə mal yoxdur!");
                                    return;
                                }
                            }
                            komut.Parameters.AddWithValue("@qiymeti", qiymetitxt.Text);
                            komut.Parameters.AddWithValue("@tarixi", tarixitxt.Text);
                            komut.Parameters.AddWithValue("@satisid", General.Satis.satisid);
                            //komut.Parameters.AddWithValue("@satisid", satisid);
                            komut.ExecuteNonQuery();
                        }
                        form4.show();
                        form4.Show();
                        this.Hide();
                    }
                    else MessageBox.Show("Anbarda qeyd etdiyiniz mal yoxdur!");
                }
                else MessageBox.Show("Müsbət ədəd daxil etdiyinizdən əmin olun!");
            }
            else MessageBox.Show("Boş yerləri doldurun!");
            baglan.Close();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            alisidtxt.Text = General.Satis.alisid;
            sayitxt.Text = General.Satis.sayi;
            qiymetitxt.Text = General.Satis.qiymeti;
            tarixitxt.Text = General.Satis.tarixi;
            /*alisidtxt.Text = alisid;
            sayitxt.Text = sayi;
            qiymetitxt.Text = qiymeti;
            tarixitxt.Text = tarixi;*/
            if (boolean == 1) addorupdbtn.Text = "Əlavə et";
            else if (boolean == 2) addorupdbtn.Text = "Düzəliş et";
        }

        private void Form5_FormClosed(object sender, FormClosedEventArgs e)
        {
            form4.Show();
        }
    }
}
