using System.Data.Entity.ModelConfiguration;
using EsfahanGhos.Model.Login_Classes;

namespace EsfahanGhos.DataLayer.Configuration
{
    public class ConfigUserIO : EntityTypeConfiguration<User_IO>
    {
        public ConfigUserIO()
        {
            Property(p => p.ExitDate).IsOptional();
            Property(p => p.EnterDate).IsOptional();
        }
    }
}
