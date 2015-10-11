using System;
using System.Collections.Generic;

namespace EsfahanGhos.Model
{
    public class Credit
    {
        public Credit()
        {
            DateCredit = DateTime.Now;
            Price = 0;
            Type = "";
        }
        public virtual int CreditID { get; set; }
        public virtual DateTime DateCredit { get; set; }
        public virtual long Price { get; set; }
        /// <summary>
        /// + or -
        /// </summary>
        public virtual string Type { get; set; }
        public virtual string NumberOfCheck { get; set; }
        public virtual string Description { get; set; }
        public virtual int TankhahID { get; set; }
        public virtual Tankhah Tankhah { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }

    }
}
