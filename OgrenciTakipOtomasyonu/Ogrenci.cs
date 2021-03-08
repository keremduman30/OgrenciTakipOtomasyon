using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciTakipOtomasyonu
{
    class Ogrenci
    {
        private int ogrenci_id;
        private String ogrenci_ad;
        private String ogrenci_soyad;
        private String tc;
        private string cinsiyet;

        public int Ogrenci_id { get => ogrenci_id; set => ogrenci_id = value; }
        public string Ogrenci_ad { get => ogrenci_ad; set => ogrenci_ad = value; }
        public string Ogrenci_soyad { get => ogrenci_soyad; set => ogrenci_soyad = value; }
        public string Tc { get => tc; set => tc = value; }
        public string Cinsiyet { get => cinsiyet; set => cinsiyet = value; }
    }
}
