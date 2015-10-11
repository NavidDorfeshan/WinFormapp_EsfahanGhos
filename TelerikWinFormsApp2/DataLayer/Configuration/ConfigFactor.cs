using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using EsfahanGhos.Model;

namespace EsfahanGhos.DataLayer.Configuration
{
    class ConfigFactor : EntityTypeConfiguration<Factor>
    {
        public ConfigFactor()
        {
            Property(p => p.FactorID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(p => p.FactorNumber).HasMaxLength(30);
            Property(p => p.FactorNumber).IsRequired();
            Property(P => P.TotalPrice).IsRequired();
            Property(p => p.Date).IsRequired();
            Property(p => p.VAX).IsRequired();
            Property(p => p.VAXPrice).IsOptional();
            Property(p => p.Description).HasMaxLength(50).IsRequired();
            HasMany(p => p.Factor_Items).WithRequired(p => p.Factor).HasForeignKey(p => p.FactorID).WillCascadeOnDelete(true);

        }
    }
}
