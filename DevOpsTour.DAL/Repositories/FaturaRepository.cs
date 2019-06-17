using DevOpsTour.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevOpsTour.DAL.Repositories
{
    public class FaturaRepository
    {
        DevOpsDBContext db;
        public FaturaRepository()
        {
            db = new DevOpsDBContext();
        }

        public int Add(Fatura yeniFatura)
        {
            db.Faturalar.Add(yeniFatura);
            return db.SaveChanges();
        }

        public int Update(Fatura guncelFatura)
        {
            db.Entry(guncelFatura).State = System.Data.Entity.EntityState.Modified;
            return db.SaveChanges();
        }

        public int Remove(Fatura silinecekFatura)
        {
            db.Faturalar.Remove(silinecekFatura);
            return db.SaveChanges();
        }

        public Fatura GetFaturaByID(int faturaID)
        {
            return db.Faturalar.SingleOrDefault(a => a.FaturaID == faturaID);
        }

        public int GetLastID()
        {
            return db.Faturalar.Max(a => a.FaturaID);
        }

        public List<Fatura> GetAllInvoices()
        {
            return db.Faturalar.ToList();
        }
    }
}
