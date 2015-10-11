using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using EsfahanGhos.DataLayer;
using EsfahanGhos.Model;
using EsfahanGhos.Temp;

namespace EsfahanGhos
{
    public partial class Form_ListSalaries : Form
    {
        Corporation db = new Corporation();
        List<Salary> ListSalaries = null;
        List<Project> ListP = null;
        List<Salary> List = new List<Salary>();
        string virgol = "";
        long vir = 0;
        int Row = -1;
        public Form_ListSalaries()
        {
            InitializeComponent();
        }
        private void Btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BGW_DoWork(object sender, DoWorkEventArgs e)
        {
            GetData();
        }

        private void GetData()
        {
            ListSalaries = db.Salaries.Include("Person").Include("Project").ToList<Salary>();
            ListP = db.Projects.ToList<Project>();
        }

        private void BGW_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            SetDateTime();
            ShowDatainComo();
            FillGrid(ListSalaries);
            checkProject.Enabled = true;
            Btn_Print.Click += Btn_Print_Click;
        }

        private void SetDateTime()
        {
            if (ListSalaries.Count != 0)
            {
                DateTime Max = ListSalaries.Max(p => p.DateFinish);
                DateTime Min = ListSalaries.Min(p => p.DateFinish);
                Date_From.GeoDate = Min;
                Date_To.GeoDate = Max;
            }
        }

        private void FillGrid(List<Salary> L)
        {
            Grid_ListSalary.Rows.Clear();
            if (L.Count != 0)
            {
                int i = 0;
                foreach (var item in L)
                {
                    if (item.Project == null)
                        Grid_ListSalary.Rows.Add(++i, item.Person.EmployeeFullName, item.Person.EmployeeNationalCode,
                            "ندارد", utility.ConvertDate_M_To_Sh(item.DateStart), utility.ConvertDate_M_To_Sh(item.DateFinish), utility.ConvertPrice(item.Cost), item.Id);
                    else
                        Grid_ListSalary.Rows.Add(++i, item.Person.EmployeeFullName, item.Person.EmployeeNationalCode, item.Project.ProjectName, utility.ConvertDate_M_To_Sh(item.DateStart), utility.ConvertDate_M_To_Sh(item.DateFinish), utility.ConvertPrice(item.Cost), item.Id);

                }
            }
        }

        private void ShowDatainComo()
        {
            Combo_Project.DataSource = ListP;
            Combo_Project.DisplayMember = "ProjectName";
            Combo_Project.ValueMember = "ProjectID";
            Combo_Project.SelectedIndex = -1;
            Combo_P.DataSource = ListP;
            Combo_P.DisplayMember = "ProjectName";
            Combo_P.ValueMember = "ProjectID";
            Combo_P.SelectedIndex = -1;
        }

        private void Form_ListSalaries_Load(object sender, EventArgs e)
        {
            BGW.RunWorkerAsync();
            Combo_Project.SelectedIndex = -1;
        }
        private void checkProject_CheckedChanged(object sender, EventArgs e)
        {
            if (checkProject.Checked) { Combo_Project.Enabled = true; }
            else { Combo_Project.SelectedIndex = -1; Combo_Project.Enabled = false; }
        }

        private void Txt_Cost_TextChanged(object sender, EventArgs e)
        {
            if (Txt_Cost.Text.Trim() != "")
            {
                if (Txt_Cost.Text != virgol)
                {
                    vir = utility.ConvertCommaPrice(Txt_Cost.Text.Trim());
                    if (vir != -1)
                    {
                        virgol = utility.ConvertPrice(vir);
                        Txt_Cost.Text = virgol;
                    }
                    Txt_Cost.Select(Txt_Cost.Text.Length, 0);
                }
            }
        }

        private void Btn_Search_Click(object sender, EventArgs e)
        {
            List.Clear();
            if (Combo_Project.SelectedIndex != -1)
            {
                List = (from a in db.Salaries.Include("Person").Include("Project").ToList<Salary>()
                        where
                            (a.Person.EmployeeFullName.Contains(Txt_Fname.Text.Trim())) &&
                            (a.ProjectId == Convert.ToInt32(Combo_Project.SelectedValue)) &&
                            (DateTime.Compare(a.DateStart, Date_From.GeoDate.Value) == 0 || DateTime.Compare(a.DateStart, Date_From.GeoDate.Value) == 1) &&
                            (DateTime.Compare(a.DateFinish, Date_To.GeoDate.Value) == 0 || DateTime.Compare(a.DateFinish, Date_To.GeoDate.Value) == -1)
                        select a).ToList();
                FillGrid(List);
            }
            else
            {
                List = (from a in db.Salaries.Include("Person").Include("Project").ToList()
                        where
                            (a.Person.EmployeeFullName.Contains(Txt_Fname.Text.Trim())) &&
                            (DateTime.Compare(a.DateStart, Date_From.GeoDate.Value) == 0 || DateTime.Compare(a.DateStart, Date_From.GeoDate.Value) == 1) &&
                            (DateTime.Compare(a.DateFinish, Date_To.GeoDate.Value) == 0 || DateTime.Compare(a.DateFinish, Date_To.GeoDate.Value) == -1)
                        select a).ToList();
                FillGrid(List);
            }
        }

