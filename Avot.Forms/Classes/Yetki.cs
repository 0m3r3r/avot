using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avot.Forms.Classes
{
    public class Permission
    {
        public enum KullaniciYetkileri
        {
            Goruntule,
            Ekle,
            Duzenle,
            Sil,
            Yazdir

        }
        public enum Kullanici_AdminYetki
        {
            Goruntule,
            Ekle,
            Duzenle,
            Sil,
            Yazdir,
            Ekle_Aktar

        }

        public static List<PermissionHD> Listpermission()
        {
            List<PermissionHD> result = new List<PermissionHD>();

            var per = typeof(Permission);
            var listofenum = per.GetMembers();

            foreach (var item in listofenum)
            {
                if (item.MemberType == System.Reflection.MemberTypes.NestedType)
                {
                    string name = item.Name;
                    string value = item.ToString();

                    result.Add(new PermissionHD {Display = name, Value = value });

                }
            }
            return result;
        }
        public static List<String> PermissionDetail(string EnumFullName)
        {
            List<string> result = new List<string>();
            var permission = System.Activator.CreateInstance(Type.GetType(EnumFullName));
            var listdetail = Enum.GetValues(permission.GetType());

            foreach (var item in listdetail)
            {
                result.Add(item.ToString());
            }
            return result;
        }
    }
    public class PermissionHD
    {
        public string Display { get; set; }
        public string Value { get; set; }
    }




}