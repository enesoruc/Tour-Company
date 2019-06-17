using DevOpsTour.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevOpsTour.DAL.Repositories
{
    public class DilRepository
    {
        DevOpsDBContext db;
        public DilRepository()
        {
            db = new DevOpsDBContext();
        }

        public int Add(Dil yeniDil)
        {
            db.Diller.Add(yeniDil);
            return db.SaveChanges();
        }

        public int Update(Dil guncelDil)
        {
            db.Entry(guncelDil).State = System.Data.Entity.EntityState.Modified;
            return db.SaveChanges();
        }

        public int Remove(Dil silinecekDil)
        {
            db.Diller.Remove(silinecekDil);
            return db.SaveChanges();
        }

        public Dil GetByID(int dilID)
        {
            return db.Diller.SingleOrDefault(a => a.DilID == dilID);
        }

        public List<Dil> GetAllLanguages()
        {
            return db.Diller.ToList();
        }
    }
}
