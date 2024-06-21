namespace Okul
{
    partial class FrmOgrenci
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
            this.btn_Sil = new System.Windows.Forms.Button();
            this.btn_Guncelle = new System.Windows.Forms.Button();
            this.btn_Ekle = new System.Windows.Forms.Button();
            this.btn_Listele = new System.Windows.Forms.Button();
            this.txt_OgrAd = new System.Windows.Forms.TextBox();
            this.txt_OgrId = new System.Windows.Forms.TextBox();
            this.lbl_Ad = new System.Windows.Forms.Label();
            this.lbl_OgrId = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbl_Panel = new System.Windows.Forms.Label();
            this.txt_OgrSoyad = new System.Windows.Forms.TextBox();
            this.lbl_Kulup = new System.Windows.Forms.Label();
            this.lbl_Soyad = new System.Windows.Forms.Label();
            this.cmb_Kulup = new System.Windows.Forms.ComboBox();
            this.rdbtn_Kiz = new System.Windows.Forms.RadioButton();
            this.rdbtn_Erkek = new System.Windows.Forms.RadioButton();
            this.lbl_Cinsiyet = new System.Windows.Forms.Label();
            this.btn_Ara = new System.Windows.Forms.Button();
            this.txt_Ara = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Sil
            // 
            this.btn_Sil.Location = new System.Drawing.Point(157, 482);
            this.btn_Sil.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(112, 36);
            this.btn_Sil.TabIndex = 15;
            this.btn_Sil.Text = "Sil";
            this.btn_Sil.UseVisualStyleBackColor = true;
            this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click);
            // 
            // btn_Guncelle
            // 
            this.btn_Guncelle.Location = new System.Drawing.Point(157, 436);
            this.btn_Guncelle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Guncelle.Name = "btn_Guncelle";
            this.btn_Guncelle.Size = new System.Drawing.Size(112, 36);
            this.btn_Guncelle.TabIndex = 13;
            this.btn_Guncelle.Text = "Güncelle";
            this.btn_Guncelle.UseVisualStyleBackColor = true;
            this.btn_Guncelle.Click += new System.EventHandler(this.btn_Guncelle_Click);
            // 
            // btn_Ekle
            // 
            this.btn_Ekle.Location = new System.Drawing.Point(18, 482);
            this.btn_Ekle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.Size = new System.Drawing.Size(112, 36);
            this.btn_Ekle.TabIndex = 14;
            this.btn_Ekle.Text = "Ekle";
            this.btn_Ekle.UseVisualStyleBackColor = true;
            this.btn_Ekle.Click += new System.EventHandler(this.btn_Ekle_Click);
            // 
            // btn_Listele
            // 
            this.btn_Listele.Location = new System.Drawing.Point(18, 436);
            this.btn_Listele.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Listele.Name = "btn_Listele";
            this.btn_Listele.Size = new System.Drawing.Size(112, 36);
            this.btn_Listele.TabIndex = 12;
            this.btn_Listele.Text = "Listele";
            this.btn_Listele.UseVisualStyleBackColor = true;
            this.btn_Listele.Click += new System.EventHandler(this.btn_Listele_Click);
            // 
            // txt_OgrAd
            // 
            this.txt_OgrAd.Location = new System.Drawing.Point(121, 346);
            this.txt_OgrAd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_OgrAd.Name = "txt_OgrAd";
            this.txt_OgrAd.Size = new System.Drawing.Size(148, 30);
            this.txt_OgrAd.TabIndex = 3;
            // 
            // txt_OgrId
            // 
            this.txt_OgrId.Enabled = false;
            this.txt_OgrId.Location = new System.Drawing.Point(394, 346);
            this.txt_OgrId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_OgrId.Name = "txt_OgrId";
            this.txt_OgrId.Size = new System.Drawing.Size(148, 30);
            this.txt_OgrId.TabIndex = 7;
            // 
            // lbl_Ad
            // 
            this.lbl_Ad.AutoSize = true;
            this.lbl_Ad.Location = new System.Drawing.Point(13, 349);
            this.lbl_Ad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Ad.Name = "lbl_Ad";
            this.lbl_Ad.Size = new System.Drawing.Size(47, 25);
            this.lbl_Ad.TabIndex = 1;
            this.lbl_Ad.Text = "Adı:";
            // 
            // lbl_OgrId
            // 
            this.lbl_OgrId.AutoSize = true;
            this.lbl_OgrId.Location = new System.Drawing.Point(285, 349);
            this.lbl_OgrId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_OgrId.Name = "lbl_OgrId";
            this.lbl_OgrId.Size = new System.Drawing.Size(111, 25);
            this.lbl_OgrId.TabIndex = 5;
            this.lbl_OgrId.Text = "Öğrenci ID:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 41);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(976, 286);
            this.dataGridView1.TabIndex = 78;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // lbl_Panel
            // 
            this.lbl_Panel.AutoSize = true;
            this.lbl_Panel.Location = new System.Drawing.Point(8, 11);
            this.lbl_Panel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Panel.Name = "lbl_Panel";
            this.lbl_Panel.Size = new System.Drawing.Size(216, 25);
            this.lbl_Panel.TabIndex = 80;
            this.lbl_Panel.Text = "Öğrenci İşlemleri Paneli";
            // 
            // txt_OgrSoyad
            // 
            this.txt_OgrSoyad.Location = new System.Drawing.Point(121, 392);
            this.txt_OgrSoyad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_OgrSoyad.Name = "txt_OgrSoyad";
            this.txt_OgrSoyad.Size = new System.Drawing.Size(148, 30);
            this.txt_OgrSoyad.TabIndex = 4;
            // 
            // lbl_Kulup
            // 
            this.lbl_Kulup.AutoSize = true;
            this.lbl_Kulup.Location = new System.Drawing.Point(285, 392);
            this.lbl_Kulup.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Kulup.Name = "lbl_Kulup";
            this.lbl_Kulup.Size = new System.Drawing.Size(80, 25);
            this.lbl_Kulup.TabIndex = 6;
            this.lbl_Kulup.Text = "Kulübü:";
            this.lbl_Kulup.Click += new System.EventHandler(this.lbl_Kulup_Click);
            // 
            // lbl_Soyad
            // 
            this.lbl_Soyad.AutoSize = true;
            this.lbl_Soyad.Location = new System.Drawing.Point(13, 392);
            this.lbl_Soyad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Soyad.Name = "lbl_Soyad";
            this.lbl_Soyad.Size = new System.Drawing.Size(79, 25);
            this.lbl_Soyad.TabIndex = 2;
            this.lbl_Soyad.Text = "Soyadı:";
            // 
            // cmb_Kulup
            // 
            this.cmb_Kulup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Kulup.FormattingEnabled = true;
            this.cmb_Kulup.Location = new System.Drawing.Point(394, 392);
            this.cmb_Kulup.Name = "cmb_Kulup";
            this.cmb_Kulup.Size = new System.Drawing.Size(148, 33);
            this.cmb_Kulup.TabIndex = 8;
            this.cmb_Kulup.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // rdbtn_Kiz
            // 
            this.rdbtn_Kiz.AutoSize = true;
            this.rdbtn_Kiz.Location = new System.Drawing.Point(574, 388);
            this.rdbtn_Kiz.Name = "rdbtn_Kiz";
            this.rdbtn_Kiz.Size = new System.Drawing.Size(61, 29);
            this.rdbtn_Kiz.TabIndex = 10;
            this.rdbtn_Kiz.TabStop = true;
            this.rdbtn_Kiz.Text = "Kız";
            this.rdbtn_Kiz.UseVisualStyleBackColor = true;
            this.rdbtn_Kiz.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rdbtn_Erkek
            // 
            this.rdbtn_Erkek.AutoSize = true;
            this.rdbtn_Erkek.Location = new System.Drawing.Point(574, 423);
            this.rdbtn_Erkek.Name = "rdbtn_Erkek";
            this.rdbtn_Erkek.Size = new System.Drawing.Size(83, 29);
            this.rdbtn_Erkek.TabIndex = 11;
            this.rdbtn_Erkek.TabStop = true;
            this.rdbtn_Erkek.Text = "Erkek";
            this.rdbtn_Erkek.UseVisualStyleBackColor = true;
            this.rdbtn_Erkek.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // lbl_Cinsiyet
            // 
            this.lbl_Cinsiyet.AutoSize = true;
            this.lbl_Cinsiyet.Location = new System.Drawing.Point(569, 349);
            this.lbl_Cinsiyet.Name = "lbl_Cinsiyet";
            this.lbl_Cinsiyet.Size = new System.Drawing.Size(88, 25);
            this.lbl_Cinsiyet.TabIndex = 9;
            this.lbl_Cinsiyet.Text = "Cinsiyet:";
            // 
            // btn_Ara
            // 
            this.btn_Ara.Location = new System.Drawing.Point(394, 440);
            this.btn_Ara.Name = "btn_Ara";
            this.btn_Ara.Size = new System.Drawing.Size(148, 36);
            this.btn_Ara.TabIndex = 16;
            this.btn_Ara.Text = "Ara";
            this.btn_Ara.UseVisualStyleBackColor = true;
            this.btn_Ara.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_Ara
            // 
            this.txt_Ara.Location = new System.Drawing.Point(394, 482);
            this.txt_Ara.Name = "txt_Ara";
            this.txt_Ara.Size = new System.Drawing.Size(148, 30);
            this.txt_Ara.TabIndex = 17;
            // 
            // FrmOgrenci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1007, 552);
            this.Controls.Add(this.txt_Ara);
            this.Controls.Add(this.btn_Ara);
            this.Controls.Add(this.lbl_Cinsiyet);
            this.Controls.Add(this.rdbtn_Erkek);
            this.Controls.Add(this.rdbtn_Kiz);
            this.Controls.Add(this.cmb_Kulup);
            this.Controls.Add(this.txt_OgrSoyad);
            this.Controls.Add(this.lbl_Kulup);
            this.Controls.Add(this.lbl_Soyad);
            this.Controls.Add(this.btn_Sil);
            this.Controls.Add(this.btn_Guncelle);
            this.Controls.Add(this.btn_Ekle);
            this.Controls.Add(this.btn_Listele);
            this.Controls.Add(this.txt_OgrAd);
            this.Controls.Add(this.txt_OgrId);
            this.Controls.Add(this.lbl_Ad);
            this.Controls.Add(this.lbl_OgrId);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbl_Panel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmOgrenci";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmOgrenci";
            this.Load += new System.EventHandler(this.FrmOgrenci_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Sil;
        private System.Windows.Forms.Button btn_Guncelle;
        private System.Windows.Forms.Button btn_Ekle;
        private System.Windows.Forms.Button btn_Listele;
        private System.Windows.Forms.TextBox txt_OgrAd;
        private System.Windows.Forms.TextBox txt_OgrId;
        private System.Windows.Forms.Label lbl_Ad;
        private System.Windows.Forms.Label lbl_OgrId;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl_Panel;
        private System.Windows.Forms.TextBox txt_OgrSoyad;
        private System.Windows.Forms.Label lbl_Kulup;
        private System.Windows.Forms.Label lbl_Soyad;
        private System.Windows.Forms.ComboBox cmb_Kulup;
        private System.Windows.Forms.RadioButton rdbtn_Kiz;
        private System.Windows.Forms.RadioButton rdbtn_Erkek;
        private System.Windows.Forms.Label lbl_Cinsiyet;
        private System.Windows.Forms.Button btn_Ara;
        private System.Windows.Forms.TextBox txt_Ara;
    }
}