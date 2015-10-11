using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Windows.Forms;
using EsfahanGhos.DataLayer;
using EsfahanGhos.Model;
using EsfahanGhos.Temp;

namespace EsfahanGhos
{
    public partial class Form_TankhahPurchaseLists : Telerik.WinControls.UI.RadForm
    {
        /// <summary>
        /// شی از دیتا بیس
        /// </summary>
        Corporation db = new Corporation();
        /// <summary>
        /// لیست تنخواه
        /// </summary>
        IList<Tankhah> Tankhahs = null;
        /// <summary>
        /// لیست لیست خرید
        /// </summary>
        IList<PurchaseList> PurchaseLists = null;
        /// <summary>
        /// ایندکس گرید
        /// </summary>
        int GridSelectedInsdex = -1;
        public Form_TankhahPurchaseLists()
        {
            InitializeComponent();
        }
        /// <summary>
        /// واکشی تنخواه ها
        /// </summary>
        private void GetTankhahs()
        {
            try
            {
                Tankhahs = (from T in db.Tankhahs.OrderBy(p=>p.TankhahID).Skip(1)
                            select T).ToList();
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show(SqlServerErrorManagment.ShowError(ex, "چک") + "\n\n" + ex.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            }
        }

        /// <summary>
        /// نمایش کمبو تنخواه ها
        /// </summary>
        private void ShowCmbTankhahs()
        {
            CmbTankhah.DataSource = Tankhahs;
            CmbTankhah.ValueMember = "TankhahID";
            CmbTankhah.DisplayMember = "TankhahName";
            CmbTankhah.SelectedIndex = -1;
        }

        /// <summary>
        /// لود فرم
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormTankhahP_Load(object sender, EventArgs e)
        {
            BgwTankhahsP.RunWorkerAsync();
        }
        /// <summary>
        /// dowork
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Bgw_Dowork(object sender, DoWorkEventArgs e)
        {
            GetTankhahs();
        }

        /// <summary>
        /// completed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Bgw_completed(object sender, RunWorkerCompletedEventArgs e)
        {
            ShowCmbTankhahs();
            CmbTankhah.Enabled = true;
        }

        /// <summary>
        /// نمایش لیست ها
        /// </summary>
        private void ShowPurchaseLists()
        {
            try
            {
                LblNoPurchaseList.Visible = false;
                GridListPurchace.Rows.Clear();
                GridListPurchace.AutoGenerateColumns = false;
                if (CmbTankhah.SelectedIndex == 0)
                {
                    GridListPurchace.Columns["TankhahName"].Visible = true;
                    PurchaseLists = (from TP in db.PurchaseLists.Include("Tankhah").AsNoTracking()
                                     select TP).OrderByDescending(P => P.Date).Skip(1).ToList();
                    int Count = PurchaseLists.Count();
                    if (Count != 0)
                    {
                        for (int i = 0; i < Count; i++)
                        {
                            GridListPurchace.Rows.Add();
                            GridListPurchace.Rows[i].Cells["PurchaseListID"].Value = PurchaseLists[i].PurchaseListID;
                            GridListPurchace.Rows[i].Cells["TankhahName"].Value = PurchaseLists[i].Tankhah.TankhahName;
                            GridListPurchace.Rows[i].Cells["TankhahID"].Value = PurchaseLists[i].Tankhah.TankhahID;
                            GridListPurchace.Rows[i].Cells["PurchaseListNumber"].Value = PurchaseLists[i].NumberOfList;
                            GridListPurchace.Rows[i].Cells["TotalPrice"].Value = utility.ConvertPrice(PurchaseLists[i].TotalPrice.ToString());
                            GridListPurchace.Rows[i].Cells["Date"].Value = utility.ConvertDate_M_To_Sh(PurchaseLists[i].Date);
                        }
                    }
                    else
                    {
                        LblNoPurchaseList.Visible = true;
                    }
                }
                else
                {
                    int CmbValue = Convert.ToInt32(CmbTankhah.SelectedValue);
                    GridListPurchace.Columns["TankhahName"].Visible = false;
                    IList<PurchaseList> SelectedTankhahP = db.PurchaseLists.Include("Tankhah").Where(p => p.TankhahID == CmbValue).ToList().OrderByDescending(p => p.Date).ToList();
                    int Count = SelectedTankhahP.Count();
                    if (Count != 0)
                    {
                        for (int i = 0; i < Count; i++)
                        {
                            GridListPurchace.Rows.Add();
                            GridListPurchace.Rows[i].Cells["PurchaseListID"].Value = SelectedTankhahP[i].PurchaseListID;
                            GridListPurchace.Rows[i].Cells["TankhahID"].Value = SelectedTankhahP[i].Tankhah.TankhahID;
                            GridListPurchace.Rows[i].Cells["PurchaseListNumber"].Value = SelectedTankhahP[i].NumberOfList;
                            GridListPurchace.Rows[i].Cells["TotalPrice"].Value = utility.ConvertPrice(SelectedTankhahP[i].TotalPrice.ToString());
                            GridListPurchace.Rows[i].Cells["Date"].Value = utility.ConvertDate_M_To_Sh(SelectedTankhahP[i].Date);
                        }
                    }
                    else
                    {
                        LblNoPurchaseList.Visible = true;
                    }
                }
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show(SqlServerErrorManagment.ShowError(ex, "چک") + "\n\n" + ex.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطا در نمایش لیست خرید" + "\n\n" + ex.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            }
        }

        /// <summary>
        /// ایونت تغییر ایندکس کومبو
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CmbTankhahs_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowPurchaseLists();
        }


        /// <summary>
        /// ایونت کلیک حذف
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (GridSelectedInsdex != -1)
                {
                    int PSelectedID = Convert.ToInt32(GridListPurchace.Rows[GridSelectedInsdex].Cells["PurchaseListID"].Value);
                    int TankhahSelectedID = Convert.ToInt32(GridListPurchace.Rows[GridSelectedInsdex].Cells["TankhahID"].Value);
                    int? ProjectID;

                    if (MessageBox.Show("آیا لیست خرید حذف شود؟ ", "سوال", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) == DialogResult.No) return;
                    PurchaseList OldPList = db.PurchaseLists.Include("PurchaseListItems").Include("CostOfServices").Include("Credit").Include("Factors").FirstOrDefault(p => p.PurchaseListID == PSelectedID);
                    foreach (PurchaseListItem item in OldPList.PurchaseListItems)
                    {
                        ProjectID = item.ProjectID;
                        db.Projects.FirstOrDefault(p => p.ProjectID == ProjectID).TotalCost -= item.Price;
                    }
                    foreach (CostOfService COS in OldPList.CostOfServices)
                    {
                        ProjectID = COS.ProjectID;
                        db.Projects.FirstOrDefault(p => p.ProjectID == ProjectID).TotalCost -= COS.Cost;
                    }
                    foreach (Factor Factor in OldPList.Factors)
                    {
                        ProjectID = Factor.ProjectID;
                        db.Projects.FirstOrDefault(p => p.ProjectID == ProjectID).TotalCost -= Factor.TotalPrice;
                    }
                    db.Tankhahs.FirstOrDefault(p => p.TankhahID == TankhahSelectedID).CreditCurrent += OldPList.TotalPrice;
                    db.Factors.RemoveRange(OldPList.Factors);
                    db.PurchaseListItems.RemoveRange(OldPList.PurchaseListItems);
                    db.Credits.Remove(OldPList.Credit);
                    db.PurchaseLists.Remove(OldPList);
                    db.SaveChanges();
                    utility.Show_Message("لیست خرید با موفقیت حذف شد", "پیغام عملیات");
                    ShowPurchaseLists();
                }
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show(SqlServerErrorManagment.ShowError(ex, "چک") + "\n\n" + ex.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطا" + "\n\n" + ex.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            }

        }

        /// <summary>
        /// ایونت سل کلیک گرید
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GridListP_CellClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            BtnRemove.Enabled = true;
            GridSelectedInsdex = e.RowIndex;
            if (e.ColumnIndex == 4 && e.RowIndex != -1)
            {
                Print_purchaselist(e.RowIndex);
            }
        }

        /// <summary>
        /// ایونت دابل کلیک گرید
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GridListP_DoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                int PurchaseListID = Convert.ToInt32(GridListPurchace.Rows[e.RowIndex].Cells["PurchaseListID"].Value);
                Form_PurchaseList FP = new Form_PurchaseList(PurchaseListID, 1);
                FP.ShowDialog();
                ShowPurchaseLists();
            }
        }

