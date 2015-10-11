namespace EsfahanGhos
{
    partial class Form_RegContractor
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
            Telerik.WinControls.UI.GridViewHyperlinkColumn gridViewHyperlinkColumn1 = new Telerik.WinControls.UI.GridViewHyperlinkColumn();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_RegContractor));
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.GridContractor = new Telerik.WinControls.UI.RadGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.radGroupBox2 = new Telerik.WinControls.UI.RadGroupBox();
            this.Btn_AddTel = new Telerik.WinControls.UI.RadButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Button_RegSkill = new Telerik.WinControls.UI.RadButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Btn_Register = new Telerik.WinControls.UI.RadButton();
            this.Btn_Edit = new Telerik.WinControls.UI.RadButton();
            this.Btn_Close = new Telerik.WinControls.UI.RadButton();
            this.Btn_DelTel = new Telerik.WinControls.UI.RadButton();
            this.listBox_Tels = new System.Windows.Forms.ListBox();
            this.Txt_Tel = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.Btn_AddSkill = new Telerik.WinControls.UI.RadButton();
            this.Btn_DelSkill = new Telerik.WinControls.UI.RadButton();
            this.listBox_Skill = new System.Windows.Forms.ListBox();
            this.ComboSkills = new Telerik.WinControls.UI.RadDropDownList();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.Txt_FName = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.aquaTheme1 = new Telerik.WinControls.Themes.AquaTheme();
            this.office2007SilverTheme1 = new Telerik.WinControls.Themes.Office2007SilverTheme();
            this.BGW = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridContractor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridContractor.MasterTemplate)).BeginInit();
            this.GridContractor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).BeginInit();
            this.radGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_AddTel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_RegSkill)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Register)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_DelTel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Tel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_AddSkill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_DelSkill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboSkills)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_FName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.GridContractor);
            this.radGroupBox1.Controls.Add(this.radGroupBox2);
            this.radGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGroupBox1.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.radGroupBox1.GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office;
            this.radGroupBox1.HeaderImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.radGroupBox1.HeaderText = "ثبت پیمانکار";
            this.radGroupBox1.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.radGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(843, 596);
            this.radGroupBox1.TabIndex = 0;
            this.radGroupBox1.Text = "ثبت پیمانکار";
            this.radGroupBox1.ThemeName = "Aqua";
            // 
            // GridContractor
            // 
            this.GridContractor.Controls.Add(this.pictureBox1);
            this.GridContractor.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.GridContractor.Location = new System.Drawing.Point(12, 45);
            // 
            // GridContractor
            // 
            this.GridContractor.MasterTemplate.AllowAddNewRow = false;
            this.GridContractor.MasterTemplate.AllowColumnReorder = false;
            this.GridContractor.MasterTemplate.AllowDragToGroup = false;
            this.GridContractor.MasterTemplate.AllowSearchRow = true;
            this.GridContractor.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.FieldName = "ContractorID";
            gridViewTextBoxColumn1.HeaderText = "کد پیمانکار";
            gridViewTextBoxColumn1.Name = "ContractorID";
            gridViewTextBoxColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn1.Width = 109;
            gridViewTextBoxColumn2.FieldName = "CName";
            gridViewTextBoxColumn2.HeaderText = "نام و نام خانوادگی";
            gridViewTextBoxColumn2.Name = "CName";
            gridViewTextBoxColumn2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn2.Width = 204;
            gridViewHyperlinkColumn1.FormatString = "پاک کردن";
            gridViewHyperlinkColumn1.HeaderText = "حذف";
            gridViewHyperlinkColumn1.Name = "Del";
            gridViewHyperlinkColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewHyperlinkColumn1.Width = 136;
            this.GridContractor.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewHyperlinkColumn1});
            this.GridContractor.Name = "GridContractor";
            this.GridContractor.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.GridContractor.ReadOnly = true;
            this.GridContractor.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GridContractor.Size = new System.Drawing.Size(467, 539);
            this.GridContractor.TabIndex = 24;
            this.GridContractor.Text = "radGridView1";
            this.GridContractor.ThemeName = "Office2007Silver";
            this.GridContractor.CellClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.GridContractor_CellClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(182, 215);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // radGroupBox2
            // 
            this.radGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radGroupBox2.Controls.Add(this.Btn_AddTel);
            this.radGroupBox2.Controls.Add(this.Button_RegSkill);
            this.radGroupBox2.Controls.Add(this.flowLayoutPanel1);
            this.radGroupBox2.Controls.Add(this.Btn_DelTel);
            this.radGroupBox2.Controls.Add(this.listBox_Tels);
            this.radGroupBox2.Controls.Add(this.Txt_Tel);
            this.radGroupBox2.Controls.Add(this.radLabel3);
            this.radGroupBox2.Controls.Add(this.Btn_AddSkill);
            this.radGroupBox2.Controls.Add(this.Btn_DelSkill);
            this.radGroupBox2.Controls.Add(this.listBox_Skill);
            this.radGroupBox2.Controls.Add(this.ComboSkills);
            this.radGroupBox2.Controls.Add(this.radLabel2);
            this.radGroupBox2.Controls.Add(this.Txt_FName);
            this.radGroupBox2.Controls.Add(this.radLabel1);
            this.radGroupBox2.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.radGroupBox2.HeaderText = "";
            this.radGroupBox2.Location = new System.Drawing.Point(489, 45);
            this.radGroupBox2.Name = "radGroupBox2";
            this.radGroupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radGroupBox2.Size = new System.Drawing.Size(345, 539);
            this.radGroupBox2.TabIndex = 0;
            this.radGroupBox2.ThemeName = "Aqua";
            // 
            // Btn_AddTel
            // 
            this.Btn_AddTel.Font = new System.Drawing.Font("Adobe Arabic", 13.8F, System.Drawing.FontStyle.Bold);
            this.Btn_AddTel.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn_AddTel.ImageKey = "Awicons-Vista-Artistic-Add.ico";
            this.Btn_AddTel.ImageList = this.imageList1;
            this.Btn_AddTel.Location = new System.Drawing.Point(197, 276);
            this.Btn_AddTel.Name = "Btn_AddTel";
            this.Btn_AddTel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Btn_AddTel.Size = new System.Drawing.Size(44, 38);
            this.Btn_AddTel.TabIndex = 25;
            this.Btn_AddTel.ThemeName = "Aqua";
            this.Btn_AddTel.Click += new System.EventHandler(this.Btn_AddTel_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Awicons-Vista-Artistic-Add.ico");
            this.imageList1.Images.SetKeyName(1, "Awicons-Vista-Artistic-Delete.ico");
            this.imageList1.Images.SetKeyName(2, "Custom-Icon-Design-Pretty-Office-9-Edit-validated.ico");
            // 
            // Button_RegSkill
            // 
            this.Button_RegSkill.Font = new System.Drawing.Font("Adobe Arabic", 13.8F, System.Drawing.FontStyle.Bold);
            this.Button_RegSkill.ImageKey = "add-icon.png";
            this.Button_RegSkill.Location = new System.Drawing.Point(20, 67);
            this.Button_RegSkill.Name = "Button_RegSkill";
            this.Button_RegSkill.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Button_RegSkill.Size = new System.Drawing.Size(44, 38);
            this.Button_RegSkill.TabIndex = 23;
            this.Button_RegSkill.Text = "...";
            this.Button_RegSkill.ThemeName = "Aqua";
            this.Button_RegSkill.Click += new System.EventHandler(this.Button_RegSkill_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.Btn_Register);
            this.flowLayoutPanel1.Controls.Add(this.Btn_Edit);
            this.flowLayoutPanel1.Controls.Add(this.Btn_Close);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(11, 411);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(320, 123);
            this.flowLayoutPanel1.TabIndex = 28;
            // 
            // Btn_Register
            // 
            this.Btn_Register.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.Btn_Register.ImageAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Register.ImageKey = "Awicons-Vista-Artistic-Add.ico";
            this.Btn_Register.ImageList = this.imageList1;
            this.Btn_Register.Location = new System.Drawing.Point(169, 3);
            this.Btn_Register.Name = "Btn_Register";
            this.Btn_Register.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Btn_Register.Size = new System.Drawing.Size(148, 46);
            this.Btn_Register.TabIndex = 0;
            this.Btn_Register.Text = "ثبت";
            this.Btn_Register.ThemeName = "Aqua";
            this.Btn_Register.Click += new System.EventHandler(this.Btn_Register_Click);
            // 
            // Btn_Edit
            // 
            this.Btn_Edit.Enabled = false;
            this.Btn_Edit.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.Btn_Edit.ImageAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Edit.ImageKey = "Custom-Icon-Design-Pretty-Office-9-Edit-validated.ico";
            this.Btn_Edit.ImageList = this.imageList1;
            this.Btn_Edit.Location = new System.Drawing.Point(13, 3);
            this.Btn_Edit.Name = "Btn_Edit";
            this.Btn_Edit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Btn_Edit.Size = new System.Drawing.Size(150, 46);
            this.Btn_Edit.TabIndex = 1;
            this.Btn_Edit.Text = "ویرایش";
            this.Btn_Edit.ThemeName = "Aqua";
            this.Btn_Edit.Click += new System.EventHandler(this.Btn_Edit_Click);
            // 
            // Btn_Close
            // 
            this.Btn_Close.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.Btn_Close.ImageAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Close.ImageKey = "Awicons-Vista-Artistic-Add.ico";
            this.Btn_Close.Location = new System.Drawing.Point(13, 55);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Btn_Close.Size = new System.Drawing.Size(304, 52);
            this.Btn_Close.TabIndex = 2;
            this.Btn_Close.Text = "خروج";
            this.Btn_Close.ThemeName = "Aqua";
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // Btn_DelTel
            // 
            this.Btn_DelTel.Font = new System.Drawing.Font("Adobe Arabic", 13.8F, System.Drawing.FontStyle.Bold);
            this.Btn_DelTel.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn_DelTel.ImageKey = "Awicons-Vista-Artistic-Delete.ico";
            this.Btn_DelTel.ImageList = this.imageList1;
            this.Btn_DelTel.Location = new System.Drawing.Point(197, 320);
            this.Btn_DelTel.Name = "Btn_DelTel";
            this.Btn_DelTel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Btn_DelTel.Size = new System.Drawing.Size(44, 38);
            this.Btn_DelTel.TabIndex = 26;
            this.Btn_DelTel.ThemeName = "Aqua";
            this.Btn_DelTel.Click += new System.EventHandler(this.Btn_DelTel_Click);
            // 
            // listBox_Tels
            // 
            this.listBox_Tels.FormattingEnabled = true;
            this.listBox_Tels.ItemHeight = 16;
            this.listBox_Tels.Location = new System.Drawing.Point(20, 276);
            this.listBox_Tels.Name = "listBox_Tels";
            this.listBox_Tels.Size = new System.Drawing.Size(170, 116);
            this.listBox_Tels.TabIndex = 25;
            // 
            // Txt_Tel
            // 
            this.Txt_Tel.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.Txt_Tel.Location = new System.Drawing.Point(20, 232);
            this.Txt_Tel.Name = "Txt_Tel";
            this.Txt_Tel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Txt_Tel.Size = new System.Drawing.Size(171, 38);
            this.Txt_Tel.TabIndex = 3;
            this.Txt_Tel.ThemeName = "Aqua";
            this.Txt_Tel.TextChanged += new System.EventHandler(this.Txt_Tel_TextChanged);
            this.Txt_Tel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Tel_KeyPress);
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.radLabel3.Location = new System.Drawing.Point(241, 234);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(98, 36);
            this.radLabel3.TabIndex = 22;
            this.radLabel3.Text = "شماره تلفن :";
            this.radLabel3.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.radLabel3.ThemeName = "Aqua";
            // 
            // Btn_AddSkill
            // 
            this.Btn_AddSkill.Font = new System.Drawing.Font("Adobe Arabic", 13.8F, System.Drawing.FontStyle.Bold);
            this.Btn_AddSkill.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn_AddSkill.ImageKey = "Awicons-Vista-Artistic-Add.ico";
            this.Btn_AddSkill.ImageList = this.imageList1;
            this.Btn_AddSkill.Location = new System.Drawing.Point(196, 110);
            this.Btn_AddSkill.Name = "Btn_AddSkill";
            this.Btn_AddSkill.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Btn_AddSkill.Size = new System.Drawing.Size(44, 38);
            this.Btn_AddSkill.TabIndex = 24;
            this.Btn_AddSkill.ThemeName = "Aqua";
            this.Btn_AddSkill.Click += new System.EventHandler(this.Btn_AddSkill_Click);
            // 
            // Btn_DelSkill
            // 
            this.Btn_DelSkill.Font = new System.Drawing.Font("Adobe Arabic", 13.8F, System.Drawing.FontStyle.Bold);
            this.Btn_DelSkill.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn_DelSkill.ImageKey = "Awicons-Vista-Artistic-Delete.ico";
            this.Btn_DelSkill.ImageList = this.imageList1;
            this.Btn_DelSkill.Location = new System.Drawing.Point(196, 154);
            this.Btn_DelSkill.Name = "Btn_DelSkill";
            this.Btn_DelSkill.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Btn_DelSkill.Size = new System.Drawing.Size(44, 38);
            this.Btn_DelSkill.TabIndex = 24;
            this.Btn_DelSkill.ThemeName = "Aqua";
            this.Btn_DelSkill.Click += new System.EventHandler(this.Btn_DelSkill_Click);
            // 
            // listBox_Skill
            // 
            this.listBox_Skill.FormattingEnabled = true;
            this.listBox_Skill.ItemHeight = 16;
            this.listBox_Skill.Location = new System.Drawing.Point(20, 110);
            this.listBox_Skill.Name = "listBox_Skill";
            this.listBox_Skill.Size = new System.Drawing.Size(170, 116);
            this.listBox_Skill.TabIndex = 23;
            // 
            // ComboSkills
            // 
            this.ComboSkills.AllowShowFocusCues = false;
            this.ComboSkills.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.ComboSkills.Location = new System.Drawing.Point(70, 65);
            this.ComboSkills.Name = "ComboSkills";
            this.ComboSkills.Size = new System.Drawing.Size(121, 38);
            this.ComboSkills.TabIndex = 2;
            this.ComboSkills.Text = "لیست حرفه";
            this.ComboSkills.ThemeName = "Aqua";
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.radLabel2.Location = new System.Drawing.Point(284, 65);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(55, 36);
            this.radLabel2.TabIndex = 21;
            this.radLabel2.Text = "حرفه :";
            this.radLabel2.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.radLabel2.ThemeName = "Aqua";
            // 
            // Txt_FName
            // 
            this.Txt_FName.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.Txt_FName.Location = new System.Drawing.Point(20, 21);
            this.Txt_FName.Name = "Txt_FName";
            this.Txt_FName.Size = new System.Drawing.Size(171, 38);
            this.Txt_FName.TabIndex = 0;
            this.Txt_FName.ThemeName = "Aqua";
            this.Txt_FName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_FName_KeyPress);
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.radLabel1.Location = new System.Drawing.Point(196, 23);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(143, 36);
            this.radLabel1.TabIndex = 20;
            this.radLabel1.Text = "نام و نام خانوادگی :";
            this.radLabel1.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.radLabel1.ThemeName = "Aqua";
            // 
            // BGW
            // 
            this.BGW.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BGW_DoWork);
            this.BGW.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BGW_RunWorkerCompleted);
            // 
            // Form_RegContractor
            // 
            this.AcceptButton = this.Btn_Register;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(843, 596);
            this.Controls.Add(this.radGroupBox1);
            this.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_RegContractor";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "";
            this.Load += new System.EventHandler(this.Form_RegContractor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridContractor.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridContractor)).EndInit();
            this.GridContractor.ResumeLayout(false);
            this.GridContractor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).EndInit();
            this.radGroupBox2.ResumeLayout(false);
            this.radGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_AddTel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_RegSkill)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Register)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_DelTel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Tel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_AddSkill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_DelSkill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboSkills)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_FName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox2;
        private Telerik.WinControls.Themes.AquaTheme aquaTheme1;
        private Telerik.WinControls.Themes.Office2007SilverTheme office2007SilverTheme1;
        private System.ComponentModel.BackgroundWorker BGW;
        private Telerik.WinControls.UI.RadDropDownList ComboSkills;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadTextBox Txt_FName;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadButton Button_RegSkill;
        private Telerik.WinControls.UI.RadButton Btn_AddSkill;
        private Telerik.WinControls.UI.RadButton Btn_DelSkill;
        private System.Windows.Forms.ListBox listBox_Skill;
        private System.Windows.Forms.ImageList imageList1;
        private Telerik.WinControls.UI.RadGridView GridContractor;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Telerik.WinControls.UI.RadButton Btn_Register;
        private Telerik.WinControls.UI.RadButton Btn_DelTel;
        private System.Windows.Forms.ListBox listBox_Tels;
        private Telerik.WinControls.UI.RadTextBox Txt_Tel;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadButton Btn_AddTel;
        private Telerik.WinControls.UI.RadButton Btn_Edit;
        private Telerik.WinControls.UI.RadButton Btn_Close;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
