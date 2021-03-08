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
    public partial class OgretmenNotIslemleri : Form
    {
        public OgretmenNotIslemleri()
        {
            InitializeComponent();
           

        }
        Notlar notlar = new Notlar();
        OgretmenIslemleri islemler = new OgretmenIslemleri();
        private void btn_ara_Click(object sender, EventArgs e)
        {
            
            if (txtOgrenciId.Text.Trim().Equals(""))//id textboxda bosluk veya bos girer isse uyarı vermek için 
            {
                MessageBox.Show("Lütfen goruntulenecek ogrenci numarasını bos girmeyin");
            }
            else
            {
                notlar.Ogrenci_id = int.Parse(txtOgrenciId.Text);
                DataTable dt = new DataTable();
                islemler.not_liste(notlar).Fill(dt);
                dataGridView1.DataSource =dt;
                Ogrenci ogrenci = new Ogrenci();
                ogrenci.Ogrenci_id = int.Parse(txtOgrenciId.Text);
                if (islemler.ThisNoStudent(ogrenci))//eger id varise ogrenci ismi ve soyadı this.text e yazacak
                {
                    this.Text = islemler.ThisName(ogrenci);

                }
                else {//eger yok ise messsageBox ile uyarı vercek
                    MessageBox.Show("BÖYLE BİR ÖGRENCİ KAYITLI DEĞİLDİR. LÜTFEN OGRENCİ İŞLEMLERİNDEN ONCE KAYDEDİN","UYARI",MessageBoxButtons.OK,MessageBoxIcon.Error); 

                }
                txtSınav1.Text = "";
                txtSınav2.Text = "";
                txtProjeNot.Text = "";
                txtDurum.Text = "";
                txtOrt.Text = "";
            }

        }
      
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          
            txtOgrenciId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtSınav1.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtSınav2.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            cmbDersler.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
           

        }
        private void OgretmenNotIslemleri_Load(object sender, EventArgs e)
        {

              DataTable dt = new DataTable();
            islemler.ComboboxVeriAktarma().Fill(dt);
            cmbDersler.DisplayMember = "Ders_ad";
            cmbDersler.ValueMember = "Ders_id";
            cmbDersler.DataSource = dt;

        }
      
        private void btn_hesapla_Click(object sender, EventArgs e)
        {
            if (txtOgrenciId.Text.Trim().Equals(""))
            {

                MessageBox.Show("Lütfen işlem yapmak için ilgili ogrenci numarasını giriniz ve aratız");
            }

            else if (txtProjeNot.Text.Trim().Equals(""))
            {  
                  MessageBox.Show("ogrencinin kalıp yada geçmesi için proje notu girilmeli");
            }
            else if (txtSınav1.Text.Trim().Equals("") || txtSınav2.Text.Trim().Equals(""))
            {
                
                MessageBox.Show("Lütfen işlem yapılacak dersi tablodan seçiniz");

            }
            else
            {
             int sınav1 = int.Parse(txtSınav1.Text);
             int snv2 = int.Parse(txtSınav2.Text);
             int projeNot = int.Parse(txtProjeNot.Text);
             int ortalama = (sınav1 + snv2 + projeNot) / 3;
                txtOrt.Text = ortalama.ToString();
                if (ortalama >= 50)
                {
                    txtDurum.ForeColor = Color.Green;
                    txtDurum.Text = "Geçiyor";
                    txtOrt.ForeColor = Color.Green;

                }
                else
                {
                    txtDurum.ForeColor = Color.Red;
                    txtOrt.ForeColor = Color.Red;
                    txtDurum.Text = "Kalıyor";

                }


            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void txt_ogrenci_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == 8)
            {
                e.Handled = false;//tuhaf tersi ile calısıyor
            }
            else e.Handled = true;
        }

        private void txt_proje_not_KeyPress(object sender, KeyPressEventArgs e)
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

        private void simpleButton2_Click(object sender, EventArgs e)
        {

            
        }

        private void simpleButton2_Click_1(object sender, EventArgs e)
        {
            NotGirme notGirme = new NotGirme();
            notGirme.Show();
        }
     

       
    }
    }

