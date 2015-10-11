using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EsfahanGhos.DataLayer;
using EsfahanGhos.Model;

namespace EsfahanGhos.View
{
    public partial class RegPeopleForPAy : UserControl
    {
        public RegPeopleForPAy()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                using (var db = new Corporation())
                {
                    db.Persons.Add(new Person()
                    {
                        EmployeeFullName = textBox1.Text.Trim(),
                        CellPhone = textBox2.Text.Trim(),
                        EmployeeMaried = false,
                        EmployeeBirth = DateTime.Now,
                        IdentityNumber = "0"

                    });
                    db.SaveChanges();
                    this.Dispose();
                }
            }
            else
            {
                textBox1.Focus();
            }

        }
    }
}

