using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using EsfahanGhos.DataLayer;
using EsfahanGhos.Model;

namespace EsfahanGhos
{
    public partial class Form_PurchaseList : Form
    {
        Corporation db = new Corporation();
        /// <summary>
        /// لیست از هزینه های سرویس
        /// </summary>
        IList<CostOfService> COSList = new List<CostOfService>();
        /// <summary>
        /// لیستی از آیتم ها
        /// </summary>
        IList<PurchaseListItem> PListItem = new List<PurchaseListItem>();
        /// <summary>
        /// لیستی از پیمانکار ها
        /// </summary>
        IList<Contractor> ContractorList = null;
        /// <summary>
        /// لیستی از پروژه ها
        /// </summary>
        IList<Project> ProjectList = null;
        /// <summary>
        /// لیستی از فاکتور ها
        /// </summary>
        IList<Factor> FactorList = new List<Factor>();
        /// <summary>
        /// لیستی از فاکتور های ویرایش نشده
        /// </summary>
        IList<Factor> OldFactorList = null;
        /// <summary>
        /// لیست تنخواه ها
        /// </summary>
        IList<Tankhah> TankhahList = null;
        /// <summary>
        /// شی لیست خرید کلی 
        /// </summary>
        PurchaseList GeneralPList;
        PurchaseList newPList;
        /// <summary>
        /// چک کردن بسته شدن فرم
        /// </summary>
        bool close = false;
        /// <summary>
        /// قیمت کل
        /// </summary>
        long OldPListPrice = 0, NewPListPrice = 0;
        /// <summary>
        /// آی دی تنخواه
        /// </summary>
        int SelectedTankhahID;
        /// <summary>
        /// آی دی لیست خرید
        /// </summary>
        int newPListID;
        /// <summary>
        /// آی دی اعتبار
        /// </summary>
        int newCreditID;
        /// <summary>
        /// ردیابی پیمانکار ها و حرفه ها
        /// </summary>
        int[,] ContractorSkills = new int[100, 100];
        /// <summary>
        /// استیت های فرم
        /// </summary>
        enum States { Normal, WithTankhah, Edit };
        /// <summary>
        /// ست کردن استیت معمولی
        /// </summary>
        States State = States.Normal;
        /// <summary>
        ///  متغیر سراسری برای ذخیره ردیف در گرید ایتم
        /// </summary>
        int _RowItem = 0;
        /// <summary>
        ///  متغیر سراسری برای ذخیره ردیف در گرید حرفه
        /// </summary>
        int _RowCost = 0;
        /// <summary>
        /// فلگ برای انتساب یگانه ایونت کی پرس
        /// </summary>
        bool flagItem = false;
        bool flagCost = false;
        long _TotalPrice = 0;
        long price = 0;
        bool flag = false;
        public Form_PurchaseList()
        {
            InitializeComponent();
        }
        public Form_PurchaseList(int TankhahID1)
        {
            State = States.WithTankhah;
            SelectedTankhahID = TankhahID1;
            InitializeComponent();
        }
        public Form_PurchaseList(int PListID, int i)
        {
            State = States.Edit;
            newPListID = PListID;
            OldFactorList = new List<Factor>();
            InitializeComponent();
        }
        private void CellFormating(DataGridViewCellFormattingEventArgs e)
        {
            long Price;
            if (e.Value != null)
                Price = utility.ConvertCommaPrice(e.Value.ToString());
            else
                Price = Convert.ToInt64(e.Value);
            e.Value = Price.ToString("###,###", CultureInfo.InvariantCulture);
            e.FormattingApplied = true;

        }
        private void UpdateRowsCount(string p, int p1, int p2)
        {
            if (p == "GridItem")
            {
                for (int i = p1; i < p2; i++)
                {
                    GridItem.Rows[i].Cells["GridItemRowS"].Value = i + 1;
                }
            }
            else
            {
                for (int i = p1; i < p2; i++)
                {
                    GridCostOfService.Rows[i].Cells["GridCostRowCount"].Value = i + 1;
                }
            }
        }
        private void RemoveRow_AND_UpdateTotalPrice(string p1, int p2)
        {
            //GridItem
            if (p1 == "GridItem")
            {
                if (GridItem.Rows.Count != p2 + 1)
                {
                    if (GridItem.Rows[p2].Cells["GridItemPrice"].Value != null)
                        _TotalPrice = _TotalPrice - utility.ConvertCommaPrice(GridItem.Rows[p2].Cells["GridItemPrice"].Value.ToString());
                    GridItem.Rows.Remove(GridItem.Rows[p2]);
                }
            }
            //GridCost
            else
            {

                if (GridCostOfService.Rows.Count != p2 + 1)
                {
                    if (GridCostOfService.Rows[p2].Cells["GridCostPrice"].Value != null)
                        _TotalPrice = _TotalPrice - utility.ConvertCommaPrice(GridCostOfService.Rows[p2].Cells["GridCostPrice"].Value.ToString());
                    GridCostOfService.Rows.RemoveAt(p2);
                }
            }
            txtTotalPrice.Text = utility.ConvertPrice(_TotalPrice);
        }
        private void CellPainting(DataGridViewCellPaintingEventArgs e)
        {
            try
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                e.Graphics.DrawImage(Properties.Resources.del, e.CellBounds.Left + 2, e.CellBounds.Top);
                e.Handled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطا" + "\n\n" + ex.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void EditingControlShowing(DataGridViewEditingControlShowingEventArgs e, string p)
        {
            TextBox text = e.Control as TextBox;
            ///GridItem
            if (p == "GridItem")
            {
                if (GridItem.CurrentCell.ColumnIndex == GridItem.Columns["GridItemPrice"].Index)
                {
                    if (!flagItem)
                    {
                        text.KeyPress += new KeyPressEventHandler(txtTotalPrice_KeyPress);
                        flagItem = true;
                    }
                }
                else
                    if (GridItem.CurrentCell.ColumnIndex == GridItem.Columns["GridItemRowS"].Index || GridItem.CurrentCell.ColumnIndex == GridItem.Columns["GridItemDescription"].Index || GridItem.CurrentCell.ColumnIndex == GridItem.Columns["GridItemRemove"].Index)
                    {
                        if (flagItem)
                        {
                            text.KeyPress -= new KeyPressEventHandler(txtTotalPrice_KeyPress);
                            flagItem = false;
                        }
                    }
                    else
                        flagItem = false;
            }
            ///GridCost
            else
            {

                if (GridCostOfService.CurrentCell.ColumnIndex == GridCostOfService.Columns["GridCostPrice"].Index)
                {
                    if (!flagCost)
                    {
                        text.KeyPress += new KeyPressEventHandler(txtTotalPrice_KeyPress);
                        flagCost = true;
                    }
                }
                else
                    if (GridCostOfService.CurrentCell.ColumnIndex == GridCostOfService.Columns["GridCostRowCount"].Index || GridCostOfService.CurrentCell.ColumnIndex == GridCostOfService.Columns["GridCostRemove"].Index)
                    {
                        if (flagCost)
                        {
                            text.KeyPress -= new KeyPressEventHandler(txtTotalPrice_KeyPress);
                            flagCost = false;
                        }
                    }
                    else
                        flagCost = false;
            }

        }
        private void txtTotalPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;

        }

