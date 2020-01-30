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

    public partial class GiyimForm : Form
    {
        int id;
        public siparis_OtomasyonuEntities db;
        public GiyimForm()
        {
            InitializeComponent();
        }

        public void GiyimUrunGetir()
        {
            dataGridView2.DataSource = SepeteUrun.yeniUrun;

            dataGridView2.Columns[0].Visible = false;
            db = new siparis_OtomasyonuEntities();
            dataGridView1.DataSource = db.UrunlerTable.Where(x => x.UrunKategori == "Giyim").ToArray();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;

        }

        private void GiyimForm_Load(object sender, EventArgs e)
        {
            GiyimUrunGetir();
            label1.Text = "Deneme";
            label1.Text = KullaniciBilgisi.Ad;
            if (KullaniciBilgisi.MusteriTipi == 1)
            {
                linkLabel4.Visible = true;

            }

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            KitapForm ktp = new KitapForm();

            ktp.MdiParent = this.ParentForm;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ktp.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            ktp.Dock = DockStyle.Fill;
            this.Hide();
            ktp.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ElektronikForm elkForm = new ElektronikForm();

            elkForm.MdiParent = this.ParentForm;

            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            elkForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            elkForm.Dock = DockStyle.Fill;
            this.Hide();
            elkForm.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();


            frm2.MdiParent = this.ParentForm;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            frm2.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm2.Dock = DockStyle.Fill;
            this.Hide();
            frm2.Show();
        }

        private void siparisEkleBtn_Click(object sender, EventArgs e)
        {
            var YeniUrun = db.UrunlerTable.Where(w => w.UrunId == id).FirstOrDefault();
            /*SiparisListesi(YeniUrun);*/

            SepeteUrun sepet = new SepeteUrun(YeniUrun);

            dataGridView2.Refresh();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SepetForm sepetfrm = new SepetForm();
            sepetfrm.MdiParent = this.ParentForm;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            sepetfrm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            sepetfrm.Dock = DockStyle.Fill;
            this.Hide();
            sepetfrm.Show();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AdminForm admn = new AdminForm();

            admn.MdiParent = this.ParentForm;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            admn.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            admn.Dock = DockStyle.Fill;
            this.Hide();
            admn.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            SepetForm sepetfrm = new SepetForm();
            sepetfrm.MdiParent = this.ParentForm;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            sepetfrm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            sepetfrm.Dock = DockStyle.Fill;
            this.Hide();
            sepetfrm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ProfilForm prfl = new ProfilForm();

            prfl.MdiParent = this.ParentForm;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            prfl.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            prfl.Dock = DockStyle.Fill;
            this.Hide();
            prfl.Show();
        }
    }
}
