using DevOpsTour.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevOpsTour.DAL.Mappings
{
    class TuristMapping:EntityTypeConfiguration<Turist>
    {
        public TuristMapping()
        {
            HasKey(a => a.TuristID);
            Property(a => a.Ad).IsRequired().HasMaxLength(40);
            Property(a => a.Soyad).IsRequired().HasMaxLength(40);
            Property(a => a.Cinsiyet).IsRequired().HasMaxLength(6);
            Property(a => a.DogumTarihi).IsRequired();
            Property(a => a.TelefonNo).IsRequired().HasMaxLength(30);
            Property(a => a.Ulke).IsRequired().HasMaxLength(20);
            Property(a => a.Uyruk).IsRequired().HasMaxLength(20);
            Property(a => a.TurkiyeyeGelisTarihi).IsRequired();

            HasMany(a => a.BiletDetaylar)
                 .WithRequired(a => a.Turist)
                 .HasForeignKey(a => a.TuristID)
                 .WillCascadeOnDelete();
        }
    }
}
