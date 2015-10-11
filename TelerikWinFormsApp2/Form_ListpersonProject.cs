using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using EsfahanGhos.DataLayer;
using EsfahanGhos.Model;
using EsfahanGhos.Temp;

namespace EsfahanGhos
{
    public partial class Form_ListpersonProject : Form
    {
        Corporation db = new Corporation();
        Project project = null;
        int id = 0;
        public Form_ListpersonProject(int projectid)
        {
            id = projectid;
            InitializeComponent();
        }

        private void Form_ListpersonProject_Load(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Enabled = false;
            BGW.RunWorkerAsync();
        }

        private void BGW_DoWork(object sender, DoWorkEventArgs e)
        {
            GetData();
        }

        private void GetData()
        {
            project = db.Projects.Include(p => p.Persons).Single(p => p.ProjectID == id);
        }

        private void BGW_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            splitContainer1.Panel2.Enabled = true;
            FillGrid(project.Persons.ToList());
        }

        private void FillGrid(List<Person> P)
        {
            Grid_Person.DataSource = P;
        }

        private void Txt_Name_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void Search()
        {
            var List = (from A in project.Persons
                        where
                            (A.EmployeeFullName.Contains(Txt_Name.Text.Trim())) &&
                            (A.EmployeeNationalCode.Contains(Txt_Code.Text.Trim())) &&
                            (A.CellPhone.Contains(Txt_Phone.Text.Trim()))
                        select A).ToList();
            FillGrid(List);
        }

        private void Btn_Print_Click(object sender, EventArgs e)
        {
            
            Print_Persons.Dictionary.Variables[0].Value = utility.ConvertDate_M_To_Sh(DateTime.Now);
            Print_Persons.Dictionary.Variables[1].Value = project.ProjectName;
            List<SalaryTemp> ListT = new List<SalaryTemp>();
            foreach (var item in project.Persons.ToList())
            {
                SalaryTemp S = new SalaryTemp()
                {
                    Fname = item.EmployeeFullName,
                    NationalCode = item.FatherName,
                    ProjectName = item.EmployeeNationalCode,
                    FromDate = item.CellPhone,
                };
                ListT.Add(S);
            }
            Print_Persons.RegBusinessObject("ListPerson", ListT);
            Print_Persons.Render(true);
            Print_Persons.Show();

        }

        private void Btn_BAck_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Grid_Person_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if (e.ColumnIndex == 6)
                {
                    if (MessageBox.Show("آیا میخواهید این فرد را از لیست افراد این پروژه حذف نمایید؟", "سوال", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        int Id = Convert.ToInt32(Grid_Person.Rows[e.RowIndex].Cells["id"].Value);
                        Person P = db.Persons.SingleOrDefault(p => p.EmployeeID == Id);
                        project.Persons.Remove(P);
                        db.SaveChanges();
                        GetData();
                        FillGrid(project.Persons.ToList());
                        Txt_Name.Text = Txt_Code.Text = Txt_Phone.Text = "";

                    }
                }
            }
        }
    }
}
