using System;

namespace EsfahanGhos.Model
{
    public class Salary
    {
        public Salary()
        {

        }
        public virtual int Id { get; set; }
        public virtual long Cost { get; set; }
        public virtual DateTime Date { get; set; }
        public virtual DateTime DateStart { get; set; }
        public virtual DateTime DateFinish { get; set; }

        public virtual string Description { get; set; }
        /// <summary>
        /// Navigation Properties
        /// </summary>
        public virtual Project Project { get; set; }
        public virtual int? ProjectId { get; set; }
        public virtual Person Person { get; set; }
        public virtual int PersonId { get; set; }
    }
}
