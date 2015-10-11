using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using EsfahanGhos.DataLayer;
using EsfahanGhos.Model;

namespace EsfahanGhos
{
    public partial class Form_EnterProject : Telerik.WinControls.UI.RadForm
    {
        int PID, project_ID;
        string Price = "";
        long Pr = 0;
        Corporation db = new Corporation();
        List<Project> ListProjects = new List<Project>();
        public Form_EnterProject(int ID)
        {
            PID = ID;
            InitializeComponent();
        }
        private void Txt_PriceProject_TextChanged(object sender, EventArgs e)
        {
            if (Txt_PriceProject.Text.Trim() != "")
            {
                if (Txt_PriceProject.Text != Price)
                {
                    Pr = utility.ConvertCommaPrice(Txt_PriceProject.Text.Trim());
                    if (Pr != -1)
                    {
                        Price = utility.ConvertPrice(Pr);
                        Txt_PriceProject.Text = Price;
                    }
                    Txt_PriceProject.Select(Txt_PriceProject.Text.Length, 0);
                }
            }
        }
        /// <summary>
        /// بستن پنجره
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Close_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void Form_EnterProject_Load(object sender, EventArgs e)
        {
            BGW.RunWorkerAsync();
        }

        private void BGW_DoWork(object sender, DoWorkEventArgs e)
        {
            GetData();
        }
        /// <summary>
        /// گرفتن اطلاعات از پایگاه داده
        /// </summary>
        private void GetData()
        {
            ListProjects = db.Projects.ToList<Project>();
        }

        private void BGW_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Show_DataCombo();
            ShowData(PID);
        }
        /// <summary>
        /// پر کردن اطلاعات در کامبو
        /// </summary>
        private void Show_DataCombo()
        {
            Combo_SelectProject.ComboBox.DisplayMember = "ProjectName";
            Combo_SelectProject.ComboBox.ValueMember = "ProjectID";
            Combo_SelectProject.ComboBox.DataSource = ListProjects;
            Combo_SelectProject.ComboBox.SelectedValue = PID;
        }
        /// <summary>
        /// پر کردن فیلدها
        /// </summary>
        private void ShowData(int id)
        {
            if (ListProjects.Count != 0)
            {
                Project P = ListProjects.Single(p => p.ProjectID == id);
                Txt_ProjectID.Text = P.ProjectID.ToString();
                Txt_PName.Text = P.ProjectName;
                Combo_SelectProject.ComboBox.SelectedValue = id;
                Txt_PStartDate.Text = utility.ConvertDate_M_To_Sh(P.ProjectStart);
                Txt_PSFinishDate.Text = utility.ConvertDate_M_To_Sh(P.ProjectFinish);
                Txt_PArea.Text = P.ProjectArea;
                textBox1.Text = P.ProjectDescribed;
                Txt_PAdress.Text = P.ProjectAdress;
                Txt_PriceProject.Text = P.PriceProject.ToString();
                Txt_NameKarfarma.Text = P.Emp_Name;
                if (P.isActive == true) Combo_IsActive.SelectedIndex = 0;
                else Combo_IsActive.SelectedIndex = 1;
                if (Txt_NameKarfarma.Text.Trim() == "") Txt_NameKarfarma.Text = "مشخص نشده ";
                if (Txt_PAdress.Text.Trim() == "") Txt_PAdress.Text = "مشخص نشده ";
                if (textBox1.Text.Trim() == "") textBox1.Text = "مشخص نشده ";
            }
        }
        /// <summary>
        /// انتخاب پروژه ی دیگه از کامبو
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Combo_SelectProject_SelectedIndexChanged(object sender, EventArgs e)
        {
            project_ID = Convert.ToInt32(Combo_SelectProject.ComboBox.SelectedValue);
            ShowData(Convert.ToInt32(Combo_SelectProject.ComboBox.SelectedValue));
        }

        private void Button_Edit_Click(object sender, EventArgs e)
        {
            List<TextBox> ListTextBox = this.Controls.OfType<TextBox>().ToList<TextBox>();
            foreach (TextBox TextBox in ListTextBox)
            {
                TextBox.Enabled = false;
            }

        }

        private void Btn_DeclareBlock_Click(object sender, EventArgs e)
        {
            Form_Block_sProjects B = new Form_Block_sProjects(project_ID);
            B.ShowDialog();
        }

        private void Btn_ShowBlockDetail_Click(object sender, EventArgs e)
        {
            Form_ShowBlock S = new Form_ShowBlock(project_ID);
            S.ShowDialog();
        }

        private void btn_Person_Click(object sender, EventArgs e)
        {
            Form_ListpersonProject nProject = new Form_ListpersonProject(project_ID);
            nProject.ShowDialog();
        }

    }
}
