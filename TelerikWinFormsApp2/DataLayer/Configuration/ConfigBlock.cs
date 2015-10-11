using System.Data.Entity.ModelConfiguration;
using EsfahanGhos.Model;

namespace EsfahanGhos.DataLayer.Configuration
{
    public class ConfigBlock : EntityTypeConfiguration<Block>
    {
        public ConfigBlock()
        {
            HasKey(p => p.BlockID);
            HasOptional(p => p.Project).WithMany(p => p.Blocks).HasForeignKey(p => p.ProjectID);
            Property(p => p.BlockName).HasMaxLength(50);
            Property(p => p.IsExist).IsOptional();
        }
    }
}
