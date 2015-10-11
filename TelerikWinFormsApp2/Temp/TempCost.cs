namespace EsfahanGhos.Temp
{
    public class TempCost
    {
        public TempCost()
        {

        }
        public virtual long Cost { get; set; }
        public virtual string Date { get; set; }
        public virtual string ContractorName { get; set; }
        public virtual string ProjectName { get; set; }
    }
}
