using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using EsfahanGhos.Model;

namespace EsfahanGhos.DataLayer.Configuration
{
    public class ConfigTankhah : EntityTypeConfiguration<Tankhah>
    {
      public ConfigTankhah()
      {
          HasKey(p => p.TankhahID);
          Property(p => p.TankhahID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
          Property(p => p.TankhahName).HasMaxLength(50).IsRequired();
          Property(p => p.CreditCurrent).IsRequired();
          HasMany(p => p.PhoneBooks).WithOptional(p => p.Tankhah).HasForeignKey(p => p.TankhahID).WillCascadeOnDelete(true);

      }
    }
}
