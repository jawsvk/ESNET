using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day3Lecture
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DafestyEntities context = new DafestyEntities();
            var q = from x in context.Customers
                    select new { x.CustomerID, x.CustomerName, x.MemberCategory } ; //this is an anonymous class and is temporary
            dataGridView1.DataSource = q.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DafestyEntities context = new DafestyEntities();
            //combination of linq and lambda
            var q = from x in context.Customers
                    group x by x.MemberCategory into g
                    select new { MC=g.Key, AMT=g.Sum(y=>y.AmountSpent)};
            dataGridView1.DataSource = q.ToList();
        }
    }
}
