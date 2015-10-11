using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using FarsiCalendarComponent;
using Telerik.WinControls.Themes;
using Telerik.WinControls.UI;

namespace EsfahanGhos
{
    partial class Form_PayToPeople2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_PayToPeople2));
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewHyperlinkColumn gridViewHyperlinkColumn1 = new Telerik.WinControls.UI.GridViewHyperlinkColumn();
            Telerik.WinControls.UI.GridViewHyperlinkColumn gridViewHyperlinkColumn2 = new Telerik.WinControls.UI.GridViewHyperlinkColumn();
            Telerik.WinControls.UI.GridViewHyperlinkColumn gridViewHyperlinkColumn3 = new Telerik.WinControls.UI.GridViewHyperlinkColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_Exit = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Btn_Search = new System.Windows.Forms.Button();
            this.Btn_Print = new System.Windows.Forms.Button();
            this.Btn_Chart = new System.Windows.Forms.Button();
            this.Txt_Name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ToDate = new FarsiCalendarComponent.FarsiDatePicker();
            this.FromDate = new FarsiCalendarComponent.FarsiDatePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Grid = new Telerik.WinControls.UI.RadGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.telerikMetroBlueTheme1 = new Telerik.WinControls.Themes.TelerikMetroBlueTheme();
            this.BGW = new System.ComponentModel.BackgroundWorker();
            this.stiReport1 = new Stimulsoft.Report.StiReport();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid.MasterTemplate)).BeginInit();
            this.Grid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(16, 567);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1052, 20);
            this.panel4.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 29);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(16, 558);
            this.panel3.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1068, 29);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(16, 558);
            this.panel2.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.Btn_Exit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1084, 29);
            this.panel1.TabIndex = 5;
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Btn_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Btn_Exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.Btn_Exit.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.Btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Exit.ImageKey = "Sign-Error-icon.png";
            this.Btn_Exit.ImageList = this.imageList1;
            this.Btn_Exit.Location = new System.Drawing.Point(1033, 0);
            this.Btn_Exit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.Size = new System.Drawing.Size(51, 29);
            this.Btn_Exit.TabIndex = 1;
            this.Btn_Exit.UseVisualStyleBackColor = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Sign-Error-icon.png");
            this.imageList1.Images.SetKeyName(1, "Actions-list-add-icon.png");
            this.imageList1.Images.SetKeyName(2, "Iconshow-Hardware-Printer.ico");
            this.imageList1.Images.SetKeyName(3, "Actions-list-add-user-icon.png");
            this.imageList1.Images.SetKeyName(4, "bigstock-magnifying-glass-as-search-ico-15600446.jpg");
            this.imageList1.Images.SetKeyName(5, "Aha-Soft-Large-Seo-SEO.ico");
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(16, 29);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.Btn_Search);
            this.splitContainer1.Panel1.Controls.Add(this.Btn_Print);
            this.splitContainer1.Panel1.Controls.Add(this.Btn_Chart);
            this.splitContainer1.Panel1.Controls.Add(this.Txt_Name);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.ToDate);
            this.splitContainer1.Panel1.Controls.Add(this.FromDate);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.Grid);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.Size = new System.Drawing.Size(1052, 538);
            this.splitContainer1.SplitterDistance = 245;
            this.splitContainer1.TabIndex = 9;
            // 
            // Btn_Search
            // 
            this.Btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Search.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Search.ImageKey = "bigstock-magnifying-glass-as-search-ico-15600446.jpg";
            this.Btn_Search.ImageList = this.imageList1;
            this.Btn_Search.Location = new System.Drawing.Point(35, 277);
            this.Btn_Search.Name = "Btn_Search";
            this.Btn_Search.Size = new System.Drawing.Size(172, 42);
            this.Btn_Search.TabIndex = 10;
            this.Btn_Search.Text = "جستجو";
            this.Btn_Search.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Search.UseVisualStyleBackColor = true;
            this.Btn_Search.Click += new System.EventHandler(this.Btn_Search_Click);
            // 
            // Btn_Print
            // 
            this.Btn_Print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Print.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Print.ImageKey = "Iconshow-Hardware-Printer.ico";
            this.Btn_Print.ImageList = this.imageList1;
            this.Btn_Print.Location = new System.Drawing.Point(35, 373);
            this.Btn_Print.Name = "Btn_Print";
            this.Btn_Print.Size = new System.Drawing.Size(172, 42);
            this.Btn_Print.TabIndex = 9;
            this.Btn_Print.Text = "چاپ گزارش";
            this.Btn_Print.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Print.UseVisualStyleBackColor = true;
            this.Btn_Print.Click += new System.EventHandler(this.Btn_Print_Click);
            // 
            // Btn_Chart
            // 
            this.Btn_Chart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Chart.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Chart.ImageKey = "Aha-Soft-Large-Seo-SEO.ico";
            this.Btn_Chart.ImageList = this.imageList1;
            this.Btn_Chart.Location = new System.Drawing.Point(35, 325);
            this.Btn_Chart.Name = "Btn_Chart";
            this.Btn_Chart.Size = new System.Drawing.Size(172, 42);
            this.Btn_Chart.TabIndex = 8;
            this.Btn_Chart.Text = "چارت";
            this.Btn_Chart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Chart.UseVisualStyleBackColor = true;
            this.Btn_Chart.Click += new System.EventHandler(this.Btn_Chart_Click);
            // 
            // Txt_Name
            // 
            this.Txt_Name.Location = new System.Drawing.Point(12, 37);
            this.Txt_Name.Multiline = true;
            this.Txt_Name.Name = "Txt_Name";
            this.Txt_Name.ReadOnly = true;
            this.Txt_Name.Size = new System.Drawing.Size(223, 34);
            this.Txt_Name.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "آقا / خانوم";
            // 
            // ToDate
            // 
            this.ToDate.GeoDate = new System.DateTime(2015, 3, 8, 0, 0, 0, 0);
            this.ToDate.Location = new System.Drawing.Point(35, 216);
            this.ToDate.Margin = new System.Windows.Forms.Padding(9, 13, 9, 13);
            this.ToDate.MaximumSize = new System.Drawing.Size(3000, 85);
            this.ToDate.Name = "ToDate";
            this.ToDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ToDate.Size = new System.Drawing.Size(172, 42);
            this.ToDate.TabIndex = 5;
            // 
            // FromDate
            // 
            this.FromDate.GeoDate = new System.DateTime(2015, 3, 8, 0, 0, 0, 0);
            this.FromDate.Location = new System.Drawing.Point(35, 126);
            this.FromDate.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.FromDate.MaximumSize = new System.Drawing.Size(2000, 47);
            this.FromDate.Name = "FromDate";
            this.FromDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.FromDate.Size = new System.Drawing.Size(172, 41);
            this.FromDate.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "تا تاریخ :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "از تاریخ :";
            // 
            // Grid
            // 
            this.Grid.Controls.Add(this.pictureBox1);
            this.Grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grid.Font = new System.Drawing.Font("B Nazanin", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Grid.Location = new System.Drawing.Point(0, 0);
            // 
            // Grid
            // 
            this.Grid.MasterTemplate.AllowAddNewRow = false;
            this.Grid.MasterTemplate.AllowColumnReorder = false;
            this.Grid.MasterTemplate.AllowDragToGroup = false;
            this.Grid.MasterTemplate.AllowSearchRow = true;
            this.Grid.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.FieldName = "Cost";
            gridViewTextBoxColumn1.HeaderText = "مبلغ";
            gridViewTextBoxColumn1.Name = "column1";
            gridViewTextBoxColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn1.Width = 217;
            gridViewTextBoxColumn2.FieldName = "Date";
            gridViewTextBoxColumn2.HeaderText = "تاریخ";
            gridViewTextBoxColumn2.Name = "column2";
            gridViewTextBoxColumn2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn2.Width = 217;
            gridViewTextBoxColumn3.FieldName = "Reason";
            gridViewTextBoxColumn3.HeaderText = "بابت";
            gridViewTextBoxColumn3.Name = "column3";
            gridViewTextBoxColumn3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn3.Width = 217;
            gridViewHyperlinkColumn1.FormatString = "ویرایش";
            gridViewHyperlinkColumn1.HeaderImage = ((System.Drawing.Image)(resources.GetObject("gridViewHyperlinkColumn1.HeaderImage")));
            gridViewHyperlinkColumn1.HeaderText = "";
            gridViewHyperlinkColumn1.ImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            gridViewHyperlinkColumn1.Name = "Edit";
            gridViewHyperlinkColumn1.Width = 43;
            gridViewHyperlinkColumn2.FormatString = "حذف";
            gridViewHyperlinkColumn2.HeaderImage = ((System.Drawing.Image)(resources.GetObject("gridViewHyperlinkColumn2.HeaderImage")));
            gridViewHyperlinkColumn2.HeaderText = "";
            gridViewHyperlinkColumn2.ImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            gridViewHyperlinkColumn2.Name = "Delete";
            gridViewHyperlinkColumn2.Width = 46;
            gridViewHyperlinkColumn3.FormatString = "اطلاعات بیشتر";
            gridViewHyperlinkColumn3.HeaderImage = ((System.Drawing.Image)(resources.GetObject("gridViewHyperlinkColumn3.HeaderImage")));
            gridViewHyperlinkColumn3.HeaderText = "";
            gridViewHyperlinkColumn3.ImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            gridViewHyperlinkColumn3.Name = "MoreInfo";
            gridViewHyperlinkColumn3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewHyperlinkColumn3.Width = 48;
            gridViewTextBoxColumn4.FieldName = "Id";
            gridViewTextBoxColumn4.HeaderText = "ID";
            gridViewTextBoxColumn4.IsVisible = false;
            gridViewTextBoxColumn4.Name = "Id";
            gridViewTextBoxColumn4.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn4.Width = 198;
            this.Grid.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewHyperlinkColumn1,
            gridViewHyperlinkColumn2,
            gridViewHyperlinkColumn3,
            gridViewTextBoxColumn4});
            this.Grid.MasterTemplate.EnablePaging = true;
            this.Grid.Name = "Grid";
            this.Grid.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.Grid.ReadOnly = true;
            this.Grid.Size = new System.Drawing.Size(803, 538);
            this.Grid.TabIndex = 0;
            this.Grid.Text = "radGridView1";
            this.Grid.ThemeName = "TelerikMetroBlue";
            this.Grid.CellClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.Grid_CellClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(335, 216);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(99, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // BGW
            // 
            this.BGW.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BGW_DoWork);
            this.BGW.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BGW_RunWorkerCompleted);
            // 
            // stiReport1
            // 
            this.stiReport1.EngineVersion = Stimulsoft.Report.Engine.StiEngineVersion.EngineV2;
            this.stiReport1.ReferencedAssemblies = new string[] {
        "System.Dll",
        "System.Drawing.Dll",
        "System.Windows.Forms.Dll",
        "System.Data.Dll",
        "System.Xml.Dll",
        "Stimulsoft.Controls.Dll",
        "Stimulsoft.Base.Dll",
        "Stimulsoft.Report.Dll"};
            this.stiReport1.ReportAlias = "Report";
            this.stiReport1.ReportGuid = "dd1add8d3b574f7d9f6a94e03e1c9522";
            this.stiReport1.ReportName = "Report";
            this.stiReport1.ReportSource = resources.GetString("stiReport1.ReportSource");
            this.stiReport1.ReportUnit = Stimulsoft.Report.StiReportUnitType.Inches;
            this.stiReport1.ScriptLanguage = Stimulsoft.Report.StiReportLanguageType.CSharp;
            this.stiReport1.UseProgressInThread = false;
            // 
            // Form_PayToPeople2
            // 
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.Btn_Exit;
            this.ClientSize = new System.Drawing.Size(1084, 587);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("B Nazanin", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form_PayToPeople2";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form_PayToPeople2_Load);
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grid.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.Grid.ResumeLayout(false);
            this.Grid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel4;
        private Panel panel3;
        private Panel panel2;
        private Panel panel1;
        private Button Btn_Exit;
        private ImageList imageList1;
        private SplitContainer splitContainer1;
        private Label label2;
        private Label label1;
        private RadGridView Grid;
        private TelerikMetroBlueTheme telerikMetroBlueTheme1;
        private Button Btn_Chart;
        private TextBox Txt_Name;
        private Label label3;
        private FarsiDatePicker ToDate;
        private FarsiDatePicker FromDate;
        private Button Btn_Search;
        private Button Btn_Print;
        private BackgroundWorker BGW;
        private PictureBox pictureBox1;
        private Stimulsoft.Report.StiReport stiReport1;
    }
}