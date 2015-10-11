namespace EsfahanGhos.Model.Login_Classes
{
    public class UnitSoftwar
    {
        public  int UnitSoftwarID { get; set; }
        public  string UnitName { get; set; }
        public  bool UnitAccess { get; set; }

        public virtual int UserID { get; set; }
        public virtual User User { get; set; }
    }
}
