namespace EsfahanGhos
{
    partial class Form_Person
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Person));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Grid_People = new System.Windows.Forms.DataGridView();
            this.radif = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.National_Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cell_Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Txt_Address = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.Txt_Date = new FarsiCalendarComponent.FarsiDatePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.Txt_Phone = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.Txt_Cell = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.Txt_NumChild = new System.Windows.Forms.TextBox();
            this.Lbl1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Combo_StatusMarried = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Txt_Shenasname = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_NationalCode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_FatherName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_FName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Btn_Register = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Btn_Edit = new System.Windows.Forms.Button();
            this.Btn_Delete = new System.Windows.Forms.Button();
            this.Btn_ListPeople = new System.Windows.Forms.Button();
            this.Btn_Back = new System.Windows.Forms.Button();
            this.BGW = new System.ComponentModel.BackgroundWorker();
            this.aquaTheme1 = new Telerik.WinControls.Themes.AquaTheme();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_People)).BeginInit();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
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
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.SeaShell;
            this.splitContainer1.Panel1.Controls.Add(this.Grid_People);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.flowLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(1413, 721);
            this.splitContainer1.SplitterDistance = 1208;
            this.splitContainer1.TabIndex = 0;
            // 
            // Grid_People
            // 
            this.Grid_People.AllowUserToAddRows = false;
            this.Grid_People.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("B Nazanin", 12F);
            this.Grid_People.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Grid_People.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Grid_People.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Grid_People.BackgroundColor = System.Drawing.Color.White;
            this.Grid_People.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Grid_People.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("B Nazanin", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
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
            this.Grid_People.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("B Nazanin", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Grid_People.DefaultCellStyle = dataGridViewCellStyle4;
            this.Grid_People.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grid_People.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.Grid_People.EnableHeadersVisualStyles = false;
            this.Grid_People.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.Grid_People.Location = new System.Drawing.Point(0, 205);
            this.Grid_People.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Grid_People.MultiSelect = false;
            this.Grid_People.Name = "Grid_People";
            this.Grid_People.ReadOnly = true;
            this.Grid_People.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("B Nazanin", 12F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grid_People.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("B Nazanin", 12F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.Grid_People.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.Grid_People.RowTemplate.Height = 24;
            this.Grid_People.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid_People.Size = new System.Drawing.Size(1208, 516);
            this.Grid_People.TabIndex = 13;
            this.Grid_People.TabStop = false;
            this.Grid_People.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridPeople_CellClick);
            // 
            // radif
            // 
            this.radif.FillWeight = 7.238616F;
            this.radif.HeaderText = "ردیف";
            this.radif.Name = "radif";
            this.radif.ReadOnly = true;
            // 
            // Name_
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Name_.DefaultCellStyle = dataGridViewCellStyle3;
            this.Name_.FillWeight = 16F;
            this.Name_.HeaderText = "نام و نام خانوادگی";
            this.Name_.Name = "Name_";
            this.Name_.ReadOnly = true;
            // 
            // National_Code
            // 
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
            this.ID.HeaderText = "Column1";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.Txt_Address);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.Txt_Date);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.Txt_Phone);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.Txt_Cell);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.Txt_NumChild);
            this.panel1.Controls.Add(this.Lbl1);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.Combo_StatusMarried);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.Txt_Shenasname);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Txt_NationalCode);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Txt_FatherName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Txt_FName);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel1.Size = new System.Drawing.Size(1208, 205);
            this.panel1.TabIndex = 0;
            // 
            // Txt_Address
            // 
            this.Txt_Address.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_Address.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.Txt_Address.Location = new System.Drawing.Point(139, 132);
            this.Txt_Address.Multiline = true;
            this.Txt_Address.Name = "Txt_Address";
            this.Txt_Address.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Txt_Address.Size = new System.Drawing.Size(907, 34);
            this.Txt_Address.TabIndex = 9;
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label17.Location = new System.Drawing.Point(1053, 135);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(57, 29);
            this.label17.TabIndex = 71;
            this.label17.Text = "آدرس :";
            // 
            // Txt_Date
            // 
            this.Txt_Date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_Date.GeoDate = new System.DateTime(2015, 6, 26, 0, 0, 0, 0);
            this.Txt_Date.Location = new System.Drawing.Point(139, 95);
            this.Txt_Date.Margin = new System.Windows.Forms.Padding(14, 24, 14, 24);
            this.Txt_Date.MaximumSize = new System.Drawing.Size(4500, 154);
            this.Txt_Date.Name = "Txt_Date";
            this.Txt_Date.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Txt_Date.Size = new System.Drawing.Size(215, 34);
            this.Txt_Date.TabIndex = 8;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label15.Location = new System.Drawing.Point(360, 100);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(80, 29);
            this.label15.TabIndex = 69;
            this.label15.Text = "تاریخ تولد :";
            // 
            // Txt_Phone
            // 
            this.Txt_Phone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_Phone.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.Txt_Phone.Location = new System.Drawing.Point(496, 95);
            this.Txt_Phone.Multiline = true;
            this.Txt_Phone.Name = "Txt_Phone";
            this.Txt_Phone.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Txt_Phone.Size = new System.Drawing.Size(215, 34);
            this.Txt_Phone.TabIndex = 7;
            this.Txt_Phone.TextChanged += new System.EventHandler(this.Txt_Phone_TextChanged);
            this.Txt_Phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Number_KeyPress);
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label16.Location = new System.Drawing.Point(717, 97);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(81, 29);
            this.label16.TabIndex = 68;
            this.label16.Text = "تلفن ثابت :";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(802, 95);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(23, 29);
            this.label13.TabIndex = 66;
            this.label13.Text = "*";
            // 
            // Txt_Cell
            // 
            this.Txt_Cell.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_Cell.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.Txt_Cell.Location = new System.Drawing.Point(831, 92);
            this.Txt_Cell.Multiline = true;
            this.Txt_Cell.Name = "Txt_Cell";
            this.Txt_Cell.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Txt_Cell.Size = new System.Drawing.Size(215, 34);
            this.Txt_Cell.TabIndex = 6;
            this.Txt_Cell.TextChanged += new System.EventHandler(this.Txt_Cell_TextChanged);
            this.Txt_Cell.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Number_KeyPress);
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label14.Location = new System.Drawing.Point(1053, 95);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(88, 29);
            this.label14.TabIndex = 65;
            this.label14.Text = "تلفن همراه :";
            // 
            // Txt_NumChild
            // 
            this.Txt_NumChild.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_NumChild.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.Txt_NumChild.Location = new System.Drawing.Point(139, 52);
            this.Txt_NumChild.Multiline = true;
            this.Txt_NumChild.Name = "Txt_NumChild";
            this.Txt_NumChild.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Txt_NumChild.Size = new System.Drawing.Size(215, 34);
            this.Txt_NumChild.TabIndex = 5;
            this.Txt_NumChild.Visible = false;
            this.Txt_NumChild.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Number_KeyPress);
            // 
            // Lbl1
            // 
            this.Lbl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl1.AutoSize = true;
            this.Lbl1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Lbl1.Location = new System.Drawing.Point(360, 55);
            this.Lbl1.Name = "Lbl1";
            this.Lbl1.Size = new System.Drawing.Size(102, 29);
            this.Lbl1.TabIndex = 62;
            this.Lbl1.Text = "تعداد فرزندان :";
            this.Lbl1.Visible = false;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(467, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 29);
            this.label9.TabIndex = 60;
            this.label9.Text = "*";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label8.Location = new System.Drawing.Point(698, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 29);
            this.label8.TabIndex = 59;
            this.label8.Text = "وضعیت تاهل :";
            // 
            // Combo_StatusMarried
            // 
            this.Combo_StatusMarried.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Combo_StatusMarried.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Combo_StatusMarried.FormattingEnabled = true;
            this.Combo_StatusMarried.Items.AddRange(new object[] {
            "مجرد ",
            "متاهل"});
            this.Combo_StatusMarried.Location = new System.Drawing.Point(496, 52);
            this.Combo_StatusMarried.Name = "Combo_StatusMarried";
            this.Combo_StatusMarried.Size = new System.Drawing.Size(121, 37);
            this.Combo_StatusMarried.TabIndex = 4;
            this.Combo_StatusMarried.SelectedIndexChanged += new System.EventHandler(this.Combo_StatusMarried_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(802, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 29);
            this.label6.TabIndex = 57;
            this.label6.Text = "*";
            // 
            // Txt_Shenasname
            // 
            this.Txt_Shenasname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_Shenasname.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.Txt_Shenasname.Location = new System.Drawing.Point(831, 52);
            this.Txt_Shenasname.Multiline = true;
            this.Txt_Shenasname.Name = "Txt_Shenasname";
            this.Txt_Shenasname.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Txt_Shenasname.Size = new System.Drawing.Size(215, 34);
            this.Txt_Shenasname.TabIndex = 3;
            this.Txt_Shenasname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Number_KeyPress);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label7.Location = new System.Drawing.Point(1053, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 29);
            this.label7.TabIndex = 56;
            this.label7.Text = "شماره شناسنامه :";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(110, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 29);
            this.label4.TabIndex = 54;
            this.label4.Text = "*";
            // 
            // Txt_NationalCode
            // 
            this.Txt_NationalCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_NationalCode.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.Txt_NationalCode.Location = new System.Drawing.Point(139, 12);
            this.Txt_NationalCode.Multiline = true;
            this.Txt_NationalCode.Name = "Txt_NationalCode";
            this.Txt_NationalCode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Txt_NationalCode.Size = new System.Drawing.Size(215, 34);
            this.Txt_NationalCode.TabIndex = 2;
            this.Txt_NationalCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Number_KeyPress);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Location = new System.Drawing.Point(360, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 29);
            this.label5.TabIndex = 53;
            this.label5.Text = "کد ملی :";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(467, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 29);
            this.label1.TabIndex = 51;
            this.label1.Text = "*";
            // 
            // Txt_FatherName
            // 
            this.Txt_FatherName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_FatherName.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.Txt_FatherName.Location = new System.Drawing.Point(496, 12);
            this.Txt_FatherName.Multiline = true;
            this.Txt_FatherName.Name = "Txt_FatherName";
            this.Txt_FatherName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Txt_FatherName.Size = new System.Drawing.Size(215, 34);
            this.Txt_FatherName.TabIndex = 1;
            this.Txt_FatherName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Alphabet_KeyPress);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Location = new System.Drawing.Point(717, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 29);
            this.label2.TabIndex = 50;
            this.label2.Text = "نام پدر :";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(802, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 29);
            this.label3.TabIndex = 48;
            this.label3.Text = "*";
            // 
            // Txt_FName
            // 
            this.Txt_FName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_FName.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.Txt_FName.Location = new System.Drawing.Point(831, 12);
            this.Txt_FName.Multiline = true;
            this.Txt_FName.Name = "Txt_FName";
            this.Txt_FName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Txt_FName.Size = new System.Drawing.Size(215, 34);
            this.Txt_FName.TabIndex = 0;
            this.Txt_FName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Alphabet_KeyPress);
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label10.Location = new System.Drawing.Point(1053, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 29);
            this.label10.TabIndex = 47;
            this.label10.Text = "نام و نام خانوادگی :";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.Btn_Register);
            this.flowLayoutPanel1.Controls.Add(this.Btn_Edit);
            this.flowLayoutPanel1.Controls.Add(this.Btn_Delete);
            this.flowLayoutPanel1.Controls.Add(this.Btn_ListPeople);
            this.flowLayoutPanel1.Controls.Add(this.Btn_Back);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(201, 721);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // Btn_Register
            // 
            this.Btn_Register.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Register.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Btn_Register.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Register.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.Btn_Register.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Btn_Register.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.Btn_Register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Register.Font = new System.Drawing.Font("B Nazanin", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Btn_Register.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Register.ImageKey = "add-icon.png";
            this.Btn_Register.ImageList = this.imageList1;
            this.Btn_Register.Location = new System.Drawing.Point(3, 3);
            this.Btn_Register.Name = "Btn_Register";
            this.Btn_Register.Size = new System.Drawing.Size(195, 63);
            this.Btn_Register.TabIndex = 0;
            this.Btn_Register.Text = "ثبت";
            this.Btn_Register.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Register.UseVisualStyleBackColor = false;
            this.Btn_Register.Click += new System.EventHandler(this.Btn_Register_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "add-icon.png");
            this.imageList1.Images.SetKeyName(1, "bigstock-magnifying-glass-as-search-ico-15600446.jpg");
            this.imageList1.Images.SetKeyName(2, "Custom-Icon-Design-Flatastic-3-Signup.ico");
            this.imageList1.Images.SetKeyName(3, "Semlabs-Web-Blog-Arrow-return-down-right.ico");
            this.imageList1.Images.SetKeyName(4, "Icontexto-Search-Search-black.ico");
            this.imageList1.Images.SetKeyName(5, "Oxygen-Icons.org-Oxygen-Actions-edit-delete.ico");
            // 
            // Btn_Edit
            // 
            this.Btn_Edit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Edit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Btn_Edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Edit.Enabled = false;
            this.Btn_Edit.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.Btn_Edit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Btn_Edit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.Btn_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Edit.Font = new System.Drawing.Font("B Nazanin", 13.8F, System.Drawing.FontStyle.Bold);
            this.Btn_Edit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Edit.ImageKey = "Custom-Icon-Design-Flatastic-3-Signup.ico";
            this.Btn_Edit.ImageList = this.imageList1;
            this.Btn_Edit.Location = new System.Drawing.Point(3, 72);
            this.Btn_Edit.Name = "Btn_Edit";
            this.Btn_Edit.Size = new System.Drawing.Size(195, 63);
            this.Btn_Edit.TabIndex = 1;
            this.Btn_Edit.Text = "ویرایش";
            this.Btn_Edit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Edit.UseVisualStyleBackColor = false;
            this.Btn_Edit.Click += new System.EventHandler(this.Btn_Edit_Click);
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Delete.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Btn_Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Delete.Enabled = false;
            this.Btn_Delete.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.Btn_Delete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Btn_Delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.Btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Delete.Font = new System.Drawing.Font("B Nazanin", 13.8F, System.Drawing.FontStyle.Bold);
            this.Btn_Delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Delete.ImageKey = "Oxygen-Icons.org-Oxygen-Actions-edit-delete.ico";
            this.Btn_Delete.ImageList = this.imageList1;
            this.Btn_Delete.Location = new System.Drawing.Point(3, 141);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(195, 63);
            this.Btn_Delete.TabIndex = 4;
            this.Btn_Delete.Text = "حذف";
            this.Btn_Delete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Delete.UseVisualStyleBackColor = false;
            // 
            // Btn_ListPeople
            // 
            this.Btn_ListPeople.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_ListPeople.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Btn_ListPeople.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_ListPeople.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.Btn_ListPeople.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Btn_ListPeople.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.Btn_ListPeople.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_ListPeople.Font = new System.Drawing.Font("B Nazanin", 13.8F, System.Drawing.FontStyle.Bold);
            this.Btn_ListPeople.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_ListPeople.ImageKey = "Icontexto-Search-Search-black.ico";
            this.Btn_ListPeople.ImageList = this.imageList1;
            this.Btn_ListPeople.Location = new System.Drawing.Point(3, 210);
            this.Btn_ListPeople.Name = "Btn_ListPeople";
            this.Btn_ListPeople.Size = new System.Drawing.Size(195, 63);
            this.Btn_ListPeople.TabIndex = 2;
            this.Btn_ListPeople.Text = "لیست کارکنان";
            this.Btn_ListPeople.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_ListPeople.UseVisualStyleBackColor = false;
            this.Btn_ListPeople.Click += new System.EventHandler(this.Btn_ListPeople_Click);
            // 
            // Btn_Back
            // 
            this.Btn_Back.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Back.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Btn_Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Back.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.Btn_Back.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Btn_Back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.Btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Back.Font = new System.Drawing.Font("B Nazanin", 13.8F, System.Drawing.FontStyle.Bold);
            this.Btn_Back.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Back.ImageKey = "Semlabs-Web-Blog-Arrow-return-down-right.ico";
            this.Btn_Back.ImageList = this.imageList1;
            this.Btn_Back.Location = new System.Drawing.Point(3, 279);
            this.Btn_Back.Name = "Btn_Back";
            this.Btn_Back.Size = new System.Drawing.Size(195, 63);
            this.Btn_Back.TabIndex = 3;
            this.Btn_Back.Text = "بازگشت";
            this.Btn_Back.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Back.UseVisualStyleBackColor = false;
            this.Btn_Back.Click += new System.EventHandler(this.Btn_Back_Click);
            // 
            // BGW
            // 
            this.BGW.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BGW_DoWork);
            this.BGW.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BGW_RunWorkerCompleted);
            // 
            // Form_Person
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1413, 721);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("B Nazanin", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form_Person";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form_Person_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_People)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button Btn_Register;
        private System.Windows.Forms.Button Btn_Edit;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button Btn_Back;
        private System.Windows.Forms.Button Btn_ListPeople;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_FName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_FatherName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_NationalCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txt_NumChild;
        private System.Windows.Forms.Label Lbl1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox Combo_StatusMarried;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Txt_Shenasname;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Txt_Phone;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox Txt_Cell;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private FarsiCalendarComponent.FarsiDatePicker Txt_Date;
        private System.Windows.Forms.TextBox Txt_Address;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DataGridView Grid_People;
        private System.ComponentModel.BackgroundWorker BGW;
        private Telerik.WinControls.Themes.AquaTheme aquaTheme1;
        private System.Windows.Forms.DataGridViewTextBoxColumn radif;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_;
        private System.Windows.Forms.DataGridViewTextBoxColumn National_Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cell_Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.Button Btn_Delete;
    }
}