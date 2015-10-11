using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using EsfahanGhos.DataLayer;
using EsfahanGhos.Model;

namespace EsfahanGhos
{
    public partial class Form_RegNewPayment : Form
    {
        Corporation db = new Corporation();
        List<Factor> Listfactor = null;
        List<Project> ListProject = null;
        private List<PurchaseList> ListPurchase = null;
        public Form_RegNewPayment()
        {
            InitializeComponent();
        }

        private void Radio_CheckedChanged(object sender, EventArgs e)
        {
            if (Radio_Diffrent.Checked)
            {
                D1.Enabled = true;
                D2.Enabled = true;
                D2.DataSource = ListProject;
                D2.DisplayMember = "ProjectName";
                D2.ValueMember = "ProjectID";
                D2.SelectedIndex = -1;
            }
            else
            {
                D1.Enabled = false;
                D2.Enabled = false;
            }
            if (Radio_Factor.Checked)
            {
                F1.Enabled = F2.Enabled = F3.Enabled = true;
                F2.DataSource = Listfactor;
                F2.DisplayMember = "FactorNumber";
                F2.ValueMember = "FactorID";
                F2.SelectedIndex = -1;
            }
            else
            {
                F1.Enabled = F2.Enabled = F3.Enabled = false;
            }
            if (Radio_ListP.Checked)
            {
                P1.Enabled = P2.Enabled = P3.Enabled = true;
                P2.DataSource = ListPurchase;
                P2.DisplayMember = "NumberOfList";
                P2.ValueMember = "PurchaseListID";
                P2.SelectedIndex = -1;
            }
            else
            {
                P1.Enabled = P2.Enabled = P3.Enabled = false;
            }
        }

        private void BGW_DoWork(object sender, DoWorkEventArgs e)
        {
            Listfactor = db.Factors.ToList();
            ListProject = db.Projects.ToList();
            ListPurchase = db.PurchaseLists.OrderBy(p => p.CreditID).Skip(1).ToList();
        }

       private void Form_RegNewPayment_Load(object sender, EventArgs e)
        {
            BGW.RunWorkerAsync();
        }

        private void Btn_Next_Click(object sender, EventArgs e)
        {
            if (Radio_Diffrent.Checked)
            {
                if (D2.SelectedIndex != -1)
                {
                    int id = Convert.ToInt32(D2.SelectedValue);
                    Form_Payment fp = new Form_Payment(ListProject.SingleOrDefault(p => p.ProjectID == id));
                    fp.ShowDialog();
                }
                else
                {
                    Form_Payment fp = new Form_Payment();
                    fp.ShowDialog();
                }
            }
            if (Radio_Factor.Checked)
            {
                if (F2.SelectedIndex != -1)
                {
                    int id = Convert.ToInt32(F2.SelectedValue);
                    if (!db.Payments.Any(p => p.FactorID == id))
                    {
                        Form_Payment fp = new Form_Payment(Listfactor.SingleOrDefault(p => p.FactorID == id));
                        fp.ShowDialog();
                    }
                }
            }
            if (Radio_ListP.Checked)
            {
                if (P2.SelectedIndex != -1)
                {
                    int id = Convert.ToInt32(P2.SelectedValue);
                    Form_Payment fp = new Form_Payment(ListPurchase.SingleOrDefault(p => p.PurchaseListID == id));
                    fp.ShowDialog();
                }
            }
        }
    }
}

