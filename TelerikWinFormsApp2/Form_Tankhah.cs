using System;

namespace EsfahanGhos
{
    public partial class Form_Tankhah : Telerik.WinControls.UI.RadForm
    {
        public Form_Tankhah()
        {
            InitializeComponent();
        }

        private void Btn_CLose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_RegTankhah_Click(object sender, EventArgs e)
        {
            Form_RegTankhah RT = new Form_RegTankhah();
            RT.ShowDialog();
        }
        private void Btn_PurchaseList_Click(object sender, EventArgs e)
        {
            Form_PurchaseList P = new Form_PurchaseList();
            P.ShowDialog();
        }

        private void Btn_CreditTankhah_Click(object sender, EventArgs e)
        {
            Form_CreditTankhah CT = new Form_CreditTankhah();
            CT.ShowDialog();
        }

        private void radButton4_Click(object sender, EventArgs e)
        {
            Form_TankhahPurchaseLists T = new Form_TankhahPurchaseLists();
            T.ShowDialog();
        }
    }
}