        private void radButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GridListPurchace_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex == 4 && e.RowIndex != -1)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                e.Graphics.DrawImage(Properties.Resources.Print_icon, e.CellBounds.Left + 8, e.CellBounds.Top);
                e.Handled = true;
            }
        }

        private void Print_purchaselist(int p)
        {
            if (MessageBox.Show("آیا میخواهید این لیست را چاپ کنید ؟", "چاپ لیست تنخواه", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int PurchaseListID = Convert.ToInt32(GridListPurchace.Rows[p].Cells["PurchaseListID"].Value);
                PurchaseList GeneralPList = db.PurchaseLists.Include("Factors.Project").Include("Tankhah").Include("PurchaseListItems").Include("PurchaseListItems.Project").Include("Credit").Include("CostOfServices").Include("CostOfServices.Project").Include("CostOfServices.Contractor").FirstOrDefault(s => s.PurchaseListID == PurchaseListID);
                #region Print

                Print_purchase.Dictionary.Variables[0].Value = utility.ConvertDate_M_To_Sh(DateTime.Now);//تاریخ چاپ
                Print_purchase.Dictionary.Variables[1].Value = GeneralPList.Tankhah.TankhahName;//نام تنخواه
                Print_purchase.Dictionary.Variables[2].Value = utility.ConvertDate_M_To_Sh(GeneralPList.Date);//تاریخ لیست

                List<TempFactor> TempF = new List<TempFactor>();
                foreach (var item in GeneralPList.Factors.ToList())
                {
                    TempFactor t = new TempFactor()
                    {
                        Description = item.Description,
                        FactorNumber = item.FactorNumber,
                        TotalPrice = item.TotalPrice,
                        Date = utility.ConvertDate_M_To_Sh(item.Date),
                        ProjectName = item.Project.ProjectName
                    };
                    TempF.Add(t);
                }
                Print_purchase.RegBusinessObject("Factor", TempF);//لیست فاکتورها

                List<TempCost> ListtempCost = new List<TempCost>();
                foreach (var item in GeneralPList.CostOfServices.ToList())
                {
                    TempCost t = new TempCost()
                    {
                        Cost = item.Cost,
                        Date = utility.ConvertDate_M_To_Sh(item.Date),
                        ContractorName = item.Contractor.CName,
                        ProjectName = item.Project.ProjectName
                    };
                    ListtempCost.Add(t);
                }
                Print_purchase.RegBusinessObject("Cost", ListtempCost);//هزینه های پیمانکار

                List<TempItem> Listitem = new List<TempItem>();
                foreach (var item in GeneralPList.PurchaseListItems.ToList())
                {
                    TempItem t = new TempItem()
                    {
                        Description = item.Description,
                        Date = utility.ConvertDate_M_To_Sh(item.Date),
                        ProjectName = item.Project.ProjectName,
                        Price = item.Price
                    };
                    Listitem.Add(t);
                }
                Print_purchase.RegBusinessObject("items", Listitem);//لیست خرید های غیر متعارف
                Print_purchase.Show();
                #endregion Print
            }
            else
                return;
        }
    }
}