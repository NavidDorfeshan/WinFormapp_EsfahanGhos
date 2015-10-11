using System.Data.Entity.ModelConfiguration;
using EsfahanGhos.Model;

namespace EsfahanGhos.DataLayer.Configuration
{
    class ConfigFactor_Item : EntityTypeConfiguration<Factor_Item>
    {
        public ConfigFactor_Item()
        {
            Property(p => p.Description).IsRequired();//الزامی بودن فیلد
            Property(p => p.Qty).IsRequired();
            Property(p => p.SoldPrice).IsRequired();
        }
    }
}
