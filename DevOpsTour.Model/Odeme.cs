using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevOpsTour.Model
{
    public class Odeme
    {
        public Odeme()
        {
            Faturalar = new HashSet<Fatura>();
        }
        public int OdemeID { get; set; }
        public string OdemeTipi { get; set; }

        public virtual ICollection<Fatura> Faturalar { get; set; }
    }
}
