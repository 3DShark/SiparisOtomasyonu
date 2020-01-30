using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiparisOtomasyonu2
{
    public partial class ProfilForm : Form
    {

        public void MusteriDoldur()
        {
            txtAd.Text = KullaniciBilgisi.Ad;
            txtSoyad.Text = KullaniciBilgisi.Soyad;
            txtAdres.Text = KullaniciBilgisi.Adres;
            txtTelefon.Text = KullaniciBilgisi.Telefon;
            txtKadi.Text = KullaniciBilgisi.KullaniciAdi;
            txtSifre.Text = KullaniciBilgisi.Sifre;
        }
        public ProfilForm()
        {
            InitializeComponent();
            MusteriDoldur();
        }
        public siparis_OtomasyonuEntities db;

        private void button1_Click(object sender, EventArgs e)
        {
            db = new siparis_OtomasyonuEntities();
            
            var guncellenecekMusteri = db.MusterilerTable.Where(w => w.MusterilerId == KullaniciBilgisi.MusterilerId).FirstOrDefault();

            guncellenecekMusteri.Ad = txtAd.Text;
            guncellenecekMusteri.Soyad = txtSoyad.Text;
            guncellenecekMusteri.Adres = txtAdres.Text;
            guncellenecekMusteri.Telefon = txtTelefon.Text;
            guncellenecekMusteri.MusteriTipi = 2;
            guncellenecekMusteri.KullaniciAdi = txtKadi.Text;
            guncellenecekMusteri.Sifre = txtSifre.Text;
            db.SaveChanges();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.MdiParent = this.ParentForm;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            frm2.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm2.Dock = DockStyle.Fill;
            this.Hide();
            frm2.Show();
        }
    }
}
