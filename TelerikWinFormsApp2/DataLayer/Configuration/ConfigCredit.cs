using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using EsfahanGhos.Model;

namespace EsfahanGhos.DataLayer.Configuration
{
    class ConfigCredit : EntityTypeConfiguration<Credit>
    {
        public ConfigCredit()
        {
            Property(p => p.CreditID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(p => p.Type).HasMaxLength(1);
            Property(p => p.DateCredit).IsRequired();
            Property(p => p.Price).IsRequired();
            Property(P => P.Type).IsRequired();


        }
    }
}
