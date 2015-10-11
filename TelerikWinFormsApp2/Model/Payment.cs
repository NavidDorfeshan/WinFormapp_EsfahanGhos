using System;
using System.Collections.Generic;

namespace EsfahanGhos.Model
{
    public class Payment
    {
        public Payment()
        {
            // Statements = new HashSet<Statement>();
        }
        public virtual int Id { get; set; }

        /// <summary>
        /// بابت
        /// </summary>
        public virtual string Reason { get; set; }
        /// <summary>
        /// در وجه
        /// </summary>
        public virtual string Name { get; set; }
        /// <summary>
        /// توضیحات
        /// </summary>
        public virtual string Description { get; set; }
        /// <summary>
        /// به مبلغ
        /// </summary>
        public virtual long Cost { get; set; }
        /// <summary>
        /// در تاریخ
        /// </summary>
        public virtual DateTime Date { get; set; }
        /// <summary>
        /// Navigation Properties
        /// </summary>
        public virtual int? CheckId { get; set; }
        public virtual Check Check { get; set; }
        public virtual int? FishId { get; set; }
        public virtual BankFish BankFish { get; set; }
        public virtual int? CardId { get; set; }
        public virtual CardToCard CardToCard { get; set; }
        public virtual Credit Credit { get; set; }
        public virtual int? CreditID { get; set; }
        public virtual Factor Factor { get; set; }
        public virtual int? FactorID { get; set; }
        public virtual PurchaseList PurchaseList { get; set; }
        public virtual int? PurchaseListID { get; set; }
        public virtual Project Project { get; set; }
        public virtual int? ProjectID { get; set; }
        public virtual ICollection<Statement> Statements { get; set; }
        public virtual Person Person { get; set; }
        public virtual int? PersonId { get; set; }
    }
}
