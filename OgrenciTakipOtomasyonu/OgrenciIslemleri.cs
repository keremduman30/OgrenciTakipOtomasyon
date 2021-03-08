using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciTakipOtomasyonu
{
    class OgrenciIslemleri
    {
        public Baglanti baglanti = new Baglanti();
        public bool OgreniGiris(Ogrenci o) {
            SqlCommand komut = new SqlCommand("Select * From Table_ogrenciler where ogrenci_no=@a1",baglanti.baglanti());
            komut.Parameters.AddWithValue("@a1",o.Ogrenci_id);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())//idi dogru ise ve komut okuyorsa retun true olarak dondurdum
            {
                return true;
            }
            else {
                return false;//degilse false tabi
            }
        }
        public SqlDataAdapter Ogrenci_not_list(int id) {//ilişkili oldug için diger tablodaki ders adını aldık ve notalrdaki ders _id esitledik
            SqlCommand komut = new SqlCommand("Select Table_dersler.Ders_ad,sınav1,sınav2 from Table_notlar INNER JOIN Table_dersler ON Table_notlar.ders_id=Table_dersler.Ders_id where ogrenci_id=@a1", baglanti.baglanti());
            komut.Parameters.AddWithValue("@a1",id);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            return da;
   
        }
        public String ThisName(int id) {
            SqlCommand komut = new SqlCommand("Select ogr_ad,ogr_soyad from Table_ogrenciler where ogrenci_no=@a1",baglanti.baglanti());
            komut.Parameters.AddWithValue("@a1",id);//ogrenci ad ve soyadı ogrenci numarsına gore getirsin dedik
            SqlDataReader dr = komut.ExecuteReader();//varsa okutsun 
            String ad="";
            while (dr.Read())//noyle kriterleri karsılıyorsa oku dedik
            {
                ad = dr["ogr_ad"].ToString()+" "+dr["ogr_soyad"];//adı ve soyadı ad degiskenine atadık
            }
            return ad.ToUpper();//ve buyuk harfle donsun dedik
        }
        
      
    }
}

