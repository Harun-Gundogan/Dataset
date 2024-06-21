namespace Okul
{
    partial class FrmGiris
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGiris));
            this.pcr_Ogrenci = new System.Windows.Forms.PictureBox();
            this.pcr_Ogretmen = new System.Windows.Forms.PictureBox();
            this.lbl_Ogrenci = new System.Windows.Forms.Label();
            this.lbl_Ogretmen = new System.Windows.Forms.Label();
            this.txt_Number = new System.Windows.Forms.TextBox();
            this.lbl_Number = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcr_Ogrenci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcr_Ogretmen)).BeginInit();
            this.SuspendLayout();
            // 
            // pcr_Ogrenci
            // 
            this.pcr_Ogrenci.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcr_Ogrenci.Image = ((System.Drawing.Image)(resources.GetObject("pcr_Ogrenci.Image")));
            this.pcr_Ogrenci.Location = new System.Drawing.Point(69, 74);
            this.pcr_Ogrenci.Name = "pcr_Ogrenci";
            this.pcr_Ogrenci.Size = new System.Drawing.Size(200, 200);
            this.pcr_Ogrenci.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcr_Ogrenci.TabIndex = 0;
            this.pcr_Ogrenci.TabStop = false;
            this.pcr_Ogrenci.Click += new System.EventHandler(this.pcr_Ogrenci_Click);
            // 
            // pcr_Ogretmen
            // 
            this.pcr_Ogretmen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcr_Ogretmen.Image = ((System.Drawing.Image)(resources.GetObject("pcr_Ogretmen.Image")));
            this.pcr_Ogretmen.Location = new System.Drawing.Point(394, 74);
            this.pcr_Ogretmen.Name = "pcr_Ogretmen";
            this.pcr_Ogretmen.Size = new System.Drawing.Size(200, 200);
            this.pcr_Ogretmen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcr_Ogretmen.TabIndex = 1;
            this.pcr_Ogretmen.TabStop = false;
            this.pcr_Ogretmen.Click += new System.EventHandler(this.pcr_Ogretmen_Click);
            // 
            // lbl_Ogrenci
            // 
            this.lbl_Ogrenci.AutoSize = true;
            this.lbl_Ogrenci.Location = new System.Drawing.Point(129, 291);
            this.lbl_Ogrenci.Name = "lbl_Ogrenci";
            this.lbl_Ogrenci.Size = new System.Drawing.Size(81, 25);
            this.lbl_Ogrenci.TabIndex = 2;
            this.lbl_Ogrenci.Text = "Öğrenci";
            // 
            // lbl_Ogretmen
            // 
            this.lbl_Ogretmen.AutoSize = true;
            this.lbl_Ogretmen.Location = new System.Drawing.Point(445, 291);
            this.lbl_Ogretmen.Name = "lbl_Ogretmen";
            this.lbl_Ogretmen.Size = new System.Drawing.Size(99, 25);
            this.lbl_Ogretmen.TabIndex = 3;
            this.lbl_Ogretmen.Text = "Öğretmen";
            // 
            // txt_Number
            // 
            this.txt_Number.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_Number.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Number.Location = new System.Drawing.Point(162, 345);
            this.txt_Number.Name = "txt_Number";
            this.txt_Number.Size = new System.Drawing.Size(432, 23);
            this.txt_Number.TabIndex = 4;
            // 
            // lbl_Number
            // 
            this.lbl_Number.AutoSize = true;
            this.lbl_Number.Location = new System.Drawing.Point(69, 343);
            this.lbl_Number.Name = "lbl_Number";
            this.lbl_Number.Size = new System.Drawing.Size(87, 25);
            this.lbl_Number.TabIndex = 7;
            this.lbl_Number.Text = "Numara:";
            // 
            // FrmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(669, 432);
            this.Controls.Add(this.lbl_Number);
            this.Controls.Add(this.txt_Number);
            this.Controls.Add(this.lbl_Ogretmen);
            this.Controls.Add(this.lbl_Ogrenci);
            this.Controls.Add(this.pcr_Ogretmen);
            this.Controls.Add(this.pcr_Ogrenci);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Ekran";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcr_Ogrenci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcr_Ogretmen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcr_Ogrenci;
        private System.Windows.Forms.PictureBox pcr_Ogretmen;
        private System.Windows.Forms.Label lbl_Ogrenci;
        private System.Windows.Forms.Label lbl_Ogretmen;
        private System.Windows.Forms.TextBox txt_Number;
        private System.Windows.Forms.Label lbl_Number;
    }
}

