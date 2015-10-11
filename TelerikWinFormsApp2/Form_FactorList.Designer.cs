namespace EsfahanGhos
{
    partial class Form_FactorList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_FactorList));
            this.office2007SilverTheme1 = new Telerik.WinControls.Themes.Office2007SilverTheme();
            this.GridFactorList = new System.Windows.Forms.DataGridView();
            this.radif = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FactorNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Project = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShowFactor = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Remove = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FactorID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aquaTheme1 = new Telerik.WinControls.Themes.AquaTheme();
            this.BGW = new System.ComponentModel.BackgroundWorker();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.ComboProject = new Telerik.WinControls.UI.RadDropDownList();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Search = new Telerik.WinControls.UI.RadButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Btn_Print = new Telerik.WinControls.UI.RadButton();
            this.Btn_Register = new Telerik.WinControls.UI.RadButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Print_Factors = new Stimulsoft.Report.StiReport();
            ((System.ComponentModel.ISupportInitialize)(this.GridFactorList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ComboProject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Search)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Print)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Register)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // GridFactorList
            // 
            this.GridFactorList.AllowUserToAddRows = false;
            this.GridFactorList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("B Nazanin", 12F);
            this.GridFactorList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.GridFactorList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridFactorList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GridFactorList.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridFactorList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.GridFactorList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridFactorList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.radif,
            this.FactorNumber,
            this.Description,
            this.Date,
            this.TotalCost,
            this.Project,
            this.ShowFactor,
            this.Remove,
            this.FactorID});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridFactorList.DefaultCellStyle = dataGridViewCellStyle5;
            this.GridFactorList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GridFactorList.EnableHeadersVisualStyles = false;
            this.GridFactorList.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.GridFactorList.Location = new System.Drawing.Point(0, 128);
            this.GridFactorList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GridFactorList.MultiSelect = false;
            this.GridFactorList.Name = "GridFactorList";
            this.GridFactorList.ReadOnly = true;
            this.GridFactorList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridFactorList.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("B Nazanin", 12F);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Orange;
            this.GridFactorList.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.GridFactorList.RowTemplate.Height = 24;
            this.GridFactorList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridFactorList.Size = new System.Drawing.Size(1353, 536);
            this.GridFactorList.TabIndex = 12;
            this.GridFactorList.TabStop = false;
            this.GridFactorList.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GridFactorList_CellMouseClick);
            this.GridFactorList.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.GridFactorList_CellPainting);
            // 
            // radif
            // 
            this.radif.FillWeight = 7.238616F;
            this.radif.HeaderText = "ردیف";
            this.radif.Name = "radif";
            this.radif.ReadOnly = true;
            // 
            // FactorNumber
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.FactorNumber.DefaultCellStyle = dataGridViewCellStyle3;
            this.FactorNumber.FillWeight = 16F;
            this.FactorNumber.HeaderText = "شماره فاکتور";
            this.FactorNumber.Name = "FactorNumber";
            this.FactorNumber.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.FillWeight = 15F;
            this.Description.HeaderText = "توضیحات";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.FillWeight = 14.47723F;
            this.Date.HeaderText = "تاریخ";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // TotalCost
            // 
            this.TotalCost.FillWeight = 20.27641F;
            this.TotalCost.HeaderText = "قیمت کل";
            this.TotalCost.Name = "TotalCost";
            this.TotalCost.ReadOnly = true;
            // 
            // Project
            // 
            this.Project.FillWeight = 17.05831F;
            this.Project.HeaderText = "پروژه";
            this.Project.Name = "Project";
            this.Project.ReadOnly = true;
            // 
            // ShowFactor
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.NullValue = "مشاهده فاکتور";
            this.ShowFactor.DefaultCellStyle = dataGridViewCellStyle4;
            this.ShowFactor.FillWeight = 14.74109F;
            this.ShowFactor.HeaderText = "...";
            this.ShowFactor.Name = "ShowFactor";
            this.ShowFactor.ReadOnly = true;
            this.ShowFactor.Text = "";
            // 
            // Remove
            // 
            this.Remove.FillWeight = 6.646685F;
            this.Remove.HeaderText = "...";
            this.Remove.Name = "Remove";
            this.Remove.ReadOnly = true;
            this.Remove.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Remove.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // FactorID
            // 
            this.FactorID.HeaderText = "FactorID";
            this.FactorID.Name = "FactorID";
            this.FactorID.ReadOnly = true;
            this.FactorID.Visible = false;
            // 
            // BGW
            // 
            this.BGW.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BGW_DoWork);
            this.BGW.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BGW_RunWorkerCompleted);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "add-icon.png");
            this.imageList1.Images.SetKeyName(1, "Aha-Soft-Large-Business-Printer.ico");
            this.imageList1.Images.SetKeyName(2, "Tatice-Cristal-Intense-Loupe.ico");
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radGroupBox1.Controls.Add(this.ComboProject);
            this.radGroupBox1.Controls.Add(this.label1);
            this.radGroupBox1.Controls.Add(this.Btn_Search);
            this.radGroupBox1.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.radGroupBox1.HeaderText = "جستجو";
            this.radGroupBox1.Location = new System.Drawing.Point(645, 12);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radGroupBox1.Size = new System.Drawing.Size(381, 111);
            this.radGroupBox1.TabIndex = 15;
            this.radGroupBox1.Text = "جستجو";
            this.radGroupBox1.ThemeName = "Office2007Silver";
            // 
            // ComboProject
            // 
            this.ComboProject.AllowShowFocusCues = false;
            this.ComboProject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboProject.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.ComboProject.Location = new System.Drawing.Point(154, 44);
            this.ComboProject.Name = "ComboProject";
            this.ComboProject.Size = new System.Drawing.Size(156, 38);
            this.ComboProject.TabIndex = 18;
            this.ComboProject.Text = "لیست پروژه ها";
            this.ComboProject.ThemeName = "Aqua";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(316, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 32);
            this.label1.TabIndex = 17;
            this.label1.Text = "پروژه :";
            // 
            // Btn_Search
            // 
            this.Btn_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Search.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.Btn_Search.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn_Search.ImageKey = "Tatice-Cristal-Intense-Loupe.ico";
            this.Btn_Search.ImageList = this.imageList1;
            this.Btn_Search.Location = new System.Drawing.Point(48, 33);
            this.Btn_Search.Name = "Btn_Search";
            this.Btn_Search.Size = new System.Drawing.Size(68, 60);
            this.Btn_Search.TabIndex = 16;
            this.Btn_Search.ThemeName = "Aqua";
            this.Btn_Search.Click += new System.EventHandler(this.Btn_Search_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(645, 363);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // Btn_Print
            // 
            this.Btn_Print.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Print.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Print.Enabled = false;
            this.Btn_Print.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.Btn_Print.ImageKey = "Aha-Soft-Large-Business-Printer.ico";
            this.Btn_Print.ImageList = this.imageList1;
            this.Btn_Print.Location = new System.Drawing.Point(1138, 75);
            this.Btn_Print.Name = "Btn_Print";
            this.Btn_Print.Size = new System.Drawing.Size(203, 48);
            this.Btn_Print.TabIndex = 15;
            this.Btn_Print.Text = "چاپ فاکتور";
            this.Btn_Print.ThemeName = "Aqua";
            this.Btn_Print.Click += new System.EventHandler(this.Btn_Print_Click);
            // 
            // Btn_Register
            // 
            this.Btn_Register.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Register.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Register.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.Btn_Register.ImageKey = "add-icon.png";
            this.Btn_Register.ImageList = this.imageList1;
            this.Btn_Register.Location = new System.Drawing.Point(1138, 21);
            this.Btn_Register.Name = "Btn_Register";
            this.Btn_Register.Size = new System.Drawing.Size(203, 48);
            this.Btn_Register.TabIndex = 14;
            this.Btn_Register.Text = "ثبت فاکتور جدید";
            this.Btn_Register.ThemeName = "Aqua";
            this.Btn_Register.Click += new System.EventHandler(this.Btn_Register_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Print_Factors
            // 
            this.Print_Factors.EngineVersion = Stimulsoft.Report.Engine.StiEngineVersion.EngineV2;
            this.Print_Factors.ReferencedAssemblies = new string[] {
        "System.Dll",
        "System.Drawing.Dll",
        "System.Windows.Forms.Dll",
        "System.Data.Dll",
        "System.Xml.Dll",
        "Stimulsoft.Controls.Dll",
        "Stimulsoft.Base.Dll",
        "Stimulsoft.Report.Dll"};
            this.Print_Factors.ReportAlias = "Report";
            this.Print_Factors.ReportGuid = "71d37745e8234499bdccb88c04191579";
            this.Print_Factors.ReportName = "Report";
            this.Print_Factors.ReportSource = resources.GetString("Print_Factors.ReportSource");
            this.Print_Factors.ReportUnit = Stimulsoft.Report.StiReportUnitType.Centimeters;
            this.Print_Factors.ScriptLanguage = Stimulsoft.Report.StiReportLanguageType.CSharp;
            this.Print_Factors.UseProgressInThread = false;
            // 
            // Form_FactorList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1353, 664);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Btn_Print);
            this.Controls.Add(this.radGroupBox1);
            this.Controls.Add(this.Btn_Register);
            this.Controls.Add(this.GridFactorList);
            this.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1361, 696);
            this.MinimumSize = new System.Drawing.Size(1361, 696);
            this.Name = "Form_FactorList";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.RootElement.MaxSize = new System.Drawing.Size(1361, 696);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "";
            this.ThemeName = "Office2007Silver";
            this.Load += new System.EventHandler(this.Form_FactorList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridFactorList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ComboProject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Search)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Print)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Register)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.Themes.Office2007SilverTheme office2007SilverTheme1;
        private System.Windows.Forms.DataGridView GridFactorList;
        private Telerik.WinControls.Themes.AquaTheme aquaTheme1;
        private System.ComponentModel.BackgroundWorker BGW;
        private Telerik.WinControls.UI.RadButton Btn_Register;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private System.Windows.Forms.ImageList imageList1;
        private Telerik.WinControls.UI.RadButton Btn_Print;
        private Telerik.WinControls.UI.RadButton Btn_Search;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Telerik.WinControls.UI.RadDropDownList ComboProject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn radif;
        private System.Windows.Forms.DataGridViewTextBoxColumn FactorNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Project;
        private System.Windows.Forms.DataGridViewButtonColumn ShowFactor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remove;
        private System.Windows.Forms.DataGridViewTextBoxColumn FactorID;
        private System.Windows.Forms.Timer timer1;
        private Stimulsoft.Report.StiReport Print_Factors;

    }
}
