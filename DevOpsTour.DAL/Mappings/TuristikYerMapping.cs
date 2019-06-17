using DevOpsTour.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevOpsTour.DAL.Mappings
{
    class TuristikYerMapping:EntityTypeConfiguration<TuristikYer>
    {
        public TuristikYerMapping()
        {
            HasKey(a=>a.TuristikYerID);
            Property(a => a.TurAdi).IsRequired().HasMaxLength(20);
            Property(a => a.Notlar).HasMaxLength(250);
        }
    }
}
