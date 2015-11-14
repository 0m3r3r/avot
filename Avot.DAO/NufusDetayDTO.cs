using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avot.DAO
{
    public class NufusDetayDTO : BaseDTO
    {
        public string NufusBaglantiliKisiTC { get; set; }
        public string NufusCuzdaniSeriNo { get; set; }
        public string NufusCuzdaniNo { get; set; }
        public string AnaAdi { get; set; }
        public string BabaAdi { get; set; }
        public DateTime DogumTarihi { get; set; }
        public string DogumYeri { get; set; }
        public string Dini { get; set; }
        public string KanGrubu { get; set; }
        public int ILID { get; set; }
        public string Mahalle { get; set; }
        public string Koy { get; set; }
        public string CiltNo { get; set; }
        public string AileSiraNo { get; set; }
        public string SiraNo { get; set; }
        public string NufusKayitnNo { get; set; }
        public DateTime VerilisTarihi { get; set; }
        public string VerilisNedeni { get; set; }
        public string VerildigiYer { get; set; }
    }
}
