namespace EsfahanGhos
{
    partial class Form_PaymentList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_PaymentList));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Btn_Search = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_Back = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_Name = new System.Windows.Forms.TextBox();
            this.Date_To = new FarsiCalendarComponent.FarsiDatePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Date_From = new FarsiCalendarComponent.FarsiDatePicker();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.check_Card = new System.Windows.Forms.CheckBox();
            this.check_Check = new System.Windows.Forms.CheckBox();
            this.check_Fish = new System.Windows.Forms.CheckBox();
            this.check_Pure = new System.Windows.Forms.CheckBox();
            this.BGW = new System.ComponentModel.BackgroundWorker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Grid_Payments = new System.Windows.Forms.DataGridView();
            this.Reason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tooltip_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Payments)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Snow;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.Btn_Search);
            this.flowLayoutPanel1.Controls.Add(this.btn_Back);
            this.flowLayoutPanel1.Controls.Add(this.pictureBox1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1244, 69);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // Btn_Search
            // 
            this.Btn_Search.BackColor = System.Drawing.Color.Snow;
            this.Btn_Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Search.FlatAppearance.BorderColor = System.Drawing.Color.Snow;
            this.Btn_Search.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.Btn_Search.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.Btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Search.Font = new System.Drawing.Font("B Nazanin", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Btn_Search.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Search.ImageKey = "Icontexto-Search-Search-black.ico";
            this.Btn_Search.ImageList = this.imageList1;
            this.Btn_Search.Location = new System.Drawing.Point(1127, 3);
            this.Btn_Search.Name = "Btn_Search";
            this.Btn_Search.Size = new System.Drawing.Size(112, 61);
            this.Btn_Search.TabIndex = 2;
            this.Btn_Search.Text = "جستجو";
            this.Btn_Search.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Search.UseVisualStyleBackColor = false;
            this.Btn_Search.Click += new System.EventHandler(this.Btn_Search_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Iconshock-Real-Vista-Text-Print.ico");
            this.imageList1.Images.SetKeyName(1, "Icontexto-Search-Search-black.ico");
            this.imageList1.Images.SetKeyName(2, "Semlabs-Web-Blog-Arrow-return-down-right.ico");
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.Color.Snow;
            this.btn_Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Back.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Back.FlatAppearance.BorderColor = System.Drawing.Color.Snow;
            this.btn_Back.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_Back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Back.Font = new System.Drawing.Font("B Nazanin", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_Back.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Back.ImageKey = "Semlabs-Web-Blog-Arrow-return-down-right.ico";
            this.btn_Back.ImageList = this.imageList1;
            this.btn_Back.Location = new System.Drawing.Point(1009, 3);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(112, 61);
            this.btn_Back.TabIndex = 4;
            this.btn_Back.Text = "بازگشت";
            this.btn_Back.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(903, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Snow;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Txt_Name);
            this.panel1.Controls.Add(this.Date_To);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Date_From);
            this.panel1.Controls.Add(this.flowLayoutPanel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Font = new System.Drawing.Font("B Nazanin", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.panel1.Location = new System.Drawing.Point(938, 69);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel1.Size = new System.Drawing.Size(306, 660);
            this.panel1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 315);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 28);
            this.label3.TabIndex = 8;
            this.label3.Text = "نام و نام خانوادگی :";
            // 
            // Txt_Name
            // 
            this.Txt_Name.Location = new System.Drawing.Point(95, 356);
            this.Txt_Name.Multiline = true;
            this.Txt_Name.Name = "Txt_Name";
            this.Txt_Name.Size = new System.Drawing.Size(141, 35);
            this.Txt_Name.TabIndex = 7;
            // 
            // Date_To
            // 
            this.Date_To.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Date_To.GeoDate = new System.DateTime(2015, 6, 26, 0, 0, 0, 0);
            this.Date_To.Location = new System.Drawing.Point(95, 273);
            this.Date_To.Margin = new System.Windows.Forms.Padding(11, 21, 11, 21);
            this.Date_To.MaximumSize = new System.Drawing.Size(3750, 138);
            this.Date_To.Name = "Date_To";
            this.Date_To.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Date_To.Size = new System.Drawing.Size(141, 36);
            this.Date_To.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "تا تاریخ :";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "از تاریخ :";
            // 
            // Date_From
            // 
            this.Date_From.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Date_From.GeoDate = new System.DateTime(2015, 6, 26, 0, 0, 0, 0);
            this.Date_From.Location = new System.Drawing.Point(95, 199);
            this.Date_From.Margin = new System.Windows.Forms.Padding(15, 34, 15, 34);
            this.Date_From.MaximumSize = new System.Drawing.Size(5156, 224);
            this.Date_From.Name = "Date_From";
            this.Date_From.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Date_From.Size = new System.Drawing.Size(135, 35);
            this.Date_From.TabIndex = 6;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel2.Controls.Add(this.check_Card);
            this.flowLayoutPanel2.Controls.Add(this.check_Check);
            this.flowLayoutPanel2.Controls.Add(this.check_Fish);
            this.flowLayoutPanel2.Controls.Add(this.check_Pure);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(163, 4);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(129, 158);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // check_Card
            // 
            this.check_Card.AutoSize = true;
            this.check_Card.Location = new System.Drawing.Point(11, 3);
            this.check_Card.Name = "check_Card";
            this.check_Card.Size = new System.Drawing.Size(115, 32);
            this.check_Card.TabIndex = 2;
            this.check_Card.Text = "کارت به کارت";
            this.check_Card.UseVisualStyleBackColor = true;
            // 
            // check_Check
            // 
            this.check_Check.AutoSize = true;
            this.check_Check.Location = new System.Drawing.Point(66, 41);
            this.check_Check.Name = "check_Check";
            this.check_Check.Size = new System.Drawing.Size(60, 32);
            this.check_Check.TabIndex = 0;
            this.check_Check.Text = "چک";
            this.check_Check.UseVisualStyleBackColor = true;
            // 
            // check_Fish
            // 
            this.check_Fish.AutoSize = true;
            this.check_Fish.Location = new System.Drawing.Point(28, 79);
            this.check_Fish.Name = "check_Fish";
            this.check_Fish.Size = new System.Drawing.Size(98, 32);
            this.check_Fish.TabIndex = 1;
            this.check_Fish.Text = "فیش بانکی";
            this.check_Fish.UseVisualStyleBackColor = true;
            // 
            // check_Pure
            // 
            this.check_Pure.AutoSize = true;
            this.check_Pure.Location = new System.Drawing.Point(62, 117);
            this.check_Pure.Name = "check_Pure";
            this.check_Pure.Size = new System.Drawing.Size(64, 32);
            this.check_Pure.TabIndex = 3;
            this.check_Pure.Text = "نقدی";
            this.check_Pure.UseVisualStyleBackColor = true;
            // 
            // BGW
            // 
            this.BGW.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BGW_DoWork);
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Grid_Payments
            // 
            this.Grid_Payments.AllowUserToAddRows = false;
            this.Grid_Payments.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("B Nazanin", 12F);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Orange;
            this.Grid_Payments.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Grid_Payments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Grid_Payments.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Grid_Payments.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("B Nazanin", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grid_Payments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Grid_Payments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Payments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Reason,
            this.Date,
            this.Cost,
            this.ID,
            this.Tooltip_});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("B Nazanin", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Grid_Payments.DefaultCellStyle = dataGridViewCellStyle4;
            this.Grid_Payments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grid_Payments.EnableHeadersVisualStyles = false;
            this.Grid_Payments.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.Grid_Payments.Location = new System.Drawing.Point(0, 69);
            this.Grid_Payments.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Grid_Payments.MultiSelect = false;
            this.Grid_Payments.Name = "Grid_Payments";
            this.Grid_Payments.ReadOnly = true;
            this.Grid_Payments.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("B Nazanin", 12F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grid_Payments.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("B Nazanin", 12F);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Orange;
            this.Grid_Payments.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.Grid_Payments.RowTemplate.Height = 24;
            this.Grid_Payments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid_Payments.Size = new System.Drawing.Size(938, 660);
            this.Grid_Payments.TabIndex = 14;
            this.Grid_Payments.TabStop = false;
            this.Grid_Payments.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_Payments_CellDoubleClick);
            this.Grid_Payments.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_Payments_CellMouseEnter);
            // 
            // Reason
            // 
            this.Reason.DataPropertyName = "Reason";
            this.Reason.FillWeight = 25F;
            this.Reason.HeaderText = "بابت";
            this.Reason.Name = "Reason";
            this.Reason.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.FillWeight = 15F;
            this.Date.HeaderText = "در تاریخ";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // Cost
            // 
            this.Cost.DataPropertyName = "Cost";
            this.Cost.FillWeight = 14.47723F;
            this.Cost.HeaderText = "به مبلغ";
            this.Cost.Name = "Cost";
            this.Cost.ReadOnly = true;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "Id";
            this.ID.HeaderText = "Column1";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // Tooltip_
            // 
            dataGridViewCellStyle3.NullValue = "...";
            this.Tooltip_.DefaultCellStyle = dataGridViewCellStyle3;
            this.Tooltip_.FillWeight = 10F;
            this.Tooltip_.HeaderText = "توضیحات";
            this.Tooltip_.Name = "Tooltip_";
            this.Tooltip_.ReadOnly = true;
            // 
            // Form_PaymentList
            // 
            this.AcceptButton = this.Btn_Search;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.CancelButton = this.btn_Back;
            this.ClientSize = new System.Drawing.Size(1244, 729);
            this.Controls.Add(this.Grid_Payments);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("B Nazanin", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form_PaymentList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_PaymentList";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form_PaymentList_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Payments)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_Search;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.CheckBox check_Card;
        private System.Windows.Forms.CheckBox check_Check;
        private System.Windows.Forms.CheckBox check_Fish;
        private System.Windows.Forms.CheckBox check_Pure;
        private System.ComponentModel.BackgroundWorker BGW;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private FarsiCalendarComponent.FarsiDatePicker Date_To;
        private FarsiCalendarComponent.FarsiDatePicker Date_From;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView Grid_Payments;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reason;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tooltip_;
    }
}