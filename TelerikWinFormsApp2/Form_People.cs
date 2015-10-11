using System;
using System.Windows.Forms;

namespace EsfahanGhos
{
    public partial class Form_People : Telerik.WinControls.UI.RadForm
    {
        public Form_People()
        {
            InitializeComponent();
        }

        private void Button_Reg_Click(object sender, EventArgs e)
        {
        }

        private void Button_Upload_Click(object sender, EventArgs e)
        {
            //Form_UploadDoc Doc = new Form_UploadDoc();
           // Doc.ShowDialog();
        }
        private void Button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Btn_RegPerson(object sender, EventArgs e)
        {
            Form_Person FP = new Form_Person();
            FP.ShowDialog();
        }

        private void Btn_ListPerson_Click(object sender, EventArgs e)
        {
            Form_ReportPeople FRP = new Form_ReportPeople();
            FRP.ShowDialog();
        }

        private void Btn_ProjectPersons_Click(object sender, EventArgs e)
        {
            FormProjectSPerson FP = new FormProjectSPerson();
            FP.ShowDialog();
        }
    }
}
