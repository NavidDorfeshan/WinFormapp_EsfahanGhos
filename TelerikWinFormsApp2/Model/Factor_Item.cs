using System;

namespace EsfahanGhos.Model
{
    public class Factor_Item
    {
        public Factor_Item()
        {
            Description = "";
            Qty = 0;
            SoldPrice = 0;
        }
        public virtual int Factor_ItemID { get; set; }
        public virtual String Description { get; set; }
        /// <summary>
        /// تعداد
        /// </summary>
        public virtual int Qty { get; set; }
        /// <summary>
        /// قیمت فروخته شده
        /// </summary>
        public virtual long SoldPrice { get; set; }
        /// <summary>
        /// qty*soldPrice
        /// </summary>
        public virtual long Tprice { get; set; }
        public virtual int FactorID { get; set; }
        public virtual Factor Factor { get; set; }
    }
}
