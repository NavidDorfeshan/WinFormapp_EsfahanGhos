namespace EsfahanGhos.Model
{
    public class StatementItem
    {
        public StatementItem()
        {

        }

        public virtual int Id { get; set; }

        /// <summary>
        /// تعداد
        /// </summary>
        public virtual int? Number { get; set; }

        /// <summary>
        /// طول
        /// </summary>
        public virtual double Length { get; set; }
        /// <summary>
        /// عرض
        /// </summary>
        public virtual double Width { get; set; }
        /// <summary>
        /// ارتفاع
        /// </summary>
        public virtual double Height { get; set; }
        /// <summary>
        /// مقدار جزیی
        /// </summary>
        public virtual double Trivial { get; set; }
        /// <summary>
        /// مقدر کلی
        /// </summary>
        public virtual double Total { get; set; }
        /// <summary>
        /// قیمت هر واحد
        /// </summary>
        public virtual long SoldPrice { get; set; }
        /// <summary>
        /// شرح فعالیت
        /// </summary>
        public virtual string Description { get; set; }
        /// <summary>
        /// Navigation Properties
        /// </summary>
        public virtual int StatementId { get; set; }
        public virtual Statement Statement { get; set; }
    }
}
