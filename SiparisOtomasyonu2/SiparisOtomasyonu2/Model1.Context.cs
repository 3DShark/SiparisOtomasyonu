﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class siparis_OtomasyonuEntities : DbContext
    {
        public siparis_OtomasyonuEntities()
            : base("name=siparis_OtomasyonuEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<MusterilerTable> MusterilerTable { get; set; }
        public virtual DbSet<SiparisListesiTable> SiparisListesiTable { get; set; }
        public virtual DbSet<SiparisUrunler> SiparisUrunler { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<UrunlerTable> UrunlerTable { get; set; }
    }
}
