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
    public partial class Edit_Data : Form
    {
        public Edit_Data()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DafestyEntities context = new DafestyEntities();
            Customer c = new Customer();
            c.CustomerID = "1007";
            c.CustomerName = "Bond";
            c.MemberCategory = "Z";
            //add customer object to database
            context.Customers.Add(c);
            context.SaveChanges();

               
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //delete
            DafestyEntities context = new DafestyEntities();
            Customer c = context.Customers.Where(x => x.CustomerID == "1007").First();
            context.Customers.Remove(c);
            context.SaveChanges(); //to update the database
        }
    }
}
