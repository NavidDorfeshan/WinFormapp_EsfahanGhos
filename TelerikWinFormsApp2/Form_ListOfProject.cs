using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using EsfahanGhos.DataLayer;
using EsfahanGhos.Model;

namespace EsfahanGhos
{
    public partial class Form_ListOfProject : Telerik.WinControls.UI.RadForm
    {
        Corporation db = new Corporation();
        List<Project> ListProjects = new List<Project>();
        public Form_ListOfProject()
        {
            InitializeComponent();
        }
        private void Button_Close_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void Form_ListOfProject_Load(object sender, EventArgs e)
        {
            BGW.RunWorkerAsync();
        }

        private void BGW_DoWork(object sender, DoWorkEventArgs e)
        {
            GetData();
        }
        /// <summary>
        /// گرفتن اطلاعات از پایگاه داده
        /// </summary>
        private void GetData()
        {
            ListProjects = db.Projects.ToList<Project>();
        }

        private void BGW_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ShowData();
        }
        /// <summary>
        /// نمایش اطلاعات در جدول
        /// </summary>
        private void ShowData()
        {
            GridProject.AutoGenerateColumns = false;
            GridProject.DataSource = ListProjects;
            foreach (var item in GridProject.Rows)
            {
                item.Cells["Date"].Value = utility.ConvertDate_M_To_Sh(ListProjects.Single(p => p.ProjectID == Convert.ToInt32(item.Cells["ProjectID"].Value)).ProjectStart);
            }
        }
        /// <summary>
        /// جستجو
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Txt_ProjectID_TextChanged(object sender, EventArgs e)
        {
            Search(Txt_ProjectID.Text.Trim(), Txt_PName.Text.Trim(), Txt_NameKarfarma.Text.Trim());
        }

        private void Txt_PName_TextChanged(object sender, EventArgs e)
        {
            Search(Txt_ProjectID.Text.Trim(), Txt_PName.Text.Trim(), Txt_NameKarfarma.Text.Trim());
        }
        private void Txt_NameKarfarma_TextChanged(object sender, EventArgs e)
        {
            Search(Txt_ProjectID.Text.Trim(), Txt_PName.Text.Trim(), Txt_NameKarfarma.Text.Trim());
        }
        private void Search(string p1, string p2, string p3)
        {
            if(Txt_ProjectID.Text.Trim()==""&& Txt_PName.Text.Trim()==""&& Txt_NameKarfarma.Text.Trim()=="")
            {
                GetData();
                ShowData();
            }
            ListProjects=(from V in ListProjects
                            where (V.ProjectID.ToString().Contains(p1) || p1 == "")&&
                            (V.ProjectName.ToString().Contains(p2)|| p2=="")
                            select V).ToList<Project>();
            ShowData();
        }

        private void GridProject_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            Form_EnterProject LP = new Form_EnterProject(Convert.ToInt32(GridProject.Rows[e.RowIndex].Cells["ProjectID"].Value));
            LP.ShowDialog();
            GetData();
            ShowData();
        }

        private void Button_Report_Click(object sender, EventArgs e)
        {
        }
    }
}
