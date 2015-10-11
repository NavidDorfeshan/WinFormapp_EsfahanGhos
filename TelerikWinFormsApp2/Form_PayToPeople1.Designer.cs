namespace EsfahanGhos
{
    partial class Form_PayToPeople1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_PayToPeople1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_Exit = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.ComboPerson = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_TotalPay = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.button5 = new System.Windows.Forms.Button();
            this.Btn_OpenForm = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Txt_Phone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_Name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BGW = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.Btn_Exit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1001, 29);
            this.panel1.TabIndex = 0;
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
            this.Btn_Exit.Location = new System.Drawing.Point(967, 0);
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.Size = new System.Drawing.Size(34, 29);
            this.Btn_Exit.TabIndex = 1;
            this.Btn_Exit.UseVisualStyleBackColor = false;
            this.Btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Sign-Error-icon.png");
            this.imageList1.Images.SetKeyName(1, "Actions-list-add-icon.png");
            this.imageList1.Images.SetKeyName(2, "Iconshow-Hardware-Printer.ico");
            this.imageList1.Images.SetKeyName(3, "Actions-list-add-user-icon.png");
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(990, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(11, 519);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 29);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(11, 519);
            this.panel3.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(11, 537);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(979, 11);
            this.panel4.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.ComboPerson);
            this.panel5.Controls.Add(this.pictureBox1);
            this.panel5.Controls.Add(this.button1);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Location = new System.Drawing.Point(17, 35);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(967, 61);
            this.panel5.TabIndex = 5;
            // 
            // ComboPerson
            // 
            this.ComboPerson.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboPerson.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.ComboPerson.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboPerson.BackColor = System.Drawing.Color.Snow;
            this.ComboPerson.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ComboPerson.FormattingEnabled = true;
            this.ComboPerson.Location = new System.Drawing.Point(629, 14);
            this.ComboPerson.Name = "ComboPerson";
            this.ComboPerson.Size = new System.Drawing.Size(193, 37);
            this.ComboPerson.TabIndex = 8;
            this.ComboPerson.SelectedIndexChanged += new System.EventHandler(this.ComboPerson_SelectedValueChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(531, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ImageKey = "Actions-list-add-user-icon.png";
            this.button1.ImageList = this.imageList1;
            this.button1.Location = new System.Drawing.Point(580, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 37);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(828, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "نام و نام خانوادگی :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.Txt_TotalPay);
            this.groupBox2.Controls.Add(this.panel6);
            this.groupBox2.Controls.Add(this.Txt_Phone);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.Txt_Name);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(11, 102);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(979, 435);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "اطلاعات فردی";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(297, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 32);
            this.label2.TabIndex = 17;
            this.label2.Text = "جمع کل :";
            // 
            // Txt_TotalPay
            // 
            this.Txt_TotalPay.Location = new System.Drawing.Point(54, 289);
            this.Txt_TotalPay.Multiline = true;
            this.Txt_TotalPay.Name = "Txt_TotalPay";
            this.Txt_TotalPay.ReadOnly = true;
            this.Txt_TotalPay.Size = new System.Drawing.Size(237, 37);
            this.Txt_TotalPay.TabIndex = 16;
            this.Txt_TotalPay.Text = "0";
            this.Txt_TotalPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.button6);
            this.panel6.Controls.Add(this.button5);
            this.panel6.Controls.Add(this.Btn_OpenForm);
            this.panel6.Controls.Add(this.button2);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(3, 332);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(973, 100);
            this.panel6.TabIndex = 15;
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button6.ImageKey = "Custom-Icon-Design-Flatastic-3-Signup.ico";
            this.button6.ImageList = this.imageList2;
            this.button6.Location = new System.Drawing.Point(257, 9);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(173, 75);
            this.button6.TabIndex = 17;
            this.button6.Text = "ویرایش پرداخت ها";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Btn_OpenForm_Click);
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "Aha-Soft-Large-Seo-SEO.ico");
            this.imageList2.Images.SetKeyName(1, "Custom-Icon-Design-Flatastic-3-Signup.ico");
            this.imageList2.Images.SetKeyName(2, "Custom-Icon-Design-Pretty-Office-6-Custom-reports.ico");
            this.imageList2.Images.SetKeyName(3, "Iconshock-Real-Vista-Text-Print.ico");
            this.imageList2.Images.SetKeyName(4, "Iconshow-Hardware-Printer.ico");
            this.imageList2.Images.SetKeyName(5, "Actions-list-add-icon.png");
            this.imageList2.Images.SetKeyName(6, "Actions-list-add-user-icon.png");
            this.imageList2.Images.SetKeyName(7, "Actions-list-remove-icon.png");
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.ImageKey = "Actions-list-add-icon.png";
            this.button5.ImageList = this.imageList2;
            this.button5.Location = new System.Drawing.Point(436, 9);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(173, 75);
            this.button5.TabIndex = 16;
            this.button5.Text = "ثبت پرداخت جدید";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Btn_OpenForm
            // 
            this.Btn_OpenForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_OpenForm.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.Btn_OpenForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_OpenForm.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_OpenForm.ImageKey = "Iconshock-Real-Vista-Text-Print.ico";
            this.Btn_OpenForm.ImageList = this.imageList2;
            this.Btn_OpenForm.Location = new System.Drawing.Point(615, 9);
            this.Btn_OpenForm.Name = "Btn_OpenForm";
            this.Btn_OpenForm.Size = new System.Drawing.Size(173, 75);
            this.Btn_OpenForm.TabIndex = 15;
            this.Btn_OpenForm.Text = "گزارش از پرداخت ها";
            this.Btn_OpenForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_OpenForm.UseVisualStyleBackColor = true;
            this.Btn_OpenForm.Click += new System.EventHandler(this.Btn_OpenForm_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.ImageKey = "Iconshow-Hardware-Printer.ico";
            this.button2.ImageList = this.imageList2;
            this.button2.Location = new System.Drawing.Point(794, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(173, 75);
            this.button2.TabIndex = 14;
            this.button2.Text = "چارت پرداختی ها";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Txt_Phone
            // 
            this.Txt_Phone.Location = new System.Drawing.Point(54, 37);
            this.Txt_Phone.Multiline = true;
            this.Txt_Phone.Name = "Txt_Phone";
            this.Txt_Phone.ReadOnly = true;
            this.Txt_Phone.Size = new System.Drawing.Size(237, 37);
            this.Txt_Phone.TabIndex = 13;
            this.Txt_Phone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(297, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 32);
            this.label5.TabIndex = 12;
            this.label5.Text = "شماره تلفن :";
            // 
            // Txt_Name
            // 
            this.Txt_Name.Location = new System.Drawing.Point(578, 36);
            this.Txt_Name.Multiline = true;
            this.Txt_Name.Name = "Txt_Name";
            this.Txt_Name.ReadOnly = true;
            this.Txt_Name.Size = new System.Drawing.Size(237, 37);
            this.Txt_Name.TabIndex = 11;
            this.Txt_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(821, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 32);
            this.label4.TabIndex = 10;
            this.label4.Text = "نام و نام خانوادگی :";
            // 
            // BGW
            // 
            this.BGW.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BGW_DoWork);
            this.BGW.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BGW_RunWorkerCompleted);
            // 
            // Form_PayToPeople1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.Btn_Exit;
            this.ClientSize = new System.Drawing.Size(1001, 548);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("B Nazanin", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form_PayToPeople1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form_PayToPeople1_Load);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_Exit;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox Txt_Phone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txt_Name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button Btn_OpenForm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_TotalPay;
        private System.ComponentModel.BackgroundWorker BGW;
        private System.Windows.Forms.ComboBox ComboPerson;
    }
}