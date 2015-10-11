using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using EsfahanGhos.DataLayer;
using EsfahanGhos.Model;

namespace EsfahanGhos
{
    public partial class Form_ReportPeople : Form
    {
        Corporation db = new Corporation();
        List<Person> LisPeople = null;
        List<Project> ListProject = null;
        public Form_ReportPeople()
        {
            InitializeComponent();
        }
        private void BGW_DoWork(object sender, DoWorkEventArgs e)
        {
            GetData();
        }

        private void GetData()
        {
            LisPeople = db.Persons.Include("Projects").OrderBy(p => p.EmployeeFullName).ToList<Person>();
            ListProject = db.Projects.ToList<Project>();
        }
        private void ShowDataGrid(List<Person> People)
        {
            Grid_People.Rows.Clear();
            if (People.Count != 0)
            {
                int i = 0;
                foreach (var item in People)
                {
                    Grid_People.Rows.Add(++i, item.EmployeeFullName, item.EmployeeNationalCode, item.CellPhone, utility.ConvertDate_M_To_Sh(item.EmployeeBirth), item.EmployeeID);
                }
            }
        }
        private void BGW_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            pictureBox1.Visible = false;
             ShowDataGrid(LisPeople);
            FillCombo();
        }

        private void Form_ReportPeople_Load(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            BGW.RunWorkerAsync();
        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Txt_FName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar <= '9' && e.KeyChar >= '0')
            {
                e.Handled = true;
            }
        }

        private void Txt_NationalCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
    && !char.IsDigit(e.KeyChar)
    && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void Btn_Search_Click(object sender, EventArgs e)
        {
            var List = (from A in LisPeople
                        where
                            (A.EmployeeFullName.Contains(Txt_FName.Text.Trim())) &&
                            (A.CellPhone.Contains(Txt_Cell.Text.Trim())) &&
                            (A.EmployeeNationalCode.Contains(Txt_NationalCode.Text.Trim()))&&
                            (A.FatherName.Contains(Txt_FatherName.Text.Trim()))
                        //  (A.Projects.Contains(ListProject.SingleOrDefault(p=>p.ProjectID==Convert.ToInt32(Combo_Project.SelectedValue))))
                        select A).ToList<Person>();
            ShowDataGrid(List);
        }
        private void FillCombo()
        {
            Combo_Project.DataSource = ListProject;
            Combo_Project.DisplayMember = "ProjectName";
            Combo_Project.ValueMember = "ProjectID";
            Combo_Project.SelectedIndex = -1;
        }

        private void Grid_People_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                int Id = Convert.ToInt32(Grid_People.Rows[e.RowIndex].Cells["ID"].Value);
                Form_Person FP = new Form_Person(Id);
                FP.ShowDialog();
                GetData();
                ShowDataGrid(LisPeople);
            }
        }
    }
}
