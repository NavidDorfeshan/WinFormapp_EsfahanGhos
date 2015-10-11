namespace EsfahanGhos
{
    partial class Form_Accounting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Accounting));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.Btn_NewPayment = new System.Windows.Forms.ToolStripMenuItem();
            this.Btn_ListPayments = new System.Windows.Forms.ToolStripMenuItem();
            this.Btn_PayToPeople = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.Btn_RegSalary = new System.Windows.Forms.ToolStripMenuItem();
            this.Btn_ListSalaries = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_ChartSalary = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.Btn_Close = new System.Windows.Forms.ToolStripButton();
            this.Exite = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Gainsboro;
            this.toolStrip1.Font = new System.Drawing.Font("B Nazanin", 10.2F, System.Drawing.FontStyle.Bold);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton2,
            this.toolStripSeparator1,
            this.toolStripButton2,
            this.toolStripSeparator2,
            this.toolStripDropDownButton1,
            this.toolStripSeparator3,
            this.Btn_Close});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip1.Size = new System.Drawing.Size(1181, 34);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Btn_NewPayment,
            this.Btn_ListPayments,
            this.Btn_PayToPeople});
            this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(106, 31);
            this.toolStripDropDownButton2.Text = "پرداختی ها";
            // 
            // Btn_NewPayment
            // 
            this.Btn_NewPayment.Name = "Btn_NewPayment";
            this.Btn_NewPayment.Size = new System.Drawing.Size(239, 32);
            this.Btn_NewPayment.Text = "ثبت پرداخت جدید";
            this.Btn_NewPayment.Click += new System.EventHandler(this.Btn_NewPayment_Click);
            // 
            // Btn_ListPayments
            // 
            this.Btn_ListPayments.Name = "Btn_ListPayments";
            this.Btn_ListPayments.Size = new System.Drawing.Size(239, 32);
            this.Btn_ListPayments.Text = "گزارش از پرداختی ها";
            this.Btn_ListPayments.Click += new System.EventHandler(this.Btn_ListPayments_Click);
            // 
            // Btn_PayToPeople
            // 
            this.Btn_PayToPeople.Name = "Btn_PayToPeople";
            this.Btn_PayToPeople.Size = new System.Drawing.Size(239, 32);
            this.Btn_PayToPeople.Text = "پرداخت به حساب اشخاص ";
            this.Btn_PayToPeople.Click += new System.EventHandler(this.Btn_PayToPeople_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 34);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Btn_RegSalary,
            this.Btn_ListSalaries,
            this.btn_ChartSalary});
            this.toolStripButton2.Font = new System.Drawing.Font("B Nazanin", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(87, 31);
            this.toolStripButton2.Text = "دستمزد";
            // 
            // Btn_RegSalary
            // 
            this.Btn_RegSalary.Name = "Btn_RegSalary";
            this.Btn_RegSalary.Size = new System.Drawing.Size(285, 32);
            this.Btn_RegSalary.Text = "ثبت دستمزد";
            this.Btn_RegSalary.Click += new System.EventHandler(this.Btn_RegSalary_Click);
            // 
            // Btn_ListSalaries
            // 
            this.Btn_ListSalaries.Name = "Btn_ListSalaries";
            this.Btn_ListSalaries.Size = new System.Drawing.Size(285, 32);
            this.Btn_ListSalaries.Text = "گزارش گیری";
            this.Btn_ListSalaries.Click += new System.EventHandler(this.Btn_ListSalaries_Click);
            // 
            // btn_ChartSalary
            // 
            this.btn_ChartSalary.Name = "btn_ChartSalary";
            this.btn_ChartSalary.Size = new System.Drawing.Size(285, 32);
            this.btn_ChartSalary.Text = "گزارش نموداری از حقوق هر کارمند";
            this.btn_ChartSalary.Click += new System.EventHandler(this.btn_ChartSalary_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 34);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(162, 31);
            this.toolStripDropDownButton1.Text = "واریزی به حساب پروژه";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 34);
            // 
            // Btn_Close
            // 
            this.Btn_Close.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Close.Image")));
            this.Btn_Close.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(65, 31);
            this.Btn_Close.Text = "خروج";
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // Exite
            // 
            this.Exite.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Exite.Location = new System.Drawing.Point(12, 644);
            this.Exite.Name = "Exite";
            this.Exite.Size = new System.Drawing.Size(75, 23);
            this.Exite.TabIndex = 1;
            this.Exite.Text = "button1";
            this.Exite.UseVisualStyleBackColor = true;
            this.Exite.Visible = false;
            this.Exite.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // Form_Accounting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.Exite;
            this.ClientSize = new System.Drawing.Size(1181, 669);
            this.Controls.Add(this.Exite);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("B Nazanin", 10.2F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form_Accounting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Accounting";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton Btn_Close;
        private System.Windows.Forms.ToolStripDropDownButton toolStripButton2;
        private System.Windows.Forms.ToolStripMenuItem Btn_RegSalary;
        private System.Windows.Forms.ToolStripMenuItem Btn_ListSalaries;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem Btn_NewPayment;
        private System.Windows.Forms.ToolStripMenuItem Btn_ListPayments;
        private System.Windows.Forms.ToolStripButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem btn_ChartSalary;
        private System.Windows.Forms.Button Exite;
        private System.Windows.Forms.ToolStripMenuItem Btn_PayToPeople;

    }
}