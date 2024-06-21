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
    public partial class FrmOgretmen : Form
    {
        public FrmOgretmen()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Kulüp_Paneli frm = new Kulüp_Paneli();

            frm.Show();
           
        }

        private void btn_Ders_Click(object sender, EventArgs e)
        {
            FrmDersler frm = new FrmDersler();

            frm.Show();
            
        }

        private void btn_Ogr_Click(object sender, EventArgs e)
        {
            FrmOgrenci frm = new FrmOgrenci();

            frm.Show();
            
        }

        private void btn_Sinav_Click(object sender, EventArgs e)
        {
            FrmSinavNotlar frm = new FrmSinavNotlar();

            frm.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
