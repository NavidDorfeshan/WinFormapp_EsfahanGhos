using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using EsfahanGhos.DataLayer;
using EsfahanGhos.Model;

namespace EsfahanGhos
{
    public partial class Form_Salary : Form
    {
        Corporation db = new Corporation();
        List<Project> ListProject = null;
        List<Person> ListPerson = null;
        List<Salary> ListSalary = new List<Salary>();
        string virgol = "";
        long vir = 0;
        Person per = null;
        /// <summary>
        /// برای سطرهای جدول اخری
        /// </summary>
        int i = 0;
        public Form_Salary()
        {
            InitializeComponent();
        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void checkProject_CheckedChanged(object sender, EventArgs e)
        {
            if (checkProject.Checked) { Combo_Project.Enabled = true; Combo_Project.SelectedIndexChanged += Combo_Project_SelectedIndexChanged; }
            else { Combo_Project.SelectedIndex = -1; Combo_Project.Enabled = false; ShowAllDataGrid(ListPerson); }
        }

        private void Combo_Project_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Combo_Project.SelectedIndex != -1)
            {
                Project PID = ListProject.Single(p => p.ProjectID == Convert.ToInt32(Combo_Project.SelectedValue));
                ShowAllDataGrid(PID.Persons.ToList<Person>());
            }
        }
        private void BGW_DoWork(object sender, DoWorkEventArgs e)
        {
            GetData();
        }

        private void GetData()
        {
            ListProject = db.Projects.Include("Persons").ToList();
            ListPerson = db.Persons.ToList();
            //.Include("Salaries")
        }

