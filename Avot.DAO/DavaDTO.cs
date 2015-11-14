using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avot.DAO
{
    public class DavaDTO : BaseDTO
    {
        public int AvukatID { get; set; }
        public int MahkemeID { get; set; }
        public string DosyaNo { get; set; }
        public string DavaTipi { get; set; }
        public string DavaDurumu { get; set; }
        public string DavaKonusu { get; set; }
        public DateTime DavaAcildigiTarih { get; set; }
        public string Savci1 { get; set; }
        public string Savci2 { get; set; }
        public decimal DavaBedeli { get; set; }
        public string KarsiTarafAvukatAd { get; set; }
        public string KarsiTarafAvukatSoyad { get; set; }
        public string KarsiTarafAvukatAdres { get; set; }
        public string KarsiTarafAvukatTelefon { get; set; }
        public string Davaci { get; set; }
        public string Davali { get; set; }
    }
}
