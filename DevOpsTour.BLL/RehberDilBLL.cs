using DevOpsTour.DAL.Mappings;
using DevOpsTour.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevOpsTour.BLL
{
    public class RehberDilBLL
    {
        RehberDilRepository _rehberDilRepository;
        public RehberDilBLL()
        {
            _rehberDilRepository = new RehberDilRepository();
        }

        public bool Add(RehberDil yeniRehberDil)
        {
            return _rehberDilRepository.Add(yeniRehberDil) > 0;
        }

        public bool Update(RehberDil guncelRehberDil)
        {
            return _rehberDilRepository.Update(guncelRehberDil) > 0;
        }

        public bool Remove(RehberDil silinecekRehberDil)
        {
            return _rehberDilRepository.Remove(silinecekRehberDil) > 0;
        }

        public List<string> GetLanguagesByRehberID (int RehberID)
        {
            return _rehberDilRepository.GetLanguagesByRehberID(RehberID);
        }

        public List<string> GetGuidesByLanguageID(int languageID)
        {
            return _rehberDilRepository.GetGuidesByLanguageID(languageID);
        }
    }
}
