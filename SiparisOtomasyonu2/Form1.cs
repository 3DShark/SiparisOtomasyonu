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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        siparis_OtomasyonuEntities db;
        

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

       

        private void Giris_Button_Click(object sender, EventArgs e)
        {
            
            db = new siparis_OtomasyonuEntities();
            string musteriKadi = txtKullanici.Text;
            var musterix = db.MusterilerTable.Where(w => w.KullaniciAdi == musteriKadi).FirstOrDefault();
            if(musterix == null)
            {
                MessageBox.Show("Girdiğiniz Kullanıcı Adı Sistemde Bulunmamaktadır.");
            }
            else
            {

                KullaniciBilgisi.Ad = musterix.Ad;
                KullaniciBilgisi.Soyad = musterix.Soyad;
                KullaniciBilgisi.Adres = musterix.Adres;
                KullaniciBilgisi.MusterilerId = musterix.MusterilerId;
                KullaniciBilgisi.MusteriTipi = musterix.MusteriTipi;
                KullaniciBilgisi.KullaniciAdi = musterix.KullaniciAdi;
                KullaniciBilgisi.Sifre = musterix.Sifre;

              
                
               
                Form2 frm2 = new Form2();
                frm2.MdiParent = this.ParentForm;

                this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                frm2.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                frm2.Dock = DockStyle.Fill;
                this.Hide();
                frm2.Show();

                
            }
         

        }

        private void kayit_Button_Click(object sender, EventArgs e)
        {
            KayıtOl kyt = new KayıtOl();
            kyt.MdiParent = this.ParentForm;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            kyt.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            kyt.Dock = DockStyle.Fill;
            this.Hide();
            kyt.Show();
        }
    }
}
