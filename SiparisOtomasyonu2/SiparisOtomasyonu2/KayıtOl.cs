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
    public partial class KayıtOl : Form
    {
        public KayıtOl()
        {
            InitializeComponent();
        }
        public siparis_OtomasyonuEntities db;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.MdiParent = this.ParentForm;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            frm1.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm1.Dock = DockStyle.Fill;
            this.Hide();
            frm1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            db = new siparis_OtomasyonuEntities();
            MusterilerTable musteriler = new MusterilerTable();
            musteriler.Ad = txtAd.Text;
            musteriler.Soyad = txtSoyad.Text;
            musteriler.Adres = txtAdres.Text;
            musteriler.Telefon = txtTelefon.Text;

            musteriler.MusteriTipi = 2;

            musteriler.KullaniciAdi = txtKadi.Text;
            musteriler.Sifre = txtSifre.Text;
            db.MusterilerTable.Add(musteriler);
            db.SaveChanges();

            Form1 frm1 = new Form1();
            frm1.MdiParent = this.ParentForm;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            frm1.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm1.Dock = DockStyle.Fill;
            this.Hide();
            frm1.Show();
        }

        private void KayıtOl_Load(object sender, EventArgs e)
        {

        }
    }
}
