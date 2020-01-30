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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
            label1.Text = KullaniciBilgisi.Ad;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();


            frm2.MdiParent = this.ParentForm;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            frm2.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm2.Dock = DockStyle.Fill;
            this.Hide();
            frm2.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MusteriEkleForm mstrekle = new MusteriEkleForm();


            mstrekle.MdiParent = this.ParentForm;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            mstrekle.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            mstrekle.Dock = DockStyle.Fill;
            this.Hide();
            mstrekle.Show();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UrunForm urn = new UrunForm();
            urn.MdiParent = this.ParentForm;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            urn.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            urn.Dock = DockStyle.Fill;
            this.Hide();
            urn.Show();

        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SiparisTakipForm sprsTakip = new SiparisTakipForm();
            sprsTakip.MdiParent = this.ParentForm;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            sprsTakip.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            sprsTakip.Dock = DockStyle.Fill;
            this.Hide();
            sprsTakip.Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {

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
