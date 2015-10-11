using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using EsfahanGhos.DataLayer;
using EsfahanGhos.Form_Users;
using EsfahanGhos.Model;
using EsfahanGhos.Model.Login_Classes;

namespace EsfahanGhos
{
    public partial class Form_MainMenu : Telerik.WinControls.UI.RadForm
    {
        Rectangle resolution = Screen.PrimaryScreen.Bounds;
        Corporation db = new Corporation();
        List<Project> Listproject = new List<Project>();
        public Form_MainMenu()
        {
            InitializeComponent();
            //Employee.AllowDrag = false;
            //Project.AllowDrag = false;
            //Accounting.AllowDrag = false;
            //Store.AllowDrag = false;
            //PhoneBook.AllowDrag = false;
            //ManagmentSystem.AllowDrag = false;
            //Tankhah.AllowDrag = false;
            //Contractor.AllowDrag = false;
        }

        private void button_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Button_Close_Click(object sender, EventArgs e)
        {
            try
            {
                // ExitRegUserIO();
                Environment.Exit(0);
            }
            catch (Exception ez)
            {
                MessageBox.Show(ez.ToString(), "خطا در هنگام خروج  ");
            }
        }
        /// <summary>
        /// ثبت خروج کاربر از سیستم
        /// </summary>
        private void ExitRegUserIO()
        {
            try
            {
                User n = new User();
                User_IO IO = db.Users_IO.Single(p => p.User == n);
                IO.ExitDate = DateTime.Now;
                db.SaveChanges();
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show(SqlServerErrorManagment.ShowError(ex, "کاربر"), "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private void radLiveTileElement2_Click(object sender, EventArgs e)
        {
            Form_SelectProject S = new Form_SelectProject();
            S.Show();
        }

        private void radLiveTileElement1_Click(object sender, EventArgs e)
        {
            Form_People PF = new Form_People();
            PF.ShowDialog();
        }

        private void Form_MainMenu_Load(object sender, EventArgs e)
        {
            //try
            //{
            timer1.Start();
            ShowDate();
            Listproject = db.Projects.ToList();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.ToString());
            //}
        }
        private void ShowDate()
        {
            PersianCalendar p = new PersianCalendar();
            int year = p.GetYear(DateTime.Now);
            int month = p.GetMonth(DateTime.Now);
            int day = p.GetDayOfMonth(DateTime.Now);

            string str = "امروز ";
            DayOfWeek d = p.GetDayOfWeek(DateTime.Now);
            switch (d)
            {
                case DayOfWeek.Friday: { str += " جمعه "; break; }
                case DayOfWeek.Monday: { str += " دوشنبه "; break; }
                case DayOfWeek.Saturday: { str += " شنبه "; break; }
                case DayOfWeek.Sunday: { str += " یکشنبه "; break; }
                case DayOfWeek.Thursday: { str += " پنجشنبه "; break; }
                case DayOfWeek.Tuesday: { str += " سه شنبه "; break; }
                case DayOfWeek.Wednesday: { str += " چهارشنبه "; break; }
            }
            str += day + " ";
            string[] ListMonth = { "فروردین ماه", "اردیبهشت ماه", " خردادماه ", " تیرماه ", " مردادماه ", " شهریورماه ", " مهرماه ", " آبان ماه ", " آذرماه ", " دی ماه ", " بهمن ماه ", " اسفندماه " };
            str += ListMonth[month - 1];
            str += " سال " + year;
            DateLable.Text = str;
        }
        private void Button_Lock_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            // ExitRegUserIO();
            Form_Login L = new Form_Login();
            L.ShowDialog();
            this.Visible = true;
        }

        private void PhoneBook_Click(object sender, EventArgs e)
        {
        }

        private void Tankhah_Click(object sender, EventArgs e)
        {
            Form_Tankhah t = new Form_Tankhah();
            t.ShowDialog();
        }

        private void Contractor_Click(object sender, EventArgs e)
        {
            Form_RegContractor RC = new Form_RegContractor();
            RC.ShowDialog();
        }

        private void FactorManagment_Click(object sender, EventArgs e)
        {
            Form_Factor F = new Form_Factor();
            F.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Lbl_Clock.Text = DateTime.Now.Second + " : " + DateTime.Now.Minute + " : " + DateTime.Now.Hour;
        }

        private void Form_MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            // ExitRegUserIO();
        }

        private void Accounting_Click(object sender, EventArgs e)
        {
            Form_Accounting FA = new Form_Accounting();
            FA.ShowDialog();
        }

        private void Store_Click(object sender, EventArgs e)
        {
            Form_Storage fsFormStorage=new Form_Storage();
            fsFormStorage.ShowDialog();
        }
    }
}
