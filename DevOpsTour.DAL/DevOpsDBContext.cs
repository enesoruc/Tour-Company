using DevOpsTour.DAL.Mappings;
using DevOpsTour.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevOpsTour.DAL
{
    class DevOpsDBContext :DbContext
    {
        public DevOpsDBContext()
            : base("Server=.;Database=DevOpsDB;Trusted_Connection=True")
        { }
        
        public DbSet<Dil> Diller { get; set; }
        public DbSet<Fatura> Faturalar { get; set; }
        public DbSet<TuristikYer> TuristikYerler { get; set; }
        public DbSet<Odeme> Odemeler { get; set; }
        public DbSet<Rehber> Rehberler { get; set; }
        public DbSet<Tur> Turlar { get; set; }
        public DbSet<Turist> Turistler { get; set; }
        public DbSet<BiletDetay> BiletDetaylar { get; set; }
        public DbSet<RehberDil> RehberDilleri { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new DilMapping());
            modelBuilder.Configurations.Add(new FaturaMapping());
            modelBuilder.Configurations.Add(new TuristikYerMapping());
            modelBuilder.Configurations.Add(new OdemeMapping());
            modelBuilder.Configurations.Add(new RehberMapping());
            modelBuilder.Configurations.Add(new TuristMapping());
            modelBuilder.Configurations.Add(new TurMapping());
            modelBuilder.Configurations.Add(new BiletDetayMapping());
            modelBuilder.Configurations.Add(new RehberDilleriMapping());

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        
    }
}
