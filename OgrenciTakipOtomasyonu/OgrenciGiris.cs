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

namespace OgrenciTakipOtomasyonu
{
    public partial class OgrenciGiris : Form
    {
        public OgrenciGiris()
        {
            InitializeComponent();
        }

        OgrenciIslemleri islemler = new OgrenciIslemleri();
        private void OgrenciGiris_Load(object sender, EventArgs e)
        {
            
        }
        public static int ogr_no;//diger formda kullanacam idi ye gore verilere gridviewe aktaracam
        private void simpleButton1_Click(object sender, EventArgs e)
        {
           
            if (textEdit1.Text.Trim().Equals(""))
            {//ogrenci id si bos girmisse veya bosluk olarak girilmis ise
                MessageBox.Show("lütfen ogrenci numarasını bos girmeyiniz","UYARI",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else {
                Ogrenci ogrenci = new Ogrenci();//ogrencigiris metdou ogrenci sınıfından tur istediği için
                ogrenci.Ogrenci_id = int.Parse(textEdit1.Text);//idiyi ona atadım
                ogr_no = ogrenci.Ogrenci_id;
                if (islemler.OgreniGiris(ogrenci))
                {//eger true donerse ogrenci not ekranına gececek
                    OgrenciNotEkranı ogrenciNot = new OgrenciNotEkranı();
                    ogrenciNot.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("boyle bir ogrenci numarası kayıtlı(eklenmemis) değil .Lütfen kontrol ediniz ve ekledikten sonra tekrar deneyiniz","UYARI",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
          

        }

       
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Hide();//eger çıkısa basılırsa bu sayfa gizlensin,kapatılsın

        }

        private void textEdit1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == 8)
            {
                e.Handled = false;//tuhaf tersi ile calısıyor
            }
            else e.Handled = true;
        }
    }
}
