namespace EsfahanGhos.View
{
    partial class Check
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Check));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.aquaTheme1 = new Telerik.WinControls.Themes.AquaTheme();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_Delete = new Telerik.WinControls.UI.RadButton();
            this.Btn_Edit = new Telerik.WinControls.UI.RadButton();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Txt_Desc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Txt_DateFinish = new FarsiCalendarComponent.FarsiDatePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.Txt_Price = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_Reason = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_DateStart = new FarsiCalendarComponent.FarsiDatePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_CheckNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Register = new Telerik.WinControls.UI.RadButton();
            this.BGW = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Delete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Register)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "add-icon.png");
            this.imageList1.Images.SetKeyName(1, "Custom-Icon-Design-Flatastic-3-Signup.ico");
            this.imageList1.Images.SetKeyName(2, "Oxygen-Icons.org-Oxygen-Actions-edit-delete.ico");
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.Btn_Delete);
            this.panel1.Controls.Add(this.Btn_Edit);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.Txt_Desc);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.Txt_DateFinish);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.Txt_Price);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.Txt_Reason);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Txt_DateStart);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Txt_Name);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Txt_CheckNumber);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Btn_Register);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(732, 433);
            this.panel1.TabIndex = 0;
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Btn_Delete.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.Btn_Delete.ImageKey = "Oxygen-Icons.org-Oxygen-Actions-edit-delete.ico";
            this.Btn_Delete.ImageList = this.imageList1;
            this.Btn_Delete.Location = new System.Drawing.Point(288, 361);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(113, 51);
            this.Btn_Delete.TabIndex = 9;
            this.Btn_Delete.Text = "حذف";
            this.Btn_Delete.ThemeName = "Aqua";
            // 
            // Btn_Edit
            // 
            this.Btn_Edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Btn_Edit.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.Btn_Edit.ImageKey = "Custom-Icon-Design-Flatastic-3-Signup.ico";
            this.Btn_Edit.ImageList = this.imageList1;
            this.Btn_Edit.Location = new System.Drawing.Point(169, 361);
            this.Btn_Edit.Name = "Btn_Edit";
            this.Btn_Edit.Size = new System.Drawing.Size(113, 51);
            this.Btn_Edit.TabIndex = 8;
            this.Btn_Edit.Text = "ویرایش";
            this.Btn_Edit.ThemeName = "Aqua";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(12, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(23, 29);
            this.label13.TabIndex = 20;
            this.label13.Text = "*";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(365, 208);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(23, 29);
            this.label12.TabIndex = 19;
            this.label12.Text = "*";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(365, 151);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(23, 29);
            this.label11.TabIndex = 18;
            this.label11.Text = "*";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(365, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 29);
            this.label9.TabIndex = 16;
            this.label9.Text = "*";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(365, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 29);
            this.label8.TabIndex = 15;
            this.label8.Text = "*";
            // 
            // Txt_Desc
            // 
            this.Txt_Desc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_Desc.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.Txt_Desc.Location = new System.Drawing.Point(41, 257);
            this.Txt_Desc.Multiline = true;
            this.Txt_Desc.Name = "Txt_Desc";
            this.Txt_Desc.Size = new System.Drawing.Size(573, 87);
            this.Txt_Desc.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label7.Location = new System.Drawing.Point(629, 260);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 29);
            this.label7.TabIndex = 13;
            this.label7.Text = "توضیحات :";
            // 
            // Txt_DateFinish
            // 
            this.Txt_DateFinish.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_DateFinish.GeoDate = new System.DateTime(2015, 6, 26, 0, 0, 0, 0);
            this.Txt_DateFinish.Location = new System.Drawing.Point(394, 203);
            this.Txt_DateFinish.Margin = new System.Windows.Forms.Padding(9, 13, 9, 13);
            this.Txt_DateFinish.MaximumSize = new System.Drawing.Size(3000, 85);
            this.Txt_DateFinish.Name = "Txt_DateFinish";
            this.Txt_DateFinish.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Txt_DateFinish.Size = new System.Drawing.Size(220, 38);
            this.Txt_DateFinish.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.Location = new System.Drawing.Point(620, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 29);
            this.label6.TabIndex = 11;
            this.label6.Text = "تاریخ وصول :";
            // 
            // Txt_Price
            // 
            this.Txt_Price.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_Price.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.Txt_Price.Location = new System.Drawing.Point(394, 148);
            this.Txt_Price.Multiline = true;
            this.Txt_Price.Name = "Txt_Price";
            this.Txt_Price.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Txt_Price.Size = new System.Drawing.Size(215, 34);
            this.Txt_Price.TabIndex = 4;
            this.Txt_Price.TextChanged += new System.EventHandler(this.Txt_Price_TextChanged);
            this.Txt_Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Number_KeyPress);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Location = new System.Drawing.Point(645, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 29);
            this.label5.TabIndex = 9;
            this.label5.Text = "به مبلغ :";
            // 
            // Txt_Reason
            // 
            this.Txt_Reason.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_Reason.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.Txt_Reason.Location = new System.Drawing.Point(41, 103);
            this.Txt_Reason.Multiline = true;
            this.Txt_Reason.Name = "Txt_Reason";
            this.Txt_Reason.Size = new System.Drawing.Size(568, 34);
            this.Txt_Reason.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Location = new System.Drawing.Point(662, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "بابت :";
            // 
            // Txt_DateStart
            // 
            this.Txt_DateStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_DateStart.GeoDate = new System.DateTime(2015, 6, 26, 0, 0, 0, 0);
            this.Txt_DateStart.Location = new System.Drawing.Point(41, 13);
            this.Txt_DateStart.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Txt_DateStart.MaximumSize = new System.Drawing.Size(2000, 47);
            this.Txt_DateStart.Name = "Txt_DateStart";
            this.Txt_DateStart.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Txt_DateStart.Size = new System.Drawing.Size(220, 43);
            this.Txt_DateStart.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Location = new System.Drawing.Point(270, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "تاریخ صدور :";
            // 
            // Txt_Name
            // 
            this.Txt_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_Name.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.Txt_Name.Location = new System.Drawing.Point(394, 58);
            this.Txt_Name.Multiline = true;
            this.Txt_Name.Name = "Txt_Name";
            this.Txt_Name.Size = new System.Drawing.Size(215, 34);
            this.Txt_Name.TabIndex = 2;
            this.Txt_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Alphabet_KeyPress);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Location = new System.Drawing.Point(645, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "در وجه :";
            // 
            // Txt_CheckNumber
            // 
            this.Txt_CheckNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_CheckNumber.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.Txt_CheckNumber.Location = new System.Drawing.Point(394, 13);
            this.Txt_CheckNumber.Multiline = true;
            this.Txt_CheckNumber.Name = "Txt_CheckNumber";
            this.Txt_CheckNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Txt_CheckNumber.Size = new System.Drawing.Size(215, 34);
            this.Txt_CheckNumber.TabIndex = 0;
            this.Txt_CheckNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Number_KeyPress);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Location = new System.Drawing.Point(620, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "شماره چک :";
            // 
            // Btn_Register
            // 
            this.Btn_Register.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Btn_Register.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.Btn_Register.ImageKey = "add-icon.png";
            this.Btn_Register.ImageList = this.imageList1;
            this.Btn_Register.Location = new System.Drawing.Point(41, 361);
            this.Btn_Register.Name = "Btn_Register";
            this.Btn_Register.Size = new System.Drawing.Size(113, 51);
            this.Btn_Register.TabIndex = 7;
            this.Btn_Register.Text = "ثبت";
            this.Btn_Register.ThemeName = "Aqua";
            this.Btn_Register.Click += new System.EventHandler(this.Btn_Register_Click);
            // 
            // BGW
            // 
            this.BGW.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BGW_DoWork);
            this.BGW.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BGW_RunWorkerCompleted);
            // 
            // Check
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("B Nazanin", 12F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Check";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(732, 433);
            this.Load += new System.EventHandler(this.Check_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Delete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Register)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private Telerik.WinControls.Themes.AquaTheme aquaTheme1;
        private System.Windows.Forms.Panel panel1;
        private Telerik.WinControls.UI.RadButton Btn_Register;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Txt_Desc;
        private System.Windows.Forms.Label label7;
        private FarsiCalendarComponent.FarsiDatePicker Txt_DateFinish;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Txt_Price;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txt_Reason;
        private System.Windows.Forms.Label label4;
        private FarsiCalendarComponent.FarsiDatePicker Txt_DateStart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_CheckNumber;
        private System.ComponentModel.BackgroundWorker BGW;
        private Telerik.WinControls.UI.RadButton Btn_Delete;
        private Telerik.WinControls.UI.RadButton Btn_Edit;

    }
}
