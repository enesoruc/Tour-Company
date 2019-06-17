using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevOpsTour.Model
{
    public class Turist:Kisi
    {
        public Turist()
        {
            BiletDetaylar = new HashSet<BiletDetay>();
        }
        public Guid TuristID { get; set; }
        public DateTime TurkiyeyeGelisTarihi { get; set; }

        public virtual ICollection<BiletDetay> BiletDetaylar { get; set; }
    }
}
