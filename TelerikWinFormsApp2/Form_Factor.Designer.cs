namespace EsfahanGhos
{
    partial class Form_Factor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Factor));
            this.aquaTheme1 = new Telerik.WinControls.Themes.AquaTheme();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Btn_RegTankhah = new Telerik.WinControls.UI.RadButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Btn_Factorlist = new Telerik.WinControls.UI.RadButton();
            this.Btn_Close = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_RegTankhah)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Factorlist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.flowLayoutPanel1);
            this.radGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGroupBox1.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.radGroupBox1.GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office;
            this.radGroupBox1.HeaderText = "فاکتور";
            this.radGroupBox1.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.radGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(283, 267);
            this.radGroupBox1.TabIndex = 0;
            this.radGroupBox1.Text = "فاکتور";
            this.radGroupBox1.ThemeName = "Aqua";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.Btn_RegTankhah);
            this.flowLayoutPanel1.Controls.Add(this.Btn_Factorlist);
            this.flowLayoutPanel1.Controls.Add(this.Btn_Close);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(43, 55);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(194, 185);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // Btn_RegTankhah
            // 
            this.Btn_RegTankhah.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_RegTankhah.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_RegTankhah.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.Btn_RegTankhah.ImageKey = "Awicons-Vista-Artistic-Add.ico";
            this.Btn_RegTankhah.ImageList = this.imageList1;
            this.Btn_RegTankhah.Location = new System.Drawing.Point(10, 3);
            this.Btn_RegTankhah.Name = "Btn_RegTankhah";
            this.Btn_RegTankhah.Size = new System.Drawing.Size(181, 51);
            this.Btn_RegTankhah.TabIndex = 65;
            this.Btn_RegTankhah.Text = "ثبت فاکتور جدید";
            this.Btn_RegTankhah.ThemeName = "Aqua";
            this.Btn_RegTankhah.Click += new System.EventHandler(this.Btn_RegTankhah_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Custom-Icon-Design-Pretty-Office-9-Edit-validated.ico");
            this.imageList1.Images.SetKeyName(1, "Awicons-Vista-Artistic-Add.ico");
            this.imageList1.Images.SetKeyName(2, "Awicons-Vista-Artistic-Delete.ico");
            this.imageList1.Images.SetKeyName(3, "Custom-Icon-Design-Pretty-Office-6-Custom-reports.ico");
            this.imageList1.Images.SetKeyName(4, "Aha-Soft-Universal-Shop-Print.ico");
            this.imageList1.Images.SetKeyName(5, "Custom-Icon-Design-Flatastic-5-Sales-report.ico");
            this.imageList1.Images.SetKeyName(6, "Hopstarter-Sleek-Xp-Basic-Preview.ico");
            // 
            // Btn_Factorlist
            // 
            this.Btn_Factorlist.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Factorlist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Factorlist.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.Btn_Factorlist.ImageIndex = 3;
            this.Btn_Factorlist.ImageKey = "Awicons-Vista-Artistic-Add.ico";
            this.Btn_Factorlist.ImageList = this.imageList1;
            this.Btn_Factorlist.Location = new System.Drawing.Point(10, 60);
            this.Btn_Factorlist.Name = "Btn_Factorlist";
            this.Btn_Factorlist.Size = new System.Drawing.Size(181, 51);
            this.Btn_Factorlist.TabIndex = 66;
            this.Btn_Factorlist.Text = "لیست فاکتورها";
            this.Btn_Factorlist.ThemeName = "Aqua";
            this.Btn_Factorlist.Click += new System.EventHandler(this.Btn_Factorlist_Click);
            // 
            // Btn_Close
            // 
            this.Btn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Btn_Close.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.Btn_Close.ImageIndex = 5;
            this.Btn_Close.ImageKey = "Awicons-Vista-Artistic-Add.ico";
            this.Btn_Close.Location = new System.Drawing.Point(10, 117);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(181, 51);
            this.Btn_Close.TabIndex = 68;
            this.Btn_Close.Text = "خروج";
            this.Btn_Close.ThemeName = "Aqua";
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // Form_Factor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.Btn_Close;
            this.ClientSize = new System.Drawing.Size(283, 267);
            this.Controls.Add(this.radGroupBox1);
            this.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Factor";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "";
            this.ThemeName = "ControlDefault";
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Btn_RegTankhah)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Factorlist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.Themes.AquaTheme aquaTheme1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Telerik.WinControls.UI.RadButton Btn_RegTankhah;
        private Telerik.WinControls.UI.RadButton Btn_Factorlist;
        private System.Windows.Forms.ImageList imageList1;
        private Telerik.WinControls.UI.RadButton Btn_Close;
    }
}
