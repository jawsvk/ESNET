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
    public partial class Q4_Form : Form
    {
        DafestyEntities1 ctx = new DafestyEntities1();
        public Q4_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Movie m = ctx.Movies1.Where(x => x.VideoCode == 5).First();

            label1.Text = m.MovieTitle;
            m.RentalCost = (float) 1.8;
            MessageBox.Show("Rental cost changed to " + m.RentalCost.ToString());

            Movie edit1 = ctx.Movies1.Where(x => x.VideoCode == 4).First();
            edit1.Producer.ProducerName = "Pixar Entertainment";
            edit1.ProducerID = "Pixar";
            MessageBox.Show(edit1.Producer.ProducerName + edit1.Producer.ProducerID);

            Producer edit2 = ctx.Producers.Where(x => x.ProducerID == "Warner").First();
            Movie xxx = ctx.Movies1.Where(x => x.VideoCode == 11).First();
            edit2.Movies.Add(xxx);
            ctx.SaveChanges();
            MessageBox.Show(xxx.ProducerID + xxx.Producer.ProducerName);
            dataGridView1.DataSource = ctx.Producers.ToList();
        }
    }
}
