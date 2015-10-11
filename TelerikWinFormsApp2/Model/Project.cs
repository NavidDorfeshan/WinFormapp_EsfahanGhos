using System;
using System.Collections.Generic;

namespace EsfahanGhos.Model
{
    public class Project
    {
        public Project()
        {
            ProjectID = 0;
            ProjectName = "";
            ProjectStart = DateTime.Now;
            ProjectFinish = DateTime.Now;
            ProjectArea = "";
            ProjectAdress = "";
            ProjectDescribed = "";
        }
        public virtual int ProjectID { get; set; }
        public virtual string ProjectName { get; set; }
        public virtual long PriceProject { get; set; }
        public virtual DateTime ProjectStart { get; set; }
        public virtual DateTime ProjectFinish { get; set; }
        public virtual string ProjectArea { get; set; }
        /// <summary>
        /// کل هزینه پروژه(صفت مشتق)ء
        /// </summary>
        public long TotalCost { get; set; }
        /// <summary>
        /// کل درآمد پروژه(صفت مشتق)ء
        /// </summary>
        public long TotalInCome { get; set; }
        public virtual string ProjectAdress { get; set; }
        /// <summary>
        /// نام کارفرما پروژه
        /// </summary>
        /// 
        public virtual string Emp_Name { get; set; }
        public virtual string ProjectDescribed { get; set; }
        public virtual int? ProjectUnit { get; set; }
        public bool isActive { get; set; }
        /// <summary>
        /// Navigation Properties
        /// </summary>
        public virtual ICollection<Contractor> Contractors { get; set; }
        public virtual ICollection<PurchaseListItem> PurchaseListItems { get; set; }
        public virtual ICollection<Factor> Factors { get; set; }
        public virtual ICollection<CostOfService> CostOfService { get; set; }
        public virtual ICollection<Block> Blocks { get; set; }
        public virtual ICollection<Statement> Statements { get; set; }
        public virtual ICollection<Salary> Salaries { get; set; }
        public virtual ICollection<Person> Persons { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }


    }
}
