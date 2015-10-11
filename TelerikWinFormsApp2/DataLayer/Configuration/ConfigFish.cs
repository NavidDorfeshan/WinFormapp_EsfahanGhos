using System.Data.Entity.ModelConfiguration;
using EsfahanGhos.Model;

namespace EsfahanGhos.DataLayer.Configuration
{
    public class ConfigFish : EntityTypeConfiguration<BankFish>
    {
        public ConfigFish()
        {
            HasKey(p => p.Id);
            Property(p => p.Name_Start).IsRequired().HasMaxLength(50);
            Property(p => p.AccountingNumber).IsRequired();
        }
    }
}
