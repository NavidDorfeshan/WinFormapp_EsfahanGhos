namespace EsfahanGhos
{
    partial class Form_CreditTankhah
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_CreditTankhah));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.aquaTheme1 = new Telerik.WinControls.Themes.AquaTheme();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.BGW = new System.ComponentModel.BackgroundWorker();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.GridListCredits = new System.Windows.Forms.DataGridView();
            this.ShamsiDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TankhahID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreditID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Txt_CurrentCredit = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.radGroupBox2 = new Telerik.WinControls.UI.RadGroupBox();
            this.Txt_Description = new Telerik.WinControls.UI.RadTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Btn_Delete = new Telerik.WinControls.UI.RadButton();
            this.Txt_Price = new Telerik.WinControls.UI.RadTextBox();
            this.Btn_RegCredit = new Telerik.WinControls.UI.RadButton();
            this.Btn_CLose = new Telerik.WinControls.UI.RadButton();
            this.label3 = new System.Windows.Forms.Label();
            this.Date = new FarsiCalendarComponent.FarsiDatePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.Combo_Tankhah = new Telerik.WinControls.UI.RadDropDownList();
            this.label1 = new System.Windows.Forms.Label();
            this.office2007SilverTheme1 = new Telerik.WinControls.Themes.Office2007SilverTheme();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Grid_Credit = new Telerik.WinControls.UI.MasterGridViewTemplate();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridListCredits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).BeginInit();
            this.radGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Description)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Delete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Price)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_RegCredit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_CLose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Combo_Tankhah)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Credit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Custom-Icon-Design-Pretty-Office-9-Edit-validated.ico");
            this.imageList1.Images.SetKeyName(1, "Awicons-Vista-Artistic-Add.ico");
            this.imageList1.Images.SetKeyName(2, "Awicons-Vista-Artistic-Delete.ico");
            this.imageList1.Images.SetKeyName(3, "Custom-Icon-Design-Pretty-Office-6-Custom-reports.ico");
            this.imageList1.Images.SetKeyName(4, "Aha-Soft-Universal-Shop-Print.ico");
            this.imageList1.Images.SetKeyName(5, "Custom-Icon-Design-Flatastic-5-Sales-report.ico");
            this.imageList1.Images.SetKeyName(6, "Hopstarter-Sleek-Xp-Basic-Preview.ico");
            // 
            // BGW
            // 
            this.BGW.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BGW_DoWork);
            this.BGW.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BGW_RunWorkerCompleted);
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.GridListCredits);
            this.radGroupBox1.Controls.Add(this.Txt_CurrentCredit);
            this.radGroupBox1.Controls.Add(this.label6);
            this.radGroupBox1.Controls.Add(this.radGroupBox2);
            this.radGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGroupBox1.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.radGroupBox1.HeaderText = "اعتبار تنخواه";
            this.radGroupBox1.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.radGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(867, 483);
            this.radGroupBox1.TabIndex = 0;
            this.radGroupBox1.Text = "اعتبار تنخواه";
            this.radGroupBox1.ThemeName = "Aqua";
            // 
            // GridListCredits
            // 
            this.GridListCredits.AllowUserToAddRows = false;
            this.GridListCredits.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("B Nazanin", 12F);
            this.GridListCredits.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.GridListCredits.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridListCredits.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("B Nazanin", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridListCredits.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.GridListCredits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridListCredits.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ShamsiDate,
            this.Value,
            this.TankhahID,
            this.Date1,
            this.CreditID});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("B Nazanin", 12F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridListCredits.DefaultCellStyle = dataGridViewCellStyle5;
            this.GridListCredits.EnableHeadersVisualStyles = false;
            this.GridListCredits.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.GridListCredits.Location = new System.Drawing.Point(12, 41);
            this.GridListCredits.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GridListCredits.MultiSelect = false;
            this.GridListCredits.Name = "GridListCredits";
            this.GridListCredits.ReadOnly = true;
            this.GridListCredits.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridListCredits.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("B Nazanin", 12F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Orange;
            this.GridListCredits.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.GridListCredits.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Adobe Arabic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GridListCredits.RowTemplate.Height = 30;
            this.GridListCredits.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridListCredits.Size = new System.Drawing.Size(460, 389);
            this.GridListCredits.TabIndex = 37;
            this.GridListCredits.TabStop = false;
            this.GridListCredits.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GridListCredits_CellMouseClick);
            // 
            // ShamsiDate
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.ShamsiDate.DefaultCellStyle = dataGridViewCellStyle3;
            this.ShamsiDate.FillWeight = 105F;
            this.ShamsiDate.HeaderText = "تاریخ";
            this.ShamsiDate.Name = "ShamsiDate";
            this.ShamsiDate.ReadOnly = true;
            // 
            // Value
            // 
            this.Value.DataPropertyName = "Value";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.Value.DefaultCellStyle = dataGridViewCellStyle4;
            this.Value.FillWeight = 105F;
            this.Value.HeaderText = "اعتبار";
            this.Value.Name = "Value";
            this.Value.ReadOnly = true;
            // 
            // TankhahID
            // 
            this.TankhahID.DataPropertyName = "TankhaID";
            this.TankhahID.HeaderText = "TankhahID";
            this.TankhahID.Name = "TankhahID";
            this.TankhahID.ReadOnly = true;
            this.TankhahID.Visible = false;
            // 
            // Date1
            // 
            this.Date1.DataPropertyName = "Date";
            this.Date1.HeaderText = "Date";
            this.Date1.Name = "Date1";
            this.Date1.ReadOnly = true;
            this.Date1.Visible = false;
            // 
            // CreditID
            // 
            this.CreditID.HeaderText = "CreditID";
            this.CreditID.Name = "CreditID";
            this.CreditID.ReadOnly = true;
            this.CreditID.Visible = false;
            // 
            // Txt_CurrentCredit
            // 
            this.Txt_CurrentCredit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_CurrentCredit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Txt_CurrentCredit.Enabled = false;
            this.Txt_CurrentCredit.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.Txt_CurrentCredit.Location = new System.Drawing.Point(12, 434);
            this.Txt_CurrentCredit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_CurrentCredit.Name = "Txt_CurrentCredit";
            this.Txt_CurrentCredit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Txt_CurrentCredit.Size = new System.Drawing.Size(153, 39);
            this.Txt_CurrentCredit.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(171, 438);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(101, 32);
            this.label6.TabIndex = 36;
            this.label6.Text = "اعتبار فعلی :";
            this.toolTip1.SetToolTip(this.label6, "اعتبار فعلی تنخواه انتخاب شده");
            // 
            // radGroupBox2
            // 
            this.radGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radGroupBox2.Controls.Add(this.Txt_Description);
            this.radGroupBox2.Controls.Add(this.label5);
            this.radGroupBox2.Controls.Add(this.Btn_Delete);
            this.radGroupBox2.Controls.Add(this.Txt_Price);
            this.radGroupBox2.Controls.Add(this.Btn_RegCredit);
            this.radGroupBox2.Controls.Add(this.Btn_CLose);
            this.radGroupBox2.Controls.Add(this.label3);
            this.radGroupBox2.Controls.Add(this.Date);
            this.radGroupBox2.Controls.Add(this.label2);
            this.radGroupBox2.Controls.Add(this.Combo_Tankhah);
            this.radGroupBox2.Controls.Add(this.label1);
            this.radGroupBox2.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.radGroupBox2.HeaderText = "";
            this.radGroupBox2.Location = new System.Drawing.Point(478, 41);
            this.radGroupBox2.Name = "radGroupBox2";
            this.radGroupBox2.Size = new System.Drawing.Size(377, 430);
            this.radGroupBox2.TabIndex = 1;
            this.radGroupBox2.ThemeName = "Aqua";
            // 
            // Txt_Description
            // 
            this.Txt_Description.AutoSize = false;
            this.Txt_Description.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.Txt_Description.Location = new System.Drawing.Point(89, 136);
            this.Txt_Description.Multiline = true;
            this.Txt_Description.Name = "Txt_Description";
            this.Txt_Description.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Txt_Description.Size = new System.Drawing.Size(156, 112);
            this.Txt_Description.TabIndex = 73;
            this.Txt_Description.ThemeName = "Aqua";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(283, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 32);
            this.label5.TabIndex = 72;
            this.label5.Text = "توضیحات :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Delete.Enabled = false;
            this.Btn_Delete.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.Btn_Delete.ImageIndex = 2;
            this.Btn_Delete.ImageKey = "Awicons-Vista-Artistic-Add.ico";
            this.Btn_Delete.ImageList = this.imageList1;
            this.Btn_Delete.Location = new System.Drawing.Point(32, 309);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(154, 51);
            this.Btn_Delete.TabIndex = 71;
            this.Btn_Delete.Text = "حذف";
            this.Btn_Delete.ThemeName = "Aqua";
            this.toolTip1.SetToolTip(this.Btn_Delete, "قبل از حذف اعتبار دقت نمایید چکی که به تنخواه داده اید\r\nپاس نشده باشد یا \r\nباطل ن" +
        "شده باشد یا\r\nبرگشت نخورده باشد \r\n در غیر اینصورت این اعتبار را حذف نکنید");
            this.Btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            // 
            // Txt_Price
            // 
            this.Txt_Price.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.Txt_Price.Location = new System.Drawing.Point(89, 92);
            this.Txt_Price.Name = "Txt_Price";
            this.Txt_Price.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Txt_Price.Size = new System.Drawing.Size(156, 38);
            this.Txt_Price.TabIndex = 71;
            this.Txt_Price.ThemeName = "Aqua";
            this.Txt_Price.TextChanged += new System.EventHandler(this.Txt_Price_TextChanged);
            this.Txt_Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Price_KeyPress);
            // 
            // Btn_RegCredit
            // 
            this.Btn_RegCredit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_RegCredit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_RegCredit.Enabled = false;
            this.Btn_RegCredit.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.Btn_RegCredit.ImageIndex = 1;
            this.Btn_RegCredit.ImageKey = "Awicons-Vista-Artistic-Add.ico";
            this.Btn_RegCredit.ImageList = this.imageList1;
            this.Btn_RegCredit.Location = new System.Drawing.Point(192, 309);
            this.Btn_RegCredit.Name = "Btn_RegCredit";
            this.Btn_RegCredit.Size = new System.Drawing.Size(154, 51);
            this.Btn_RegCredit.TabIndex = 70;
            this.Btn_RegCredit.Text = "ثبت";
            this.Btn_RegCredit.ThemeName = "Aqua";
            this.Btn_RegCredit.Click += new System.EventHandler(this.Btn_RegCredit_Click);
            // 
            // Btn_CLose
            // 
            this.Btn_CLose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_CLose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_CLose.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.Btn_CLose.ImageKey = "Awicons-Vista-Artistic-Add.ico";
            this.Btn_CLose.Location = new System.Drawing.Point(32, 366);
            this.Btn_CLose.Name = "Btn_CLose";
            this.Btn_CLose.Size = new System.Drawing.Size(314, 51);
            this.Btn_CLose.TabIndex = 69;
            this.Btn_CLose.Text = "خروج";
            this.Btn_CLose.ThemeName = "Aqua";
            this.Btn_CLose.Click += new System.EventHandler(this.Btn_CLose_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(317, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "مبلغ :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Date
            // 
            this.Date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Date.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Date.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Date.GeoDate = new System.DateTime(2015, 4, 15, 0, 0, 0, 0);
            this.Date.Location = new System.Drawing.Point(89, 59);
            this.Date.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Date.MaximumSize = new System.Drawing.Size(1333, 26);
            this.Date.Name = "Date";
            this.Date.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Date.Size = new System.Drawing.Size(156, 26);
            this.Date.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(312, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "تاریخ :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Combo_Tankhah
            // 
            this.Combo_Tankhah.AllowShowFocusCues = false;
            this.Combo_Tankhah.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Combo_Tankhah.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Combo_Tankhah.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.Combo_Tankhah.Location = new System.Drawing.Point(89, 14);
            this.Combo_Tankhah.Name = "Combo_Tankhah";
            this.Combo_Tankhah.Size = new System.Drawing.Size(156, 38);
            this.Combo_Tankhah.TabIndex = 1;
            this.Combo_Tankhah.Text = "نام تنخواه";
            this.Combo_Tankhah.ThemeName = "Aqua";
            this.Combo_Tankhah.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.Combo_Tankhah_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(305, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "تنخواه :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Grid_Credit
            // 
            this.Grid_Credit.AllowColumnReorder = false;
            gridViewTextBoxColumn1.FieldName = "CreditID";
            gridViewTextBoxColumn1.HeaderText = "column4";
            gridViewTextBoxColumn1.IsVisible = false;
            gridViewTextBoxColumn1.Name = "column4";
            gridViewTextBoxColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn2.FieldName = "Date";
            gridViewTextBoxColumn2.HeaderText = "تاریخ";
            gridViewTextBoxColumn2.Name = "Date";
            gridViewTextBoxColumn2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn2.Width = 100;
            gridViewTextBoxColumn3.FieldName = "Price";
            gridViewTextBoxColumn3.HeaderText = "اعتبار";
            gridViewTextBoxColumn3.Name = "Price";
            gridViewTextBoxColumn3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn3.Width = 150;
            gridViewTextBoxColumn4.HeaderText = "شماره فیش";
            gridViewTextBoxColumn4.Name = "Number";
            gridViewTextBoxColumn4.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn4.Width = 100;
            this.Grid_Credit.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4});
            // 
            // Form_CreditTankhah
            // 
            this.AcceptButton = this.Btn_RegCredit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(867, 483);
            this.Controls.Add(this.radGroupBox1);
            this.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_CreditTankhah";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_CreditTankhah";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.Form_CreditTankhah_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridListCredits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).EndInit();
            this.radGroupBox2.ResumeLayout(false);
            this.radGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Description)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Delete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Price)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_RegCredit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_CLose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Combo_Tankhah)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Credit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.Themes.AquaTheme aquaTheme1;
        private System.Windows.Forms.ImageList imageList1;
        private System.ComponentModel.BackgroundWorker BGW;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox2;
        private Telerik.WinControls.Themes.Office2007SilverTheme office2007SilverTheme1;
        private FarsiCalendarComponent.FarsiDatePicker Date;
        private System.Windows.Forms.Label label2;
        private Telerik.WinControls.UI.RadDropDownList Combo_Tankhah;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private Telerik.WinControls.UI.RadButton Btn_RegCredit;
        private Telerik.WinControls.UI.RadButton Btn_CLose;
        private Telerik.WinControls.UI.RadTextBox Txt_Price;
        private Telerik.WinControls.UI.RadButton Btn_Delete;
        private Telerik.WinControls.UI.RadTextBox Txt_Description;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txt_CurrentCredit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridView GridListCredits;
        private Telerik.WinControls.UI.MasterGridViewTemplate Grid_Credit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShamsiDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private System.Windows.Forms.DataGridViewTextBoxColumn TankhahID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreditID;
    }
}
