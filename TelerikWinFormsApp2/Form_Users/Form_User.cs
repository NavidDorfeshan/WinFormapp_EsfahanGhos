using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Windows.Forms;
using EsfahanGhos.DataLayer;
using EsfahanGhos.Form_Users.Hasher;
using EsfahanGhos.Model.Login_Classes;

namespace EsfahanGhos.Form_Users
{
    public partial class Form_User : Telerik.WinControls.UI.RadForm
    {
        Corporation db = new Corporation();
        List<User> ListUser = null;
        int _Row = -1;
        public Form_User()
        {
            InitializeComponent();
        }

        private void Txt_Password_TextChanged(object sender, EventArgs e)
        {
            if (Txt_Password.TextLength <= 3) Lbl_Warning.Visible = true;
            else Lbl_Warning.Visible = false;
        }

        private void BGW_DoWork(object sender, DoWorkEventArgs e)
        {
            GetData();
        }

        private void GetData()
        {
            try
            {
                ListUser = db.Users.Include("UnitSoftwars").Include("Users_IO").OrderBy(p=>p.UserName).Skip(1).ToList();
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show(SqlServerErrorManagment.ShowError(ex, "کاربر"), "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            }
        }

        private void BGW_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ShowDataGrid();
        }

        private void ShowDataGrid()
        {
            try
            {
                GridUser.Rows.Clear();
                if (ListUser.Count != 0)
                {
                    GridUser.Rows.Clear();
                    GridUser.AutoGenerateColumns = false;
                    int i = 0;
                    foreach (var item in ListUser)
                    {
                        GridUser.Rows.Add(item.UserID, GridUser.Rows.Count + 1, item.FName, item.UserName, "*****");
                        i++;
                    }
                    GridUser.CurrentRow.Selected = false;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void Form_User_Load(object sender, EventArgs e)
        {
            BGW.RunWorkerAsync();
        }

        private void Btn_Register_Click(object sender, EventArgs e)
        {
            if (CheckError())
            {
                Register();
                BGW.RunWorkerAsync();
                Clear();
            }
        }

        private void Clear()
        {
            Txt_Fname.Text = Txt_Password.Text = Txt_UserName.Text ="";
            Txt_Fname.Focus();
            Lbl_Warning.Visible = false;
        }

        private bool CheckError()
        {
            if (Txt_Fname.Text.Trim() == "" || Txt_UserName.Text.Trim() == "" || Lbl_Warning.Visible == true)
            {
                MessageBox.Show("لطفا تمامی موارد را پر نمایید", "خطا در هنگام ثبت", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else return true;
        }

        private void Register()
        {
            try
            {
                if (ListUser.Exists(p => p.UserName == Txt_UserName.Text.Trim()) || ListUser.Exists(p => p.FName == Txt_Fname.Text.Trim()))
                {
                    MessageBox.Show("نام کاربری یا نام و نام خانوادگی وارد شده تکراری می باشد", "خطا در هنگام ثبت", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string HashedPassword = PasswordHasher.HashPassword(Txt_Password.Text.Trim());
                User U = new User()
                {
                    FName = Txt_Fname.Text.Trim(),
                    UserName = Txt_UserName.Text.Trim(),
                    Password = HashedPassword,
                };
                db.Users.Add(U);
                db.SaveChanges();
                utility.Show_Message("اطلاعات این کاربر با موفقیت ثبت شد", "پیغام ثبت");

            }

            catch (DbUpdateException ex)
            {
                MessageBox.Show(SqlServerErrorManagment.ShowError(ex, "کاربر"), "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void GridUser_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1)
                {
                    Clear();
                    _Row = e.RowIndex;
                    Btn_Register.Enabled = false;
                    Btn_Edit.Enabled = Btn_Delete.Enabled = Btn_Access.Enabled = true;
                    User U = ListUser.FirstOrDefault(p => p.UserID == Convert.ToInt32(GridUser.Rows[e.RowIndex].Cells[0].Value));
                    if (U != null)
                    {
                        Txt_Fname.Text = U.FName;
                        Txt_UserName.Text = U.UserName;
                        Txt_Password.Text = "*****";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Btn_Access_Click(object sender, EventArgs e)
        {
            try
            {
                if (_Row != -1)
                {
                    User u = ListUser.Single(p => p.UserID == Convert.ToInt32(GridUser.Rows[_Row].Cells[0].Value));
                    Form_Acess A = new Form_Acess(u);
                    A.ShowDialog();
                    Clear();
                    Btn_Edit.Enabled = Btn_Delete.Enabled = Btn_Access.Enabled = false;
                    Btn_Register.Enabled = true;
                    _Row = -1;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GridUser_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1)
                {
                    User u = ListUser.Single(p => p.UserID == Convert.ToInt32(GridUser.Rows[e.RowIndex].Cells[0].Value));
                    Form_UserIO IO = new Form_UserIO(u);
                    IO.ShowDialog();
                    Clear();
                    Btn_Edit.Enabled = Btn_Delete.Enabled = Btn_Access.Enabled = false;
                    Btn_Register.Enabled = true;
                    _Row = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Btn_Edit_Click(object sender, EventArgs e)
        {
            if (CheckError() || Txt_Password.Text.Trim() != "*****")
            {
                Edit();
                BGW.RunWorkerAsync();
                Clear();
                Btn_Register.Enabled = true;
                Btn_Edit.Enabled = Btn_Delete.Enabled = Btn_Access.Enabled = false;
                _Row = -1;
            }
            else
            {
                utility.Show_Message("خطا در هنگام ویرایش اطلاعات", "پیغام ویرایش");
                Clear();
                Btn_Register.Enabled = true;
                Btn_Edit.Enabled = Btn_Delete.Enabled = Btn_Access.Enabled = false;
                _Row = -1;
            }
        }

        private void Edit()
        {
            try
            {
                User u = ListUser.FirstOrDefault(p => p.UserID == Convert.ToInt32(GridUser.Rows[_Row].Cells[0].Value));
                if (u != null)
                {
                    if (ListUser.Exists(p => p.UserName == Txt_UserName.Text.Trim()) || ListUser.Exists(p => p.FName == Txt_Fname.Text.Trim()))
                    {
                        MessageBox.Show("نام کاربری یا نام و نام خانوادگی وارد شده تکراری می باشد", "خطا در هنگام ویرایش", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    string HashedPassword = PasswordHasher.HashPassword(Txt_Password.Text.Trim());
                    u.FName = Txt_Fname.Text.Trim();
                    u.UserName = Txt_UserName.Text.Trim();
                    u.Password = HashedPassword;
                    db.SaveChanges();
                    utility.Show_Message("اطلاعات این کاربر با موفقیت ویرایش شد", "پیغام ویرایش");
                }

            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show(SqlServerErrorManagment.ShowError(ex, "کاربر"), "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (Delete())
                {
                    GetData();
                    ShowDataGrid();
                    Clear();
                    Btn_Register.Enabled = true;
                    Btn_Edit.Enabled = Btn_Delete.Enabled = Btn_Access.Enabled = false;
                    _Row = -1;
                }
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show(SqlServerErrorManagment.ShowError(ex, "کاربر"), "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool Delete()
        {
            db.Users.Remove(ListUser.FirstOrDefault(p => p.UserID == Convert.ToInt32(GridUser.Rows[_Row].Cells[0].Value)));
            db.SaveChanges();
            utility.Show_Message("اطلاعات این کاربر با موفقیت حذف شد", "پیغام حذف");
            return true;
        }

        private void Txt_Fname_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsDigit(e.KeyChar);
        }


    }
}
