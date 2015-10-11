using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using EsfahanGhos.DataLayer;
using EsfahanGhos.Model;

namespace EsfahanGhos
{
    public partial class Form_TypeStorage : Form
    {
        Corporation db = new Corporation();
        private List<Type_Storage> ListStorage = null;
        private int Row = -1;
        public Form_TypeStorage()
        {
            InitializeComponent();
        }

        private void Form_TypeStorage_Load(object sender, EventArgs e)
        {
            BGW.RunWorkerAsync();
        }

        private void BGW_DoWork(object sender, DoWorkEventArgs e)
        {
            GetData();
        }

        private void GetData()
        {
            ListStorage = db.TypeStorages.ToList();
        }

        private void BGW_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ShowDataInGrid();
        }

        private void ShowDataInGrid()
        {
            Grid_TypeStorage.Rows.Clear();
            if (ListStorage.Count != 0)
            {
                var i = 0;
                foreach (var item in ListStorage)
                {
                    Grid_TypeStorage.Rows.Add(++i, item.Name, item.Id);
                }
            }
        }

        private void Btn_Reg_Click(object sender, EventArgs e)
        {
            if (Txt_Name.Text.Trim() == "")
            {
                MessageBox.Show("لطفا فیلد مربوطه را پر نمایید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (ListStorage.Any(type => Txt_Name.Text.Trim() == type.Name))
            {
                MessageBox.Show("واحد اندازه گیری وارد شده در سیستم وجود دارد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Register();
        }

        private void Register()
        {
            db.TypeStorages.Add(new Type_Storage()
            {
                Name = Txt_Name.Text.Trim()
            });
            db.SaveChanges();
            Txt_Name.Text = "";
            utility.Show_Message("اطلاعات با موفقیت ثبت شد", "پیغام");
            GetData();
            ShowDataInGrid();
        }

        private void Grid_TypeStorage_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                Row = e.RowIndex;
                Txt_Name.Text = Grid_TypeStorage.Rows[e.RowIndex].Cells[1].Value.ToString();
                Btn_Edit.Enabled = Btn_Delete.Enabled = true;
            }
        }

        private void Btn_Edit_Click(object sender, EventArgs e)
        {
            if (Txt_Name.Text.Trim() == "")
            {
                MessageBox.Show("لطفا فیلد مربوطه را پر نمایید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (ListStorage.Any(type => Txt_Name.Text.Trim() == type.Name))
            {
                MessageBox.Show("واحد اندازه گیری وارد شده در سیستم وجود دارد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Edit();
            Btn_Edit.Enabled = Btn_Delete.Enabled = false;
            Row = -1;

        }

        private void Edit()
        {
            var typestorage =
                ListStorage.FirstOrDefault(p => p.Id == Convert.ToInt32(Grid_TypeStorage.Rows[Row].Cells[2].Value));
            if (typestorage != null)
            {
                typestorage.Name = Txt_Name.Text.Trim();
                db.SaveChanges();
                utility.Show_Message("اطلاعات با موفقیت ویرایش شد", "پیغام");
                GetData();
                ShowDataInGrid();
                Txt_Name.Text = "";


            }
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            Delete();
            Btn_Edit.Enabled = Btn_Delete.Enabled = false;
            Row = -1;
        }

        private void Delete()
        {
            db.TypeStorages.Remove(
                ListStorage.FirstOrDefault(p => p.Id == Convert.ToInt32(Grid_TypeStorage.Rows[Row].Cells["Id"].Value)));
            db.SaveChanges();
            utility.Show_Message("اطلاعات با موفقیت حذف شد", "پیغام");
            GetData();
            ShowDataInGrid();
            Txt_Name.Text = "";

        }
    }
}
