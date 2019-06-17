using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevOpsTour.Model
{
    public class RehberDil
    {
        public int RehberID { get; set; }
        public int DilID { get; set; }
        public DateTime IslemTarihi { get; set; }

        public virtual Rehber Rehber { get; set; }
        public virtual Dil Dil { get; set; }
    }
}
