using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace EsfahanGhos.Form_Users
{
    partial class Form_User
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.office2007SilverTheme1 = new Telerik.WinControls.Themes.Office2007SilverTheme();
            this.GridUser = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Row = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Btn_Access = new Telerik.WinControls.UI.RadButton();
            this.Lbl_Warning = new System.Windows.Forms.Label();
            this.Btn_Delete = new Telerik.WinControls.UI.RadButton();
            this.Btn_Edit = new Telerik.WinControls.UI.RadButton();
            this.Btn_Register = new Telerik.WinControls.UI.RadButton();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_Password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_UserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_Fname = new System.Windows.Forms.TextBox();
            this.BGW = new System.ComponentModel.BackgroundWorker();
            this.aquaTheme1 = new Telerik.WinControls.Themes.AquaTheme();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GridUser)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Access)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Delete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Register)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // GridUser
            // 
            this.GridUser.AllowUserToAddRows = false;
            this.GridUser.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.GridUser.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.GridUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridUser.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Salmon;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("B Nazanin", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.GridUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Row,
            this.FName,
            this.UserName,
            this.TotalPrice});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("B Nazanin", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridUser.DefaultCellStyle = dataGridViewCellStyle3;
            this.GridUser.Dock = System.Windows.Forms.DockStyle.Left;
            this.GridUser.EnableHeadersVisualStyles = false;
            this.GridUser.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.GridUser.Location = new System.Drawing.Point(0, 0);
            this.GridUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GridUser.MultiSelect = false;
            this.GridUser.Name = "GridUser";
            this.GridUser.ReadOnly = true;
            this.GridUser.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GridUser.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Adobe Arabic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GridUser.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.GridUser.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Adobe Arabic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GridUser.RowTemplate.Height = 30;
            this.GridUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridUser.Size = new System.Drawing.Size(673, 571);
            this.GridUser.TabIndex = 61;
            this.GridUser.TabStop = false;
            this.GridUser.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridUser_CellDoubleClick);
            this.GridUser.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GridUser_CellMouseClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "UserID";
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Row
            // 
            this.Row.FillWeight = 12F;
            this.Row.HeaderText = "ردیف";
            this.Row.Name = "Row";
            this.Row.ReadOnly = true;
            // 
            // FName
            // 
            this.FName.DataPropertyName = "FName";
            this.FName.FillWeight = 30F;
            this.FName.HeaderText = "نام و نام خانوادگی";
            this.FName.Name = "FName";
            this.FName.ReadOnly = true;
            // 
            // UserName
            // 
            this.UserName.DataPropertyName = "UserName";
            this.UserName.FillWeight = 20F;
            this.UserName.HeaderText = "نام کاربری ";
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            // 
            // TotalPrice
            // 
            this.TotalPrice.FillWeight = 20F;
            this.TotalPrice.HeaderText = "پسورد";
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.Btn_Access);
            this.groupBox1.Controls.Add(this.Lbl_Warning);
            this.groupBox1.Controls.Add(this.Btn_Delete);
            this.groupBox1.Controls.Add(this.Btn_Edit);
            this.groupBox1.Controls.Add(this.Btn_Register);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Txt_Password);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Txt_UserName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Txt_Fname);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(679, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(347, 491);
            this.groupBox1.TabIndex = 62;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "اطلاعات";
            // 
            // Btn_Access
            // 
            this.Btn_Access.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Access.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Access.Enabled = false;
            this.Btn_Access.Font = new System.Drawing.Font("B Nazanin", 10.8F, System.Drawing.FontStyle.Bold);
            this.Btn_Access.Location = new System.Drawing.Point(17, 342);
            this.Btn_Access.Name = "Btn_Access";
            this.Btn_Access.Size = new System.Drawing.Size(320, 42);
            this.Btn_Access.TabIndex = 8;
            this.Btn_Access.Text = "ثبت دسترسی";
            this.Btn_Access.ThemeName = "Office2007Silver";
            this.Btn_Access.Click += new System.EventHandler(this.Btn_Access_Click);
            // 
            // Lbl_Warning
            // 
            this.Lbl_Warning.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_Warning.AutoSize = true;
            this.Lbl_Warning.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Lbl_Warning.Font = new System.Drawing.Font("B Nazanin", 10F);
            this.Lbl_Warning.ForeColor = System.Drawing.Color.Red;
            this.Lbl_Warning.Location = new System.Drawing.Point(16, 158);
            this.Lbl_Warning.Name = "Lbl_Warning";
            this.Lbl_Warning.Size = new System.Drawing.Size(240, 26);
            this.Lbl_Warning.TabIndex = 9;
            this.Lbl_Warning.Text = "نام کاربری می بایست بیش از 4 کاراکتر باشد";
            this.Lbl_Warning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Lbl_Warning.Visible = false;
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Delete.Enabled = false;
            this.Btn_Delete.Font = new System.Drawing.Font("B Nazanin", 10.8F, System.Drawing.FontStyle.Bold);
            this.Btn_Delete.Location = new System.Drawing.Point(17, 294);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(149, 42);
            this.Btn_Delete.TabIndex = 7;
            this.Btn_Delete.Text = "حذف";
            this.Btn_Delete.ThemeName = "Office2007Silver";
            this.Btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            // 
            // Btn_Edit
            // 
            this.Btn_Edit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Edit.Enabled = false;
            this.Btn_Edit.Font = new System.Drawing.Font("B Nazanin", 10.8F, System.Drawing.FontStyle.Bold);
            this.Btn_Edit.Location = new System.Drawing.Point(188, 294);
            this.Btn_Edit.Name = "Btn_Edit";
            this.Btn_Edit.Size = new System.Drawing.Size(149, 42);
            this.Btn_Edit.TabIndex = 6;
            this.Btn_Edit.Text = "ویرایش";
            this.Btn_Edit.ThemeName = "Office2007Silver";
            this.Btn_Edit.Click += new System.EventHandler(this.Btn_Edit_Click);
            // 
            // Btn_Register
            // 
            this.Btn_Register.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Register.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Register.Font = new System.Drawing.Font("B Nazanin", 10.8F, System.Drawing.FontStyle.Bold);
            this.Btn_Register.Location = new System.Drawing.Point(17, 246);
            this.Btn_Register.Name = "Btn_Register";
            this.Btn_Register.Size = new System.Drawing.Size(320, 42);
            this.Btn_Register.TabIndex = 5;
            this.Btn_Register.Text = "ثبت";
            this.Btn_Register.ThemeName = "Office2007Silver";
            this.Btn_Register.Click += new System.EventHandler(this.Btn_Register_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Location = new System.Drawing.Point(228, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 30);
            this.label3.TabIndex = 5;
            this.label3.Text = "کلمه ی عبور :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Txt_Password
            // 
            this.Txt_Password.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_Password.Font = new System.Drawing.Font("B Nazanin", 12F);
            this.Txt_Password.Location = new System.Drawing.Point(16, 117);
            this.Txt_Password.Multiline = true;
            this.Txt_Password.Name = "Txt_Password";
            this.Txt_Password.Size = new System.Drawing.Size(169, 35);
            this.Txt_Password.TabIndex = 3;
            this.Txt_Password.TextChanged += new System.EventHandler(this.Txt_Password_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Location = new System.Drawing.Point(245, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "نام کاربری :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Txt_UserName
            // 
            this.Txt_UserName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_UserName.Font = new System.Drawing.Font("B Nazanin", 12F);
            this.Txt_UserName.Location = new System.Drawing.Point(16, 76);
            this.Txt_UserName.Multiline = true;
            this.Txt_UserName.Name = "Txt_UserName";
            this.Txt_UserName.Size = new System.Drawing.Size(169, 35);
            this.Txt_UserName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Location = new System.Drawing.Point(198, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "نام و نام خانوادگی :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Txt_Fname
            // 
            this.Txt_Fname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_Fname.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Txt_Fname.Location = new System.Drawing.Point(16, 35);
            this.Txt_Fname.Multiline = true;
            this.Txt_Fname.Name = "Txt_Fname";
            this.Txt_Fname.Size = new System.Drawing.Size(169, 35);
            this.Txt_Fname.TabIndex = 0;
            this.Txt_Fname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Fname_KeyPress);
            // 
            // BGW
            // 
            this.BGW.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BGW_DoWork);
            this.BGW.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BGW_RunWorkerCompleted);
            // 
            // Form_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            ((RadFormControlBase) this).AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1038, 571);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GridUser);
            this.Font = new System.Drawing.Font("B Nazanin", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name = "Form_User";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "";
            this.ThemeName = "Office2007Silver";
            this.Load += new System.EventHandler(this.Form_User_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridUser)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Access)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Delete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Register)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Telerik.WinControls.Themes.Office2007SilverTheme office2007SilverTheme1;
        private global::System.Windows.Forms.DataGridView GridUser;
        private global::System.Windows.Forms.GroupBox groupBox1;
        private global::System.Windows.Forms.Label label2;
        private global::System.Windows.Forms.TextBox Txt_UserName;
        private global::System.Windows.Forms.Label label1;
        private global::System.Windows.Forms.TextBox Txt_Fname;
        private Telerik.WinControls.UI.RadButton Btn_Delete;
        private Telerik.WinControls.UI.RadButton Btn_Edit;
        private Telerik.WinControls.UI.RadButton Btn_Register;
        private global::System.Windows.Forms.Label label3;
        private global::System.Windows.Forms.TextBox Txt_Password;
        private global::System.Windows.Forms.Label Lbl_Warning;
        private Telerik.WinControls.UI.RadButton Btn_Access;
        private global::System.ComponentModel.BackgroundWorker BGW;
        private Telerik.WinControls.Themes.AquaTheme aquaTheme1;
        private global::System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private global::System.Windows.Forms.DataGridViewTextBoxColumn Row;
        private global::System.Windows.Forms.DataGridViewTextBoxColumn FName;
        private global::System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private global::System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
        private global::System.Windows.Forms.ToolTip toolTip1;
    }
}
