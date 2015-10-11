using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using EsfahanGhos.DataLayer;
using EsfahanGhos.Model;

namespace EsfahanGhos
{
    public partial class Form_Person : Form
    {
        Corporation db = new Corporation();
        List<Person> LisPeople = null;
        string num = "";
        int IDP = -1;
        private int _edit = -1;
        public Form_Person()
        {
            InitializeComponent();
            Btn_Delete.Click += Btn_Delete_Click;
        }
        public Form_Person(int P)
        {
            IDP = P;
            InitializeComponent();
        }
        private void Btn_Register_Click(object sender, EventArgs e)
        {
            if (CheckError())
            {
                Register();
                GetData();
                ShowDataGrid();
                ClearText();
            }
            else MessageBox.Show("لطفا تمام موارد ستاره دار را پر کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private bool CheckError()
        {
            if (Txt_FName.Text.Trim() == "" || Txt_FatherName.Text.Trim() == "" || Txt_NationalCode.Text.Trim() == "" || Txt_Cell.Text.Trim() == "" || Combo_StatusMarried.SelectedIndex == -1 || Txt_Shenasname.Text.Trim() == "")
            {
                return false;
            }
            else return true;
        }
        private void Combo_StatusMarried_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Combo_StatusMarried.SelectedIndex == 0)
            {
                Lbl1.Visible = Txt_NumChild.Visible = false;
            }
            else
            {
                Lbl1.Visible = Txt_NumChild.Visible = true;
            }
        }
        private void Register()
        {
            Person P = new Person()
            {
                EmployeeNationalCode = Txt_NationalCode.Text.Trim(),
                FatherName = Txt_FatherName.Text.Trim(),
                EmployeeFullName = Txt_FName.Text.Trim(),
                PhoneNumber = Txt_Phone.Text.Trim(),
                EmployeeBirth = Txt_Date.GeoDate.Value,
                CellPhone = Txt_Cell.Text.Trim(),
                Adress = Txt_Address.Text.Trim(),
                IdentityNumber = Txt_Shenasname.Text.Trim(),
            };
            if (Combo_StatusMarried.SelectedIndex == 0) P.EmployeeMaried = false;
            else { P.EmployeeMaried = true; P.NumberOfChildren = Txt_NumChild.Text.Trim(); }
            db.Persons.Add(P);
            db.SaveChanges();
            utility.Show_Message("اطلاعات این شخص با موفقیت ذخیره شد ", "پیغام");
        }
        private void Btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_Person_Load(object sender, EventArgs e)
        {
            SetDefualt();
        }

        private void EditForm()
        {
            Btn_Delete.Click += Btn_Delete_Click;
            Btn_Edit.Enabled = true;
            Btn_Register.Enabled = false;
            Btn_Delete.Enabled = true;
            Person Pers = LisPeople.FirstOrDefault(p => p.EmployeeID == IDP);
            if (Pers != null)
            {
                Btn_Edit.Tag = Pers;
                Btn_Delete.Tag = Pers;
                Txt_NationalCode.Text = Pers.EmployeeNationalCode;
                Txt_FatherName.Text = Pers.FatherName;
                Txt_FName.Text = Pers.EmployeeFullName;
                Txt_Phone.Text = Pers.PhoneNumber;
                Txt_Cell.Text = Pers.CellPhone;
                Txt_Address.Text = Pers.Adress;
                Txt_Shenasname.Text = Pers.IdentityNumber;
                Txt_NumChild.Text = Pers.NumberOfChildren;
                Txt_Date.GeoDate = Pers.EmployeeBirth;
                if (Pers.EmployeeMaried) Combo_StatusMarried.SelectedIndex = 1;
                else Combo_StatusMarried.SelectedIndex = 0;
            }
        }

        private void SetDefualt()
        {
            Combo_StatusMarried.SelectedIndex = -1;
            Txt_Date.GeoDate = DateTime.Now;
            BGW.RunWorkerAsync();

        }
        private void ClearText()
        {
            Txt_NationalCode.Text =
            Txt_FatherName.Text =
            Txt_FName.Text =
            Txt_Phone.Text =
            Txt_Cell.Text =
            Txt_Address.Text =
            Txt_NumChild.Text =
            Txt_Shenasname.Text = "";
            Combo_StatusMarried.SelectedIndex = -1;
            Txt_Date.GeoDate = DateTime.Now;
            Txt_FName.Focus();
        }

        private void BGW_DoWork(object sender, DoWorkEventArgs e)
        {
            GetData();
        }

