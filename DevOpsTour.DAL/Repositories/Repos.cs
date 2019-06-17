using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevOpsTour.DAL.Repositories
{
    public interface Repos<T>
    {
        int Add(T param);
        int Update(T param);
        int Remove(T param);
        int GetByID();
        int GetAll();
    }
}
