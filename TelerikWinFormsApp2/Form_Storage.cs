using System;
using System.Windows.Forms;

namespace EsfahanGhos
{
    public partial class Form_Storage : Form
    {
        public Form_Storage()
        {
            InitializeComponent();
        }

        private void Btn_Unit_Click(object sender, EventArgs e)
        {
            var formUnit = new Form_Unit();
            formUnit.ShowDialog();
        }

        private void Btn_TypeStorage_Click(object sender, EventArgs e)
        {
            var formTypeStorage = new Form_TypeStorage();
            formTypeStorage.ShowDialog();
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Btn_RegStorage_Click(object sender, EventArgs e)
        {
            Form_RegSourceStorage form = new Form_RegSourceStorage();
            form.ShowDialog();
        }

        private void Btn_SourceStorage_Click(object sender, EventArgs e)
        {
            Form_ListSourceStorage form
                = new Form_ListSourceStorage();
            form.ShowDialog();
        }
    }
}
