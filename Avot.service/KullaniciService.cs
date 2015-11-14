using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Avot.DAO;
using Avot.DAL;

namespace Avot.service
{
    public class KullaniciService : ICrud<KullaniciDTO>
    {
        private Entities db;

        
        public int Insert(KullaniciDTO instance)
        {
            using (db = new Entities())
            {
                db.Kullanici.Add(new Kullanici
                {
                    Adi = instance.Adi,
                    Soyadi = instance.Soyadi,
                    KullaniciAdi = instance.KullaniciAdi,
                    Sifre = instance.Sifre,
                    //KullaniciYetkiID = instance.KullaniciYetkiID,
                    KaydiGirenKullaniciID = instance.KaydiGirenKullaniciID,
                    KaydiDegistirenKullaniciID = instance.KaydiDegistirenKullaniciID,
                    KayitTarihi = instance.KayitTarihi,
                    KaydiDegistirmeTarihi = instance.KaydiDegistirmeTarihi,
                    AktifMi = instance.Aktifmi
                });

                return db.SaveChanges();
            }
        }

        public int Update(KullaniciDTO instance)
        {
            using (db = new Entities())
            {
                Kullanici gelen = db.Kullanici.Find(instance.ID);
                gelen.Adi = instance.Adi;
                gelen.Soyadi = instance.Soyadi;
                gelen.KullaniciAdi = instance.KullaniciAdi;
                gelen.Sifre = instance.Sifre;
                gelen.KullaniciYetkiID = instance.KullaniciYetkiID;

                return db.SaveChanges();
            }
        }

        public int SifreDegistir(KullaniciDTO instance)
        {
            using (db = new Entities())
            {
                Kullanici gelen = db.Kullanici.Find(instance.ID);
                gelen.Sifre = instance.Sifre;

                return db.SaveChanges();
            }
        }

        public int Delete(KullaniciDTO instance)
        {
            using (db = new Entities())
            {
                Kullanici gelen = db.Kullanici.Find(instance.ID);
                gelen.AktifMi = false;

                return db.SaveChanges();
            }
        }

        public List<KullaniciDTO> Select()
        {
            List<KullaniciDTO> kullList = new List<KullaniciDTO>();

            using (db = new Entities())
            {
                foreach (Kullanici item in db.Kullanici.ToList().Where(p => p.AktifMi == true))
                {
                    kullList.Add(new KullaniciDTO()
                    {
                        ID = item.KullaniciID,
                        Adi = item.Adi,
                        Soyadi = item.Soyadi,
                        KullaniciAdi = item.KullaniciAdi,
                        Sifre = item.Sifre,
                        KullaniciYetkiID = (int)item.KullaniciYetkiID,
                        KaydiGirenKullaniciID = (int)item.KaydiGirenKullaniciID,
                        KaydiDegistirenKullaniciID = (int)item.KaydiDegistirenKullaniciID,
                        KayitTarihi = (DateTime)item.KayitTarihi,
                        KaydiDegistirmeTarihi = (DateTime)item.KaydiDegistirmeTarihi,
                        Aktifmi = (bool)item.AktifMi
                    });
                }
            }
            return kullList;
        }
    }
}
