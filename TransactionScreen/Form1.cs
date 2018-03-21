using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransactionScreen
{
    
    public partial class Form1 : Form
    {
        DafestyEntities context = new DafestyEntities();
        Customer c;
        Movie m;
        IssueTran newTrans = new IssueTran();
        Customer_Lookup f = new Customer_Lookup();
        
        public Form1()
        {
            InitializeComponent();
           
        }
        public string custID { get; set; }
        public string custName { get; set; }


        private void getTransID()
        {

            IssueTran latest = context.IssueTrans.OrderByDescending(x => x.TransactionID).First();
            
            newTrans.TransactionID += latest.TransactionID;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            newTrans.CustomerID = c.CustomerID;
            newTrans.VideoCode = m.VideoCode;
            newTrans.DateIssue = issueDate.Value;
            newTrans.DateDue = dueDate.Value;
            newTrans.Remarks = remarksBox.Text;
            newTrans.RentalStatus = "out";
            getTransID();
           
            context.IssueTrans.Add(newTrans);
            context.SaveChanges();
        }

        private void customerIDBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                c = context.Customers.Where(x => x.CustomerID == customerIDBox.Text).First();

                CustNameBox.Text = c.CustomerName;
            }

        }

   
        private void vidCodeBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                short num = short.Parse(vidCodeBox.Text);
                m = context.Movies1.Where(x => x.VideoCode == num).First();
                movieTitleBox.Text = m.MovieTitle;
            }
        }

        private void cust_lookup_Click(object sender, EventArgs e)
        {
           
            f.ShowDialog(this);
            customerIDBox.Text = custID;
            CustNameBox.Text = custName;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            f.referen = this;
            customerIDBox.Text = custID;
            CustNameBox.Text = custName;
        }
    }
}
