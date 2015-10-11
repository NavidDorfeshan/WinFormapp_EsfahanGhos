using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Windows.Forms;
using EsfahanGhos.DataLayer;
using EsfahanGhos.Model;

namespace EsfahanGhos
{
    public partial class Form_FactorList : Telerik.WinControls.UI.RadForm
    {
        Corporation db = new Corporation();
        List<Factor> _Factor = null;
        List<Project> ListProject = null;
        List<Factor_Item> ListFactorItem = null;
        int Row = -1;
        public Form_FactorList()
        {
            InitializeComponent();
        }

        private void GridFactorList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                Row = e.RowIndex;
                Btn_Print.Enabled = true;
                if (e.ColumnIndex == 7)
                {

                    DeletFactor(Convert.ToInt32(GridFactorList.Rows[e.RowIndex].Cells[8].Value));
                    GridFactorList.Rows.Clear();
                    GetFactors();
                    FillGridFactor();
                }
                if (e.ColumnIndex == 6)
                {
                    ViewFactor(e);
                    //GridFactorList.Rows.Clear();
                    //GetFactors();
                    //FillGridFactor();
                }
            }
            catch (Exception)
            {
            }
        }

        private void GridFactorList_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            //try
            //{
            if (e.ColumnIndex == 7 && e.RowIndex != -1)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                // Icon icon = new Icon(Properties.Resources.compstui_64003.ToString(), new Size(32, 32));
                e.Graphics.DrawImage(Properties.Resources.del, e.CellBounds.Left + 10, e.CellBounds.Top);
                e.Handled = true;
            }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }
        /// <summary>
        /// گرفتن پروژه ها از دیتابیس
        /// </summary>
        private void GetProject()
        {
            try
            {
                ListProject = db.Projects.ToList<Project>();
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show(SqlServerErrorManagment.ShowError(ex, "پروژه"), "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private void FillCombo()
        {
            ComboProject.ValueMember = "ProjectID";
            ComboProject.DisplayMember = "ProjectName";
            ComboProject.DataSource = ListProject;
            ComboProject.SelectedIndex = -1;
        }
        /// <summary>
        /// خواندن Factor از دیتا بیس
        /// </summary>
        private void GetFactors()
        {
            try
            {
                _Factor = (from V in db.Factors.Include("Project")
                           where V.PurchaseListID == null
                           select V).OrderByDescending(p => p.Date).ToList<Factor>();
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show(SqlServerErrorManagment.ShowError(ex, "فاکتور"), "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        /// <summary>
        /// پر کردن GridView
        /// </summary>
        private void FillGridFactor()
        {
            try
            {
                GridFactorList.Rows.Clear();
                int i = 0;
                //if (_Factor.Count == 0)
                //{
                //    return;
                //}
                //else
                //{
                foreach (var Item in _Factor)
                {
                    GridFactorList.Rows.Add(GridFactorList.Rows.Count + 1, Item.FactorNumber, Item.Description, utility.ConvertDate_M_To_Sh(Item.Date), utility.ConvertPrice(Item.TotalPrice), Item.Project.ProjectName, null, null, Item.FactorID);
                    GridFactorList.Rows[i].Cells[3].ToolTipText = Item.Description;
                    i++;
                }
                GridFactorList.CurrentRow.Selected = false;
                //}
            }
            catch (Exception)
            {
            }
        }
        /// <summary>
        /// مشاهده فاکتور انتخابی
        /// </summary>
        /// <param name="e"></param>
        private void ViewFactor(DataGridViewCellMouseEventArgs e)
        {
            try
            {
                Form_RegFactorListItem F = new Form_RegFactorListItem(Convert.ToInt32(GridFactorList.Rows[e.RowIndex].Cells["FactorID"].Value));
                F.ShowDialog();
                GridFactorList.Rows.Clear();
                GetFactors();
                GetProject();
                FillGridFactor();
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show(SqlServerErrorManagment.ShowError(ex, "فاکتور"), "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            }
        }
        /// <summary>
        /// حذف فاکتور
        /// </summary>
        /// <param name="ID"></param>
        private void DeletFactor(int ID)
        {
            try
            {
                //List<Check> checklist = db.Checks.Where(p => p.FactorID == ID).ToList<Check>();
                bool flag = true;
                //foreach (var Item in checklist)
                //{
                //    if (Item.isPassed == true)
                //    {
                //        flag = false;
                //        Utility.ShowNotification("پیغام عملیات", "به علت داشتن چک پاس شده این هزینه قابل حذف نیست", Utility.Icons.Information, 3000);
                //        return;
                //    }
                //    if (Item.isWasted == true)
                //    {
                //        flag = false;
                //        Utility.ShowNotification("پیغام عملیات", "به علت داشتن چک باطل شده این هزینه قابل حذف نیست", Utility.Icons.Information, 3000);
                //        return;
                //    }
                //    if (Item.isBack == true)
                //    {
                //        flag = false;
                //        Utility.ShowNotification("پیغام عملیات", "به علت داشتن چک برگشتی شده این هزینه قابل حذف نیست", Utility.Icons.Information, 3000);
                //        return;
                //    }
                //}
                if (flag == false)
                    return;
                if (MessageBox.Show("آیا فاکتور حذف شود؟", "سوال", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) == DialogResult.No) return;
                //SpecialUtility.DeleteChecks(checklist);
                //List<Images> imagelist = db.Images.Where(p => p.FactorID == ID).ToList<Images>();
                //SpecialUtility.DeleteImages(imagelist);
                Factor Fact = (from V in db.Factors
                               where V.FactorID == ID
                               select V).FirstOrDefault();
                db.Factors.Remove(Fact);
                db.SaveChanges();
                Row = -1;
                Btn_Print.Enabled = false;
                utility.Show_Message("عملیات حذف فاکتور با موفقیت انجام شد", "پیغام عملیات");
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show(SqlServerErrorManagment.ShowError(ex, "فاکتور"), "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            }
        }

        private void BGW_DoWork(object sender, DoWorkEventArgs e)
        {
            GetFactors();
            GetProject();
        }

        private void GetFactor_Item()
        {
            try
            {
                ListFactorItem = db.Factor_Items.Include("Factor").ToList<Factor_Item>();
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show(SqlServerErrorManagment.ShowError(ex, "پروژه"), "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private void BGW_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            pictureBox1.Visible = false;
            FillGridFactor();
            FillCombo();
        }

        private void Form_FactorList_Load(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            BGW.RunWorkerAsync();
            GridFactorList.AutoGenerateColumns = false;
        }
        /// <summary>
        /// ثبت فاکتور جدید
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Register_Click(object sender, EventArgs e)
        {
            try
            {
                Form_RegFactorListItem F = new Form_RegFactorListItem();
                F.ShowDialog();
                GridFactorList.Rows.Clear();
                BGW.RunWorkerAsync();
            }
            catch (Exception)
            {
            }
        }
        /// <summary>
        /// جستجو
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Search_Click(object sender, EventArgs e)
        {
            try
            {
                GetFactors();
                pictureBox1.Visible = true;
                timer1.Enabled = true;

            }
            catch (Exception v)
            {
                MessageBox.Show(v.Message);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                if (ComboProject.SelectedIndex != -1)
                {
                    int ProjectID = Convert.ToInt32(ComboProject.SelectedValue);
                    _Factor = _Factor.Where(p => p.ProjectID == ProjectID).ToList();
                    pictureBox1.Visible = false;
                    timer1.Enabled = false;
                    FillGridFactor();
                    GetProject();
                    FillCombo();
                }
                else
                {
                    pictureBox1.Visible = false;
                    timer1.Enabled = false;
                    FillGridFactor();
                    FillCombo();
                }
            }
            catch (Exception v)
            {
                MessageBox.Show(v.Message);
            }
        }
        /// <summary>
        /// چاپ فاکتور انتخاب شده 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Print_Click(object sender, EventArgs e)
        {
            try
            {
                #region Stimulsoft
                if (Row != -1)
                {
                    GetFactor_Item();
                    int ID = Convert.ToInt32(GridFactorList.Rows[Row].Cells[8].Value);
                    Print_Factors.Dictionary.Variables[0].Value = utility.ConvertDate_M_To_Sh(DateTime.Now);
                    Print_Factors.Dictionary.Variables[1].Value = GridFactorList.Rows[Row].Cells["Project"].Value.ToString();
                    Print_Factors.Dictionary.Variables[2].Value = GridFactorList.Rows[Row].Cells["Date"].Value.ToString();
                    Print_Factors.Dictionary.Variables[3].Value = GridFactorList.Rows[Row].Cells["TotalCost"].Value.ToString();
                    Print_Factors.Dictionary.Variables[4].Value = GridFactorList.Rows[Row].Cells["FactorNumber"].Value.ToString();
                    ListFactorItem = ListFactorItem.Where(p => p.FactorID == ID).ToList();
                    Print_Factors.RegBusinessObject("FactorList", ListFactorItem);
                    Print_Factors.Render(true);
                    Print_Factors.Show();
                    Btn_Print.Enabled = false;
                #endregion
                    Row = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
