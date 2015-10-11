using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using EsfahanGhos.DataLayer;
using EsfahanGhos.Form_Users;
using EsfahanGhos.Migrations;
using EsfahanGhos.Model;

namespace EsfahanGhos
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<Corporation, Configuration>());
//            try
//            {
//                Corporation db = new Corporation();
//                for (int i = 1; i <= 1500; i++)
//                {
//                    Person P = new Person()
//                    {
//                        EmployeeFullName = "دفیفای",
//                        FatherName = "محقغیغود",
//                        CellPhone = "09155341399",
//                        EmployeeBirth = DateTime.Now,
//                        EmployeeNationalCode = "545335",
//                        IdentityNumber = i++.ToString(),
//                        PhoneNumber = "251561"
//                    };
//                    db.Persons.Add(P);
//                }
//                db.SaveChanges();
//                List<Person> Lisp = db.Persons.ToList();
//                foreach (var item in Lisp)
//                {
//                    Project project = db.Projects.Include("Persons").First();
//                    if (project != null)
//                        project.Persons.Add(item);
//                }
//                db.SaveChanges();
//                db.Dispose();
//            }
//            catch (Exception)
//            {
//                MessageBox.Show(@"خطایی رخ داده است، لطفا چند لحظه دیگر دوباره تلاش کنید
//                 در صورت تکرار این خطا با پشتیبانی تماس حاصل فرمایید", "خطای سیستمی", MessageBoxButtons.OK, MessageBoxIcon.Error);
//            }
           
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form_MainMenu());
        }
    }
}