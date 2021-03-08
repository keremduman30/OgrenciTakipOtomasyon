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
    public partial class OgretmenDersIslemleri : Form
    {
        public OgretmenDersIslemleri()
        {
            InitializeComponent();
        }
        OgretmenIslemleri islemler = new OgretmenIslemleri();
        Dersler ders = new Dersler();


        private void OgretmenDersIslemleri_Load(object sender, EventArgs e)
        {
            listele();
        }
        private void simpleButton4_Click(object sender, EventArgs e)
        {

            listele();
        }
        void listele() {
            ///gridControl1.DataSource = islemler.Ders_listele();
            dataGridView1.DataSource = islemler.Ders_listele();

        }
        void temizle() {
            txtId.Text = "";
            txtAd.Text = "";
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (txtAd.Text.Trim().Equals(""))
            {
                MessageBox.Show("Lütfen bos bırakma");

            }
            else
            {
            ders.Ders_ad = txtAd.Text;
            islemler.DersEkle(ders);
            MessageBox.Show("ders ekleme basarılı");
            listele();
                temizle();



            }
         


        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
           
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            if (txtId.Text.Trim().Equals(""))
            {
                MessageBox.Show("Lütfen silinecek idiyi tablodan yazın ");


            }
            else
            {
                ders.Ders_id = int.Parse(txtId.Text);
                if (islemler.DersSil(ders)==true)
                {
                    MessageBox.Show("ders silme basarılı");
                    listele();
                    temizle();
                }
                else MessageBox.Show("silme basarısız tekrar dene");




            }


        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (txtId.Text.Trim().Equals("") || txtAd.Text.Trim().Equals(""))
            {

                MessageBox.Show("Lütfen guncelleeck  idiyi tablodan yazın ve adı bos bırakmayın");

            }
            else {
                ders.Ders_id = int.Parse(txtId.Text);
                ders.Ders_ad = txtAd.Text;
                islemler.DersGuncelle(ders);
                MessageBox.Show("ders guncelleme basarılı");
                listele();
                temizle();
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtAd.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
    }
}
