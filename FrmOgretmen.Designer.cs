namespace Okul
{
    partial class FrmOgretmen
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
            this.btn_Ders = new System.Windows.Forms.Button();
            this.btn_Kulup = new System.Windows.Forms.Button();
            this.btn_Sinav = new System.Windows.Forms.Button();
            this.btn_Ogr = new System.Windows.Forms.Button();
            this.btn_Cikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Ders
            // 
            this.btn_Ders.Location = new System.Drawing.Point(146, 14);
            this.btn_Ders.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Ders.Name = "btn_Ders";
            this.btn_Ders.Size = new System.Drawing.Size(225, 78);
            this.btn_Ders.TabIndex = 0;
            this.btn_Ders.Text = "Ders İşlemleri";
            this.btn_Ders.UseVisualStyleBackColor = true;
            this.btn_Ders.Click += new System.EventHandler(this.btn_Ders_Click);
            // 
            // btn_Kulup
            // 
            this.btn_Kulup.Location = new System.Drawing.Point(146, 101);
            this.btn_Kulup.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Kulup.Name = "btn_Kulup";
            this.btn_Kulup.Size = new System.Drawing.Size(225, 78);
            this.btn_Kulup.TabIndex = 1;
            this.btn_Kulup.Text = "Kulüp İşlemleri";
            this.btn_Kulup.UseVisualStyleBackColor = true;
            this.btn_Kulup.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_Sinav
            // 
            this.btn_Sinav.Location = new System.Drawing.Point(146, 190);
            this.btn_Sinav.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Sinav.Name = "btn_Sinav";
            this.btn_Sinav.Size = new System.Drawing.Size(225, 78);
            this.btn_Sinav.TabIndex = 2;
            this.btn_Sinav.Text = "Sınav Notları";
            this.btn_Sinav.UseVisualStyleBackColor = true;
            this.btn_Sinav.Click += new System.EventHandler(this.btn_Sinav_Click);
            // 
            // btn_Ogr
            // 
            this.btn_Ogr.Location = new System.Drawing.Point(146, 278);
            this.btn_Ogr.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Ogr.Name = "btn_Ogr";
            this.btn_Ogr.Size = new System.Drawing.Size(225, 78);
            this.btn_Ogr.TabIndex = 3;
            this.btn_Ogr.Text = "Öğrenci İşlemleri";
            this.btn_Ogr.UseVisualStyleBackColor = true;
            this.btn_Ogr.Click += new System.EventHandler(this.btn_Ogr_Click);
            // 
            // btn_Cikis
            // 
            this.btn_Cikis.Location = new System.Drawing.Point(146, 364);
            this.btn_Cikis.Name = "btn_Cikis";
            this.btn_Cikis.Size = new System.Drawing.Size(225, 78);
            this.btn_Cikis.TabIndex = 4;
            this.btn_Cikis.Text = "Çıkış";
            this.btn_Cikis.UseVisualStyleBackColor = true;
            this.btn_Cikis.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmOgretmen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(530, 464);
            this.Controls.Add(this.btn_Cikis);
            this.Controls.Add(this.btn_Ogr);
            this.Controls.Add(this.btn_Sinav);
            this.Controls.Add(this.btn_Kulup);
            this.Controls.Add(this.btn_Ders);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmOgretmen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğretmen Ekranı";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Ders;
        private System.Windows.Forms.Button btn_Kulup;
        private System.Windows.Forms.Button btn_Sinav;
        private System.Windows.Forms.Button btn_Ogr;
        private System.Windows.Forms.Button btn_Cikis;
    }
}