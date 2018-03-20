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

namespace WindowsFormsApp1
{
    public partial class DataSetEx : Form
    {
        static SqlCommand cm = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter(cm);
        DataSet ds = new DataSet();
        public DataSetEx()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          string conS = "data source = (local);integrated security=SSPI;initial catalog=Dafesty";
         SqlConnection cn = new SqlConnection(conS);

        SqlCommand cm = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter(cm);
        
        SqlCommandBuilder cmb = new SqlCommandBuilder(da);
        cm.Connection = cn;

            cm.CommandText = "select CustomerID,CustomerName,MemberCategory from Customers";
            cn.Open();

          
          
            // label1.Text = ds.Tables.Count.ToString();
            da.Fill(ds, "Customers");
            //label1.Text = ds.Tables[0].Columns.Count.ToString(); //count number of columns

           label1.Text = ds.Tables[0].Rows[0][1].ToString(); //will show cell value 

        
           // label1.Text= cmb.GetInsertCommand().CommandText; //shows actual 
            //need to have command builder before update command will work
            cn.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataRow r = ds.Tables["Customers"].NewRow();
            r["CustomerID"] = "1007";
            r["CustomerName"] = "Venkat";
            r["MemberCategory"] = "C";
           

            da.Update(ds, "Customers");
        }
    }
}
