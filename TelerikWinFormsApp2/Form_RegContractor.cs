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
    public partial class Form_RegContractor : Telerik.WinControls.UI.RadForm
    {
        /// <summary>
        /// برای شماره تلفن
        /// </summary>
        string num = "";
        Corporation db = new Corporation();
        List<Contractor> ListContractor = null;
        int Row = -1;
        public Form_RegContractor()
        {
            InitializeComponent();
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
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
        /// <summary>
        /// باز کردن فرم ثبت حرفه
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_RegSkill_Click(object sender, EventArgs e)
        {
            Form_RegSkill RS = new Form_RegSkill();
            RS.ShowDialog();
            ShowDatainCombo();
        }
        private void Clear()
        {
            Txt_FName.Text = Txt_Tel.Text = "";
            listBox_Skill.Items.Clear();
            listBox_Tels.Items.Clear();
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

        private void BGW_DoWork(object sender, DoWorkEventArgs e)
        {
            GetData();
        }

        private void GetData()
        {
            try
            {
                ListContractor = db.Contractors.Include("Skills").Include("PhoneBooks").ToList<Contractor>();
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show(SqlServerErrorManagment.ShowError(ex, "پیمانکار"), "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BGW_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            pictureBox1.Visible = false;
            ShowDatainCombo();
            ShowDatainGrid();
        }

        private void ShowDatainGrid()
        {
            try
            {
                GridContractor.AutoGenerateColumns = false;
                GridContractor.DataSource = ListContractor;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowDatainCombo()
        {
            try
            {
                List<Skill> ListS = db.Skills.ToList<Skill>();
                ComboSkills.DisplayMember = "SkillName";
                ComboSkills.ValueMember = "SkillID";
                ComboSkills.DataSource = ListS;
                ComboSkills.SelectedIndex = -1;
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show(SqlServerErrorManagment.ShowError(ex, "حرفه"), "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form_RegContractor_Load(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            BGW.RunWorkerAsync();
        }
        /// <summary>
        /// اضافه کردن به لیست باکس حرفه
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_AddSkill_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (var item in listBox_Skill.Items)
                {
                    if (ComboSkills.SelectedText == item.ToString())
                    {
                        MessageBox.Show("حرفه ی وارد شده تکراری می باشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                listBox_Skill.Items.Add(ComboSkills.SelectedItem.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// پاک کردن از لیست باکس حرفه
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_DelSkill_Click(object sender, EventArgs e)
        {
            try
            {
                int n = listBox_Skill.SelectedIndex;
                if (n == -1)
                {
                    if (listBox_Skill.Items.Count == 0)
                        MessageBox.Show("هیچ حرفه ای وارد نشده است", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        MessageBox.Show("لطفا برای حذف از لیست حرفه ای را انتخاب کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (n == 0 && listBox_Skill.Items.Count != 1)
                    {
                        listBox_Skill.SelectedIndex = 0;
                    }
                }
                else
                {
                    listBox_Skill.Items.RemoveAt(n);
                    if (n != 0 || listBox_Skill.Items.Count == 0)
                    {
                        listBox_Skill.SelectedIndex = n - 1;
                    }
                    else
                        listBox_Skill.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// اضافه کردن به لیست باکس تلفن
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_AddTel_Click(object sender, EventArgs e)
        {
            try
            {
                if (Txt_Tel.TextLength != 11)
                {
                    MessageBox.Show("لطفا شماره تلفن را درست وارد نمایید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (Txt_Tel.Text.Trim() == "")
                {
                    MessageBox.Show("لطفا فیلد مربوطه را پر نمایید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                foreach (var item in listBox_Tels.Items)
                {
                    if (Txt_Tel.Text.Trim() == item.ToString())
                    {
                        MessageBox.Show("تلفن وارد شده تکراری می باشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        /// <summary>
        /// دکمه ی ثبت اطلاعات
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Register_Click(object sender, EventArgs e)
        {
            if (Txt_FName.Text.Trim() == "" || listBox_Tels.Items.Count == 0 || listBox_Skill.Items.Count == 0)
            {
                MessageBox.Show("لطفا فیلد های مربوطه را پر کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Register();
        }

        private void Register()
        {
            try
            {
                Contractor C = ListContractor.FirstOrDefault(p => p.CName == Txt_FName.Text.Trim());
                if (C != null)
                {
                    MessageBox.Show("نام پیمانکار تکراری است", "خطا در هنگام ثبت اطلاعات", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                int ID = Convert.ToInt32(MakeID());
                Contractor c = new Contractor()
                {
                    CName = Txt_FName.Text.Trim(),
                    ContractorID = ID
                };
                List<Skill> ListSkill = new List<Skill>();
                foreach (string item in listBox_Skill.Items)
                {
                    ListSkill.Add((from V in db.Skills where V.SkillName == item.ToString() select V).FirstOrDefault());
                }
                c.Skills = ListSkill;
                db.Contractors.Add(c);
                db.SaveChanges();
                RegisterTel(ID);
                utility.Show_Message("اطلاعات این پیمانکار با موفقیت ثبت شد", "ثبت");
                Clear();
                GetData();
                ShowDatainGrid();
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show(SqlServerErrorManagment.ShowError(ex, "پیمانکار"), "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RegisterTel(int _NewID)
        {
            try
            {
                if (listBox_Tels.Items.Count != 0)
                {
                    String s;
                    foreach (Object selecteditem in listBox_Tels.Items)
                    {
                        s = selecteditem as String;
                        PhoneBook t = new PhoneBook()
                        {
                            ContractorID = _NewID,
                            PNumber = s,
                        };
                        db.PhoneBooks.Add(t);
                    }
                    db.SaveChanges();
                }
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show(SqlServerErrorManagment.ShowError(ex, "پیمانکار"), "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GridContractor_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1)
                {
                    Clear();
                    Row = e.RowIndex;
                    Btn_Edit.Enabled = true;
                    int ID = Convert.ToInt32(GridContractor.Rows[e.RowIndex].Cells["ContractorID"].Value);
                    Txt_FName.Text = GridContractor.Rows[e.RowIndex].Cells["CName"].Value.ToString();
                    List<Skill> S = ListContractor.Single(p => p.ContractorID == ID).Skills.ToList();
                    foreach (var item in S)
                    {
                        listBox_Skill.Items.Add(item.SkillName);
                    }
                    List<PhoneBook> P = ListContractor.Single(p => p.ContractorID == ID).PhoneBooks.ToList();
                    foreach (var item in P)
                    {
                        listBox_Tels.Items.Add(item.PNumber);
                    }
                    if (e.ColumnIndex == GridContractor.Columns["Del"].Index)
                    {
                        Btn_Edit.Enabled = false;
                        if (MessageBox.Show("آیا میخواهید اطلاعات این پیمانکار حذف شود؟", "حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            db.Contractors.Remove(ListContractor.Single(p => p.ContractorID == ID));
                            db.SaveChanges();
                            utility.Show_Message("اطلاعات این پیمانکار با موفقیت حذف شد", "حذف");
                            Clear();
                            GetData();
                            ShowDatainGrid();
                        }
                    }
                }
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show(SqlServerErrorManagment.ShowError(ex, "حرفه"), "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// ویرایش
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Edit_Click(object sender, EventArgs e)
        {
            if (Txt_FName.Text.Trim() == "" || listBox_Tels.Items.Count == 0 || listBox_Skill.Items.Count == 0)
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
                Contractor C = ListContractor.Single(p => p.ContractorID == Convert.ToInt32(GridContractor.Rows[Row].Cells["ContractorID"].Value));
                C.CName = Txt_FName.Text.Trim();
                foreach (Skill item in C.Skills.ToList())
                {
                    C.Skills.Remove(item);
                }
                foreach (string item in listBox_Skill.Items)
                {
                    Skill S = (from V in db.Skills where V.SkillName == item select V).FirstOrDefault();
                    C.Skills.Add(S);
                }
                foreach (var item in C.PhoneBooks.ToList())
                {
                    C.PhoneBooks.Remove(item);
                }
                String s;
                foreach (Object selecteditem in listBox_Tels.Items)
                {
                    s = selecteditem as String;
                    PhoneBook t = new PhoneBook()
                    {
                        ContractorID = C.ContractorID,
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
                utility.Show_Message("اطلاعات این پیمانکار با موفقیت ویرایش شد", "ویرایش");
                GetData();
                ShowDatainGrid();
                Clear();
                Btn_Edit.Enabled = false;
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show(SqlServerErrorManagment.ShowError(ex, "حرفه"), "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }


}

