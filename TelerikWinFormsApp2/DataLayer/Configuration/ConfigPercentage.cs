using System.Data.Entity.ModelConfiguration;
using EsfahanGhos.Model;

namespace EsfahanGhos.DataLayer.Configuration
{
    class ConfigPercentage : EntityTypeConfiguration<Percentage>
    {
        public ConfigPercentage()
        {
            HasKey(p => p.PrecentageID);
            Property(p => p.Precent).IsRequired();
            Property(p => p.name).IsRequired();
            Property(p => p.name).HasMaxLength(50);
        }
    }
}
