using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace OgrenciTakipOtomasyonu
{
   public class Baglanti
    {
        public string Adres = System.IO.File.ReadAllText(@"C:\Test.txt");
        public SqlConnection baglanti() {
          SqlConnection baglan = new SqlConnection(Adres);
            baglan.Open();
            return baglan;

    }



}
}
