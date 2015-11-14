using Avot.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avot.Forms.Classes
{
    public class CurrentPermission
    {
        private Entities db;

        public int KullaniciID { get; set; }
        public string KullaniciAdi { get; set; }

        private Dictionary<string, List<string>> PermissionList = new Dictionary<string, List<string>>();
        public void UpdatePermission()
        {
            using (db = new Entities())
            {
                var currentpermission = from p in db.KullaniciYetki
                                        where p.KullaniciID == this.KullaniciID
                                        select p;

                foreach (var item in currentpermission)
                {
                    
                    db.Database.Delete(); //deletobject  olması gerekli
                }
                db.SaveChanges();

                foreach (KeyValuePair<string, List<string>> Ygrup in this.PermissionList)
                {
                    string Yetkiaciklama = Ygrup.Key.ToUpper();

                    foreach (var item in Ygrup.Value)
                    {
                        var epermission = new KullaniciYetki();
                        epermission.KullaniciID = this.KullaniciID;
                        epermission.KullaniciYetkiAciklama = Yetkiaciklama;
                        epermission.KullaniciYetkisi = item;

                        //db.AddToPermissions(epermission);
                        
                    }
                }
                db.SaveChanges();
            }

        }


        public void LoadPermission()
        {
            this.PermissionList.Clear();

            using (db = new Entities())
            {
                var permission = from p in db.KullaniciYetki
                                 where p.KullaniciID == this.KullaniciID
                                 select p;

                foreach (var item in permission)
                {
                    this.Yetkidizi(item.KullaniciYetkiAciklama, item.KullaniciYetkisi);

                }
            }


            //this.PermissionList.Add("KullaniciYetkileri", new List<string>());
            //this.PermissionList.Add("Kullanici_AdminYetki", new List<string>());

            //var pkullyetki = this.PermissionList["KullaniciYetkileri"];
            //pkullyetki.Add("Ekle");
            //pkullyetki.Add("Duzenle");

            //var pkulladminyetki = this.PermissionList["Kullanici_AdminYetki"];
            //pkulladminyetki.Add("Sil");
            //pkulladminyetki.Add("Yazdir");


        }
        public bool YetkiErisimi(Enum ePermission)
        {
            bool result = false;
            string permission_name = ePermission.GetType().Name.ToUpper();

            if (this.PermissionList.ContainsKey(permission_name))
            {
                result = true;

            }

            return result;
        }
        public bool YetkiYapilan(Enum ePermission)
        {
            bool result = false;

            string permission_name = ePermission.GetType().Name.ToUpper();
            string permission_value = ePermission.ToString().ToUpper();

            if (this.PermissionList.ContainsKey(permission_name))
            {
                var plist = this.PermissionList[permission_name];


                if (plist.Contains(permission_name))
                {
                    result = true;
                }

            }

            return result;
        }
        public void Yetkidizi(string permissionName, bool Issil = false)
        {
            permissionName = permissionName.ToUpper();
            if (Issil)
            {
                if (this.PermissionList.ContainsKey(permissionName))
                {
                    this.PermissionList.Remove(permissionName);
                }
            }
            else
            {
                if (!this.PermissionList.ContainsKey(permissionName)) this.PermissionList.Add(permissionName, new List<string>());
            }

        }

        public void Yetkidizi(string permissionName, string permissionvalue)
        {
            permissionName = permissionName.ToUpper();
            permissionName = permissionvalue.ToUpper();

            this.Yetkidizi(permissionName);
            this.PermissionList[permissionName].Add(permissionvalue);


        }
    }
}
