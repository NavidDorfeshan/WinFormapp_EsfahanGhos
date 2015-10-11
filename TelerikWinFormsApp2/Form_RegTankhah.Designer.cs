namespace EsfahanGhos
{
    partial class Form_RegTankhah
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_RegTankhah));
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewHyperlinkColumn gridViewHyperlinkColumn1 = new Telerik.WinControls.UI.GridViewHyperlinkColumn();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.aquaTheme1 = new Telerik.WinControls.Themes.AquaTheme();
            this.office2007SilverTheme1 = new Telerik.WinControls.Themes.Office2007SilverTheme();
            this.BGW = new System.ComponentModel.BackgroundWorker();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.GridTankhah = new Telerik.WinControls.UI.RadGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.radGroupBox2 = new Telerik.WinControls.UI.RadGroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Btn_Register = new Telerik.WinControls.UI.RadButton();
            this.Btn_Edit = new Telerik.WinControls.UI.RadButton();
            this.Btn_Close = new Telerik.WinControls.UI.RadButton();
            this.Btn_AddTel = new Telerik.WinControls.UI.RadButton();
            this.Btn_DelTel = new Telerik.WinControls.UI.RadButton();
            this.listBox_Tels = new System.Windows.Forms.ListBox();
            this.Txt_Tel = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.Txt_FName = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridTankhah)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridTankhah.MasterTemplate)).BeginInit();
            this.GridTankhah.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).BeginInit();
            this.radGroupBox2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Register)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_AddTel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_DelTel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Tel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_FName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Awicons-Vista-Artistic-Add.ico");
            this.imageList1.Images.SetKeyName(1, "Awicons-Vista-Artistic-Delete.ico");
            this.imageList1.Images.SetKeyName(2, "Custom-Icon-Design-Pretty-Office-9-Edit-validated.ico");
            // 
            // BGW
            // 
            this.BGW.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BGW_DoWork);
            this.BGW.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BGW_RunWorkerCompleted);
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.GridTankhah);
            this.radGroupBox1.Controls.Add(this.radGroupBox2);
            this.radGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGroupBox1.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.radGroupBox1.GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office;
            this.radGroupBox1.HeaderImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.radGroupBox1.HeaderText = "ثبت تنخواه";
            this.radGroupBox1.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.radGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(961, 518);
            this.radGroupBox1.TabIndex = 1;
            this.radGroupBox1.Text = "ثبت تنخواه";
            this.radGroupBox1.ThemeName = "Aqua";
            // 
            // GridTankhah
            // 
            this.GridTankhah.Controls.Add(this.pictureBox1);
            this.GridTankhah.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.GridTankhah.Location = new System.Drawing.Point(5, 48);
            // 
            // GridTankhah
            // 
            this.GridTankhah.MasterTemplate.AllowAddNewRow = false;
            this.GridTankhah.MasterTemplate.AllowColumnReorder = false;
            this.GridTankhah.MasterTemplate.AllowDragToGroup = false;
            this.GridTankhah.MasterTemplate.AllowSearchRow = true;
            this.GridTankhah.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.FieldName = "TankhahID";
            gridViewTextBoxColumn1.HeaderText = "کد تنخواه";
            gridViewTextBoxColumn1.Name = "TankhahID";
            gridViewTextBoxColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn1.Width = 108;
            gridViewTextBoxColumn2.FieldName = "TankhahName";
            gridViewTextBoxColumn2.HeaderText = "نام و نام خانوادگی";
            gridViewTextBoxColumn2.Name = "TankhahName";
            gridViewTextBoxColumn2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn2.Width = 203;
            gridViewTextBoxColumn3.HeaderText = "اعتبار";
            gridViewTextBoxColumn3.Name = "CreditCurrent";
            gridViewTextBoxColumn3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn3.Width = 135;
            gridViewHyperlinkColumn1.FormatString = "پاک کردن";
            gridViewHyperlinkColumn1.HeaderText = "حذف";
            gridViewHyperlinkColumn1.Name = "Del";
            gridViewHyperlinkColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewHyperlinkColumn1.Width = 136;
            this.GridTankhah.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewHyperlinkColumn1});
            this.GridTankhah.Name = "GridTankhah";
            this.GridTankhah.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.GridTankhah.ReadOnly = true;
            this.GridTankhah.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GridTankhah.Size = new System.Drawing.Size(599, 458);
            this.GridTankhah.TabIndex = 1;
            this.GridTankhah.Text = "radGridView1";
            this.GridTankhah.ThemeName = "Office2007Silver";
            this.GridTankhah.CellClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.GridTankhah_CellClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(244, 190);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // radGroupBox2
            // 
            this.radGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radGroupBox2.Controls.Add(this.flowLayoutPanel1);
            this.radGroupBox2.Controls.Add(this.Btn_AddTel);
            this.radGroupBox2.Controls.Add(this.Btn_DelTel);
            this.radGroupBox2.Controls.Add(this.listBox_Tels);
            this.radGroupBox2.Controls.Add(this.Txt_Tel);
            this.radGroupBox2.Controls.Add(this.radLabel3);
            this.radGroupBox2.Controls.Add(this.Txt_FName);
            this.radGroupBox2.Controls.Add(this.radLabel1);
            this.radGroupBox2.HeaderText = "";
            this.radGroupBox2.Location = new System.Drawing.Point(609, 48);
            this.radGroupBox2.Name = "radGroupBox2";
            this.radGroupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radGroupBox2.Size = new System.Drawing.Size(347, 458);
            this.radGroupBox2.TabIndex = 0;
            this.radGroupBox2.ThemeName = "Aqua";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.Btn_Register);
            this.flowLayoutPanel1.Controls.Add(this.Btn_Edit);
            this.flowLayoutPanel1.Controls.Add(this.Btn_Close);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(9, 330);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(327, 123);
            this.flowLayoutPanel1.TabIndex = 32;
            // 
            // Btn_Register
            // 
            this.Btn_Register.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.Btn_Register.ImageAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Register.ImageKey = "Awicons-Vista-Artistic-Add.ico";
            this.Btn_Register.ImageList = this.imageList1;
            this.Btn_Register.Location = new System.Drawing.Point(176, 3);
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
            this.Btn_Edit.Location = new System.Drawing.Point(20, 3);
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
            this.Btn_Close.Location = new System.Drawing.Point(20, 55);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Btn_Close.Size = new System.Drawing.Size(304, 52);
            this.Btn_Close.TabIndex = 2;
            this.Btn_Close.Text = "خروج";
            this.Btn_Close.ThemeName = "Aqua";
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // Btn_AddTel
            // 
            this.Btn_AddTel.Font = new System.Drawing.Font("Adobe Arabic", 13.8F, System.Drawing.FontStyle.Bold);
            this.Btn_AddTel.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn_AddTel.ImageKey = "Awicons-Vista-Artistic-Add.ico";
            this.Btn_AddTel.ImageList = this.imageList1;
            this.Btn_AddTel.Location = new System.Drawing.Point(190, 114);
            this.Btn_AddTel.Name = "Btn_AddTel";
            this.Btn_AddTel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Btn_AddTel.Size = new System.Drawing.Size(44, 38);
            this.Btn_AddTel.TabIndex = 29;
            this.Btn_AddTel.ThemeName = "Aqua";
            this.Btn_AddTel.Click += new System.EventHandler(this.Btn_AddTel_Click);
            // 
            // Btn_DelTel
            // 
            this.Btn_DelTel.Font = new System.Drawing.Font("Adobe Arabic", 13.8F, System.Drawing.FontStyle.Bold);
            this.Btn_DelTel.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn_DelTel.ImageKey = "Awicons-Vista-Artistic-Delete.ico";
            this.Btn_DelTel.ImageList = this.imageList1;
            this.Btn_DelTel.Location = new System.Drawing.Point(190, 158);
            this.Btn_DelTel.Name = "Btn_DelTel";
            this.Btn_DelTel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Btn_DelTel.Size = new System.Drawing.Size(44, 38);
            this.Btn_DelTel.TabIndex = 31;
            this.Btn_DelTel.ThemeName = "Aqua";
            this.Btn_DelTel.Click += new System.EventHandler(this.Btn_DelTel_Click);
            // 
            // listBox_Tels
            // 
            this.listBox_Tels.FormattingEnabled = true;
            this.listBox_Tels.ItemHeight = 16;
            this.listBox_Tels.Location = new System.Drawing.Point(13, 114);
            this.listBox_Tels.Name = "listBox_Tels";
            this.listBox_Tels.Size = new System.Drawing.Size(170, 116);
            this.listBox_Tels.TabIndex = 30;
            // 
            // Txt_Tel
            // 
            this.Txt_Tel.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.Txt_Tel.Location = new System.Drawing.Point(13, 70);
            this.Txt_Tel.Name = "Txt_Tel";
            this.Txt_Tel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Txt_Tel.Size = new System.Drawing.Size(171, 38);
            this.Txt_Tel.TabIndex = 27;
            this.Txt_Tel.ThemeName = "Aqua";
            this.Txt_Tel.TextChanged += new System.EventHandler(this.Txt_Tel_TextChanged);
            this.Txt_Tel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Tel_KeyPress);
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.radLabel3.Location = new System.Drawing.Point(234, 72);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(98, 36);
            this.radLabel3.TabIndex = 28;
            this.radLabel3.Text = "شماره تلفن :";
            this.radLabel3.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.radLabel3.ThemeName = "Aqua";
            // 
            // Txt_FName
            // 
            this.Txt_FName.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.Txt_FName.Location = new System.Drawing.Point(13, 19);
            this.Txt_FName.Name = "Txt_FName";
            this.Txt_FName.Size = new System.Drawing.Size(171, 38);
            this.Txt_FName.TabIndex = 21;
            this.Txt_FName.ThemeName = "Aqua";
            this.Txt_FName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_FName_KeyPress);
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.radLabel1.Location = new System.Drawing.Point(189, 21);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(143, 36);
            this.radLabel1.TabIndex = 22;
            this.radLabel1.Text = "نام و نام خانوادگی :";
            this.radLabel1.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.radLabel1.ThemeName = "Aqua";
            // 
            // Form_RegTankhah
            // 
            this.AcceptButton = this.Btn_Register;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(961, 518);
            this.Controls.Add(this.radGroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_RegTankhah";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_RegTankhah";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.Form_RegTankhah_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridTankhah.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridTankhah)).EndInit();
            this.GridTankhah.ResumeLayout(false);
            this.GridTankhah.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).EndInit();
            this.radGroupBox2.ResumeLayout(false);
            this.radGroupBox2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Register)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_AddTel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_DelTel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Tel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_FName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private Telerik.WinControls.Themes.AquaTheme aquaTheme1;
        private Telerik.WinControls.Themes.Office2007SilverTheme office2007SilverTheme1;
        private System.ComponentModel.BackgroundWorker BGW;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox2;
        private Telerik.WinControls.UI.RadTextBox Txt_FName;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadButton Btn_AddTel;
        private Telerik.WinControls.UI.RadButton Btn_DelTel;
        private System.Windows.Forms.ListBox listBox_Tels;
        private Telerik.WinControls.UI.RadTextBox Txt_Tel;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadGridView GridTankhah;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Telerik.WinControls.UI.RadButton Btn_Register;
        private Telerik.WinControls.UI.RadButton Btn_Edit;
        private Telerik.WinControls.UI.RadButton Btn_Close;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
