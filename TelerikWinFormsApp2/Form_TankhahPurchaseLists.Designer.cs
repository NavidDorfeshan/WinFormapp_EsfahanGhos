namespace EsfahanGhos
{
    partial class Form_TankhahPurchaseLists
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_TankhahPurchaseLists));
            this.aquaTheme1 = new Telerik.WinControls.Themes.AquaTheme();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.LblNoPurchaseList = new System.Windows.Forms.Label();
            this.radButton3 = new Telerik.WinControls.UI.RadButton();
            this.BtnRemove = new Telerik.WinControls.UI.RadButton();
            this.GridListPurchace = new System.Windows.Forms.DataGridView();
            this.TankhahName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseListNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Print = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseListID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TankhahID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LblTankhahName = new System.Windows.Forms.Label();
            this.CmbTankhah = new System.Windows.Forms.ComboBox();
            this.BgwTankhahsP = new System.ComponentModel.BackgroundWorker();
            this.Print_purchase = new Stimulsoft.Report.StiReport();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radButton3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnRemove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridListPurchace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.LblNoPurchaseList);
            this.radGroupBox1.Controls.Add(this.radButton3);
            this.radGroupBox1.Controls.Add(this.BtnRemove);
            this.radGroupBox1.Controls.Add(this.GridListPurchace);
            this.radGroupBox1.Controls.Add(this.LblTankhahName);
            this.radGroupBox1.Controls.Add(this.CmbTankhah);
            this.radGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGroupBox1.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.radGroupBox1.GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office;
            this.radGroupBox1.HeaderText = "لیست های ثبت شده";
            this.radGroupBox1.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.radGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(769, 575);
            this.radGroupBox1.TabIndex = 0;
            this.radGroupBox1.Text = "لیست های ثبت شده";
            this.radGroupBox1.ThemeName = "Aqua";
            // 
            // LblNoPurchaseList
            // 
            this.LblNoPurchaseList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblNoPurchaseList.AutoSize = true;
            this.LblNoPurchaseList.BackColor = System.Drawing.Color.White;
            this.LblNoPurchaseList.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.LblNoPurchaseList.ForeColor = System.Drawing.Color.Red;
            this.LblNoPurchaseList.Location = new System.Drawing.Point(295, 339);
            this.LblNoPurchaseList.Name = "LblNoPurchaseList";
            this.LblNoPurchaseList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LblNoPurchaseList.Size = new System.Drawing.Size(214, 32);
            this.LblNoPurchaseList.TabIndex = 76;
            this.LblNoPurchaseList.Text = "هیچ لیست خریدی یافت نشد";
            this.LblNoPurchaseList.Visible = false;
            // 
            // radButton3
            // 
            this.radButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radButton3.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.radButton3.Location = new System.Drawing.Point(12, 64);
            this.radButton3.Name = "radButton3";
            this.radButton3.Size = new System.Drawing.Size(111, 45);
            this.radButton3.TabIndex = 75;
            this.radButton3.Text = "خروج";
            this.radButton3.ThemeName = "Aqua";
            this.radButton3.Click += new System.EventHandler(this.radButton3_Click);
            // 
            // BtnRemove
            // 
            this.BtnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRemove.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.BtnRemove.Location = new System.Drawing.Point(169, 64);
            this.BtnRemove.Name = "BtnRemove";
            this.BtnRemove.Size = new System.Drawing.Size(111, 45);
            this.BtnRemove.TabIndex = 74;
            this.BtnRemove.Text = "حذف";
            this.BtnRemove.ThemeName = "Aqua";
            this.BtnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // GridListPurchace
            // 
            this.GridListPurchace.AllowUserToAddRows = false;
            this.GridListPurchace.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("B Nazanin", 12F);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Orange;
            this.GridListPurchace.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.GridListPurchace.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridListPurchace.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("B Nazanin", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridListPurchace.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.GridListPurchace.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridListPurchace.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TankhahName,
            this.PurchaseListNumber,
            this.Date,
            this.TotalPrice,
            this.Print,
            this.PurchaseListID,
            this.TankhahID});
            this.GridListPurchace.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("B Nazanin", 12F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridListPurchace.DefaultCellStyle = dataGridViewCellStyle8;
            this.GridListPurchace.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GridListPurchace.EnableHeadersVisualStyles = false;
            this.GridListPurchace.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.GridListPurchace.Location = new System.Drawing.Point(2, 138);
            this.GridListPurchace.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GridListPurchace.MultiSelect = false;
            this.GridListPurchace.Name = "GridListPurchace";
            this.GridListPurchace.ReadOnly = true;
            this.GridListPurchace.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("B Nazanin", 12F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridListPurchace.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("B Nazanin", 12F);
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Orange;
            this.GridListPurchace.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.GridListPurchace.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Adobe Arabic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GridListPurchace.RowTemplate.Height = 30;
            this.GridListPurchace.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridListPurchace.Size = new System.Drawing.Size(765, 435);
            this.GridListPurchace.TabIndex = 72;
            this.GridListPurchace.TabStop = false;
            this.GridListPurchace.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GridListP_CellClick);
            this.GridListPurchace.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GridListP_DoubleClick);
            this.GridListPurchace.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.GridListPurchace_CellPainting);
            // 
            // TankhahName
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.TankhahName.DefaultCellStyle = dataGridViewCellStyle3;
            this.TankhahName.HeaderText = "تنخواه";
            this.TankhahName.Name = "TankhahName";
            this.TankhahName.ReadOnly = true;
            this.TankhahName.Visible = false;
            // 
            // PurchaseListNumber
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.PurchaseListNumber.DefaultCellStyle = dataGridViewCellStyle4;
            this.PurchaseListNumber.HeaderText = "شماره";
            this.PurchaseListNumber.Name = "PurchaseListNumber";
            this.PurchaseListNumber.ReadOnly = true;
            // 
            // Date
            // 
            dataGridViewCellStyle5.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.Date.DefaultCellStyle = dataGridViewCellStyle5;
            this.Date.HeaderText = "تاریخ";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // TotalPrice
            // 
            dataGridViewCellStyle6.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.TotalPrice.DefaultCellStyle = dataGridViewCellStyle6;
            this.TotalPrice.HeaderText = "مبلغ";
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.ReadOnly = true;
            // 
            // Print
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Print.DefaultCellStyle = dataGridViewCellStyle7;
            this.Print.FillWeight = 50F;
            this.Print.HeaderText = "چاپ";
            this.Print.Name = "Print";
            this.Print.ReadOnly = true;
            // 
            // PurchaseListID
            // 
            this.PurchaseListID.HeaderText = "PurchaseListID";
            this.PurchaseListID.Name = "PurchaseListID";
            this.PurchaseListID.ReadOnly = true;
            this.PurchaseListID.Visible = false;
            // 
            // TankhahID
            // 
            this.TankhahID.HeaderText = "TankhahID";
            this.TankhahID.Name = "TankhahID";
            this.TankhahID.ReadOnly = true;
            this.TankhahID.Visible = false;
            // 
            // LblTankhahName
            // 
            this.LblTankhahName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblTankhahName.AutoSize = true;
            this.LblTankhahName.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.LblTankhahName.Location = new System.Drawing.Point(690, 69);
            this.LblTankhahName.Name = "LblTankhahName";
            this.LblTankhahName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LblTankhahName.Size = new System.Drawing.Size(67, 32);
            this.LblTankhahName.TabIndex = 71;
            this.LblTankhahName.Text = "تنخواه :";
            // 
            // CmbTankhah
            // 
            this.CmbTankhah.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.CmbTankhah.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CmbTankhah.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbTankhah.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.CmbTankhah.FormattingEnabled = true;
            this.CmbTankhah.Items.AddRange(new object[] {
            "همه"});
            this.CmbTankhah.Location = new System.Drawing.Point(484, 64);
            this.CmbTankhah.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CmbTankhah.Name = "CmbTankhah";
            this.CmbTankhah.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CmbTankhah.Size = new System.Drawing.Size(201, 40);
            this.CmbTankhah.TabIndex = 70;
            this.CmbTankhah.SelectedIndexChanged += new System.EventHandler(this.CmbTankhahs_SelectedIndexChanged);
            // 
            // BgwTankhahsP
            // 
            this.BgwTankhahsP.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Bgw_Dowork);
            this.BgwTankhahsP.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.Bgw_completed);
            // 
            // Print_purchase
            // 
            this.Print_purchase.EngineVersion = Stimulsoft.Report.Engine.StiEngineVersion.EngineV2;
            this.Print_purchase.ReferencedAssemblies = new string[] {
        "System.Dll",
        "System.Drawing.Dll",
        "System.Windows.Forms.Dll",
        "System.Data.Dll",
        "System.Xml.Dll",
        "Stimulsoft.Controls.Dll",
        "Stimulsoft.Base.Dll",
        "Stimulsoft.Report.Dll"};
            this.Print_purchase.ReportAlias = "Report";
            this.Print_purchase.ReportGuid = "5652133e964b4c2ea7d3e690d81a0b4b";
            this.Print_purchase.ReportName = "Report";
            this.Print_purchase.ReportSource = resources.GetString("Print_purchase.ReportSource");
            this.Print_purchase.ReportUnit = Stimulsoft.Report.StiReportUnitType.Centimeters;
            this.Print_purchase.ScriptLanguage = Stimulsoft.Report.StiReportLanguageType.CSharp;
            this.Print_purchase.UseProgressInThread = false;
            // 
            // Form_TankhahPurchaseLists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(769, 575);
            this.Controls.Add(this.radGroupBox1);
            this.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_TankhahPurchaseLists";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.FormTankhahP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radButton3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnRemove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridListPurchace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.Themes.AquaTheme aquaTheme1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadButton radButton3;
        private Telerik.WinControls.UI.RadButton BtnRemove;
        private System.Windows.Forms.DataGridView GridListPurchace;
        private System.Windows.Forms.Label LblTankhahName;
        public System.Windows.Forms.ComboBox CmbTankhah;
        private System.ComponentModel.BackgroundWorker BgwTankhahsP;
        private System.Windows.Forms.Label LblNoPurchaseList;
        private Stimulsoft.Report.StiReport Print_purchase;
        private System.Windows.Forms.DataGridViewTextBoxColumn TankhahName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseListNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Print;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseListID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TankhahID;
    }
}
