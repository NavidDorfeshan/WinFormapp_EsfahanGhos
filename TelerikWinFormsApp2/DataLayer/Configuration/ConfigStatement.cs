using System.Data.Entity.ModelConfiguration;
using EsfahanGhos.Model;

namespace EsfahanGhos.DataLayer.Configuration
{
    public class ConfigStatement : EntityTypeConfiguration<Statement>
    {
        public ConfigStatement()
        {
            HasKey(p => p.id);
            Property(p => p.Date).IsRequired();
            Property(p => p.StatementNum).IsOptional();
            Property(p => p.Description).IsOptional();
            Property(p => p.StatementPrice).IsRequired();
            HasMany(p => p.StatementItems).WithRequired(p => p.Statement).HasForeignKey(p => p.StatementId);
            HasRequired(p => p.Project).WithMany(p => p.Statements).HasForeignKey(p => p.ProjectID);
        }
    }
}
