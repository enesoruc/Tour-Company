using DevOpsTour.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevOpsTour.DAL.Mappings
{
    class BiletDetayMapping:EntityTypeConfiguration<BiletDetay>
    {
        public BiletDetayMapping()
        {
            HasKey(a => new {a.TuristID,a.TurID,a.FaturaID });
        }
    }
}
