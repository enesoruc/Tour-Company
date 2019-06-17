using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevOpsTour.Model
{
    public class Tur
    {
        public Tur()
        {
            BiletDetaylar = new HashSet<BiletDetay>();
        }
        public int TurID { get; set; }
        public string TurAdi { get; set; }
        public int RehberID { get; set; }
        public int TuristikYerID { get; set; }
        public decimal Ucret { get; set; }
        public DateTime TurTarihi { get; set; }
        public int TurDilID { get; set; }


        public virtual ICollection<BiletDetay> BiletDetaylar { get; set; }
        public virtual Rehber Rehber { get; set; }
        public virtual TuristikYer TuristikYer { get; set; }
        public virtual Dil Dil { get; set; }
    }
}
