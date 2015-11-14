using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avot.DAO
{
    public class AvukatDTO : BaseDTO
    {
        public string TC { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string Brans { get; set; }
        public string BaroSicilNo { get; set; }
        public string TBBNo { get; set; }
        public string VergiDairesi { get; set; }
        public string VergiNo { get; set; }
        public bool Cinsiyet { get; set; }
        public bool CalisiyorMu { get; set; }
    }
}
