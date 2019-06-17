using DevOpsTour.DAL.Repositories;
using DevOpsTour.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevOpsTour.BLL
{
    public class TuristBLL
    {
        TuristRepository _turistRepository;
        public TuristBLL()
        {
            _turistRepository = new TuristRepository();
        }

        public bool Add(Turist yeniTurist)
        {
          return _turistRepository.Add(yeniTurist) > 0;
        }

        public bool Update(Turist guncelTurist)
        {
            return _turistRepository.Update(guncelTurist) > 0;
        }

        public bool Remove(Turist silinecekTurist)
        {
            return _turistRepository.Remove(silinecekTurist) > 0;
        }

        public Turist GetTouristbyID(Guid turistID)
        {
            return _turistRepository.GetTouristByID(turistID);
        }

        public List<Turist> GetAllTourists()
        {
            return _turistRepository.GetAllTourists();
        }
    }
}
