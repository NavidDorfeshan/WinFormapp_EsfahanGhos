using System.Collections.Generic;

namespace EsfahanGhos.Model
{
    public class Skill
    {
        public Skill()
        {
            SkillID = 0;
            SkillName = "";
        }
        public virtual int SkillID { get; set; }
        public virtual string SkillName { get; set; }

        public virtual ICollection<Contractor> Contractors { get; set; }
        public virtual ICollection<CostOfService> CostOfService { get; set; }

    }
}
