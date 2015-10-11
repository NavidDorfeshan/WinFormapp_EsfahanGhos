using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using EsfahanGhos.Model;

namespace EsfahanGhos.DataLayer.Configuration
{
    public class ConfigContractor : EntityTypeConfiguration<Contractor>
    {
        public ConfigContractor()
        {
            HasKey(p => p.ContractorID);
            Property(p => p.ContractorID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(p => p.CName).IsRequired().HasMaxLength(50);
            HasMany(p => p.Skills).WithMany(p => p.Contractors);
            HasMany(p => p.PhoneBooks).WithOptional(p => p.Contractor).HasForeignKey(p => p.ContractorID).WillCascadeOnDelete(true);
            HasMany(p => p.CostOfServices).WithRequired(p => p.Contractor).HasForeignKey(p => p.ContractorID).WillCascadeOnDelete(false);

            HasOptional(p => p.Project).WithMany(p => p.Contractors).HasForeignKey(p => p.ProjectID);



        }
    }
}
