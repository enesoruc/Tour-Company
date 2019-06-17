using DevOpsTour.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevOpsTour.DAL.Mappings
{
    class FaturaMapping : EntityTypeConfiguration<Fatura>
    {
        public FaturaMapping()
        {
            HasKey(a => a.FaturaID);
            Property(a => a.Tutar).IsRequired();
          
            HasMany(a => a.BiletDetaylar)
               .WithRequired(a => a.Fatura)
               .HasForeignKey(a => a.FaturaID)
               .WillCascadeOnDelete();
        }
    }
}
