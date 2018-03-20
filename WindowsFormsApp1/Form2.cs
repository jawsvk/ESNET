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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            string conS = "data source = (local);integrated security=SSPI;initial catalog=Dafesty";
            SqlConnection cn = new SqlConnection(conS);
            SqlCommand cm = new SqlCommand();
            cm.Connection = cn;
            cm.CommandText = "select * from Movies";
            cn.Open();
            SqlDataReader rd = cm.ExecuteReader();


            while (rd.Read())
            {
                string prices = rd["RentalPrice"].ToString();
                movieList.Items.Add(rd["MovieTitle"].ToString()+"\t" + prices);
            }
            

            cn.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
        }
    }
}
