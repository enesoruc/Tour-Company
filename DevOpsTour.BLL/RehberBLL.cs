using DevOpsTour.DAL.Repositories;
using DevOpsTour.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevOpsTour.BLL
{
    public class RehberBLL
    {
        RehberRepository _rehberRepository;
        public RehberBLL()
        {
            _rehberRepository = new RehberRepository();
        }

        public bool Add(Rehber yeniRehber)
        {
            return _rehberRepository.Add(yeniRehber) > 0;
        }

        public bool Update(Rehber guncelRehber)
        {
            return _rehberRepository.Update(guncelRehber) > 0;
        }

        public bool Remove(Rehber silinecekRehber)
        {
            return _rehberRepository.Remove(silinecekRehber) > 0;
        }

        public Rehber GetGuideByID(int rehberID)
        {
           return _rehberRepository.GetGuideByID(rehberID);
        }

        public List<Rehber> GetAllGuides()
        {
            return _rehberRepository.GetAllGuides();
        }

        public List<Rehber> GetAllActiveGuides()
        {
            List<Rehber> aktifRehberler = new List<Rehber>();
            List<Rehber> rehberler;
            rehberler= _rehberRepository.GetAllGuides();

            foreach (Rehber item in rehberler)
            {
                if (item.AktiflikDurumu)
                {
                    aktifRehberler.Add(item);
                }
            }
            return aktifRehberler;
        }

        public int GetGuideIDByNameAndSurname(string guideName)
        {
            int ID = 0;
            List<Rehber> rehberler = _rehberRepository.GetAllGuides();
            foreach (Rehber item in rehberler)
            {
                if ((item.Ad+" "+item.Soyad)==guideName)
                {
                    ID = item.RehberID;
                }
            }

            return ID;
        }
    }
}
