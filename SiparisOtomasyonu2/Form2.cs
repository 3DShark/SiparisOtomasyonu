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
    public partial class Form2 : Form
    {
      
        public Form2()
        {
          
            InitializeComponent();

            label1.Text = "Deneme";
            label1.Text = KullaniciBilgisi.Ad;
            if (KullaniciBilgisi.MusteriTipi == 1)
            {
                linkLabel4.Visible = true;

            }

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

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GiyimForm gym = new GiyimForm();

            gym.MdiParent = this.ParentForm;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            gym.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            gym.Dock = DockStyle.Fill;
            this.Hide();
            gym.Show();
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

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
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
    }
}
