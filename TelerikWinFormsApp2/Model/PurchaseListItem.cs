using System;

namespace EsfahanGhos.Model
{
    public class PurchaseListItem
    {
        public PurchaseListItem()
        {
            Date = DateTime.Now;
            Price = 0;
            Description = "";
        }
        public virtual int PurchaseListItemID { get; set; }
        public virtual DateTime Date { get; set; }
        public virtual long Price { get; set; }
        public virtual string Description { get; set; }
        public virtual int PurchaseListID { get; set; }
        public virtual PurchaseList PurchaseList { get; set; }
        public virtual int? ProjectID { get; set; }
        public virtual Project Project { get; set; }

    }
}
