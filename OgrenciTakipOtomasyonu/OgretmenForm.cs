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
    public partial class OgretmenForm : Form
    {
        public OgretmenForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_ders_Click(object sender, EventArgs e)
        {
            OgretmenDersIslemleri dersIslemleri = new OgretmenDersIslemleri();
            dersIslemleri.Show();
        }

        private void btn_not_Click(object sender, EventArgs e)
        {
            OgretmenNotIslemleri notIslemleri = new OgretmenNotIslemleri();
            notIslemleri.Show();
        }

        private void btn_ogrenci_Click(object sender, EventArgs e)
        {
            OgretmenOgrenciIslemleri ogrenciIslemleri = new OgretmenOgrenciIslemleri();
            ogrenciIslemleri.Show();
            
        }

        private void OgretmenForm_Load(object sender, EventArgs e)
        {

        }
    }
}
