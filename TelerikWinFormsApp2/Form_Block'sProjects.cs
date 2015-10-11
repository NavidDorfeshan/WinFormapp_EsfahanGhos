using System;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Windows.Forms;
using EsfahanGhos.DataLayer;
using EsfahanGhos.Model;

namespace EsfahanGhos
{
    public partial class Form_Block_sProjects : Form
    {
        Corporation db = new Corporation();
        Block Bl = null;
        int P = 0;
        public Form_Block_sProjects(int project)
        {
            InitializeComponent();
            P = project;
        }
        public Form_Block_sProjects(Block B)
        {
            Bl = B;
            InitializeComponent();

        }
        /// <summary>
        /// ثبت اطلاعات
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Reg_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkBox1.Enabled)
                {
                    if (!checkBox1.Checked)
                    {
                        if (db.Blocks.Any(p => p.BlockName == Txt_Block.Text.Trim()))
                        {
                            MessageBox.Show("بلوکی با این نام در سیستم موجود می باشد", "خطا", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                            return;
                        }
                        Block B = new Block()
                        {
                            BlockName = Txt_Block.Text.Trim(),
                            NumberOfUnits = Txt_UnitR.Text.Trim(),
                            ProjectID = P,
                            IsExist = true
                        };
                        db.Blocks.Add(B);
                        db.SaveChanges();
                        Txt_UnitR.Text = Txt_Block.Text = "";
                        utility.Show_Message("عملیات ثبت این بلوک با موفقیت انجام شد", "پیغام ثبت");
                    }
                }
                else
                {
                    Block block = db.Blocks.SingleOrDefault(p => p.BlockID == Bl.BlockID);
                    block.BlockName = Txt_Block.Text.Trim();
                    block.NumberOfUnits = Txt_UnitR.Text.Trim();
                    db.SaveChanges();
                    utility.Show_Message("عملیات ویرایش این بلوک با موفقیت انجام شد", "پیغام ثبت");

                }
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show(SqlServerErrorManagment.ShowError(ex, "پروژه"), "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            }
        }

        private void Form_Block_sProjects_Load(object sender, EventArgs e)
        {
            if (Bl != null)
            {
                Txt_Block.Text = Bl.BlockName;
                Txt_UnitR.Text = Bl.NumberOfUnits;
                checkBox1.Enabled = false;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Txt_Block.Enabled = Txt_UnitR.Enabled = false;
                Btn_Reg.Enabled = false;

            }
            else
            {
                Txt_Block.Enabled = Txt_UnitR.Enabled = true;
                Btn_Reg.Enabled = true;

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

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
