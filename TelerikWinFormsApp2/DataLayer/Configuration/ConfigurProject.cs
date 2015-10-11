using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using EsfahanGhos.Model;

namespace EsfahanGhos.DataLayer.Configuration
{
    class ConfigurProject : EntityTypeConfiguration<Project>
    {
        public ConfigurProject()
        {
            HasKey(p => p.ProjectID);
            Property(p => p.ProjectID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(p => p.ProjectName).HasMaxLength(50).IsRequired();
            Property(p => p.ProjectFinish).IsOptional();
            Property(p => p.ProjectUnit).IsOptional();
            Property(p => p.PriceProject).IsRequired();
            Property(p => p.PriceProject).IsOptional();
            Property(p => p.Emp_Name).IsOptional().HasMaxLength(50);
            Property(p => p.TotalInCome).IsOptional();
        }
    }
}
