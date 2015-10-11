using System.Collections.Generic;

namespace EsfahanGhos.Model
{
    public class Contractor
    {
        public Contractor()
        {
            ContractorID = 0;
            CName = "";
        }
        public virtual int ContractorID { get; set; }
        public virtual string CName { get; set; }
        public virtual int? ProjectID { get; set; }

        public virtual Project Project { get; set; }
        public virtual ICollection<Skill> Skills { get; set; }
        public virtual ICollection<PhoneBook> PhoneBooks { get; set; }
        public virtual ICollection<CostOfService> CostOfServices { get; set; }
    }
}
