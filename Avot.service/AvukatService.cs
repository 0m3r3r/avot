using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Avot.DAO;
using Avot.DAL;

namespace Avot.service
{
    public class AvukatService : ICrud<AvukatDTO>
    {

        Entities db;

        public int Insert(AvukatDTO instance)
        {
            using (db = new Entities())
            {
                db.Avukat.Add(new Avukat()
                {
                    TC = instance.TC,
                    Adi = instance.Adi,
                    Soyadi = instance.Soyadi,
                    Brans = instance.Brans,
                    BaroSicilNo = instance.BaroSicilNo,
                    TBBNo = instance.TBBNo,
                    VergiDairesi = instance.VergiDairesi,
                    VergiNo = instance.VergiNo,
                    Cinsiyet = (bool)instance.Cinsiyet,
                    CalisiyorMu = (bool)instance.CalisiyorMu,

                    KaydiGirenKullaniciID = instance.KaydiGirenKullaniciID,
                    KaydiDegistirenKullaniciID = instance.KaydiDegistirenKullaniciID,
                    KayitTarihi = instance.KayitTarihi,
                    KaydiDegistirmeTarihi = instance.KaydiDegistirmeTarihi,
                    AktifMi = instance.Aktifmi
                });
                return db.SaveChanges();
            }
        }

        public int Update(AvukatDTO instance)
        {
            using (db = new Entities())
            {
                Avukat gelen = db.Avukat.Find(instance.ID);
                gelen.TC = instance.TC;
                gelen.Adi = instance.Adi;
                gelen.Soyadi = instance.Soyadi;
                gelen.Brans = instance.Brans;
                gelen.BaroSicilNo = instance.BaroSicilNo;
                gelen.TBBNo = instance.TBBNo;
                gelen.VergiDairesi = instance.VergiDairesi;
                gelen.VergiNo = instance.VergiNo;
                gelen.Cinsiyet = instance.Cinsiyet;
                gelen.CalisiyorMu = instance.CalisiyorMu;

                gelen.KaydiDegistirenKullaniciID = instance.KaydiDegistirenKullaniciID;
                gelen.KaydiDegistirmeTarihi = instance.KaydiDegistirmeTarihi;

                db.Avukat.Add(gelen);

                return db.SaveChanges();
            }
        }

        public int Delete(AvukatDTO instance)
        {
            using (db = new Entities())
            {
                Avukat gelen = db.Avukat.Find(instance.ID);
                gelen.AktifMi = false;

                return db.SaveChanges();
            }
        }

        public List<AvukatDTO> Select()
        {
            List<AvukatDTO> listAvot = new List<AvukatDTO>();

            using (db = new Entities())
            {
                foreach (Avukat item in db.Avukat.ToList().Where(p => p.AktifMi == true))
                {
                    listAvot.Add(new AvukatDTO()
                    {
                        ID = item.AvukatID,
                        TC = item.TC,
                        Adi = item.Adi,
                        Soyadi = item.Soyadi,
                        Brans = item.Brans,
                        BaroSicilNo = item.BaroSicilNo,
                        TBBNo = item.TBBNo,
                        VergiDairesi = item.VergiDairesi,
                        VergiNo = item.VergiNo,
                        Cinsiyet = (bool)item.Cinsiyet,
                        CalisiyorMu = (bool)item.CalisiyorMu,
                    });
                }
            }
            return listAvot;
        }
    }
}