using System.Collections.Generic;

namespace EsfahanGhos.Model
{
    public class Storage
    {
        public int Id { get; set; }
        public string Name { get; set; }
        /// <summary>
        /// Navigation Properties
        /// </summary>
        public virtual ICollection<StorageItem> StorageItems { get; set; }
    }
}
