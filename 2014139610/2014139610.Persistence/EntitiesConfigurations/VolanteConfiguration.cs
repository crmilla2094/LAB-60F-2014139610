using _2014139610.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014139610.Persistance.EntitiesConfigurations
{
    public class VolanteConfiguration : EntityTypeConfiguration<Volante>
    {
        public VolanteConfiguration()
        {
            //Table Configurations
            ToTable("Volante");

            HasKey(a => a.VolanteId);

            //Relations Configurations
           // HasRequired(a => a.Carro)
              //  .WithOptional(a => a.Volante);

        }
    }
}
