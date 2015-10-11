using System.Data.Entity.ModelConfiguration;
using EsfahanGhos.Model;

namespace EsfahanGhos.DataLayer.Configuration
{
    public class ConfigPerson : EntityTypeConfiguration<Person>
    {
        public ConfigPerson()
        {
            HasKey(p => p.EmployeeID);
            Property(p => p.EmployeeFullName).IsRequired().HasMaxLength(50);
            Property(p => p.FatherName).IsOptional().HasMaxLength(10);
            Property(p => p.EmployeeMaried).IsRequired();
            Property(p => p.EmployeeNationalCode).HasMaxLength(10);
            Property(p => p.IdentityNumber).IsRequired().HasMaxLength(20);
            Property(p => p.CellPhone).IsRequired().HasMaxLength(11);
            Property(p => p.PhoneNumber).IsOptional().HasMaxLength(11);
            Property(p => p.EmployeeBirth).IsOptional();
            Property(p => p.NumberOfChildren).IsOptional();
            
        }
    }
}
