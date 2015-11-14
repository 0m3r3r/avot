using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avot.DAO
{
    public class MAhkemeDTO : BaseDTO
    {
        public string MahkemeAdi { get; set; }
        public string MahkemeNO { get; set; }
        public int ILID { get; set; }
        public string MahkemeTuru { get; set; }
    }
}
