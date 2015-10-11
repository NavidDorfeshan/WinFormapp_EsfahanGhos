namespace EsfahanGhos.Model
{
    public class Percentage
    {
        public Percentage()
        {
            Precent = 0;
            name = "";
        }
        public virtual int PrecentageID { get; set; }
        public virtual double Precent { get; set; }
        public virtual string name { get; set; }
    }
}
