namespace EsfahanGhos.Form_Users
{
    partial class Form_Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private global::System.ComponentModel.IContainer components = null;

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
            this.components = new global::System.ComponentModel.Container();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.flowLayoutPanel1 = new global::System.Windows.Forms.FlowLayoutPanel();
            this.Txt_UserName = new Telerik.WinControls.UI.RadTextBox();
            this.Txt_Password = new Telerik.WinControls.UI.RadTextBox();
            this.Lbl = new global::System.Windows.Forms.Label();
            this.Btn_Login = new Telerik.WinControls.UI.RadButton();
            this.Btn_Exit = new Telerik.WinControls.UI.RadButton();
            this.aquaTheme1 = new Telerik.WinControls.Themes.AquaTheme();
            this.timer1 = new global::System.Windows.Forms.Timer(this.components);
            this.errorProvider1 = new global::System.Windows.Forms.ErrorProvider(this.components);
            this.BGW = new global::System.ComponentModel.BackgroundWorker();
            ((global::System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((global::System.ComponentModel.ISupportInitialize)(this.Txt_UserName)).BeginInit();
            ((global::System.ComponentModel.ISupportInitialize)(this.Txt_Password)).BeginInit();
            ((global::System.ComponentModel.ISupportInitialize)(this.Btn_Login)).BeginInit();
            ((global::System.ComponentModel.ISupportInitialize)(this.Btn_Exit)).BeginInit();
            ((global::System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = global::System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.BackColor = global::System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.radGroupBox1.Controls.Add(this.flowLayoutPanel1);
            this.radGroupBox1.Dock = global::System.Windows.Forms.DockStyle.Fill;
            this.radGroupBox1.Font = new global::System.Drawing.Font("B Nazanin", 16.2F, ((global::System.Drawing.FontStyle)((global::System.Drawing.FontStyle.Bold | global::System.Drawing.FontStyle.Italic))), global::System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.radGroupBox1.FooterImageAlignment = global::System.Drawing.ContentAlignment.MiddleCenter;
            this.radGroupBox1.FooterTextAlignment = global::System.Drawing.ContentAlignment.MiddleCenter;
            this.radGroupBox1.GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office;
            this.radGroupBox1.HeaderText = "نرم افزار اصفهان قوس";
            this.radGroupBox1.HeaderTextAlignment = global::System.Drawing.ContentAlignment.MiddleCenter;
            this.radGroupBox1.Location = new global::System.Drawing.Point(0, 0);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new global::System.Drawing.Size(322, 402);
            this.radGroupBox1.TabIndex = 0;
            this.radGroupBox1.Text = "نرم افزار اصفهان قوس";
            this.radGroupBox1.ThemeName = "Aqua";
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radGroupBox1.GetChildAt(0).GetChildAt(0).GetChildAt(0))).BackColor2 = global::System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radGroupBox1.GetChildAt(0).GetChildAt(0).GetChildAt(0))).BackColor3 = global::System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radGroupBox1.GetChildAt(0).GetChildAt(0).GetChildAt(0))).BackColor4 = global::System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radGroupBox1.GetChildAt(0).GetChildAt(0).GetChildAt(0))).BackColor = global::System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            ((Telerik.WinControls.UI.GroupBoxHeader)(this.radGroupBox1.GetChildAt(0).GetChildAt(1))).GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radGroupBox1.GetChildAt(0).GetChildAt(1).GetChildAt(0))).BackColor2 = global::System.Drawing.Color.White;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radGroupBox1.GetChildAt(0).GetChildAt(1).GetChildAt(0))).BackColor3 = global::System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radGroupBox1.GetChildAt(0).GetChildAt(1).GetChildAt(0))).BackColor4 = global::System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radGroupBox1.GetChildAt(0).GetChildAt(1).GetChildAt(0))).BackColor = global::System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radGroupBox1.GetChildAt(0).GetChildAt(1).GetChildAt(1))).BottomColor = global::System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radGroupBox1.GetChildAt(0).GetChildAt(1).GetChildAt(1))).ForeColor2 = global::System.Drawing.SystemColors.ControlDark;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radGroupBox1.GetChildAt(0).GetChildAt(1).GetChildAt(1))).InnerColor2 = global::System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radGroupBox1.GetChildAt(0).GetChildAt(1).GetChildAt(1))).ForeColor = global::System.Drawing.SystemColors.ActiveCaptionText;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((global::System.Windows.Forms.AnchorStyles)(((global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left) 
            | global::System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.BackColor = global::System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.Txt_UserName);
            this.flowLayoutPanel1.Controls.Add(this.Txt_Password);
            this.flowLayoutPanel1.Controls.Add(this.Lbl);
            this.flowLayoutPanel1.Controls.Add(this.Btn_Login);
            this.flowLayoutPanel1.Controls.Add(this.Btn_Exit);
            this.flowLayoutPanel1.Location = new global::System.Drawing.Point(12, 59);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new global::System.Drawing.Size(298, 298);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // Txt_UserName
            // 
            this.Txt_UserName.AutoSize = false;
            this.Txt_UserName.Font = new global::System.Drawing.Font("B Nazanin", 13.8F, global::System.Drawing.FontStyle.Bold);
            this.Txt_UserName.ForeColor = global::System.Drawing.Color.LightGray;
            this.Txt_UserName.Location = new global::System.Drawing.Point(3, 3);
            this.Txt_UserName.Multiline = true;
            this.Txt_UserName.Name = "Txt_UserName";
            this.Txt_UserName.Size = new global::System.Drawing.Size(289, 53);
            this.Txt_UserName.TabIndex = 0;
            this.Txt_UserName.Text = "UserName ...";
            this.Txt_UserName.TextChanged += new global::System.EventHandler(this.Txt_UserName_TextChanged);
            this.Txt_UserName.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.Txt_UserName_KeyPress);
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.Txt_UserName.GetChildAt(0))).Text = "UserName ...";
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.Txt_UserName.GetChildAt(0))).ForeColor = global::System.Drawing.Color.LightGray;
            // 
            // Txt_Password
            // 
            this.Txt_Password.AutoSize = false;
            this.Txt_Password.Font = new global::System.Drawing.Font("B Nazanin", 13.8F, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Txt_Password.ForeColor = global::System.Drawing.Color.LightGray;
            this.Txt_Password.Location = new global::System.Drawing.Point(3, 62);
            this.Txt_Password.Multiline = true;
            this.Txt_Password.Name = "Txt_Password";
            this.Txt_Password.Size = new global::System.Drawing.Size(289, 53);
            this.Txt_Password.TabIndex = 1;
            this.Txt_Password.Text = "Password...";
            this.Txt_Password.TextChanged += new global::System.EventHandler(this.Txt_Password_TextChanged);
            this.Txt_Password.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.Txt_Password_KeyPress);
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.Txt_Password.GetChildAt(0))).Text = "Password...";
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.Txt_Password.GetChildAt(0))).ForeColor = global::System.Drawing.Color.LightGray;
            // 
            // Lbl
            // 
            this.Lbl.Anchor = ((global::System.Windows.Forms.AnchorStyles)(((global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left) 
            | global::System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl.AutoSize = true;
            this.Lbl.BackColor = global::System.Drawing.Color.Transparent;
            this.Lbl.Font = new global::System.Drawing.Font("B Nazanin", 10.8F, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Lbl.ForeColor = global::System.Drawing.Color.Red;
            this.Lbl.Location = new global::System.Drawing.Point(3, 118);
            this.Lbl.Name = "Lbl";
            this.Lbl.Size = new global::System.Drawing.Size(247, 28);
            this.Lbl.TabIndex = 3;
            this.Lbl.Text = "نام کاربری یا رمز عبور نادرست می باشد ";
            this.Lbl.Visible = false;
            // 
            // Btn_Login
            // 
            this.Btn_Login.Cursor = global::System.Windows.Forms.Cursors.Hand;
            this.Btn_Login.Font = new global::System.Drawing.Font("B Nazanin", 13.8F, global::System.Drawing.FontStyle.Bold);
            this.Btn_Login.ForeColor = global::System.Drawing.SystemColors.Window;
            this.Btn_Login.Location = new global::System.Drawing.Point(3, 149);
            this.Btn_Login.Name = "Btn_Login";
            this.Btn_Login.Size = new global::System.Drawing.Size(289, 53);
            this.Btn_Login.TabIndex = 3;
            this.Btn_Login.Text = "LOGIN";
            this.Btn_Login.ThemeName = "Aqua";
            this.Btn_Login.Click += new global::System.EventHandler(this.Btn_Login_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.Btn_Login.GetChildAt(0))).Text = "LOGIN";
            ((Telerik.WinControls.UI.RadButtonElement)(this.Btn_Login.GetChildAt(0))).ForeColor = global::System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            ((Telerik.WinControls.UI.RadButtonElement)(this.Btn_Login.GetChildAt(0))).BackColor = global::System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.Btn_Login.GetChildAt(0).GetChildAt(0))).BackColor2 = global::System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(78)))), ((int)(((byte)(131)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.Btn_Login.GetChildAt(0).GetChildAt(0))).BackColor3 = global::System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(78)))), ((int)(((byte)(131)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.Btn_Login.GetChildAt(0).GetChildAt(0))).BackColor4 = global::System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(78)))), ((int)(((byte)(131)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.Btn_Login.GetChildAt(0).GetChildAt(0))).BackColor = global::System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(78)))), ((int)(((byte)(131)))));
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.Cursor = global::System.Windows.Forms.Cursors.Hand;
            this.Btn_Exit.Font = new global::System.Drawing.Font("B Nazanin", 13.8F, global::System.Drawing.FontStyle.Bold);
            this.Btn_Exit.ForeColor = global::System.Drawing.SystemColors.Window;
            this.Btn_Exit.Location = new global::System.Drawing.Point(3, 208);
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.Size = new global::System.Drawing.Size(289, 53);
            this.Btn_Exit.TabIndex = 4;
            this.Btn_Exit.Text = "EXIT";
            this.Btn_Exit.ThemeName = "Aqua";
            this.Btn_Exit.Click += new global::System.EventHandler(this.Btn_Exit_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.Btn_Exit.GetChildAt(0))).Text = "EXIT";
            ((Telerik.WinControls.UI.RadButtonElement)(this.Btn_Exit.GetChildAt(0))).ForeColor = global::System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            ((Telerik.WinControls.UI.RadButtonElement)(this.Btn_Exit.GetChildAt(0))).BackColor = global::System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.Btn_Exit.GetChildAt(0).GetChildAt(0))).BackColor2 = global::System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(78)))), ((int)(((byte)(131)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.Btn_Exit.GetChildAt(0).GetChildAt(0))).BackColor3 = global::System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(78)))), ((int)(((byte)(131)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.Btn_Exit.GetChildAt(0).GetChildAt(0))).BackColor4 = global::System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(78)))), ((int)(((byte)(131)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.Btn_Exit.GetChildAt(0).GetChildAt(0))).BackColor = global::System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(78)))), ((int)(((byte)(131)))));
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // BGW
            // 
            this.BGW.DoWork += new global::System.ComponentModel.DoWorkEventHandler(this.BGW_DoWork);
            this.BGW.RunWorkerCompleted += new global::System.ComponentModel.RunWorkerCompletedEventHandler(this.BGW_RunWorkerCompleted);
            // 
            // Form_Login
            // 
            this.AcceptButton = this.Btn_Login;
            this.AutoScaleDimensions = new global::System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::System.Drawing.Color.White;
            this.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new global::System.Drawing.Size(322, 402);
            this.Controls.Add(this.radGroupBox1);
            this.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Login";
            this.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Login";
            this.TransparencyKey = global::System.Drawing.SystemColors.MenuBar;
            this.Load += new global::System.EventHandler(this.Form_Login_Load);
            ((global::System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((global::System.ComponentModel.ISupportInitialize)(this.Txt_UserName)).EndInit();
            ((global::System.ComponentModel.ISupportInitialize)(this.Txt_Password)).EndInit();
            ((global::System.ComponentModel.ISupportInitialize)(this.Btn_Login)).EndInit();
            ((global::System.ComponentModel.ISupportInitialize)(this.Btn_Exit)).EndInit();
            ((global::System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.Themes.AquaTheme aquaTheme1;
        private global::System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Telerik.WinControls.UI.RadTextBox Txt_UserName;
        private Telerik.WinControls.UI.RadTextBox Txt_Password;
        private Telerik.WinControls.UI.RadButton Btn_Login;
        private Telerik.WinControls.UI.RadButton Btn_Exit;
        private global::System.Windows.Forms.Timer timer1;
        private global::System.Windows.Forms.ErrorProvider errorProvider1;
        private global::System.Windows.Forms.Label Lbl;
        private global::System.ComponentModel.BackgroundWorker BGW;
    }
}