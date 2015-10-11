namespace EsfahanGhos
{
    partial class Form_People
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_People));
            this.aquaTheme1 = new Telerik.WinControls.Themes.AquaTheme();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.Btn_Person = new System.Windows.Forms.ToolStripDropDownButton();
            this.Btn_Reg = new System.Windows.Forms.ToolStripMenuItem();
            this.Btn_ListPerson = new System.Windows.Forms.ToolStripMenuItem();
            this.Btn_ProjectPersons = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Button_Close = new System.Windows.Forms.ToolStripButton();
            this.button1 = new System.Windows.Forms.Button();
            this.toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.BackColor = System.Drawing.SystemColors.ControlDark;
            this.toolStrip.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator4,
            this.Btn_Person,
            this.toolStripSeparator1,
            this.Button_Close});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip.Size = new System.Drawing.Size(1414, 39);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "toolStrip1";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 39);
            // 
            // Btn_Person
            // 
            this.Btn_Person.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Btn_Reg,
            this.Btn_ListPerson,
            this.Btn_ProjectPersons});
            this.Btn_Person.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Person.Image")));
            this.Btn_Person.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_Person.Name = "Btn_Person";
            this.Btn_Person.Size = new System.Drawing.Size(99, 36);
            this.Btn_Person.Text = "کارکنان";
            // 
            // Btn_Reg
            // 
            this.Btn_Reg.Name = "Btn_Reg";
            this.Btn_Reg.Size = new System.Drawing.Size(230, 36);
            this.Btn_Reg.Text = "ثبت";
            this.Btn_Reg.Click += new System.EventHandler(this.Btn_RegPerson);
            // 
            // Btn_ListPerson
            // 
            this.Btn_ListPerson.Name = "Btn_ListPerson";
            this.Btn_ListPerson.Size = new System.Drawing.Size(230, 36);
            this.Btn_ListPerson.Text = "گزارش گیری";
            this.Btn_ListPerson.Click += new System.EventHandler(this.Btn_ListPerson_Click);
            // 
            // Btn_ProjectPersons
            // 
            this.Btn_ProjectPersons.Name = "Btn_ProjectPersons";
            this.Btn_ProjectPersons.Size = new System.Drawing.Size(230, 36);
            this.Btn_ProjectPersons.Text = "ثبت افراد برای پروژه";
            this.Btn_ProjectPersons.Click += new System.EventHandler(this.Btn_ProjectPersons_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // Button_Close
            // 
            this.Button_Close.Image = ((System.Drawing.Image)(resources.GetObject("Button_Close.Image")));
            this.Button_Close.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Button_Close.Name = "Button_Close";
            this.Button_Close.Size = new System.Drawing.Size(117, 36);
            this.Button_Close.Text = "بستن پنجره";
            this.Button_Close.Click += new System.EventHandler(this.Button_Close_Click);
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(43, 661);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.Button_Close_Click);
            // 
            // Form_People
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(1414, 991);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.toolStrip);
            this.Font = new System.Drawing.Font("Adobe Arabic", 13.8F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_People";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_ListOfEmployee";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.Themes.AquaTheme aquaTheme1;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton Button_Close;
        private System.Windows.Forms.ToolStripDropDownButton Btn_Person;
        private System.Windows.Forms.ToolStripMenuItem Btn_Reg;
        private System.Windows.Forms.ToolStripMenuItem Btn_ListPerson;
        private System.Windows.Forms.ToolStripMenuItem Btn_ProjectPersons;
        private System.Windows.Forms.Button button1;
    }
}
