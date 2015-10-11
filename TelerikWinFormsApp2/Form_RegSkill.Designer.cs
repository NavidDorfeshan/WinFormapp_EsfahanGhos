namespace EsfahanGhos
{
    partial class Form_RegSkill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_RegSkill));
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Btn_Delete = new Telerik.WinControls.UI.RadButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Btn_Edit = new Telerik.WinControls.UI.RadButton();
            this.Btn_Reg = new Telerik.WinControls.UI.RadButton();
            this.Btn_Close = new Telerik.WinControls.UI.RadButton();
            this.Txt_SkillName = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.GridSkill = new Telerik.WinControls.UI.RadGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.aquaTheme1 = new Telerik.WinControls.Themes.AquaTheme();
            this.office2007SilverTheme1 = new Telerik.WinControls.Themes.Office2007SilverTheme();
            this.BGW = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Delete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Reg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_SkillName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridSkill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridSkill.MasterTemplate)).BeginInit();
            this.GridSkill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.groupBox1);
            this.radGroupBox1.Controls.Add(this.GridSkill);
            this.radGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGroupBox1.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.radGroupBox1.GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office;
            this.radGroupBox1.HeaderText = "ثبت حرفه";
            this.radGroupBox1.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.radGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(715, 465);
            this.radGroupBox1.TabIndex = 1;
            this.radGroupBox1.Text = "ثبت حرفه";
            this.radGroupBox1.ThemeName = "Aqua";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Controls.Add(this.Txt_SkillName);
            this.groupBox1.Controls.Add(this.radLabel3);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(351, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 223);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.Btn_Delete);
            this.flowLayoutPanel1.Controls.Add(this.Btn_Edit);
            this.flowLayoutPanel1.Controls.Add(this.Btn_Reg);
            this.flowLayoutPanel1.Controls.Add(this.Btn_Close);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 99);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(334, 118);
            this.flowLayoutPanel1.TabIndex = 30;
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.Enabled = false;
            this.Btn_Delete.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.Btn_Delete.ImageAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Delete.ImageKey = "Awicons-Vista-Artistic-Delete.ico";
            this.Btn_Delete.ImageList = this.imageList1;
            this.Btn_Delete.Location = new System.Drawing.Point(3, 3);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(102, 49);
            this.Btn_Delete.TabIndex = 29;
            this.Btn_Delete.Text = "حذف";
            this.Btn_Delete.ThemeName = "Aqua";
            this.Btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Custom-Icon-Design-Pretty-Office-9-Edit-validated.ico");
            this.imageList1.Images.SetKeyName(1, "Awicons-Vista-Artistic-Add.ico");
            this.imageList1.Images.SetKeyName(2, "Awicons-Vista-Artistic-Delete.ico");
            // 
            // Btn_Edit
            // 
            this.Btn_Edit.Enabled = false;
            this.Btn_Edit.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.Btn_Edit.ImageAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Edit.ImageKey = "Custom-Icon-Design-Pretty-Office-9-Edit-validated.ico";
            this.Btn_Edit.ImageList = this.imageList1;
            this.Btn_Edit.Location = new System.Drawing.Point(111, 3);
            this.Btn_Edit.Name = "Btn_Edit";
            this.Btn_Edit.Size = new System.Drawing.Size(102, 49);
            this.Btn_Edit.TabIndex = 28;
            this.Btn_Edit.Text = "ویرایش";
            this.Btn_Edit.ThemeName = "Aqua";
            this.Btn_Edit.Click += new System.EventHandler(this.Btn_Edit_Click);
            // 
            // Btn_Reg
            // 
            this.Btn_Reg.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.Btn_Reg.ImageAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Reg.ImageKey = "Awicons-Vista-Artistic-Add.ico";
            this.Btn_Reg.ImageList = this.imageList1;
            this.Btn_Reg.Location = new System.Drawing.Point(219, 3);
            this.Btn_Reg.Name = "Btn_Reg";
            this.Btn_Reg.Size = new System.Drawing.Size(102, 49);
            this.Btn_Reg.TabIndex = 27;
            this.Btn_Reg.Text = "ثبت";
            this.Btn_Reg.ThemeName = "Aqua";
            this.Btn_Reg.Click += new System.EventHandler(this.Btn_Reg_Click);
            // 
            // Btn_Close
            // 
            this.Btn_Close.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.Btn_Close.ImageAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Close.ImageKey = "arrow_left.png";
            this.Btn_Close.Location = new System.Drawing.Point(3, 58);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(318, 49);
            this.Btn_Close.TabIndex = 30;
            this.Btn_Close.Text = "بازگشت";
            this.Btn_Close.ThemeName = "Aqua";
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // Txt_SkillName
            // 
            this.Txt_SkillName.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.Txt_SkillName.Location = new System.Drawing.Point(74, 38);
            this.Txt_SkillName.Name = "Txt_SkillName";
            this.Txt_SkillName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Txt_SkillName.Size = new System.Drawing.Size(145, 38);
            this.Txt_SkillName.TabIndex = 13;
            this.Txt_SkillName.ThemeName = "Aqua";
            this.Txt_SkillName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_SkillName_KeyPress);
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.radLabel3.Location = new System.Drawing.Point(225, 38);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radLabel3.Size = new System.Drawing.Size(78, 36);
            this.radLabel3.TabIndex = 14;
            this.radLabel3.Text = "نام حرفه :";
            this.radLabel3.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.radLabel3.ThemeName = "Aqua";
            // 
            // GridSkill
            // 
            this.GridSkill.Controls.Add(this.pictureBox1);
            this.GridSkill.Font = new System.Drawing.Font("B Nazanin", 12F);
            this.GridSkill.Location = new System.Drawing.Point(12, 48);
            // 
            // GridSkill
            // 
            this.GridSkill.MasterTemplate.AllowAddNewRow = false;
            this.GridSkill.MasterTemplate.AllowColumnReorder = false;
            this.GridSkill.MasterTemplate.AllowDragToGroup = false;
            this.GridSkill.MasterTemplate.AllowSearchRow = true;
            this.GridSkill.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.FieldName = "SkillID";
            gridViewTextBoxColumn1.HeaderText = "کد حرفه";
            gridViewTextBoxColumn1.Name = "SkillID";
            gridViewTextBoxColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn1.Width = 109;
            gridViewTextBoxColumn2.FieldName = "SkillName";
            gridViewTextBoxColumn2.HeaderText = "نام حرفه";
            gridViewTextBoxColumn2.Name = "SkillName";
            gridViewTextBoxColumn2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn2.Width = 205;
            this.GridSkill.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2});
            this.GridSkill.Name = "GridSkill";
            this.GridSkill.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.GridSkill.ReadOnly = true;
            this.GridSkill.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GridSkill.Size = new System.Drawing.Size(333, 402);
            this.GridSkill.TabIndex = 1;
            this.GridSkill.Text = "radGridView1";
            this.GridSkill.ThemeName = "Office2007Silver";
            this.GridSkill.CellClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.GridSkill_CellClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(113, 157);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // BGW
            // 
            this.BGW.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BGW_DoWork);
            this.BGW.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BGW_RunWorkerCompleted);
            // 
            // Form_RegSkill
            // 
            this.AcceptButton = this.Btn_Reg;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 465);
            this.Controls.Add(this.radGroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_RegSkill";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_RegSkill1";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.Form_RegSkill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Delete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Reg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_SkillName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridSkill.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridSkill)).EndInit();
            this.GridSkill.ResumeLayout(false);
            this.GridSkill.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Telerik.WinControls.UI.RadButton Btn_Delete;
        private Telerik.WinControls.UI.RadButton Btn_Edit;
        private Telerik.WinControls.UI.RadButton Btn_Reg;
        private Telerik.WinControls.UI.RadButton Btn_Close;
        private Telerik.WinControls.UI.RadTextBox Txt_SkillName;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadGridView GridSkill;
        private Telerik.WinControls.Themes.AquaTheme aquaTheme1;
        private Telerik.WinControls.Themes.Office2007SilverTheme office2007SilverTheme1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ImageList imageList1;
        private System.ComponentModel.BackgroundWorker BGW;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
