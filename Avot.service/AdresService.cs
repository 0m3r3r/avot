using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Avot.DAO;
using Avot.DAL;

namespace Avot.service
{
    public class AdresService : ICrud<AdresDTO>
    {
        private Entities db;

        public int Insert(AdresDTO instance)
        {
            using (db = new Entities())
            {
                db.Adres.Add(new Adres()
                {
                    AdresBaglantiliKisiTC = instance.AdresBaglantiliKisiTC,
                    ILID = instance.ILID,
                    Telefon1 = instance.Tel1,
                    Telefon2 = instance.Tel2,
                    Telefon3 = instance.Tel3,
                    Fax = instance.Fax,
                    EMail = instance.EMail,
                    SubeKodu = instance.SubeKodu,
                    BankaAdi = instance.BankaAdi,
                    HesapNo = instance.HesapNo,
                    IBAN = instance.IBAN,
                    AdresAciklama = instance.AdresAciklama,
                    KaydiGirenKullaniciID = instance.KaydiGirenKullaniciID,
                    KaydiDegistirenKullaniciID = instance.KaydiDegistirenKullaniciID,
                    KayitTarihi = instance.KayitTarihi,
                    KaydiDegistirmeTarihi = instance.KaydiDegistirmeTarihi,
                    AktifMi = instance.Aktifmi
                });
                return db.SaveChanges();
            }
        }

        public int Update(AdresDTO instance)
        {
            using (db = new Entities())
            {
                Adres gelen = db.Adres.Find(instance.ID);
                gelen.AdresBaglantiliKisiTC = instance.AdresBaglantiliKisiTC;
                gelen.ILID = instance.ILID;
                gelen.Telefon1 = instance.Tel1;
                gelen.Telefon2 = instance.Tel2;
                gelen.Telefon3 = instance.Tel3;
                gelen.Fax = instance.Fax;
                gelen.EMail = instance.EMail;
                gelen.SubeKodu = instance.SubeKodu;
                gelen.BankaAdi = instance.BankaAdi;
                gelen.HesapNo = instance.HesapNo;
                gelen.IBAN = instance.IBAN;
                gelen.AdresAciklama = instance.AdresAciklama;

                return db.SaveChanges();
            }
        }

        public int Delete(AdresDTO instance)
        {
            using (db = new Entities())
            {
                Adres gelen = db.Adres.Find(instance.ID);

                gelen.AktifMi = false;

                return db.SaveChanges();
            }
        }

        public List<AdresDTO> Select()
        {
            List<AdresDTO> adresList = new List<AdresDTO>();

            using (db = new Entities())
            {
                foreach (Adres item in db.Adres.ToList().Where(p => p.AktifMi == true))
                {
                    adresList.Add(new AdresDTO()
                    {
                        AdresBaglantiliKisiTC = item.AdresBaglantiliKisiTC,
                        ILID = (int)item.ILID,
                        Tel1 = item.Telefon1,
                        Tel2 = item.Telefon2,
                        Tel3 = item.Telefon3,
                        Fax = item.Fax,
                        EMail = item.EMail,
                        SubeKodu = item.SubeKodu,
                        BankaAdi = item.BankaAdi,
                        HesapNo = item.HesapNo,
                        IBAN = item.IBAN,
                        AdresAciklama = item.AdresAciklama
                    });
                }
                return adresList;
            }
        }
    }
}
