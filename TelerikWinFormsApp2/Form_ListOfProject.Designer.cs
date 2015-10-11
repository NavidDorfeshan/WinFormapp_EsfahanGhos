namespace EsfahanGhos
{
    partial class Form_ListOfProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ListOfProject));
            this.GridProject = new Telerik.WinControls.UI.RadGridView();
            this.aquaTheme1 = new Telerik.WinControls.Themes.AquaTheme();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.Button_Close = new Telerik.WinControls.UI.RadButton();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.Button_Report = new Telerik.WinControls.UI.RadButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Txt_NameKarfarma = new Telerik.WinControls.UI.RadTextBox();
            this.Txt_PName = new Telerik.WinControls.UI.RadTextBox();
            this.Txt_ProjectID = new Telerik.WinControls.UI.RadTextBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.BGW = new System.ComponentModel.BackgroundWorker();
            this.office2007SilverTheme1 = new Telerik.WinControls.Themes.Office2007SilverTheme();
            ((System.ComponentModel.ISupportInitialize)(this.GridProject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridProject.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Button_Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_Report)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_NameKarfarma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_PName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_ProjectID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // GridProject
            // 
            this.GridProject.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GridProject.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.GridProject.Location = new System.Drawing.Point(0, 132);
            // 
            // GridProject
            // 
            this.GridProject.MasterTemplate.AllowAddNewRow = false;
            this.GridProject.MasterTemplate.AllowColumnReorder = false;
            gridViewTextBoxColumn1.FieldName = "ProjectID";
            gridViewTextBoxColumn1.HeaderText = "کد پروژه";
            gridViewTextBoxColumn1.Name = "ProjectID";
            gridViewTextBoxColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn1.Width = 100;
            gridViewTextBoxColumn2.FieldName = "ProjectName";
            gridViewTextBoxColumn2.HeaderText = "نام پروژه";
            gridViewTextBoxColumn2.Name = "column1";
            gridViewTextBoxColumn2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn2.Width = 150;
            gridViewTextBoxColumn3.HeaderText = "نام کارفرما";
            gridViewTextBoxColumn3.Name = "column6";
            gridViewTextBoxColumn3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn3.Width = 100;
            gridViewTextBoxColumn4.FieldName = "ProjectArea";
            gridViewTextBoxColumn4.HeaderText = "مساحت";
            gridViewTextBoxColumn4.Name = "column3";
            gridViewTextBoxColumn4.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn4.Width = 100;
            gridViewTextBoxColumn5.HeaderText = "تاریخ شروع";
            gridViewTextBoxColumn5.Name = "Date";
            gridViewTextBoxColumn5.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn5.Width = 100;
            gridViewTextBoxColumn6.HeaderText = "مبلغ قرارداد";
            gridViewTextBoxColumn6.Name = "column5";
            gridViewTextBoxColumn6.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn6.Width = 100;
            this.GridProject.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6});
            this.GridProject.Name = "GridProject";
            this.GridProject.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.GridProject.ReadOnly = true;
            this.GridProject.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GridProject.Size = new System.Drawing.Size(903, 267);
            this.GridProject.TabIndex = 0;
            this.GridProject.Text = "radGridView1";
            this.GridProject.ThemeName = "Office2007Silver";
            this.GridProject.CellClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.GridProject_CellClick);
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.Button_Close);
            this.radGroupBox1.Controls.Add(this.Button_Report);
            this.radGroupBox1.Controls.Add(this.flowLayoutPanel1);
            this.radGroupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radGroupBox1.Font = new System.Drawing.Font("Adobe Arabic", 13.8F, System.Drawing.FontStyle.Bold);
            this.radGroupBox1.GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office;
            this.radGroupBox1.HeaderAlignment = Telerik.WinControls.UI.HeaderAlignment.Far;
            this.radGroupBox1.HeaderText = "جستجو";
            this.radGroupBox1.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.radGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(903, 127);
            this.radGroupBox1.TabIndex = 4;
            this.radGroupBox1.Text = "جستجو";
            this.radGroupBox1.ThemeName = "Aqua";
            // 
            // Button_Close
            // 
            this.Button_Close.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.Button_Close.ImageKey = "Kyo-Tux-Soft-Back.ico";
            this.Button_Close.ImageList = this.imageList;
            this.Button_Close.Location = new System.Drawing.Point(216, 79);
            this.Button_Close.Name = "Button_Close";
            this.Button_Close.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Button_Close.Size = new System.Drawing.Size(87, 41);
            this.Button_Close.TabIndex = 1;
            this.Button_Close.Text = "خروج";
            this.Button_Close.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.Button_Close.ThemeName = "Aqua";
            this.Button_Close.Click += new System.EventHandler(this.Button_Close_Click);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "Calendar-icon.png");
            this.imageList.Images.SetKeyName(1, "add-icon.png");
            this.imageList.Images.SetKeyName(2, "Kyo-Tux-Soft-Back.ico");
            this.imageList.Images.SetKeyName(3, "Tatice-Cristal-Intense-Loupe.ico");
            this.imageList.Images.SetKeyName(4, "Aha-Soft-Large-Business-Printer.ico");
            // 
            // Button_Report
            // 
            this.Button_Report.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.Button_Report.ImageKey = "Aha-Soft-Large-Business-Printer.ico";
            this.Button_Report.ImageList = this.imageList;
            this.Button_Report.Location = new System.Drawing.Point(309, 79);
            this.Button_Report.Name = "Button_Report";
            this.Button_Report.Size = new System.Drawing.Size(88, 43);
            this.Button_Report.TabIndex = 0;
            this.Button_Report.Text = "چاپ";
            this.Button_Report.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.Button_Report.ThemeName = "Aqua";
            this.toolTip.SetToolTip(this.Button_Report, "چاپ اطلاعات جدول");
            this.Button_Report.Click += new System.EventHandler(this.Button_Report_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.Txt_NameKarfarma);
            this.flowLayoutPanel1.Controls.Add(this.Txt_PName);
            this.flowLayoutPanel1.Controls.Add(this.Txt_ProjectID);
            this.flowLayoutPanel1.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(518, 79);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(373, 43);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // Txt_NameKarfarma
            // 
            this.Txt_NameKarfarma.Font = new System.Drawing.Font("Adobe Arabic", 13.8F, System.Drawing.FontStyle.Bold);
            this.Txt_NameKarfarma.Location = new System.Drawing.Point(3, 3);
            this.Txt_NameKarfarma.Name = "Txt_NameKarfarma";
            this.Txt_NameKarfarma.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Txt_NameKarfarma.Size = new System.Drawing.Size(115, 32);
            this.Txt_NameKarfarma.TabIndex = 2;
            this.Txt_NameKarfarma.ThemeName = "Aqua";
            this.toolTip.SetToolTip(this.Txt_NameKarfarma, "نام کارفرما");
            this.Txt_NameKarfarma.TextChanged += new System.EventHandler(this.Txt_NameKarfarma_TextChanged);
            // 
            // Txt_PName
            // 
            this.Txt_PName.Font = new System.Drawing.Font("Adobe Arabic", 13.8F, System.Drawing.FontStyle.Bold);
            this.Txt_PName.Location = new System.Drawing.Point(124, 3);
            this.Txt_PName.Name = "Txt_PName";
            this.Txt_PName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Txt_PName.Size = new System.Drawing.Size(115, 32);
            this.Txt_PName.TabIndex = 1;
            this.Txt_PName.ThemeName = "Aqua";
            this.toolTip.SetToolTip(this.Txt_PName, "نام پروژه");
            this.Txt_PName.TextChanged += new System.EventHandler(this.Txt_PName_TextChanged);
            // 
            // Txt_ProjectID
            // 
            this.Txt_ProjectID.Font = new System.Drawing.Font("Adobe Arabic", 13.8F, System.Drawing.FontStyle.Bold);
            this.Txt_ProjectID.Location = new System.Drawing.Point(245, 3);
            this.Txt_ProjectID.Name = "Txt_ProjectID";
            this.Txt_ProjectID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Txt_ProjectID.Size = new System.Drawing.Size(115, 32);
            this.Txt_ProjectID.TabIndex = 0;
            this.Txt_ProjectID.ThemeName = "Aqua";
            this.toolTip.SetToolTip(this.Txt_ProjectID, "کد پروژه");
            this.Txt_ProjectID.TextChanged += new System.EventHandler(this.Txt_ProjectID_TextChanged);
            // 
            // BGW
            // 
            this.BGW.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BGW_DoWork);
            this.BGW.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BGW_RunWorkerCompleted);
            // 
            // Form_ListOfProject
            // 
            this.AcceptButton = this.Button_Report;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 399);
            this.Controls.Add(this.radGroupBox1);
            this.Controls.Add(this.GridProject);
            this.Font = new System.Drawing.Font("Adobe Arabic", 13.8F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IconScaling = Telerik.WinControls.Enumerations.ImageScaling.None;
            this.Name = "Form_ListOfProject";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "";
            this.ThemeName = "Aqua";
            this.Load += new System.EventHandler(this.Form_ListOfProject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridProject.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridProject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Button_Close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_Report)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_NameKarfarma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_PName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_ProjectID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView GridProject;
        private Telerik.WinControls.Themes.AquaTheme aquaTheme1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Telerik.WinControls.UI.RadTextBox Txt_NameKarfarma;
        private Telerik.WinControls.UI.RadTextBox Txt_PName;
        private Telerik.WinControls.UI.RadTextBox Txt_ProjectID;
        private Telerik.WinControls.UI.RadButton Button_Report;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.ToolTip toolTip;
        private System.ComponentModel.BackgroundWorker BGW;
        private Telerik.WinControls.UI.RadButton Button_Close;
        private Telerik.WinControls.Themes.Office2007SilverTheme office2007SilverTheme1;
        //private Stimulsoft.Report.StiReport Report;
    }
}
