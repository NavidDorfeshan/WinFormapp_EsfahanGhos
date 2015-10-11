using System;
using System.Data.Entity;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;
using EsfahanGhos.DataLayer;
using Telerik.WinControls.UI;

namespace EsfahanGhos
{
    static class utility
    {
        /// <summary>
        ///این تابع پایگاه داده را درست میکند
        /// </summary>
        /// <returns></returns>
        public static bool CreatDataBase()
        {
            try
            {
                if (!Database.Exists("Data Source = .;Initial Catalog = Corporation;Integrated Security=true;"))
                {
                    using (Corporation db = new Corporation())
                    {
                        db.Database.Create();
                        //Database.SetInitializer<Atelie1>(new AtelieInitializer(db));

                    }
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        /// <summary>
        /// این تابع تاریخ شمسی را به میلادی تبدیل میکند 
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static string ConvertDate_M_To_Sh(DateTime date)
        {
            PersianCalendar D = new PersianCalendar();
            string date_P = D.GetYear(date) + "/" + (D.GetMonth(date) >= 10 ? "" : "0") + D.GetMonth(date) + "/" + (D.GetDayOfMonth(date) >= 10 ? "" : "0") + D.GetDayOfMonth(date);
            return date_P;
        }
        /// <summary>
        /// ساعت را نشان میدهد 
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static string Show_Time(DateTime date)
        {
            PersianCalendar p = new PersianCalendar();
            string T = p.GetSecond(date) + " : " + p.GetMinute(date) + " : " + p.GetHour(date);
            return T;
        }
        /// <summary>
        /// این تابع زبان کیبورد را فارسی میکند(fa-ir)
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static InputLanguage ChangeLanguegeToPersian()
        {
            System.Globalization.CultureInfo language = new System.Globalization.CultureInfo("fa-ir");
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(language);
            return InputLanguage.CurrentInputLanguage;
        }
        /// <summary>
        /// این تابع زبان ویندوز را انگلیسی میکند (en-us)
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static InputLanguage ChangeLanguegeToEng()
        {
            System.Globalization.CultureInfo language = new System.Globalization.CultureInfo("en-us");
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(language);
            return InputLanguage.CurrentInputLanguage;
        }
        /// <summary>
        /// اين تابع بين قيمت ها ويرگول مي گذارد 
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string ConvertPrice(String str)
        {
            int j = str.Length - 1;
            String st = "";
            for (int i = 0; i < str.Length; i++)
            {
                st += str[j];
                if ((i + 1) % 3 == 0 && j != 0)
                    st += ',';
                j--;
            }
            char[] a = st.ToCharArray().Reverse().ToArray();
            return new String(a);
        }
        /// <summary>
        /// اين تابع بين قيمت ها ويرگول مي گذارد 
        /// </summary>
        /// <param name="Num"></param>
        /// <returns></returns>
        public static string ConvertPrice(long Num)
        {
            String str = Num.ToString();
            String st = "";
            int j = str.Length - 1;
            for (int i = 0; i < str.Length; i++)
            {
                st += str[j];
                if ((i + 1) % 3 == 0 && j != 0)
                    st += ',';
                j--;
            }
            char[] a = st.ToCharArray().Reverse().ToArray();
            return new String(a);
        }
        /// <summary>
        /// اين تابع مقدار عدد رشته اي را که ويرگول دارد را به عدد صحيح تبديل ميکند
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static long ConvertCommaPrice(String str)
        {
            try
            {
                String st = "";
                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i] >= '0' && str[i] <= '9')
                        st += str[i];
                }
                return Convert.ToInt64(st);
            }
            catch (FormatException)
            {
                return -1;
            }
        }
        /// <summary>
        /// نمایش پیام
        /// </summary>
        /// <param name="TextMessage"></param>
        /// <param name="TextTitle"></param>
        public static void Show_Message(string TextMessage, string TextTitle)
        {
            RadDesktopAlert Alert = new RadDesktopAlert();
            Alert.AutoCloseDelay = 5;
            Alert.Opacity = 1F;
            Alert.CaptionText = TextTitle;
            Alert.ContentText = TextMessage;
            Alert.FadeAnimationFrames = 5;
            Alert.FadeAnimationSpeed = 50;
            Alert.PopupAnimationDirection = RadDirection.Right;
            Alert.ThemeName = "Aqua";
            Alert.Show();
        }
        public static int CreatedNewID()
        {
            try
            {
                return Convert.ToInt32(DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString() + DateTime.Now.Millisecond.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("خطا در ساخت آی دی", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                return -1;
            }

        }
        private static IQueryable<T> PagedResult<T, TResult>(IQueryable<T> query, int pageNum, int pageSize,
                Expression<Func<T, TResult>> orderByProperty, bool isAscendingOrder, out int rowsCount)
        {
            if (pageSize <= 0) pageSize = 20;

            //مجموع ردیف‌های به دست آمده
            rowsCount = query.Count();

            // اگر شماره صفحه کوچکتر از 0 بود صفحه اول نشان داده شود
            if (rowsCount <= pageSize || pageNum <= 0) pageNum = 1;

            // محاسبه ردیف هایی که نسبت به سایز صفحه باید از آنها گذشت
            int excludedRows = (pageNum - 1) * pageSize;

            query = isAscendingOrder ? query.OrderBy(orderByProperty) : query.OrderByDescending(orderByProperty);

            // ردشدن از ردیف‌های اضافی و  دریافت ردیف‌های مورد نظر برای صفحه مربوطه
            return query.Skip(excludedRows).Take(pageSize);
        }
    }
}

