using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Okul
{
    public partial class Kulüp_Paneli : Form
    {
        public Kulüp_Paneli()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=HARUN\SQLEXPRESS;Initial Catalog=OkulProje;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");

        void listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_kulupler", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void Kulüp_Paneli_Load(object sender, EventArgs e)
        {
          listele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_Kulup_Ad.Text == "" || txt_Kulup_Id.Text == "")
                {
                    MessageBox.Show("Lütfen boş yerleri doldurunuz.","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
                else
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("insert into tbl_kulupler (kulup_ad) values (@p1)", baglanti);
                    komut.Parameters.AddWithValue("@p1", txt_Kulup_Ad.Text);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("eklendi");
                    listele();
                }
               
            }
            catch (Exception)
            {

                MessageBox.Show("Hata Oluştu","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error); 
            }
            finally
            {
                txt_Kulup_Ad.Text = "";
                txt_Kulup_Id.Text = "";
            }
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_Kulup_Id.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_Kulup_Ad.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_Kulup_Ad.Text == "" || txt_Kulup_Id.Text == "")
                {
                    MessageBox.Show("Lütfen boş yerleri doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("delete from tbl_kulupler where kulup_Id=@p1", baglanti);
                    komut.Parameters.AddWithValue("@p1", txt_Kulup_Id.Text);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Kulüp Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listele();
                }
            }

            catch (Exception)
            {

                MessageBox.Show("Hata Oluştu","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            finally
            {
                txt_Kulup_Ad.Text = "";
                txt_Kulup_Id.Text = "";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_Kulup_Ad.Text == "" || txt_Kulup_Id.Text == "")
                {
                    MessageBox.Show("Lütfen boş yerleri doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("Update tbl_kulupler set kulup_ad=@p1 where kulup_Id=@p2", baglanti);
                    komut.Parameters.AddWithValue("@p1", txt_Kulup_Ad.Text);
                    komut.Parameters.AddWithValue("@p2", txt_Kulup_Id.Text);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Kulüp Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listele();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Hata Oluştu", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                txt_Kulup_Ad.Text = "";
                txt_Kulup_Id.Text = "";
            }

        }
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
