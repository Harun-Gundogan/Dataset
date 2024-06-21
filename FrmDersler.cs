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
    public partial class FrmDersler : Form
    {
        public FrmDersler()
        {
            InitializeComponent();
        }
        DataSet1TableAdapters.Tbl_DerslerTableAdapter ds = new DataSet1TableAdapters.Tbl_DerslerTableAdapter();
        private void FrmDersler_Load(object sender, EventArgs e)
        {
            
            dataGridView1.DataSource = ds.DersListesi();
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            try
            {
                ds.DersEkle(txt_Kulup_Ad.Text);
                MessageBox.Show("Ders Eklendi","Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = ds.DersListesi();
            }
            catch (Exception)
            {

                MessageBox.Show("Hata Oluştu","Hata",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                txt_Kulup_Id.Text = "";
                txt_Kulup_Ad.Text = "";

            }

        }

        private void btn_Listele_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = ds.DersListesi();
            }
            catch (Exception)
            {

                MessageBox.Show("Hata Oluştu", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            try
            {
                ds.DersSil(byte.Parse(txt_Kulup_Id.Text));
                MessageBox.Show("Ders Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = ds.DersListesi();
            }
            catch (Exception)
            {

               
            }

            finally
            {
                txt_Kulup_Id.Text = "";
                txt_Kulup_Ad.Text = "";

            }
           
        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            try
            {
                ds.DersGuncelle(txt_Kulup_Ad.Text, byte.Parse(txt_Kulup_Id.Text));
                MessageBox.Show("Ders Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = ds.DersListesi();
            }
            catch (Exception)
            {

                MessageBox.Show("Hata Oluştu", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                txt_Kulup_Id.Text = "";
                txt_Kulup_Ad.Text = "";
            }
           

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_Kulup_Id.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_Kulup_Ad.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
    }
}
