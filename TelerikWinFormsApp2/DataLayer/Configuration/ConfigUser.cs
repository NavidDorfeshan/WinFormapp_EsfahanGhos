using System.Data.Entity.ModelConfiguration;
using EsfahanGhos.Model.Login_Classes;

namespace EsfahanGhos.DataLayer.Configuration
{
    public class ConfigUser : EntityTypeConfiguration<User>
    {
        public ConfigUser()
        {
            HasKey(p => p.UserID);
            Property(p => p.FName).IsRequired().HasMaxLength(50);
            Property(p => p.UserName).IsRequired().HasMaxLength(20);
            Property(p => p.Password).IsRequired();
        }
    }
}
