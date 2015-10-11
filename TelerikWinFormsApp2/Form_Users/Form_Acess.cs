using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Windows.Forms;
using EsfahanGhos.DataLayer;
using EsfahanGhos.Model.Login_Classes;

namespace EsfahanGhos.Form_Users
{
    public partial class Form_Acess : Telerik.WinControls.UI.RadForm
    {
        Corporation db = new Corporation();
        List<UnitSoftwar> ListUnit = null;
        User u = null;
        public Form_Acess(User user)
        {
            u = user;
            InitializeComponent();
        }

        private void BGW_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                ListUnit = db.UnitSoftwars.Include("User").ToList<UnitSoftwar>();
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show(SqlServerErrorManagment.ShowError(ex, "کاربر"), "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            }
        }

        private void BGW_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ShowDataTextBox();
            ShowDataGrid();
        }

        private void ShowDataGrid()
        {
            try
            {
                if (ListUnit.Count != 0)
                {
                    GridAcess.Rows.Clear();
                    GridAcess.AutoGenerateColumns = false;
                    int i = 0;
                    foreach (var item in ListUnit.Where(p=>p.UserID==u.UserID).ToList())
                    {
                        GridAcess.Rows.Add(GridAcess.Rows.Count + 1, item.UnitName,item.UnitAccess);
                        i++;
                    }
                    GridAcess.CurrentRow.Selected = false;
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

        private void ShowDataTextBox()
        {
            Txt_Fname.Text = u.FName;
            Txt_UserName.Text = u.UserName;
        }

        private void Form_Acess_Load(object sender, EventArgs e)
        {
            BGW.RunWorkerAsync();
        }
    }
}
