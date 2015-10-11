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
    public partial class Form_RegTankhah : Telerik.WinControls.UI.RadForm
    {
        Corporation db = new Corporation();
        string num = "";
        int Row = -1;
        List<Tankhah> ListTankhah = null;
        List<PhoneBook> ListTels = null;
        public Form_RegTankhah()
        {
            InitializeComponent();
        }
        private void Txt_Tel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
        /// <summary>
        /// شماره تلفن
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Txt_Tel_TextChanged(object sender, EventArgs e)
        {
            if (Txt_Tel.TextLength < 12)
            {
                num = Txt_Tel.Text.Trim();
            }
            Txt_Tel.Text = num;
            Txt_Tel.Select(Txt_Tel.Text.Length, 0);
        }
        /// <summary>
        /// نام و نام خانوادگی 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Txt_FName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar <= '9' && e.KeyChar >= '0')
            {
                e.Handled = true;
            }
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private string MakeID()
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
            return strID;
        }
        private void Clear()
        {
            Txt_FName.Text = Txt_Tel.Text = "";
            listBox_Tels.Items.Clear();
        }
        private void BGW_DoWork(object sender, DoWorkEventArgs e)
        {
            GetData();
        }

        private void GetData()
        {
            try
            {
                ListTankhah = db.Tankhahs.Where(p => p.TankhahID != 0).ToList<Tankhah>();
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
            pictureBox1.Visible = false;
            ShowData();
        }

        private void ShowData()
        {
            try
            {
                GridTankhah.AutoGenerateColumns = false;
                GridTankhah.DataSource = ListTankhah;
                foreach (var item in GridTankhah.Rows)
                {
                    long P=Convert.ToInt64(item.Cells[0].Value);
                    item.Cells["CreditCurrent"].Value = utility.ConvertPrice(ListTankhah.FirstOrDefault(p=>p.TankhahID==P).CreditCurrent);
                }
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

        private void Form_RegTankhah_Load(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            BGW.RunWorkerAsync();
        }
        private void Btn_AddTel_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (var item in listBox_Tels.Items)
                {
                    if (Txt_Tel.Text == item.ToString())
                    {
                        MessageBox.Show("حرفه ی وارد شده تکراری می باشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                listBox_Tels.Items.Add(Txt_Tel.Text.Trim());
                Txt_Tel.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_DelTel_Click(object sender, EventArgs e)
        {
            try
            {
                int n = listBox_Tels.SelectedIndex;
                if (n == -1)
                {
                    if (listBox_Tels.Items.Count == 0)
                        MessageBox.Show("هیچ شماره تلفنی وارد نشده است", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        MessageBox.Show("لطفا برای حذف از لیست شماره تلفنی را انتخاب کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (n == 0 && listBox_Tels.Items.Count != 1)
                    {
                        listBox_Tels.SelectedIndex = 0;
                    }
                }
                else
                {
                    listBox_Tels.Items.RemoveAt(n);
                    if (n != 0 || listBox_Tels.Items.Count == 0)
                    {
                        listBox_Tels.SelectedIndex = n - 1;
                    }
                    else
                        listBox_Tels.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Btn_Register_Click(object sender, EventArgs e)
        {
            if (Txt_FName.Text.Trim() == "" || listBox_Tels.Items.Count == 0)
            {
                MessageBox.Show("لطفا فیلد های مربوطه را پر کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Register();
        }
        /// <summary>
        /// ثبت اطلاعات
        /// </summary>
        private void Register()
        {
            int ID = Convert.ToInt32(MakeID());
            try
            {
                Tankhah T = new Tankhah()
                {
                    TankhahID = ID,
                    TankhahName = Txt_FName.Text.Trim(),
                    CreditCurrent = 0
                };
                db.Tankhahs.Add(T);
                foreach (var item in listBox_Tels.Items)
                {
                    PhoneBook PB = new PhoneBook();
                    PB.PNumber = item.ToString();
                    PB.TankhahID = ID;
                    db.PhoneBooks.Add(PB);
                }
                db.SaveChanges();
                utility.Show_Message("اطلاعات این تنخواه با موفقیت ثبت شد", "ثبت");
                GetData();
                ShowData();
                Clear();
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

        private void GridTankhah_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1)
                {
                    Clear();
                    Row = e.RowIndex;
                    Btn_Register.Enabled = false;
                    Btn_Edit.Enabled = true;
                    Txt_FName.Text = GridTankhah.Rows[e.RowIndex].Cells["TankhahName"].Value.ToString();
                    int ID = Convert.ToInt32(GridTankhah.Rows[e.RowIndex].Cells["TankhahID"].Value);
                    ListTels = (from P in db.PhoneBooks
                                where P.TankhahID == ID
                                select P).ToList();
                    foreach (var item in ListTels)
                    {
                        listBox_Tels.Items.Add(item.PNumber.ToString());
                    }
                    if (e.ColumnIndex == GridTankhah.Columns["Del"].Index)
                    {
                        if (MessageBox.Show("آیا میخواهید اطلاعات این تنخواه حذف شود؟", "حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            db.Tankhahs.Remove(ListTankhah.Single(p => p.TankhahID == ID));
                            db.SaveChanges();
                            utility.Show_Message("اطلاعات این تنخواه با موفقیت حذف شد", "حذف");
                            GetData();
                            ShowData();
                            Clear();
                            Btn_Register.Enabled = true;
                            Btn_Edit.Enabled = false;
                        }
                    }
                }
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

        private void Btn_Edit_Click(object sender, EventArgs e)
        {
            if (Txt_FName.Text.Trim() == "" || listBox_Tels.Items.Count == 0)
            {
                MessageBox.Show("لطفا فیلد های مربوطه را پر کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Edit();
        }

        private void Edit()
        {
            try
            {
                int ID = Convert.ToInt32(GridTankhah.Rows[Row].Cells[0].Value);
                Tankhah T = ListTankhah.Single(p => p.TankhahID == ID);
                T.TankhahName = Txt_FName.Text.Trim();
                foreach (var item in T.PhoneBooks.ToList())
                {
                    T.PhoneBooks.Remove(item);
                }
                String s;
                foreach (Object selecteditem in listBox_Tels.Items)
                {
                    s = selecteditem as String;
                    PhoneBook t = new PhoneBook()
                    {
                        TankhahID = T.TankhahID,
                        PNumber = s,
                    };
                    db.PhoneBooks.Add(t);
                }
                db.SaveChanges();
                List<PhoneBook> ListT = db.PhoneBooks.ToList<PhoneBook>();
                foreach (var item in ListT)
                {
                    if (item.TankhahID == null && item.ContractorID == null)
                        db.PhoneBooks.Remove(item);
                }
                db.SaveChanges();
                Btn_Register.Enabled = true;
                Btn_Edit.Enabled = false;
                utility.Show_Message("اطلاعات این تنخواه با موفقیت ویرایش شد", "ویرایش");
                GetData();
                ShowData();
                Clear();
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
    }
}
