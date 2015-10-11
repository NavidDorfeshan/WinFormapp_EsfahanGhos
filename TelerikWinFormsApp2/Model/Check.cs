using System;
using System.Collections.Generic;

namespace EsfahanGhos.Model
{
   public class Check
    {
        public Check()
        {

        }
        public virtual int Id { get; set; }
        /// <summary>
        /// شماره چک
        /// </summary>
        public virtual int CheckNumber { get; set; }
        /// <summary>
        /// تاریخ وصول
        /// </summary>
        public virtual DateTime RecoverDate { get; set; }

        /// <summary>
        /// Navigation Properties
        /// </summary>
        public virtual ICollection<Payment> Payments { get; set; }
    }
}
 
