using DevOpsTour.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevOpsTour.DAL.Mappings
{
    public class RehberDilRepository
    {
        DevOpsDBContext db;
        public RehberDilRepository()
        {
            db = new DevOpsDBContext();
        }
        public int Add(RehberDil yeniRehberDil)
        {
            db.RehberDilleri.Add(yeniRehberDil);
            return db.SaveChanges();
        }

        public int Update(RehberDil guncelRehberDil)
        {
            db.Entry(guncelRehberDil).State = System.Data.Entity.EntityState.Modified;
            return db.SaveChanges();
        }

        public int Remove(RehberDil silinecekRehberDil)
        {
            db.RehberDilleri.Remove(silinecekRehberDil);
            return db.SaveChanges();
        }

        public List<string> GetLanguagesByRehberID(int RehberID)
        {
            List<string> diller = new List<string>();
            var result = db.Rehberler.Join(db.RehberDilleri,
                                        o => o.RehberID,
                                        c => c.RehberID,
                                        (o, c) => new
                                        {
                                            dil = c.DilID,
                                            rehber=c.RehberID
                                        }).Join(db.Diller,
                                                oc => oc.dil,
                                                e => e.DilID,
                                                (oc, e) => new
                                                {
                                                    rehberinDili = e.DilAdi,
                                                    rehber=oc.rehber
                                                }).Where(a=>a.rehber==RehberID).ToList();
            foreach (var item in result)
            {
                diller.Add(item.rehberinDili);
            }
            return diller;
        }
        public List<string> GetGuidesByLanguageID(int languageID)
        {
            List<string> rehberler = new List<string>();
            var result = db.Diller.Join(db.RehberDilleri,
                                        o => o.DilID,
                                        c => c.DilID,
                                        (o, c) => new
                                        {
                                            dil=o.DilID,
                                            Rehber = c.RehberID,
                                        }).Join(db.Rehberler,
                                                oc => oc.Rehber,
                                                e => e.RehberID,
                                                (oc, e) => new
                                                {
                                                    rehber = e.Ad+" "+e.Soyad,
                                                    dilID=oc.dil
                                                }).Where(a=>a.dilID==languageID).Select(a=>a.rehber).ToList();
            foreach (var item in result)
            {
                rehberler.Add(item);
            }
            return rehberler;
        }



        public List<RehberDil> GetAllLanguages()
        {
            return db.RehberDilleri.ToList();
        }
    }
}
