using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using EsfahanGhos.DataLayer;
using EsfahanGhos.Model;

namespace EsfahanGhos
{
    public partial class Form_Payment : Form
    {
        Corporation db = new Corporation();
        Credit Cr = null;
        Factor Fa = null;
        PurchaseList Pu = null;
        Project Pro = null;
        Payment Pa = null;
        List<Payment> ListPayments = null;
        private int PersonId;
        enum States
        {
            WriteC, WriteF, WriteP, WritePro, Edit,
            Normal,People
        };
        States State = States.WriteC;
        public Form_Payment(Credit C)
        {
            State = States.WriteC;
            Cr = C;
            InitializeComponent();
        }
        public Form_Payment(Factor F)
        {
            State = States.WriteF;
            Fa = F;
            InitializeComponent();
        }
        public Form_Payment(PurchaseList P)
        {
            State = States.WriteP;
            Pu = P;
            InitializeComponent();
        }
        public Form_Payment(Project Pr)
        {
            State = States.WritePro;
            Pro = Pr;
            InitializeComponent();
        }
        public Form_Payment(Payment P)
        {
            State = States.Edit;
            Pa = P;
            InitializeComponent();
            splitContainer1.Panel1.Enabled = false;
        }

        public Form_Payment()
        {
            State = States.Normal;
            InitializeComponent();
        }

        public Form_Payment(int personId)
        {
            State=States.People;
            PersonId = personId;
            InitializeComponent();
        }
        private void Form_Payment_Load(object sender, EventArgs e)
        {
            if (State == States.Edit)
            {
                BackgroundWorker BGW = new BackgroundWorker();
                BGW.DoWork += BGW_DoWork;
                BGW.RunWorkerCompleted += BGW_RunWorkerCompleted;
                BGW.RunWorkerAsync();
            }
            SetDefaulte();
        }
        private void SetDefaulte()
        {
            Combo_Payment.SelectedIndex = -1;
            splitContainer1.Panel2.Controls.Clear();
        }

        private void Combo_Payment_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (Combo_Payment.SelectedIndex)
            {
                case 0:
                    splitContainer1.Panel2.Controls.Clear();
                    View.Check UC_Check = null;
                    if (State == States.WriteC)
                    {
                        UC_Check = new View.Check(Cr);

                    }
                    if (State == States.WriteF)
                    {
                        UC_Check = new View.Check(Fa);

                    }
                    if (State == States.WriteP)
                    {
                        UC_Check = new View.Check(Pu);
                    }
                    if (State == States.WritePro)
                    {
                        UC_Check = new View.Check(Pro);
                    }
                    if (State == States.Normal)
                    {
                        UC_Check = new View.Check();
                    }
                    if (State == States.People)
                    {
                        UC_Check=new View.Check(PersonId);
                    }
                    UC_Check.Dock = DockStyle.Fill;
                    splitContainer1.Panel2.Controls.Add(UC_Check);
                    break;
                case 1:
                    splitContainer1.Panel2.Controls.Clear();
                    View.CardtoCard UC_Card = null;
                    if (State == States.WriteC)
                    {
                        UC_Card = new View.CardtoCard(Cr);

                    }
                    if (State == States.WriteF)
                    {
                        UC_Card = new View.CardtoCard(Fa);

                    }
                    if (State == States.WriteP)
                    {
                        UC_Card = new View.CardtoCard(Pu);
                    }
                    if (State == States.WritePro)
                    {
                        UC_Card = new View.CardtoCard(Pro);
                    }
                    if (State == States.Normal)
                    {
                        UC_Card = new View.CardtoCard();
                    }
                    if (State == States.People)
                    {
                        UC_Card = new View.CardtoCard(PersonId);
                    }
                    UC_Card.Dock = DockStyle.Fill;
                    splitContainer1.Panel2.Controls.Add(UC_Card);
                    break;
                case 2:
                    splitContainer1.Panel2.Controls.Clear();
                    View.BankFish UC_Fish = null;
                    if (State == States.WriteC)
                    {
                        UC_Fish = new View.BankFish(Cr);

                    }
                    if (State == States.WriteF)
                    {
                        UC_Fish = new View.BankFish(Fa);

                    }
                    if (State == States.WriteP)
                    {
                        UC_Fish = new View.BankFish(Pu);
                    }
                    if (State == States.WritePro)
                    {
                        UC_Fish = new View.BankFish(Pro);
                    }
                    if (State == States.Normal)
                    {
                        UC_Fish = new View.BankFish();
                    }
                    if (State == States.People)
                    {
                        UC_Fish = new View.BankFish(PersonId);
                    }
                    UC_Fish.Dock = DockStyle.Fill;
                    splitContainer1.Panel2.Controls.Add(UC_Fish);
                    break;
                case 3:
                    splitContainer1.Panel2.Controls.Clear();
                    View.Pure UC_Pure = null;
                    if (State == States.WriteC)
                    {
                        UC_Pure = new View.Pure(Cr);

                    }
                    if (State == States.WriteF)
                    {
                        UC_Pure = new View.Pure(Fa);

                    }
                    if (State == States.WriteP)
                    {
                        UC_Pure = new View.Pure(Pu);
                    }
                    if (State == States.WritePro)
                    {
                        UC_Pure = new View.Pure(Pro);
                    }
                    if (State == States.Normal)
                    {
                        UC_Pure = new View.Pure();
                    }
                    if (State == States.People)
                    {
                        UC_Pure = new View.Pure(PersonId);
                    }
                    UC_Pure.Dock = DockStyle.Fill;
                    splitContainer1.Panel2.Controls.Add(UC_Pure);
                    break;
            }
        }
        private void BGW_DoWork(object sender, DoWorkEventArgs e)
        {
            ListPayments = db.Payments.Include("Check").Include("BankFish").Include("CardToCard").ToList();
        }
        private void BGW_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Payment pay = ListPayments.SingleOrDefault(p => p.Id == Pa.Id);
            ShowUserControllerForEdit(pay);
        }

        private void ShowUserControllerForEdit(Payment Pay)
        {
            if (Pay.CardToCard != null)
            {
                View.CardtoCard UC = new View.CardtoCard(Pay, Pay.CardToCard);
                UC.Dock = DockStyle.Fill;
                splitContainer1.Panel2.Controls.Add(UC);
            }
            if (Pay.Check != null)
            {
                View.Check UC = new View.Check(Pay, Pay.Check);
                UC.Dock = DockStyle.Fill;
                splitContainer1.Panel2.Controls.Add(UC);
            }
            if (Pay.BankFish != null)
            {
                View.BankFish UC = new View.BankFish(Pay, Pay.BankFish);
                UC.Dock = DockStyle.Fill;
                splitContainer1.Panel2.Controls.Add(UC);
            }
            if (Pay.BankFish == null && Pay.BankFish == null && Pay.CardToCard == null && Pay.Check == null)
            {
                View.Pure UC = new View.Pure(Pay);
                UC.Dock = DockStyle.Fill;
                splitContainer1.Panel2.Controls.Add(UC);
            }
            // this.Close();
        }
    }
}
