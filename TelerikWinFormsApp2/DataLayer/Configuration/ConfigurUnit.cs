using System.Data.Entity.ModelConfiguration;
using EsfahanGhos.Model;

namespace EsfahanGhos.DataLayer.Configuration
{
    class ConfigurUnit : EntityTypeConfiguration<Unit>
    {
        public ConfigurUnit()
        {
            HasKey(p => p.Id);
            Property(p => p.UnitName).HasMaxLength(50).IsRequired();
        }
    }
}
