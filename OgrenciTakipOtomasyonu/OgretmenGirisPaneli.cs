using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenciTakipOtomasyonu
{
    public partial class OgretmenGirisPaneli : Form
    {
        public OgretmenGirisPaneli()
        {
            InitializeComponent();
        }
        private void OgretmenGirisPaneli_Load(object sender, EventArgs e)
        {

        }


        Baglanti bgl = new Baglanti();

      

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            Ogretmen ogretmen = new Ogretmen();
            ogretmen.Ogretmen_ad = txtAd.Text;
            ogretmen.Ogretmen_parola = txtParola.Text;
            if (txtAd.Text.Trim().Equals("") || txtParola.Text.Trim().Equals(""))
            {
                MessageBox.Show("lütfen tum alanları doldurunuz");
            }
            else {
                OgretmenIslemleri islemler = new OgretmenIslemleri();
                if (islemler.OgretmenGiris(ogretmen))
                {
                    OgretmenForm ogretmenForm = new OgretmenForm();
                    ogretmenForm.Show();
                    this.Hide();
                }
                else {
                    MessageBox.Show("kullanıcı adı veya parola hatalı","UYARI",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
              
            }
        }
    }
}
