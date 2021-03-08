namespace OgrenciTakipOtomasyonu
{
    partial class OgretmenForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OgretmenForm));
            this.btnDers = new DevExpress.XtraEditors.SimpleButton();
            this.btnNot = new DevExpress.XtraEditors.SimpleButton();
            this.btnOgrenci = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // btnDers
            // 
            this.btnDers.Appearance.BackColor = System.Drawing.Color.Silver;
            this.btnDers.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDers.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnDers.Appearance.Options.UseBackColor = true;
            this.btnDers.Appearance.Options.UseFont = true;
            this.btnDers.Appearance.Options.UseForeColor = true;
            this.btnDers.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnDers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDers.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_ders.ImageOptions.Image")));
            this.btnDers.Location = new System.Drawing.Point(42, 55);
            this.btnDers.Name = "btnDers";
            this.btnDers.Size = new System.Drawing.Size(307, 72);
            this.btnDers.TabIndex = 1;
            this.btnDers.Text = "Ders İşlemleri";
            this.btnDers.Click += new System.EventHandler(this.btn_ders_Click);
            // 
            // btnNot
            // 
            this.btnNot.Appearance.BackColor = System.Drawing.Color.Silver;
            this.btnNot.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNot.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnNot.Appearance.Options.UseBackColor = true;
            this.btnNot.Appearance.Options.UseFont = true;
            this.btnNot.Appearance.Options.UseForeColor = true;
            this.btnNot.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnNot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNot.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_not.ImageOptions.Image")));
            this.btnNot.Location = new System.Drawing.Point(42, 156);
            this.btnNot.Name = "btnNot";
            this.btnNot.Size = new System.Drawing.Size(307, 72);
            this.btnNot.TabIndex = 3;
            this.btnNot.Text = "Sınav Notları";
            this.btnNot.Click += new System.EventHandler(this.btn_not_Click);
            // 
            // btnOgrenci
            // 
            this.btnOgrenci.Appearance.BackColor = System.Drawing.Color.Silver;
            this.btnOgrenci.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOgrenci.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnOgrenci.Appearance.Options.UseBackColor = true;
            this.btnOgrenci.Appearance.Options.UseFont = true;
            this.btnOgrenci.Appearance.Options.UseForeColor = true;
            this.btnOgrenci.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnOgrenci.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOgrenci.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_ogrenci.ImageOptions.Image")));
            this.btnOgrenci.Location = new System.Drawing.Point(42, 247);
            this.btnOgrenci.Name = "btnOgrenci";
            this.btnOgrenci.Size = new System.Drawing.Size(307, 72);
            this.btnOgrenci.TabIndex = 4;
            this.btnOgrenci.Text = "Öğrenci İşlemleri";
            this.btnOgrenci.Click += new System.EventHandler(this.btn_ogrenci_Click);
            // 
            // OgretmenForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(378, 381);
            this.Controls.Add(this.btnOgrenci);
            this.Controls.Add(this.btnNot);
            this.Controls.Add(this.btnDers);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "OgretmenForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İşlemler Menüsü";
            this.Load += new System.EventHandler(this.OgretmenForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnDers;
        private DevExpress.XtraEditors.SimpleButton btnNot;
        private DevExpress.XtraEditors.SimpleButton btnOgrenci;
    }
}