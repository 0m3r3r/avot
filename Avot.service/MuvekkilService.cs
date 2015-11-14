using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Avot.DAO;
using Avot.DAL;

namespace Avot.service
{
    public class MuvekkilService : ICrud<MuvekkilDTO>
    {
        private Entities db;

        public int Insert(MuvekkilDTO instance)
        {
            using (db = new Entities())
            {
                db.Muvekkil.Add(new Muvekkil()
                {
                    Ad = instance.Ad,
                    Soyad = instance.Soyad,
                    TC = instance.TC,
                    Cinsiyet = (bool)instance.Cinsiyet,
                    KaydiGirenKullaniciID = instance.KaydiGirenKullaniciID,
                    KaydiDegistirenKullaniciID = instance.KaydiDegistirenKullaniciID,
                    KayitTarihi = instance.KayitTarihi,
                    KaydiDegistirmeTarihi = instance.KaydiDegistirmeTarihi,
                    AktifMi = instance.Aktifmi
                });

                return db.SaveChanges();
            }
        }

        public int Update(MuvekkilDTO instance)
        {
            using (db = new Entities())
            {
                Muvekkil gelen = db.Muvekkil.Find(instance.ID);
                gelen.Ad = instance.Ad;
                gelen.Soyad = instance.Soyad;
                gelen.TC = instance.TC;
                gelen.Cinsiyet = instance.Cinsiyet;
                gelen.KaydiDegistirenKullaniciID = instance.KaydiDegistirenKullaniciID;
                gelen.KaydiDegistirmeTarihi = instance.KaydiDegistirmeTarihi;

                return db.SaveChanges();
            }
        }

        public int Delete(MuvekkilDTO instance)
        {
            using (db = new Entities())
            {
                Muvekkil gelen = db.Muvekkil.Find(instance.ID);
                gelen.AktifMi = false;

                return db.SaveChanges();
            }
        }

        public List<MuvekkilDTO> Select()
        {
            List<MuvekkilDTO> muvList = new List<MuvekkilDTO>();

            using (db = new Entities())
            {
                foreach (Muvekkil item in db.Muvekkil.ToList().Where(p => p.AktifMi == true))
                {
                    muvList.Add(new MuvekkilDTO()
                    {
                        ID = item.MuvekkilID,
                        Ad = item.Ad,
                        Soyad = item.Soyad,
                        TC = item.TC,
                        Cinsiyet = (bool)item.Cinsiyet,
                    });
                }
            }
            return muvList;
        }
    }
}
