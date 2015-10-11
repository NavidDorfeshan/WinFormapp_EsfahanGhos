using System.Collections.Generic;

namespace EsfahanGhos.Model
{
    public class Tankhah
    {
        public Tankhah()
        {
            TankhahID = 0;
            TankhahName = "";
            CreditCurrent = 0;
        }
        public virtual int TankhahID { get; set; }
        public virtual string TankhahName { get; set; }
        public virtual long CreditCurrent { get; set; }
        public virtual ICollection<PhoneBook> PhoneBooks { get; set; }
        public virtual ICollection<PurchaseList> PurchaseLists { get; set; }
        public virtual ICollection<Credit> Credits { get; set; }
    }
}
