using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using EsfahanGhos.DataLayer;
using EsfahanGhos.Model;
using EsfahanGhos.View;

namespace EsfahanGhos
{
    public partial class Form_PayToPeople1 : Form
    {
        readonly Corporation db = new Corporation();
        private List<Person> Listpeople = null;
        Person person;
        public Form_PayToPeople1()
        {
            InitializeComponent();
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (groupBox2.Controls.Count == 7)
            {
                var formRegPeople = new RegPeopleForPAy { Location = new Point(513, 96) };
                formRegPeople.Select();
                formRegPeople.Show();
                groupBox2.Controls.Add(formRegPeople);
                GetData();
                ShowDatainCombo();
            }
            else
            {
                groupBox2.Controls[7].Dispose();
            }

        }

        private void Form_PayToPeople1_Load(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            BGW.RunWorkerAsync();
        }

        private void GetData()
        {
            Listpeople = db.Persons.AsNoTracking().Include("Payments").OrderBy(p => p.EmployeeID).ToList();
        }

        private void ShowDatainCombo()
        {
            ComboPerson.ValueMember = "EmployeeID";
            ComboPerson.DisplayMember = "EmployeeFullName";
            ComboPerson.DataSource = Listpeople;
            ComboPerson.SelectedIndex = -1;
        }

        private void BGW_DoWork(object sender, DoWorkEventArgs e)
        {
            GetData();
        }

        private void BGW_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ShowDatainCombo();
            pictureBox1.Visible = false;
        }
        private void Btn_OpenForm_Click(object sender, EventArgs e)
        {
            Form_PayToPeople2 pay2 = new Form_PayToPeople2(person);
            pay2.ShowDialog();
            GetData();
            ShowDatainCombo();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_ChartPayToPeople chart = new Form_ChartPayToPeople(person.Payments.ToList());
            chart.ShowDialog();
            GetData();
            ShowDatainCombo();
        }

        private void ComboPerson_SelectedValueChanged(object sender, EventArgs e)
        {
            if (ComboPerson.SelectedIndex != -1)
            {
                person = null;
                person = Listpeople.Single(p => p.EmployeeID == Convert.ToInt32(ComboPerson.SelectedValue));
                if (person != null)
                {
                    Txt_Name.Text = person.EmployeeFullName;
                    Txt_Phone.Text = person.CellPhone;
                    var list = person.Payments.ToList();
                    Txt_TotalPay.Text = utility.ConvertPrice(list.Sum(p => p.Cost).ToString());
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form_Payment formPayment = new Form_Payment(person.EmployeeID);
            formPayment.ShowDialog();
            GetData();
            ShowDatainCombo();
        }
    }
}
