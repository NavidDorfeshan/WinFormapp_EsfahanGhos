using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using EsfahanGhos.DataLayer;
using EsfahanGhos.Model;

namespace EsfahanGhos
{
    public partial class Form_RegSourceStorage : Form
    {
        readonly Corporation db = new Corporation();
        private List<Unit> Listunit = null;

        enum Stats
        {
            Normal,
            Edit
        }

        private Stats state = Stats.Normal;
        private int _row = 0;
        public Form_RegSourceStorage()
        {
            state = Stats.Normal;
            InitializeComponent();
        }
        public Form_RegSourceStorage(int id)
        {
            state = Stats.Edit;
            InitializeComponent();
            Btn_Reg.Text = "ویرایش";
        }
        private void GridItem_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex == 6 && e.RowIndex != -1)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                e.Graphics.DrawImage(Properties.Resources.del, e.CellBounds.Left + 2, e.CellBounds.Top);
                e.Handled = true;
            }
        }

        private void UpdateRowCount(int p1, int p2)
        {
            for (int i = p1; i < p2; i++)
            {
                GridItem.Rows[i].Cells[0].Value = i + 1;
            }
        }
        private void GridItem_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            _row = e.RowIndex;
        }
        private void GridItem_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            _row = e.RowIndex;
        }
        private void GridItem_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            GridItem.Rows[GridItem.Rows.Count - 1].Cells[0].Value = GridItem.Rows.Count;

        }
        private void GridItem_KeyUp(object sender, KeyEventArgs e)
        {
            if (CheckRow())
            {
                if (GridItem.CurrentCell.ColumnIndex == 5 && GridItem.Rows.Count > GridItem.CurrentCell.RowIndex + 1)
                {
                    GridItem.Rows[GridItem.CurrentCell.RowIndex + 1].Cells[1].Selected = true;
                }
            }
        }
        private void GridSetCount()
        {
            GridItem.Rows[0].Cells[0].Value = 1;
        }

        private bool CheckRow()
        {
            try
            {
                if (GridItem.Rows[GridItem.CurrentCell.RowIndex].Cells[0].Selected == true)
                {
                    GridItem.Rows[GridItem.CurrentCell.RowIndex].Cells[1].Selected = true;
                    return false;
                }
                if (GridItem.Rows[GridItem.CurrentCell.RowIndex].Cells[1].Value == null)
                {
                    GridItem.Rows[GridItem.CurrentCell.RowIndex].Cells[1].Selected = true;
                    utility.Show_Message("کد کالا نمیتواند خالی باشد", "هشدار");
                    return false;
                }
                if (GridItem.Rows[GridItem.CurrentCell.RowIndex].Cells[2].Value == null)
                {
                    GridItem.Rows[GridItem.CurrentCell.RowIndex].Cells[2].Selected = true;
                    utility.Show_Message("شرح کالا نمیتواند خالی باشد", "هشدار");
                    return false;
                }
                if (GridItem.Rows[GridItem.CurrentCell.RowIndex].Cells[5].Value == null)
                {
                    GridItem.Rows[GridItem.CurrentCell.RowIndex].Cells[5].Selected = true;
                    utility.Show_Message("تعداد نمیتواند خالی باشد ", "هشدار");
                    return false;
                }
                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }
        private void Form_RegSourceStorage_Load(object sender, EventArgs e)
        {
            LoadingPic(true);
            GridSetCount();
            BGW.RunWorkerAsync();
        }

        private void LoadingPic(bool I)
        {
            pictureBox1.Visible = I;
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
            SetComboTypeStorage();
            var Thread = new Thread(o =>
            {
                SetComboUnit();

            });
            Thread.Start();
            LoadingPic(false);
        }

        private void SetComboUnit()
        {
            Combounit.DataSource = Listunit;
            Combounit.ValueMember = "Id";
            Combounit.DisplayMember = "UnitName";
            Combounit.DropDownWidth = 200;

        }

        private void SetComboTypeStorage()
        {
            ComboTypeStorage.DataSource = db.TypeStorages.ToList();
            ComboTypeStorage.ValueMember = "Id";
            ComboTypeStorage.DisplayMember = "Name";
            ComboTypeStorage.SelectedIndex = -1;
        }

        private void Btn_OpenRegTypeStorage_Click(object sender, EventArgs e)
        {
            ShowFormTypeStorage();
            SetComboTypeStorage();
        }

        private void ShowFormTypeStorage()
        {
            Form_TypeStorage formTypeStorage = new Form_TypeStorage();
            formTypeStorage.ShowDialog();
        }

        private bool CheckError()
        {
            for (int i = 0; i < GridItem.RowCount - 1; i++)
            {
                if (GridItem.Rows[i].Cells[1].Value == null)
                {
                    utility.Show_Message("کد کالا نمیتواند خالی باشد", "هشدار");
                    return false;
                }
                if (GridItem.Rows[i].Cells[2].Value == null)
                {
                    utility.Show_Message("شرح کالا نمیتواند خالی باشد", "هشدار");
                    return false;
                }
                //if (GridItem.Rows[i].Cells["TotalCount"].Value == null)
                //{
                //    utility.Show_Message("تعداد نمیتواند خالی باشد ", "هشدار");
                //    return false;
                //}
            }
            return true;
        }
        private List<StorageItem> GetDataFromGrid()
        {
            var liststorageItem = new List<StorageItem>();
            if (GridItem.RowCount != 0)
            {
                if (CheckError())
                {
                    for (int i = 0; i < GridItem.RowCount - 1; i++)
                    {
                        var item = new StorageItem()
                        {
                            Code = Convert.ToInt32(GridItem.Rows[i].Cells["Id"].Value),
                            Description = GridItem.Rows[i].Cells["GridItemDescription"].Value.ToString(),
                            Count = Convert.ToInt32(GridItem.Rows[i].Cells["Count"].Value),
                            TotalCount = Convert.ToInt32(GridItem.Rows[i].Cells["TotalCount"].Value),
                        };
                        liststorageItem.Add(item);
                    }
                    for (int i = 0; i < liststorageItem.Count; i++)
                    {
                        var storageItem = liststorageItem[i];
                        storageItem.TypeStorageId = Convert.ToInt32(ComboTypeStorage.SelectedValue);
                        storageItem.UnitId = Convert.ToInt32(GridItem.Rows[i].Cells["Combounit"].Value);
                        storageItem.StorageId = 1;
                    }
                }
            }
            return liststorageItem;
        }

        private void Btn_Reg_Click(object sender, EventArgs e)
        {
            if (ComboTypeStorage.SelectedIndex == -1)
            {
                MessageBox.Show("لطفا دسته بندی کالاها را مشخص نمایید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Register();
        }

        private void Register()
        {
            var listItem = GetDataFromGrid();
            if (listItem.Count == 0)
            {
                utility.Show_Message("اطلاعاتی برای ثبت وجود ندارد", "هشدار");
                return;
            }
            db.StorageItems.AddRange(listItem);
            db.SaveChanges();
            utility.Show_Message("اطلاعات با موفقیت ثبت شد", "پیغام");

        }

        private void GridItem_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                RemoveRow(e.RowIndex);
                UpdateRowCount(e.RowIndex, GridItem.Rows.Count);
            }
        }

        private void RemoveRow(int p)
        {
            if (GridItem.Rows.Count != p + 1)
            {
                GridItem.Rows.Remove(GridItem.Rows[p]);
            }
        }
    }
}
