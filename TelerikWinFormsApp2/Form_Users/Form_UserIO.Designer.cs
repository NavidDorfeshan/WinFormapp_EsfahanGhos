namespace EsfahanGhos.Form_Users
{
    partial class Form_UserIO
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
            global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new global::System.Windows.Forms.DataGridViewCellStyle();
            global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new global::System.Windows.Forms.DataGridViewCellStyle();
            global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new global::System.Windows.Forms.DataGridViewCellStyle();
            global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new global::System.Windows.Forms.DataGridViewCellStyle();
            global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new global::System.Windows.Forms.DataGridViewCellStyle();
            this.office2007SilverTheme1 = new Telerik.WinControls.Themes.Office2007SilverTheme();
            this.GridIO = new global::System.Windows.Forms.DataGridView();
            this.BGW = new global::System.ComponentModel.BackgroundWorker();
            this.Row = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
            ((global::System.ComponentModel.ISupportInitialize)(this.GridIO)).BeginInit();
            ((global::System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // GridIO
            // 
            this.GridIO.AllowUserToAddRows = false;
            this.GridIO.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = global::System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new global::System.Drawing.Font("B Nazanin", 12F, global::System.Drawing.FontStyle.Bold);
            this.GridIO.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.GridIO.AutoSizeColumnsMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridIO.BackgroundColor = global::System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = global::System.Drawing.Color.Salmon;
            dataGridViewCellStyle2.Font = new global::System.Drawing.Font("B Nazanin", 10.8F, global::System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = global::System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = global::System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = global::System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = global::System.Windows.Forms.DataGridViewTriState.True;
            this.GridIO.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.GridIO.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridIO.Columns.AddRange(new global::System.Windows.Forms.DataGridViewColumn[] {
            this.Row,
            this.Description,
            this.Number,
            this.TotalPrice,
            this.Column1});
            dataGridViewCellStyle4.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = global::System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new global::System.Drawing.Font("B Nazanin", 10.8F, global::System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = global::System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = global::System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = global::System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = global::System.Windows.Forms.DataGridViewTriState.False;
            this.GridIO.DefaultCellStyle = dataGridViewCellStyle4;
            this.GridIO.Dock = global::System.Windows.Forms.DockStyle.Fill;
            this.GridIO.EnableHeadersVisualStyles = false;
            this.GridIO.GridColor = global::System.Drawing.SystemColors.AppWorkspace;
            this.GridIO.Location = new global::System.Drawing.Point(0, 0);
            this.GridIO.Margin = new global::System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GridIO.MultiSelect = false;
            this.GridIO.Name = "GridIO";
            this.GridIO.ReadOnly = true;
            this.GridIO.RightToLeft = global::System.Windows.Forms.RightToLeft.Yes;
            this.GridIO.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = global::System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new global::System.Drawing.Font("Adobe Arabic", 15F, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GridIO.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.GridIO.RowTemplate.DefaultCellStyle.Font = new global::System.Drawing.Font("Adobe Arabic", 15F, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GridIO.RowTemplate.Height = 30;
            this.GridIO.SelectionMode = global::System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridIO.Size = new global::System.Drawing.Size(754, 419);
            this.GridIO.TabIndex = 62;
            this.GridIO.TabStop = false;
            // 
            // BGW
            // 
            this.BGW.DoWork += new global::System.ComponentModel.DoWorkEventHandler(this.BGW_DoWork);
            this.BGW.RunWorkerCompleted += new global::System.ComponentModel.RunWorkerCompletedEventHandler(this.BGW_RunWorkerCompleted);
            // 
            // Row
            // 
            this.Row.FillWeight = 12F;
            this.Row.HeaderText = "ردیف";
            this.Row.Name = "Row";
            this.Row.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.FillWeight = 40F;
            this.Description.HeaderText = "نام و نام خانوادگی";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // Number
            // 
            dataGridViewCellStyle3.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Number.DefaultCellStyle = dataGridViewCellStyle3;
            this.Number.FillWeight = 30F;
            this.Number.HeaderText = "تاریخ";
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            // 
            // TotalPrice
            // 
            this.TotalPrice.FillWeight = 30F;
            this.TotalPrice.HeaderText = "ساعت ورود";
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 30F;
            this.Column1.HeaderText = "ساعت خروج";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Form_UserIO
            // 
            this.AutoScaleDimensions = new global::System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new global::System.Drawing.Size(754, 419);
            this.Controls.Add(this.GridIO);
            this.Font = new global::System.Drawing.Font("B Nazanin", 10.8F, global::System.Drawing.FontStyle.Bold);
            this.Name = "Form_UserIO";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "";
            this.ThemeName = "Office2007Silver";
            this.Load += new global::System.EventHandler(this.Form_UserIO_Load);
            ((global::System.ComponentModel.ISupportInitialize)(this.GridIO)).EndInit();
            ((global::System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.Themes.Office2007SilverTheme office2007SilverTheme1;
        private global::System.Windows.Forms.DataGridView GridIO;
        private global::System.ComponentModel.BackgroundWorker BGW;
        private global::System.Windows.Forms.DataGridViewTextBoxColumn Row;
        private global::System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private global::System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private global::System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
        private global::System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}
