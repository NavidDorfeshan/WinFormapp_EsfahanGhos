using System.Collections.Generic;

namespace EsfahanGhos.Model
{
    public class CardToCard
    {
        public CardToCard()
        {

        }
        public virtual int Id { get; set; }
        /// <summary>
        /// شماره کارت مبدا
        /// </summary>
        public virtual string Card_Start { get; set; }
        /// <summary>
        /// شماره کارت مقصد
        /// </summary>
        public virtual string Card_Finish { get; set; }
        /// <summary>
        /// نام صاحب کارت مقصد
        /// </summary>
        public virtual string Name { get; set; }
        /// <summary>
        /// کد پیگیری
        /// </summary>
        public virtual int Code_Peygiri { get; set; }
        /// <summary>
        /// Navigation Properties
        /// </summary>
        public virtual ICollection<Payment> Payments { get; set; }
    }
}
