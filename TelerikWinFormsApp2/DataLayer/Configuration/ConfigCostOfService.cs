using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using EsfahanGhos.Model;

namespace EsfahanGhos.DataLayer.Configuration
{
    class ConfigCostOfService : EntityTypeConfiguration<CostOfService>
    {
        public ConfigCostOfService()
        {
            Property(p => p.CostOfServiceID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);//لغو ساخت آی دی توسط دیتا بیس
            Property(p => p.Cost).IsRequired();//الزامی بودن فیلد
            Property(p => p.Date).IsRequired().HasColumnType("Date");
        }
    }
}
