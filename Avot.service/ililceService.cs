using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Avot.DAO;
using Avot.DAL;
//Hello World ! :)
namespace Avot.service
{
    public class ililceService : ICrud<ililceDTO>
    {
        private Entities db;

        public int Insert(ililceDTO instance)
        {
            throw new NotImplementedException();
        }

        public int Update(ililceDTO instance)
        {
            throw new NotImplementedException();
        }

        public int Delete(ililceDTO instance)
        {
            throw new NotImplementedException();
        }

        public List<ililceDTO> Select()
        {
            List<ililceDTO> ililceList = new List<ililceDTO>();

            using (db = new Entities())
            {
                foreach (ililce item in db.ililce.ToList())
                {
                    ililceList.Add(new ililceDTO()
                    {
                        ILID = item.ILID,
                        IlKodu = (int)item.IlKodu,
                        Il = item.Il,
                        IlceKodu = (int)item.IlceKodu,
                        Ilce = item.Ilce                       
                    });
                }
            }
            return ililceList;
        }        
    }
}
