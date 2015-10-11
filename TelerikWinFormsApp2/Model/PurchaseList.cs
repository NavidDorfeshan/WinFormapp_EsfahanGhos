using System;
using System.Collections.Generic;

namespace EsfahanGhos.Model
{
    public class PurchaseList
    {
        public PurchaseList()
        {
            Date = DateTime.Now;
            NumberOfList = 0;
            TotalPrice = 0;
        }

        public virtual int PurchaseListID { get; set; }
        public virtual int NumberOfList { get; set; }
        public virtual long TotalPrice { get; set; }
        public virtual DateTime Date { get; set; }
        public virtual int TankhahID { get; set; }
        public virtual Tankhah Tankhah { get; set; }
        public virtual int? CreditID { get; set; }
        public virtual Credit Credit { get; set; }
        public virtual ICollection<PurchaseListItem> PurchaseListItems { get; set; }
        public virtual ICollection<Factor> Factors { get; set; }
        public virtual ICollection<CostOfService> CostOfServices { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
    }
}
