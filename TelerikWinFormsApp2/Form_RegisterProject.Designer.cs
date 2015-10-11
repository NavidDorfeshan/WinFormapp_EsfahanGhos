namespace EsfahanGhos
{
    partial class Form_RegisterProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_RegisterProject));
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.aquaTheme1 = new Telerik.WinControls.Themes.AquaTheme();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.Txt_PName = new Telerik.WinControls.UI.RadTextBox();
            this.GroupBox_RegProject = new Telerik.WinControls.UI.RadGroupBox();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.Calendar1 = new FarsiCalendarComponent.FarsiDatePicker();
            this.Txt_Em = new Telerik.WinControls.UI.RadTextBox();
            this.Txt_PDesc = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel7 = new Telerik.WinControls.UI.RadLabel();
            this.Txt_ProjectID = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.Button_ListProject = new Telerik.WinControls.UI.RadButton();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.Button_Close = new Telerik.WinControls.UI.RadButton();
            this.Button_Reg = new Telerik.WinControls.UI.RadButton();
            this.Txt_PArea = new Telerik.WinControls.UI.RadTextBox();
            this.Register_Alert = new Telerik.WinControls.UI.RadDesktopAlert(this.components);
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_PName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupBox_RegProject)).BeginInit();
            this.GroupBox_RegProject.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Em)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_PDesc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_ProjectID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_ListProject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_Reg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_PArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.radLabel1.Location = new System.Drawing.Point(441, 92);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(79, 36);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "نام پروژه :";
            this.radLabel1.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.radLabel1.ThemeName = "Aqua";
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.radLabel2.Location = new System.Drawing.Point(418, 178);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radLabel2.Size = new System.Drawing.Size(102, 36);
            this.radLabel2.TabIndex = 1;
            this.radLabel2.Text = "تاریخ شروع :";
            this.radLabel2.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.radLabel2.ThemeName = "Aqua";
            // 
            // radLabel4
            // 
            this.radLabel4.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.radLabel4.Location = new System.Drawing.Point(404, 218);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radLabel4.Size = new System.Drawing.Size(116, 36);
            this.radLabel4.TabIndex = 2;
            this.radLabel4.Text = "مساحت پروژه :";
            this.radLabel4.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.radLabel4.ThemeName = "Aqua";
            // 
            // Txt_PName
            // 
            this.Txt_PName.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.Txt_PName.Location = new System.Drawing.Point(122, 91);
            this.Txt_PName.Name = "Txt_PName";
            this.Txt_PName.Size = new System.Drawing.Size(274, 38);
            this.Txt_PName.TabIndex = 1;
            this.Txt_PName.ThemeName = "Aqua";
            this.Txt_PName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AlphaTextBox_KeyPress);
            // 
            // GroupBox_RegProject
            // 
            this.GroupBox_RegProject.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.GroupBox_RegProject.Controls.Add(this.radLabel5);
            this.GroupBox_RegProject.Controls.Add(this.Calendar1);
            this.GroupBox_RegProject.Controls.Add(this.Txt_Em);
            this.GroupBox_RegProject.Controls.Add(this.radLabel1);
            this.GroupBox_RegProject.Controls.Add(this.Txt_PDesc);
            this.GroupBox_RegProject.Controls.Add(this.radLabel7);
            this.GroupBox_RegProject.Controls.Add(this.Txt_ProjectID);
            this.GroupBox_RegProject.Controls.Add(this.radLabel3);
            this.GroupBox_RegProject.Controls.Add(this.Button_ListProject);
            this.GroupBox_RegProject.Controls.Add(this.Button_Close);
            this.GroupBox_RegProject.Controls.Add(this.Button_Reg);
            this.GroupBox_RegProject.Controls.Add(this.Txt_PArea);
            this.GroupBox_RegProject.Controls.Add(this.Txt_PName);
            this.GroupBox_RegProject.Controls.Add(this.radLabel4);
            this.GroupBox_RegProject.Controls.Add(this.radLabel2);
            this.GroupBox_RegProject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupBox_RegProject.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.GroupBox_RegProject.GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office;
            this.GroupBox_RegProject.HeaderText = "تعریف پروژه";
            this.GroupBox_RegProject.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.GroupBox_RegProject.Location = new System.Drawing.Point(0, 0);
            this.GroupBox_RegProject.Name = "GroupBox_RegProject";
            this.GroupBox_RegProject.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GroupBox_RegProject.Size = new System.Drawing.Size(557, 434);
            this.GroupBox_RegProject.TabIndex = 9;
            this.GroupBox_RegProject.Text = "تعریف پروژه";
            this.GroupBox_RegProject.ThemeName = "Aqua";
            // 
            // radLabel5
            // 
            this.radLabel5.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.radLabel5.Location = new System.Drawing.Point(429, 137);
            this.radLabel5.Name = "radLabel5";
            this.radLabel5.Size = new System.Drawing.Size(91, 36);
            this.radLabel5.TabIndex = 2;
            this.radLabel5.Text = "نام کارفرما :";
            this.radLabel5.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.radLabel5.ThemeName = "Aqua";
            // 
            // Calendar1
            // 
            this.Calendar1.GeoDate = new System.DateTime(2015, 3, 8, 0, 0, 0, 0);
            this.Calendar1.Location = new System.Drawing.Point(122, 178);
            this.Calendar1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Calendar1.MaximumSize = new System.Drawing.Size(1333, 26);
            this.Calendar1.Name = "Calendar1";
            this.Calendar1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Calendar1.Size = new System.Drawing.Size(274, 26);
            this.Calendar1.TabIndex = 3;
            // 
            // Txt_Em
            // 
            this.Txt_Em.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.Txt_Em.Location = new System.Drawing.Point(122, 135);
            this.Txt_Em.Name = "Txt_Em";
            this.Txt_Em.Size = new System.Drawing.Size(274, 38);
            this.Txt_Em.TabIndex = 2;
            this.Txt_Em.ThemeName = "Aqua";
            this.Txt_Em.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AlphaTextBox_KeyPress);
            // 
            // Txt_PDesc
            // 
            this.Txt_PDesc.AutoSize = false;
            this.Txt_PDesc.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.Txt_PDesc.Location = new System.Drawing.Point(122, 259);
            this.Txt_PDesc.Multiline = true;
            this.Txt_PDesc.Name = "Txt_PDesc";
            this.Txt_PDesc.Size = new System.Drawing.Size(274, 95);
            this.Txt_PDesc.TabIndex = 5;
            this.Txt_PDesc.ThemeName = "Aqua";
            // 
            // radLabel7
            // 
            this.radLabel7.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.radLabel7.Location = new System.Drawing.Point(434, 259);
            this.radLabel7.Name = "radLabel7";
            this.radLabel7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radLabel7.Size = new System.Drawing.Size(86, 36);
            this.radLabel7.TabIndex = 8;
            this.radLabel7.Text = "توضیحات :";
            this.radLabel7.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.radLabel7.ThemeName = "Aqua";
            // 
            // Txt_ProjectID
            // 
            this.Txt_ProjectID.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.Txt_ProjectID.Location = new System.Drawing.Point(122, 46);
            this.Txt_ProjectID.Name = "Txt_ProjectID";
            this.Txt_ProjectID.ReadOnly = true;
            this.Txt_ProjectID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Txt_ProjectID.Size = new System.Drawing.Size(274, 38);
            this.Txt_ProjectID.TabIndex = 0;
            this.Txt_ProjectID.ThemeName = "Aqua";
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.radLabel3.Location = new System.Drawing.Point(441, 47);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(79, 36);
            this.radLabel3.TabIndex = 14;
            this.radLabel3.Text = "کد پروژه :";
            this.radLabel3.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.radLabel3.ThemeName = "Aqua";
            // 
            // Button_ListProject
            // 
            this.Button_ListProject.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Button_ListProject.ImageKey = "Tatice-Cristal-Intense-Loupe.ico";
            this.Button_ListProject.ImageList = this.imageList;
            this.Button_ListProject.Location = new System.Drawing.Point(293, 381);
            this.Button_ListProject.Name = "Button_ListProject";
            this.Button_ListProject.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Button_ListProject.Size = new System.Drawing.Size(219, 41);
            this.Button_ListProject.TabIndex = 6;
            this.Button_ListProject.Text = "مشاهده ی لیست پروژه ها";
            this.Button_ListProject.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.Button_ListProject.ThemeName = "Aqua";
            this.Button_ListProject.Click += new System.EventHandler(this.Button_ListProject_Click);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "Calendar-icon.png");
            this.imageList.Images.SetKeyName(1, "add-icon.png");
            this.imageList.Images.SetKeyName(2, "Kyo-Tux-Soft-Back.ico");
            this.imageList.Images.SetKeyName(3, "Tatice-Cristal-Intense-Loupe.ico");
            // 
            // Button_Close
            // 
            this.Button_Close.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Button_Close.ImageKey = "Kyo-Tux-Soft-Back.ico";
            this.Button_Close.ImageList = this.imageList;
            this.Button_Close.Location = new System.Drawing.Point(80, 381);
            this.Button_Close.Name = "Button_Close";
            this.Button_Close.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Button_Close.Size = new System.Drawing.Size(87, 41);
            this.Button_Close.TabIndex = 7;
            this.Button_Close.Text = "خروج";
            this.Button_Close.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.Button_Close.ThemeName = "Aqua";
            this.Button_Close.Click += new System.EventHandler(this.Button_Close_Click);
            // 
            // Button_Reg
            // 
            this.Button_Reg.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Button_Reg.ImageKey = "add-icon.png";
            this.Button_Reg.ImageList = this.imageList;
            this.Button_Reg.Location = new System.Drawing.Point(173, 381);
            this.Button_Reg.Name = "Button_Reg";
            this.Button_Reg.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Button_Reg.Size = new System.Drawing.Size(114, 41);
            this.Button_Reg.TabIndex = 6;
            this.Button_Reg.Text = "ثبت و بعدی";
            this.Button_Reg.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.Button_Reg.ThemeName = "Aqua";
            this.Button_Reg.Click += new System.EventHandler(this.Button_Reg_Click);
            // 
            // Txt_PArea
            // 
            this.Txt_PArea.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.Txt_PArea.Location = new System.Drawing.Point(122, 215);
            this.Txt_PArea.Name = "Txt_PArea";
            this.Txt_PArea.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Txt_PArea.Size = new System.Drawing.Size(274, 38);
            this.Txt_PArea.TabIndex = 4;
            this.Txt_PArea.ThemeName = "Aqua";
            this.Txt_PArea.TextChanged += new System.EventHandler(this.Txt_Area_TextChanged);
            this.Txt_PArea.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberTextBox_KeyPress);
            // 
            // Register_Alert
            // 
            this.Register_Alert.AutoCloseDelay = 3;
            this.Register_Alert.CaptionText = "پیام";
            this.Register_Alert.ContentText = "اطلاعات با موفقیت ثبت شد";
            this.Register_Alert.FadeAnimationFrames = 100;
            this.Register_Alert.PopupAnimationDirection = Telerik.WinControls.UI.RadDirection.Left;
            this.Register_Alert.ThemeName = "Aqua";
            // 
            // Form_RegisterProject
            // 
            this.AcceptButton = this.Button_Reg;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(557, 434);
            this.Controls.Add(this.GroupBox_RegProject);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_RegisterProject";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "";
            this.Load += new System.EventHandler(this.Form_RegisterPoroject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_PName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupBox_RegProject)).EndInit();
            this.GroupBox_RegProject.ResumeLayout(false);
            this.GroupBox_RegProject.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Em)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_PDesc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_ProjectID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_ListProject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_Close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_Reg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_PArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.Themes.AquaTheme aquaTheme1;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadTextBox Txt_PName;
        private Telerik.WinControls.UI.RadGroupBox GroupBox_RegProject;
        private Telerik.WinControls.UI.RadTextBox Txt_PArea;
        private Telerik.WinControls.UI.RadButton Button_Reg;
        private System.Windows.Forms.ImageList imageList;
        private Telerik.WinControls.UI.RadButton Button_Close;
        private Telerik.WinControls.UI.RadDesktopAlert Register_Alert;
        private System.Windows.Forms.ToolTip toolTip;
        private Telerik.WinControls.UI.RadButton Button_ListProject;
        private Telerik.WinControls.UI.RadTextBox Txt_ProjectID;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadTextBox Txt_PDesc;
        private Telerik.WinControls.UI.RadLabel radLabel7;
        private FarsiCalendarComponent.FarsiDatePicker Calendar1;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private Telerik.WinControls.UI.RadTextBox Txt_Em;
    }
}
