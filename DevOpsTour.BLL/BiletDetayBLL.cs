using DevOpsTour.DAL.Repositories;
using DevOpsTour.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevOpsTour.BLL
{
    public class BiletDetayBLL
    {
        BiletDetayRepository _biletDetayRepository;
        public BiletDetayBLL()
        {
            _biletDetayRepository = new BiletDetayRepository();
        }

        public bool Add(BiletDetay yeniBiletDetay)
        {
            return _biletDetayRepository.Add(yeniBiletDetay) > 0;
        }

        public bool Update(BiletDetay guncelBiletDetay)
        {
            return _biletDetayRepository.Update(guncelBiletDetay) > 0;
        }

        public bool Remove(BiletDetay silinecekBiletDetay)
        {
            return _biletDetayRepository.Remove(silinecekBiletDetay) > 0;
        }

        public List<BiletDetay> GetTouristbyID(Guid turisID)
        {
            return _biletDetayRepository.GetByTouristID(turisID);
        }

        public List<BiletDetay> GetAll()
        {
            return _biletDetayRepository.GetAll();
        }
    }
}
