using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using EsfahanGhos.DataLayer;
using EsfahanGhos.Model;

namespace EsfahanGhos.View
{
    public partial class BankFish : UserControl
    {
        Corporation db = new Corporation();
        long vir = 0;
        string virgol = "";
        Credit Cr = null;
        Factor Fa = null;
        PurchaseList Pu = null;
        Project Pro = null;
        List<Factor> ListFactor = null;
        List<Credit> ListCredit = null;
        List<PurchaseList> ListPurchaseList = null;
        Payment Pa = null;
        Model.BankFish Ba = null;
        private int PersonId;
        enum States { WriteC, WriteF, WriteP, WritePro, Edit,Normal ,people};
        States State = States.WriteC;
        public BankFish(Credit C)
        {
            State = States.WriteC;
            Cr = C;
            InitializeComponent();
            Btn_Edit.Enabled = Btn_Delete.Enabled = false;
        }
        public BankFish(Factor F)
        {
            State = States.WriteF;
            Fa = F;
            InitializeComponent();
            Btn_Edit.Enabled = Btn_Delete.Enabled = false;
        }
        public BankFish(PurchaseList P)
        {
            State = States.WriteP;
            Pu = P;
            InitializeComponent();
            Btn_Edit.Enabled = Btn_Delete.Enabled = false;
        }
        public BankFish(Project P)
        {
            State = States.WritePro;
            Pro = P;
            InitializeComponent();
            Btn_Edit.Enabled = Btn_Delete.Enabled = false;
        }
        public BankFish(Payment P, Model.BankFish B)
        {
            State = States.Edit;
            Pa = P;
            Ba = B;
            InitializeComponent();
            Btn_Reg.Enabled = false;
        }

        public BankFish()
        {
            State = States.Normal;
            InitializeComponent();
        }

