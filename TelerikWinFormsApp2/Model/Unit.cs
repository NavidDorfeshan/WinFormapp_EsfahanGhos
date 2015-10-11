using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EsfahanGhos.Model
{
    public class Unit
    {
        [Key]
        public int Id { get; set; }
        public string UnitName { get; set; }
        /// <summary>
        /// Navigation Properties
        /// </summary>
        public virtual ICollection<StorageItem> StorageItems { get; set; }
    }
}
