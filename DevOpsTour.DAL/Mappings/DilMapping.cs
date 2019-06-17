using DevOpsTour.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevOpsTour.DAL.Mappings
{
    class DilMapping:EntityTypeConfiguration<Dil>
    {
        public DilMapping()
        {
            HasKey(a=>a.DilID);
            Property(a => a.DilAdi).IsRequired().HasMaxLength(20);
        }
    }
}
