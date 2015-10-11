using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using EsfahanGhos.DataLayer;
using EsfahanGhos.Model;

namespace EsfahanGhos.View
{
    public partial class Check : UserControl
    {
        long vir = 0;
        string virgol = "";
        Factor F1 = null;
        Credit Cr1 = null;
        Payment Pa = null;
        Project Pro = null;
        Model.Check Ch = null;
        Corporation db = new Corporation();
        List<Factor> ListFactor = null;
        List<Credit> ListCredit = null;
        List<PurchaseList> ListPurchaseList = null;
        PurchaseList Pu = null;
        private int PersonId;
        enum States { WriteC, WriteF, WriteP, WritePro, Edit, Normal,People };
        States State = States.WriteC;
        public Check(Credit Cr)
        {
            State = States.WriteC;
            Cr1 = Cr;
            InitializeComponent();
            Btn_Edit.Enabled = Btn_Delete.Enabled = false;
        }
        public Check(Factor F)
        {
            State = States.WriteF;
            F1 = F;
            InitializeComponent();
            Btn_Edit.Enabled = Btn_Delete.Enabled = false;
        }
        public Check(PurchaseList P)
        {
            State = States.WriteP;
            Pu = P;
            InitializeComponent();
            Btn_Edit.Enabled = Btn_Delete.Enabled = false;
        }
        public Check(Project P)
        {
            State = States.WritePro;
            Pro = P;
            InitializeComponent();
            Btn_Edit.Enabled = Btn_Delete.Enabled = false;
        }
        public Check(Payment P, Model.Check C)
        {
            State = States.Edit;
            Pa = P;
            Ch = C;
            InitializeComponent();
            Btn_Register.Enabled = false;
        }

        public Check(int personId)
        {
            PersonId = personId;
            State=States.People;
            InitializeComponent();
        }
        public Check()
        {
            State = States.Normal;
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
        private void Check_Load(object sender, EventArgs e)
        {
            BGW.RunWorkerAsync();
            SetDefualt();
        }

        private void SetDefualt()
        {
            Txt_DateStart.GeoDate = Txt_DateFinish.GeoDate = DateTime.Now;
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
        private void Btn_Register_Click(object sender, EventArgs e)
        {
            if (CheckError())
            {
                Register();
                ClearText();

            }
            else MessageBox.Show("لطفا تمامی موارد ستاره دار را پر کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private bool CheckError()
        {
           // if (Txt_CheckNumber.Text.Trim() == "" || Txt_Name.Text.Trim() == "" || Txt_Price.Text.Trim() == "") return false;
           // else
            return true;
        }

        private void ClearText()
        {
            List<TextBox> ListT = this.Controls[0].Controls.OfType<TextBox>().ToList();
            foreach (var item in ListT)
            {
                item.Text = "";
            }
            SetDefualt();
        }

        private void Register()
        {
            Payment P = new Payment()
            {
                Reason = Txt_Reason.Text.Trim(),
                Name = Txt_Name.Text.Trim(),
                Description = Txt_Desc.Text.Trim(),
                Cost = utility.ConvertCommaPrice(Txt_Price.Text.Trim()),
                Date = Txt_DateStart.GeoDate.Value,
            };
            db.Payments.Add(P);
            if (State == States.WriteC)
            {
                Credit c = ListCredit.Single(p => p.CreditID == Cr1.CreditID);
                P.Credit = c;
            }
            if (State == States.WriteF)
            {
                Factor c = ListFactor.Single(p => p.FactorID == F1.FactorID);
                P.Factor = c;
            }
            if (State == States.WriteP)
            {
                PurchaseList c = ListPurchaseList.Single(p => p.PurchaseListID == Pu.PurchaseListID);
                P.PurchaseList = c;
            }
            if (State == States.People)
            {
                P.PersonId = PersonId;
            }
            Model.Check C = new Model.Check()
            {
                CheckNumber = Convert.ToInt32(Txt_CheckNumber.Text.Trim()),
                RecoverDate = Txt_DateFinish.GeoDate.Value
            };
            P.Check = C;
            db.SaveChanges();
            utility.Show_Message("اطلاعات این پرداخت با موفقیت ثبت شد", "پیغام");

        }

        private void BGW_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (State == States.Edit)
            {
                FillData();
            }
        }

        private void FillData()
        {
            db.Payments.ToList();
            Model.Check CheckE = db.Payments.Include("Check").SingleOrDefault(p => p.Check.Id == Ch.Id).Check;
            var PaymentE = db.Payments.SingleOrDefault(p => p.Id == Pa.Id);
            Txt_CheckNumber.Text = CheckE.CheckNumber.ToString();
            Txt_DateFinish.GeoDate = CheckE.RecoverDate;
            Txt_Desc.Text = PaymentE.Description;
            Txt_Name.Text = PaymentE.Name;
            Txt_Price.Text = utility.ConvertPrice(PaymentE.Cost);
            Txt_Reason.Text = PaymentE.Reason;
            Txt_DateStart.GeoDate = PaymentE.Date;
            Btn_Delete.Click += Btn_Delete_Click;
            Btn_Edit.Click += Btn_Edit_Click;
        }

        void Btn_Edit_Click(object sender, EventArgs e)
        {
            if (CheckError())
            {
                Model.Check CheckE = db.Payments.SingleOrDefault(p => p.Check.Id == Ch.Id).Check;
                var PaymentE = db.Payments.SingleOrDefault(p => p.Id == Pa.Id);
                if (PaymentE != null && PaymentE.Project != null)
                {
                    var orDefault = db.Projects.SingleOrDefault(p => p.ProjectID == PaymentE.ProjectID);
                    if (orDefault != null)
                        orDefault.TotalCost -= PaymentE.Cost;
                }
                CheckE.CheckNumber = Convert.ToInt32(Txt_CheckNumber.Text);
                CheckE.RecoverDate = Txt_DateFinish.GeoDate.Value;
                PaymentE.Description = Txt_Desc.Text.Trim();
                PaymentE.Name = Txt_Name.Text.Trim();
                PaymentE.Cost = utility.ConvertCommaPrice(Txt_Price.Text.Trim());
                PaymentE.Reason = Txt_Reason.Text.Trim();
                PaymentE.Date = Txt_DateStart.GeoDate.Value;
                var project = db.Projects.SingleOrDefault(p => p.ProjectID == PaymentE.ProjectID);
                if (project != null)
                    project.TotalCost += PaymentE.Cost;
                db.SaveChanges();
                utility.Show_Message("عملیات ویرایش با موفقیت انجام شد", "پیغام");
                ClearText();
            }
            else MessageBox.Show("لطفا تمامی موارد ستاره دار را پر کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        void Btn_Delete_Click(object sender, EventArgs e)
        {
            db.Checks.Remove(db.Payments.Include("Check").SingleOrDefault(p => p.Check.Id == Ch.Id).Check);

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
            ClearText();
        }
    }
}
