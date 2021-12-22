using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Aksesuar
{
    static class General
    {
        static SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-FRPNK3P;Initial Catalog=aksesuar;Integrated Security=True");
        static public DataTable Show(string dbname)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from " + dbname, baglan);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];
        }

        static public class Alis
        {
            static public string id = "";
            static public string cesid = "";
            static public string marka = "";
            static public string getirilme_tarixi = "";
            static public string sayi = "";
            static public string alis_qiymeti = "";
            static public string satis_qiymeti = "";
            static public string elave_melumat = "";
        }
        static public class Satis
        {
            static public string satisid = "";
            static public string alisid = "";
            static public string sayi = "";
            static public string qiymeti = "";
            static public string tarixi = "";
        }
    }
}
