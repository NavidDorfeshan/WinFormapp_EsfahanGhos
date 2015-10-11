using System.Data.Entity.ModelConfiguration;
using EsfahanGhos.Model;

namespace EsfahanGhos.DataLayer.Configuration
{
    public class ConfigStatementItem : EntityTypeConfiguration<StatementItem>
    {
        public ConfigStatementItem()
        {
            HasKey(p => p.Id);
            Property(p => p.Description).IsRequired();
        }
    }
}
