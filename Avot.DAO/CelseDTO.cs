using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avot.DAO
{
    public class CelseDTO : BaseDTO
    {
        public int DavaID { get; set; }
        public DateTime CelseTarihi { get; set; }
        public int AvukatID { get; set; }
        public string Hakim { get; set; }
        public string Savci { get; set; }
        public string Karar { get; set; }
        public string ErtelemeMazeret { get; set; }
        public DateTime ErtelemeTarihi { get; set; }
        public int AjandaKayıtID { get; set; }
        public string Aciklama { get; set; }
    }
}
