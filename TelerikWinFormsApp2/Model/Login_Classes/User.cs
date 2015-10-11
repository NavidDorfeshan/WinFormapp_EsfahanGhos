using System.Collections.Generic;

namespace EsfahanGhos.Model.Login_Classes
{
    public class User
    {
        public  int UserID { get; set; }
        public  string FName { get; set; }
        public  string UserName { get; set; }
        public  string Password { get; set; }
        public virtual ICollection<UnitSoftwar> UnitSoftwars { get; set; }
        public virtual ICollection<User_IO> Users_IO { get; set; }
    }
}
