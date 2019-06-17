using DevOpsTour.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevOpsTour.DAL.Mappings
{
    class RehberMapping:EntityTypeConfiguration<Rehber>
    {
        public RehberMapping()
        {
            HasKey(a => a.RehberID);
            Property(a=>a.Ad).IsRequired().HasMaxLength(50);
            Property(a=>a.Soyad).IsRequired().HasMaxLength(50);
            Property(a => a.Ulke).IsRequired().HasMaxLength(50);
            Property(a => a.Uyruk).IsRequired().HasMaxLength(50);
            Property(a => a.Cinsiyet).IsRequired().HasMaxLength(6);
            Property(a => a.TelefonNo).IsRequired().HasMaxLength(30);

            HasMany(a => a.Turlar)
                .WithRequired(a => a.Rehber)
                .HasForeignKey(a => a.RehberID);
        }
    }
}
