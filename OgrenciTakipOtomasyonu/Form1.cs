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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
        }

    

     

       

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            OgrenciGiris ogrenci = new OgrenciGiris();
            ogrenci.Show();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            OgretmenGirisPaneli ogretmenGiris = new OgretmenGirisPaneli();
            ogretmenGiris.Show();
        }
    }
}
