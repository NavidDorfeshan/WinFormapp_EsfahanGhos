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
    public partial class Form_RegSkill : Telerik.WinControls.UI.RadForm
    {
        Corporation db = new Corporation();
        List<Skill> ListSkill = new List<Skill>();
        int Row = -1;
        public Form_RegSkill()
        {
            InitializeComponent();
        }
        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BGW_DoWork(object sender, DoWorkEventArgs e)
        {
            GetData();
        }

        private void GetData()
        {
            try
            {
                ListSkill = db.Skills.ToList<Skill>();
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

        private void BGW_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            pictureBox1.Visible = false;
            ShowDataInGrid();
        }

        private void ShowDataInGrid()
        {
            try
            {
                GridSkill.AutoGenerateColumns = false;
                GridSkill.DataSource = ListSkill;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form_RegSkill_Load(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            BGW.RunWorkerAsync();
        }

        private void Btn_Reg_Click(object sender, EventArgs e)
        {
            Btn_Delete.Enabled = Btn_Edit.Enabled = false;
            if (Txt_SkillName.Text.Trim() == "")
            {
                MessageBox.Show("لطفا فیلد مربوطه را پر نمایید", "خطا در هنگام ثبت اطلاعات", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (ListSkill.Exists(p => p.SkillName == Txt_SkillName.Text.Trim()))
            {
                MessageBox.Show("اطلاعات این حرفه قبلا ثبت شده است", "خطا در هنگام ثبت اطلاعات", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Register();
        }

        private void Register()
        {
            try
            {
                Skill S = new Skill()
                {
                    SkillName = Txt_SkillName.Text.Trim()
                };
                db.Skills.Add(S);
                db.SaveChanges();
                utility.Show_Message("این حرفه با موفقیت ثبت شد", "ثبت");
                Txt_SkillName.Text = "";
                GetData();
                ShowDataInGrid();
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
        private void GridSkill_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Row = e.RowIndex;
                Txt_SkillName.Text = GridSkill.Rows[e.RowIndex].Cells["SkillName"].Value.ToString();
                Btn_Delete.Enabled = Btn_Edit.Enabled = true;
            }
        }

        private void Btn_Edit_Click(object sender, EventArgs e)
        {
            if (Row == -1)
            {
                MessageBox.Show("لطفا موردی از لیست انتخاب نمایید", "خطا در هنگام ویرایش اطلاعات", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Txt_SkillName.Text.Trim() == "")
            {
                MessageBox.Show("لطفا فیلد مربوطه را پر نمایید", "خطا در هنگام ویرایش اطلاعات", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Edit();
        }

        private void Edit()
        {
            try
            {
                Skill S = ListSkill.Single(p => p.SkillID == Convert.ToInt32(GridSkill.Rows[Row].Cells["SkillID"].Value));
                S.SkillName = Txt_SkillName.Text.Trim();
                db.SaveChanges();
                utility.Show_Message("این حرفه با موفقیت ویرایش شد", "ویرایش");
                Txt_SkillName.Text = "";
                GetData();
                ShowDataInGrid();
                Btn_Delete.Enabled = Btn_Edit.Enabled = false;
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

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            if (Row == -1)
            {
                MessageBox.Show("لطفا موردی از لیست انتخاب نمایید", "خطا در هنگام حذف اطلاعات", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Txt_SkillName.Text.Trim() == "")
            {
                MessageBox.Show("لطفا فیلد مربوطه را پر نمایید", "خطا در هنگام حذف اطلاعات", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Delete();
        }

        private void Delete()
        {
            try
            {
                Skill S = ListSkill.Single(p => p.SkillID == Convert.ToInt32(GridSkill.Rows[Row].Cells["SkillID"].Value));
                db.Skills.Remove(S);
                db.SaveChanges();
                utility.Show_Message("این حرفه با موفقیت حذف شد", "حذف");
                Txt_SkillName.Text = "";
                GetData();
                ShowDataInGrid();
                Btn_Delete.Enabled = Btn_Edit.Enabled = false;

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

        private void Txt_SkillName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar <= '9' && e.KeyChar >= '0')
            {
                e.Handled = true;
            }

        }
    }
}
