using DevOpsTour.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevOpsTour.DAL.Mappings
{
    class RehberDilleriMapping:EntityTypeConfiguration<RehberDil>
    {
        public RehberDilleriMapping()
        {
            HasKey(a=>new {a.RehberID,a.DilID});
        }
    }
}
