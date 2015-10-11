using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using EsfahanGhos.DataLayer;
using EsfahanGhos.Model;

namespace EsfahanGhos
{
    public partial class FormProjectSPerson : Form
    {
        Corporation _db = new Corporation();
        List<Person> _plus = null;
        List<Int32> _Minus = null;
        List<Person> _listPerson = null;
        List<Project> _listProjects = null;
        Project project = null;
        public FormProjectSPerson()
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
            _listProjects = _db.Projects.Include("Persons").ToList();
        }

        private void BGW_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            pictureBox1.Visible = false;
            FillComboProject();
        }

        private void FillComboProject()
        {
            Combo_Project.DataSource = _listProjects;
            Combo_Project.DisplayMember = "ProjectName";
            Combo_Project.ValueMember = "ProjectID";
            Combo_Project.SelectedIndex = -1;
            Combo_Project.SelectedIndexChanged += Combo_Project_SelectedIndexChanged;
        }

        private void Combo_Project_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Combo_Project.SelectedIndex != -1)
            {
                int idproject = Convert.ToInt32(Combo_Project.SelectedValue);
                project = _db.Projects.SingleOrDefault(p => p.ProjectID == idproject);
                FillComboPerson();
                if (project != null)
                {
                    FillGrid(project.Persons.ToList());
                    _listPerson = project.Persons.ToList();
                }
                _plus = new List<Person>();
                _Minus = new List<int>();
            }
        }

        private void FillGrid(List<Person> list)
        {
            Grid_Person.DataSource = null;
            Grid_Person.AutoGenerateColumns = false;
            Grid_Person.DataSource = list;
        }

        private void FillComboPerson()
        {
            int idproject = Convert.ToInt32(Combo_Project.SelectedValue);
            Combo_Person.Enabled = true;
            Combo_Person.DataSource =
            _db.Persons.Where(person => person.Projects.All(project1 => project1.ProjectID != idproject)).ToList();
            Combo_Person.DisplayMember = "EmployeeFullName";
            Combo_Person.ValueMember = "EmployeeID";
            Combo_Person.SelectedIndex = -1;
            Combo_Person.SelectedIndexChanged += Combo_Person_SelectedIndexChanged;
        }

        private void Combo_Person_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idperson = Convert.ToInt32(Combo_Person.SelectedValue);
            Person person = _db.Persons.SingleOrDefault(p => p.EmployeeID == idperson);
            if (!_listPerson.Exists(p => person != null && p.EmployeeID == person.EmployeeID))
            {
                _listPerson.Add(person);
                _plus.Add(person);
            }
            else
            {
                utility.Show_Message("این فرد قبلا انتخاب شده", "خطا");
            }
            FillGrid(_listPerson);
        }

        private void Form_Project_sPerson_Load(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            BGW.RunWorkerAsync();
        }

        private void Grid_Person_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if (e.ColumnIndex == 4)
                {
                    int id = Convert.ToInt32(Grid_Person.Rows[e.RowIndex].Cells["id"].Value);
                    _Minus.Add(id);
                    _listPerson.Remove(_listPerson.Single(p => p.EmployeeID == id));
                    FillGrid(_listPerson);
                }
            }
        }

        private void Btn_reg_Click(object sender, EventArgs e)
        {
            if (_listPerson.Count == 0 && _listPerson == null) return;
            pictureBox1.Visible = true;
            DeleteFromDb();
            SetToDb();
            _db.SaveChanges();
            utility.Show_Message("اطلاعات با موفقیت ثبت شد", "پیغام");
            GetData();
            pictureBox1.Visible = false;
            Combo_Project.SelectedIndex = -1;
            Combo_Person.SelectedIndex = -1;
            FillGrid(null);
        }

        private void DeleteFromDb()
        {
            //int idproject = 0;
            //if (Combo_Project.SelectedIndex != -1)
            //    idproject = Convert.ToInt32(Combo_Project.SelectedValue);
            //if (idproject != 0)
            //{
            //    Project project = _listProjects.SingleOrDefault(p => p.ProjectID == idproject);
            if (project != null)
                foreach (var variable in _Minus)
                {
                    project.Persons.Remove(_db.Persons.Single(per => per.EmployeeID == variable));
                }
        }

        private void SetToDb()
        {
            //int idproject = 0;
            //if (Combo_Project.SelectedIndex != -1)
            //    idproject = Convert.ToInt32(Combo_Project.SelectedValue);
            foreach (var variable in _plus)
            {
               project.Persons.Add(variable);

            }
        }
    }
}
