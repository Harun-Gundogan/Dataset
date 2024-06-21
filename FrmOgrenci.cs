using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Windows.Forms.VisualStyles;

namespace Okul
{
    public partial class FrmOgrenci : Form
    {
        public FrmOgrenci()
        {
            InitializeComponent();
        }
        DataSet1TableAdapters.DataTable1TableAdapter ds = new DataSet1TableAdapters.DataTable1TableAdapter();
        SqlConnection baglanti = new SqlConnection(@"Data Source=HARUN\SQLEXPRESS;Initial Catalog=OkulProje;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        private void FrmOgrenci_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.OgrenciListesi();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from Tbl_Kulupler",baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmb_Kulup.DisplayMember = "Kulup_Ad";
            cmb_Kulup.ValueMember= "Kulup_Id";
            cmb_Kulup.DataSource = dt;
            baglanti.Close();
        }
        string c = "";
        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_OgrAd.Text == "" || txt_OgrId.Text == "" || txt_OgrSoyad.Text == "")
                {
                    MessageBox.Show("Lütfen ilgili alanları doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    ds.OgrenciEkle(txt_OgrAd.Text, txt_OgrSoyad.Text, byte.Parse(cmb_Kulup.SelectedValue.ToString()), c);
                    MessageBox.Show("Öğrenci Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = ds.OgrenciListesi();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Bir Hata Oluştu", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                txt_Ara.Text = "";
                txt_OgrAd.Text = "";
                txt_OgrId.Text = "";
                txt_OgrSoyad.Text = "";
            }
           
        }

        private void btn_Listele_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = ds.OgrenciListesi();
            }
            catch (Exception)
            {

                MessageBox.Show("Bir Hata Oluştu","Hata",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                txt_Ara.Text = "";
                txt_OgrAd.Text = "";
                txt_OgrId.Text = "";
                txt_OgrSoyad.Text = "";
            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_OgrAd.Text == "" || txt_OgrId.Text == "" || txt_OgrSoyad.Text == "")
                {
                    MessageBox.Show("Lütfen ilgili alanları doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    ds.OgrenciSil(int.Parse(txt_OgrId.Text));
                    MessageBox.Show("Öğrenci Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dataGridView1.DataSource = ds.OgrenciListesi();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Bir Hata Oluştu", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                txt_Ara.Text = "";
                txt_OgrAd.Text = "";
                txt_OgrId.Text = "";
                txt_OgrSoyad.Text = "";
               

            }
           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_OgrId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_OgrAd.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_OgrSoyad.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            cmb_Kulup.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            c = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();

            if (c == "Kız")
            {
                rdbtn_Kiz.Checked = true;
                rdbtn_Erkek.Checked = false;
            }
           if(c == "Erkek")
            {
                rdbtn_Kiz.Checked = false;
                rdbtn_Erkek.Checked = true;
            }
        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if(txt_OgrAd.Text==""||txt_OgrId.Text==""||txt_OgrSoyad.Text=="")
                {
                    MessageBox.Show("Lütfen ilgili alanları doldurunuz.","Uyarı",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    ds.OgrenciGuncelle(txt_OgrAd.Text, txt_OgrSoyad.Text, byte.Parse(cmb_Kulup.SelectedValue.ToString()), c, int.Parse(txt_OgrId.Text));
                    MessageBox.Show("Öğrenci Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = ds.OgrenciListesi();
                }
                
            }
            catch (Exception)
            {

                MessageBox.Show("Bir Hata Oluştu", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                txt_Ara.Text = "";
                txt_OgrAd.Text = "";
                txt_OgrId.Text = "";
                txt_OgrSoyad.Text = "";
            }
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtn_Kiz.Checked == true)
            {
                c = "Kız";
            }
           
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
           
            if (rdbtn_Erkek.Checked == true)
            {
                c = "Erkek";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = ds.OgrenciGetir(txt_Ara.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Bir Hata Oluştu", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                txt_Ara.Text = "";
                txt_OgrAd.Text = "";
                txt_OgrId.Text = "";
                txt_OgrSoyad.Text = "";
            }
          
        }

        private void lbl_Kulup_Click(object sender, EventArgs e)
        {

        }
    }
}