        private void Grid_ListSalary_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                ClearText();
                Row = e.RowIndex;
                Btn_Edit.Click += Btn_Edit_Click;
                Btn_Delete.Click += Btn_Delete_Click;
                Salary S = ListSalaries.SingleOrDefault(p => p.Id == Convert.ToInt32(Grid_ListSalary.Rows[e.RowIndex].Cells["salaryid"].Value));
                Txt_FatherName.Text = S.Person.FatherName;
                Txt_name.Text = S.Person.EmployeeFullName;
                Txt_NationalCode.Text = S.Person.EmployeeNationalCode;
                Txt_Cell.Text = S.Person.CellPhone;
                Txt_Cost.Text = utility.ConvertPrice(S.Cost);
                Txt_Description.Text = S.Description;
                if (S.ProjectId != null) Combo_P.SelectedValue = S.ProjectId;
                else Combo_P.SelectedIndex = -1;
                Txt_DateStart.GeoDate = S.DateStart;
                Txt_DateFinish.GeoDate = S.DateFinish;
                Date.GeoDate = S.Date;
            }
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            Salary S = ListSalaries.SingleOrDefault(p => p.Id == Convert.ToInt32(Grid_ListSalary.Rows[Row].Cells["salaryid"].Value));
            if (S.Project != null) S.Project.TotalCost -= S.Cost;
            db.Salaries.Remove(S);
            db.SaveChanges();
            utility.Show_Message("اطلاعات با موفقیت حذف شد", "پیغام");
            BGW.RunWorkerAsync();
            ClearText();
        }

        private void ClearText()
        {
            Txt_FatherName.Text =
            Txt_name.Text =
            Txt_NationalCode.Text =
            Txt_Cell.Text =
            Txt_Cost.Text =
            Txt_Description.Text = "";
            Combo_P.SelectedIndex = -1;
            Txt_DateStart.GeoDate = DateTime.Now;
            Txt_DateFinish.GeoDate = DateTime.Now;
            Date.GeoDate = DateTime.Now;
        }

        private void Btn_Edit_Click(object sender, EventArgs e)
        {
            Salary S = ListSalaries.SingleOrDefault(p => p.Id == Convert.ToInt32(Grid_ListSalary.Rows[Row].Cells["salaryid"].Value));
            if (S.Project != null) S.Project.TotalCost -= S.Cost;
            S.Cost = utility.ConvertCommaPrice(Txt_Cost.Text.Trim());
            S.Date = Date.GeoDate.Value;
            S.DateFinish = Txt_DateFinish.GeoDate.Value;
            S.DateStart = Txt_DateStart.GeoDate.Value;
            S.Description = Txt_Description.Text.Trim();
            if (Combo_P.SelectedIndex == -1) S.ProjectId = null;
            else
            {
                S.ProjectId = Convert.ToInt32(Combo_P.SelectedValue);
                S.Project.TotalCost += S.Cost;
            }

            db.SaveChanges();
            utility.Show_Message("اطلاعات با موفقیت ویرایش شد", "پیغام");
            BGW.RunWorkerAsync();
            ClearText();
        }

        private void Btn_Print_Click(object sender, EventArgs e)
        {

            if (List.Count != 0)
            {
                List<SalaryTemp> ListT = new List<SalaryTemp>();
                long t = 0;
                foreach (var item in List)
                {
                    SalaryTemp S = new SalaryTemp()
                    {
                        Fname = item.Person.EmployeeFullName,
                        NationalCode = item.Person.EmployeeNationalCode,
                        FromDate = utility.ConvertDate_M_To_Sh(item.DateStart),
                        ToDate = utility.ConvertDate_M_To_Sh(item.DateFinish),
                        Cost = item.Cost
                    };
                    if (item.Project != null) S.ProjectName = item.Project.ProjectName;
                    else S.ProjectName = "ندارد";
                    t += item.Cost;
                    ListT.Add(S);
                }
                Print_Salary.Dictionary.Variables[0].Value = utility.ConvertDate_M_To_Sh(DateTime.Now);
                Print_Salary.Dictionary.Variables[1].Value = utility.ConvertDate_M_To_Sh(Date_From.GeoDate.Value);
                Print_Salary.Dictionary.Variables[2].Value = utility.ConvertDate_M_To_Sh(Date_To.GeoDate.Value);
                Print_Salary.RegBusinessObject("ListSalary", ListT);
                Print_Salary.Dictionary.Variables[3].Value = utility.ConvertPrice(t);
                Print_Salary.Show();
            }
        }
        private void Alphabet_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar <= '9' && e.KeyChar >= '0')
            {
                e.Handled = true;
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
    }
}
