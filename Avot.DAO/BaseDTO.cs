using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avot.DAO
{
    public abstract class BaseDTO
    {
        public BaseDTO()
        {
            this.Aktifmi = true;
            this.KayitTarihi = DateTime.Now;
        }

        public int ID { get; set; }
        public int KaydiGirenKullaniciID { get; set; }
        public int KaydiDegistirenKullaniciID { get; set; }
        public DateTime KayitTarihi { get; set; }
        public DateTime KaydiDegistirmeTarihi { get; set; }
        public bool Aktifmi { get; set; }
    }
}