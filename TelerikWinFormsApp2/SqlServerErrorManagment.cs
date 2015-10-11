using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;

namespace EsfahanGhos
{
    public static class SqlServerErrorManagment
    {
        public static string ShowError(DbUpdateException ex, string EntityName)
        {
            SqlException eex = ex.InnerException.InnerException as SqlException;
            int ErrNumber = eex.Number;
            if (ErrNumber == 2627)
            {
                return " اطلاعات " + EntityName + " تکراری است ";
            }
            if (ErrNumber == 547)
            {
                return " به دلیل اینکه اطلاعات " + EntityName + " در قسمت های دیگر استفاده شده است، اطلاعات قابل تغییر نیست ";
            }
            if (ErrNumber == 2)
            {
                return "ارتباط با اسکیو ال سرور بر قرار نمی شود";
            }
            return "خطا از بانک اطلاعاتی";
        }
    }
}