        public BankFish(int personId)
        {
            PersonId = personId;
            State = States.people;
            InitializeComponent();
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

        private void Txt_Price_TextChanged(object sender, EventArgs e)
        {
            if (Txt_Price.Text.Trim() != "")
            {
                if (Txt_Price.Text != virgol)
                {
                    vir = utility.ConvertCommaPrice(Txt_Price.Text.Trim());
                    if (vir != -1)
                    {
                        virgol = utility.ConvertPrice(vir);
                        Txt_Price.Text = virgol;
                    }
                    Txt_Price.Select(Txt_Price.Text.Length, 0);
                }
            }
        }
        private void BGW_DoWork(object sender, DoWorkEventArgs e)
        {
            GetData();
        }

        private void GetData()
        {
            if (State == States.WriteC)
            {
                ListCredit = db.Credits.ToList<Credit>();

            }
            if (State == States.WriteF)
            {
                ListFactor = db.Factors.ToList<Factor>();
            }
            if (State == States.WriteP)
            {
                ListPurchaseList = db.PurchaseLists.ToList<PurchaseList>();

            }
        }

        private void BankFish_Load(object sender, EventArgs e)
        {
            BGW.RunWorkerAsync();
            Date.GeoDate = DateTime.Now;
        }
        private bool CheckError()
        {
          //  if (Txt_AccountingNumber.Text.Trim() == "" || Txt_NameFinish.Text.Trim() == "" || Txt_NameS.Text.Trim() == "" || Txt_Price.Text.Trim() == "")
              //  return false;
           // else 
            return true;
        }
        private void Clear()
        {
            Txt_Price.Text = Txt_NameS.Text = Txt_NameFinish.Text = Txt_Desc.Text = Txt_Reason.Text = Txt_AccountingNumber.Text = "";
            Date.GeoDate = DateTime.Now;
        }
        private void Btn_Reg_Click(object sender, EventArgs e)
        {
            if (CheckError())
            {
                Reg();
                Clear();
            }
            else MessageBox.Show("لطفا تمامی موارد ستاره دار را پر کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Reg()
        {
            Payment P = new Payment()
            {
                Reason = Txt_Reason.Text.Trim(),
                Name = Txt_NameFinish.Text.Trim(),
                Description = Txt_Desc.Text.Trim(),
                Cost = utility.ConvertCommaPrice(Txt_Price.Text.Trim()),
                Date = Date.GeoDate.Value,
            };
            db.Payments.Add(P);
            if (State == States.WriteC)
            {
                Credit c = ListCredit.Single(p => p.CreditID == Cr.CreditID);
                P.Credit = c;
            }
            if (State == States.WriteF)
            {
                Factor c = ListFactor.Single(p => p.FactorID == Fa.FactorID);
                P.Factor = c;
            }
            if (State == States.WriteP)
            {
                PurchaseList c = ListPurchaseList.Single(p => p.PurchaseListID == Pu.PurchaseListID);
                P.PurchaseList = c;
            }
            if (State == States.people)
            {
                P.PersonId = PersonId;
            }
            Model.BankFish BankFish = new Model.BankFish()
            {
                AccountingNumber = Convert.ToInt64(Txt_AccountingNumber.Text.Trim()),
                Name_Start = Txt_NameS.Text.Trim()
            };
            P.BankFish = BankFish;
            db.SaveChanges();
            utility.Show_Message("اطلاعات این پرداخت با موفقیت ثبت شد", "پیغام");
        }

        private void BGW_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (State == States.Edit)
            {
                EditFill();
            }
        }

        private void EditFill()
        {
            Model.BankFish BankE = db.Payments.Include("BankFish").SingleOrDefault(p => p.BankFish.Id == Ba.Id).BankFish;
            Payment PaymentE = db.Payments.SingleOrDefault(p => p.Id == Pa.Id);
            Txt_AccountingNumber.Text = BankE.AccountingNumber.ToString();
            Txt_NameS.Text = BankE.Name_Start;
            Txt_Desc.Text = PaymentE.Description;
            Txt_NameFinish.Text = PaymentE.Name;
            Txt_Price.Text = utility.ConvertPrice(PaymentE.Cost);
            Txt_Reason.Text = PaymentE.Reason;
            Date.GeoDate = PaymentE.Date;
            Btn_Delete.Click += Btn_Delete_Click;
            Btn_Edit.Click += Btn_Edit_Click;
        }

        private void Btn_Edit_Click(object sender, EventArgs e)
        {
            if (CheckError())
            {
                Model.BankFish BankE = db.Payments.Include("BankFish").SingleOrDefault(p => p.BankFish.Id == Ba.Id).BankFish;
                Payment PaymentE = db.Payments.SingleOrDefault(p => p.Id == Pa.Id);
                if (PaymentE != null && PaymentE.Project != null)
                {
                    var orDefault = db.Projects.SingleOrDefault(p => p.ProjectID == PaymentE.ProjectID);
                    if (orDefault != null)
                        orDefault.TotalCost -= PaymentE.Cost;
                }
                BankE.Name_Start = Txt_NameS.Text.Trim();
                BankE.AccountingNumber = Convert.ToInt64(Txt_AccountingNumber.Text.Trim());
                PaymentE.Description = Txt_Desc.Text.Trim();
                PaymentE.Name = Txt_NameFinish.Text.Trim();
                PaymentE.Cost = utility.ConvertCommaPrice(Txt_Price.Text.Trim());
                PaymentE.Reason = Txt_Reason.Text.Trim();
                PaymentE.Date = Date.GeoDate.Value;
                var project = db.Projects.SingleOrDefault(p => p.ProjectID == PaymentE.ProjectID);
                if (project != null)
                    project.TotalCost += PaymentE.Cost;
                db.SaveChanges();
                utility.Show_Message("عملیات ویرایش با موفقیت انجام شد", "پیغام");
                Clear();
            }
            else MessageBox.Show("لطفا تمامی موارد ستاره دار را پر کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            db.Fishes.Remove(db.Payments.Include("BankFish").SingleOrDefault(p => p.BankFish.Id == Ba.Id).BankFish);

            var paymentE = db.Payments.SingleOrDefault(p => p.Id == Pa.Id);
            if (paymentE.Project != null)
            {
                var project = db.Projects.SingleOrDefault(p => p.ProjectID == paymentE.ProjectID);
                if (project != null)
                    project.TotalCost -= paymentE.Cost;
            }
            db.Payments.Remove(paymentE);

            db.SaveChanges();
            utility.Show_Message("عملیات حذف با موفقیت انجام شد", "پیغام");
            Clear();
        }
    }
}
