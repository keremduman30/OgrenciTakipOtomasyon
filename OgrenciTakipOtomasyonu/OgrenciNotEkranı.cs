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
    public partial class OgrenciNotEkranı : Form
    {
        public OgrenciNotEkranı()
        {
            InitializeComponent();
        }
        OgrenciIslemleri islemler = new OgrenciIslemleri();
        private void OgrenciNotEkranı_Load(object sender, EventArgs e)
        {
           
            DataTable dt = new DataTable();
            int id = OgrenciGiris.ogr_no;
            islemler.Ogrenci_not_list(id).Fill(dt);
            dataGridView1.DataSource =dt;
            this.Text = islemler.ThisName(id);
          
        }

    }
}
