using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenciTakipOtomasyonu
{
    public partial class NotGirme : Form
    {
        public NotGirme()
        {
            InitializeComponent();
        }
        OgretmenIslemleri islemler = new OgretmenIslemleri();
        Notlar notlar = new Notlar();
        Ogrenci ogrenci = new Ogrenci();
        int ders_id;
        private void NotGirme_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            islemler.ComboboxVeriAktarma().Fill(dt);
            cmbDers.DisplayMember = "Ders_ad";
            cmbDers.ValueMember = "Ders_id";
            cmbDers.DataSource = dt;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (txtOgId.Text.Trim().Equals(""))
            {
                MessageBox.Show("lütfen ogrenci no bos bırakma", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            else
            {
                ogrenci.Ogrenci_id = int.Parse(txtOgId.Text);

            }

            if (islemler.OgrenciID(ogrenci))
            {
              

                if ( txtSınav1.Text.Trim().Equals("") || txtSınav2.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Lütfen tum boslukları doldurun");
                }
                else
                {
                    notlar.Ders_id = ders_id;
                    notlar.Ogrenci_id = int.Parse(txtOgId.Text);
                    notlar.Sınav1 = int.Parse(txtSınav1.Text);
                    notlar.Sınav2 = int.Parse(txtSınav2.Text);
                    islemler.NotEkle(notlar);
                    MessageBox.Show("Not ekleme basarılı lütfen cıkısta ogrenci numarasını yazıp aratınız","EKLENDİ",MessageBoxButtons.OK);
                   
                    this.Hide();
                    

                }
            }
            else {
                MessageBox.Show("boyle bir ogrenci bulunmamaktadır .Lütfen kayıtlı ogrenci no gir","UYARI",MessageBoxButtons.OK,MessageBoxIcon.Error);

            }
            Temizle();


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           ders_id = int.Parse(cmbDers.SelectedValue.ToString());
        }

        private void txt_og_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == 8)
            {
                e.Handled = false;//tuhaf tersi ile calısıyor
            }
            else e.Handled = true;
        }

        private void txt_sınav1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == 8)
            {
                e.Handled = false;//tuhaf tersi ile calısıyor
            }
            else e.Handled = true;
        }

        private void txt_sınav2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == 8)
            {
                e.Handled = false;//tuhaf tersi ile calısıyor
            }
            else e.Handled = true;
        }
        public void Temizle() {
            txtOgId.Text = "";
            txtSınav1.Text = "";
            txtSınav2.Text = "";
            this.Text = "";
        }
    }
    
}
