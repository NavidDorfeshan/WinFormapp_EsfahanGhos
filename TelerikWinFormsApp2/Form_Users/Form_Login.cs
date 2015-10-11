using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using EsfahanGhos.DataLayer;
using EsfahanGhos.Form_Users.Hasher;
using EsfahanGhos.Model.Login_Classes;

namespace EsfahanGhos.Form_Users
{
    public partial class Form_Login : Form
    {
        Corporation db = new Corporation();
        List<User> ListUser = null;
        bool flag = true;
        enum States { Login, Forgot };
        States State = States.Login;
        public Form_Login()
        {
            State = States.Login;
            InitializeComponent();
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Txt_UserName_TextChanged(object sender, EventArgs e)
        {
                if (Txt_UserName.Text.Length == 0 && flag)
                {
                    Txt_UserName.Text = "UserName ...";
                    Txt_UserName.TextBoxElement.ForeColor = Color.DarkGray;
                }
                else
                {
                    Txt_UserName.TextBoxElement.ForeColor = Color.Black;
                    flag = true;
                }
            
        }
        private void Txt_UserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Txt_UserName.Text == "UserName ...")
            {
                flag = false;
                Txt_UserName.Clear();
            }
        }
        private void Txt_Password_TextChanged(object sender, EventArgs e)
        {
            if (Txt_Password.Text.Length == 0 && flag)
            {
                Txt_Password.Text = "Password...";
                Txt_Password.TextBoxElement.ForeColor = Color.DarkGray;
            }
            else
            {
                Txt_Password.TextBoxElement.ForeColor = Color.Black;
                flag = true;
            }

        }
        private void Txt_Password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Txt_Password.Text == "Password...")
            {
                flag = false;
                Txt_Password.Clear();
            }
        }

        private void BGW_DoWork(object sender, DoWorkEventArgs e)
        {
            GetData();
        }

        private void GetData()
        {
            ListUser = db.Users.ToList<User>();
        }

        private void BGW_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }
        private void Btn_Login_Click(object sender, EventArgs e)
        {
            Lbl.Visible = false;
            if (!ListUser.Exists(p => p.UserName == Txt_UserName.Text.Trim()))
            {
                Lbl.Visible = true;
                return;
            }
            string Pass = ListUser.SingleOrDefault(p => p.UserName == Txt_UserName.Text.Trim()).Password;
            if (!PasswordHasher.VerifyHashedPassword(Pass, Txt_Password.Text.Trim()))
            {
                Lbl.Visible = true;
                return;
            }
            //RegIO_User();
            //wellcom
        }

        private void EnterRegIO_User(User U)
        {
            try
            {
                User_IO IO = new User_IO()
                {
                    EnterDate = DateTime.Now,
                    User = U
                };
                db.Users_IO.Add(IO);
                db.SaveChanges();
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

        private void Form_Login_Load(object sender, EventArgs e)
        {
            BGW.RunWorkerAsync();
        }

        private void linkLabel_ForgotPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
        }
    }
}
