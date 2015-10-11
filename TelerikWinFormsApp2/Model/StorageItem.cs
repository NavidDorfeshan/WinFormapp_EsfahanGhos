namespace EsfahanGhos.Model
{
    public class StorageItem
    {
        public int Id { get; set; }
        public int Code { get; set; }
        public string Description { get; set; }
        /// <summary>
        /// تعداد
        /// </summary>
        public int Count { get; set; }
        /// <summary>
        /// مقدار کل
        /// </summary>
        public int? TotalCount { get; set; }
        /// <summary>
        /// Navigation Properties
        /// </summary>
        public virtual Storage Storage { get; set; }
        public virtual int StorageId { get; set; }
        public virtual Unit Unit { get; set; }
        public virtual int? UnitId { get; set; }
        public virtual Type_Storage TypeStorage { get; set; }
        public virtual int? TypeStorageId { get; set; }
    }
}
