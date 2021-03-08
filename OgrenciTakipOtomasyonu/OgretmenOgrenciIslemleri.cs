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
    public partial class OgretmenOgrenciIslemleri : Form
    {
        public OgretmenOgrenciIslemleri()
        {
            InitializeComponent();
            listele();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        OgretmenIslemleri islemler = new OgretmenIslemleri();
        void listele() {
            
            dataGridView1.DataSource = islemler.Ogrenci_listele();    
        }
        String cinsiyet;
        private void OgretmenOgrenciIslemleri_Load(object sender, EventArgs e)
        {

        }

        private void btn_listele_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            txtNo.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtAd.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            mskTc.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnErkek.Checked == true)
            {
                cinsiyet = "erkek";
            }
           
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
              if (rbtnKiz.Checked == true)
            {
                cinsiyet = "kız";
            }
        }
        void temizle() {
            txtAd.Text = "";
            txtSoyad.Text = "";
            txtNo.Text = "";
            mskTc.Text = "";
          
        }
        private void btn_ekle_Click(object sender, EventArgs e)
        {
            if (txtAd.Text.Trim().Equals("") || txtSoyad.Text.Trim().Equals("") || mskTc.Text.Trim().Equals(""))
            {
                MessageBox.Show("lütfen tum boslukları doldurunuz");
            }
            else if (rbtnErkek.Checked!=true && rbtnKiz.Checked!=true)
            {
                MessageBox.Show("lütfen cinsiyeti belirleyinizs");
            }
            else {
                Ogrenci ogrenci = new Ogrenci();
                ogrenci.Ogrenci_ad = txtAd.Text;
                ogrenci.Ogrenci_soyad = txtSoyad.Text;
                ogrenci.Tc = mskTc.Text;
                ogrenci.Cinsiyet = cinsiyet;
                if (islemler.OgrenciEkle(ogrenci) > 0)
                {
                    MessageBox.Show("Ekleme basarılı");
                }
                else {
                    MessageBox.Show("ekleme basarısız");
                }
                listele();
                temizle();
            }
           
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            Ogrenci ogrenci = new Ogrenci();
            if (txtNo.Text.Trim().Equals(""))
            {

                MessageBox.Show("lütfen silinecek  ogrenci  satırını tablodan seçiniz");
            }
            else {
                ogrenci.Ogrenci_id = int.Parse(txtNo.Text);

                if (islemler.OgrenciSil(ogrenci) > 0)
                {
                    MessageBox.Show("silme basarılı");
                    listele();
                    temizle();
                }

            }
           
            

        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Ogrenci_ad = txtAd.Text;
            ogrenci.Ogrenci_soyad = txtSoyad.Text;
            ogrenci.Tc = mskTc.Text;

            if (txtAd.Text.Trim().Equals("") || txtSoyad.Text.Trim().Equals("") || mskTc.Text.Trim().Equals(""))
            {
                MessageBox.Show("lütfen tum boslukları doldurunuz ");

            }
            else if (txtNo.Text.Trim().Equals(""))
            {
                MessageBox.Show("lütfen guncellenecek ogrenciyi tablodan seciniz");
            }
            else {
                ogrenci.Ogrenci_id = int.Parse(txtNo.Text);
                if (islemler.OgrenciGuncelle(ogrenci))
                {
                    MessageBox.Show("guncelleme basarılı");
                }
                else {
                    MessageBox.Show("guncelleme basarısız");
                }

                listele();
                temizle();
            }
          
        }

        private void btn_ara_Click(object sender, EventArgs e)
        {
            
        }
    }
}
