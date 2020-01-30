using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SiparisOtomasyonu2
{

   
    public  class SepeteUrun
    {
        
        

        public static List<SepeteUrun> yeniUrun = new List<SepeteUrun>();
        public   int UrunId { get; set; }
        public   string UrunAdı { get; set; }
        public  double UrunFiyat { get; set; }
        public  string UrunKategori { get; set; }
        public  string UrunAciklama { get; set; }
        
        public double UrunAdet { get; set; }

        

        public SepeteUrun()
        {

        }

        public SepeteUrun(UrunlerTable urunler)
        {
           

            var testUrun = yeniUrun.Where(w => w.UrunId == urunler.UrunId).FirstOrDefault();
            if(testUrun == null)
            {
                this.UrunId = urunler.UrunId;
                this.UrunAdı = urunler.UrunAdı;
                this.UrunFiyat = urunler.UrunFiyat;
                this.UrunKategori = urunler.UrunKategori;
                this.UrunAciklama = urunler.UrunAciklama;
                this.UrunAdet = 1;
                yeniUrun.Add(this);

            }
            else
            {
                testUrun.UrunAdet++;
                
            }
           
        }
        public static void UrunSil(string id)
        {
            int id1 = Convert.ToInt32(id);
            var silUrun = yeniUrun.Where(w => w.UrunId == id1).FirstOrDefault();

            yeniUrun.Remove(silUrun);

        }


    }

   
}
