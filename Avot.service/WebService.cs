using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Avot.DAO;
using Avot.DAL;

namespace Avot.service
{
    public class WebService : ICrud<WebDTO>
    {
        Entities db;
        public int Insert(WebDTO instance)
        {
            using (db = new Entities())
            {
                db.Web.Add(new Web()
                {
                    URL = instance.URL,
                    Aciklama = instance.Aciklama
                });
                return db.SaveChanges();
            }
        }

        public int Update(WebDTO instance)
        {
            using (db = new Entities())
            {
                Web gelen = db.Web.Find(instance.ID);
                gelen.URL = instance.URL;
                gelen.Aciklama = instance.Aciklama;

                return db.SaveChanges();
            }
        }

        public int Delete(WebDTO instance)
        {
            using (db = new Entities())
            {
                Web gelen = db.Web.Find(instance.ID);
                gelen.AktifMi = false;

                return db.SaveChanges();
            }
        }

        public List<WebDTO> Select()
        {
            List<WebDTO> webList = new List<WebDTO>();

            using (db = new Entities())
            {
                foreach (Web item in db.Web.ToList().Where(p => p.AktifMi == true))
                {
                    webList.Add(new WebDTO()
                    {
                        ID = item.WebKayitID,
                        URL = item.URL,
                        Aciklama = item.Aciklama
                    });
                }
            }
            return webList;
        }
    }
}
