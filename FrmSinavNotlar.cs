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
    public partial class FrmSinavNotlar : Form
    {
        public FrmSinavNotlar()
        {
            InitializeComponent();
        }

        DataSet1TableAdapters.Tbl_NotlarTableAdapter ds = new DataSet1TableAdapters.Tbl_NotlarTableAdapter();

        SqlConnection baglanti = new SqlConnection(@"Data Source=HARUN\SQLEXPRESS;Initial Catalog=OkulProje;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");

        int notId;
        private void FrmSinavNotlar_Load(object sender, EventArgs e)
        {
            
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from Tbl_Dersler", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbders.DisplayMember = "Ders_Ad";
            cmbders.ValueMember = "Ders_Id";
            cmbders.DataSource = dt;
            baglanti.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.NotListesi(int.Parse(txt_OgrID.Text));
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            notId=int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            txt_OgrID.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtsinav1.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtsinav2.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtsinav3.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtproje.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtortalama.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            txtdurum.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();



        }
        int sinav1, sinav2, sinav3, proje;

        private void button3_Click(object sender, EventArgs e)
        {
            txtdurum.Text = "";
            txtortalama.Text = "";
            txtproje.Text = "";
            txtsinav1.Text = "";
            txtsinav2.Text = "";
            txtsinav3.Text = "";
            txt_OgrID.Text = "";
        }

        double ortalama;
        private void button1_Click(object sender, EventArgs e)
        {
            
 
            sinav1=Convert.ToInt16(txt_OgrID.Text);
            sinav2 = Convert.ToInt16(txtsinav1.Text);
            sinav3 = Convert.ToInt16(txtsinav2.Text);
            proje = Convert.ToInt16(txtsinav3.Text);
            ortalama=(sinav1+sinav2+sinav3+proje)/4.00;
            txtortalama.Text=ortalama.ToString();
            if (ortalama >= 35)
            {
                txtdurum.Text="True";
            }
            else
            {
                txtdurum.Text="False";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ds.NotGuncelle(
                   byte.Parse(cmbders.SelectedValue.ToString()), 
                   int.Parse(txt_OgrID.Text), 
                   byte.Parse(txtsinav1.Text), 
                   byte.Parse(txtsinav2.Text), 
                   byte.Parse(txtsinav3.Text),
                   byte.Parse(txtproje.Text), 
                   decimal.Parse(txtortalama.Text), 
                   bool.Parse(txtdurum.Text),  
                   notId 
               );
 

        }
    }
}
