using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using EsfahanGhos.DataLayer;
using EsfahanGhos.Model;

namespace EsfahanGhos
{
    public partial class Form_ChartSalary : Form
    {
        Corporation db = new Corporation();
        private IList<Person> Listperson = null;
        private IList<Project> Listproject = null;
        public Form_ChartSalary()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BGW.RunWorkerAsync();
        }

        private void BGW_DoWork(object sender, DoWorkEventArgs e)
        {
            Listproject = db.Projects.Include("Persons").ToList();
            Listperson = db.Persons.Include("Salaries").ToList();
        }

        private void BGW_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            FillComboProject();
            FillComboPerson(Listperson);
        }

        private void FillComboPerson(IList<Person> Listperson)
        {
            Combo_Person.DataSource = Listperson;
            Combo_Person.DisplayMember = "EmployeeFullName";
            Combo_Person.ValueMember = "EmployeeID";
            Combo_Person.SelectedIndex = -1;
            Combo_Person.SelectedIndexChanged += Combo_Person_SelectedIndexChanged;
        }

        private void FillComboProject()
        {
            Combo_Project.DataSource = Listproject;
            Combo_Project.DisplayMember = "ProjectName";
            Combo_Project.ValueMember = "ProjectID";
            Combo_Project.SelectedIndex = -1;
            Combo_Project.SelectedIndexChanged += Combo_Project_SelectedIndexChanged;
        }

        private void Combo_Project_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Combo_Project.SelectedIndex != -1)
            {
                int Id = Convert.ToInt32(Combo_Project.SelectedValue);
                Project project = Listproject.Single(p => p.ProjectID == Id);
                FillComboPerson(project.Persons.ToList());
            }
        }
        private void Combo_Person_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Combo_Person.SelectedIndex != -1)
            {
                int Id = Convert.ToInt32(Combo_Person.SelectedValue);
                var person = Listperson.Single(p => p.EmployeeID == Id);
                CreatChart(person);
            }
        }

        private void CreatChart(Person person)
        {
            if (Combo_Project.SelectedIndex == -1)
            {
                chart1.Series.Clear();
                int i = 0;
                List<Salary> Lists = person.Salaries.ToList();
                foreach (Salary item in Lists)
                {
                    Series series = this.chart1.Series.Add
                        (++i + " _ " + " از " + utility.ConvertDate_M_To_Sh(item.DateStart) + " تا " +
                         utility.ConvertDate_M_To_Sh(item.DateFinish));
                    series.Font = new Font("B Nazanin", 10.2F, System.Drawing.FontStyle.Bold,
                        System.Drawing.GraphicsUnit.Point, ((byte)(178)));
                    series.IsValueShownAsLabel = true;
                    series.Points.Add(Convert.ToDouble(item.Cost));
                }
            }
            else
            {
                chart1.Series.Clear();
                int i = 0;
                List<Salary> Lists = person.Salaries.Where(p => p.ProjectId == Convert.ToInt32(Combo_Project.SelectedValue)).ToList();
                foreach (Salary item in Lists)
                {
                    var series = this.chart1.Series.Add
                        (++i + " _ " + " از " + utility.ConvertDate_M_To_Sh(item.DateStart) + " تا " +
                         utility.ConvertDate_M_To_Sh(item.DateFinish));
                    series.Font = new Font("B Nazanin", 10.2F, System.Drawing.FontStyle.Bold,
                        System.Drawing.GraphicsUnit.Point, ((byte)(178)));
                    series.IsValueShownAsLabel = true;
                    series.Points.Add(Convert.ToDouble(item.Cost));
                }
            }

        }

        private void Btn_Print_Click(object sender, EventArgs e)
        {
            chart1.Printing.PrintPreview();
        }
    }
}
