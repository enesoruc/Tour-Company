using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevOpsTour.Model
{
    public class BiletDetay
    {
        public Guid TuristID { get; set; }
        public int TurID { get; set; }
        public int FaturaID { get; set; }
        public DateTime DetayTarih { get; set; }

        public virtual Turist Turist { get; set; }
        public virtual Tur Tur { get; set; }
        public virtual Fatura Fatura { get; set; }
    }
}
