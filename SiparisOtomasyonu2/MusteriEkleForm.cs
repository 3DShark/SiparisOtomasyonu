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
    public partial class MusteriEkleForm : Form
    {
        siparis_OtomasyonuEntities db;
        public SqlConnection baglanti;
        public SqlCommand komut;
        public SqlDataAdapter data;

        public MusteriEkleForm()
        {
            InitializeComponent();
        }

        void MusteriGetir()
        {
            dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            db = new siparis_OtomasyonuEntities();
            dataGridView1.DataSource = db.MusterilerTable.ToList();
            this.dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[8].Visible = false;

            /*
            baglanti = new SqlConnection("Data Source=DESKTOP-QRHKDRF\\SQLEXPRESS;Initial Catalog=siparis_Otomasyonu;Integrated Security=True");
            baglanti.Open();
            data = new SqlDataAdapter("SELECT * FROM MusterilerTable", baglanti);
            DataTable tablo = new DataTable();
            data.Fill(tablo);
           
            baglanti.Close();
            */

        }



        private void MusteriEkle_Load(object sender, EventArgs e)
        {
            MusteriGetir();
        }
        

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtAd.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtSoyad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtAdres.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtTelefon.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();

            string kontrol = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            if(kontrol == "1")
            {
                radioAdmin.Checked = true;
                radioKullanici.Checked = false;

            }
            else
            {
                
                radioKullanici.Checked = true;
                radioAdmin.Checked = false;
            }
            txtKadi.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtSifre.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();

        }

        private void EkleBtn_Click(object sender, EventArgs e)
        {
            MusterilerTable musteriler = new MusterilerTable();
            musteriler.Ad = txtAd.Text;
            musteriler.Soyad = txtSoyad.Text;
            musteriler.Adres = txtAdres.Text;
            musteriler.Telefon = txtTelefon.Text;
            if (radioAdmin.Checked == true)
            {
                musteriler.MusteriTipi = 1;

            }
            else
            {
                musteriler.MusteriTipi = 2;
            }

            
            musteriler.KullaniciAdi = txtKadi.Text;
            musteriler.Sifre = txtSifre.Text;
            db.MusterilerTable.Add(musteriler);
            db.SaveChanges();
            MusteriGetir();
            /*
            string sorgu = "INSERT INTO MusterilerTable(Ad,Soyad,Adres,Telefon,MusteriTipi,KullaniciAdi,Sifre) VALUES (@Ad,@Soyad,@Adres,@Telefon,@MusteriTipi,@KullaniciAdi,@Sifre)";

            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@Ad", txtAd.Text);
            komut.Parameters.AddWithValue("@Soyad", txtSoyad.Text);
            komut.Parameters.AddWithValue("@Adres", txtAdres.Text);
            komut.Parameters.AddWithValue("@Telefon", txtTelefon.Text);
            if(radioAdmin.Checked == true)
            {
                komut.Parameters.AddWithValue("@MusteriTipi", "1");

            }
            else
            {
                komut.Parameters.AddWithValue("@MusteriTipi", "2");
            }
            
            komut.Parameters.AddWithValue("@KullaniciAdi", txtKadi.Text);
            komut.Parameters.AddWithValue("@Sifre", txtSifre.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();*/



        }

        private void temizleBtn_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtAd.Text = "";
            txtSoyad.Text = "";
            txtAdres.Text = "";
            txtTelefon.Text = "";

             
            radioKullanici.Checked = false;
            radioAdmin.Checked = false;

            txtKadi.Text = "";
            txtSifre.Text = "";
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
        private void GüncelleBtn_Click(object sender, EventArgs e)
        {
            int güncellenecekId = Convert.ToInt32(txtId.Text);
            var guncellenecekMusteri = db.MusterilerTable.Where(w => w.MusterilerId == güncellenecekId).FirstOrDefault();

            guncellenecekMusteri.Ad = txtAd.Text;
            guncellenecekMusteri.Soyad = txtSoyad.Text;
            guncellenecekMusteri.Adres = txtAdres.Text;
            guncellenecekMusteri.Telefon = txtTelefon.Text;
            if (radioAdmin.Checked == true)
            {
                guncellenecekMusteri.MusteriTipi = 1;

            }
            else
            {
                guncellenecekMusteri.MusteriTipi = 2;
            }

            guncellenecekMusteri.KullaniciAdi = txtKadi.Text;
            guncellenecekMusteri.Sifre = txtSifre.Text;
            db.SaveChanges();

            MusteriGetir();
            /*
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@MusterilerId", Convert.ToInt32(txtId.Text));
            komut.Parameters.AddWithValue("@Ad", txtAd.Text);
            komut.Parameters.AddWithValue("@Soyad", txtSoyad.Text);
            komut.Parameters.AddWithValue("@Adres", txtAdres.Text);
            komut.Parameters.AddWithValue("@Telefon", txtTelefon.Text);
            if (radioAdmin.Checked == true)
            {
                komut.Parameters.AddWithValue("@MusteriTipi", "1");

            }
            else
            {
                komut.Parameters.AddWithValue("@MusteriTipi", "2");
            }
            komut.Parameters.AddWithValue("@KullaniciAdi", txtKadi.Text);
            komut.Parameters.AddWithValue("@Sifre", txtSifre.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            */


        }

        private void SilBtn_Click(object sender, EventArgs e)
        {
            int güncellenecekId = Convert.ToInt32(txtId.Text);
            var silinecekKisi = db.MusterilerTable.Where(w => w.MusterilerId == güncellenecekId).FirstOrDefault();
            db.MusterilerTable.Remove(silinecekKisi);
            db.SaveChanges();
            MusteriGetir();
            /*
            string sorgu = "DELETE FROM MusterilerTable WHERE MusterilerId=@MusterilerId";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@MusterilerId", Convert.ToInt32(txtId.Text));
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            */




        }
    }
}
