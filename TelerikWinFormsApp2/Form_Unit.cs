using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using EsfahanGhos.DataLayer;
using EsfahanGhos.Model;

namespace EsfahanGhos
{
    public partial class Form_Unit : Form
    {
        Corporation db = new Corporation();
        private List<Unit> Listunit = null;
        private int Row = -1;
        public Form_Unit()
        {
            InitializeComponent();
        }

        private void Form_Unit_Load(object sender, EventArgs e)
        {
            BGW.RunWorkerAsync();
        }

        private void BGW_DoWork(object sender, DoWorkEventArgs e)
        {
            GetData();
        }

        private void GetData()
        {
            Listunit = db.Units.ToList();
        }

        private void BGW_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ShowDataInGrid();
        }

        private void ShowDataInGrid()
        {
            Grid_Unit.Rows.Clear();
            if (Listunit.Count != 0)
            {
                int i = 0;
                foreach (var unit in Listunit)
                {
                    Grid_Unit.Rows.Add(++i, unit.UnitName, unit.Id);
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
            if (Listunit.Any(unit => Txt_Name.Text.Trim() == unit.UnitName))
            {
                MessageBox.Show("واحد اندازه گیری وارد شده در سیستم وجود دارد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Register();
            GetData();
            ShowDataInGrid();
        }

        private void Register()
        {
            db.Units.Add(new Unit()
            {
                UnitName = Txt_Name.Text.Trim()
            });
            db.SaveChanges();
            Txt_Name.Text = "";
            utility.Show_Message("اطلاعات با موفقیت ثبت شد", "پیغام");
        }

        private void Grid_Unit_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                Row = e.RowIndex;
                Btn_Edit.Enabled = Btn_Del.Enabled = true;
                Txt_Name.Text = Grid_Unit.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }

        private void Btn_Edit_Click(object sender, EventArgs e)
        {
            if (Txt_Name.Text.Trim() == "")
            {
                MessageBox.Show("لطفا فیلد مربوطه را پر نمایید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Listunit.Any(unit => Txt_Name.Text.Trim() == unit.UnitName))
            {
                MessageBox.Show("واحد اندازه گیری وارد شده در سیستم وجود دارد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Edit();
            GetData();
            ShowDataInGrid();
            Row = -1;
            Btn_Edit.Enabled = Btn_Del.Enabled = false;
            Txt_Name.Text = "";


        }

        private void Edit()
        {
            var unit =
                Listunit.FirstOrDefault(p => p.Id == Convert.ToInt32(Grid_Unit.Rows[Row].Cells[2].Value));
            if (unit != null)
            {
                unit.UnitName = Txt_Name.Text.Trim();
                db.SaveChanges();
                utility.Show_Message("اطلاعات با موفقیت ویرایش شد", "پیغام");
            }

        }

        private void Btn_Del_Click(object sender, EventArgs e)
        {
            Delete();
            Btn_Edit.Enabled = Btn_Del.Enabled = false;
            Row = -1;
        }

        private void Delete()
        {
            db.Units.Remove(
                Listunit.FirstOrDefault(p => p.Id == Convert.ToInt32(Grid_Unit.Rows[Row].Cells["Id"].Value)));
            db.SaveChanges();
            utility.Show_Message("اطلاعات با موفقیت حذف شد", "پیغام");
            GetData();
            ShowDataInGrid();
            Txt_Name.Text = "";
        }
    }
}
