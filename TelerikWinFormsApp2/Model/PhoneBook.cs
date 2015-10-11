namespace EsfahanGhos.Model
{
    public class PhoneBook
    {
        public PhoneBook()
        {
            PID = 0;
            PNumber = "";
        }
        public virtual int PID { get; set; }
        public virtual string PNumber { get; set; }
        public virtual int? ContractorID { get; set; }
        public virtual int? TankhahID { get; set; }

        public virtual Contractor Contractor { get; set; }
        public virtual Tankhah Tankhah { get; set; }
    }
}
