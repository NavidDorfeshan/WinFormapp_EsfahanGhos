using System.Data.Entity.ModelConfiguration;
using EsfahanGhos.Model;

namespace EsfahanGhos.DataLayer.Configuration
{
    public class ConfigPhoneBook : EntityTypeConfiguration<PhoneBook>
    {
        public ConfigPhoneBook()
        {
            HasKey(p => p.PID);
            Property(p => p.PNumber).IsRequired().HasMaxLength(20);
        }
    }
}
