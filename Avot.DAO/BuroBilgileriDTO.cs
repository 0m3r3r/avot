using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avot.DAO
{
    public class BuroBilgileriDTO : BaseDTO
    {
        public int ILID { get; set; }
        public int SorumluSabitAvukatID { get; set; }
        public string BuroTanim { get; set; }
        public string Adres { get; set; }
        public string Telefon { get; set; }
        public string Fax { get; set; }
        public string BaroBilgileri { get; set; }
        public string IcraDairesi { get; set; }

    }
}
