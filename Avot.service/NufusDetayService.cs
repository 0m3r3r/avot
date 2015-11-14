using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Avot.DAO;
using Avot.DAL;

namespace Avot.service
{
    public class NufusDetayService : ICrud<NufusDetayDTO>
    {
        Entities db;
        public int Insert(NufusDetayDTO instance)
        {
            using (db = new Entities())
            {
                db.NufusDetay.Add(new NufusDetay()
                {
                    NufusBaglantiliKisiTC = instance.NufusBaglantiliKisiTC,
                    NufusCuzdaniSeriNo = instance.NufusCuzdaniSeriNo,
                    NufusCuzdaniNo = instance.NufusCuzdaniNo,
                    AnaAdi = instance.AnaAdi,
                    BabaAdi = instance.BabaAdi,
                    DogumYeri = instance.DogumYeri,
                    Dini = instance.Dini,
                    KanGrubu = instance.KanGrubu,
                    ILID = instance.ILID,
                    Mahalle = instance.Mahalle,
                    Koy = instance.Koy,
                    CiltNo = instance.CiltNo,
                    AileSiraNo = instance.AileSiraNo,
                    SiraNo = instance.SiraNo,
                    DogumTarihi = instance.DogumTarihi,
                    NufusKayitnNo = instance.NufusKayitnNo,
                    VerilisTarihi = instance.VerilisTarihi,
                    VerilisNedeni = instance.VerilisNedeni,
                    VerildigiYer = instance.VerildigiYer,

                    KaydiGirenKullaniciID = instance.KaydiGirenKullaniciID,
                    KaydiDegistirenKullaniciID = instance.KaydiDegistirenKullaniciID,
                    KayitTarihi = instance.KayitTarihi,
                    KaydiDegistirmeTarihi = instance.KaydiDegistirmeTarihi,
                    AktifMi = instance.Aktifmi
                });
                return db.SaveChanges();
            }
        }

        public int Update(NufusDetayDTO instance)
        {
            using (db = new Entities())
            {
                NufusDetay gelen = db.NufusDetay.Find(instance.NufusBaglantiliKisiTC);
                gelen.NufusBaglantiliKisiTC = instance.NufusBaglantiliKisiTC;
                gelen.NufusCuzdaniSeriNo = instance.NufusCuzdaniSeriNo;
                gelen.NufusCuzdaniNo = instance.NufusCuzdaniNo;
                gelen.AnaAdi = instance.AnaAdi;
                gelen.BabaAdi = instance.BabaAdi;
                gelen.DogumTarihi = instance.DogumTarihi;
                gelen.DogumYeri = instance.DogumYeri;
                gelen.Dini = instance.Dini;
                gelen.KanGrubu = instance.KanGrubu;
                gelen.ILID = instance.ILID;
                gelen.Mahalle = instance.Mahalle;
                gelen.Koy = instance.Koy;
                gelen.CiltNo = instance.CiltNo;
                gelen.AileSiraNo = instance.AileSiraNo;
                gelen.SiraNo = instance.SiraNo;
                gelen.NufusKayitnNo = instance.NufusKayitnNo;
                gelen.VerilisTarihi = instance.VerilisTarihi;
                gelen.VerilisNedeni = instance.VerilisNedeni;
                gelen.VerildigiYer = instance.VerildigiYer;

                return db.SaveChanges();
            }
        }

        public int Delete(NufusDetayDTO instance)
        {
            using (db = new Entities())
            {
                NufusDetay gelen = db.NufusDetay.Find(instance.NufusBaglantiliKisiTC);
                gelen.AktifMi = false;

                return db.SaveChanges();
            }
        }

        public List<NufusDetayDTO> Select()
        {
            List<NufusDetayDTO> nufList = new List<NufusDetayDTO>();

            using (db = new Entities())
            {
                foreach (NufusDetay item in db.NufusDetay.ToList().Where(p => p.AktifMi == true))
                {
                    nufList.Add(new NufusDetayDTO()
                    {
                        //NufusBaglantiliKisiTC = item.NufusBaglantiliKisiTC,
                        NufusCuzdaniSeriNo = item.NufusCuzdaniSeriNo,
                        NufusCuzdaniNo = item.NufusCuzdaniNo,
                        AnaAdi = item.AnaAdi,
                        BabaAdi = item.BabaAdi,
                        DogumYeri = item.DogumYeri,
                        Dini = item.Dini,
                        KanGrubu = item.KanGrubu,
                        ILID = (int)item.ILID,
                        Mahalle = item.Mahalle,
                        Koy = item.Koy,
                        CiltNo = item.CiltNo,
                        AileSiraNo = item.AileSiraNo,
                        SiraNo = item.SiraNo,
                        NufusKayitnNo = item.NufusKayitnNo,
                        VerilisTarihi = (DateTime)item.VerilisTarihi,
                        VerilisNedeni = item.VerilisNedeni,
                        VerildigiYer = item.VerildigiYer,
                        DogumTarihi = (DateTime)item.DogumTarihi,

                        //KaydiGirenKullaniciID = (int)item.KaydiGirenKullaniciID,
                        //KaydiDegistirenKullaniciID = (int)item.KaydiDegistirenKullaniciID,
                        //KayitTarihi = Convert.ToDateTime(item.KayitTarihi),
                        //KaydiDegistirmeTarihi = Convert.ToDateTime(item.KaydiDegistirmeTarihi),
                        //Aktifmi = (bool)item.AktifMi
                    });
                }
            }
            return nufList;
        }
    }
}
