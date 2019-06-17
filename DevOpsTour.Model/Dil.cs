using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevOpsTour.Model
{
    public class Dil
    {
        public Dil()
        {
            Turlar = new HashSet<Tur>();
        }
        public int DilID { get; set; }
        public string DilAdi { get; set; }

        public virtual ICollection<Tur> Turlar { get; set; }
    }
}
