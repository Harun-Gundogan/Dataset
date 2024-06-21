using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Okul
{
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pcr_Ogrenci_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_Number.Text == "")
                {
                    MessageBox.Show("Lütfen öğrenci numarasını giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    FrmOgrenciNotlar frm = new FrmOgrenciNotlar();
                    frm.numara = txt_Number.Text;
                    frm.Show();
                    this.Hide();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Lütfen girdiğiniz bilgileri kontrol ediniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
           
           
        }

        private void pcr_Ogretmen_Click(object sender, EventArgs e)
        {
            FrmOgretmen frm = new FrmOgretmen();
           
            frm.Show();
            this.Hide();
        }
    }
}
