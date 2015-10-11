using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using EsfahanGhos.Model;

namespace EsfahanGhos.DataLayer.Configuration
{
    class ConfigPurcheseList : EntityTypeConfiguration<PurchaseList>
    {
        public ConfigPurcheseList()
        {
            HasKey(p => p.PurchaseListID);
            Property(p => p.PurchaseListID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(p => p.Date).IsRequired();
            Property(p => p.NumberOfList).IsRequired();
            Property(p => p.TotalPrice).IsRequired();
            HasOptional(p => p.Credit);
            HasMany(p => p.PurchaseListItems).WithRequired(p => p.PurchaseList).HasForeignKey(p => p.PurchaseListID);
            //HasMany(p => p.CostOfServices).WithOptional(p => p.PurchaseList).HasForeignKey(p => p.CostOfServiceID);
        }
    }
}
