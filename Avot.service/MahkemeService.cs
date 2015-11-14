using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Avot.DAO;
using Avot.DAL;

namespace Avot.service
{
    public class MahkemeService : ICrud<MAhkemeDTO>
    {

        private Entities db;

        public int Insert(MAhkemeDTO instance)
        {
            using (db = new Entities())
            {
                db.Mahkeme.Add(new Mahkeme()
                {
                    MahkemeAdi = instance.MahkemeAdi,
                    MahkemeNO = instance.MahkemeNO,
                    ILID = instance.ILID,
                    MahkemeTuru = instance.MahkemeTuru,
                    KaydiGirenKullaniciID = instance.KaydiGirenKullaniciID,
                    KaydiDegistirenKullaniciID = instance.KaydiDegistirenKullaniciID,
                    KayitTarihi = instance.KayitTarihi,
                    KaydiDegistirmeTarihi = instance.KaydiDegistirmeTarihi,
                    AktifMi = instance.Aktifmi
                });
                return db.SaveChanges();
            }
        }

        public int Update(MAhkemeDTO instance)
        {
            using (db = new Entities())
            {
                Mahkeme gelen = db.Mahkeme.Find(instance.ID);
                gelen.MahkemeAdi = instance.MahkemeAdi;
                gelen.MahkemeNO = instance.MahkemeNO;
                //gelen.ILID = instance.ILID;
                gelen.MahkemeTuru = instance.MahkemeTuru;
                gelen.KaydiDegistirenKullaniciID = instance.KaydiDegistirenKullaniciID;
                gelen.KaydiDegistirmeTarihi = instance.KaydiDegistirmeTarihi;

                return db.SaveChanges();
            }
        }

        public int Delete(MAhkemeDTO instance)
        {
            using (db = new Entities())
            {
                Mahkeme gelen = db.Mahkeme.Find(instance.ID);
                gelen.AktifMi = false;

                return db.SaveChanges();
            }
        }

        public List<MAhkemeDTO> Select()
        {
            List<MAhkemeDTO> mahList = new List<MAhkemeDTO>();

            using (db = new Entities())
            {
                foreach (Mahkeme item in db.Mahkeme.ToList().Where(p => p.AktifMi == true))
                {
                    mahList.Add(new MAhkemeDTO()
                    {
                        ID = item.MahkemeID,
                        MahkemeAdi = item.MahkemeAdi,
                        MahkemeNO = item.MahkemeNO,
                        ILID = (int)item.ILID,
                        MahkemeTuru = item.MahkemeTuru,
                    });
                }
            }
            return mahList;
        }
    }
}
