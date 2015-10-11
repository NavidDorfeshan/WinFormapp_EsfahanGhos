using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using EsfahanGhos.DataLayer;
using EsfahanGhos.Model;

namespace EsfahanGhos
{
    public partial class Form_CreditTankhah : Telerik.WinControls.UI.RadForm
    {
        long Pr;
        string Price = "";
        Corporation db = new Corporation();
        List<Tankhah> ListTankhah = null;
        List<Credit> CreditList = new List<Credit>();
        int Row = -1;
        public Form_CreditTankhah()
        {
            InitializeComponent();
        }

        private void Btn_CLose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Txt_Price_TextChanged(object sender, EventArgs e)
        {
            if (Txt_Price.Text.Trim() != "")
            {
                if (Txt_Price.Text != Price)
                {
                    Pr = utility.ConvertCommaPrice(Txt_Price.Text.Trim());
                    if (Pr != -1)
                    {
                        Price = utility.ConvertPrice(Pr);
                        Txt_Price.Text = Price;
                    }
                    Txt_Price.Select(Txt_Price.Text.Length, 0);
                }
            }
        }

        private void Txt_Price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
        private void DataSetDateTime()
        {
            Date.GeoDate = DateTime.Now;
        }
        private void Form_CreditTankhah_Load(object sender, EventArgs e)
        {
            BGW.RunWorkerAsync();
            DataSetDateTime();
        }

        private void BGW_DoWork(object sender, DoWorkEventArgs e)
        {
            GetData();
        }

