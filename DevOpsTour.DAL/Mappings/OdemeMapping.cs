using DevOpsTour.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevOpsTour.DAL.Mappings
{
    class OdemeMapping:EntityTypeConfiguration<Odeme>
    {
        public OdemeMapping()
        {
            HasKey(a=>a.OdemeID);
            Property(a=>a.OdemeTipi).IsRequired().HasMaxLength(15);

            HasMany(a => a.Faturalar)
               .WithRequired(a => a.Odeme)
               .HasForeignKey(a => a.OdemeID)
               .WillCascadeOnDelete();
        }
    }
}
