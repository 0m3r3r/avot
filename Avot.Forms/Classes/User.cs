using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Avot.DAO;
using Avot.service;

namespace Avot.Forms.Classes
{
    public static class User
    {
        //Kullanıcı adıın gösterimi ve şifre değiştirme işlemlerinin yapılabilmesi için, kullanıcı doğru giriş yaptığı anda verilerin tutulacağı sınıfımız.
        //static kullanmaktaki amaç, bir class a ait item çağırılacağı zaman normalde instance laınıp çağırılır.Static bu zorunluluğu ortadan kaldırıyor ve bir metod veya propertie çağıracağımız zaman classismi.motedveyapropertieismi şeklinde çağırmamıza olanak sağlıyor.


        public static int IdGir { get; set; }
        public static string KAdGir { get; set; }
        public static string SifreGir { get; set; }
        public static int  KullaniciYetkiGir { get; set; }
       
        
        public static int ID()
        {
            return IdGir;
        }

        public static string KAd()
        {
            return KAdGir;
        }

        public static string Sifre()
        {
            return SifreGir;
        }

        public static int KullaniciYetki()
        {

            return KullaniciYetkiGir;
        }

       
        //public static string Ad()
        //{
        //    //KullaniciService kService = new KullaniciService();

        //    //return kService.Select().Where(p=>p.KullaniciAdi==KAd);

        //    //devam edilecek.
        //}

        //public static string Soyad()
        //{
        //    return KAdGir;
        // devam edilecek
        //}

    }
   
}
        