        private void GetData()
        {
            try
            {
                ListTankhah = db.Tankhahs.Include("Credits").Where(p => p.TankhahID != 0).ToList<Tankhah>();
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show(SqlServerErrorManagment.ShowError(ex, "تنخواه"), "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BGW_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ShowDataInCombo();
        }

        private void ShowDataInCombo()
        {
            //try
            //{
            if (ListTankhah.Count != 0)
            {
                Combo_Tankhah.ValueMember = "TankhahID";
                Combo_Tankhah.DisplayMember = "TankhahName";
                Combo_Tankhah.DataSource = ListTankhah;
                Combo_Tankhah.SelectedIndex = -1;
            }
            else
            {
                while (MessageBox.Show("شما هنوز هیچ تنخواهی ثبت نکرده اید ، آیا مایل به ثبت تنخواه هستید ؟", "پیغام", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) == DialogResult.Yes)
                {
                    Form_RegTankhah FT = new Form_RegTankhah();
                    FT.ShowDialog();
                    GetData();
                    if (ListTankhah.Count != 0)
                    {
                        GetData();
                        ShowDataInCombo();
                        return;
                    }
                }
                this.Close();
            }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void Combo_Tankhah_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            //try
            //{
            if (Combo_Tankhah.SelectedIndex != -1)
            {
                Grid_Credit.Rows.Clear();
                Btn_RegCredit.Enabled = true;
                GetAllCreditsOfSelectedTankhah();
                ShowDataInGrid();
            }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
        /// <summary>
        /// گرفتن اعتبارات مربوط به تنخواه
        /// </summary>
        private void GetAllCredits()
        {
            //try
            //{
            if (ListTankhah.Count != -1)
            {
                int ID = Convert.ToInt32(Combo_Tankhah.SelectedItem.Value);
                Tankhah T = ListTankhah.FirstOrDefault(p => p.TankhahID == ID);
                CreditList.Clear();
                if (T.Credits.Count != -1)
                {
                    CreditList = T.Credits.OrderByDescending(p => p.DateCredit).ToList();
                }
            }
            //}
            //catch (DbUpdateException ex)
            //{
            //    MessageBox.Show(SqlServerErrorManagment.ShowError(ex, "تنخواه"), "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
        /// <summary>
        /// ذخیره تمام اعتبارات در لیست
        /// </summary>
        private void GetAllCreditsOfSelectedTankhah()
        {
            //try
            //{
            if (ListTankhah.Count != 0)
            {
                int CmbTankhahID = Convert.ToInt32(Combo_Tankhah.SelectedValue);
                Tankhah TankhahCreditList = (from C in db.Tankhahs.Include("Credits")
                                             where C.TankhahID == CmbTankhahID
                                             select C).FirstOrDefault();
                CreditList.Clear();
                if (TankhahCreditList.Credits.Count != 0)
                    CreditList = TankhahCreditList.Credits.OrderByDescending(p => p.DateCredit).Take(20).ToList();
            }
            //}
            //catch (DbUpdateException ex)
            //{
            //    MessageBox.Show(SqlServerErrorManagment.ShowError(ex, "اعتبارات"), "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            //}
        }
        /// <summary>
        /// پرکردن گرید
        /// </summary>
        private void ShowDataInGrid()
        {
            //try
            //{
            GridListCredits.AutoGenerateColumns = false;
            GridListCredits.Rows.Clear();
            int i = 0;
            foreach (var item in CreditList)
            {
                GridListCredits.Rows.Add();
                if (item.Type == "+")
                {
                    GridListCredits.Rows[i].DefaultCellStyle.BackColor = Color.LightGreen;
                }
                else
                {
                    GridListCredits.Rows[i].DefaultCellStyle.BackColor = Color.PaleVioletRed;
                }
                GridListCredits.Rows[i].Cells["Date1"].Value = item.DateCredit;
                GridListCredits.Rows[i].Cells["ShamsiDate"].Value = utility.ConvertDate_M_To_Sh(item.DateCredit);
                GridListCredits.Rows[i].Cells["Value"].Value = utility.ConvertPrice(item.Price);
                GridListCredits.Rows[i++].Cells["CreditID"].Value = item.CreditID;
            }
            if (GridListCredits.Rows.Count != 0)
                GridListCredits.CurrentRow.Selected = false;
            List<Credit> LC = db.Credits.ToList<Credit>();

            long P = 0;
            foreach (var item in LC.Where(p => p.TankhahID == Convert.ToInt32(Combo_Tankhah.SelectedValue)))
            {
                if (item.Type == "+") P += item.Price;
                else P -= item.Price;
            }
            Txt_CurrentCredit.Text = utility.ConvertPrice(P.ToString());
            //utility.ConvertPrice(ListTankhah.FirstOrDefault(p => p.TankhahID == Convert.ToInt32(Combo_Tankhah.SelectedValue)).CreditCurrent.ToString());
            //}
            //catch (DbUpdateException ex)
            //{
            //    MessageBox.Show(SqlServerErrorManagment.ShowError(ex, "تنخواه"), "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void Btn_RegCredit_Click(object sender, EventArgs e)
        {
            if (Txt_Price.Text.Trim() == "")
            {
                MessageBox.Show("لطفا فیلد مربوط به اعتبار را وارد نمایید", "خطا در هنگام ثبت اعتبار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            RegCredit();
        }

        private void RegCredit()
        {
            //try
            //{
            Credit C = new Credit()
            {
                Type = "+",
                Price = utility.ConvertCommaPrice(Txt_Price.Text.Trim()),
                DateCredit = Date.GeoDate.Value,
                CreditID = utility.CreatedNewID(),
                Description = Txt_Description.Text.Trim()
            };
            C.TankhahID = Convert.ToInt32(Combo_Tankhah.SelectedValue);
            db.Credits.Add(C);
            db.SaveChanges();
            int ID = Convert.ToInt32(Combo_Tankhah.SelectedValue);
            db.Tankhahs.Single(p => p.TankhahID == ID).CreditCurrent += utility.ConvertCommaPrice(Txt_Price.Text.Trim());
            db.SaveChanges();
            utility.Show_Message(" این اعتبار با موفقیت ثبت شد", "ثبت");
            FormDefult();
            if (MessageBox.Show("آیا میخواهید اطلاعات این پرداخت ثبت شود؟", "سوال", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Form_Payment FP = new Form_Payment(C);
                FP.ShowDialog();
            }
            //}
            //catch (DbUpdateException ex)
            //{
            //    MessageBox.Show(SqlServerErrorManagment.ShowError(ex, "تنخواه"), "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void FormDefult()
        {
            GetData();
            ShowDataInGrid();
            GetAllCredits();
            ShowDataInCombo();
            Date.GeoDate = DateTime.Now;
            Btn_RegCredit.Enabled = true;
            Btn_Delete.Enabled = false;
            Txt_Price.Text = Txt_Description.Text = "";
        }
        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            Del();
        }

        private void Del()
        {
            //try
            //{
            if (MessageBox.Show("آیا میخواهید این اعتبار تخصیص یافته را پاک نمایید ؟", "سوال", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int IDC = Convert.ToInt32(Grid_Credit.Rows[Row].Cells["CreditID"].Value);
                db.Credits.Remove(db.Credits.FirstOrDefault(p => p.CreditID == IDC));
                int IDT = db.Credits.FirstOrDefault(p => p.CreditID == IDC).TankhahID;
                db.Tankhahs.FirstOrDefault(p => p.TankhahID == IDT).CreditCurrent -= db.Credits.FirstOrDefault(p => p.CreditID == IDC).Price;
                db.SaveChanges();
                utility.Show_Message(" این اعتبار با موفقیت حذف شد", "حذف");
                FormDefult();
            }
            //}
            //catch (DbUpdateException ex)
            //{
            //    MessageBox.Show(SqlServerErrorManagment.ShowError(ex, "تنخواه"), "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void GridListCredits_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                Row = e.RowIndex;
                int SelectedCreditID;
                int CmbTankhahID = Convert.ToInt32(Combo_Tankhah.SelectedValue);
                int CmbTankhahIndex = Combo_Tankhah.SelectedIndex;
                int GridSelectedIndex = e.RowIndex;
                if (GridListCredits.Rows[e.RowIndex].DefaultCellStyle.BackColor != Color.PaleVioletRed)
                    SelectedCreditID = Convert.ToInt32(GridListCredits.Rows[GridSelectedIndex].Cells["CreditID"].Value);
                else
                    SelectedCreditID = -1;
                var credit = db.Credits.SingleOrDefault(p => p.CreditID == SelectedCreditID);
                Date.GeoDate = credit.DateCredit;
                Txt_Description.Text = credit.Description;
                Txt_Price.Text = utility.ConvertPrice(credit.Price);
                Btn_Delete.Enabled = true;

                //else if (SelectedCreditID != -1)
                //{
                //    //All checks
                //    Credit SelectedCeredit = (from C in db.Credits.Include("Checks")
                //                              where C.CreditID == SelectedCreditID
                //                              select C).FirstOrDefault();
                //    long Oldvalue = SelectedCeredit.Price;
                //    long NewValue = 0;
                //    ////Check form
                //    //FormCheck FC = new FormCheck(SelectedCeredit);
                //    //FC.ShowDialog();
                //    //db = new MyDataBase();
                //    ////New registered checks
                //    //var checks = (from C in db.Checks
                //    //              where C.CreditID == SelectedCreditID
                //    //              select C).ToList<Check>();
                //    ////calculating new value
                //    if (checks.Count != 0)
                //    {
                //        foreach (var item in checks)
                //        {
                //            NewValue += item.Price;
                //        }
                //        db.Credits.First(p => p.CreditID == SelectedCreditID).Value = NewValue;
                //        db.Tankhahs.First(p => p.TankhahID == CmbTankhahID).CurrentCredit += NewValue - Oldvalue;
                //        db.SaveChanges();
                //        FormDefaults();
                //        CmbTankhah.SelectedIndex = CmbTankhahIndex;
                //    }
                //else
                //{
                //    db.Tankhahs.First(p => p.TankhahID == CmbTankhahID).CreditCurrent -= Oldvalue;
                //    db.SaveChanges();
                //    FormDefult();
                //    Combo_Tankhah.SelectedIndex = CmbTankhahIndex;
                //}
            }

        }
    }
}

