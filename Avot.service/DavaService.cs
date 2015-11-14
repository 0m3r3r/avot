using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Avot.DAO;
using Avot.DAL;

namespace Avot.service
{
    public class DavaService : ICrud<DavaDTO>
    {
        private Entities db;
        public int Insert(DavaDTO instance)
        {
            using (db = new Entities())
            {
                db.Dava.Add(new Dava
                {
                    AvukatID = instance.AvukatID,
                    MahkemeID = instance.MahkemeID,
                    DosyaNo = instance.DosyaNo,
                    DavaTipi = instance.DavaTipi,
                    DavaDurumu = instance.DavaDurumu,
                    DavaKonusu = instance.DavaKonusu,
                    DavaAcildigiTarihi = instance.DavaAcildigiTarih,
                    Savci1 = instance.Savci1,
                    Savci2 = instance.Savci2,
                    DavaBedeli = instance.DavaBedeli,
                    KarsiTarafAvukatAd = instance.KarsiTarafAvukatAd,
                    KarsiTarafAvukatSoyad = instance.KarsiTarafAvukatSoyad,
                    KarsiTarafAvukatAdres = instance.KarsiTarafAvukatAdres,
                    KarsiTarafAvukatTelefon = instance.KarsiTarafAvukatTelefon,
                    Davaci = instance.Davaci,
                    Davali = instance.Davali,
                    KaydiGirenKullaniciID = instance.KaydiGirenKullaniciID,
                    KaydiDegistirenKullaniciID = instance.KaydiDegistirenKullaniciID,
                    KayitTarihi = instance.KayitTarihi,
                    KaydiDegistirmeTarihi = instance.KaydiDegistirmeTarihi,
                    AktifMi = instance.Aktifmi
                });
                return db.SaveChanges();
            }
        }

        public int Update(DavaDTO instance)
        {
            using (db = new Entities())
            {
                Dava gelen = db.Dava.Find(instance.ID);
                gelen.AvukatID = instance.AvukatID;
                gelen.DosyaNo = instance.DosyaNo;
                gelen.DavaTipi = instance.DavaTipi;
                gelen.DavaDurumu = instance.DavaDurumu;
                gelen.DavaKonusu = instance.DavaKonusu;
                gelen.DavaAcildigiTarihi = instance.DavaAcildigiTarih;
                gelen.Savci1 = instance.Savci1;
                gelen.Savci2 = instance.Savci2;
                gelen.DavaBedeli = instance.DavaBedeli;
                gelen.KarsiTarafAvukatAd = instance.KarsiTarafAvukatAd;
                gelen.KarsiTarafAvukatSoyad = instance.KarsiTarafAvukatSoyad;
                gelen.KarsiTarafAvukatAdres = instance.KarsiTarafAvukatAdres;
                gelen.KarsiTarafAvukatTelefon = instance.KarsiTarafAvukatTelefon;
                gelen.Davaci = instance.Davaci;
                gelen.Davali = instance.Davali;
                gelen.MahkemeID = instance.MahkemeID;
                gelen.KaydiDegistirenKullaniciID = instance.KaydiDegistirenKullaniciID;
                gelen.KaydiDegistirmeTarihi = instance.KaydiDegistirmeTarihi;

                return db.SaveChanges();
            }
        }

        public int Delete(DavaDTO instance)
        {
            using (db = new Entities())
            {
                Dava gelen = db.Dava.Find(instance.ID);
                gelen.AktifMi = false;

                return db.SaveChanges();
            }
        }

        public List<DavaDTO> Select()
        {
            List<DavaDTO> davaList = new List<DavaDTO>();

            using (db = new Entities())
            {
                foreach (Dava item in db.Dava.ToList().Where(p => p.AktifMi == true))
                {
                    davaList.Add(new DavaDTO()
                    {
                        ID = item.DavaID,
                        AvukatID = (int)item.AvukatID,
                        MahkemeID = (int)item.MahkemeID,
                        DosyaNo = item.DosyaNo,
                        DavaTipi = item.DavaTipi,
                        DavaDurumu = item.DavaDurumu,
                        DavaKonusu = item.DavaKonusu,
                        DavaAcildigiTarih = (DateTime)item.DavaAcildigiTarihi,
                        Savci1 = item.Savci1,
                        Savci2 = item.Savci2,
                        DavaBedeli = (decimal)item.DavaBedeli,
                        KarsiTarafAvukatAd = item.KarsiTarafAvukatAd,
                        KarsiTarafAvukatSoyad = item.KarsiTarafAvukatSoyad,
                        KarsiTarafAvukatAdres = item.KarsiTarafAvukatAdres,
                        KarsiTarafAvukatTelefon = item.KarsiTarafAvukatTelefon,
                        Davaci = item.Davaci,
                        Davali = item.Davali,
                    });
                }
            }
            return davaList;
        }
    }
}
