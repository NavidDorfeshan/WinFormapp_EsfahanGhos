using System;
using System.Collections.Generic;

namespace EsfahanGhos.Model
{
    public class Statement
    {
        public Statement()
        {
            StatementItems = new HashSet<StatementItem>();
        }
        public virtual int id { get; set; }
        public virtual DateTime Date { get; set; }
        public virtual int StatementNum { get; set; }
        public virtual string Description { get; set; }
        public virtual long StatementPrice { get; set; }
        /// <summary>
        /// Navigation Properties
        /// </summary>
        public int PaymentID { get; set; }
        public virtual Payment Payment { get; set; }
        public virtual int ProjectID { get; set; }
        public virtual Project Project { get; set; }
        public virtual int BlockID { get; set; }
        public virtual Block Block { get; set; }
        public virtual ICollection<StatementItem> StatementItems { get; set; }
    }
}
