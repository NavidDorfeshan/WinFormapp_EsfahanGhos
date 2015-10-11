using System.Data.Entity.ModelConfiguration;
using EsfahanGhos.Model;

namespace EsfahanGhos.DataLayer.Configuration
{
   public class ConfigSkill : EntityTypeConfiguration<Skill>
    {
       public ConfigSkill()
       {
           HasKey(p => p.SkillID);
           Property(p => p.SkillName).IsRequired().HasMaxLength(50);
       }
    }
}
