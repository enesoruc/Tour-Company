using DevOpsTour.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevOpsTour.DAL.Repositories
{
    public class TurRepository
    {
        DevOpsDBContext db;
        public TurRepository()
        {
            db = new DevOpsDBContext();
        }

        public int Add(Tur yeniTur)
        {
            db.Turlar.Add(yeniTur);
            return db.SaveChanges();
        }

        public int Update(Tur guncelTur)
        {
            Tur yenitur = new Tur();
            yenitur = guncelTur;
            db.Entry(yenitur).State = System.Data.Entity.EntityState.Modified;
            return db.SaveChanges();
        }

        public int Remove(Tur silinecekTur)
        {
            db.Turlar.Remove(silinecekTur);
            return db.SaveChanges();
        }

        public Tur GetTourByID(int turID)
        {
            return db.Turlar.SingleOrDefault(a => a.TurID == turID);
        }

        public List<Tur> GetToursByLanguageID(int languageID,DateTime turTarih)
        {
            return db.Turlar.Where(a => a.TurDilID == languageID & a.TurTarihi==turTarih).ToList();
        }

        public List<Tur> GetAllTours()
        {
            return db.Turlar.ToList();
        }

        public List<Tur> GetToursByLanguage(int languageID)
        {
            //List<Tur> ts = new List<Tur>();
            //var result = db.Turlar.Where(a => a.TurDilID == languageID).ToList();

            //foreach (Tur item in result)
            //{
            //    ts.Add(item);
            //}
            //return ts;

            List<Tur> ts = db.Turlar.Where(a => a.TurDilID == languageID).ToList();

             return ts;
        }
    }
}
