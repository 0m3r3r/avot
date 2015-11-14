using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Avot.DAO;
using Avot.DAL;

namespace Avot.service
{
    public class BuroBilgileriService : ICrud<BuroBilgileriDTO>
    {

        private Entities db;

        public int Insert(BuroBilgileriDTO instance)
        {
            using (db = new Entities())
            {
                db.BuroBilgileri.Add(new BuroBilgileri()
                {
                    ILID = instance.ILID,
                    SorumluSabitAvukatID = (int)instance.SorumluSabitAvukatID,
                    BuroTanimi = instance.BuroTanim,
                    Adres = instance.Adres,
                    Telefon = instance.Telefon,
                    Fax = instance.Fax,
                    BaroBilgileri = instance.BaroBilgileri,
                    IcraDairesi = instance.IcraDairesi
                });
                return db.SaveChanges();
            }
        }

        public int Update(BuroBilgileriDTO instance)
        {
            using (db = new Entities())
            {
                BuroBilgileri gelen = db.BuroBilgileri.Find(instance.ID);
                gelen.ILID = instance.ILID;
                gelen.SorumluSabitAvukatID = instance.SorumluSabitAvukatID;
                gelen.BuroTanimi = instance.BuroTanim;
                gelen.Adres = instance.Adres;
                gelen.Telefon = instance.Telefon;
                gelen.Fax = instance.Fax;
                gelen.BaroBilgileri = instance.BaroBilgileri;
                gelen.IcraDairesi = instance.IcraDairesi;

                return db.SaveChanges();
            }
        }

        public int Delete(BuroBilgileriDTO instance)
        {
            using (db = new Entities())
            {
                BuroBilgileri gelen = db.BuroBilgileri.Find(instance.ID);

                db.BuroBilgileri.Remove(gelen);

                return db.SaveChanges();
            }
        }

        public List<BuroBilgileriDTO> Select()
        {
            List<BuroBilgileriDTO> bList = new List<BuroBilgileriDTO>();

            using (db = new Entities())
            {
                foreach (BuroBilgileri item in db.BuroBilgileri.ToList())
                {
                    bList.Add(new BuroBilgileriDTO()
                    {
                        ILID = (int)item.ILID,
                        SorumluSabitAvukatID = (int)item.SorumluSabitAvukatID,
                        BuroTanim = item.BuroTanimi,
                        Adres = item.Adres,
                        Telefon = item.Telefon,
                        Fax = item.Fax,
                        BaroBilgileri = item.BaroBilgileri,
                        IcraDairesi = item.IcraDairesi
                    });
                }
            }
            return bList;
        }
    }
}