        private void BGW_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ShowData();
        }

        private void ShowData()
        {
            FillCombo();
            pictureBox1.Visible = false;
            checkProject.Enabled = true;
            ShowAllDataGrid(ListPerson);
        }

        private void ShowAllDataGrid(List<Person> ListPeople)
        {
            Grid_People.Rows.Clear();
            if (ListPeople.Count != 0)
            {
                int i = 0;
                foreach (var item in ListPeople)
                {
                    Grid_People.Rows.Add(++i, item.EmployeeFullName, item.EmployeeNationalCode, item.CellPhone, utility.ConvertDate_M_To_Sh(item.EmployeeBirth), item.EmployeeID);
                }
            }
        }

        private void FillCombo()
        {
            Combo_Project.DataSource = ListProject;
            Combo_Project.DisplayMember = "ProjectName";
            Combo_Project.ValueMember = "ProjectID";
            Combo_Project.SelectedIndex = -1;
            Combo_P.DataSource = ListProject;
            Combo_P.DisplayMember = "ProjectName";
            Combo_P.ValueMember = "ProjectID";
            Combo_P.SelectedIndex = -1;
        }

        private void Form_Salary_Load(object sender, EventArgs e)
        {
            SetDefault();
            BGW.RunWorkerAsync();
            Combo_Project.SelectedIndex = -1;
            Combo_P.SelectedIndex = -1;
        }

        private void SetDefault()
        {
            pictureBox1.Visible = true;
            checkProject.Enabled = false;
        }

        private void Txt_Fname_TextChanged(object sender, EventArgs e)
        {
            if (Combo_Project.SelectedIndex == -1)
            {
                var list = (from A in ListPerson where A.EmployeeFullName.Contains(Txt_Fname.Text.Trim()) select A).ToList<Person>();
                ShowAllDataGrid(list);
            }
            else
            {
                Project PID = ListProject.Single(p => p.ProjectID == Convert.ToInt32(Combo_Project.SelectedValue));
                var list = (from A in PID.Persons where A.EmployeeFullName.Contains(Txt_Fname.Text.Trim()) select A).ToList<Person>();
                ShowAllDataGrid(list);
            }
        }

        private void Grid_ListSalary_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex == Grid_ListSalary.Columns["Remove"].Index && e.RowIndex != -1)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                e.Graphics.DrawImage(Properties.Resources.del, e.CellBounds.Left + 1, e.CellBounds.Top);
                e.Handled = true;
            }
        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            ClearSalaryInfo();
        }

        private void ClearSalaryInfo()
        {
            Txt_Cost.Text = Txt_Description.Text = Txt_CellPhone.Text = Txt_NationalCode.Text = Txt_Name.Text = Txt_Father.Text = "";
            Txt_DateFinish.GeoDate = Txt_DateStart.GeoDate = DateTime.Now;
            Combo_P.SelectedIndex = -1;
        }

        private void Grid_People_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                SetDatainSalaryInfo(Convert.ToInt32(Grid_People.Rows[e.RowIndex].Cells["ID"].Value));
            }
        }

        private void SetDatainSalaryInfo(int p)
        {
            Person s = ListPerson.Single(a => a.EmployeeID == p);
            per = s;
            Txt_Name.Text = s.EmployeeFullName;
            Txt_NationalCode.Text = s.EmployeeNationalCode;
            Txt_Father.Text = s.FatherName;
            Txt_CellPhone.Text = s.CellPhone;
        }

        private void Btn_RegList_Click(object sender, EventArgs e)
        {
            if (Txt_Name.Text.Trim() == "")
            {
                MessageBox.Show("لطفا ابتدا از لیست بالا موردی انتخاب نمایید.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Txt_Cost.Text.Trim() == "")
            {
                MessageBox.Show("لطفا تمام موارد را پرکنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Combo_P.SelectedIndex != -1)
            {
                int Id = Convert.ToInt32(Combo_P.SelectedValue);
                var project = db.Persons.Single(p=>p.EmployeeID==per.EmployeeID).Projects.SingleOrDefault(p => p.ProjectID == Id);
                if (project == null)
                {
                    MessageBox.Show("این فرد در این پروژه حضور ندارد ", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            Reg();
        }

        private void Reg()
        {
            Salary S = new Salary()
            {
                Cost = utility.ConvertCommaPrice(Txt_Cost.Text.Trim()),
                Description = Txt_Description.Text.Trim(),
                DateStart = Txt_DateStart.GeoDate.Value,
                DateFinish = Txt_DateFinish.GeoDate.Value,
                Date = Date.GeoDate.Value,
                Person = per
            };
            if (Combo_P.SelectedIndex != -1)
            {
                S.Project = ListProject.Single(p => p.ProjectID == Convert.ToInt32(Combo_P.SelectedValue));
            }
            ListSalary.Add(S);
            Grid_ListSalary.Rows.Add(++i, per.EmployeeFullName, per.EmployeeNationalCode, utility.ConvertPrice(S.Cost), per.EmployeeID, S.Id);
            per = null;
            ClearSalaryInfo();
            Txt_Fname.Focus();
        }

        private void Grid_ListSalary_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                int SalaryID = Convert.ToInt32(Grid_ListSalary.Rows[e.RowIndex].Cells["salaryid"].Value);
                Salary S = ListSalary.Single(p => p.Id == SalaryID);
                int PersonID = Convert.ToInt32(Grid_ListSalary.Rows[e.RowIndex].Cells["ID1"].Value);
                if (e.ColumnIndex == 5)
                {
                    ListSalary.Remove(ListSalary.Single(p => p.Id == SalaryID));
                    Grid_ListSalary.Rows.Remove(Grid_ListSalary.Rows[e.RowIndex]);
                }
                SetDatainSalaryInfo(PersonID);
                Txt_Cost.Text = utility.ConvertPrice(S.Cost);
                Txt_DateFinish.GeoDate = S.DateFinish;
                Txt_DateStart.GeoDate = S.DateFinish;
                Date.GeoDate = S.Date;
                Txt_Description.Text = S.Description;
                if (S.Project != null)
                    Combo_P.SelectedValue = S.Project.ProjectID;
                ListSalary.Remove(ListSalary.Single(p => p.Id == SalaryID));
                Grid_ListSalary.Rows.Remove(Grid_ListSalary.Rows[e.RowIndex]);
            }
        }

        private void Btn_RegSalary_Click(object sender, EventArgs e)
        {
            if (ListSalary.Count != 0)
            {
                foreach (var item in ListSalary)
                {
                    if (item.Project != null)
                        item.Project.TotalCost += item.Cost;
                    db.Salaries.Add(item);
                }
                db.SaveChanges();
                utility.Show_Message("اطلاعات این دستمزدها ثبت شد", "پیغام");
                GetData();
                ClearSalaryInfo();
                ListSalary.Clear();
                checkProject.Checked = false;
                Combo_Project.SelectedIndex = -1;
                Grid_ListSalary.Rows.Clear();
            }
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
