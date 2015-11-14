using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avot.Forms.Classes
{
    public class Messages
    {
        //Bu class ın eklenmesi ve ypaılmasındaki amaç mesajların tek elden yönetilmesidir.
        //ekleme güncelleme silme gibi işlemlerden sonra kullanıcıya verilecek olan mesajlar standart olarak bu bölüme tanımlanır.
        //form içerisinden çağırılırken class ismi+metod ismi şeklinde çağırılabilinir.Ör: Message.silindi(); şeklinde çağırıldığı anda aşağıdaki mesaj ekrana basılacaktır.
        //Kullanılacak olan formun içerisine using eklenmesi lazım. //using Avot.Forms.Classes;//
        //İhtiyaç duyuldukca mbox mesajları eklenecek.


        public static string hosgeldin(string isim)
        {
            return Convert.ToString(MessageBox.Show("Hoşgeldin : " + isim, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information));
        }


        public static string kayitBasarili()
        {
            return Convert.ToString(MessageBox.Show("Kayıt işleminiz gerçekleştirilmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information));
        }


        public static string kayitBasarisiz(string ExceptionEx)
        {
            return Convert.ToString(MessageBox.Show("Kayıt işleminiz gerçekleştirilirken hata ile karşılaşıldı.\nHata mesajı : " + ExceptionEx, "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Warning));
        }

        public static string GuncellemeBasarili()
        {
            return Convert.ToString(MessageBox.Show("Güncelleme işleminiz gerçekleştirilmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information));
        }

        public static string GuncellemeBasarisiz(string ExceptionEx)
        {
            return Convert.ToString(MessageBox.Show("Güncelleme işleminiz gerçekleştirilirken hata ile karşılaşıldı.\nHata mesajı : " + ExceptionEx, "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Warning));
        }


        public static string silindi()
        {
            return Convert.ToString(MessageBox.Show("Seçtiğiniz Öğe Başarıyla Silimiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information));
        }


        public static string itemSeciniz()
        {
            return Convert.ToString(MessageBox.Show("İşleme devam edebilmek için bir öğe seçiniz", "Uyarı !", MessageBoxButtons.OK, MessageBoxIcon.Warning));
        }


        public static string SifreDegistirmeBasarili()
        {
            return Convert.ToString(MessageBox.Show("Şifre değiştirme işleminiz başarı ile gerçekleşmiştir", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information));

        }
    }
}