        private void GetData()
        {
            LisPeople = db.Persons.OrderBy(p => p.EmployeeFullName).ToList();
        }
        private void ShowDataGrid()
        {
            Grid_People.Rows.Clear();
            if (LisPeople.Count != 0)
            {
                int i = 0;
                foreach (var item in LisPeople.OrderBy(p=>p.EmployeeID).ToList())
                {
                    Grid_People.Rows.Add(++i, item.EmployeeFullName, item.EmployeeNationalCode, item.CellPhone, utility.ConvertDate_M_To_Sh(item.EmployeeBirth), item.EmployeeID);
                }
            }
        }

        private void Btn_ListPeople_Click(object sender, EventArgs e)
        {
            ShowDataGrid();
        }



        private void GridPeople_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                ClearText();
                Person P = LisPeople.FirstOrDefault(p => p.EmployeeID == Convert.ToInt32(Grid_People.Rows[e.RowIndex].Cells["ID"].Value));
                if (P != null)
                {
                    Btn_Delete.Enabled = true;

                    Btn_Edit.Enabled = true;
                    Btn_Register.Enabled = false;
                    _edit = P.EmployeeID;
                    Txt_NationalCode.Text = P.EmployeeNationalCode;
                    Txt_FatherName.Text = P.FatherName;
                    Txt_FName.Text = P.EmployeeFullName;
                    Txt_Phone.Text = P.PhoneNumber;
                    Txt_Cell.Text = P.CellPhone;
                    Txt_Address.Text = P.Adress;
                    Txt_Shenasname.Text = P.IdentityNumber;
                    Txt_Date.GeoDate = P.EmployeeBirth;
                    Txt_NumChild.Text = P.NumberOfChildren;
                    if (P.EmployeeMaried) Combo_StatusMarried.SelectedIndex = 1;
                    else Combo_StatusMarried.SelectedIndex = 0;
                }
            }
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            Btn_Edit.Enabled = false;
            Btn_Delete.Enabled = false;
            Btn_Register.Enabled = true;

            db.Persons.Remove(db.Persons.Find(_edit));
            db.SaveChanges();
            utility.Show_Message("اطلاعات این شخص با موفقیت حذف شد ", "پیغام");
            GetData();
            ShowDataGrid();
            ClearText();
        }

        private void Btn_Edit_Click(object sender, EventArgs e)
        {
            if (CheckError())
            {
                Btn_Edit.Enabled = false;
                Btn_Register.Enabled = true;
                Edit();
                GetData();
                ShowDataGrid();
                ClearText();
            }
            else MessageBox.Show("لطفا تمام موارد ستاره دار را پر کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Edit()
        {
            Person P = db.Persons.Single(p => p.EmployeeID == _edit);
            P.EmployeeNationalCode = Txt_NationalCode.Text.Trim();
            P.FatherName = Txt_FatherName.Text.Trim();
            P.EmployeeFullName = Txt_FName.Text.Trim();
            P.PhoneNumber = Txt_Phone.Text.Trim();
            P.EmployeeBirth = Txt_Date.GeoDate.Value;
            P.CellPhone = Txt_Cell.Text.Trim();
            P.Adress = Txt_Address.Text.Trim();
            P.IdentityNumber = Txt_Shenasname.Text.Trim();
            if (Combo_StatusMarried.SelectedIndex == 0) P.EmployeeMaried = false;
            else { P.EmployeeMaried = true; P.NumberOfChildren = Txt_NumChild.Text.Trim(); }
            db.SaveChanges();
            utility.Show_Message("اطلاعات این شخص با موفقیت ویرایش شد ", "پیغام");
            Btn_Edit.Tag = 0;
        }

        private void BGW_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ShowDataGrid();
            if (IDP != -1)
            {
                EditForm();
            }
        }
        private void Alphabet_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar <= '9' && e.KeyChar >= '0')
            {
                e.Handled = true;
            }
        }

        private void Number_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
    && !char.IsDigit(e.KeyChar)
    && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void Txt_Cell_TextChanged(object sender, EventArgs e)
        {
            if (Txt_Cell.TextLength < 12)
            {
                num = Txt_Cell.Text.Trim();
            }
            Txt_Cell.Text = num;
            Txt_Cell.Select(Txt_Cell.Text.Length, 0);
        }

        private void Txt_Phone_TextChanged(object sender, EventArgs e)
        {
            if (Txt_Phone.TextLength < 12)
            {
                num = Txt_Phone.Text.Trim();
            }
            Txt_Phone.Text = num;
            Txt_Phone.Select(Txt_Phone.Text.Length, 0);
        }
    }
}
