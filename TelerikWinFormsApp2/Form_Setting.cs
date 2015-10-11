using System;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Windows.Forms;
using EsfahanGhos.DataLayer;
using EsfahanGhos.Model;

namespace EsfahanGhos
{
    public partial class Form_Setting : Telerik.WinControls.UI.RadForm
    {
        Corporation db = new Corporation();
        public Form_Setting()
        {
            InitializeComponent();
        }

        private void BtnSaveVAX_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtVAXDecimal.Text.Trim() != string.Empty || TxtVAXDigit.Text.Trim() != string.Empty)
                {
                    string VAX = TxtVAXDigit.Text.Trim();
                    if (TxtVAXDecimal.Text.Trim() != string.Empty)
                    {
                        VAX += "." + TxtVAXDecimal.Text.Trim();
                    }
                    if (!db.Percentages.AsNoTracking().Any(p => p.name == "VAX"))
                    {
                        Percentage newVaxPercentage = new Percentage
                        {
                            name = "VAX",
                            Precent = Convert.ToDouble(VAX)
                        };
                        db.Percentages.Add(newVaxPercentage);
                    }
                    else
                    {
                        Percentage VAXPercent = (from P in db.Percentages
                                                 where P.name == "VAX"
                                                 select P).FirstOrDefault();
                        VAXPercent.Precent = Convert.ToDouble(VAX);
                    }
                    db.SaveChanges();
                }
                if (TxtTaxDigit.Text.Trim() != string.Empty || TxtTaxDecimal.Text.Trim() != string.Empty)
                {
                    string TAX = TxtTaxDigit.Text.Trim();
                    if (TxtTaxDecimal.Text.Trim() != string.Empty)
                    {
                        TAX += "." + TxtTaxDecimal.Text.Trim();
                    }
                    if (!db.Percentages.AsNoTracking().Any(p => p.name == "TAX"))
                    {
                        Percentage newTaxPercentage = new Percentage
                        {
                            name = "TAX",
                            Precent = Convert.ToDouble(TAX)
                        };
                        db.Percentages.Add(newTaxPercentage);
                    }
                    else
                    {
                        Percentage TAXPercent = (from P in db.Percentages
                                                 where P.name == "TAX"
                                                 select P).FirstOrDefault();
                        TAXPercent.Precent = Convert.ToDouble(TAX);
                    }
                    db.SaveChanges();
                }
                utility.Show_Message("تغییرات با موفقیت اعمال شد", "پیغام عملیات");
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show(SqlServerErrorManagment.ShowError(ex, "مالیات بر ارزش افزوده"), "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                return;
            }
            catch (Exception)
            {
                MessageBox.Show("در عملیات ثبت مالیات بر ارزش افزوده خطایی رخ داده", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                return;
            }
        }
    }
}
