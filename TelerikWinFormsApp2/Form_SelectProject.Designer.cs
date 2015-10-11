namespace EsfahanGhos
{
    partial class Form_SelectProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_SelectProject));
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.Button_ListOfProject = new Telerik.WinControls.UI.RadButton();
            this.Button_Close = new Telerik.WinControls.UI.RadButton();
            this.Combo_SelectProject = new Telerik.WinControls.UI.RadDropDownList();
            this.label1 = new System.Windows.Forms.Label();
            this.Button_RegProject = new Telerik.WinControls.UI.RadButton();
            this.Button_EnterProject = new Telerik.WinControls.UI.RadButton();
            this.BGW = new System.ComponentModel.BackgroundWorker();
            this.aquaTheme1 = new Telerik.WinControls.Themes.AquaTheme();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Button_ListOfProject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Combo_SelectProject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_RegProject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_EnterProject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "Computer-Hardware-Shutdown-icon.png");
            this.imageList.Images.SetKeyName(1, "Itzikgur-My-Seven-Keys.ico");
            this.imageList.Images.SetKeyName(2, "Iconsmind-Outline-Lock.ico");
            this.imageList.Images.SetKeyName(3, "Gakuseisean-Ivista-2-Alarm-Padlock.ico");
            this.imageList.Images.SetKeyName(4, "Hopstarter-Soft-Scraps-Lock-Lock.ico");
            this.imageList.Images.SetKeyName(5, "Awicons-Vista-Artistic-Add.ico");
            this.imageList.Images.SetKeyName(6, "Fatcow-Farm-Fresh-Door-open.ico");
            this.imageList.Images.SetKeyName(7, "Kyo-Tux-Soft-Back.ico");
            this.imageList.Images.SetKeyName(8, "Tatice-Cristal-Intense-Loupe.ico");
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.Button_ListOfProject);
            this.radGroupBox1.Controls.Add(this.Button_Close);
            this.radGroupBox1.Controls.Add(this.Combo_SelectProject);
            this.radGroupBox1.Controls.Add(this.label1);
            this.radGroupBox1.Controls.Add(this.Button_RegProject);
            this.radGroupBox1.Controls.Add(this.Button_EnterProject);
            this.radGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGroupBox1.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.radGroupBox1.FooterTextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.radGroupBox1.GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office;
            this.radGroupBox1.HeaderImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.radGroupBox1.HeaderText = "پروژه";
            this.radGroupBox1.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.radGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(333, 351);
            this.radGroupBox1.TabIndex = 0;
            this.radGroupBox1.Text = "پروژه";
            this.radGroupBox1.ThemeName = "Aqua";
            // 
            // Button_ListOfProject
            // 
            this.Button_ListOfProject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_ListOfProject.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.Button_ListOfProject.ImageKey = "Tatice-Cristal-Intense-Loupe.ico";
            this.Button_ListOfProject.ImageList = this.imageList;
            this.Button_ListOfProject.Location = new System.Drawing.Point(48, 210);
            this.Button_ListOfProject.Name = "Button_ListOfProject";
            this.Button_ListOfProject.Size = new System.Drawing.Size(212, 37);
            this.Button_ListOfProject.TabIndex = 3;
            this.Button_ListOfProject.Text = "لیست پروژ ها";
            this.Button_ListOfProject.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.Button_ListOfProject.ThemeName = "Aqua";
            this.Button_ListOfProject.Click += new System.EventHandler(this.Button_ListOfProject_Click);
            // 
            // Button_Close
            // 
            this.Button_Close.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.Button_Close.ImageKey = "Kyo-Tux-Soft-Back.ico";
            this.Button_Close.ImageList = this.imageList;
            this.Button_Close.Location = new System.Drawing.Point(101, 279);
            this.Button_Close.Name = "Button_Close";
            this.Button_Close.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Button_Close.Size = new System.Drawing.Size(87, 41);
            this.Button_Close.TabIndex = 4;
            this.Button_Close.Text = "خروج";
            this.Button_Close.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.Button_Close.ThemeName = "Aqua";
            this.Button_Close.Click += new System.EventHandler(this.Button_Close_Click);
            // 
            // Combo_SelectProject
            // 
            this.Combo_SelectProject.AllowShowFocusCues = false;
            this.Combo_SelectProject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Combo_SelectProject.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.Combo_SelectProject.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Combo_SelectProject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Combo_SelectProject.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.Combo_SelectProject.Location = new System.Drawing.Point(48, 77);
            this.Combo_SelectProject.Name = "Combo_SelectProject";
            this.Combo_SelectProject.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Combo_SelectProject.Size = new System.Drawing.Size(212, 38);
            this.Combo_SelectProject.TabIndex = 0;
            this.Combo_SelectProject.Text = "انتخاب کن";
            this.Combo_SelectProject.ThemeName = "Aqua";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(122, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 32);
            this.label1.TabIndex = 17;
            this.label1.Text = "انتخاب پروژه";
            // 
            // Button_RegProject
            // 
            this.Button_RegProject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_RegProject.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.Button_RegProject.ImageKey = "Awicons-Vista-Artistic-Add.ico";
            this.Button_RegProject.ImageList = this.imageList;
            this.Button_RegProject.Location = new System.Drawing.Point(48, 167);
            this.Button_RegProject.Name = "Button_RegProject";
            this.Button_RegProject.Size = new System.Drawing.Size(212, 37);
            this.Button_RegProject.TabIndex = 2;
            this.Button_RegProject.Text = "ایجاد پروژه ی جدید";
            this.Button_RegProject.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.Button_RegProject.ThemeName = "Aqua";
            this.Button_RegProject.Click += new System.EventHandler(this.radButton2_Click);
            // 
            // Button_EnterProject
            // 
            this.Button_EnterProject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_EnterProject.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.Button_EnterProject.ImageKey = "Fatcow-Farm-Fresh-Door-open.ico";
            this.Button_EnterProject.ImageList = this.imageList;
            this.Button_EnterProject.Location = new System.Drawing.Point(48, 124);
            this.Button_EnterProject.Name = "Button_EnterProject";
            this.Button_EnterProject.Size = new System.Drawing.Size(212, 37);
            this.Button_EnterProject.TabIndex = 1;
            this.Button_EnterProject.Text = "ورود";
            this.Button_EnterProject.ThemeName = "Aqua";
            this.Button_EnterProject.Click += new System.EventHandler(this.radButton1_Click);
            // 
            // BGW
            // 
            this.BGW.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BGW_DoWork);
            this.BGW.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BGW_RunWorkerCompleted);
            // 
            // Form_SelectProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(333, 351);
            this.Controls.Add(this.radGroupBox1);
            this.Font = new System.Drawing.Font("Adobe Arabic", 13.8F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(700, 350);
            this.Name = "Form_SelectProject";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "";
            this.ThemeName = "Aqua";
            this.Load += new System.EventHandler(this.Form_SelectProject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Button_ListOfProject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_Close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Combo_SelectProject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_RegProject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_EnterProject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadDropDownList Combo_SelectProject;
        private System.Windows.Forms.Label label1;
        private Telerik.WinControls.UI.RadButton Button_RegProject;
        private Telerik.WinControls.UI.RadButton Button_EnterProject;
        private Telerik.WinControls.UI.RadButton Button_Close;
        private System.ComponentModel.BackgroundWorker BGW;
        private Telerik.WinControls.Themes.AquaTheme aquaTheme1;
        private Telerik.WinControls.UI.RadButton Button_ListOfProject;
    }
}
