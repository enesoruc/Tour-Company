using DevOpsTour.DAL.Repositories;
using DevOpsTour.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevOpsTour.BLL
{
    public class TuristikYerBLL
    {
        TuristikYerRepository _turistikYerRepository;
        public TuristikYerBLL()
        {
            _turistikYerRepository=new TuristikYerRepository();
        }

        public bool Add(TuristikYer TuristikYer)
        {
            return _turistikYerRepository.Add(TuristikYer) > 0;
        }

        public bool Update(TuristikYer TuristikYer)
        {
            return _turistikYerRepository.Update(TuristikYer) > 0;
        }

        public bool Remove(TuristikYer silinecekTuristikYer)
        {
            return _turistikYerRepository.Remove(silinecekTuristikYer) > 0;
        }

        public TuristikYer GetCityByID(int TuristikYerID)
        {
            return _turistikYerRepository.GetCityByID(TuristikYerID);
        }

        public List<TuristikYer> GelAllCities()
        {
            return _turistikYerRepository.GetAllCities();
        }
    }
}
