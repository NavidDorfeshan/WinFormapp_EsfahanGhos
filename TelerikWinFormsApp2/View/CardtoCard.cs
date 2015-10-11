using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using EsfahanGhos.DataLayer;
using EsfahanGhos.Model;

namespace EsfahanGhos.View
{
    public partial class CardtoCard : UserControl
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
        CardToCard Ca = null;
        private int PersonId;
        enum States { WriteC, WriteF, WriteP, WritePro, Edit,
            Normal,People
        };
        States State = States.WriteC;
        public CardtoCard(Credit C)
        {
            State = States.WriteC;
            Cr = C;
            InitializeComponent();
            Btn_Edit.Enabled = Btn_Del.Enabled = false;
        }
        public CardtoCard(Factor F)
        {
            State = States.WriteF;
            Fa = F;
            InitializeComponent();
            Btn_Edit.Enabled = Btn_Del.Enabled = false;
        }
        public CardtoCard(PurchaseList P)
        {
            State = States.WriteP;
            Pu = P;
            InitializeComponent();
            Btn_Edit.Enabled = Btn_Del.Enabled = false;
        }
        public CardtoCard(Project P)
        {
            State = States.WritePro;
            Pro = P;
            InitializeComponent();
            Btn_Edit.Enabled = Btn_Del.Enabled = false;
        }
        public CardtoCard(Payment P, CardToCard C)
        {
            State = States.Edit;
            Pa = P;
            Ca = C;
            InitializeComponent();
            Btn_Reg.Enabled = false;
        }

        public CardtoCard()
        {
            State = States.Normal;
            InitializeComponent();
        }

        public CardtoCard(int personId)
        {
            PersonId = personId;
            State=States.People;
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
        private void Clear()
        {
            Txt_Card1.Text = Txt_Card2.Text = Txt_Cost.Text = Txt_Desc.Text = Txt_Name.Text = Txt_Peygiri.Text = Txt_Reason.Text = "";
            Date.GeoDate = DateTime.Now;
        }
        private bool CheckError()
        {
          //  if (Txt_Card1.Text.Trim() == "" || Txt_Card2.Text.Trim() == "")
          //  {
          //      return false;
           // }
          //  else
                return true;
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

        private void CardtoCard_Load(object sender, EventArgs e)
        {
            BGW.RunWorkerAsync();
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
                Name = Txt_Name.Text.Trim(),
                Description = Txt_Desc.Text.Trim(),
                Cost = utility.ConvertCommaPrice(Txt_Cost.Text.Trim()),
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
            if (State == States.People)
            {
                P.PersonId = PersonId;
            }
            CardToCard Card = new CardToCard()
            {
                Card_Start = Txt_Card1.Text.Trim(),
                Card_Finish = Txt_Card2.Text.Trim(),
                Code_Peygiri = Convert.ToInt32(Txt_Peygiri.Text.Trim()),
                Name = Txt_Name.Text.Trim(),
            };
            P.CardToCard = Card;
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
            Model.CardToCard CardE = db.Payments.Include(p => p.CardToCard).SingleOrDefault(p => p.CardToCard.Id == Ca.Id).CardToCard;
            Payment PaymentE = db.Payments.SingleOrDefault(p => p.Id == Pa.Id);
            Txt_Card1.Text = CardE.Card_Start;
            Txt_Card2.Text = CardE.Card_Finish;
            Txt_Peygiri.Text = CardE.Code_Peygiri.ToString();
            Txt_Name.Text = CardE.Name;
            Txt_Desc.Text = PaymentE.Description;
            Txt_Name.Text = PaymentE.Name;
            Txt_Cost.Text = utility.ConvertPrice(PaymentE.Cost);
            Txt_Reason.Text = PaymentE.Reason;
            Date.GeoDate = PaymentE.Date;
            Btn_Del.Click += Btn_Delete_Click;
            Btn_Edit.Click += Btn_Edit_Click;
        }

        private void Btn_Edit_Click(object sender, EventArgs e)
        {
            if (CheckError())
            {
                Model.CardToCard CardE = db.Payments.Include(p => p.CardToCard).SingleOrDefault(p => p.CardToCard.Id == Ca.Id).CardToCard;
                Payment PaymentE = db.Payments.SingleOrDefault(p => p.Id == Pa.Id);
                if (PaymentE != null && PaymentE.Project != null)
                {
                    var orDefault = db.Projects.SingleOrDefault(p => p.ProjectID == PaymentE.ProjectID);
                    if (orDefault != null)
                        orDefault.TotalCost -= PaymentE.Cost;
                }
                CardE.Card_Start = Txt_Card2.Text.Trim();
                CardE.Card_Finish = Txt_Card1.Text.Trim();
                CardE.Code_Peygiri = Convert.ToInt32(Txt_Peygiri.Text.Trim());
                CardE.Name = Txt_Name.Text.Trim();
                PaymentE.Description = Txt_Desc.Text.Trim();
                PaymentE.Name = Txt_Name.Text.Trim();
                PaymentE.Cost = utility.ConvertCommaPrice(Txt_Cost.Text.Trim());
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
            db.Cards.Remove(db.Payments.Include(p => p.CardToCard).SingleOrDefault(p => p.CardToCard.Id == Ca.Id).CardToCard);

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
