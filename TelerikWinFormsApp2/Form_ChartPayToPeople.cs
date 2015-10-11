
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using EsfahanGhos.Model;
using Telerik.WinControls.UI;

namespace EsfahanGhos
{
    public partial class Form_ChartPayToPeople : Form
    {
        private List<Payment> Listpayments = null;
        public Form_ChartPayToPeople(List<Payment> Listp)
        {
            Listpayments = Listp;
            InitializeComponent();
        }

        private void Form_ChartPayToPeople_Load(object sender, System.EventArgs e)
        {
            if (Listpayments.Count == 0)
            {
                utility.Show_Message("اطلاعاتی برای رسم نمودار وجود ندارد", "پیام");
                return;
            }
            else
            {
                CreatChart();
            }
        }

        private void CreatChart()
        {
            int i = 0;
            foreach (var item in Listpayments)
            {
                var series = chart1.Series.Add
                    (++i + " _ " + utility.ConvertDate_M_To_Sh(item.Date));
                series.Font = new Font("B Nazanin", 10.2F, System.Drawing.FontStyle.Bold,GraphicsUnit.Point, ((byte)(178)));
                series.IsValueShownAsLabel = true;
                series.Points.Add(Convert.ToDouble(item.Cost));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            chart1.Printing.PrintPreview();
        }
    }
}
