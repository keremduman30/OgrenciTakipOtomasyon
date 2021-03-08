namespace OgrenciTakipOtomasyonu
{
    partial class NotGirme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotGirme));
            this.label1 = new System.Windows.Forms.Label();
            this.txtOgId = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSınav2 = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSınav1 = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEkle = new DevExpress.XtraEditors.SimpleButton();
            this.cmbDers = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtOgId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSınav2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSınav1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(62, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ögrenci No : ";
            // 
            // txtOgId
            // 
            this.txtOgId.Location = new System.Drawing.Point(195, 35);
            this.txtOgId.Name = "txtOgId";
            this.txtOgId.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOgId.Properties.Appearance.Options.UseFont = true;
            this.txtOgId.Size = new System.Drawing.Size(157, 30);
            this.txtOgId.TabIndex = 1;
            this.txtOgId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_og_id_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(94, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ders adı :";
            // 
            // txtSınav2
            // 
            this.txtSınav2.Location = new System.Drawing.Point(195, 204);
            this.txtSınav2.Name = "txtSınav2";
            this.txtSınav2.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSınav2.Properties.Appearance.Options.UseFont = true;
            this.txtSınav2.Size = new System.Drawing.Size(157, 30);
            this.txtSınav2.TabIndex = 4;
            this.txtSınav2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_sınav2_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(100, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sınav 2 :";
            // 
            // txtSınav1
            // 
            this.txtSınav1.Location = new System.Drawing.Point(195, 142);
            this.txtSınav1.Name = "txtSınav1";
            this.txtSınav1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSınav1.Properties.Appearance.Options.UseFont = true;
            this.txtSınav1.Size = new System.Drawing.Size(157, 30);
            this.txtSınav1.TabIndex = 3;
            this.txtSınav1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_sınav1_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(100, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Sınav 1 :";
            // 
            // btnEkle
            // 
            this.btnEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnEkle.Location = new System.Drawing.Point(140, 264);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(180, 48);
            this.btnEkle.TabIndex = 8;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // cmbDers
            // 
            this.cmbDers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbDers.FormattingEnabled = true;
            this.cmbDers.Location = new System.Drawing.Point(195, 88);
            this.cmbDers.Name = "cmbDers";
            this.cmbDers.Size = new System.Drawing.Size(157, 33);
            this.cmbDers.TabIndex = 9;
            this.cmbDers.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(168, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 25);
            this.label5.TabIndex = 10;
            // 
            // NotGirme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(425, 356);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbDers);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtSınav1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSınav2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOgId);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.Name = "NotGirme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Not Gir";
            this.Load += new System.EventHandler(this.NotGirme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtOgId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSınav2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSınav1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtOgId;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txtSınav2;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit txtSınav1;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.SimpleButton btnEkle;
        private System.Windows.Forms.ComboBox cmbDers;
        private System.Windows.Forms.Label label5;
    }
}