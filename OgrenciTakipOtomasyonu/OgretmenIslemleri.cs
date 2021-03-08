using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DevExpress.XtraEditors;
using System.Windows.Forms;

namespace OgrenciTakipOtomasyonu
{
    class OgretmenIslemleri
    {
        public Baglanti baglanti = new Baglanti();
        //ogretmendersislemleri
        public bool OgretmenGiris(Ogretmen ogretmen) {
            SqlCommand komut = new SqlCommand("Select * from Table_ogretmen where ogretmen_ad=@a1 and ogretmen_parola=@a2", baglanti.baglanti());
            komut.Parameters.AddWithValue("@a1", ogretmen.Ogretmen_ad);
            komut.Parameters.AddWithValue("@a2", ogretmen.Ogretmen_parola);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public List<Dersler> Ders_listele() {
            Baglanti baglanti = new Baglanti();

            List<Dersler> ders_array = new List<Dersler>();//listelemek için adı ustunnde arraylistlerden yardım aldım
            SqlCommand komut = new SqlCommand("select * from Table_dersler", baglanti.baglanti());//komut yazdım
            SqlDataReader dr = komut.ExecuteReader();//okuttuk
            while (dr.Read())
            {
                Dersler ders = new Dersler();
                ders.Ders_id = int.Parse(dr["Ders_id"].ToString());
                ders.Ders_ad = dr["Ders_ad"].ToString();
                ders_array.Add(ders);

            }
            dr.Close();
            return ders_array;
        }
        public int DersEkle(Dersler d) {
            Baglanti baglanti = new Baglanti();

            SqlCommand komut = new SqlCommand("insert into Table_dersler (Ders_ad) values(@a1)", baglanti.baglanti());

            komut.Parameters.AddWithValue("@a1", d.Ders_ad);
            return komut.ExecuteNonQuery();// eklerse bu sayı int degerinde artıgı için


        }
        public bool DersSil(Dersler d) {
            SqlCommand komut = new SqlCommand("Delete from Table_dersler where Ders_id=@a1", baglanti.baglanti());
            komut.Parameters.AddWithValue("@a1", d.Ders_id);
            return komut.ExecuteNonQuery() > 0;//true yada false aldıgı için ya sıfırdan buyuk yada kucuktur

        }
        public bool DersGuncelle(Dersler d) {
            SqlCommand komut = new SqlCommand("update Table_dersler set Ders_ad=@a1 where Ders_id=@a2", baglanti.baglanti());
            komut.Parameters.AddWithValue("@a1", d.Ders_ad);
            komut.Parameters.AddWithValue("@a2", d.Ders_id);
            return komut.ExecuteNonQuery() > 0;//guncelerse de aynı ekleme mantıgı gibi int + doner >0 yani

        }
        public SqlDataAdapter not_liste(Notlar n) {
            SqlCommand komut = new SqlCommand("Select ogrenci_id,Ders_ad,sınav1,sınav2 from Table_notlar INNER JOIN Table_dersler ON Table_notlar.ders_id = Table_dersler.Ders_id where ogrenci_id = @a1"
            , baglanti.baglanti());//iliskili oldugu için ınner joın kullandım bu sayede iliskisi diger tablodan olan adı getirdım
            komut.Parameters.AddWithValue("@a1", n.Ogrenci_id);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            return da;//dataadapter yapmamın tek nedeni datagridviewe aktarmak
        }
        public String ThisName(Ogrenci o) {//idiye gore girilen ogrenci adını soyadını form textine yazdırmak için
            SqlCommand komut = new SqlCommand("Select ogr_ad,ogr_soyad from Table_ogrenciler where ogrenci_no=@a1", baglanti.baglanti());
            komut.Parameters.AddWithValue("@a1",o.Ogrenci_id);//idiye gore ad soyad getirecek 
            SqlDataReader dr = komut.ExecuteReader();//select oldugu için komutu okutuyoruz
            String name = "";
           
            while (dr.Read())
                {
                    o.Ogrenci_ad = dr["ogr_ad"].ToString();
                    o.Ogrenci_soyad = dr["ogr_soyad"].ToString();
                    name = o.Ogrenci_ad + " " + o.Ogrenci_soyad;//true donerse name ad ve soyadı yazdırdım
                }

          
            

            return name.ToUpper();//sonra buyuk harf olmalarını sagladım(this ekranına yazdıracam cunku)
        }
        public bool ThisNoStudent(Ogrenci o) {
            bool durum = false;
            SqlCommand komut = new SqlCommand("Select ogr_ad,ogr_soyad from Table_ogrenciler where ogrenci_no=@a1", baglanti.baglanti());
            komut.Parameters.AddWithValue("@a1", o.Ogrenci_id);
            SqlDataReader dr= komut.ExecuteReader();
            if (dr.Read()) {
                durum = true;
            }
            else durum = false;
            return durum;
        }
        public SqlDataAdapter ComboboxVeriAktarma() {//cmb verilerini aktarmak için dersler tablosunu getirdim
            SqlCommand komut = new SqlCommand("Select * from Table_dersler", baglanti.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(komut);//cmb value ve display degerleri içiin data source kullandım buda sql data adapter ister
            return da;//bu yuzden geri donus sqldataadapteroldu

        }
        //ogretmenogrenciislemleri
        public List<Ogrenci> Ogrenci_listele() {
            List<Ogrenci> ogrenci_list = new List<Ogrenci>();//ogrencileri listelemek için liste aktardım while kullanacam cunku
            SqlCommand komut = new SqlCommand("select * from Table_ogrenciler", baglanti.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {//eger sart yerine gelmis ve veritabanında veriler var ise
                Ogrenci ogrenci = new Ogrenci();
                ogrenci.Ogrenci_id = int.Parse(dr["ogrenci_no"].ToString());
                ogrenci.Ogrenci_ad = (dr["ogr_ad"].ToString());
                ogrenci.Ogrenci_soyad = (dr["ogr_soyad"].ToString());
                ogrenci.Tc = (dr["ogr_tc"].ToString());
                ogrenci.Cinsiyet = (dr["ogr_cinsiyet"].ToString());
                ogrenci_list.Add(ogrenci);//her dongu basında listeye eklesin dedim


            }
           
            dr.Close();
            return ogrenci_list; //metod tipi list oldugu için list donemk zorunda


        }
        public int OgrenciEkle(Ogrenci o) {//is sadece sorguda bitiyor
            SqlCommand komut = new SqlCommand("insert into Table_ogrenciler(ogr_ad,ogr_soyad,ogr_tc,ogr_cinsiyet)values(@a1,@a2,@a3,@a4)", baglanti.baglanti());
            komut.Parameters.AddWithValue("@a1", o.Ogrenci_ad);
            komut.Parameters.AddWithValue("@a2", o.Ogrenci_soyad);
            komut.Parameters.AddWithValue("@a3", o.Tc);
            komut.Parameters.AddWithValue("@a4", o.Cinsiyet);
            return komut.ExecuteNonQuery();//eklerse bu sayı int degerinde artıgı için
        }
        public int OgrenciSil(Ogrenci o) {
            SqlCommand komut = new SqlCommand("Delete from Table_ogrenciler where ogrenci_no=@a1", baglanti.baglanti());
            komut.Parameters.AddWithValue("@a1", o.Ogrenci_id);
            return komut.ExecuteNonQuery();//eklerse bu sayı int degerinde artıgı için
        }
        public bool OgrenciGuncelle(Ogrenci o) {
            SqlCommand komut = new SqlCommand("update Table_ogrenciler set ogr_ad=@a1,ogr_soyad=@a2,ogr_tc=@a3 where ogrenci_no=@a5", baglanti.baglanti());
            komut.Parameters.AddWithValue("@a1", o.Ogrenci_ad);
            komut.Parameters.AddWithValue("@a2", o.Ogrenci_soyad);
            komut.Parameters.AddWithValue("@a3", o.Tc);
            komut.Parameters.AddWithValue("@a5", o.Ogrenci_id);
            return komut.ExecuteNonQuery() > 0;//executenonquery  sıfırdan buyuk ise true donecek
        }

       /* public int Ogrenci_Not_Gir(Notlar notlar) {
            SqlCommand komut = new SqlCommand("İnsert into Table_notlar INNER JOIN Table_dersler on Table_notlar.ders_id=Table_dersler.Ders_id (Table_dersler.Ders_id,ogrenci_id,sınav1,sınav2) values(@a1,@a2,@a3,@a4) on  where ogrenci_id=@a5", baglanti.baglanti());
            komut.Parameters.AddWithValue("@a1",notlar.Ders_id);
            komut.Parameters.AddWithValue("@a2",notlar.Ogrenci_id);
            komut.Parameters.AddWithValue("@a3",notlar.Sınav1);
            komut.Parameters.AddWithValue("@a4",notlar.Sınav2);
            komut.Parameters.AddWithValue("@a5",notlar.Ogrenci_id);
            return komut.ExecuteNonQuery();

        }
        */

        public int NotEkle(Notlar notlar) {
            SqlCommand komut = new SqlCommand("insert into Table_notlar(ders_id,ogrenci_id,sınav1,sınav2)values(@a1,@a2,@a3,@a4)",baglanti.baglanti());
            komut.Parameters.AddWithValue("@a1",notlar.Ders_id);
            komut.Parameters.AddWithValue("@a2",notlar.Ogrenci_id);
            komut.Parameters.AddWithValue("@a3",notlar.Sınav1);
            komut.Parameters.AddWithValue("@a4",notlar.Sınav2);
          
            return komut.ExecuteNonQuery();
            
        }
        public bool OgrenciID(Ogrenci n) {
            bool durum = false;
            SqlCommand komut = new SqlCommand("select * from Table_ogrenciler where ogrenci_no=@a1",baglanti.baglanti());
            komut.Parameters.AddWithValue("@a1",n.Ogrenci_id);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                durum = true;
            }
            else durum = false;

            return durum;
        }
    }
 }

