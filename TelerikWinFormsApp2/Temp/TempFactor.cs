using System;

namespace EsfahanGhos.Temp
{
    public class TempFactor
    {
        public TempFactor()
        {

        }
        public virtual string Date { get; set; }
        public virtual long TotalPrice { get; set; }
        public virtual String FactorNumber { get; set; }
        public virtual string Description { get; set; }
        public virtual string ProjectName { get; set; }

    }
}
