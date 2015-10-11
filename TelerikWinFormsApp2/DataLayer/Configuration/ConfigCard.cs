using System.Data.Entity.ModelConfiguration;
using EsfahanGhos.Model;

namespace EsfahanGhos.DataLayer.Configuration
{
    public class ConfigCard : EntityTypeConfiguration<CardToCard>
    {
        public ConfigCard()
        {
            HasKey(p => p.Id);
            Property(p => p.Name).IsRequired().HasMaxLength(50);
            Property(p => p.Code_Peygiri).IsOptional();
            Property(p => p.Card_Start).IsRequired();
            Property((p => p.Card_Finish)).IsRequired();
        }
    }
}
