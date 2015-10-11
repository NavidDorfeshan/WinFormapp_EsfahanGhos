namespace EsfahanGhos
{
    partial class Form_ListpersonProject
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewHyperlinkColumn gridViewHyperlinkColumn1 = new Telerik.WinControls.UI.GridViewHyperlinkColumn();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ListpersonProject));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Grid_Person = new Telerik.WinControls.UI.RadGridView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Btn_Print = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Btn_BAck = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_Code = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_Phone = new System.Windows.Forms.TextBox();
            this.BGW = new System.ComponentModel.BackgroundWorker();
            this.office2007SilverTheme1 = new Telerik.WinControls.Themes.Office2007SilverTheme();
            this.Print_Persons = new Stimulsoft.Report.StiReport();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Person)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Person.MasterTemplate)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(5);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.Grid_Person);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Snow;
            this.splitContainer1.Panel2.Controls.Add(this.flowLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(1155, 664);
            this.splitContainer1.SplitterDistance = 919;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 0;
            // 
            // Grid_Person
            // 
            this.Grid_Person.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Grid_Person.AutoScroll = true;
            this.Grid_Person.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grid_Person.Font = new System.Drawing.Font("B Nazanin", 10.2F, System.Drawing.FontStyle.Bold);
            this.Grid_Person.GroupExpandAnimationType = Telerik.WinControls.UI.GridExpandAnimationType.Slide;
            this.Grid_Person.Location = new System.Drawing.Point(0, 0);
            // 
            // Grid_Person
            // 
            this.Grid_Person.MasterTemplate.AllowAddNewRow = false;
            this.Grid_Person.MasterTemplate.AllowColumnReorder = false;
            this.Grid_Person.MasterTemplate.AllowSearchRow = true;
            this.Grid_Person.MasterTemplate.AutoGenerateColumns = false;
            this.Grid_Person.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.FieldName = "EmployeeFullName";
            gridViewTextBoxColumn1.HeaderText = "نام و نام خانوادگی ";
            gridViewTextBoxColumn1.Name = "column1";
            gridViewTextBoxColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn1.Width = 174;
            gridViewTextBoxColumn2.FieldName = "FatherName";
            gridViewTextBoxColumn2.HeaderText = "نام پدر";
            gridViewTextBoxColumn2.Name = "column4";
            gridViewTextBoxColumn2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn2.Width = 174;
            gridViewTextBoxColumn3.FieldName = "EmployeeNationalCode";
            gridViewTextBoxColumn3.HeaderText = "کد ملی";
            gridViewTextBoxColumn3.Name = "column2";
            gridViewTextBoxColumn3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn3.Width = 174;
            gridViewTextBoxColumn4.FieldName = "CellPhone";
            gridViewTextBoxColumn4.HeaderText = "شماره تلفن همراه";
            gridViewTextBoxColumn4.Name = "column3";
            gridViewTextBoxColumn4.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn4.Width = 174;
            gridViewTextBoxColumn5.FieldName = "Adress";
            gridViewTextBoxColumn5.HeaderText = "آدرس";
            gridViewTextBoxColumn5.MinWidth = 30;
            gridViewTextBoxColumn5.Name = "column5";
            gridViewTextBoxColumn5.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn5.Width = 168;
            gridViewTextBoxColumn6.FieldName = "EmployeeID";
            gridViewTextBoxColumn6.HeaderText = "column6";
            gridViewTextBoxColumn6.IsVisible = false;
            gridViewTextBoxColumn6.Name = "id";
            gridViewTextBoxColumn6.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn6.Width = 48;
            gridViewHyperlinkColumn1.FormatString = "حذف";
            gridViewHyperlinkColumn1.HeaderText = "حذف";
            gridViewHyperlinkColumn1.Name = "Del";
            gridViewHyperlinkColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewHyperlinkColumn1.Width = 40;
            this.Grid_Person.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewHyperlinkColumn1});
            this.Grid_Person.MasterTemplate.EnablePaging = true;
            this.Grid_Person.MasterTemplate.ShowHeaderCellButtons = true;
            this.Grid_Person.Name = "Grid_Person";
            this.Grid_Person.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.Grid_Person.ReadOnly = true;
            this.Grid_Person.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Grid_Person.ShowGroupPanel = false;
            this.Grid_Person.ShowHeaderCellButtons = true;
            this.Grid_Person.Size = new System.Drawing.Size(919, 664);
            this.Grid_Person.TabIndex = 0;
            this.Grid_Person.ThemeName = "Office2007Silver";
            this.Grid_Person.CellClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.Grid_Person_CellClick);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.Btn_Print);
            this.flowLayoutPanel1.Controls.Add(this.Btn_BAck);
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.Txt_Name);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.Txt_Code);
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.Txt_Phone);
            this.flowLayoutPanel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flowLayoutPanel1.Size = new System.Drawing.Size(230, 664);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // Btn_Print
            // 
            this.Btn_Print.FlatAppearance.BorderColor = System.Drawing.Color.Snow;
            this.Btn_Print.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Crimson;
            this.Btn_Print.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.Btn_Print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Print.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Print.ImageKey = "Iconshock-Real-Vista-Text-Print.ico";
            this.Btn_Print.ImageList = this.imageList1;
            this.Btn_Print.Location = new System.Drawing.Point(17, 5);
            this.Btn_Print.Margin = new System.Windows.Forms.Padding(5);
            this.Btn_Print.Name = "Btn_Print";
            this.Btn_Print.Size = new System.Drawing.Size(208, 56);
            this.Btn_Print.TabIndex = 0;
            this.Btn_Print.Text = "چاپ همه";
            this.Btn_Print.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Print.UseVisualStyleBackColor = true;
            this.Btn_Print.Click += new System.EventHandler(this.Btn_Print_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Semlabs-Web-Blog-Arrow-return-down-right.ico");
            this.imageList1.Images.SetKeyName(1, "Iconshock-Real-Vista-Text-Print.ico");
            // 
            // Btn_BAck
            // 
            this.Btn_BAck.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Btn_BAck.FlatAppearance.BorderColor = System.Drawing.Color.Snow;
            this.Btn_BAck.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Crimson;
            this.Btn_BAck.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.Btn_BAck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_BAck.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_BAck.ImageKey = "Semlabs-Web-Blog-Arrow-return-down-right.ico";
            this.Btn_BAck.ImageList = this.imageList1;
            this.Btn_BAck.Location = new System.Drawing.Point(17, 71);
            this.Btn_BAck.Margin = new System.Windows.Forms.Padding(5);
            this.Btn_BAck.Name = "Btn_BAck";
            this.Btn_BAck.Size = new System.Drawing.Size(208, 56);
            this.Btn_BAck.TabIndex = 1;
            this.Btn_BAck.Text = "بازگشت";
            this.Btn_BAck.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_BAck.UseVisualStyleBackColor = true;
            this.Btn_BAck.Click += new System.EventHandler(this.Btn_BAck_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "نام نام خانوادگی ";
            // 
            // Txt_Name
            // 
            this.Txt_Name.Location = new System.Drawing.Point(17, 162);
            this.Txt_Name.Name = "Txt_Name";
            this.Txt_Name.Size = new System.Drawing.Size(210, 34);
            this.Txt_Name.TabIndex = 3;
            this.Txt_Name.TextChanged += new System.EventHandler(this.Txt_Name_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "کد ملی";
            // 
            // Txt_Code
            // 
            this.Txt_Code.Location = new System.Drawing.Point(17, 229);
            this.Txt_Code.Name = "Txt_Code";
            this.Txt_Code.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Txt_Code.Size = new System.Drawing.Size(210, 34);
            this.Txt_Code.TabIndex = 4;
            this.Txt_Code.TextChanged += new System.EventHandler(this.Txt_Name_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 27);
            this.label3.TabIndex = 5;
            this.label3.Text = "شماره تلفن همراه";
            // 
            // Txt_Phone
            // 
            this.Txt_Phone.Location = new System.Drawing.Point(17, 296);
            this.Txt_Phone.Name = "Txt_Phone";
            this.Txt_Phone.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Txt_Phone.Size = new System.Drawing.Size(210, 34);
            this.Txt_Phone.TabIndex = 6;
            this.Txt_Phone.TextChanged += new System.EventHandler(this.Txt_Name_TextChanged);
            // 
            // BGW
            // 
            this.BGW.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BGW_DoWork);
            this.BGW.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BGW_RunWorkerCompleted);
            // 
            // Print_Persons
            // 
            this.Print_Persons.EngineVersion = Stimulsoft.Report.Engine.StiEngineVersion.EngineV2;
            this.Print_Persons.ReferencedAssemblies = new string[] {
        "System.Dll",
        "System.Drawing.Dll",
        "System.Windows.Forms.Dll",
        "System.Data.Dll",
        "System.Xml.Dll",
        "Stimulsoft.Controls.Dll",
        "Stimulsoft.Base.Dll",
        "Stimulsoft.Report.Dll"};
            this.Print_Persons.ReportAlias = "Report";
            this.Print_Persons.ReportGuid = "75c6054cc8ec46db9381ca1b43979867";
            this.Print_Persons.ReportName = "Report";
            this.Print_Persons.ReportSource = resources.GetString("Print_Persons.ReportSource");
            this.Print_Persons.ReportUnit = Stimulsoft.Report.StiReportUnitType.Centimeters;
            this.Print_Persons.ScriptLanguage = Stimulsoft.Report.StiReportLanguageType.CSharp;
            this.Print_Persons.UseProgressInThread = false;
            // 
            // Form_ListpersonProject
            // 
            this.AcceptButton = this.Btn_Print;
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.Btn_BAck;
            this.ClientSize = new System.Drawing.Size(1155, 664);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("B Nazanin", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form_ListpersonProject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form_ListpersonProject";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form_ListpersonProject_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Person.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Person)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button Btn_Print;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button Btn_BAck;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_Code;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_Phone;
        private System.ComponentModel.BackgroundWorker BGW;
        private Telerik.WinControls.UI.RadGridView Grid_Person;
        private Telerik.WinControls.Themes.Office2007SilverTheme office2007SilverTheme1;
        private Stimulsoft.Report.StiReport Print_Persons;
    }
}