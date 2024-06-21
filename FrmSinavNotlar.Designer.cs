namespace Okul
{
    partial class FrmSinavNotlar
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbl_OgrID = new System.Windows.Forms.Label();
            this.lbl_Ders = new System.Windows.Forms.Label();
            this.lbl_S1 = new System.Windows.Forms.Label();
            this.txt_OgrID = new System.Windows.Forms.TextBox();
            this.cmbders = new System.Windows.Forms.ComboBox();
            this.txtsinav1 = new System.Windows.Forms.TextBox();
            this.txtsinav2 = new System.Windows.Forms.TextBox();
            this.lbl_S2 = new System.Windows.Forms.Label();
            this.txtsinav3 = new System.Windows.Forms.TextBox();
            this.lbl_S3 = new System.Windows.Forms.Label();
            this.txtproje = new System.Windows.Forms.TextBox();
            this.lbl_Proje = new System.Windows.Forms.Label();
            this.txtortalama = new System.Windows.Forms.TextBox();
            this.lbl_Ort = new System.Windows.Forms.Label();
            this.txtdurum = new System.Windows.Forms.TextBox();
            this.lbl_Durum = new System.Windows.Forms.Label();
            this.btn_Hesapla = new System.Windows.Forms.Button();
            this.btn_Ekle = new System.Windows.Forms.Button();
            this.btn_Temizle = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1176, 345);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // lbl_OgrID
            // 
            this.lbl_OgrID.AutoSize = true;
            this.lbl_OgrID.Location = new System.Drawing.Point(12, 379);
            this.lbl_OgrID.Name = "lbl_OgrID";
            this.lbl_OgrID.Size = new System.Drawing.Size(111, 25);
            this.lbl_OgrID.TabIndex = 1;
            this.lbl_OgrID.Text = "Ogrenci ID:";
            // 
            // lbl_Ders
            // 
            this.lbl_Ders.AutoSize = true;
            this.lbl_Ders.Location = new System.Drawing.Point(12, 454);
            this.lbl_Ders.Name = "lbl_Ders";
            this.lbl_Ders.Size = new System.Drawing.Size(59, 25);
            this.lbl_Ders.TabIndex = 2;
            this.lbl_Ders.Text = "Ders:";
            // 
            // lbl_S1
            // 
            this.lbl_S1.AutoSize = true;
            this.lbl_S1.Location = new System.Drawing.Point(12, 496);
            this.lbl_S1.Name = "lbl_S1";
            this.lbl_S1.Size = new System.Drawing.Size(89, 25);
            this.lbl_S1.TabIndex = 3;
            this.lbl_S1.Text = "1. Sınav:";
            // 
            // txt_OgrID
            // 
            this.txt_OgrID.Location = new System.Drawing.Point(140, 374);
            this.txt_OgrID.Name = "txt_OgrID";
            this.txt_OgrID.Size = new System.Drawing.Size(121, 30);
            this.txt_OgrID.TabIndex = 4;
            // 
            // cmbders
            // 
            this.cmbders.FormattingEnabled = true;
            this.cmbders.Location = new System.Drawing.Point(140, 449);
            this.cmbders.Name = "cmbders";
            this.cmbders.Size = new System.Drawing.Size(121, 33);
            this.cmbders.TabIndex = 5;
            // 
            // txtsinav1
            // 
            this.txtsinav1.Location = new System.Drawing.Point(140, 488);
            this.txtsinav1.Name = "txtsinav1";
            this.txtsinav1.Size = new System.Drawing.Size(121, 30);
            this.txtsinav1.TabIndex = 6;
            // 
            // txtsinav2
            // 
            this.txtsinav2.Location = new System.Drawing.Point(140, 524);
            this.txtsinav2.Name = "txtsinav2";
            this.txtsinav2.Size = new System.Drawing.Size(121, 30);
            this.txtsinav2.TabIndex = 8;
            // 
            // lbl_S2
            // 
            this.lbl_S2.AutoSize = true;
            this.lbl_S2.Location = new System.Drawing.Point(12, 533);
            this.lbl_S2.Name = "lbl_S2";
            this.lbl_S2.Size = new System.Drawing.Size(89, 25);
            this.lbl_S2.TabIndex = 7;
            this.lbl_S2.Text = "2. Sınav:";
            // 
            // txtsinav3
            // 
            this.txtsinav3.Location = new System.Drawing.Point(140, 560);
            this.txtsinav3.Name = "txtsinav3";
            this.txtsinav3.Size = new System.Drawing.Size(121, 30);
            this.txtsinav3.TabIndex = 10;
            // 
            // lbl_S3
            // 
            this.lbl_S3.AutoSize = true;
            this.lbl_S3.Location = new System.Drawing.Point(12, 568);
            this.lbl_S3.Name = "lbl_S3";
            this.lbl_S3.Size = new System.Drawing.Size(89, 25);
            this.lbl_S3.TabIndex = 9;
            this.lbl_S3.Text = "3. Sınav:";
            // 
            // txtproje
            // 
            this.txtproje.Location = new System.Drawing.Point(376, 377);
            this.txtproje.Name = "txtproje";
            this.txtproje.Size = new System.Drawing.Size(121, 30);
            this.txtproje.TabIndex = 12;
            // 
            // lbl_Proje
            // 
            this.lbl_Proje.AutoSize = true;
            this.lbl_Proje.Location = new System.Drawing.Point(280, 374);
            this.lbl_Proje.Name = "lbl_Proje";
            this.lbl_Proje.Size = new System.Drawing.Size(63, 25);
            this.lbl_Proje.TabIndex = 11;
            this.lbl_Proje.Text = "Proje:";
            // 
            // txtortalama
            // 
            this.txtortalama.Location = new System.Drawing.Point(376, 413);
            this.txtortalama.Name = "txtortalama";
            this.txtortalama.Size = new System.Drawing.Size(121, 30);
            this.txtortalama.TabIndex = 14;
            // 
            // lbl_Ort
            // 
            this.lbl_Ort.AutoSize = true;
            this.lbl_Ort.Location = new System.Drawing.Point(280, 418);
            this.lbl_Ort.Name = "lbl_Ort";
            this.lbl_Ort.Size = new System.Drawing.Size(98, 25);
            this.lbl_Ort.TabIndex = 13;
            this.lbl_Ort.Text = "Ortalama:";
            // 
            // txtdurum
            // 
            this.txtdurum.Location = new System.Drawing.Point(376, 449);
            this.txtdurum.Name = "txtdurum";
            this.txtdurum.Size = new System.Drawing.Size(121, 30);
            this.txtdurum.TabIndex = 16;
            // 
            // lbl_Durum
            // 
            this.lbl_Durum.AutoSize = true;
            this.lbl_Durum.Location = new System.Drawing.Point(280, 457);
            this.lbl_Durum.Name = "lbl_Durum";
            this.lbl_Durum.Size = new System.Drawing.Size(76, 25);
            this.lbl_Durum.TabIndex = 15;
            this.lbl_Durum.Text = "Durum:";
            // 
            // btn_Hesapla
            // 
            this.btn_Hesapla.Location = new System.Drawing.Point(285, 494);
            this.btn_Hesapla.Name = "btn_Hesapla";
            this.btn_Hesapla.Size = new System.Drawing.Size(212, 31);
            this.btn_Hesapla.TabIndex = 17;
            this.btn_Hesapla.Text = "Hesapla";
            this.btn_Hesapla.UseVisualStyleBackColor = true;
            this.btn_Hesapla.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Ekle
            // 
            this.btn_Ekle.Location = new System.Drawing.Point(285, 531);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.Size = new System.Drawing.Size(212, 36);
            this.btn_Ekle.TabIndex = 18;
            this.btn_Ekle.Text = "Güncelle - Ekle";
            this.btn_Ekle.UseVisualStyleBackColor = true;
            this.btn_Ekle.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_Temizle
            // 
            this.btn_Temizle.Location = new System.Drawing.Point(285, 573);
            this.btn_Temizle.Name = "btn_Temizle";
            this.btn_Temizle.Size = new System.Drawing.Size(212, 30);
            this.btn_Temizle.TabIndex = 19;
            this.btn_Temizle.Text = "Temizle";
            this.btn_Temizle.UseVisualStyleBackColor = true;
            this.btn_Temizle.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(140, 410);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(121, 33);
            this.button4.TabIndex = 20;
            this.button4.Text = "Ara";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // FrmSinavNotlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1200, 663);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btn_Temizle);
            this.Controls.Add(this.btn_Ekle);
            this.Controls.Add(this.btn_Hesapla);
            this.Controls.Add(this.txtdurum);
            this.Controls.Add(this.lbl_Durum);
            this.Controls.Add(this.txtortalama);
            this.Controls.Add(this.lbl_Ort);
            this.Controls.Add(this.txtproje);
            this.Controls.Add(this.lbl_Proje);
            this.Controls.Add(this.txtsinav3);
            this.Controls.Add(this.lbl_S3);
            this.Controls.Add(this.txtsinav2);
            this.Controls.Add(this.lbl_S2);
            this.Controls.Add(this.txtsinav1);
            this.Controls.Add(this.cmbders);
            this.Controls.Add(this.txt_OgrID);
            this.Controls.Add(this.lbl_S1);
            this.Controls.Add(this.lbl_Ders);
            this.Controls.Add(this.lbl_OgrID);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmSinavNotlar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSinavNotlar";
            this.Load += new System.EventHandler(this.FrmSinavNotlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl_OgrID;
        private System.Windows.Forms.Label lbl_Ders;
        private System.Windows.Forms.Label lbl_S1;
        private System.Windows.Forms.TextBox txt_OgrID;
        private System.Windows.Forms.ComboBox cmbders;
        private System.Windows.Forms.TextBox txtsinav1;
        private System.Windows.Forms.TextBox txtsinav2;
        private System.Windows.Forms.Label lbl_S2;
        private System.Windows.Forms.TextBox txtsinav3;
        private System.Windows.Forms.Label lbl_S3;
        private System.Windows.Forms.TextBox txtproje;
        private System.Windows.Forms.Label lbl_Proje;
        private System.Windows.Forms.TextBox txtortalama;
        private System.Windows.Forms.Label lbl_Ort;
        private System.Windows.Forms.TextBox txtdurum;
        private System.Windows.Forms.Label lbl_Durum;
        private System.Windows.Forms.Button btn_Hesapla;
        private System.Windows.Forms.Button btn_Ekle;
        private System.Windows.Forms.Button btn_Temizle;
        private System.Windows.Forms.Button button4;
    }
}