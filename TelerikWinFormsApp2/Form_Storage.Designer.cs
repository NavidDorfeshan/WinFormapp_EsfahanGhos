namespace EsfahanGhos
{
    partial class Form_Storage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Storage));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.Btn_Unit = new System.Windows.Forms.ToolStripMenuItem();
            this.Btn_TypeStorage = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.Btn_RegStorage = new System.Windows.Forms.ToolStripMenuItem();
            this.Btn_SourceStorage = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.Font = new System.Drawing.Font("B Nazanin", 10.2F);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.toolStripDropDownButton1,
            this.toolStripSeparator2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1176, 39);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Btn_Unit,
            this.Btn_TypeStorage});
            this.toolStripButton1.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.toolStripButton1.ForeColor = System.Drawing.Color.White;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(130, 36);
            this.toolStripButton1.Text = "اطلاعات پایه";
            // 
            // Btn_Unit
            // 
            this.Btn_Unit.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Unit.Image")));
            this.Btn_Unit.Name = "Btn_Unit";
            this.Btn_Unit.Size = new System.Drawing.Size(239, 36);
            this.Btn_Unit.Text = "واحد های اندازه گیری";
            this.Btn_Unit.Click += new System.EventHandler(this.Btn_Unit_Click);
            // 
            // Btn_TypeStorage
            // 
            this.Btn_TypeStorage.Image = ((System.Drawing.Image)(resources.GetObject("Btn_TypeStorage.Image")));
            this.Btn_TypeStorage.Name = "Btn_TypeStorage";
            this.Btn_TypeStorage.Size = new System.Drawing.Size(239, 36);
            this.Btn_TypeStorage.Text = "دسته بندی کالاها";
            this.Btn_TypeStorage.Click += new System.EventHandler(this.Btn_TypeStorage_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Btn_RegStorage,
            this.Btn_SourceStorage});
            this.toolStripDropDownButton1.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.toolStripDropDownButton1.ForeColor = System.Drawing.Color.White;
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(73, 36);
            this.toolStripDropDownButton1.Text = "انبار";
            // 
            // Btn_RegStorage
            // 
            this.Btn_RegStorage.Name = "Btn_RegStorage";
            this.Btn_RegStorage.Size = new System.Drawing.Size(181, 36);
            this.Btn_RegStorage.Text = "ثبت کالا";
            this.Btn_RegStorage.Click += new System.EventHandler(this.Btn_RegStorage_Click);
            // 
            // Btn_SourceStorage
            // 
            this.Btn_SourceStorage.Name = "Btn_SourceStorage";
            this.Btn_SourceStorage.Size = new System.Drawing.Size(181, 36);
            this.Btn_SourceStorage.Text = "موجودی انبار";
            this.Btn_SourceStorage.Click += new System.EventHandler(this.Btn_SourceStorage_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // Form_Storage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1176, 657);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("B Nazanin", 10.2F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form_Storage";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Storage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripButton1;
        private System.Windows.Forms.ToolStripMenuItem Btn_Unit;
        private System.Windows.Forms.ToolStripMenuItem Btn_TypeStorage;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem Btn_RegStorage;
        private System.Windows.Forms.ToolStripMenuItem Btn_SourceStorage;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}