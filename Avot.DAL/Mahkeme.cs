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
    
    public partial class Mahkeme
    {
        public Mahkeme()
        {
            this.Dava = new HashSet<Dava>();
        }
    
        public int MahkemeID { get; set; }
        public string MahkemeAdi { get; set; }
        public string MahkemeNO { get; set; }
        public string MahkemeTuru { get; set; }
        public Nullable<int> ILID { get; set; }
        public int KaydiGirenKullaniciID { get; set; }
        public Nullable<int> KaydiDegistirenKullaniciID { get; set; }
        public Nullable<System.DateTime> KayitTarihi { get; set; }
        public Nullable<System.DateTime> KaydiDegistirmeTarihi { get; set; }
        public Nullable<bool> AktifMi { get; set; }
    
        public virtual ICollection<Dava> Dava { get; set; }
        public virtual ililce ililce { get; set; }
        public virtual Kullanici Kullanici { get; set; }
        public virtual Kullanici Kullanici1 { get; set; }
    }
}
