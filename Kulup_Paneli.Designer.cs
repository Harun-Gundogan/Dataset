namespace Okul
{
    partial class Kulüp_Paneli
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
            this.lbl_Panel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbl_KulupID = new System.Windows.Forms.Label();
            this.lbl_KulupAd = new System.Windows.Forms.Label();
            this.txt_Kulup_Id = new System.Windows.Forms.TextBox();
            this.txt_Kulup_Ad = new System.Windows.Forms.TextBox();
            this.btn_Listele = new System.Windows.Forms.Button();
            this.btn_Ekle = new System.Windows.Forms.Button();
            this.btn_Guncelle = new System.Windows.Forms.Button();
            this.btn_Sil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Panel
            // 
            this.lbl_Panel.AutoSize = true;
            this.lbl_Panel.Location = new System.Drawing.Point(13, 9);
            this.lbl_Panel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Panel.Name = "lbl_Panel";
            this.lbl_Panel.Size = new System.Drawing.Size(198, 25);
            this.lbl_Panel.TabIndex = 50;
            this.lbl_Panel.Text = "Kulüp İşlemleri Paneli";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 39);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(976, 286);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lbl_KulupID
            // 
            this.lbl_KulupID.AutoSize = true;
            this.lbl_KulupID.Location = new System.Drawing.Point(13, 340);
            this.lbl_KulupID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_KulupID.Name = "lbl_KulupID";
            this.lbl_KulupID.Size = new System.Drawing.Size(93, 25);
            this.lbl_KulupID.TabIndex = 1;
            this.lbl_KulupID.Text = "Kulup ID:";
            // 
            // lbl_KulupAd
            // 
            this.lbl_KulupAd.AutoSize = true;
            this.lbl_KulupAd.Location = new System.Drawing.Point(13, 402);
            this.lbl_KulupAd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_KulupAd.Name = "lbl_KulupAd";
            this.lbl_KulupAd.Size = new System.Drawing.Size(99, 25);
            this.lbl_KulupAd.TabIndex = 5;
            this.lbl_KulupAd.Text = "Kulüp Ad:";
            // 
            // txt_Kulup_Id
            // 
            this.txt_Kulup_Id.Enabled = false;
            this.txt_Kulup_Id.Location = new System.Drawing.Point(121, 340);
            this.txt_Kulup_Id.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Kulup_Id.Name = "txt_Kulup_Id";
            this.txt_Kulup_Id.Size = new System.Drawing.Size(148, 30);
            this.txt_Kulup_Id.TabIndex = 2;
            // 
            // txt_Kulup_Ad
            // 
            this.txt_Kulup_Ad.Location = new System.Drawing.Point(121, 399);
            this.txt_Kulup_Ad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Kulup_Ad.Name = "txt_Kulup_Ad";
            this.txt_Kulup_Ad.Size = new System.Drawing.Size(148, 30);
            this.txt_Kulup_Ad.TabIndex = 6;
            // 
            // btn_Listele
            // 
            this.btn_Listele.Location = new System.Drawing.Point(277, 340);
            this.btn_Listele.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Listele.Name = "btn_Listele";
            this.btn_Listele.Size = new System.Drawing.Size(112, 36);
            this.btn_Listele.TabIndex = 3;
            this.btn_Listele.Text = "Listele";
            this.btn_Listele.UseVisualStyleBackColor = true;
            this.btn_Listele.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Ekle
            // 
            this.btn_Ekle.Location = new System.Drawing.Point(277, 393);
            this.btn_Ekle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.Size = new System.Drawing.Size(112, 36);
            this.btn_Ekle.TabIndex = 7;
            this.btn_Ekle.Text = "Ekle";
            this.btn_Ekle.UseVisualStyleBackColor = true;
            this.btn_Ekle.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_Guncelle
            // 
            this.btn_Guncelle.Location = new System.Drawing.Point(397, 340);
            this.btn_Guncelle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Guncelle.Name = "btn_Guncelle";
            this.btn_Guncelle.Size = new System.Drawing.Size(112, 36);
            this.btn_Guncelle.TabIndex = 4;
            this.btn_Guncelle.Text = "Güncelle";
            this.btn_Guncelle.UseVisualStyleBackColor = true;
            this.btn_Guncelle.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_Sil
            // 
            this.btn_Sil.Location = new System.Drawing.Point(397, 391);
            this.btn_Sil.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(112, 36);
            this.btn_Sil.TabIndex = 8;
            this.btn_Sil.Text = "Sil";
            this.btn_Sil.UseVisualStyleBackColor = true;
            this.btn_Sil.Click += new System.EventHandler(this.button4_Click);
            // 
            // Kulüp_Paneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1009, 456);
            this.Controls.Add(this.btn_Sil);
            this.Controls.Add(this.btn_Guncelle);
            this.Controls.Add(this.btn_Ekle);
            this.Controls.Add(this.btn_Listele);
            this.Controls.Add(this.txt_Kulup_Ad);
            this.Controls.Add(this.txt_Kulup_Id);
            this.Controls.Add(this.lbl_KulupAd);
            this.Controls.Add(this.lbl_KulupID);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbl_Panel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Kulüp_Paneli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kulüp Paneli";
            this.Load += new System.EventHandler(this.Kulüp_Paneli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Panel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl_KulupID;
        private System.Windows.Forms.Label lbl_KulupAd;
        private System.Windows.Forms.TextBox txt_Kulup_Id;
        private System.Windows.Forms.TextBox txt_Kulup_Ad;
        private System.Windows.Forms.Button btn_Listele;
        private System.Windows.Forms.Button btn_Ekle;
        private System.Windows.Forms.Button btn_Guncelle;
        private System.Windows.Forms.Button btn_Sil;
    }
}