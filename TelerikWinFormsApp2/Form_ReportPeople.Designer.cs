namespace EsfahanGhos
{
    partial class Form_ReportPeople
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ReportPeople));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.BGW = new System.ComponentModel.BackgroundWorker();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.aquaTheme1 = new Telerik.WinControls.Themes.AquaTheme();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Grid_People = new System.Windows.Forms.DataGridView();
            this.radif = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.National_Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cell_Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lBL = new System.Windows.Forms.Label();
            this.Combo_Project = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Btn_Back = new System.Windows.Forms.Button();
            this.Btn_Search = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_NationalCode = new System.Windows.Forms.TextBox();
            this.Txt_Cell = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.Txt_FatherName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_FName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_People)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "add-icon.png");
            this.imageList1.Images.SetKeyName(1, "Semlabs-Web-Blog-Arrow-return-down-right.ico");
            this.imageList1.Images.SetKeyName(2, "Oxygen-Icons.org-Oxygen-Actions-edit-delete (1).ico");
            this.imageList1.Images.SetKeyName(3, "Icontexto-Search-Search-black.ico");
            this.imageList1.Images.SetKeyName(4, "Custom-Icon-Design-Flatastic-3-Signup.ico");
            // 
            // BGW
            // 
            this.BGW.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BGW_DoWork);
            this.BGW.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BGW_RunWorkerCompleted);
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "راهنمایی";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel1.Controls.Add(this.Grid_People);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(1336, 713);
            this.splitContainer1.SplitterDistance = 947;
            this.splitContainer1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(344, 260);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(163, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // Grid_People
            // 
            this.Grid_People.AllowUserToAddRows = false;
            this.Grid_People.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("B Nazanin", 10.8F);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Orange;
            this.Grid_People.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Grid_People.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Grid_People.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Grid_People.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("B Nazanin", 10.8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grid_People.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Grid_People.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_People.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.radif,
            this.Name_,
            this.National_Code,
            this.Cell_Phone,
            this.Date_,
            this.ID});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("B Nazanin", 10.8F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Grid_People.DefaultCellStyle = dataGridViewCellStyle4;
            this.Grid_People.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grid_People.EnableHeadersVisualStyles = false;
            this.Grid_People.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.Grid_People.Location = new System.Drawing.Point(0, 0);
            this.Grid_People.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Grid_People.MultiSelect = false;
            this.Grid_People.Name = "Grid_People";
            this.Grid_People.ReadOnly = true;
            this.Grid_People.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Grid_People.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("B Nazanin", 10.8F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grid_People.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("B Nazanin", 10.8F);
            this.Grid_People.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.Grid_People.RowTemplate.Height = 24;
            this.Grid_People.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid_People.Size = new System.Drawing.Size(947, 713);
            this.Grid_People.TabIndex = 14;
            this.Grid_People.TabStop = false;
            this.Grid_People.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_People_CellDoubleClick);
            // 
            // radif
            // 
            this.radif.DataPropertyName = "EmployeeID";
            this.radif.FillWeight = 7.238616F;
            this.radif.HeaderText = "ردیف";
            this.radif.Name = "radif";
            this.radif.ReadOnly = true;
            // 
            // Name_
            // 
            this.Name_.DataPropertyName = "EmployeeFullName";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Name_.DefaultCellStyle = dataGridViewCellStyle3;
            this.Name_.FillWeight = 16F;
            this.Name_.HeaderText = "نام و نام خانوادگی";
            this.Name_.Name = "Name_";
            this.Name_.ReadOnly = true;
            // 
            // National_Code
            // 
            this.National_Code.DataPropertyName = "EmployeeNationalCode";
            this.National_Code.FillWeight = 15F;
            this.National_Code.HeaderText = "کدملی";
            this.National_Code.Name = "National_Code";
            this.National_Code.ReadOnly = true;
            // 
            // Cell_Phone
            // 
            this.Cell_Phone.FillWeight = 20.27641F;
            this.Cell_Phone.HeaderText = "تلفن همراه";
            this.Cell_Phone.Name = "Cell_Phone";
            this.Cell_Phone.ReadOnly = true;
            // 
            // Date_
            // 
            this.Date_.FillWeight = 14.47723F;
            this.Date_.HeaderText = "تاریخ تولد";
            this.Date_.Name = "Date_";
            this.Date_.ReadOnly = true;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "EmployeeID";
            this.ID.HeaderText = "Column1";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Snow;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lBL);
            this.panel1.Controls.Add(this.Combo_Project);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.Txt_NationalCode);
            this.panel1.Controls.Add(this.Txt_Cell);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.Txt_FatherName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Txt_FName);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel1.Size = new System.Drawing.Size(385, 713);
            this.panel1.TabIndex = 0;
            // 
            // lBL
            // 
            this.lBL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lBL.AutoSize = true;
            this.lBL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lBL.Location = new System.Drawing.Point(244, 173);
            this.lBL.Name = "lBL";
            this.lBL.Size = new System.Drawing.Size(56, 30);
            this.lBL.TabIndex = 75;
            this.lBL.Text = "پروژه :";
            // 
            // Combo_Project
            // 
            this.Combo_Project.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Combo_Project.BackColor = System.Drawing.Color.AliceBlue;
            this.Combo_Project.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Combo_Project.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Combo_Project.ForeColor = System.Drawing.Color.Black;
            this.Combo_Project.FormattingEnabled = true;
            this.Combo_Project.Location = new System.Drawing.Point(21, 170);
            this.Combo_Project.Name = "Combo_Project";
            this.Combo_Project.Size = new System.Drawing.Size(215, 37);
            this.Combo_Project.TabIndex = 74;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.Btn_Back);
            this.panel2.Controls.Add(this.Btn_Search);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 228);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(381, 481);
            this.panel2.TabIndex = 73;
            // 
            // Btn_Back
            // 
            this.Btn_Back.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Back.BackColor = System.Drawing.Color.Snow;
            this.Btn_Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Back.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Btn_Back.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.Btn_Back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.Btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Back.Font = new System.Drawing.Font("B Nazanin", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Btn_Back.ImageKey = "Semlabs-Web-Blog-Arrow-return-down-right.ico";
            this.Btn_Back.ImageList = this.imageList1;
            this.Btn_Back.Location = new System.Drawing.Point(3, 72);
            this.Btn_Back.Name = "Btn_Back";
            this.Btn_Back.Size = new System.Drawing.Size(373, 63);
            this.Btn_Back.TabIndex = 75;
            this.Btn_Back.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Back.UseVisualStyleBackColor = false;
            this.Btn_Back.Click += new System.EventHandler(this.Btn_Back_Click);
            // 
            // Btn_Search
            // 
            this.Btn_Search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Search.BackColor = System.Drawing.Color.Snow;
            this.Btn_Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Search.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Btn_Search.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.Btn_Search.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.Btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Search.Font = new System.Drawing.Font("B Nazanin", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Btn_Search.ImageKey = "Icontexto-Search-Search-black.ico";
            this.Btn_Search.ImageList = this.imageList1;
            this.Btn_Search.Location = new System.Drawing.Point(4, 3);
            this.Btn_Search.Name = "Btn_Search";
            this.Btn_Search.Size = new System.Drawing.Size(373, 63);
            this.Btn_Search.TabIndex = 73;
            this.Btn_Search.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Search.UseVisualStyleBackColor = false;
            this.Btn_Search.Click += new System.EventHandler(this.Btn_Search_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Location = new System.Drawing.Point(244, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 30);
            this.label5.TabIndex = 54;
            this.label5.Text = "کد ملی :";
            // 
            // Txt_NationalCode
            // 
            this.Txt_NationalCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_NationalCode.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.Txt_NationalCode.Location = new System.Drawing.Point(21, 90);
            this.Txt_NationalCode.Multiline = true;
            this.Txt_NationalCode.Name = "Txt_NationalCode";
            this.Txt_NationalCode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Txt_NationalCode.Size = new System.Drawing.Size(215, 34);
            this.Txt_NationalCode.TabIndex = 53;
            this.Txt_NationalCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_NationalCode_KeyPress);
            // 
            // Txt_Cell
            // 
            this.Txt_Cell.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_Cell.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.Txt_Cell.Location = new System.Drawing.Point(21, 130);
            this.Txt_Cell.Multiline = true;
            this.Txt_Cell.Name = "Txt_Cell";
            this.Txt_Cell.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Txt_Cell.Size = new System.Drawing.Size(215, 34);
            this.Txt_Cell.TabIndex = 69;
            this.Txt_Cell.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_NationalCode_KeyPress);
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label14.Location = new System.Drawing.Point(243, 133);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(92, 30);
            this.label14.TabIndex = 71;
            this.label14.Text = "تلفن همراه :";
            // 
            // Txt_FatherName
            // 
            this.Txt_FatherName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_FatherName.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.Txt_FatherName.Location = new System.Drawing.Point(21, 50);
            this.Txt_FatherName.Multiline = true;
            this.Txt_FatherName.Name = "Txt_FatherName";
            this.Txt_FatherName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Txt_FatherName.Size = new System.Drawing.Size(215, 34);
            this.Txt_FatherName.TabIndex = 51;
            this.Txt_FatherName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_FName_KeyPress);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Location = new System.Drawing.Point(243, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 30);
            this.label2.TabIndex = 52;
            this.label2.Text = "نام پدر :";
            // 
            // Txt_FName
            // 
            this.Txt_FName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_FName.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.Txt_FName.Location = new System.Drawing.Point(21, 10);
            this.Txt_FName.Multiline = true;
            this.Txt_FName.Name = "Txt_FName";
            this.Txt_FName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Txt_FName.Size = new System.Drawing.Size(215, 34);
            this.Txt_FName.TabIndex = 48;
            this.Txt_FName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_FName_KeyPress);
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label10.Location = new System.Drawing.Point(243, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(133, 30);
            this.label10.TabIndex = 49;
            this.label10.Text = "نام و نام خانوادگی :";
            // 
            // Form_ReportPeople
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1336, 713);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("B Nazanin", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form_ReportPeople";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_ReportPeople";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form_ReportPeople_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_People)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.ComponentModel.BackgroundWorker BGW;
        private System.Windows.Forms.ToolTip toolTip1;
        private Telerik.WinControls.Themes.AquaTheme aquaTheme1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView Grid_People;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Txt_FName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Txt_FatherName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_NationalCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txt_Cell;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Btn_Search;
        private System.Windows.Forms.Button Btn_Back;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lBL;
        private System.Windows.Forms.ComboBox Combo_Project;
        private System.Windows.Forms.DataGridViewTextBoxColumn radif;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_;
        private System.Windows.Forms.DataGridViewTextBoxColumn National_Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cell_Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
    }
}