using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EF2DEMO
{
    public partial class LectureDemo : Form
    {
        public LectureDemo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DafestyEntities context = new DafestyEntities();
            Customer c = context.Customers.Where(x => x.CustomerID == "1001").First();
            //label1.Text = c.CustomerName;
            //label2.Text = c.Country.CountryName;

            Country cn = context.Countries.First(x => x.CountryCode == "SWZ");
            label1.Text = cn.CountryName;
            foreach(Customer cx in cn.Customers)
            {
                label2.Text += cx.CustomerName + Environment.NewLine;
            }

        }
    }
}
