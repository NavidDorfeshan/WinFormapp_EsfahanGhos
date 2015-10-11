using System;
using System.Data.Entity.Infrastructure;
using System.Windows.Forms;
using EsfahanGhos.DataLayer;
using EsfahanGhos.Model;

namespace EsfahanGhos
{

    public partial class Form_RegisterProject : Telerik.WinControls.UI.RadForm
    {
        Corporation db = new Corporation();
        string virgol = "";
        long vir = 0;
        public Form_RegisterProject()
        {
            InitializeComponent();
        }
        /// <summary>
        /// برای اینکه عدد نتواند وارد کند
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AlphaTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar <= '9' && e.KeyChar >= '0')
            {
                e.Handled = true;
            }
        }
        /// <summary>
        /// برای اینکه حروف نتواند وارد کند 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
                && !char.IsDigit(e.KeyChar)
                && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
        /// <summary>
        /// این تابع برای مساحت ویرگول میگذارد
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Txt_Area_TextChanged(object sender, EventArgs e)
        {
            if (Txt_PArea.Text.Trim() != "")
            {
                if (Txt_PArea.Text != virgol)
                {
                    vir = utility.ConvertCommaPrice(Txt_PArea.Text.Trim());
                    if (vir != -1)
                    {
                        virgol = utility.ConvertPrice(vir);
                        Txt_PArea.Text = virgol;
                    }
                    Txt_PArea.Select(Txt_PArea.Text.Length, 0);
                }
            }
        }
        /// <summary>
        /// این تابع برای مبلغ قرارداد ویرگول میگذارد
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Txt_PriceProject_TextChanged(object sender, EventArgs e)
        {
        }
        /// <summary>
        /// بستن فرم
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Close_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// کلیک بر روی دکمه ی لیست پروژه ها
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_ListProject_Click(object sender, EventArgs e)
        {
            Form_ListOfProject ListP = new Form_ListOfProject();
            ListP.ShowDialog();
        }
        /// <summary>
        /// تولید شماره پروژه
        /// </summary>
        private void BuildProjectID()
        {
            String str = Guid.NewGuid().ToString("N"), strID = "";
            int i = 0;
            while (strID.Length < 4)
            {
                if (str[i] >= '0' && str[i] < '9')
                    strID += str[i];
                i++;
                if (i == str.Length)
                {
                    str = Guid.NewGuid().ToString("N");
                    i = 0;
                }
            }
            Txt_ProjectID.Text = strID;
        }
        private void Form_RegisterPoroject_Load(object sender, EventArgs e)
        {
            BuildProjectID();
            Calendar1.GeoDate = DateTime.Now;
            //Project P = new Project();
            //Txt_PArea.DataBindings.Add("Text", P, "ProjectArea");
        }
        /// <summary>
        /// پاک کردن تکس باس ها برای ثبت بعدی 
        /// </summary>

        private void clearText()
        {
            Txt_ProjectID.Text = Txt_PName.Text = Txt_PDesc.Text = Txt_PArea.Text = Txt_Em.Text = "";
        }

        private void Button_Reg_Click(object sender, EventArgs e)
        {
            if (Txt_ProjectID.Text.Trim() == "" || Txt_PName.Text.Trim() == "" || Txt_Em.Text == "")
            {
                MessageBox.Show("لطفا همه ی موارد را پر کنید ", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Register();
            BuildProjectID();
            clearText();
            utility.Show_Message("اطلاعات پروژه با موفقیت ثبت شد", "پیام ");

        }

        private void Register()
        {
            try
            {
                Project P = new Project()
                {
                    ProjectID = Convert.ToInt32(Txt_ProjectID.Text.Trim()),
                    ProjectName = Txt_PName.Text.Trim(),
                    ProjectStart = Calendar1.GeoDate.Value,
                    ProjectArea = Txt_PArea.Text.Trim(),
                    ProjectDescribed = Txt_PDesc.Text.Trim(),
                    Emp_Name = Txt_Em.Text.Trim(),
                    isActive = true,
                    TotalCost = 0,
                    TotalInCome = 0
                };
                db.Projects.Add(P);
                db.SaveChanges();
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show(SqlServerErrorManagment.ShowError(ex, "پروژه"));
            }
        }
    }
}
