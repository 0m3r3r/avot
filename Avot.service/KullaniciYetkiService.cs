using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Avot.DAO;
using Avot.DAL;

namespace Avot.service
{
    public class KullaniciYetkiService : ICrud<KullaniciYetkiDTO>
    {
        private Entities db;
        public int Insert(KullaniciYetkiDTO instance)
        {
            using (db = new Entities())
            {
                db.KullaniciYetki.Add(new KullaniciYetki()
                {
                    KullaniciYetkiAciklama = instance.KullaniciYetkiAciklama,
                    DavaYetkisi = (bool)instance.DavaYetkisi,
                    CelseYetkisi = (bool)instance.CelseYetkisi,
                    AvukatYetkisi = (bool)instance.AvukatYetkisi,
                    MahkemeYetkisi = (bool)instance.MahkemeYetkisi,
                    MuvekkilYetkisi = (bool)instance.MuvekkilYetkisi,
                    WebYetkisi = (bool)instance.WebYetkisi,
                    AjandaYetkisi = (bool)instance.AvukatYetkisi,
                    KullaniciYetkisi = (bool)instance.KullaniciYetkisi,
                    BuroYetkisi = (bool)instance.BuroYetkisi
                });

                return db.SaveChanges();
            }
        }

        public int Update(KullaniciYetkiDTO instance)
        {
            using (db = new Entities())
            {
                KullaniciYetki gelen = db.KullaniciYetki.Find(instance.ID);
                gelen.KullaniciYetkiAciklama = instance.KullaniciYetkiAciklama;
                gelen.DavaYetkisi = instance.DavaYetkisi;
                gelen.CelseYetkisi = instance.CelseYetkisi;
                gelen.AvukatYetkisi = instance.AvukatYetkisi;
                gelen.MahkemeYetkisi = instance.MahkemeYetkisi;
                gelen.MuvekkilYetkisi = instance.MuvekkilYetkisi;
                gelen.WebYetkisi = instance.WebYetkisi;
                gelen.AjandaYetkisi = instance.AjandaYetkisi;
                gelen.KullaniciYetkisi = instance.KullaniciYetkisi;
                gelen.BuroYetkisi = instance.BuroYetkisi;
                return db.SaveChanges();
            }
        }

        public int Delete(KullaniciYetkiDTO instance)
        {
            using (db = new Entities())
            {
                KullaniciYetki gelen = db.KullaniciYetki.Find(instance.ID);
                db.KullaniciYetki.Remove(gelen);

                return db.SaveChanges();
            }
        }

        public List<KullaniciYetkiDTO> Select()
        {
            List<KullaniciYetkiDTO> kullYet = new List<KullaniciYetkiDTO>();

            using (db = new Entities())
            {
                foreach (KullaniciYetki item in db.KullaniciYetki.ToList())
                {
                    kullYet.Add(new KullaniciYetkiDTO()
                    {
                        ID = item.KullaniciYetkiID,
                        KullaniciYetkiAciklama = item.KullaniciYetkiAciklama,
                        DavaYetkisi = (bool)item.DavaYetkisi,
                        CelseYetkisi = (bool)item.CelseYetkisi,
                        AvukatYetkisi = (bool)item.AvukatYetkisi,
                        MahkemeYetkisi = (bool)item.MahkemeYetkisi,
                        MuvekkilYetkisi = (bool)item.MuvekkilYetkisi,
                        WebYetkisi = (bool)item.WebYetkisi,
                        AjandaYetkisi = (bool)item.AvukatYetkisi,
                        KullaniciYetkisi = (bool)item.KullaniciYetkisi,
                        BuroYetkisi = (bool)item.BuroYetkisi,
                    });
                }
                return kullYet;
            }
        }
    }
}
