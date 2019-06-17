using DevOpsTour.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevOpsTour.DAL.Mappings
{
    class TurMapping:EntityTypeConfiguration<Tur>
    {
        public TurMapping()
        {
            HasKey(a => a.TurID);
            Property(a => a.TurAdi).IsRequired().HasMaxLength(50);

            HasRequired(a => a.TuristikYer)
                .WithMany(a => a.Turlar)
                .HasForeignKey(a => a.TuristikYerID);


            HasMany(a => a.BiletDetaylar)
                .WithRequired(a => a.Tur)
                .HasForeignKey(a => a.TurID)
                .WillCascadeOnDelete();

            HasRequired(a => a.Dil)
                .WithMany(a => a.Turlar)
                .HasForeignKey(a => a.TurDilID);
        }
    }
}
