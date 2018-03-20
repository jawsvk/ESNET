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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Update_btn_Click(object sender, EventArgs e)
        {
            string conS = "data source = (local);integrated security=SSPI; initial catalog=Dafesty";
            SqlConnection cn = new SqlConnection(conS);
            SqlCommand cm = new SqlCommand();
            cm.CommandText = String.Format("Update Movies set RentalPrice = {0} where VideoCode = {1}",Price.Text,VidCode.Text);
            cm.Connection = cn;
            cn.Open();
            cm.ExecuteNonQuery();
            cn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 newForm2 = new Form2();
            newForm2.Show();

           

        }
    }
}
