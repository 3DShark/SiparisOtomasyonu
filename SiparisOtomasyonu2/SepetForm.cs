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
   
    public partial class SepetForm : Form
    {
        public siparis_OtomasyonuEntities db;
        List<UrunlerTable> urunlerList = new List<UrunlerTable>();

        double toplamTutar;
        
        public SepetForm()
        {
           
            InitializeComponent();
        }
         public void SepeteUrunGetir()
        {

            foreach (SepeteUrun urun2 in SepeteUrun.yeniUrun)
            {
                UrunlerTable urunTable = new UrunlerTable();

                urunTable.UrunId = urun2.UrunId;
                urunTable.UrunAdı = urun2.UrunAdı;
                urunTable.UrunFiyat = urun2.UrunFiyat;
                urunTable.UrunAciklama = urun2.UrunAciklama;
                urunTable.UrunKategori = urun2.UrunKategori;
                urunTable.UrunAdet = urun2.UrunAdet;


                urunlerList.Add(urunTable);


            }
            dataGridView2.DataSource = urunlerList;
            dataGridView2.Columns[0].Visible = false;
            dataGridView2.Columns[6].Visible = false;
            toplamTutar = 0;
            foreach (var urun in urunlerList)
            {
                toplamTutar += urun.UrunAdet * urun.UrunFiyat;
                

            }
            labelToplam.Text = toplamTutar + "TL";


        }
       
        
        

        private void SepetForm_Load(object sender, EventArgs e)
        {
           
            SepeteUrunGetir();
         
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void nakitCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (nakitCheck.Checked == true)
            {
                groupBox1.Visible = true;
            }
            else if (nakitCheck.Checked == false)
            {
                groupBox1.Visible = false;
            }
            
        }

        private void krediCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (krediCheck.Checked == true)
            {
                groupBox2.Visible = true;
            }
            else if (krediCheck.Checked == false)
            {
                groupBox2.Visible = false;
            }
        }

        private void cekCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (cekCheck.Checked == true)
            {
                groupBox3.Visible = true;
            }
            else if (cekCheck.Checked == false)
            {
                groupBox3.Visible = false;
            }
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

        private void odeBtn_Click(object sender, EventArgs e)
        {

            double tutar = Convert.ToDouble(textBox1.Text) + Convert.ToDouble(textBox7.Text) + Convert.ToDouble(textBox8.Text);
            if (tutar == toplamTutar)
            {
                db = new siparis_OtomasyonuEntities();
                SiparisListesiTable siparisler = new SiparisListesiTable();

                siparisler.MusterilerId = KullaniciBilgisi.MusterilerId;
                siparisler.SparisTarih = DateTime.Now;
                siparisler.UrunToplamFiyat = toplamTutar;
                db.SiparisListesiTable.Add(siparisler);
                db.SaveChanges();

                /*var YeniUrun = db.SiparisListesiTable.Last();*/

                SiparisUrunler siparisUrunler = new SiparisUrunler();

                foreach (var urun in SepeteUrun.yeniUrun)
                {
                    siparisUrunler.KullaniciAdi = KullaniciBilgisi.KullaniciAdi;
                    siparisUrunler.SiparisListesiId = siparisler.SiparisListesiId;
                    siparisUrunler.UrunAdet = Convert.ToInt32(urun.UrunAdet);
                    siparisUrunler.UrunId = urun.UrunId;
                    siparisUrunler.MusteriId = KullaniciBilgisi.MusterilerId;
                    db.SiparisUrunler.Add(siparisUrunler);
                    db.SaveChanges();

                }
                MessageBox.Show("Ödeme İşleminiz Tamamlandı Ana Menüye yönlendiriliyorsunuz...");
                Form2 frm2 = new Form2();


                frm2.MdiParent = this.ParentForm;
                this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                frm2.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                frm2.Dock = DockStyle.Fill;
                this.Hide();
                frm2.Show();


            }
            else if (tutar > toplamTutar)
            {
                MessageBox.Show("Ödemeniz gereken tutardan daha fazla tutar girdiniz...");
            }
            else
            {

                MessageBox.Show("Ödemeniz gereken tutardan daha az tutar girdiniz...");
            }
        }

        private void dataGridView2_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

            

        }

     
    }
    }

