using System;
using System.Windows.Forms;

namespace EsfahanGhos
{
    public partial class Form_Accounting : Form
    {
        public Form_Accounting()
        {
            InitializeComponent();
        }

        private void Btn_RegSalary_Click(object sender, EventArgs e)
        {
            Form_Salary FS = new Form_Salary();
            FS.ShowDialog();
        }

        private void Btn_ListSalaries_Click(object sender, EventArgs e)
        {
            Form_ListSalaries FL = new Form_ListSalaries();
            FL.ShowDialog();
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_PaymentsList_Click(object sender, EventArgs e)
        {
            Form_PaymentList FP = new Form_PaymentList();
            FP.ShowDialog();
        }

        private void Btn_ListPayments_Click(object sender, EventArgs e)
        {
            Form_PaymentList FPL = new Form_PaymentList();
            FPL.ShowDialog();
        }

        private void Btn_NewPayment_Click(object sender, EventArgs e)
        {
            Form_RegNewPayment fpFormRegNewPayment = new Form_RegNewPayment();
            fpFormRegNewPayment.ShowDialog();
        }

        private void btn_ChartSalary_Click(object sender, EventArgs e)
        {
            Form_ChartSalary FC = new Form_ChartSalary();
            FC.ShowDialog();
        }

        private void Btn_PayToPeople_Click(object sender, EventArgs e)
        {
            Form_PayToPeople1 people1 = new Form_PayToPeople1();
            people1.ShowDialog();
        }
    }
}
