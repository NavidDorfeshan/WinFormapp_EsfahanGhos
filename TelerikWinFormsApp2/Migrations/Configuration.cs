using System;
using System.Data.Entity.Migrations;
using EsfahanGhos.DataLayer;
using EsfahanGhos.Form_Users.Hasher;
using EsfahanGhos.Model;
using EsfahanGhos.Model.Login_Classes;

namespace EsfahanGhos.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<Corporation>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;

        }

        private string hashed(string pass)
        {
            string HashedPassword = PasswordHasher.HashPassword(pass);
            return HashedPassword;
        }
        protected override void Seed(Corporation context)
        {
            context.Tankhahs.AddOrUpdate(
                p => p.TankhahName,
                new Tankhah { TankhahName = "همه", CreditCurrent = 0, TankhahID = 0 }
                );
            context.Credits.AddOrUpdate(
                p => p.CreditID,
                new Credit { Type = "-", TankhahID = 0, CreditID = 0, Price = 0, DateCredit = DateTime.Now }
                    );
            context.PurchaseLists.AddOrUpdate(
                p => p.PurchaseListID,
                new PurchaseList { PurchaseListID = 0, CreditID = 0, TankhahID = 0, TotalPrice = 0, Date = DateTime.Now, NumberOfList = 0 }
                );
            context.Units.AddOrUpdate(
                p => p.UnitName,
                new Unit { UnitName = "سانتی متر" },
                new Unit { UnitName = "میلیمتر" },
                new Unit { UnitName = "متر" },
                new Unit { UnitName = "متر مربع" },
                new Unit { UnitName = "متر مکعب" });
            context.Storages.AddOrUpdate(
                p=>p.Name,
                new Storage{Name = "انبار مادر"});
            context.Users.AddOrUpdate(
                p=>p.UserName,
                new User{FName ="Admin",UserName = "AdminNavid",Password = hashed("Navid659073")});
        }
    }
}
