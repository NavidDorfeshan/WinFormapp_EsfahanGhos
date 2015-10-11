using System.Data.Entity;
using EsfahanGhos.DataLayer.Configuration;
using EsfahanGhos.Model;
using EsfahanGhos.Model.Login_Classes;

namespace EsfahanGhos.DataLayer
{
    public class Corporation : DbContext
    {
        public Corporation()
            : base("Data Source=.; Initial Catalog=Corporation;Integrated Security=true;")
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = true;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ConfigStorageItem());
            modelBuilder.Configurations.Add(new ConfigurProject());
            modelBuilder.Configurations.Add(new ConfigPerson());
            modelBuilder.Configurations.Add(new ConfigurUnit());
            modelBuilder.Configurations.Add(new ConfigSkill());
            modelBuilder.Configurations.Add(new ConfigPhoneBook());
            modelBuilder.Configurations.Add(new ConfigContractor());
            modelBuilder.Configurations.Add(new ConfigTankhah());
            modelBuilder.Configurations.Add(new ConfigCredit());
            modelBuilder.Configurations.Add(new ConfigPurcheseList());
            modelBuilder.Configurations.Add(new ConfigPurchaseListItem());
            modelBuilder.Configurations.Add(new ConfigFactor());
            modelBuilder.Configurations.Add(new ConfigFactor_Item());
            modelBuilder.Configurations.Add(new ConfigCostOfService());
            modelBuilder.Configurations.Add(new ConfigPercentage());
            modelBuilder.Configurations.Add(new ConfigBlock());
            modelBuilder.Configurations.Add(new ConfigStatement());
            modelBuilder.Configurations.Add(new ConfigStatementItem());
            modelBuilder.Configurations.Add(new ConfigPayment());
            modelBuilder.Configurations.Add(new ConfigFish());
            modelBuilder.Configurations.Add(new ConfigCheck());
            modelBuilder.Configurations.Add(new ConfigCard());
            modelBuilder.Configurations.Add(new ConfigSalary());
        }
        public DbSet<StorageItem> StorageItems { get; set; }
        public DbSet<Storage> Storages { get; set; }
        public DbSet<Type_Storage> TypeStorages { get; set; }
        public DbSet<Salary> Salaries { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<BankFish> Fishes { get; set; }
        public DbSet<Check> Checks { get; set; }
        public DbSet<CardToCard> Cards { get; set; }
        public DbSet<Statement> Statements { get; set; }
        public DbSet<StatementItem> StatementItems { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Block> Blocks { get; set; }
        public DbSet<Tankhah> Tankhahs { get; set; }
        public DbSet<Contractor> Contractors { get; set; }
        public DbSet<Factor> Factors { get; set; }
        public DbSet<Factor_Item> Factor_Items { get; set; }
        public DbSet<CostOfService> CostOfServices { get; set; }
        public DbSet<PurchaseListItem> PurchaseListItems { get; set; }
        public DbSet<PurchaseList> PurchaseLists { get; set; }
        public DbSet<Credit> Credits { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<PhoneBook> PhoneBooks { get; set; }
        public DbSet<Unit> Units { get; set; }
        public DbSet<Percentage> Percentages { get; set; }//ساخت جدول درصد
        public DbSet<UnitSoftwar> UnitSoftwars { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<User_IO> Users_IO { get; set; }
    }
}