namespace EsfahanGhos
{
    partial class Form_ChartSalary
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_Print = new Telerik.WinControls.UI.RadButton();
            this.Combo_Person = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Combo_Project = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BGW = new System.ComponentModel.BackgroundWorker();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.aquaTheme1 = new Telerik.WinControls.Themes.AquaTheme();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Print)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Btn_Print);
            this.panel1.Controls.Add(this.Combo_Person);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Combo_Project);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("B Nazanin", 10.8F, System.Drawing.FontStyle.Bold);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel1.Size = new System.Drawing.Size(925, 66);
            this.panel1.TabIndex = 1;
            // 
            // Btn_Print
            // 
            this.Btn_Print.Font = new System.Drawing.Font("B Nazanin", 10.8F, System.Drawing.FontStyle.Bold);
            this.Btn_Print.Location = new System.Drawing.Point(11, 8);
            this.Btn_Print.Name = "Btn_Print";
            this.Btn_Print.Size = new System.Drawing.Size(137, 37);
            this.Btn_Print.TabIndex = 3;
            this.Btn_Print.Text = "چاپ نمودار";
            this.Btn_Print.ThemeName = "Aqua";
            this.Btn_Print.Click += new System.EventHandler(this.Btn_Print_Click);
            // 
            // Combo_Person
            // 
            this.Combo_Person.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Combo_Person.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.Combo_Person.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Combo_Person.BackColor = System.Drawing.Color.Snow;
            this.Combo_Person.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Combo_Person.FormattingEnabled = true;
            this.Combo_Person.Location = new System.Drawing.Point(171, 9);
            this.Combo_Person.Name = "Combo_Person";
            this.Combo_Person.Size = new System.Drawing.Size(239, 37);
            this.Combo_Person.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(416, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "نام و نام خانوادگی:";
            // 
            // Combo_Project
            // 
            this.Combo_Project.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Combo_Project.BackColor = System.Drawing.Color.Snow;
            this.Combo_Project.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Combo_Project.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Combo_Project.FormattingEnabled = true;
            this.Combo_Project.Location = new System.Drawing.Point(561, 7);
            this.Combo_Project.Name = "Combo_Project";
            this.Combo_Project.Size = new System.Drawing.Size(239, 37);
            this.Combo_Project.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(806, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "پروژه :";
            // 
            // BGW
            // 
            this.BGW.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BGW_DoWork);
            this.BGW.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BGW_RunWorkerCompleted);
            // 
            // chart1
            // 
            this.chart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.Center;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Bottom;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(0, 74);
            this.chart1.Margin = new System.Windows.Forms.Padding(5);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            this.chart1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chart1.Size = new System.Drawing.Size(925, 573);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            // 
            // Form_ChartSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(925, 647);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("B Nazanin", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form_ChartSalary";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "گزارش از حقوق کارمند";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Print)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox Combo_Person;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Combo_Project;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker BGW;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Telerik.WinControls.UI.RadButton Btn_Print;
        private Telerik.WinControls.Themes.AquaTheme aquaTheme1;

    }
}