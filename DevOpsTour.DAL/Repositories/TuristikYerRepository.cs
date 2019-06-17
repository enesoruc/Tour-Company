using DevOpsTour.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevOpsTour.DAL.Repositories
{
    public class TuristikYerRepository
    {
        DevOpsDBContext db;
        public TuristikYerRepository()
        {
            db = new DevOpsDBContext();
        }

        public int Add(TuristikYer yeniTuristikYer)
        {
            db.TuristikYerler.Add(yeniTuristikYer);
            return db.SaveChanges();
        }
        
        public int Update(TuristikYer guncelTuristikYer)
        {
            db.Entry(guncelTuristikYer).State = System.Data.Entity.EntityState.Modified;
            return db.SaveChanges();
        }

        public int Remove(TuristikYer silinecekTuristikYer)
        {
            db.TuristikYerler.Remove(silinecekTuristikYer);
            return db.SaveChanges();
        }

        public TuristikYer GetCityByID(int TuristikYerID)
        {
            return db.TuristikYerler.SingleOrDefault(a => a.TuristikYerID == TuristikYerID);
        }

        public List<TuristikYer> GetAllCities()
        {
            return db.TuristikYerler.ToList();
        }
    }
}
