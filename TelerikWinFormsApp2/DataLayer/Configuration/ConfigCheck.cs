using System.Data.Entity.ModelConfiguration;
using EsfahanGhos.Model;

namespace EsfahanGhos.DataLayer.Configuration
{
    public class ConfigCheck : EntityTypeConfiguration<Check>
    {
        public ConfigCheck()
        {
            HasKey(p => p.Id);
            Property(p => p.RecoverDate).IsRequired();
            Property(p => p.CheckNumber).IsRequired();
            HasMany(p => p.Payments).WithOptional(p => p.Check).HasForeignKey(p => p.CheckId);
        }
    }
}
