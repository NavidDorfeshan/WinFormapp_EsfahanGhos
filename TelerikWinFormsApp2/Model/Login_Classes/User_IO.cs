using System;

namespace EsfahanGhos.Model.Login_Classes
{
    public class User_IO
    {
        public User_IO()
        {
            UserID = 0;
            EnterDate = DateTime.Now;
            ExitDate = DateTime.Now;
        }
        public virtual int User_IOID { get; set; }
        public virtual DateTime EnterDate { get; set; }
        public virtual DateTime? ExitDate { get; set; }
        public virtual int? UserID { get; set; }
        public virtual User User { get; set; }
    }
}
