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
    
    public partial class Kullanici
    {
        public Kullanici()
        {
            this.Adres = new HashSet<Adres>();
            this.Adres1 = new HashSet<Adres>();
            this.Avukat = new HashSet<Avukat>();
            this.Avukat1 = new HashSet<Avukat>();
            this.Celse = new HashSet<Celse>();
            this.Celse1 = new HashSet<Celse>();
            this.Dava = new HashSet<Dava>();
            this.Dava1 = new HashSet<Dava>();
            this.Mahkeme = new HashSet<Mahkeme>();
            this.Mahkeme1 = new HashSet<Mahkeme>();
            this.Muvekkil = new HashSet<Muvekkil>();
            this.Muvekkil1 = new HashSet<Muvekkil>();
            this.NufusDetay = new HashSet<NufusDetay>();
            this.NufusDetay1 = new HashSet<NufusDetay>();
            this.Web = new HashSet<Web>();
            this.Web1 = new HashSet<Web>();
            this.KullaniciYetki = new HashSet<KullaniciYetki>();
            this.KullaniciYetki1 = new HashSet<KullaniciYetki>();
        }
    
        public int KullaniciID { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
        public Nullable<int> KullaniciYetkiID { get; set; }
        public Nullable<int> KaydiGirenKullaniciID { get; set; }
        public Nullable<int> KaydiDegistirenKullaniciID { get; set; }
        public Nullable<System.DateTime> KayitTarihi { get; set; }
        public Nullable<System.DateTime> KaydiDegistirmeTarihi { get; set; }
        public Nullable<bool> AktifMi { get; set; }
    
        public virtual ICollection<Adres> Adres { get; set; }
        public virtual ICollection<Adres> Adres1 { get; set; }
        public virtual ICollection<Avukat> Avukat { get; set; }
        public virtual ICollection<Avukat> Avukat1 { get; set; }
        public virtual ICollection<Celse> Celse { get; set; }
        public virtual ICollection<Celse> Celse1 { get; set; }
        public virtual ICollection<Dava> Dava { get; set; }
        public virtual ICollection<Dava> Dava1 { get; set; }
        public virtual ICollection<Mahkeme> Mahkeme { get; set; }
        public virtual ICollection<Mahkeme> Mahkeme1 { get; set; }
        public virtual ICollection<Muvekkil> Muvekkil { get; set; }
        public virtual ICollection<Muvekkil> Muvekkil1 { get; set; }
        public virtual ICollection<NufusDetay> NufusDetay { get; set; }
        public virtual ICollection<NufusDetay> NufusDetay1 { get; set; }
        public virtual ICollection<Web> Web { get; set; }
        public virtual ICollection<Web> Web1 { get; set; }
        public virtual ICollection<KullaniciYetki> KullaniciYetki { get; set; }
        public virtual ICollection<KullaniciYetki> KullaniciYetki1 { get; set; }
    }
}