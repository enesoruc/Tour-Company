using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevOpsTour.Model
{
    public class TuristikYer
    {
        public TuristikYer()
        {
            Turlar = new HashSet<Tur>();
        }
        public int TuristikYerID { get; set; }
        public string TurAdi { get; set; }
        public string Notlar { get; set; }
        public decimal Ucret { get; set; }

        public virtual ICollection<Tur> Turlar { get; set; }
    }
}
