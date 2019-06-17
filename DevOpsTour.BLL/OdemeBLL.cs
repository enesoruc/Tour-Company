using DevOpsTour.DAL.Repositories;
using DevOpsTour.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevOpsTour.BLL
{
    public class OdemeBLL
    {
        OdemeRepository _odemeRepository;
        public OdemeBLL()
        {
            _odemeRepository = new OdemeRepository();
        }

        public bool Add(Odeme yeniOdeme)
        {
            return _odemeRepository.Add(yeniOdeme) > 0;
        }

        public bool Update(Odeme guncelOdeme)
        {
            return _odemeRepository.Update(guncelOdeme) > 0;
        }

        public bool Remove(Odeme silinecekOdeme)
        {
            return _odemeRepository.Remove(silinecekOdeme) > 0;
        }

        public List<Odeme> Pays()
        {
            return _odemeRepository.Pays();
        }
    }
}
