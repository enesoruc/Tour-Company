using DevOpsTour.DAL.Repositories;
using DevOpsTour.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevOpsTour.BLL
{
    public class TurBLL
    {
        TurRepository _turRepository;
        public TurBLL()
        {
            _turRepository = new TurRepository();
        }

        public bool Add(Tur yeniTur)
        {
            return _turRepository.Add(yeniTur) > 0;
        }

        public bool Update(Tur guncelTur)
        {
            return _turRepository.Update(guncelTur) > 0;
        }

        public bool Remove(Tur silinecekTur)
        {
            return _turRepository.Remove(silinecekTur) > 0;
        }

        public Tur GetTourByID(int turID)
        {
            return _turRepository.GetTourByID(turID);
        }

        public List<Tur> GetAllTours()
        {
            return _turRepository.GetAllTours();
        }

        public List<Tur> GetToursByLanguageAndDate(int dilID)/*,DateTime turTarih*/
        {
            List<Tur> languageTours = new List<Tur>();
            List<Tur> allTours = _turRepository.GetAllTours();
            foreach (Tur item in allTours)
            {
                if (item.TurDilID==dilID)/*&& item.TurTarihi==turTarih*/
                {
                    allTours.Add(item);
                }
            }
            return languageTours;
        }

        public List<Tur> GetToursByLanguage(int languageID)
        {
            return _turRepository.GetToursByLanguage(languageID);
        }
    }
}
