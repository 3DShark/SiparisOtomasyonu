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
 
namespace SiparisOtomasyonu2
{
    public partial class UrunForm : Form
    {
        /*
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter data;*/
        public siparis_OtomasyonuEntities db;
        public UrunForm()
        {
            InitializeComponent();
        }

        void UrunleriGetir()
        {
            dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            
            db = new siparis_OtomasyonuEntities();
            dataGridView1.DataSource = db.UrunlerTable.ToList();
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;


            /*
            baglanti = new SqlConnection("Data Source=DESKTOP-QRHKDRF\\SQLEXPRESS;Initial Catalog=siparis_Otomasyonu;Integrated Security=True");
            baglanti.Open();
            data = new SqlDataAdapter("SELECT * FROM UrunlerTable", baglanti);
            DataTable tablo = new DataTable();
            data.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close(); */


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UrunForm_Load(object sender, EventArgs e)
        {
            UrunleriGetir();

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            
            txtUrunId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtUrunAdi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtUrunFiyat.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            string kontrol = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            if (kontrol == "Elektronik")
            {
                comboUrunKategori.Text = "Elektronik";
            }
            else if(kontrol == "Giyim")
            {
                comboUrunKategori.Text = "Giyim";
            }
            else
            {
                comboUrunKategori.Text = "Kitap";
            }

            txtUrunAciklamasi.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void temizleBtn_Click(object sender, EventArgs e)
        {
            txtUrunId.Text = "";
            txtUrunAdi.Text = "";
            txtUrunFiyat.Text = "";
            comboUrunKategori.Text = "";
            txtUrunAciklamasi.Text = "";
        }

        private void EkleBtn_Click(object sender, EventArgs e)
        {
            UrunlerTable urunler = new UrunlerTable();
            urunler.UrunAdı = txtUrunAdi.Text;
            urunler.UrunFiyat = Convert.ToDouble(txtUrunFiyat.Text);
            urunler.UrunKategori = comboUrunKategori.Text;
            urunler.UrunAciklama = txtUrunAciklamasi.Text;
            
            db.UrunlerTable.Add(urunler);
            db.SaveChanges();
            
          
            /*
            string sorgu = "INSERT INTO UrunlerTable(UrunAdı,UrunFiyat,UrunKategori,UrunAciklama) VALUES (@UrunAdı,@UrunFiyat,@UrunKategori,@UrunAciklama)";

            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@UrunAdı", txtUrunAdi.Text);
            komut.Parameters.AddWithValue("@UrunFiyat", Convert.ToDouble(txtUrunFiyat.Text));
            komut.Parameters.AddWithValue("@UrunKategori", comboUrunKategori.Text);
            komut.Parameters.AddWithValue("@UrunAciklama", txtUrunAciklamasi.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close(); */

            UrunleriGetir();


        }

        private void SilBtn_Click(object sender, EventArgs e)
        {
            int silinecekid = Convert.ToInt32(txtUrunId.Text);
            var silinicekKisi = db.UrunlerTable.Where(w => w.UrunId == silinecekid).FirstOrDefault();
            db.UrunlerTable.Remove(silinicekKisi);
            db.SaveChanges();
            

            /*
            string sorgu = "DELETE FROM UrunlerTable WHERE UrunId=@UrunId";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@UrunId", Convert.ToInt32(txtUrunId.Text));
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            */
            UrunleriGetir();
        }

        private void GüncelleBtn_Click(object sender, EventArgs e)
        {
            int güncellenecekId = Convert.ToInt32(txtUrunId.Text);
            var guncellenecekUrun = db.UrunlerTable.Where(w => w.UrunId == güncellenecekId).FirstOrDefault();
            guncellenecekUrun.UrunAdı = txtUrunAdi.Text;
            guncellenecekUrun.UrunFiyat = Convert.ToInt32(txtUrunFiyat.Text);
            guncellenecekUrun.UrunKategori = comboUrunKategori.Text;
            guncellenecekUrun.UrunAciklama = txtUrunAciklamasi.Text;
            db.SaveChanges();
            /*
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@UrunId",Convert.ToInt32(txtUrunId.Text));
            komut.Parameters.AddWithValue("@UrunAdı", txtUrunAdi.Text);
            komut.Parameters.AddWithValue("@UrunFiyat", Convert.ToDouble(txtUrunFiyat.Text));
            komut.Parameters.AddWithValue("@UrunKategori", comboUrunKategori.Text);
            komut.Parameters.AddWithValue("@UrunAciklama", txtUrunAciklamasi.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            */
            UrunleriGetir();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AdminForm admn = new AdminForm();
            admn.MdiParent = this.ParentForm;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            admn.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            admn.Dock = DockStyle.Fill;
            this.Hide();
            admn.Show();
        }
    }
}
