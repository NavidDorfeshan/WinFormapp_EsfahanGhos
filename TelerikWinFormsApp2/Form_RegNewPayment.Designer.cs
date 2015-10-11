namespace EsfahanGhos
{
    partial class Form_RegNewPayment
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
            this.BGW = new System.ComponentModel.BackgroundWorker();
            this.aquaTheme1 = new Telerik.WinControls.Themes.AquaTheme();
            this.Btn_Next = new Telerik.WinControls.UI.RadButton();
            this.D1 = new System.Windows.Forms.Label();
            this.D2 = new System.Windows.Forms.ComboBox();
            this.P3 = new System.Windows.Forms.Label();
            this.F3 = new System.Windows.Forms.Label();
            this.P1 = new System.Windows.Forms.Label();
            this.P2 = new System.Windows.Forms.ComboBox();
            this.F1 = new System.Windows.Forms.Label();
            this.F2 = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Radio_Factor = new System.Windows.Forms.RadioButton();
            this.Radio_ListP = new System.Windows.Forms.RadioButton();
            this.Radio_Diffrent = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Next)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BGW
            // 
            this.BGW.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BGW_DoWork);
            // 
            // Btn_Next
            // 
            this.Btn_Next.Font = new System.Drawing.Font("B Nazanin", 10.8F, System.Drawing.FontStyle.Bold);
            this.Btn_Next.Location = new System.Drawing.Point(12, 12);
            this.Btn_Next.Name = "Btn_Next";
            this.Btn_Next.Size = new System.Drawing.Size(137, 44);
            this.Btn_Next.TabIndex = 22;
            this.Btn_Next.Text = "مرحله ی بعد";
            this.Btn_Next.ThemeName = "Aqua";
            this.Btn_Next.Click += new System.EventHandler(this.Btn_Next_Click);
            // 
            // D1
            // 
            this.D1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.D1.AutoSize = true;
            this.D1.Enabled = false;
            this.D1.Location = new System.Drawing.Point(453, 101);
            this.D1.Name = "D1";
            this.D1.Size = new System.Drawing.Size(56, 30);
            this.D1.TabIndex = 21;
            this.D1.Text = "پروژه :";
            // 
            // D2
            // 
            this.D2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.D2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.D2.Enabled = false;
            this.D2.FormattingEnabled = true;
            this.D2.Location = new System.Drawing.Point(212, 98);
            this.D2.Name = "D2";
            this.D2.Size = new System.Drawing.Size(235, 37);
            this.D2.TabIndex = 20;
            // 
            // P3
            // 
            this.P3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.P3.AutoSize = true;
            this.P3.Enabled = false;
            this.P3.ForeColor = System.Drawing.Color.Red;
            this.P3.Location = new System.Drawing.Point(183, 58);
            this.P3.Name = "P3";
            this.P3.Size = new System.Drawing.Size(23, 30);
            this.P3.TabIndex = 19;
            this.P3.Text = "*";
            // 
            // F3
            // 
            this.F3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.F3.AutoSize = true;
            this.F3.Enabled = false;
            this.F3.ForeColor = System.Drawing.Color.Red;
            this.F3.Location = new System.Drawing.Point(183, 15);
            this.F3.Name = "F3";
            this.F3.Size = new System.Drawing.Size(23, 30);
            this.F3.TabIndex = 18;
            this.F3.Text = "*";
            // 
            // P1
            // 
            this.P1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.P1.AutoSize = true;
            this.P1.Enabled = false;
            this.P1.Location = new System.Drawing.Point(453, 58);
            this.P1.Name = "P1";
            this.P1.Size = new System.Drawing.Size(100, 30);
            this.P1.TabIndex = 17;
            this.P1.Text = "لیست خرید :";
            // 
            // P2
            // 
            this.P2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.P2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.P2.Enabled = false;
            this.P2.FormattingEnabled = true;
            this.P2.Location = new System.Drawing.Point(212, 55);
            this.P2.Name = "P2";
            this.P2.Size = new System.Drawing.Size(235, 37);
            this.P2.TabIndex = 16;
            // 
            // F1
            // 
            this.F1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.F1.AutoSize = true;
            this.F1.Enabled = false;
            this.F1.Location = new System.Drawing.Point(453, 15);
            this.F1.Name = "F1";
            this.F1.Size = new System.Drawing.Size(104, 30);
            this.F1.TabIndex = 15;
            this.F1.Text = "فاکتور شماره :";
            // 
            // F2
            // 
            this.F2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.F2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.F2.Enabled = false;
            this.F2.FormattingEnabled = true;
            this.F2.Location = new System.Drawing.Point(212, 12);
            this.F2.Name = "F2";
            this.F2.Size = new System.Drawing.Size(235, 37);
            this.F2.TabIndex = 14;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.Radio_Factor);
            this.flowLayoutPanel1.Controls.Add(this.Radio_ListP);
            this.flowLayoutPanel1.Controls.Add(this.Radio_Diffrent);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(590, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(149, 150);
            this.flowLayoutPanel1.TabIndex = 13;
            // 
            // Radio_Factor
            // 
            this.Radio_Factor.AutoSize = true;
            this.Radio_Factor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Radio_Factor.Location = new System.Drawing.Point(69, 3);
            this.Radio_Factor.Name = "Radio_Factor";
            this.Radio_Factor.Size = new System.Drawing.Size(75, 34);
            this.Radio_Factor.TabIndex = 0;
            this.Radio_Factor.Text = "فاکتور";
            this.Radio_Factor.UseVisualStyleBackColor = true;
            this.Radio_Factor.CheckedChanged += new System.EventHandler(this.Radio_CheckedChanged);
            // 
            // Radio_ListP
            // 
            this.Radio_ListP.AutoSize = true;
            this.Radio_ListP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Radio_ListP.Location = new System.Drawing.Point(31, 43);
            this.Radio_ListP.Name = "Radio_ListP";
            this.Radio_ListP.Size = new System.Drawing.Size(113, 34);
            this.Radio_ListP.TabIndex = 1;
            this.Radio_ListP.Text = "لیست خرید";
            this.Radio_ListP.UseVisualStyleBackColor = true;
            this.Radio_ListP.CheckedChanged += new System.EventHandler(this.Radio_CheckedChanged);
            // 
            // Radio_Diffrent
            // 
            this.Radio_Diffrent.AutoSize = true;
            this.Radio_Diffrent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Radio_Diffrent.Location = new System.Drawing.Point(65, 83);
            this.Radio_Diffrent.Name = "Radio_Diffrent";
            this.Radio_Diffrent.Size = new System.Drawing.Size(79, 34);
            this.Radio_Diffrent.TabIndex = 3;
            this.Radio_Diffrent.Text = "متفرقه";
            this.Radio_Diffrent.UseVisualStyleBackColor = true;
            this.Radio_Diffrent.CheckedChanged += new System.EventHandler(this.Radio_CheckedChanged);
            // 
            // Form_RegNewPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(739, 150);
            this.Controls.Add(this.Btn_Next);
            this.Controls.Add(this.D1);
            this.Controls.Add(this.D2);
            this.Controls.Add(this.P3);
            this.Controls.Add(this.F3);
            this.Controls.Add(this.P1);
            this.Controls.Add(this.P2);
            this.Controls.Add(this.F1);
            this.Controls.Add(this.F2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("B Nazanin", 10.8F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form_RegNewPayment";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form_RegNewPayment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Next)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker BGW;
        private Telerik.WinControls.Themes.AquaTheme aquaTheme1;
        private Telerik.WinControls.UI.RadButton Btn_Next;
        private System.Windows.Forms.Label D1;
        private System.Windows.Forms.ComboBox D2;
        private System.Windows.Forms.Label P3;
        private System.Windows.Forms.Label F3;
        private System.Windows.Forms.Label P1;
        private System.Windows.Forms.ComboBox P2;
        private System.Windows.Forms.Label F1;
        private System.Windows.Forms.ComboBox F2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.RadioButton Radio_Factor;
        private System.Windows.Forms.RadioButton Radio_ListP;
        private System.Windows.Forms.RadioButton Radio_Diffrent;

    }
}