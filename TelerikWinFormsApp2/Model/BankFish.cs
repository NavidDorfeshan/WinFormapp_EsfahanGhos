using System.Collections.Generic;

namespace EsfahanGhos.Model
{
    public class BankFish
    {
        public BankFish()
        {

        }
        public virtual int Id { get; set; }
        /// <summary>
        /// شماره حساب به
        /// </summary>
        public virtual long AccountingNumber { get; set; }
        /// <summary>
        /// نام واریز کننده
        /// </summary>
        public virtual string Name_Start { get; set; }
        /// <summary>
        /// Navigation Properties
        /// </summary>
        public virtual ICollection<Payment> Payments { get; set; }

    }
}
