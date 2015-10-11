namespace EsfahanGhos.Form_Users
{
    partial class Form_Acess
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
            global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new global::System.Windows.Forms.DataGridViewCellStyle();
            global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new global::System.Windows.Forms.DataGridViewCellStyle();
            this.office2007SilverTheme1 = new Telerik.WinControls.Themes.Office2007SilverTheme();
            this.groupBox1 = new global::System.Windows.Forms.GroupBox();
            this.Btn_Register = new Telerik.WinControls.UI.RadButton();
            this.label2 = new global::System.Windows.Forms.Label();
            this.Txt_UserName = new global::System.Windows.Forms.TextBox();
            this.label1 = new global::System.Windows.Forms.Label();
            this.Txt_Fname = new global::System.Windows.Forms.TextBox();
            this.GridAcess = new global::System.Windows.Forms.DataGridView();
            this.Column1 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new global::System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.BGW = new global::System.ComponentModel.BackgroundWorker();
            this.aquaTheme1 = new Telerik.WinControls.Themes.AquaTheme();
            this.groupBox1.SuspendLayout();
            ((global::System.ComponentModel.ISupportInitialize)(this.Btn_Register)).BeginInit();
            ((global::System.ComponentModel.ISupportInitialize)(this.GridAcess)).BeginInit();
            ((global::System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((global::System.Windows.Forms.AnchorStyles)(((global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left) 
            | global::System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.Btn_Register);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Txt_UserName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Txt_Fname);
            this.groupBox1.Font = new global::System.Drawing.Font("B Nazanin", 10.8F, global::System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new global::System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = global::System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new global::System.Drawing.Size(785, 89);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "مشخصات";
            // 
            // Btn_Register
            // 
            this.Btn_Register.Font = new global::System.Drawing.Font("B Nazanin", 10.8F, global::System.Drawing.FontStyle.Bold);
            this.Btn_Register.Location = new global::System.Drawing.Point(41, 35);
            this.Btn_Register.Name = "Btn_Register";
            this.Btn_Register.Size = new global::System.Drawing.Size(146, 35);
            this.Btn_Register.TabIndex = 8;
            this.Btn_Register.Text = "ثبت";
            this.Btn_Register.ThemeName = "Office2007Silver";
            // 
            // label2
            // 
            this.label2.Anchor = ((global::System.Windows.Forms.AnchorStyles)((global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new global::System.Drawing.Point(391, 38);
            this.label2.Name = "label2";
            this.label2.Size = new global::System.Drawing.Size(86, 30);
            this.label2.TabIndex = 7;
            this.label2.Text = "نام کاربری :";
            this.label2.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Txt_UserName
            // 
            this.Txt_UserName.Anchor = ((global::System.Windows.Forms.AnchorStyles)((global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_UserName.Font = new global::System.Drawing.Font("B Nazanin", 12F);
            this.Txt_UserName.Location = new global::System.Drawing.Point(238, 35);
            this.Txt_UserName.Multiline = true;
            this.Txt_UserName.Name = "Txt_UserName";
            this.Txt_UserName.ReadOnly = true;
            this.Txt_UserName.Size = new global::System.Drawing.Size(145, 35);
            this.Txt_UserName.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Anchor = ((global::System.Windows.Forms.AnchorStyles)((global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new global::System.Drawing.Point(641, 37);
            this.label1.Name = "label1";
            this.label1.Size = new global::System.Drawing.Size(133, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "نام و نام خانوادگی :";
            this.label1.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Txt_Fname
            // 
            this.Txt_Fname.Anchor = ((global::System.Windows.Forms.AnchorStyles)((global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_Fname.Font = new global::System.Drawing.Font("B Nazanin", 12F, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Txt_Fname.Location = new global::System.Drawing.Point(487, 35);
            this.Txt_Fname.Multiline = true;
            this.Txt_Fname.Name = "Txt_Fname";
            this.Txt_Fname.ReadOnly = true;
            this.Txt_Fname.Size = new global::System.Drawing.Size(145, 35);
            this.Txt_Fname.TabIndex = 4;
            // 
            // GridAcess
            // 
            this.GridAcess.AllowUserToAddRows = false;
            this.GridAcess.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = global::System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new global::System.Drawing.Font("B Nazanin", 12F, global::System.Drawing.FontStyle.Bold);
            this.GridAcess.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.GridAcess.AutoSizeColumnsMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridAcess.BackgroundColor = global::System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = global::System.Drawing.Color.Salmon;
            dataGridViewCellStyle2.Font = new global::System.Drawing.Font("B Nazanin", 10.8F, global::System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = global::System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = global::System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = global::System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = global::System.Windows.Forms.DataGridViewTriState.True;
            this.GridAcess.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.GridAcess.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridAcess.Columns.AddRange(new global::System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            dataGridViewCellStyle3.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = global::System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new global::System.Drawing.Font("B Nazanin", 10.8F, global::System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = global::System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = global::System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = global::System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = global::System.Windows.Forms.DataGridViewTriState.False;
            this.GridAcess.DefaultCellStyle = dataGridViewCellStyle3;
            this.GridAcess.Dock = global::System.Windows.Forms.DockStyle.Bottom;
            this.GridAcess.EnableHeadersVisualStyles = false;
            this.GridAcess.GridColor = global::System.Drawing.SystemColors.AppWorkspace;
            this.GridAcess.Location = new global::System.Drawing.Point(0, 122);
            this.GridAcess.Margin = new global::System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GridAcess.MultiSelect = false;
            this.GridAcess.Name = "GridAcess";
            this.GridAcess.RightToLeft = global::System.Windows.Forms.RightToLeft.Yes;
            this.GridAcess.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = global::System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new global::System.Drawing.Font("Adobe Arabic", 15F, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GridAcess.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.GridAcess.RowTemplate.DefaultCellStyle.Font = new global::System.Drawing.Font("Adobe Arabic", 15F, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GridAcess.RowTemplate.Height = 30;
            this.GridAcess.SelectionMode = global::System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridAcess.Size = new global::System.Drawing.Size(809, 358);
            this.GridAcess.TabIndex = 62;
            this.GridAcess.TabStop = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ردیف";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "شرح";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "حق دسترسی";
            this.Column3.Name = "Column3";
            // 
            // BGW
            // 
            this.BGW.DoWork += new global::System.ComponentModel.DoWorkEventHandler(this.BGW_DoWork);
            this.BGW.RunWorkerCompleted += new global::System.ComponentModel.RunWorkerCompletedEventHandler(this.BGW_RunWorkerCompleted);
            // 
            // Form_Acess
            // 
            this.AutoScaleDimensions = new global::System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::System.Drawing.Color.Linen;
            this.ClientSize = new global::System.Drawing.Size(809, 480);
            this.Controls.Add(this.GridAcess);
            this.Controls.Add(this.groupBox1);
            this.Font = new global::System.Drawing.Font("B Nazanin", 10.8F, global::System.Drawing.FontStyle.Bold);
            this.Name = "Form_Acess";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "";
            this.ThemeName = "Office2007Silver";
            this.Load += new global::System.EventHandler(this.Form_Acess_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((global::System.ComponentModel.ISupportInitialize)(this.Btn_Register)).EndInit();
            ((global::System.ComponentModel.ISupportInitialize)(this.GridAcess)).EndInit();
            ((global::System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.Themes.Office2007SilverTheme office2007SilverTheme1;
        private global::System.Windows.Forms.GroupBox groupBox1;
        private global::System.Windows.Forms.Label label2;
        private global::System.Windows.Forms.TextBox Txt_UserName;
        private global::System.Windows.Forms.Label label1;
        private global::System.Windows.Forms.TextBox Txt_Fname;
        private Telerik.WinControls.UI.RadButton Btn_Register;
        private global::System.Windows.Forms.DataGridView GridAcess;
        private global::System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private global::System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private global::System.Windows.Forms.DataGridViewCheckBoxColumn Column3;
        private global::System.ComponentModel.BackgroundWorker BGW;
        private Telerik.WinControls.Themes.AquaTheme aquaTheme1;
    }
}
