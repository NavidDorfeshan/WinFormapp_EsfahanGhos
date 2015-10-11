using System.Data.Entity.ModelConfiguration;
using EsfahanGhos.Model;

namespace EsfahanGhos.DataLayer.Configuration
{
    public class ConfigPayment : EntityTypeConfiguration<Payment>
    {
        public ConfigPayment()
        {
            HasKey(p => p.Id);
            Property(p => p.Cost).IsRequired();
            Property(p => p.Date).IsRequired();
            Property(p => p.Description).IsOptional();
            Property(p => p.Reason).IsOptional();
            HasOptional(p => p.Check).WithMany(p => p.Payments).HasForeignKey(p => p.CheckId).WillCascadeOnDelete(true);
            HasOptional(p => p.BankFish).WithMany(p => p.Payments).HasForeignKey(p => p.FishId).WillCascadeOnDelete(true);
            HasOptional(p => p.CardToCard).WithMany(p => p.Payments).HasForeignKey(p => p.CardId).WillCascadeOnDelete(true);
            HasOptional(p => p.Person).WithMany(p => p.Payments).HasForeignKey(p => p.PersonId).WillCascadeOnDelete(false);
            HasOptional(p => p.Factor).WithMany(p => p.Payments).HasForeignKey(p => p.FactorID);
            HasOptional(p => p.Credit).WithMany(p => p.Payments).HasForeignKey(p => p.CreditID);
            HasOptional(p => p.PurchaseList).WithMany(p => p.Payments).HasForeignKey(p => p.PurchaseListID);
            HasOptional(p => p.Project).WithMany(p => p.Payments).HasForeignKey(p => p.ProjectID);
        }
    }
}
