using System.Collections.Generic;

namespace EsfahanGhos.Model
{
    public class Block
    {
        public Block()
        {
           // Statements=new HashSet<Statement>();
        }
        /// <summary>
        /// آی دی بلوک
        /// </summary>
        public virtual int BlockID { get; set; }
        public virtual bool IsExist { get; set; }
        /// <summary>
        /// اسم بلوک
        /// </summary>
        public virtual string BlockName { get; set; }
        /// <summary>
        /// تعداد واحد های بلوک
        /// </summary>
        public virtual string NumberOfUnits { get; set; }
        public virtual int? ProjectID { get; set; }
        public virtual Project Project { get; set; }
        public virtual ICollection<Statement> Statements { get; set; }
    }
}
