using System;

namespace EsfahanGhos
{
    public partial class Form_Factor : Telerik.WinControls.UI.RadForm
    {
        public Form_Factor()
        {
            InitializeComponent();
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_RegTankhah_Click(object sender, EventArgs e)
        {
            Form_RegFactorListItem RFL = new Form_RegFactorListItem();
            RFL.ShowDialog();
        }

        private void Btn_Factorlist_Click(object sender, EventArgs e)
        {
            Form_FactorList FL = new Form_FactorList();
            FL.ShowDialog();
        }
    }
}
