using DevOpsTour.DAL.Repositories;
using DevOpsTour.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevOpsTour.BLL
{
    public class FaturaBLL
    {
        FaturaRepository _faturaRepository;
        public FaturaBLL()
        {
            _faturaRepository = new FaturaRepository();
        }

        public bool Add(Fatura yeniFatura)
        {
            return _faturaRepository.Add(yeniFatura) > 0;
        }

        public bool Update(Fatura guncelFatura)
        {
            return _faturaRepository.Update(guncelFatura) > 0;
        }

        public int GetLastID()
        {
            return _faturaRepository.GetLastID();
        }
    }
}
