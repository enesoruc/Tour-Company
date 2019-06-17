using DevOpsTour.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevOpsTour.DAL.Repositories
{
    public class TuristRepository
    {
        DevOpsDBContext db;
        public TuristRepository()
        {
            db = new DevOpsDBContext();
        }

        public int Add(Turist yeniTurist)
        {
            db.Turistler.Add(yeniTurist);
            return db.SaveChanges();
        }

        public int Update(Turist guncelTurist)
        {
            db.Entry(guncelTurist).State = System.Data.Entity.EntityState.Modified;
            return db.SaveChanges();
        }

        public int Remove(Turist silincekTurist)
        {
            db.Turistler.Remove(silincekTurist);
            return db.SaveChanges();
        }

        public Turist GetTouristByID(Guid turistID)
        {
            return db.Turistler.SingleOrDefault(a=>a.TuristID==turistID);
        }

        public List<Turist> GetAllTourists()
        {
            return db.Turistler.ToList();
        }
    }
}