        /// <summary>
        /// لود فرم
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormPurchaseList_Load(object sender, EventArgs e)
        {
            Datepicker.GeoDate = DateTime.Now;
            BGW.RunWorkerAsync();
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            GridItem.Rows[0].Cells["GridItemRowS"].Value = 1;
            GridCostOfService.Rows[0].Cells["GridCostRowCount"].Value = 1;
        }
        private void GridItem_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex == 5 && e.RowIndex != -1)
                CellPainting(e);
        }
        private void GridCostOfServis_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex == 5 && e.RowIndex != -1)
                CellPainting(e);
        }
        private void GridCostOfServis_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 3)
                CellFormating(e);
        }
        private void GridItem_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 3)
                CellFormating(e);
        }
        private void GridCostOfServis_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            EditingControlShowing(e, "GridCostOfServis");
        }
        private void GridItem_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            EditingControlShowing(e, "GridItem");
        }
        private void GridCostOfServis_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            flag = true;
            if (e.ColumnIndex == 5)
            {
                flag = false;
                RemoveRow_AND_UpdateTotalPrice("GridCostOfServis", e.RowIndex);
                UpdateRowsCount("GridCostOfServis", e.RowIndex, GridCostOfService.Rows.Count);
            }
        }
        private void GridItem_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            flag = true;
            if (e.ColumnIndex == 5)
            {
                flag = false;
                RemoveRow_AND_UpdateTotalPrice("GridItem", e.RowIndex);
                UpdateRowsCount("GridItem", e.RowIndex, GridItem.Rows.Count);
            }
        }
        private void GridCostOfServis_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (flag)
            {
                GridItem.Rows[0].Cells["GridItemRowS"].Selected = true;
            }
            if (e.ColumnIndex == GridCostOfService.Columns["GridCostPrice"].Index)
            {
                if (GridCostOfService.CurrentCell.Value != null)
                    price = utility.ConvertCommaPrice(GridCostOfService.CurrentCell.Value.ToString());
                else
                    price = -1;
            }
            _RowCost = e.RowIndex;
        }
        private void GridItem_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (GridItem.Columns["GridItemRemove"].Index == e.RowIndex)
                return;
            if (flag)
            {
                GridCostOfService.Rows[0].Cells["GridCostRowCount"].Selected = true;
            }
            if (e.ColumnIndex == GridItem.Columns["GridItemPrice"].Index)
            {
                if (GridItem.CurrentCell.Value != null)
                    price = utility.ConvertCommaPrice(GridItem.CurrentCell.Value.ToString());
                else
                    price = -1;
            }
            _RowItem = e.RowIndex;
        }
        private void GridCostOfServis_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            GridCostOfService.Rows[GridCostOfService.Rows.Count - 1].Cells["GridCostRowCount"].Value = GridCostOfService.Rows.Count;
        }
        private void GridItem_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            GridItem.Rows[GridItem.Rows.Count - 1].Cells["GridItemRowS"].Value = GridItem.Rows.Count;
        }
        private void GridItem_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            flag = false;
            if (e.ColumnIndex == GridItem.Columns["GridItemPrice"].Index && GridItem.Rows[_RowItem].Cells["GridItemPrice"].Value != null)
            {
                if (price != -1)
                {
                    _TotalPrice -= price;
                }
                _TotalPrice += utility.ConvertCommaPrice(GridItem.Rows[_RowItem].Cells["GridItemPrice"].Value.ToString());
                txtTotalPrice.Text = utility.ConvertPrice(_TotalPrice);
            }
            _RowItem = e.RowIndex;
        }
        private void GridCostOfServis_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            flag = false;
            if (e.ColumnIndex == GridCostOfService.Columns["GridCostPrice"].Index && GridCostOfService.Rows[_RowCost].Cells["GridCostPrice"].Value != null)
            {
                if (price != -1)
                {
                    _TotalPrice -= price;
                }
                _TotalPrice += utility.ConvertCommaPrice(GridCostOfService.Rows[_RowCost].Cells["GridCostPrice"].Value.ToString());
                txtTotalPrice.Text = utility.ConvertPrice(_TotalPrice);
            }
            _RowCost = e.RowIndex;
        }

        /// <summary>
        /// dowork
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BgwPurchaselist_DoWork(object sender, DoWorkEventArgs e)
        {
            //try
            //{
            if (State == States.Normal || State == States.WithTankhah)
            {
                GetTankhahs();
                GetProjects();
                GeneralPList = db.PurchaseLists.FirstOrDefault(p => p.PurchaseListID == 0);
            }
            else
            {
                GeneralPList = db.PurchaseLists.Include("Factors").Include("Tankhah").Include("Credit").Include("PurchaseListItems").Include("CostOfServices").FirstOrDefault(p => p.PurchaseListID == newPListID);
                GetTankhahs();
                GetProjects();
            }
            //}
            //catch (DbUpdateException ex)
            //{
            //    MessageBox.Show(SqlServerErrorManagment.ShowError(ex, "صورت وضعیت") + "\n\n" + ex.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("خطا" + "\n\n" + ex.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            //}

        }

        /// <summary>
        /// نمایش پروژه ها
        /// </summary>
        private void ShowProjects()
        {
            //try
            //{
            if (ProjectList.Count == 0)
            {
                MessageBox.Show("شما هیچ پروژه ای ثبت نکرده اید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                Form_RegisterProject P = new Form_RegisterProject();
                P.ShowDialog();
                GetProjects();
                ShowProjects();
            }
            else
            {
                GridItemProject.ValueMember = "ProjectID";
                GridItemProject.DisplayMember = "ProjectName";
                GridItemProject.DataSource = ProjectList;
                GridItemProject.DropDownWidth = 160;
                GridCostProject.ValueMember = "ProjectID";
                GridCostProject.DisplayMember = "ProjectName";
                GridCostProject.DataSource = ProjectList;
                GridCostProject.DropDownWidth = 160;
            }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("خطا در نمایش پروژه ها" + "\n\n" + ex.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            //}
        }

        /// <summary>
        /// واکشی پروژه ها
        /// </summary>
        private void GetProjects()
        {
            //try
            //{
            if (State == States.Normal || State == States.WithTankhah)
                ProjectList = db.Projects.OrderBy(p => p.ProjectID).Where(p => p.isActive == true).ToList();
            else
                ProjectList = db.Projects.OrderBy(p => p.ProjectID).ToList();
            //}
            //catch (DbUpdateException ex)
            //{
            //    MessageBox.Show(SqlServerErrorManagment.ShowError(ex, "پروژه") + "\n\n" + ex.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("خطا" + "\n\n" + ex.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            //}
        }

        /// <summary>
        /// واکشی تنخواه ها
        /// </summary>
        private void GetTankhahs()
        {
            //try
            //{
            if (State == States.Normal)
            {
                TankhahList = db.Tankhahs.OrderBy(p => p.TankhahName).Where(p => p.TankhahID != 0).ToList<Tankhah>();
            }
            else if (State == States.WithTankhah)
            {
                TankhahList = db.Tankhahs.Where(p => p.TankhahID == SelectedTankhahID).ToList<Tankhah>();
            }
            else
            {
                int PID = GeneralPList.TankhahID;
                TankhahList = db.Tankhahs.Where(p => p.TankhahID == PID).ToList<Tankhah>();
            }
            //}
            //catch (DbUpdateException ex)
            //{
            //    MessageBox.Show(SqlServerErrorManagment.ShowError(ex, "تنخواه ") + "\n\n" + ex.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("خطا" + "\n\n" + ex.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            //}
        }

        /// <summary>
        /// Completed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BgwPurchaselist_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //try
            //{
            if (State == States.Normal || State == States.WithTankhah)
            {
                ShowProjects();
                ShowTankhahCombo();
                GeneralPList = db.PurchaseLists.FirstOrDefault(p => p.PurchaseListID == 0);
                GetContractors();
                ShowContarctorsInCmb();
                btnRegister.Enabled = true;
                BtnNew.Enabled = true;
            }
            else
            {
                ShowProjects();
                ShowTankhahCombo();
                GetContractors();
                ShowContarctorsInCmb();
                btnRegister.Enabled = true;
                btnRegister.Text = "ویرایش";
                ShowPListItems();
                ShowFactors();
                ShowCOSs();
                txtTotalPrice.Text = utility.ConvertPrice(GeneralPList.TotalPrice);
                OldPListPrice = _TotalPrice = utility.ConvertCommaPrice(txtTotalPrice.Text.Trim());
                ShowFormDatas();
            }
            //}
            //catch (DbUpdateException ex)
            //{
            //    MessageBox.Show(SqlServerErrorManagment.ShowError(ex, "لیست تنخواه") + "\n\n" + ex.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("خطا" + "\n\n" + ex.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            //}
        }

        /// <summary>
        /// نمایش داده های کلی
        /// </summary>
        private void ShowFormDatas()
        {
            Datepicker.GeoDate = Convert.ToDateTime(GeneralPList.Date);
            NumPListCount.Text = GeneralPList.NumberOfList.ToString();
        }

        /// <summary>
        /// نمایش هزینه های پیمانکار
        /// </summary>
        private void ShowCOSs()
        {
            //try
            //{
            //ContractorSkills
            if (GeneralPList.CostOfServices != null)
                COSList = GeneralPList.CostOfServices.ToList();
            if (COSList.Count != 0)
            {
                int i = 0;
                foreach (CostOfService COS in COSList)
                {
                    GridCostOfService.Rows.Add();
                    GridCostOfService.Rows[i].Cells["GridCostRowCount"].Value = i + 1;
                    GridCostOfService.Rows[i].Cells["GridCostDate"].Value = COS.Date;
                    GridCostOfService.Rows[i].Cells["GridCostContractor"].Value = COS.Contractor.CName + " - " + COS.Skill.SkillName;
                    GridCostOfService.Rows[i].Cells["GridCostPrice"].Value = COS.Cost;
                    GridCostOfService.Rows[i].Cells["GridCostProject"].Value = COS.ProjectID;
                    i++;
                }
            }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("خطا در نمایش هزینه های پیمانکار" + "\n\n" + ex.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            //}
        }

        /// <summary>
        /// نمایش فاکتور ها
        /// </summary>
        private void ShowFactors()
        {
            //try
            //{
            if (GeneralPList.Factors != null)
                OldFactorList = FactorList = GeneralPList.Factors.ToList();
            Factor[] temp = new Factor[OldFactorList.Count];
            OldFactorList.ToList().CopyTo(temp);
            OldFactorList = temp.ToList();
            temp = new Factor[FactorList.Count];
            FactorList.ToList().CopyTo(temp);
            FactorList = temp.ToList();
            if (OldFactorList.Count != 0)
            {
                int i = 0;
                foreach (Factor Factor in OldFactorList)
                {
                    GridFactors.Rows.Add();
                    GridFactors.Rows[i].Cells["Row"].Value = i + 1;
                    GridFactors.Rows[i].Cells["Description"].Value = Factor.Description;
                    GridFactors.Rows[i].Cells["Number"].Value = Factor.FactorNumber;
                    GridFactors.Rows[i].Cells["TotalPrice"].Value = Factor.TotalPrice;
                    GridFactors.Rows[i].Cells["GridFactorDate"].Value = Factor.Date;
                    GridFactors.Rows[i].Cells["ProjectName"].Value = Factor.Project.ProjectName;
                    GridFactors.Rows[i].Cells["FactorID"].Value = Factor.FactorID;
                    i++;
                }
            }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("خطا" + "\n\n" + ex.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            //}
        }

        /// <summary>
        /// نمایش آیتم های لیست
        /// </summary>
        private void ShowPListItems()
        {
            ////try
            ////{
            if (GeneralPList.PurchaseListItems != null)
                PListItem = GeneralPList.PurchaseListItems.ToList();
            if (PListItem.Count != 0)
            {
                int i = 0;
                foreach (PurchaseListItem item in PListItem)
                {
                    GridItem.Rows.Add();
                    GridItem.Rows[i].Cells["GridItemRowS"].Value = i + 1;
                    GridItem.Rows[i].Cells["GridItemDescription"].Value = item.Description;
                    GridItem.Rows[i].Cells["GridItemDate"].Value = Convert.ToDateTime(item.Date);
                    GridItem.Rows[i].Cells["GridItemPrice"].Value = utility.ConvertPrice(item.Price);
                    GridItem.Rows[i].Cells["GridItemProject"].Value = item.ProjectID;
                    i++;
                }
            }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("خطا در نمایش موارد لیست خرید" + "\n\n" + ex.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            //}
        }

        /// <summary>
        /// نمایش پیمانکارها در کومبو
        /// </summary>
        private void ShowContarctorsInCmb()
        {
            //try
            //{
            if (ContractorList.Count != 0)
            {
                int i = -1;
                int j = -1;
                foreach (var Contractor in ContractorList)
                {
                    j++;
                    foreach (var Skill in Contractor.Skills)
                    {
                        i++;
                        GridCostContractor.Items.Add(Contractor.CName + " - " + Skill.SkillName);
                        ContractorSkills[i, j] = Skill.SkillID;
                    }
                }
                GridCostContractor.DropDownWidth = 200;
            }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("خطا" + "\n\n" + ex.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            //}
        }

        /// <summary>
        /// واکشی پیمانکار ها
        /// </summary>
        private void GetContractors()
        {
            //try
            //{
            ContractorList = db.Contractors.Include("Skills").ToList();
            //}
            //catch (DbUpdateException ex)
            //{
            //    MessageBox.Show(SqlServerErrorManagment.ShowError(ex, "پیمانکار") + "\n\n" + ex.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            //}
        }

        /// <summary>
        /// نمایش تنخواه ها در  کومبو
        /// </summary>
        private void ShowTankhahCombo()
        {
            //try
            //{
            if (State == States.Normal)
            {
                if (TankhahList.Count() != 0)
                {
                    CmbTankhah.ValueMember = "TankhahID";
                    CmbTankhah.DisplayMember = "TankhahName";
                    CmbTankhah.DataSource = TankhahList;
                    CmbTankhah.Enabled = true;
                }
                else
                {
                    if (MessageBox.Show("شما هیچ تنخواهی ثبت نکرده اید ، آیا مایل به ثبت تنخواه هستید ؟", "خطا", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) == DialogResult.Yes)
                    {
                        Form_RegTankhah FT = new Form_RegTankhah();
                        FT.ShowDialog();
                        FormDefaults();
                    }
                    else
                    {
                        this.Close();
                        return;
                    }
                }
            }
            else
            {
                CmbTankhah.ValueMember = "TankhahID";
                CmbTankhah.DisplayMember = "TankhahName";
                CmbTankhah.DataSource = TankhahList;
            }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("خطا" + "\n\n" + ex.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            //}
        }

        /// <summary>
        /// داده های اولیه فرم
        /// </summary>
        private void FormDefaults()
        {
            GetTankhahs();
            ShowTankhahCombo();
            GridCostOfService.Rows.Clear();
            GridItem.Rows.Clear();
            GridFactors.Rows.Clear();
        }

        /// <summary>
        /// ایونت کمبو تنخواه
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CmbTankhah_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (State == States.Normal || State == States.WithTankhah)
            {
                SelectedTankhahID = Convert.ToInt32(CmbTankhah.SelectedValue);
                GetTankhahPListCount();
            }
        }

        /// <summary>
        /// گرفتن شماره لیست
        /// </summary>
        private void GetTankhahPListCount()
        {
            //try
            //{
            if (State == States.Normal || State == States.WithTankhah)
            {
                if (db.PurchaseLists.Any(p => p.TankhahID == SelectedTankhahID))
                {
                    int? num = db.PurchaseLists.Where(p => p.TankhahID == SelectedTankhahID).Max(p => p.NumberOfList);
                    NumPListCount.Text = (num + 1).ToString();

                }
                else
                {
                    NumPListCount.Text = "1";
                }
            }
            //}
            //catch (DbUpdateException ex)
            //{
            //    MessageBox.Show(SqlServerErrorManagment.ShowError(ex, "تنخواه") + "\n\n" + ex.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("خطا" + "\n\n" + ex.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            //}
        }

        /// <summary>
        /// ایونت ثثثثثثثثبت
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (State == States.Normal || State == States.WithTankhah)
            {
                if (CheckError(GridCostOfService) && CheckError(GridItem))
                {
                    InsertCredit();
                    InsertPList();
                    InsertItems();
                    InsertCostOfServices();
                    AssignFactors();
                    db.SaveChanges();
                    utility.Show_Message("عملیات ثبت با موفقیت انجام شد", "پیغام عملیات");
                    FormDefaults();
                    if (FactorList.Count != 0)
                    {
                        FactorList.Clear();
                    }
                    _TotalPrice = 0;
                    txtTotalPrice.Text = "0";
                }

                if (MessageBox.Show("آیا میخواهید اطلاعات این پرداخت ثبت شود؟", "سوال", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Form_Payment FP = new Form_Payment(newPList);
                    FP.ShowDialog();
                }
            }
            else
            {
                if (CheckError(GridCostOfService) && CheckError(GridItem))
                {
                    NewPListPrice = utility.ConvertCommaPrice(txtTotalPrice.Text.Trim());
                    DeleteItems();
                    DeleteCOSs();
                    UpdateFactorPrices();
                    InsertItems();
                    InsertCostOfServices();
                    UpdatePList();
                    AssignFactors();
                    db.SaveChanges();
                    utility.Show_Message("عملیات ویرایش با موفقیت انجام شد", "پیغام عملیات");

                    close = true;
                    this.Close();
                }
            }

        }

        /// <summary>
        /// به روز رسانی لیست خرید
        /// </summary>
        private void UpdatePList()
        {
            //try
            //{
            db.Tankhahs.FirstOrDefault(p => p.TankhahID == GeneralPList.TankhahID).CreditCurrent += (NewPListPrice - OldPListPrice);
            db.Credits.FirstOrDefault(p => p.CreditID == GeneralPList.CreditID).Price += (NewPListPrice - OldPListPrice);

            GeneralPList.TotalPrice += (NewPListPrice - OldPListPrice);
            GeneralPList.Date = Convert.ToDateTime(Datepicker.GeoDate);
            GeneralPList.NumberOfList = Convert.ToInt32(NumPListCount.Text);
            //}
            //catch (DbUpdateException ex)
            //{
            //    MessageBox.Show(SqlServerErrorManagment.ShowError(ex, "لیست خرید") + "\n\n" + ex.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("خطا" + "\n\n" + ex.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            //}
        }

        /// <summary>
        /// به روز رسانی فاکتور ها
        /// </summary>
        private void UpdateFactorPrices()
        {
            //try
            //{
            int? ProjectID;
            if (OldFactorList.Count != 0)
            {
                foreach (Factor Factor in OldFactorList)
                {
                    ProjectID = Factor.ProjectID;
                    db.Projects.FirstOrDefault(p => p.ProjectID == ProjectID).TotalCost -= Factor.TotalPrice;
                }

            }
            int PID = GeneralPList.PurchaseListID;
            List<Factor> AFactorList = new List<Factor>();
            AFactorList = db.Factors.AsNoTracking().Include("Project").Where(p => p.PurchaseListID == PID).ToList<Factor>();
            if (AFactorList.Count != 0)
            {
                foreach (Factor Factor in AFactorList)
                {
                    ProjectID = Factor.ProjectID;
                    db.Projects.FirstOrDefault(p => p.ProjectID == ProjectID).TotalCost += Factor.TotalPrice;
                }
            }
            //}
            //catch (DbUpdateException ex)
            //{
            //    MessageBox.Show(SqlServerErrorManagment.ShowError(ex, "صورت وضعیت") + "\n\n" + ex.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("خطا" + "\n\n" + ex.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            //}
        }

        /// <summary>
        /// حذف همه هزینه سرویس ها
        /// </summary>
        private void DeleteCOSs()
        {
            //try
            //{
            if (COSList.Count != 0)
            {
                int ProjectID;
                foreach (CostOfService COS in COSList)
                {
                    ProjectID = COS.ProjectID;
                    db.Projects.FirstOrDefault(p => p.ProjectID == ProjectID).TotalCost -= COS.Cost;
                }
                db.CostOfServices.RemoveRange(COSList);
            }
            //}
            //catch (DbUpdateException ex)
            //{
            //    MessageBox.Show(SqlServerErrorManagment.ShowError(ex, "هزینه پیمانکار") + "\n\n" + ex.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("خطا در ثبت هزینه های پیمانکار" + "\n\n" + ex.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            //}
        }

        /// <summary>
        /// حذف همه موارد لیست
        /// </summary>
        private void DeleteItems()
        {
            //try
            //{
            int? ProjectID;
            foreach (PurchaseListItem item in PListItem)
            {
                ProjectID = item.ProjectID;
                db.Projects.FirstOrDefault(p => p.ProjectID == ProjectID).TotalCost -= item.Price;
            }
            db.PurchaseListItems.RemoveRange(PListItem);
            //}
            //catch (DbUpdateException ex)
            //{
            //    MessageBox.Show(SqlServerErrorManagment.ShowError(ex, "موارد لیست خرید") + "\n\n" + ex.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("خطا در ثبت موارد لیست خرید" + "\n\n" + ex.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            //}
        }

        /// <summary>
        /// اینسرت موارد هزینه سرویس
        /// </summary>
        private void InsertCostOfServices()
        {
            //try
            //{
            int i = -1, y = 0, Index;
            int SkillID, ProjectID;
            long Cost;
            if (COSList.Count != 0)
            {
                COSList.Clear();
            }
            foreach (var Row in GridCostOfService.Rows)
            {
                i++;
                if (GridCostOfService.Rows.Count - 1 != i)
                {
                    y = 0;
                    DataGridViewComboBoxCell ContractorsCell = (DataGridViewComboBoxCell)GridCostOfService.Rows[i].Cells["GridCostContractor"];
                    Index = ContractorsCell.Items.IndexOf(ContractorsCell.Value);
                    Cost = Convert.ToInt64(GridCostOfService.Rows[i].Cells["GridCostPrice"].Value);
                    ProjectID = Convert.ToInt32(GridCostOfService.Rows[i].Cells["GridCostProject"].Value);
                    while (ContractorSkills[Index, y] == 0)
                    {
                        y++;
                    }
                    SkillID = ContractorSkills[Index, y];
                    CostOfService newCostOfService = new CostOfService()
                    {
                        ContractorID = ContractorList.ToList()[y].ContractorID,
                        Cost = Cost,
                        CostOfServiceID = utility.CreatedNewID(),
                        Date = Convert.ToDateTime(GridCostOfService.Rows[i].Cells["GridCostDate"].Value),
                        ProjectID = ProjectID,
                        PurchaseListID = newPListID,
                        SkillID = SkillID
                    };
                    db.Projects.FirstOrDefault(p => p.ProjectID == ProjectID).TotalCost += Cost;
                    COSList.Add(newCostOfService);
                }
            }
            db.CostOfServices.AddRange(COSList);
            //}
            //catch (DbUpdateException ex)
            //{
            //    MessageBox.Show(SqlServerErrorManagment.ShowError(ex, "موارد لیست خرید") + "\n\n" + ex.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("خطا در ثبت موارد لیست خرید" + "\n\n" + ex.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            //}
        }

        /// <summary>
        /// اینسرت آیتم ها
        /// </summary>
        private void InsertItems()
        {
            //try
            //{
            int i = -1;
            int ProjectID;
            long Price;
            if (PListItem.Count != 0)
            {
                PListItem.Clear();
            }
            foreach (var Row in GridItem.Rows)
            {
                i++;
                if (GridItem.Rows.Count - 1 != i)
                {
                    ProjectID = Convert.ToInt32(GridItem.Rows[i].Cells["GridItemProject"].Value);
                    Price = Convert.ToInt64(utility.ConvertCommaPrice(GridItem.Rows[i].Cells["GridItemPrice"].Value.ToString()));
                    PurchaseListItem newPurchaseListItem = new PurchaseListItem()
                    {
                        Date = Convert.ToDateTime(GridItem.Rows[i].Cells["GridItemDate"].Value),
                        Description = GridItem.Rows[i].Cells["GridItemDescription"].Value.ToString(),
                        Price = Price,
                        PurchaseListID = newPListID,
                        ProjectID = Convert.ToInt32(GridItem.Rows[i].Cells["GridItemProject"].Value)
                    };
                    db.Projects.FirstOrDefault(p => p.ProjectID == ProjectID).TotalCost += Price;
                    PListItem.Add(newPurchaseListItem);
                }
            }
            db.PurchaseListItems.AddRange(PListItem);
            //}
            //catch (DbUpdateException ex)
            //{
            //    MessageBox.Show(SqlServerErrorManagment.ShowError(ex, "موارد لیست خرید") + "\n\n" + ex.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("خطا در ثبت موارد لیست خرید" + "\n\n" + ex.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            //}
        }

        /// <summary>
        /// تعیین کلید خارجی فاکتور ها
        /// </summary>
        private void AssignFactors()
        {
            //try
            //{
            if (State == States.Normal || State == States.WithTankhah)
            {
                int? ProjectID;
                int ID = GeneralPList.PurchaseListID;
                FactorList = db.Factors.Include("Project").Where(p => p.PurchaseListID == ID).ToList<Factor>();
                if (FactorList.Count != 0)
                {
                    foreach (var Factor in FactorList)
                    {
                        Factor.PurchaseListID = newPListID;
                        //Factor.PurchaseList = GeneralPList;
                        ProjectID = Factor.ProjectID;
                        db.Projects.FirstOrDefault(p => p.ProjectID == ProjectID).TotalCost += Factor.TotalPrice;
                    }
                }
            }
            else
            {
                if (FactorList.Count != 0)
                {
                    int FactorID;
                    foreach (Factor Factor in FactorList)
                    {
                        FactorID = Factor.FactorID;
                        db.Factors.FirstOrDefault(p => p.FactorID == FactorID).PurchaseListID = newPListID;
                    }
                }
            }
            //}
            //catch (DbUpdateException ex)
            //{
            //    MessageBox.Show(SqlServerErrorManagment.ShowError(ex, "فاکتور") + "\n\n" + ex.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("خطا" + "\n\n" + ex.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            //}
        }
        /// <summary>
        /// اینسرت خود لیست خرید :پی
        /// </summary>
        private void InsertPList()
        {
            //try
            //{
            DateTime DD = Convert.ToDateTime(Datepicker.GeoDate);
            DateTime D = new DateTime(DD.Year, DD.Month, DD.Day, DateTime.Now.Hour, DateTime.Now.Minute, 0);
            newPListID = utility.CreatedNewID();
             newPList = new PurchaseList()
            {
                PurchaseListID = newPListID,
                CreditID = newCreditID,
                Date = D,
                NumberOfList = Convert.ToInt32(NumPListCount.Text.Trim()),
                TankhahID = Convert.ToInt32(CmbTankhah.SelectedValue),
                TotalPrice = _TotalPrice
            };
            db.PurchaseLists.Add(newPList);
            //}
            //catch (DbUpdateException ex)
            //{
            //    MessageBox.Show(SqlServerErrorManagment.ShowError(ex, "فاکتور") + "\n\n" + ex.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("خطا در ثبت لیست خرید" + "\n\n" + ex.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            //}
        }

        /// <summary>
        /// اینسرت اعتبار
        /// </summary>
        private void InsertCredit()
        {
            //try
            //{
            newCreditID = utility.CreatedNewID();
            Credit newCredit = new Credit()
            {
                CreditID = newCreditID,
                DateCredit = Convert.ToDateTime(Datepicker.GeoDate),
                TankhahID = Convert.ToInt32(CmbTankhah.SelectedValue),
                Type = "-",
                Price = _TotalPrice
            };
            db.Credits.Add(newCredit);
            db.Tankhahs.FirstOrDefault(p => p.TankhahID == SelectedTankhahID).CreditCurrent -= _TotalPrice;
            //}
            //catch (DbUpdateException ex)
            //{
            //    MessageBox.Show(SqlServerErrorManagment.ShowError(ex, "فاکتور") + "\n\n" + ex.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("خطا در ثبت اعتبار" + "\n\n" + ex.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            //}
        }

        /// <summary>
        /// ایونت new  کلیک
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnNew_Click(object sender, EventArgs e)
        {
            //try
            //{
            FormDefaults();
            if (FactorList.Count != 0)
            {
                db.Factors.RemoveRange(FactorList);
                db.SaveChanges();
                FactorList.Clear();
                GridFactors.Rows.Clear();
            }
            //}
            //catch (DbUpdateException ex)
            //{
            //    MessageBox.Show(SqlServerErrorManagment.ShowError(ex, "فاکتور") + "\n\n" + ex.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("خطا" + "\n\n" + ex.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            //}
        }
        /// <summary>
        /// ایونت ثبت فاکتور
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnFactorRegister_Click(object sender, EventArgs e)
        {
            Form_RegFactorListItem FF = new Form_RegFactorListItem(GeneralPList);
            FF.ShowDialog();
            UpdateFactors();
        }

        /// <summary>
        /// به روز رسانی فاکتور ها
        /// </summary>
        private void UpdateFactors()
        {
            //try
            //{
            long OldValue = 0;
            long NewValue = 0;
            if (FactorList.Count != 0)
            {
                FactorList.Clear();
            }
            int PID = GeneralPList.PurchaseListID;

            //var refreshableObject=db.ChangeTracker.Entries().Select(c => c.Entity).ToList();
            //((IObjectContextAdapter)db).ObjectContext.Refresh(RefreshMode.StoreWins, refreshableObject);
            //FactorList = FFactorList;
            // FactorList = FFactorList.ToList();
            //FFactorList.CopyTo(FactorList.ToArray<Factor>(), 0);
            //Corporation db2 = new Corporation();
            List<Factor> FFactorList = new List<Factor>();
            FFactorList = db.Factors.AsNoTracking().Include("Project").Where(p => p.PurchaseListID == PID).ToList<Factor>();

            for (int i = 0; i < GridFactors.Rows.Count; i++)
            {
                OldValue += Convert.ToInt64(utility.ConvertCommaPrice(GridFactors.Rows[i].Cells["TotalPrice"].Value.ToString()));
            }
            GridFactors.Rows.Clear();
            int j = 0;
            if (FFactorList.Count != 0)
            {
                foreach (var Factor in FFactorList)
                {
                    GridFactors.Rows.Add();
                    NewValue += Factor.TotalPrice;
                    GridFactors.Rows[j].Cells["Row"].Value = j + 1;
                    GridFactors.Rows[j].Cells["Description"].Value = Factor.Description;
                    GridFactors.Rows[j].Cells["TotalPrice"].Value = utility.ConvertPrice(Factor.TotalPrice);
                    GridFactors.Rows[j].Cells["GridFactorDate"].Value = utility.ConvertDate_M_To_Sh(Factor.Date);
                    GridFactors.Rows[j].Cells["FactorID"].Value = Factor.FactorID;
                    GridFactors.Rows[j].Cells["Number"].Value = Factor.FactorNumber;
                    GridFactors.Rows[j++].Cells["ProjectName"].Value = Factor.Project.ProjectName;
                }
            }
            if (OldValue != NewValue)
            {
                _TotalPrice += (NewValue - OldValue);
                txtTotalPrice.Text = utility.ConvertPrice(_TotalPrice.ToString());
            }
            //}
            //catch (DbUpdateException ex)
            //{
            //    MessageBox.Show(SqlServerErrorManagment.ShowError(ex, "فاکتور") + "\n\n" + ex.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("خطا در به روز رسانی فاکتور ها" + "\n\n" + ex.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            //}
        }

        /// <summary>
        /// ایونت بسته شدن فرم
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormPurchaseList_FormClosing(object sender, FormClosingEventArgs e)
        {
            //try
            //{
            if (State == States.Normal || State == States.WithTankhah)
            {
                if (FactorList.Count != 0)
                {
                    if (MessageBox.Show("برای این لیست فاکتور ثبت شده ، آیا از لغو عملیات اطمینان دارید ؟" + "\n در صورت لغو فاکتور ها حذف خواهند شد ", "اخطار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) == DialogResult.Yes)
                    {
                        db.Factors.RemoveRange(FactorList);
                        db.SaveChanges();
                    }
                    else
                    {
                        e.Cancel = true;
                        return;
                    }

                }
            }
            else
            {
                int i = 0;
                foreach (Factor NewFactor in FactorList)
                {
                    foreach (Factor OldFactor in OldFactorList)
                    {
                        if (NewFactor.TotalPrice == OldFactor.TotalPrice && NewFactor.FactorID == OldFactor.FactorID)
                            i++;
                    }
                }
                if (i != FactorList.Count && !close)
                {
                    MessageBox.Show("به دلیل اجاد تغییرات در فاکتور ها امکان لغو عملیات وجود ندارد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                    e.Cancel = true;
                    return;
                }
            }
            //}
            //catch (DbUpdateException ex)
            //{
            //    MessageBox.Show(SqlServerErrorManagment.ShowError(ex, "...") + "\n\n" + ex.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("خطا" + "\n\n" + ex.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            //}
        }

        /// <summary>
        /// چک کردن گرید ها
        /// </summary>
        /// <param name="Grid"></param>
        /// <returns></returns>
        private bool CheckError(DataGridView Grid)
        {
            if (Grid.Rows.Count > 1)
                Grid.Rows[1].Cells[0].Selected = true;
            for (int i = 0; i < Grid.Rows.Count - 1; i++)
            {
                for (int j = 0; j < Grid.Rows[i].Cells.Count; j++)
                {
                    if (j != 5 && j != 6)
                        if (Grid.Rows[i].Cells[j].Value == null)
                        {
                            Grid.Rows[i].Cells[j].Selected = true;

                            MessageBox.Show(" !!! " + Grid.Columns[j].HeaderText + " نمیتواند خالی بماند");
                            return false;
                        }
                }
            }
            return true;
        }

        /// <summary>
        /// عکس دار کردن گرید فاکتور
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GridFactors_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex == GridFactors.Columns["GridFactorRemove"].Index && e.RowIndex != -1)
                CellPainting(e);
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_PurchaseList_FormClosed(object sender, FormClosedEventArgs e)
        {
            db.Configuration.LazyLoadingEnabled = true;
            db.Configuration.ProxyCreationEnabled = false;
            db.SaveChanges();
        }

        private void GridFactors_CellMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            //try
            //{
            if (e.ColumnIndex == GridFactors.Columns["GridFactorRemove"].Index)
            {
                if (MessageBox.Show("آیا این فاکتور حذف شود ؟", "اخطار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) == DialogResult.Yes)
                {
                    int FactorID = Convert.ToInt32(GridFactors.Rows[e.RowIndex].Cells["FactorID"].Value);
                    long Cost = db.Factors.FirstOrDefault(p => p.FactorID == FactorID).TotalPrice;
                    int? PID = db.Factors.FirstOrDefault(p => p.FactorID == FactorID).ProjectID;
                    //FactorList = db.Factors.ToList();
                    db.Factors.Remove(db.Factors.FirstOrDefault(p => p.FactorID == FactorID));
                    OldFactorList.Remove(db.Factors.FirstOrDefault(p => p.FactorID == FactorID));
                    db.SaveChanges();
                    db.Projects.FirstOrDefault(p => p.ProjectID == PID).TotalCost -= Cost;
                    db.SaveChanges();
                    UpdateFactors();
                }
            }
            else if (e.ColumnIndex == GridFactors.Columns["View"].Index)
            {
                int FactorID = Convert.ToInt32(GridFactors.Rows[e.RowIndex].Cells["FactorID"].Value);
                int PurchaseListID = GeneralPList.PurchaseListID;
                Form_RegFactorListItem FF = new Form_RegFactorListItem(PurchaseListID, FactorID);
                FF.ShowDialog();
                UpdateFactors();
            }
            //}
            //catch (DbUpdateException ex)
            //{
            //    Utility.GetScreenShot(" پایگاه داده _سل کلیک گرید فاکتور _" + Utility.ConvertDate(DateTime.Now) + "_Line=" + Utility.GetErrorLine(ex) + "_" + DateTime.Now.Millisecond);
            //    MessageBox.Show(SqlServerErrorManagment.ShowError(ex, "فاکتور") + "\n\n" + ex.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            //    db = new MyDataBase();
            //}
            //catch (Exception ex)
            //{
            //    Utility.GetScreenShot("سل کلیک گرید فاکتور _" + Utility.ConvertDate(DateTime.Now) + "_Line=" + Utility.GetErrorLine(ex) + "_" + DateTime.Now.Millisecond);
            //    MessageBox.Show("خطا" + "\n\n" + ex.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            //}
        }

        private void Form_PurchaseList_FormClosing(object sender, FormClosingEventArgs e)
        {
            //try
            //{
            if (State == States.Normal || State == States.WithTankhah)
            {
                if (FactorList.Count != 0)
                {
                    if (MessageBox.Show("برای این لیست فاکتور ثبت شده ، آیا از لغو عملیات اطمینان دارید ؟" + "\n در صورت لغو فاکتور ها حذف خواهند شد ", "اخطار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) == DialogResult.Yes)
                    {
                        db.Factors.RemoveRange(FactorList);
                        db.SaveChanges();
                    }
                    else
                    {
                        e.Cancel = true;
                        return;
                    }

                }
            }
            else
            {
                int i = 0;
                foreach (Factor NewFactor in FactorList)
                {
                    foreach (Factor OldFactor in OldFactorList)
                    {
                        if (NewFactor.TotalPrice == OldFactor.TotalPrice && NewFactor.FactorID == OldFactor.FactorID)
                            i++;
                    }
                }
                if (i != FactorList.Count && !close)
                {
                    MessageBox.Show("به دلیل اجاد تغییرات در فاکتور ها امکان لغو عملیات وجود ندارد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                    e.Cancel = true;
                    return;
                }
            }
            //}
            //catch (DbUpdateException ex)
            //{
            //    Utility.GetScreenShot(" پایگاه داده _رویداد بسته شدن فرم _" + Utility.ConvertDate(DateTime.Now) + "_Line=" + Utility.GetErrorLine(ex) + "_" + DateTime.Now.Millisecond);
            //    MessageBox.Show(SqlServerErrorManagment.ShowError(ex, "...") + "\n\n" + ex.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            //    db = new MyDataBase();
            //}
            //catch (Exception ex)
            //{
            //    Utility.GetScreenShot("رویدادبسته شدن فرم _" + Utility.ConvertDate(DateTime.Now) + "_Line=" + Utility.GetErrorLine(ex) + "_" + DateTime.Now.Millisecond);
            //    MessageBox.Show("خطا" + "\n\n" + ex.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            //}
        }

        private void GridFactors_CellPainting_1(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex == GridFactors.Columns["GridFactorRemove"].Index && e.RowIndex != -1)
                CellPainting(e);
        }

        private void GridFactors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
