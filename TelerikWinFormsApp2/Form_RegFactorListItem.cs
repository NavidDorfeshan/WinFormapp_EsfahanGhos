using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity.Infrastructure;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using EsfahanGhos.DataLayer;
using EsfahanGhos.Model;

namespace EsfahanGhos
{
    public partial class Form_RegFactorListItem : Telerik.WinControls.UI.RadForm
    {
        Corporation db = new Corporation();
        PurchaseList _Purchase = new PurchaseList();
        Factor _Factor = null;
        List<Project> _project = null;
        double _VAX = 0;
        int _NewID = 0;
        bool flag = false;
        /// <summary>
        /// محاسبه ی قیمت کل
        /// </summary>
        long _TotalPrice = 0;
        int _Row = 0;
        /// <summary>
        /// Form State
        /// </summary>
        /// state 0 = Register
        /// state 1 = Edit
        /// state 2 = purchaselist register
        /// state 3 = purchaselist Edit
        int state = 0;
        public Form_RegFactorListItem()
        {
            InitializeComponent();
            BGW.RunWorkerAsync();
        }
        /// <summary>
        /// State برای حالت ویرایش و مشاهده
        /// </summary>
        /// <param name="_ViewFactor"></param>
        public Form_RegFactorListItem(int FactorID)
        {
            InitializeComponent();
            GetFactor(FactorID);
            Text = "ویرایش فاکتور";
            state = 1;
            Btn_Register.Text = "ویرایش";
            BGW.RunWorkerAsync();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="FactorID"></param>
        public Form_RegFactorListItem(int PurchaseListID, int FactorID)
        {
            InitializeComponent();
            GetFactor(PurchaseListID, FactorID);
            Text = "ویرایش فاکتور";
            state = 3;
            Btn_Register.Text = "ویرایش";
            BGW.RunWorkerAsync();
        }
        /// <summary>
        /// State برای حالت ثبت فاکتور برای تنحواه
        /// </summary>
        /// <param name="_ViewFactor"></param>
        public Form_RegFactorListItem(PurchaseList Purchase)
        {
            InitializeComponent();
            _Purchase = Purchase;
            state = 2;
            Text = Text + " " + "برای لیست تنخواه";
            BGW.RunWorkerAsync();
        }
        private void GetFactor(int PurchaseListID, int FactorID)
        {
            try
            {
                _Factor = (from V in db.Factors.Include("Factor_Items") where V.FactorID == FactorID && V.PurchaseListID == PurchaseListID select V).FirstOrDefault();
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show(SqlServerErrorManagment.ShowError(ex, "ارزش افزوده"), "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            }
        }

        private void GetFactor(int FactorID)
        {
            try
            {
                _Factor = (from V in db.Factors.Include("Factor_Items") where V.FactorID == FactorID select V).FirstOrDefault();
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show(SqlServerErrorManagment.ShowError(ex, "ارزش افزوده"), "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            }
        }
        private void Btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ChekVAX_CheckedChanged(object sender, EventArgs e)
        {
            if (ChekVAX.Checked == true)
            {
                lblFactorPrice.Text = "قیمت فاکتور به احتساب مالیات بر ارزش افزوده :";
                txtVAX.Visible = true;
                label4.Visible = true;
            }
            else
            {
                lblFactorPrice.Text = "قیمت فاکتور :";
                txtVAX.Visible = false;
                label4.Visible = false;
            }
            ComputeVAX();
        }
        /// <summary>
        /// ذخیره ی ردیف فعلی
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GridFactorReg_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            _Row = e.RowIndex;
        }
        /// <summary>
        /// محاسبه ی قیمت کالایی که اطلاعات آن تکمیل شده
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GridFactorReg_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (_Row != e.RowIndex)
                    if (GridFactorReg.Rows[_Row].Cells[2].Value != null && GridFactorReg.Rows[_Row].Cells[3].Value != null)
                    {
                        ComputePrice();
                    }

                _Row = e.RowIndex;
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show(SqlServerErrorManagment.ShowError(ex, "فاکتور"), "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GridFactorReg_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 5)
                {
                    RemoveRow_UpdateTotalPrice(e.RowIndex);
                    UpdateRowsCount(e.RowIndex, GridFactorReg.Rows.Count);
                }
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show(SqlServerErrorManagment.ShowError(ex, "فاکتور"), "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// تابع حذف کالای انتخابی
        /// </summary>
        /// <param name="Rowindex"></param>
        private void RemoveRow_UpdateTotalPrice(int Rowindex)
        {
            try
            {
                if (GridFactorReg.Rows.Count != Rowindex + 1)
                {
                    if (GridFactorReg.Rows[_Row].Cells[4].Value != null)
                        _TotalPrice = _TotalPrice - utility.ConvertCommaPrice(GridFactorReg.Rows[Rowindex].Cells[4].Value.ToString());
                    GridFactorReg.Rows.Remove(GridFactorReg.Rows[Rowindex]);
                }
                ComputeVAX();

            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show(SqlServerErrorManagment.ShowError(ex, "فاکتور"), "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// به روز شدن شماره های گرید
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        private void UpdateRowsCount(int p1, int p2)
        {
            try
            {
                for (int i = p1; i < p2; i++)
                {
                    GridFactorReg.Rows[i].Cells[0].Value = i + 1;
                }

            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show(SqlServerErrorManagment.ShowError(ex, "فاکتور"), "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// برای ویرگول گذاشتن قیمت ها
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GridFactorReg_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                long Price;
                if (e.ColumnIndex == 2)
                {
                    if (e.Value != null)
                        Price = utility.ConvertCommaPrice(e.Value.ToString());
                    else
                        Price = Convert.ToInt64(e.Value);
                    e.Value = Price.ToString("###,###", CultureInfo.InvariantCulture);
                    e.FormattingApplied = true;
                }
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show(SqlServerErrorManagment.ShowError(ex, "فاکتور"), "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// عکس دیلیت
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GridFactorReg_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 5 && e.RowIndex != -1)
                {
                    e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                    e.Graphics.DrawImage(Properties.Resources.del, e.CellBounds.Left + 5, e.CellBounds.Top);
                    e.Handled = true;
                }
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show(SqlServerErrorManagment.ShowError(ex, "فاکتور"), "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// محاسبه قیمت فاکتور
        /// </summary>
        private void ComputePrice()
        {
            try
            {
                long mablagh = utility.ConvertCommaPrice(GridFactorReg.Rows[_Row].Cells[2].Value.ToString());
                long tedad = Convert.ToInt32(GridFactorReg.Rows[_Row].Cells[3].Value.ToString());
                long Price = mablagh * tedad;
                if (GridFactorReg.Rows[_Row].Cells[4].Value != null)
                {
                    _TotalPrice = _TotalPrice - utility.ConvertCommaPrice(GridFactorReg.Rows[_Row].Cells[4].Value.ToString());
                }
                GridFactorReg.Rows[_Row].Cells[4].Value = utility.ConvertPrice(Price);
                _TotalPrice += Price;
                ComputeVAX();

            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show(SqlServerErrorManagment.ShowError(ex, "فاکتور"), "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// محاسبه مقدار مالیات بر ارزش افزوده فاکتور و به روز شدن هزینه کلی فاکتور
        /// </summary>
        private void ComputeVAX()
        {
            try
            {
                if (txtVAX.Visible == true)
                {
                    long VAXpric = Convert.ToInt64((_TotalPrice) * (_VAX / 100));
                    txtVAX.Text = utility.ConvertPrice(VAXpric.ToString());
                    long i = Convert.ToInt64(_TotalPrice + VAXpric);
                    txtTotalCost.Text = utility.ConvertPrice(i.ToString());
                }
                else
                {
                    txtTotalCost.Text = utility.ConvertPrice(_TotalPrice.ToString());
                }

            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show(SqlServerErrorManagment.ShowError(ex, "فاکتور"), "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// لود فرم
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form_RegFactorListItem_Load(object sender, EventArgs e)
        {
            GridFactorReg.Rows[0].Cells[0].Value = 1;
            DataSet();
        }

        private void DataSet()
        {
            Datepicker.GeoDate = DateTime.Now;
        }

        private void BGW_DoWork(object sender, DoWorkEventArgs e)
        {
            GetProject();
        }
        /// <summary>
        /// خواندن پروژه ها از دیتا بیس
        /// </summary>
        private void GetProject()
        {
            try
            {
                _project = (from V in db.Projects
                            where V.isActive == true
                            select V).ToList<Project>();
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show(SqlServerErrorManagment.ShowError(ex, "پروژه"), "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// اعمال پایانی BackGroundWorker
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BGW_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (FillComboProject())
                if (GetVAX())
                {
                    if (state == 1 || state == 3)
                        ShowFactorInformation();
                }
        }
        /// <summary>
        /// پر کردن کمبو باکس پروژه
        /// </summary>
        private bool FillComboProject()
        {
            try
            {
                ComboProject.DataSource = _project;
                ComboProject.DisplayMember = "ProjectName";
                ComboProject.ValueMember = "ProjectID";
                if (ComboProject.Items.Count == 0)
                {
                    if (MessageBox.Show("برای ثبت فاکتور باید پروژه ثبت شده باشد \n آیا مایل به ثبت پروژه می باشید؟", "سوال", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {
                        this.Close();
                        return false;
                    }
                    else
                    {
                        Form_RegisterProject F = new Form_RegisterProject();
                        F.ShowDialog();
                        GetProject();
                        return FillComboProject();
                    }
                }
                else
                    return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }
        private void ShowFactorInformation()
        {
            try
            {
                foreach (var Item in _Factor.Factor_Items)
                {
                    GridFactorReg.Rows.Add(GridFactorReg.Rows.Count, Item.Description, utility.ConvertPrice(Item.SoldPrice), Item.Qty, utility.ConvertPrice(Item.Qty * Item.SoldPrice));
                }
                ComboProject.SelectedValue = _Factor.ProjectID;
                //ComboSeller.SelectedValue = _Factor.SellerID;
                Datepicker.GeoDate = _Factor.Date;
                txtDescription.Text = _Factor.Description;
                txtFactorNumber.Text = _Factor.FactorNumber;
                if (_Factor.VAXPrice != 0)
                {
                    ChekVAX.Checked = true;
                    txtVAX.Text = utility.ConvertPrice(_Factor.VAXPrice);
                }
                txtTotalCost.Text = utility.ConvertPrice(_Factor.TotalPrice);
                _TotalPrice = _Factor.TotalPrice - _Factor.VAXPrice;

            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show(SqlServerErrorManagment.ShowError(ex, "فاکتور"), "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// خواندن VAX از دیتا بیس
        /// </summary>
        private bool GetVAX()
        {
            try
            {

                Percentage VAX = (from V in db.Percentages
                                  where V.name == "VAX"
                                  select V).FirstOrDefault();
                if (VAX == null)
                {
                    if (MessageBox.Show("برای ثبت فاکتور باید مالیات بر ارزش افزوده ثبت شده باشد \n آیا مایل به ثبت مالیات بر ارزش افزوده می باشید؟", "سوال", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {
                        BGW.Dispose();
                        this.Close();
                        return false;
                    }
                    else
                    {
                        Form_Setting F = new Form_Setting();
                        F.TabControlSetting.SelectTab(1);
                        F.TxtVAXDigit.Focus();
                        F.ShowDialog();
                        return GetVAX();
                    }
                }
                else
                {
                    _VAX = VAX.Precent;
                    return true;
                }
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show(SqlServerErrorManagment.ShowError(ex, "ارزش افزوده"), "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                return false;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        /// <summary>
        /// تابع پاک کردن اطلاعات فاکتور قبلی
        /// </summary>
        private void Clear()
        {
            try
            {
                ChekVAX.Checked = false;
                GridFactorReg.Rows.Clear();
                _TotalPrice = 0;
                _Row = 0;
                txtFactorNumber.Text = "";
                txtDescription.Text = "";
                txtVAX.Text = "0";
                txtTotalCost.Text = "0";

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_New_Click(object sender, EventArgs e)
        {
            Clear();
        }
        /// <summary>
        /// چک کردن خطا های فرم برای ثبت فاکتور
        /// </summary>
        /// <returns></returns>
        private bool CheckError()
        {
            //try
            //{
            GridFactorReg.Rows[GridFactorReg.Rows.Count - 1].Cells[0].Selected = true;
            if (txtFactorNumber.Text == "")
            {
                txtFactorNumber.Select();
                return false;
            }
            if (GridFactorReg.Rows.Count == 1)
            {
                utility.Show_Message("برای ثبت فاکتور کالایی ثبت کنید", "خطا");
                GridFactorReg.Select();
                GridFactorReg.Rows[0].Cells[1].Selected = true;
                return false;
            }
            for (int i = 0; i < GridFactorReg.Rows.Count - 1; i++)
            {
                if (GridFactorReg.Rows[i].Cells[1].Value == null)
                {
                    GridFactorReg.Rows[i].Cells[1].Selected = true;
                    utility.Show_Message("شرح کالا نمیتواند خالی باشد", "خطا");
                    return false;
                }
                if (GridFactorReg.Rows[i].Cells[2].Value == null)
                {
                    GridFactorReg.Rows[i].Cells[2].Selected = true;
                    utility.Show_Message("مبلغ کالا نمیتواند خالی باشد", "خطا");
                    return false;
                }
                if (GridFactorReg.Rows[i].Cells[3].Value == null)
                {
                    GridFactorReg.Rows[i].Cells[3].Selected = true;
                    utility.Show_Message("تعداد کالا نمیتواند خالی باشد", "خطا");
                    return false;
                }
                if (utility.ConvertCommaPrice(GridFactorReg.Rows[i].Cells["UnitPrice"].Value.ToString()) == 0)
                {
                    GridFactorReg.Rows[i].Cells[2].Selected = true;
                    utility.Show_Message("مبلغ کالا نمیتواند صفر باشد", "خطا");
                    return false;
                }
                if (Convert.ToInt32(GridFactorReg.Rows[i].Cells[3].Value) == 0)
                {
                    GridFactorReg.Rows[i].Cells[3].Selected = true;
                    utility.Show_Message("تعداد کالا نمیتواند صفر باشد", "خطا");
                    return false;
                }
            }
            return true;

            //}
            //catch (Exception)
            //{
            //    return false;
            //}

        }

        private void Btn_Register_Click(object sender, EventArgs e)
        {
            //try
            //{
            if (CheckError())
            {
                if (state == 0 || state == 2)
                {
                    if (RegisterFactor())
                    {
                        utility.Show_Message("اطلاعات این فاکتور با موفقیت ثبت شد", "ثبت");
                        Clear();
                    }
                }
                if (state == 1 || state == 3)
                {
                    UpdateFactor();
                }
            }

            //}
            //catch (DbUpdateException ex)
            //{
            //    MessageBox.Show(SqlServerErrorManagment.ShowError(ex, "ارزش افزوده"), "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
        /// <summary>
        /// ثبت یک فاکتور
        /// </summary>
        /// <returns></returns>
        private bool RegisterFactor()
        {
            //try
            //{
            _NewID = Convert.ToInt32(DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString() + DateTime.Now.Millisecond.ToString());
            string VAXPrice;
            if (ChekVAX.Checked == true)
            {
                VAXPrice = txtVAX.Text.Trim();
            }
            else
            {
                VAXPrice = "0";
            }
            string Des = "ندارد";
            if (txtDescription.Text != "")
            {
                Des = txtDescription.Text;
            }
            DateTime DD = Convert.ToDateTime(Datepicker.GeoDate);
            DateTime D = new DateTime(DD.Year, DD.Month, DD.Day, DateTime.Now.Hour, DateTime.Now.Minute, 0);
            Factor NewFactor = new Factor()
            {
                FactorID = _NewID,
                FactorNumber = txtFactorNumber.Text.ToString().Trim(),
                Date = D,
                TotalPrice = utility.ConvertCommaPrice(txtTotalCost.Text),
                VAX = _VAX,
                VAXPrice = utility.ConvertCommaPrice(VAXPrice),
                Description = Des,
            };
            int projeID = Convert.ToInt32(ComboProject.SelectedValue);
            NewFactor.Project = db.Projects.First(p => p.ProjectID == projeID);
            if (state == 2)
                NewFactor.PurchaseListID = _Purchase.PurchaseListID;
            db.Factors.Add(NewFactor);
            db.SaveChanges();
            if (MessageBox.Show("آیا میخواهید اطلاعات این پرداخت ثبت شود؟", "سوال", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Form_Payment FP = new Form_Payment(NewFactor);
                FP.ShowDialog();
            }
            if (!RegisterFactorItems())
            {
                db.Factors.Remove(NewFactor);
                utility.Show_Message("ثبت فاکتور انجام نشد", "خطا");
                return false;
            }
            return true;
            //}
            //catch (DbUpdateException ex)
            //{
            //    MessageBox.Show(SqlServerErrorManagment.ShowError(ex, "فاکتور"), "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return false;
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return false;
            //}
        }
        /// <summary>
        /// تابع ثبت اقلام فاکتور
        /// </summary>
        /// <returns></returns>
        private bool RegisterFactorItems()
        {
            //try
            //{
            for (int i = 0; i < GridFactorReg.Rows.Count - 1; i++)
            {
                Factor_Item F = new Factor_Item()
                {
                    Description = GridFactorReg.Rows[i].Cells[1].Value.ToString(),
                    SoldPrice = utility.ConvertCommaPrice(GridFactorReg.Rows[i].Cells[2].Value.ToString()),
                    Qty = Convert.ToInt32(GridFactorReg.Rows[i].Cells[3].Value.ToString()),
                    FactorID = _NewID,
                    Tprice = utility.ConvertCommaPrice(GridFactorReg.Rows[i].Cells[4].Value.ToString())
                };
                db.Factor_Items.Add(F);
            }
            db.SaveChanges();
            return true;
            //}
            //catch (DbUpdateException ex)
            //{
            //    MessageBox.Show(SqlServerErrorManagment.ShowError(ex, "اقلام فاکتور"), "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return false;
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return false;
            //}
        }
        /// <summary>
        /// به روز شدن یک فاکتور
        /// </summary>
        private void UpdateFactor()
        {
            //try
            //{
            if (ChekVAX.Checked == true)
            {
                _Factor.VAXPrice = utility.ConvertCommaPrice(txtVAX.Text);
            }
            else
            {
                _Factor.VAXPrice = 0;
            }
            if (txtDescription.Text != "")
            {
                _Factor.Description = txtDescription.Text;
            }
            else
            {
                _Factor.Description = "ندارد";
            }
            _Factor.FactorNumber = txtFactorNumber.Text.ToString().Trim();
            DateTime DD = Convert.ToDateTime(Datepicker.GeoDate);
            DateTime D = new DateTime(DD.Year, DD.Month, DD.Day, DateTime.Now.Hour, DateTime.Now.Minute, 0);
            _Factor.Date = D;
            _Factor.TotalPrice = utility.ConvertCommaPrice(txtTotalCost.Text);
            int projeID = Convert.ToInt32(ComboProject.SelectedValue);
            _Factor.Project = db.Projects.First(p => p.ProjectID == projeID);
            //int SellerID = Convert.ToInt32(ComboSeller.SelectedValue);
            //_Factor.Seller = db.Sellers.First(p => p.SellerID == SellerID);
            _Factor.VAX = _VAX;
            //if (state == 1)
            //{
            //    if (_Factor.ProjectID != projeID)
            //    {
            //        //_Factor.Checks = SpecialUtility.ChangeProjectChecks(_Factor.Checks, projeID, ComboSeller.Text);
            //    }
            //}
            var items = (from V in db.Factor_Items
                         where V.FactorID == _Factor.FactorID
                         select V).ToList<Factor_Item>();
            _Factor.Factor_Items.Clear();
            db.Factor_Items.RemoveRange(items);
            for (int i = 0; i < GridFactorReg.Rows.Count - 1; i++)
            {
                Factor_Item F = new Factor_Item()
                {
                    Description = GridFactorReg.Rows[i].Cells[1].Value.ToString(),
                    SoldPrice = utility.ConvertCommaPrice(GridFactorReg.Rows[i].Cells[2].Value.ToString()),
                    Qty = Convert.ToInt32(GridFactorReg.Rows[i].Cells[3].Value.ToString()),
                    FactorID = _Factor.FactorID,
                    Tprice = utility.ConvertCommaPrice(GridFactorReg.Rows[i].Cells[4].Value.ToString())
                };
                db.Factor_Items.Add(F);
            }
            //if (state == 1)
            //{
            //    FormCheck FC = new FormCheck(_Factor);
            //    FC.ShowDialog();
            //    if (!FC.GetStatusFactorState())
            //        return;
            //    _CheckList = FC.GetRegCheckList();
            //    if (_CheckList.Count == 0)
            //    {
            //        Utility.ShowNotification("خطا", "شما هیچ چکی برای این هزینه ثبت نکردید ، توجه کنید که در صورتی می توانید این هزینه را ثبت کنید که چک های صادر شده را ثبت کنید", Utility.Icons.Information, 3000);
            //        return;
            //    }
            //    else
            //    {
            //        foreach (var item in _CheckList)
            //        {
            //            db.Checks.First(p => p.CheckID == item.CheckID).FactorID = _Factor.FactorID;
            //        }
            //    }
            //    db.SaveChanges();
            //}
            db.SaveChanges();
            utility.Show_Message("فاکتور با موفقیت ویرایش شد", "پیغام عملیات");
            //}
            //catch (DbUpdateException ex)
            //{
            //    MessageBox.Show(SqlServerErrorManagment.ShowError(ex, "فاکتور"), "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void GridFactorReg_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            try
            {
                GridFactorReg.Rows[GridFactorReg.Rows.Count - 1].Cells[0].Value = GridFactorReg.Rows.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GridFactorReg_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (ChekRow())
                {
                    if (GridFactorReg.CurrentCell.ColumnIndex == 4 && GridFactorReg.Rows.Count > GridFactorReg.CurrentCell.RowIndex + 1)
                    {
                        ComputePrice();
                        GridFactorReg.Rows[GridFactorReg.CurrentCell.RowIndex + 1].Cells[1].Selected = true;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GridFactorReg_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            try
            {
                TextBox text = e.Control as TextBox;
                if (GridFactorReg.CurrentCell.ColumnIndex == GridFactorReg.Columns["UnitPrice"].Index || GridFactorReg.CurrentCell.ColumnIndex == GridFactorReg.Columns["Count"].Index)
                {
                    if (!flag)
                    {
                        text.KeyPress += new KeyPressEventHandler(txtTotalCost_KeyPress);
                        flag = true;
                    }
                }
                else
                    if (flag)
                    {
                        text.KeyPress -= new KeyPressEventHandler(txtTotalCost_KeyPress);
                        flag = false;
                    }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtTotalCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
                    e.Handled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// تابع چک کردن خطاهای کالای درحال ثبت
        /// </summary>
        /// <returns></returns>
        private bool ChekRow()
        {
            try
            {
                if (GridFactorReg.Rows[GridFactorReg.CurrentCell.RowIndex].Cells[0].Selected == true)
                {
                    GridFactorReg.Rows[GridFactorReg.CurrentCell.RowIndex].Cells[1].Selected = true;
                    return false;
                }
                if (GridFactorReg.Rows[GridFactorReg.CurrentCell.RowIndex].Cells[1].Value == null)
                {
                    GridFactorReg.Rows[GridFactorReg.CurrentCell.RowIndex].Cells[1].Selected = true;
                    utility.Show_Message("شرح کالا نمیتواند خالی باشد", "هشدار");
                    return false;
                }
                if (GridFactorReg.Rows[GridFactorReg.CurrentCell.RowIndex].Cells[2].Value == null)
                {
                    GridFactorReg.Rows[GridFactorReg.CurrentCell.RowIndex].Cells[2].Selected = true;
                    utility.Show_Message("قیمت واحد نمیتواند خالی باشد ", "هشدار");
                    return false;
                }
                if (GridFactorReg.Rows[GridFactorReg.CurrentCell.RowIndex].Cells[3].Value == null)
                {
                    GridFactorReg.Rows[GridFactorReg.CurrentCell.RowIndex].Cells[3].Selected = true;
                    utility.Show_Message("تعداد نمیتواند خالی باشد ", "هشدار");
                    return false;
                }
                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }

        private void txtFactorNumber_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar)
    && !char.IsDigit(e.KeyChar)
    && e.KeyChar != '.')
            {
                e.Handled = true;
            }

        }



    }
}
