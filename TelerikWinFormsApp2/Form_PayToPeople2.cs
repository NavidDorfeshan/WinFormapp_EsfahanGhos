using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EsfahanGhos.DataLayer;
using EsfahanGhos.Model;

namespace EsfahanGhos
{
    public partial class Form_PayToPeople2 : Form
    {
        private Corporation db = new Corporation();
        private List<Payment> Listpeyment = null;
        private readonly Person person;

        public Form_PayToPeople2(Person P)
        {
            person = P;
            InitializeComponent();
        }

        private void Form_PayToPeople2_Load(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            BGW.RunWorkerAsync();
        }

        private void BGW_DoWork(object sender, DoWorkEventArgs e)
        {
            GetData();
        }

        private void GetData()
        {
            Listpeyment = db.Payments.Where(p => p.PersonId == person.EmployeeID).ToList();
        }

        private void BGW_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            pictureBox1.Visible = false;
            Txt_Name.Text = person.EmployeeFullName;
            ShowDataGrid(Listpeyment);
            SetDate();
        }

        private void SetDate()
        {
            if (Listpeyment.Count != 0)
            {
                FromDate.GeoDate = Listpeyment.Min(p => p.Date);
                ToDate.GeoDate = Listpeyment.Max(p => p.Date);
            }
            else
            {
                FromDate.GeoDate = ToDate.GeoDate = DateTime.Now;
            }
        }

        private void ShowDataGrid(List<Payment> ListPeyment)
        {
            Grid.AutoGenerateColumns = false;
            List<GRidShow> ListGridShow = ListPeyment.Select(payment => new GRidShow()
            {
                Id = payment.Id,
                Cost = utility.ConvertPrice(payment.Cost),
                Date = utility.ConvertDate_M_To_Sh(payment.Date),
                Reason = payment.Reason
            }).ToList();
            Grid.DataSource = ListGridShow;
        }

        private List<Payment> Search(List<Payment> List)
        {
            var listp = (from A in List
                         where
                             (DateTime.Compare(A.Date, FromDate.GeoDate.Value) >= 0 &&
                              DateTime.Compare(A.Date, ToDate.GeoDate.Value) <= 0)
                         select A).ToList();
            return listp;
        }

        private void Btn_Search_Click(object sender, EventArgs e)
        {
            ShowDataGrid(Search(Listpeyment));
        }

        private void Grid_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if (e.ColumnIndex == 3 || e.ColumnIndex == 4 || e.ColumnIndex == 5)
                {
                    Form_Payment P = new Form_Payment(Listpeyment.SingleOrDefault(p => p.Id == Convert.ToInt32(Grid.Rows[e.RowIndex].Cells["Id"].Value)));
                    P.ShowDialog();
                    BGW.RunWorkerAsync();
                }
            }
        }

        private void Btn_Chart_Click(object sender, EventArgs e)
        {
            Form_ChartPayToPeople chart = new Form_ChartPayToPeople(Listpeyment);
            chart.ShowDialog();
        }

        private void Print(List<Payment> List)
        {
            stiReport1.Dictionary.Variables[0].Value = utility.ConvertDate_M_To_Sh(DateTime.Now);
            stiReport1.Dictionary.Variables[1].Value = person.EmployeeFullName;
            stiReport1.Dictionary.Variables[2].Value = utility.ConvertPrice(List.Sum(p => p.Cost));
            List<GRidShow> ListGridShow = List.Select(payment => new GRidShow()
            {
                Id = payment.Id,
                Cost = utility.ConvertPrice(payment.Cost),
                Date = utility.ConvertDate_M_To_Sh(payment.Date),
                Reason = payment.Reason
            }).ToList();
            stiReport1.RegBusinessObject("Payments", ListGridShow);
            stiReport1.Show();
        }

        private void Btn_Print_Click(object sender, EventArgs e)
        {
            Print(Listpeyment);
        }
    }
}
