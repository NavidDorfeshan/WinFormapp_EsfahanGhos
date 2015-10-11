namespace EsfahanGhos
{
    partial class Form_Setting
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.office2007SilverTheme1 = new Telerik.WinControls.Themes.Office2007SilverTheme();
            this.TabRestore = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtRestoreAddress = new System.Windows.Forms.TextBox();
            this.GridListBackUps = new System.Windows.Forms.DataGridView();
            this.BackUpName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LblBackUp = new System.Windows.Forms.Label();
            this.TabBackup = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.TxtBackUpPath = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TabVAX = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtVAXDigit = new System.Windows.Forms.MaskedTextBox();
            this.TxtVAXDecimal = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtTaxDigit = new System.Windows.Forms.MaskedTextBox();
            this.TxtTaxDecimal = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnSaveVAX = new Telerik.WinControls.UI.RadButton();
            this.TabPersonaliziation = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtImageAddress = new System.Windows.Forms.TextBox();
            this.TabControlSetting = new System.Windows.Forms.TabControl();
            this.TabRestore.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridListBackUps)).BeginInit();
            this.TabBackup.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.TabVAX.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnSaveVAX)).BeginInit();
            this.TabPersonaliziation.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.TabControlSetting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // TabRestore
            // 
            this.TabRestore.BackColor = System.Drawing.Color.Linen;
            this.TabRestore.Controls.Add(this.groupBox5);
            this.TabRestore.Location = new System.Drawing.Point(4, 36);
            this.TabRestore.Margin = new System.Windows.Forms.Padding(4);
            this.TabRestore.Name = "TabRestore";
            this.TabRestore.Padding = new System.Windows.Forms.Padding(4);
            this.TabRestore.Size = new System.Drawing.Size(811, 326);
            this.TabRestore.TabIndex = 4;
            this.TabRestore.Text = "بازگردانی اطلاعات";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Linen;
            this.groupBox5.Controls.Add(this.LblBackUp);
            this.groupBox5.Controls.Add(this.GridListBackUps);
            this.groupBox5.Controls.Add(this.TxtRestoreAddress);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Location = new System.Drawing.Point(8, 0);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(687, 266);
            this.groupBox5.TabIndex = 45;
            this.groupBox5.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(517, 26);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 27);
            this.label7.TabIndex = 42;
            this.label7.Text = "آدرس فایل پشتیبان :";
            // 
            // TxtRestoreAddress
            // 
            this.TxtRestoreAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtRestoreAddress.Font = new System.Drawing.Font("Adobe Arabic", 14.9F, System.Drawing.FontStyle.Bold);
            this.TxtRestoreAddress.Location = new System.Drawing.Point(364, 55);
            this.TxtRestoreAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtRestoreAddress.Multiline = true;
            this.TxtRestoreAddress.Name = "TxtRestoreAddress";
            this.TxtRestoreAddress.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtRestoreAddress.Size = new System.Drawing.Size(307, 117);
            this.TxtRestoreAddress.TabIndex = 0;
            // 
            // GridListBackUps
            // 
            this.GridListBackUps.AllowUserToAddRows = false;
            this.GridListBackUps.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Adobe Arabic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GridListBackUps.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.GridListBackUps.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridListBackUps.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Adobe Arabic", 14.9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridListBackUps.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.GridListBackUps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridListBackUps.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.BackUpName});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Adobe Arabic", 14.9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridListBackUps.DefaultCellStyle = dataGridViewCellStyle7;
            this.GridListBackUps.EnableHeadersVisualStyles = false;
            this.GridListBackUps.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.GridListBackUps.Location = new System.Drawing.Point(20, 60);
            this.GridListBackUps.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GridListBackUps.MultiSelect = false;
            this.GridListBackUps.Name = "GridListBackUps";
            this.GridListBackUps.ReadOnly = true;
            this.GridListBackUps.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Adobe Arabic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GridListBackUps.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.GridListBackUps.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Adobe Arabic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GridListBackUps.RowTemplate.Height = 30;
            this.GridListBackUps.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridListBackUps.Size = new System.Drawing.Size(315, 148);
            this.GridListBackUps.TabIndex = 3;
            this.GridListBackUps.TabStop = false;
            // 
            // BackUpName
            // 
            this.BackUpName.HeaderText = "BackupName";
            this.BackUpName.Name = "BackUpName";
            this.BackUpName.ReadOnly = true;
            this.BackUpName.Visible = false;
            // 
            // Date
            // 
            this.Date.HeaderText = "تاریخ فایل پشتیبان";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // LblBackUp
            // 
            this.LblBackUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblBackUp.AutoSize = true;
            this.LblBackUp.BackColor = System.Drawing.Color.White;
            this.LblBackUp.Font = new System.Drawing.Font("Adobe Arabic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBackUp.ForeColor = System.Drawing.Color.Red;
            this.LblBackUp.Location = new System.Drawing.Point(65, 133);
            this.LblBackUp.Name = "LblBackUp";
            this.LblBackUp.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LblBackUp.Size = new System.Drawing.Size(209, 27);
            this.LblBackUp.TabIndex = 52;
            this.LblBackUp.Text = "هیچ فایل پشتیبانی یافت نشد";
            this.LblBackUp.Visible = false;
            // 
            // TabBackup
            // 
            this.TabBackup.BackColor = System.Drawing.Color.Linen;
            this.TabBackup.Controls.Add(this.groupBox4);
            this.TabBackup.Location = new System.Drawing.Point(4, 36);
            this.TabBackup.Margin = new System.Windows.Forms.Padding(4);
            this.TabBackup.Name = "TabBackup";
            this.TabBackup.Padding = new System.Windows.Forms.Padding(4);
            this.TabBackup.Size = new System.Drawing.Size(811, 326);
            this.TabBackup.TabIndex = 3;
            this.TabBackup.Text = "پشتیبان گیری";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Linen;
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.TxtBackUpPath);
            this.groupBox4.Location = new System.Drawing.Point(9, 8);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(684, 261);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "تهیه نسخه پشتیبان";
            // 
            // TxtBackUpPath
            // 
            this.TxtBackUpPath.Location = new System.Drawing.Point(133, 48);
            this.TxtBackUpPath.Margin = new System.Windows.Forms.Padding(4);
            this.TxtBackUpPath.Name = "TxtBackUpPath";
            this.TxtBackUpPath.Size = new System.Drawing.Size(397, 35);
            this.TxtBackUpPath.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(532, 52);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 27);
            this.label6.TabIndex = 3;
            this.label6.Text = "محل ذخیره سازی :";
            // 
            // TabVAX
            // 
            this.TabVAX.BackColor = System.Drawing.Color.Linen;
            this.TabVAX.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TabVAX.Controls.Add(this.groupBox2);
            this.TabVAX.Location = new System.Drawing.Point(4, 36);
            this.TabVAX.Margin = new System.Windows.Forms.Padding(4);
            this.TabVAX.Name = "TabVAX";
            this.TabVAX.Padding = new System.Windows.Forms.Padding(4);
            this.TabVAX.Size = new System.Drawing.Size(811, 326);
            this.TabVAX.TabIndex = 2;
            this.TabVAX.Text = "محاسبات";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Linen;
            this.groupBox2.Controls.Add(this.BtnSaveVAX);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.TxtTaxDecimal);
            this.groupBox2.Controls.Add(this.TxtTaxDigit);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.TxtVAXDecimal);
            this.groupBox2.Controls.Add(this.TxtVAXDigit);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Adobe Arabic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(59, 27);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(684, 273);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Adobe Arabic", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(288, 52);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(366, 26);
            this.label2.TabIndex = 34;
            this.label2.Text = "درصد مالیات بر ارزش افزوده امسال (محاسبات فاکتور) :";
            // 
            // TxtVAXDigit
            // 
            this.TxtVAXDigit.Font = new System.Drawing.Font("Adobe Arabic", 14.9F, System.Drawing.FontStyle.Bold);
            this.TxtVAXDigit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TxtVAXDigit.Location = new System.Drawing.Point(133, 47);
            this.TxtVAXDigit.Margin = new System.Windows.Forms.Padding(4);
            this.TxtVAXDigit.Mask = "00";
            this.TxtVAXDigit.Name = "TxtVAXDigit";
            this.TxtVAXDigit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtVAXDigit.Size = new System.Drawing.Size(56, 35);
            this.TxtVAXDigit.TabIndex = 0;
            this.TxtVAXDigit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtVAXDecimal
            // 
            this.TxtVAXDecimal.Font = new System.Drawing.Font("Adobe Arabic", 14.9F, System.Drawing.FontStyle.Bold);
            this.TxtVAXDecimal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TxtVAXDecimal.Location = new System.Drawing.Point(221, 47);
            this.TxtVAXDecimal.Margin = new System.Windows.Forms.Padding(4);
            this.TxtVAXDecimal.Mask = "00";
            this.TxtVAXDecimal.Name = "TxtVAXDecimal";
            this.TxtVAXDecimal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtVAXDecimal.Size = new System.Drawing.Size(56, 35);
            this.TxtVAXDecimal.TabIndex = 33;
            this.TxtVAXDecimal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Adobe Arabic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(197, 47);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(25, 37);
            this.label5.TabIndex = 1;
            this.label5.Text = "/";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Adobe Arabic", 14.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(336, 116);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(319, 26);
            this.label4.TabIndex = 39;
            this.label4.Text = "درصد مالیات امسال (محاسبات صورت وضعیت) :";
            // 
            // TxtTaxDigit
            // 
            this.TxtTaxDigit.Font = new System.Drawing.Font("Adobe Arabic", 14.9F, System.Drawing.FontStyle.Bold);
            this.TxtTaxDigit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TxtTaxDigit.Location = new System.Drawing.Point(183, 112);
            this.TxtTaxDigit.Margin = new System.Windows.Forms.Padding(4);
            this.TxtTaxDigit.Mask = "00";
            this.TxtTaxDigit.Name = "TxtTaxDigit";
            this.TxtTaxDigit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtTaxDigit.Size = new System.Drawing.Size(56, 35);
            this.TxtTaxDigit.TabIndex = 2;
            this.TxtTaxDigit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtTaxDecimal
            // 
            this.TxtTaxDecimal.Font = new System.Drawing.Font("Adobe Arabic", 14.9F, System.Drawing.FontStyle.Bold);
            this.TxtTaxDecimal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TxtTaxDecimal.Location = new System.Drawing.Point(271, 112);
            this.TxtTaxDecimal.Margin = new System.Windows.Forms.Padding(4);
            this.TxtTaxDecimal.Mask = "00";
            this.TxtTaxDecimal.Name = "TxtTaxDecimal";
            this.TxtTaxDecimal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtTaxDecimal.Size = new System.Drawing.Size(56, 35);
            this.TxtTaxDecimal.TabIndex = 38;
            this.TxtTaxDecimal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Adobe Arabic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(247, 112);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(25, 37);
            this.label3.TabIndex = 3;
            this.label3.Text = "/";
            // 
            // BtnSaveVAX
            // 
            this.BtnSaveVAX.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.BtnSaveVAX.Location = new System.Drawing.Point(78, 205);
            this.BtnSaveVAX.Name = "BtnSaveVAX";
            this.BtnSaveVAX.Size = new System.Drawing.Size(137, 42);
            this.BtnSaveVAX.TabIndex = 40;
            this.BtnSaveVAX.Text = "ذخیره";
            this.BtnSaveVAX.ThemeName = "Office2007Silver";
            this.BtnSaveVAX.Click += new System.EventHandler(this.BtnSaveVAX_Click);
            // 
            // TabPersonaliziation
            // 
            this.TabPersonaliziation.BackColor = System.Drawing.Color.Linen;
            this.TabPersonaliziation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TabPersonaliziation.Controls.Add(this.groupBox1);
            this.TabPersonaliziation.Location = new System.Drawing.Point(4, 36);
            this.TabPersonaliziation.Margin = new System.Windows.Forms.Padding(4);
            this.TabPersonaliziation.Name = "TabPersonaliziation";
            this.TabPersonaliziation.Padding = new System.Windows.Forms.Padding(4);
            this.TabPersonaliziation.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TabPersonaliziation.Size = new System.Drawing.Size(811, 326);
            this.TabPersonaliziation.TabIndex = 0;
            this.TabPersonaliziation.Text = "شخصی سازی";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Linen;
            this.groupBox1.Controls.Add(this.TxtImageAddress);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Adobe Arabic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(80, 17);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(684, 278);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بارگزاری تصویر پس زمینه برای صفحه اصلی برنامه";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(573, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "آدرس تصویر :";
            // 
            // TxtImageAddress
            // 
            this.TxtImageAddress.Location = new System.Drawing.Point(176, 59);
            this.TxtImageAddress.Margin = new System.Windows.Forms.Padding(4);
            this.TxtImageAddress.Name = "TxtImageAddress";
            this.TxtImageAddress.Size = new System.Drawing.Size(388, 33);
            this.TxtImageAddress.TabIndex = 0;
            // 
            // TabControlSetting
            // 
            this.TabControlSetting.Controls.Add(this.TabPersonaliziation);
            this.TabControlSetting.Controls.Add(this.TabVAX);
            this.TabControlSetting.Controls.Add(this.TabBackup);
            this.TabControlSetting.Controls.Add(this.TabRestore);
            this.TabControlSetting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControlSetting.Font = new System.Drawing.Font("Adobe Arabic", 14.9F, System.Drawing.FontStyle.Bold);
            this.TabControlSetting.Location = new System.Drawing.Point(0, 0);
            this.TabControlSetting.Margin = new System.Windows.Forms.Padding(4);
            this.TabControlSetting.Name = "TabControlSetting";
            this.TabControlSetting.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TabControlSetting.RightToLeftLayout = true;
            this.TabControlSetting.SelectedIndex = 0;
            this.TabControlSetting.Size = new System.Drawing.Size(819, 366);
            this.TabControlSetting.TabIndex = 1;
            // 
            // Form_Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(819, 366);
            this.Controls.Add(this.TabControlSetting);
            this.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.Name = "Form_Setting";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تنظیمات سیستم";
            this.ThemeName = "Office2007Silver";
            this.TabRestore.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridListBackUps)).EndInit();
            this.TabBackup.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.TabVAX.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnSaveVAX)).EndInit();
            this.TabPersonaliziation.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.TabControlSetting.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.Themes.Office2007SilverTheme office2007SilverTheme1;
        private System.Windows.Forms.TabPage TabRestore;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label LblBackUp;
        private System.Windows.Forms.DataGridView GridListBackUps;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn BackUpName;
        private System.Windows.Forms.TextBox TxtRestoreAddress;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage TabBackup;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtBackUpPath;
        private System.Windows.Forms.TabPage TabVAX;
        private System.Windows.Forms.GroupBox groupBox2;
        private Telerik.WinControls.UI.RadButton BtnSaveVAX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox TxtTaxDecimal;
        public System.Windows.Forms.MaskedTextBox TxtTaxDigit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox TxtVAXDecimal;
        public System.Windows.Forms.MaskedTextBox TxtVAXDigit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage TabPersonaliziation;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtImageAddress;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TabControl TabControlSetting;

    }
}
