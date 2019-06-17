using DevOpsTour.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevOpsTour.DAL.Repositories
{
    public class OdemeRepository
    {
        DevOpsDBContext db;
        public OdemeRepository()
        {
            db = new DevOpsDBContext();
        }

        public int Add(Odeme yeniOdeme)
        {
            db.Odemeler.Add(yeniOdeme);
            return db.SaveChanges();
        }

        public int Update(Odeme guncelOdeme)
        {
            db.Entry(guncelOdeme).State = System.Data.Entity.EntityState.Modified;
            return db.SaveChanges();
        }

        public int Remove(Odeme silinecekOdeme)
        {
            db.Odemeler.Remove(silinecekOdeme);
            return db.SaveChanges();
        }

        public List<Odeme> Pays()
        {
            return db.Odemeler.ToList();
        }
    }
}
