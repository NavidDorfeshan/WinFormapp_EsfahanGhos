using System;
using System.Collections.Generic;

namespace EsfahanGhos.Model
{
    public class Person
    {
        public Person()
        {
        }
        public int EmployeeID { get; set; }
        /// <summary>
        /// نام و نام خانوادگی 
        /// </summary>
        public string EmployeeFullName { get; set; }
        /// <summary>
        /// نام پدر
        /// </summary>
        public string FatherName { get; set; }
        /// <summary>
        /// ازدواج کرده ؟
        /// </summary>
        public bool EmployeeMaried { get; set; }
        /// <summary>
        /// کد ملی
        /// </summary>
        public string EmployeeNationalCode { get; set; }
        /// <summary>
        /// شماره شناسنامه
        /// </summary>
        public string IdentityNumber { get; set; }
        /// <summary>
        /// شماره موبایل
        /// </summary>
        public string CellPhone { get; set; }
        /// <summary>
        /// شماره منزل
        /// </summary>
        public string PhoneNumber { get; set; }
        /// <summary>
        ///تاریخ تولد
        /// </summary>
        public DateTime EmployeeBirth { get; set; }
        /// <summary>
        /// تعداد فرزندان
        /// </summary>
        public string NumberOfChildren { get; set; }
        /// <summary>
        /// آدرس
        /// </summary>
        public string Adress { get; set; }
        /// <summary>
        /// Navigation Properties
        /// </summary>
        public virtual ICollection<Salary> Salaries { get; set; }
        public virtual ICollection<Project> Projects { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
    }
}
