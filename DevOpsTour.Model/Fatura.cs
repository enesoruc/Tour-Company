using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevOpsTour.Model
{
    public class Fatura
    {
        public Fatura()
        {
            BiletDetaylar = new HashSet<BiletDetay>();
        }
        public int FaturaID { get; set; }
        public int OdemeID { get; set; }
        public decimal Tutar { get; set; }
        public DateTime FaturaTarihi { get; set; }
        public virtual Odeme Odeme { get; set; }

        
        public virtual ICollection<BiletDetay> BiletDetaylar { get; set; }
        public virtual Odeme OdemeTip { get; set; }
    }
}
