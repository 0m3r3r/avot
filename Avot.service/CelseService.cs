using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Avot.DAO;
using Avot.DAL;

namespace Avot.service
{
    public class CelseService : ICrud<CelseDTO>
    {

        Entities db;

        public int Insert(CelseDTO instance)
        {
            using (db = new Entities())
            {
                db.Celse.Add(new Celse()
                {
                    DavaID = (int)instance.DavaID,
                    CelseTarihi = (DateTime)instance.CelseTarihi,
                    AvukatID = (int)instance.AvukatID,
                    Hakim = instance.Hakim,
                    Savci = instance.Savci,
                    Karar = instance.Karar,
                    ErtelemeMazeret = instance.ErtelemeMazeret,
                    ErtelemeTarihi = (DateTime)instance.ErtelemeTarihi,
                    Aciklama = instance.Aciklama,

                    KaydiGirenKullaniciID = instance.KaydiGirenKullaniciID,
                    KaydiDegistirenKullaniciID = instance.KaydiDegistirenKullaniciID,
                    KayitTarihi = instance.KayitTarihi,
                    KaydiDegistirmeTarihi = instance.KaydiDegistirmeTarihi
                });

                return db.SaveChanges();
            }
        }

        public int Update(CelseDTO instance)
        {
            using (db = new Entities())
            {
                Celse gelen = db.Celse.Find(instance.ID);

                gelen.DavaID = instance.DavaID;
                gelen.CelseTarihi = instance.CelseTarihi;
                gelen.AvukatID = instance.AvukatID;
                gelen.Hakim = instance.Hakim;
                gelen.Savci = instance.Savci;
                gelen.Karar = instance.Karar;
                gelen.ErtelemeMazeret = instance.ErtelemeMazeret;
                gelen.ErtelemeTarihi = instance.ErtelemeTarihi;
                gelen.Aciklama = instance.Aciklama;

                return db.SaveChanges();
            }
        }

        public int Delete(CelseDTO instance)
        {
            using (db = new Entities())
            {
                Celse gelen = db.Celse.Find(instance.ID);

                gelen.AktifMi = false;

                return db.SaveChanges();
            }
        }

        public List<CelseDTO> Select()
        {
            List<CelseDTO> celList = new List<CelseDTO>();

            using (db = new Entities())
            {
                foreach (Celse item in db.Celse.ToList().Where(p => p.AktifMi == true))
                {
                    celList.Add(new CelseDTO()
                    {
                        ID = item.CelseID,
                        DavaID = (int)item.DavaID,
                        CelseTarihi = (DateTime)item.CelseTarihi,
                        AvukatID = (int)item.AvukatID,
                        Hakim = item.Hakim,
                        Savci = item.Savci,
                        Karar = item.Karar,
                        ErtelemeMazeret = item.ErtelemeMazeret,
                        ErtelemeTarihi = (DateTime)item.ErtelemeTarihi,
                        Aciklama = item.Aciklama
                    });
                }
            }
            return celList;
        }
    }
}
