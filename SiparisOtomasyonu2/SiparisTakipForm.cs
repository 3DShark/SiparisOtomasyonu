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
    public partial class SiparisTakipForm : Form
    {
        public SiparisTakipForm()
        {

            InitializeComponent();
            db = new siparis_OtomasyonuEntities();
          
        }
        public siparis_OtomasyonuEntities db;
        
        int kullaniciId;
        

        private void SiparisTakipForm_Load(object sender, EventArgs e)
        {


            foreach (var musteriler in db.SiparisUrunler)
            {
                kullaniciId = musteriler.MusteriId;
                var ekleMusteri = db.MusterilerTable.Where(w => w.MusterilerId == kullaniciId).FirstOrDefault();

                musteriler.KullaniciAdi = ekleMusteri.KullaniciAdi;


            }




            dataGridView1.DataSource = db.SiparisUrunler.ToList();
          
 
            


          
            

            
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Refresh();



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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
           

        }
    }
}
