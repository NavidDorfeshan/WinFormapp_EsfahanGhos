namespace EsfahanGhos
{
    partial class FormProjectSPerson
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
            Telerik.WinControls.UI.GridViewHyperlinkColumn gridViewHyperlinkColumn1 = new Telerik.WinControls.UI.GridViewHyperlinkColumn();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProjectSPerson));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Grid_Person = new Telerik.WinControls.UI.RadGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Combo_Person = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Combo_Project = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Btn_reg = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Btn_Back = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.BGW = new System.ComponentModel.BackgroundWorker();
            this.office2007SilverTheme1 = new Telerik.WinControls.Themes.Office2007SilverTheme();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Person)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Person.MasterTemplate)).BeginInit();
            this.Grid_Person.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.Grid_Person);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.flowLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(1215, 660);
            this.splitContainer1.SplitterDistance = 972;
            this.splitContainer1.TabIndex = 0;
            // 
            // Grid_Person
            // 
            this.Grid_Person.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Grid_Person.AutoScroll = true;
            this.Grid_Person.Controls.Add(this.pictureBox1);
            this.Grid_Person.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grid_Person.Font = new System.Drawing.Font("B Nazanin", 10.2F, System.Drawing.FontStyle.Bold);
            this.Grid_Person.GroupExpandAnimationType = Telerik.WinControls.UI.GridExpandAnimationType.Slide;
            this.Grid_Person.Location = new System.Drawing.Point(0, 53);
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
            gridViewTextBoxColumn1.Width = 293;
            gridViewTextBoxColumn2.FieldName = "EmployeeNationalCode";
            gridViewTextBoxColumn2.HeaderText = "کد ملی";
            gridViewTextBoxColumn2.Name = "column2";
            gridViewTextBoxColumn2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn2.Width = 293;
            gridViewTextBoxColumn3.FieldName = "CellPhone";
            gridViewTextBoxColumn3.HeaderText = "شماره تلفن همراه";
            gridViewTextBoxColumn3.Name = "column3";
            gridViewTextBoxColumn3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn3.Width = 293;
            gridViewTextBoxColumn4.FieldName = "EmployeeID";
            gridViewTextBoxColumn4.HeaderText = "column6";
            gridViewTextBoxColumn4.IsVisible = false;
            gridViewTextBoxColumn4.Name = "id";
            gridViewTextBoxColumn4.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn4.Width = 46;
            gridViewHyperlinkColumn1.FormatString = "حذف";
            gridViewHyperlinkColumn1.HeaderText = "حذف";
            gridViewHyperlinkColumn1.Name = "Del";
            gridViewHyperlinkColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewHyperlinkColumn1.Width = 76;
            this.Grid_Person.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewHyperlinkColumn1});
            this.Grid_Person.MasterTemplate.EnablePaging = true;
            this.Grid_Person.MasterTemplate.ShowHeaderCellButtons = true;
            this.Grid_Person.Name = "Grid_Person";
            this.Grid_Person.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.Grid_Person.ReadOnly = true;
            this.Grid_Person.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Grid_Person.ShowGroupPanel = false;
            this.Grid_Person.ShowHeaderCellButtons = true;
            this.Grid_Person.Size = new System.Drawing.Size(972, 607);
            this.Grid_Person.TabIndex = 1;
            this.Grid_Person.ThemeName = "Office2007Silver";
            this.Grid_Person.CellClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.Grid_Person_CellClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(400, 192);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Combo_Person);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Combo_Project);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("B Nazanin", 10.8F, System.Drawing.FontStyle.Bold);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel1.Size = new System.Drawing.Size(972, 53);
            this.panel1.TabIndex = 0;
            // 
            // Combo_Person
            // 
            this.Combo_Person.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Combo_Person.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.Combo_Person.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Combo_Person.BackColor = System.Drawing.Color.Snow;
            this.Combo_Person.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Combo_Person.Enabled = false;
            this.Combo_Person.FormattingEnabled = true;
            this.Combo_Person.Location = new System.Drawing.Point(218, 8);
            this.Combo_Person.Name = "Combo_Person";
            this.Combo_Person.Size = new System.Drawing.Size(239, 37);
            this.Combo_Person.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(463, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "نام و نام خانوادگی:";
            // 
            // Combo_Project
            // 
            this.Combo_Project.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Combo_Project.BackColor = System.Drawing.Color.Snow;
            this.Combo_Project.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Combo_Project.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Combo_Project.FormattingEnabled = true;
            this.Combo_Project.Location = new System.Drawing.Point(657, 6);
            this.Combo_Project.Name = "Combo_Project";
            this.Combo_Project.Size = new System.Drawing.Size(239, 37);
            this.Combo_Project.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(902, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "پروژه :";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.Btn_reg);
            this.flowLayoutPanel1.Controls.Add(this.Btn_Back);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(239, 660);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // Btn_reg
            // 
            this.Btn_reg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_reg.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Btn_reg.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.Btn_reg.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.Btn_reg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_reg.Font = new System.Drawing.Font("B Nazanin", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Btn_reg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_reg.ImageKey = "add-icon.png";
            this.Btn_reg.ImageList = this.imageList1;
            this.Btn_reg.Location = new System.Drawing.Point(3, 3);
            this.Btn_reg.Name = "Btn_reg";
            this.Btn_reg.Size = new System.Drawing.Size(233, 62);
            this.Btn_reg.TabIndex = 0;
            this.Btn_reg.Text = "ثبت";
            this.Btn_reg.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_reg.UseVisualStyleBackColor = true;
            this.Btn_reg.Click += new System.EventHandler(this.Btn_reg_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Custom-Icon-Design-Pretty-Office-9-Edit-validated.ico");
            this.imageList1.Images.SetKeyName(1, "Semlabs-Web-Blog-Arrow-return-down-right.ico");
            this.imageList1.Images.SetKeyName(2, "add-icon.png");
            this.imageList1.Images.SetKeyName(3, "Oxygen-Icons.org-Oxygen-Actions-edit-delete.ico");
            // 
            // Btn_Back
            // 
            this.Btn_Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Back.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Btn_Back.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Btn_Back.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.Btn_Back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.Btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Back.Font = new System.Drawing.Font("B Nazanin", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Btn_Back.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Back.ImageKey = "Semlabs-Web-Blog-Arrow-return-down-right.ico";
            this.Btn_Back.ImageList = this.imageList1;
            this.Btn_Back.Location = new System.Drawing.Point(3, 71);
            this.Btn_Back.Name = "Btn_Back";
            this.Btn_Back.Size = new System.Drawing.Size(233, 62);
            this.Btn_Back.TabIndex = 1;
            this.Btn_Back.Text = "بازگشت";
            this.Btn_Back.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Back.UseVisualStyleBackColor = true;
            this.Btn_Back.Click += new System.EventHandler(this.Btn_Back_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 8000;
            this.toolTip1.BackColor = System.Drawing.Color.Linen;
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.ReshowDelay = 100;
            // 
            // BGW
            // 
            this.BGW.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BGW_DoWork);
            this.BGW.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BGW_RunWorkerCompleted);
            // 
            // FormProjectSPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.Btn_Back;
            this.ClientSize = new System.Drawing.Size(1215, 660);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("B Nazanin", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormProjectSPerson";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form_Project_sPerson_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Person.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Person)).EndInit();
            this.Grid_Person.ResumeLayout(false);
            this.Grid_Person.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.ComponentModel.BackgroundWorker BGW;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button Btn_reg;
        private System.Windows.Forms.Button Btn_Back;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox Combo_Project;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Combo_Person;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Telerik.WinControls.UI.RadGridView Grid_Person;
        private Telerik.WinControls.Themes.Office2007SilverTheme office2007SilverTheme1;
    }
}