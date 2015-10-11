using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using EsfahanGhos.DataLayer;
using EsfahanGhos.Model;

namespace EsfahanGhos
{
    public partial class Form_SelectProject : Telerik.WinControls.UI.RadForm
    {
        Corporation db = new Corporation();
        List<Project> ListProject = new List<Project>();
        public Form_SelectProject()
        {
            InitializeComponent();
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            if (Combo_SelectProject.SelectedIndex == -1)
            {
                MessageBox.Show("لطفا موردی از لیست انتخاب نمایید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int ID = Convert.ToInt32(Combo_SelectProject.SelectedValue);
            Form_EnterProject P = new Form_EnterProject(ID);
            P.ShowDialog();
            GetData();
            ShowData();
        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            Form_RegisterProject P = new Form_RegisterProject();
            P.ShowDialog();
            GetData();
            ShowData();
        }

        private void Button_ListOfProject_Click(object sender, EventArgs e)
        {
            Form_ListOfProject LP = new Form_ListOfProject();
            LP.ShowDialog();
            GetData();
            ShowData();
        }
        private void Button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Form_SelectProject_Load(object sender, EventArgs e)
        {
            BGW.RunWorkerAsync();
        }
        private void BGW_DoWork(object sender, DoWorkEventArgs e)
        {
            GetData();
        }

        private void GetData()
        {
            ListProject = db.Projects.ToList<Project>();
        }

        private void BGW_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ShowData();
        }
        /// <summary>
        /// پر کردن کامبو باکس
        /// </summary>
        private void ShowData()
        {
            Combo_SelectProject.DisplayMember = "ProjectName";
            Combo_SelectProject.ValueMember = "ProjectID";
            Combo_SelectProject.DataSource = ListProject;
            Combo_SelectProject.SelectedIndex = -1;
        }
    }
}
