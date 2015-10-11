using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using EsfahanGhos.DataLayer;
using EsfahanGhos.Model;

namespace EsfahanGhos
{
    public partial class Form_ShowBlock : Form
    {
        Corporation db = new Corporation();
        List<Block> ListBlock = new List<Block>();
        int id = 0;
        public Form_ShowBlock(int Project)
        {
            id = Project;
            InitializeComponent();
        }

        private void Form_ShowBlock_Load(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            BGW.RunWorkerAsync();
        }

        private void BGW_DoWork(object sender, DoWorkEventArgs e)
        {
            Getdata();
        }

        private void Getdata()
        {
            ListBlock = db.Blocks.Where(p => p.ProjectID == id).ToList();
        }

        private void BGW_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            pictureBox1.Visible = false;
            ShowDatainGrid();
        }

        private void ShowDatainGrid()
        {
              Grid.Rows.Clear();
            if (ListBlock.Count != 0)
            {
                int i = 0;
                foreach (var item in ListBlock)
                {
                    Grid.Rows.Add(item.BlockID, ++i, item.BlockName, item.NumberOfUnits, "حذف");
                }
            }
            else
            {
                LB_Nothing.Visible = true;
            }
        }

        private void Grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if (e.ColumnIndex == 4)
                {
                    if (MessageBox.Show("آیا میخواهید این بلوک را حذف کنید ؟", "حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        int bid = Convert.ToInt32(Grid.Rows[e.RowIndex].Cells[0].Value);
                        db.Blocks.Remove(db.Blocks.SingleOrDefault(p => p.BlockID == bid));
                        db.SaveChanges();
                        Getdata();
                        ShowDatainGrid();
                    }
                }
            }
        }

        private void Grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != 4)
            {
                int bid = Convert.ToInt32(Grid.Rows[e.RowIndex].Cells[0].Value);
                Form_Block_sProjects fpBlockSProjects=new Form_Block_sProjects(db.Blocks.SingleOrDefault(p=>p.BlockID==bid));
                fpBlockSProjects.ShowDialog();
                Getdata();
                ShowDatainGrid();
            }
        }
    }
}
