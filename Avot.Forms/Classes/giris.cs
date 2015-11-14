using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Avot.Forms.Classes;

namespace Avot.Forms.Classes
{
    class giris
    {
        public static CurrentPermission user { get; set; }

        static giris()
        {
            giris.user = new CurrentPermission();
            giris.user.KullaniciID = 1; // Giris yapan kullanıcı ID si buraya atmamız lazım
        }
    }
}
