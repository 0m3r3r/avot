using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avot.DAO
{
    public class MuvekkilDTO : BaseDTO
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string TC { get; set; }
        public string NufusDetayTC { get; set; }
        public string AdresDetayTC { get; set; }
        public bool Cinsiyet { get; set; }
    }
}
