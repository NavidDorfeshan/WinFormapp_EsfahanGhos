using System;

namespace EsfahanGhos.Model
{
    public class CostOfService
    {
        public CostOfService()
        {
            Cost = 0;
            Description = "";
            Date = DateTime.Now;
        }
        public virtual int CostOfServiceID { get; set; }
        public virtual long Cost { get; set; }
        public virtual String Description { get; set; }
        public virtual DateTime Date { get; set; }
        public virtual int ProjectID { get; set; }
        public virtual Project Project { get; set; }
        public virtual int ContractorID { get; set; }
        public virtual Contractor Contractor { get; set; }
        public virtual Skill Skill { get; set; }
        public virtual int SkillID { get; set; }
        public virtual int? PurchaseListID { get; set; }
        public virtual PurchaseList PurchaseList { get; set; }

    }
}
