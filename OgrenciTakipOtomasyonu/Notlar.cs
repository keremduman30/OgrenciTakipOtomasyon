using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciTakipOtomasyonu
{
    class Notlar
    {
        private int not_id;
        private int ders_id;
        private int ogrenci_id;
        private int sınav1;
        private int sınav2;
        /*private decimal ortalama;
        private bool durum;*/

        public int Not_id { get => not_id; set => not_id = value; }
        public int Ders_id { get => ders_id; set => ders_id = value; }
        public int Ogrenci_id { get => ogrenci_id; set => ogrenci_id = value; }
        public int Sınav1 { get => sınav1; set => sınav1 = value; }
        public int Sınav2 { get => sınav2; set => sınav2 = value; }
     /*   public decimal Ortalama { get => ortalama; set => ortalama = value; }
        public bool Durum { get => durum; set => durum = value; }*/
     


    }
}
