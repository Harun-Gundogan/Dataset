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

namespace Okul
{
    public partial class FrmOgrenciNotlar : Form
    {
        public FrmOgrenciNotlar()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=HARUN\SQLEXPRESS;Initial Catalog=OkulProje;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");

        public string numara;
        private void FrmOgrenciNotlar_Load(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("select ders_ad, sinav_1, sinav_2, sinav_3, proje, ortalama, durum from Tbl_Notlar inner join Tbl_Dersler on Tbl_Notlar.Ders_Id=Tbl_Dersler.Ders_Id where Ogr_Id=@p1", baglanti);
                komut.Parameters.AddWithValue("@p1", numara);
                //this.Text=numara.ToString();
                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception)
            {

                MessageBox.Show("Hata Oluştu","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
