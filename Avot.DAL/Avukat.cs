//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Avot.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Avukat
    {
        public Avukat()
        {
            this.BuroBilgileri = new HashSet<BuroBilgileri>();
            this.Celse = new HashSet<Celse>();
            this.Dava = new HashSet<Dava>();
        }
    
        public int AvukatID { get; set; }
        public string TC { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string Brans { get; set; }
        public string BaroSicilNo { get; set; }
        public string TBBNo { get; set; }
        public string VergiDairesi { get; set; }
        public string VergiNo { get; set; }
        public Nullable<bool> Cinsiyet { get; set; }
        public Nullable<bool> CalisiyorMu { get; set; }
        public Nullable<int> KaydiGirenKullaniciID { get; set; }
        public Nullable<int> KaydiDegistirenKullaniciID { get; set; }
        public Nullable<System.DateTime> KayitTarihi { get; set; }
        public Nullable<System.DateTime> KaydiDegistirmeTarihi { get; set; }
        public Nullable<bool> AktifMi { get; set; }
    
        public virtual Adres Adres { get; set; }
        public virtual Kullanici Kullanici { get; set; }
        public virtual Kullanici Kullanici1 { get; set; }
        public virtual NufusDetay NufusDetay { get; set; }
        public virtual ICollection<BuroBilgileri> BuroBilgileri { get; set; }
        public virtual ICollection<Celse> Celse { get; set; }
        public virtual ICollection<Dava> Dava { get; set; }
    }
}