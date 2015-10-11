using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using EsfahanGhos.DataLayer;
using EsfahanGhos.Model;

namespace EsfahanGhos
{
    public partial class Form_PaymentList : Form
    {
        Corporation db = new Corporation();
        List<Payment> ListPayments = null;
        public Form_PaymentList()
        {
            InitializeComponent();
        }

        private void BGW_DoWork(object sender, DoWorkEventArgs e)
        {
            GetData();
        }

        private void GetData()
        {
            if (ListPayments != null) ListPayments.Clear();
            ListPayments = db.Payments.AsNoTracking().Include("Check").Include("BankFish").Include("CardToCard").ToList();
        }

        private void Form_PaymentList_Load(object sender, EventArgs e)
        {
            BGW.RunWorkerAsync();
            SetDefualt();
        }

        private void SetDefualt()
        {
            Date_From.GeoDate = Date_To.GeoDate = DateTime.Now;
        }

        private void Btn_Search_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            GetData();
            List<Payment> List = Search();
            BuildGrid(List);
        }

        private List<Payment> Search()
        {
            if (ListPayments != null)
            {
                for (int i = 0; ListPayments.Count > i; i++)
                {
                    if (!check_Card.Checked)
                    {
                        if (ListPayments[i].CardToCard != null)
                            ListPayments.Remove(ListPayments[i]);
                    }
                    if (!check_Check.Checked)
                    {
                        if (ListPayments[i].Check != null)
                            ListPayments.Remove(ListPayments[i]);
                    }
                    if (!check_Fish.Checked)
                    {
                        if (ListPayments[i].BankFish != null)
                            ListPayments.Remove(ListPayments[i]);
                    }
                    if (!check_Pure.Checked)
                    {
                        if (ListPayments[i].BankFish == null && ListPayments[i].BankFish == null && ListPayments[i].CardToCard == null && ListPayments[i].Check == null)
                            ListPayments.Remove(ListPayments[i]);
                    }
                }
                List<Payment> ListT = (from A in ListPayments
                                       where
                                           (DateTime.Compare(A.Date, Date_From.GeoDate.Value) == 0 || DateTime.Compare(A.Date, Date_From.GeoDate.Value) == 1) &&
                                           (DateTime.Compare(A.Date, Date_To.GeoDate.Value) == -1 || DateTime.Compare(A.Date, Date_To.GeoDate.Value) == 0)&&
                                            (A.Name.Contains(Txt_Name.Text.Trim()))
                                       select A).ToList<Payment>();
                return ListT;
            }
            else
                return ListPayments;
        }

        private void BuildGrid(List<Payment> List)
        {
            Grid_Payments.Rows.Clear();
            if (List != null)
            {
                foreach (var item in List)
                {
                    Grid_Payments.Rows.Add( item.Reason, utility.ConvertDate_M_To_Sh(item.Date), utility.ConvertPrice(item.Cost), item.Id);
                }
            }
        }
        private void Grid_Payments_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            string tool = "توضیحات\n";
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                Payment P = ListPayments.SingleOrDefault(p => p.Id == Convert.ToInt32(Grid_Payments.Rows[e.RowIndex].Cells["ID"].Value));
                if (P.Check != null)
                {
                    tool += "پرداخت از طریق چک :\n";
                    tool += "شماره چک : " + P.Check.CheckNumber + "\n" + "تاریخ وصول : " + utility.ConvertDate_M_To_Sh(P.Check.RecoverDate);
                }
                if (P.CardToCard != null)
                {
                    tool += "پرداخت از طریق کارت به کارت :\n";
                    tool += "از شماره کارت : " + P.CardToCard.Card_Start + " به شماره کارت : " + P.CardToCard.Card_Finish + "\n";
                }
                if (P.BankFish != null)
                {
                    tool += "پرداخت از طریق فیش بانکی :\n";
                    tool += "به شماره حساب : " + P.BankFish.AccountingNumber + "\n";
                }
                if (P.BankFish == null && P.BankFish == null && P.CardToCard == null && P.Check == null)
                {
                    tool = "پرداخت نقدی\n";
                }
                if (e.ColumnIndex == 5)
                    Grid_Payments.Rows[e.RowIndex].Cells[5].ToolTipText = tool;
            }
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Grid_Payments_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if (DialogResult.Yes == MessageBox.Show("آیا میخواهید اطلاعات این پرداخت را ویرایش کنید ؟", "سوال", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    Form_Payment P = new Form_Payment(ListPayments.SingleOrDefault(p => p.Id == Convert.ToInt32(Grid_Payments.Rows[e.RowIndex].Cells["ID"].Value)));
                    P.ShowDialog();
                    GetData();
                    List<Payment> list = Search();
                    BuildGrid(list);
                }
            }
        }
    }
}
