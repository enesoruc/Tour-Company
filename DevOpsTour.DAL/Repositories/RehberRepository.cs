using DevOpsTour.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevOpsTour.DAL.Repositories
{
    public class RehberRepository
    {
        DevOpsDBContext db;
        public RehberRepository()
        {
            db = new DevOpsDBContext();
        }

        public int Add(Rehber yeniRehber)
        {
            db.Rehberler.Add(yeniRehber);
            return db.SaveChanges();
        }

        public int Update(Rehber guncelRehber)
        {
            db.Entry(guncelRehber).State = System.Data.Entity.EntityState.Modified;
            return db.SaveChanges();
        }

        public int Remove(Rehber silinecekRehber)
        {
            db.Rehberler.Remove(silinecekRehber);
            return db.SaveChanges();
        }

        public Rehber GetGuideByID(int rehberID)
        {
            return db.Rehberler.SingleOrDefault(a => a.RehberID == rehberID);            
        }

        public List<Rehber> GetAllGuides()
        {
            return db.Rehberler.ToList();
        }
    }
}
