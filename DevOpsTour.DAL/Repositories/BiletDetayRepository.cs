using DevOpsTour.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevOpsTour.DAL.Repositories
{
    public class BiletDetayRepository
    {
        DevOpsDBContext db;
        public BiletDetayRepository()
        {
            db = new DevOpsDBContext();
        }

        public int Add(BiletDetay yeniBiletDetay)
        {
             db.BiletDetaylar.Add(yeniBiletDetay);
            return db.SaveChanges();
        }

        public int Remove(BiletDetay silinecekBiletDetay)
        {
            db.BiletDetaylar.Remove(silinecekBiletDetay);
            return db.SaveChanges();
        }

        public int Update(BiletDetay guncelBiletDetay)
        {
            db.Entry(guncelBiletDetay).State = System.Data.Entity.EntityState.Modified;
            return db.SaveChanges();
        }

        public List<BiletDetay> GetByTouristID(Guid touristID)
        {
            //return (from a in db.BiletDetaylar
            //              where a.TuristID == touristID
            //              select a).ToList();

            return db.BiletDetaylar.Where(a => a.TuristID == touristID).ToList();
        }

        public List<BiletDetay> GetAll()
        {
            return db.BiletDetaylar.ToList();
        }
    }
}
