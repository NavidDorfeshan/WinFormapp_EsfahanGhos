using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EsfahanGhos.Model
{
    public class Factor
    {
        public Factor()
        {
            FactorNumber = "";
            Date = DateTime.Now;
            TotalPrice = 0;
            VAXPrice = 0;
            VAX = 0;
            Description = "";
        }
        public virtual int FactorID { get; set; }
        public virtual String FactorNumber { get; set; }
        public virtual DateTime Date { get; set; }
        public virtual long TotalPrice { get; set; }
        public virtual long VAXPrice { get; set; }
        public virtual double VAX { get; set; }
        public virtual string Description { get; set; }
        public virtual int? ProjectID { get; set; }
        public virtual Project Project { get; set; }
        public virtual ICollection<Factor_Item> Factor_Items { get; set; }
        public virtual PurchaseList PurchaseList { get; set; }
        [Association("IsForeignKey", "PurchaseListID", "PurchaseListID")]
        public virtual int? PurchaseListID { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
    }
}