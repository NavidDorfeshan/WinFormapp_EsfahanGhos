namespace EsfahanGhos
{
    partial class Form_RegSourceStorage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_RegSourceStorage));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Btn_Reg = new Telerik.WinControls.UI.RadButton();
            this.Btn_OpenRegTypeStorage = new Telerik.WinControls.UI.RadButton();
            this.ComboTypeStorage = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GridItem = new System.Windows.Forms.DataGridView();
            this.GridItemRowS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridItemDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Combounit = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridItemRemove = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aquaTheme1 = new Telerik.WinControls.Themes.AquaTheme();
            this.BGW = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Reg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_OpenRegTypeStorage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridItem)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Font = new System.Drawing.Font("B Nazanin", 12F);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel2.Controls.Add(this.GridItem);
            this.splitContainer1.Panel2.Font = new System.Drawing.Font("B Nazanin", 12F);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.Size = new System.Drawing.Size(1277, 677);
            this.splitContainer1.SplitterDistance = 92;
            this.splitContainer1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1277, 92);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Btn_Reg);
            this.groupBox1.Controls.Add(this.Btn_OpenRegTypeStorage);
            this.groupBox1.Controls.Add(this.ComboTypeStorage);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(1275, 90);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "اطلاعات";
            // 
            // Btn_Reg
            // 
            this.Btn_Reg.Font = new System.Drawing.Font("B Nazanin", 12F);
            this.Btn_Reg.Location = new System.Drawing.Point(11, 28);
            this.Btn_Reg.Name = "Btn_Reg";
            this.Btn_Reg.Size = new System.Drawing.Size(93, 45);
            this.Btn_Reg.TabIndex = 3;
            this.Btn_Reg.Text = "ثبت";
            this.Btn_Reg.ThemeName = "Aqua";
            this.Btn_Reg.Click += new System.EventHandler(this.Btn_Reg_Click);
            // 
            // Btn_OpenRegTypeStorage
            // 
            this.Btn_OpenRegTypeStorage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_OpenRegTypeStorage.Location = new System.Drawing.Point(910, 36);
            this.Btn_OpenRegTypeStorage.Name = "Btn_OpenRegTypeStorage";
            this.Btn_OpenRegTypeStorage.Size = new System.Drawing.Size(54, 37);
            this.Btn_OpenRegTypeStorage.TabIndex = 2;
            this.Btn_OpenRegTypeStorage.Text = "...";
            this.Btn_OpenRegTypeStorage.ThemeName = "Aqua";
            this.Btn_OpenRegTypeStorage.Click += new System.EventHandler(this.Btn_OpenRegTypeStorage_Click);
            // 
            // ComboTypeStorage
            // 
            this.ComboTypeStorage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboTypeStorage.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.ComboTypeStorage.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboTypeStorage.Font = new System.Drawing.Font("B Nazanin", 12F);
            this.ComboTypeStorage.FormattingEnabled = true;
            this.ComboTypeStorage.Location = new System.Drawing.Point(976, 36);
            this.ComboTypeStorage.Name = "ComboTypeStorage";
            this.ComboTypeStorage.Size = new System.Drawing.Size(161, 37);
            this.ComboTypeStorage.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1143, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "نوع دسته بندی :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(580, 240);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // GridItem
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("B Nazanin", 12F);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Orange;
            this.GridItem.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.GridItem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridItem.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GridItem.BackgroundColor = System.Drawing.Color.White;
            this.GridItem.CausesValidation = false;
            this.GridItem.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("B Nazanin", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridItem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.GridItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GridItemRowS,
            this.Id,
            this.GridItemDescription,
            this.Combounit,
            this.Count,
            this.TotalCount,
            this.GridItemRemove});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("B Nazanin", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridItem.DefaultCellStyle = dataGridViewCellStyle3;
            this.GridItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridItem.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.GridItem.EnableHeadersVisualStyles = false;
            this.GridItem.GridColor = System.Drawing.Color.WhiteSmoke;
            this.GridItem.Location = new System.Drawing.Point(0, 0);
            this.GridItem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GridItem.MultiSelect = false;
            this.GridItem.Name = "GridItem";
            this.GridItem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("B Nazanin", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridItem.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("B Nazanin", 12F);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Orange;
            this.GridItem.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.GridItem.RowTemplate.Height = 24;
            this.GridItem.Size = new System.Drawing.Size(1277, 581);
            this.GridItem.TabIndex = 13;
            this.GridItem.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridItem_CellEndEdit);
            this.GridItem.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridItem_CellEnter);
            this.GridItem.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GridItem_CellMouseClick);
            this.GridItem.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.GridItem_CellPainting);
            this.GridItem.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.GridItem_RowsAdded);
            this.GridItem.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GridItem_KeyUp);
            // 
            // GridItemRowS
            // 
            this.GridItemRowS.FillWeight = 30F;
            this.GridItemRowS.HeaderText = "ردیف";
            this.GridItemRowS.Name = "GridItemRowS";
            this.GridItemRowS.ReadOnly = true;
            // 
            // Id
            // 
            this.Id.FillWeight = 50F;
            this.Id.HeaderText = "کد کالا";
            this.Id.Name = "Id";
            // 
            // GridItemDescription
            // 
            this.GridItemDescription.FillWeight = 120F;
            this.GridItemDescription.HeaderText = "شرح";
            this.GridItemDescription.Name = "GridItemDescription";
            // 
            // Combounit
            // 
            this.Combounit.FillWeight = 40F;
            this.Combounit.HeaderText = "واحد";
            this.Combounit.Name = "Combounit";
            // 
            // Count
            // 
            this.Count.FillWeight = 50F;
            this.Count.HeaderText = "مقدار";
            this.Count.Name = "Count";
            // 
            // TotalCount
            // 
            this.TotalCount.FillWeight = 50F;
            this.TotalCount.HeaderText = "تعداد کل";
            this.TotalCount.Name = "TotalCount";
            // 
            // GridItemRemove
            // 
            this.GridItemRemove.FillWeight = 10F;
            this.GridItemRemove.HeaderText = "...";
            this.GridItemRemove.Name = "GridItemRemove";
            this.GridItemRemove.ReadOnly = true;
            // 
            // BGW
            // 
            this.BGW.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BGW_DoWork);
            this.BGW.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BGW_RunWorkerCompleted);
            // 
            // Form_RegSourceStorage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 677);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form_RegSourceStorage";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form_RegSourceStorage_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Reg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_OpenRegTypeStorage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView GridItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private Telerik.WinControls.UI.RadButton Btn_OpenRegTypeStorage;
        private System.Windows.Forms.ComboBox ComboTypeStorage;
        private System.Windows.Forms.Label label1;
        private Telerik.WinControls.UI.RadButton Btn_Reg;
        private Telerik.WinControls.Themes.AquaTheme aquaTheme1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker BGW;
        private System.Windows.Forms.DataGridViewTextBoxColumn GridItemRowS;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn GridItemDescription;
        private System.Windows.Forms.DataGridViewComboBoxColumn Combounit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn GridItemRemove;
    }
}