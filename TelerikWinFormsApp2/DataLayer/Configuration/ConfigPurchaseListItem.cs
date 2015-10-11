using System.Data.Entity.ModelConfiguration;
using EsfahanGhos.Model;

namespace EsfahanGhos.DataLayer.Configuration
{
    class ConfigPurchaseListItem : EntityTypeConfiguration<PurchaseListItem>
    {
        public ConfigPurchaseListItem()
        {
            Property(p => p.Description).IsRequired();
            Property(p => p.Price).IsRequired();
            Property(p => p.Date).IsRequired().HasColumnType("Date");
        }
    }
}
