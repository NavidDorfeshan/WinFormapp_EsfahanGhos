using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using EsfahanGhos.DataLayer;
using EsfahanGhos.Model.Login_Classes;

namespace EsfahanGhos.Form_Users
{
    public partial class Form_UserIO : Telerik.WinControls.UI.RadForm
    {
        private List<User_IO> ListIO = null;
        Corporation db = new Corporation();
        User U;
        public Form_UserIO(User user)
        {
            U = user;
            InitializeComponent();
        }

        private void Form_UserIO_Load(object sender, EventArgs e)
        {
            BGW.RunWorkerAsync();
        }

        private void BGW_DoWork(object sender, DoWorkEventArgs e)
        {
            GetData();
        }

        private void GetData()
        {
            try
            {
                ListIO = db.Users_IO.Include("User").Where(p => p.UserID == U.UserID).ToList();

            }
            catch (Exception e)
            {
                MessageBox.Show(@"خطایی رخ داده است، لطفا چند لحظه دیگر دوباره تلاش کنید
                 در صورت تکرار این خطا با پشتیبانی تماس حاصل فرمایید", "خطای سیستمی", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BGW_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ShowData();
            Delte_IO_1month();
        }

        private void ShowData()
        {
            try
            {
                GridIO.Rows.Clear();
                if (ListIO.Count != 0)
                {
                    GridIO.Rows.Clear();
                    GridIO.AutoGenerateColumns = false;
                    int i = 0;
                    foreach (var item in ListIO)
                    {
                        string D1 = item.EnterDate.Hour + " : " + item.EnterDate.Minute;
                        string D2 = "";
                        if (item.ExitDate != null)
                        {
                            D2 = item.ExitDate.Value.Hour + " : " + item.ExitDate.Value.Minute;
                        }
                        else
                        {
                            D2 = "به دلایل فنی مشخص نمی باشد";
                        }
                        GridIO.Rows.Add(GridIO.Rows.Count + 1, item.User.FName, utility.ConvertDate_M_To_Sh(item.EnterDate), D1, D2);
                        i++;
                    }
                    GridIO.CurrentRow.Selected = false;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(@"خطایی رخ داده است، لطفا چند لحظه دیگر دوباره تلاش کنید
                 در صورت تکرار این خطا با پشتیبانی تماس حاصل فرمایید", "خطای سیستمی", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Delte_IO_1month()
        {
            try
            {
                var list = ListIO.OrderBy(p => p.EnterDate);
                var IO = list.Last();
                foreach (User_IO item in list)
                {
                    if (item.EnterDate.Year == IO.EnterDate.Year)
                    {
                        if (IO.EnterDate.Month - item.EnterDate.Month >= 1)
                        {
                            db.Users_IO.Remove(item);
                        }
                    }
                }
                db.SaveChanges();
            }
            catch (Exception)
            {
                MessageBox.Show(@"خطایی رخ داده است، لطفا چند لحظه دیگر دوباره تلاش کنید
                 در صورت تکرار این خطا با پشتیبانی تماس حاصل فرمایید", "خطای سیستمی", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
