using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransactionScreen
{
    public partial class Customer_Lookup : Form
    {
        DafestyEntities ctx = new DafestyEntities();
        List<Customer> clist;
        public Form1 referen;

        public Customer_Lookup()
        {
            InitializeComponent();
            
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
           
            if (comboBox.Text == "Customer Name")
            {
                clist = ctx.Customers.Where(x => x.CustomerName == searchBox.Text).ToList();
            }

            if(comboBox.Text == "Member Category")
            {
                clist = ctx.Customers.Where(x => x.MemberCategory == searchBox.Text).ToList();
            }

            cust_grid.DataSource = clist;
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
        }

        private void ok_btn_Click(object sender, EventArgs e)
        {

            referen.custName = cust_grid.SelectedCells[1].Value.ToString();
            referen.custID = cust_grid.SelectedCells[0].Value.ToString();
            Form.ActiveForm.Close();

        }
    }
}
