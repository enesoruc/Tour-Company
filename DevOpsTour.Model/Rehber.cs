using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevOpsTour.Model
{
    public class Rehber:Kisi
    {
        public Rehber()
        {
            Turlar = new HashSet<Tur>();
        }
        public int RehberID { get; set; }
        public bool AktiflikDurumu { get; set; }

        //public virtual Tur Tur { get; set; }
        public virtual ICollection<Tur> Turlar { get; set; }
    }
}
