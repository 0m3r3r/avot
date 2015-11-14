using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avot.DAO
{
    public class KullaniciYetkiDTO : BaseDTO
    {
        public int KullaniciYetkiID { get; set; }
        public string KullaniciYetkiAciklama { get; set; }
        public bool DavaYetkisi { get; set; }
        public bool CelseYetkisi { get; set; }
        public bool AvukatYetkisi { get; set; }
        public bool MahkemeYetkisi { get; set; }
        public bool MuvekkilYetkisi { get; set; }
        public bool WebYetkisi { get; set; }
        public bool AjandaYetkisi { get; set; }
        public bool KullaniciYetkisi { get; set; }
        public bool BuroYetkisi { get; set; }


    }
}
