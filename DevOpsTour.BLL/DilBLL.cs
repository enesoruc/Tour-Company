using DevOpsTour.DAL.Repositories;
using DevOpsTour.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevOpsTour.BLL
{
    public class DilBLL
    {
        DilRepository _dilRepository;
        public DilBLL()
        {
            _dilRepository = new DilRepository();
        }

        public bool Add(Dil yeniDil)
        {
            return _dilRepository.Add(yeniDil) > 0;
        }

        public bool Update(Dil dil)
        {
            return _dilRepository.Update(dil) > 0;
        }

        public bool Remove(Dil silinecekDil)
        {
            return _dilRepository.Remove(silinecekDil) > 0;
        }

        public Dil GetLanguageByID(int dilID)
        {
            return _dilRepository.GetByID(dilID);
        }

        public List<Dil> GetAllLanguages()
        {
            return _dilRepository.GetAllLanguages();
        }

    }
}
