using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparisOtomasyonu2
{
    public abstract class Odeme
    {
        public float Miktar { get; set; }
    }

    class KrediKartı: Odeme
    {
        public string KartNumarası { get; set; }
        public DateTime  SonKullanimTarihi { get; set; }
       
    }
    class Nakit : Odeme
    {

    }
    class  Cek: Odeme
    {
        public string BankID { get; set; }
    }
}
