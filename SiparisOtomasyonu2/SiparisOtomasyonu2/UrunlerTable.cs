//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SiparisOtomasyonu2
{
    using System;
    using System.Collections.Generic;
    
    public partial class UrunlerTable
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UrunlerTable()
        {
            this.SiparisUrunler = new HashSet<SiparisUrunler>();
        }
    
        public int UrunId { get; set; }
        public string UrunAdı { get; set; }
        public double UrunFiyat { get; set; }
        public string UrunKategori { get; set; }
        public string UrunAciklama { get; set; }

        public double UrunAdet { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SiparisUrunler> SiparisUrunler { get; set; }
    }
}
