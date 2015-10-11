using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using EsfahanGhos.DataLayer;
using EsfahanGhos.Model;

namespace EsfahanGhos
{
    public partial class Form_ListSourceStorage : Form
    {
        private List<StorageItem> ListstorageItem = null;
        private List<Type_Storage> Listtype = null;
        public Form_ListSourceStorage()
        {
            InitializeComponent();
        }

        private void Form_ListSourceStorage_Load(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            BGW.RunWorkerAsync();
        }

        private void BGW_DoWork(object sender, DoWorkEventArgs e)
        {
            GetData();
        }

        private void GetData()
        {
            Corporation db = new Corporation();
            ListstorageItem = db.StorageItems.AsNoTracking().Include("Storage").ToList();
            Listtype = db.TypeStorages.ToList();
        }
        private void ShowDatainGrid(List<StorageItem> List)
        {
            grid.AutoGenerateColumns = false;
            grid.DataSource = List;
        }

        private void BGW_RunWorkerCompleted_1(object sender, RunWorkerCompletedEventArgs e)
        {
            ShowDatainCombo();
            ShowDatainGrid(ListstorageItem);
            pictureBox1.Visible = false;
        }

        private List<StorageItem> Search(List<StorageItem> ListstorageItem)
        {
            var IdType = Convert.ToInt32(Combo.SelectedValue);
            if (IdType == 0 || Combo.SelectedIndex != -1)
            {
                var list = (from A in ListstorageItem
                            where
                                A.Code.ToString().Contains(Txt_Code.Text.Trim()) &&
                                A.Description.Contains(Txt_Description.Text.Trim()) &&
                                A.TypeStorageId.ToString().Contains(IdType.ToString())

                            select A).ToList();
                return list;
            }
            else
            {
                var list = (from A in ListstorageItem
                            where
                                A.Code.ToString().Contains(Txt_Code.Text.Trim()) &&
                                A.Description.Contains(Txt_Description.Text.Trim())
                            select A).ToList();
                return list;
            }
        }

        private void ShowDatainCombo()
        {
            Combo.DataSource = Listtype;
            Combo.DisplayMember = "Name";
            Combo.ValueMember = "Id";
            Combo.SelectedIndex = -1;
            Combo.SelectedIndexChanged += Combo_SelectedIndexChanged;
        }

        private void Txt_Description_TextChanged(object sender, EventArgs e)
        {
            ShowDatainGrid(Search(ListstorageItem));
        }

        private void Combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Combo.SelectedIndex != -1)
                if (Combo.SelectedValue != (object)0)
                    ShowDatainGrid(Search(ListstorageItem));
        }

        private void Btn_First_Click(object sender, EventArgs e)
        {
            ShowDatainCombo();
            GetData();
            ShowDatainGrid(ListstorageItem);
        }
    }
}
