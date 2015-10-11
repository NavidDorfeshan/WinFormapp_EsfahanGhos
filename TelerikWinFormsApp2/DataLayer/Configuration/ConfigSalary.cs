using System.Data.Entity.ModelConfiguration;
using EsfahanGhos.Model;

namespace EsfahanGhos.DataLayer.Configuration
{
    public class ConfigSalary : EntityTypeConfiguration<Salary>
    {
        public ConfigSalary()
        {
            HasKey(p => p.Id);
            Property(p => p.Cost).IsRequired();
            Property(p => p.Description).IsOptional();
            Property(p => p.DateStart).IsRequired();
            Property(p => p.DateFinish).IsRequired();
            Property(p => p.Date).IsRequired();
            HasRequired(p => p.Person).WithMany(p => p.Salaries).HasForeignKey(p => p.PersonId);
            HasOptional(p => p.Project).WithMany(p => p.Salaries).HasForeignKey(p => p.ProjectId);
        }
    }
}
