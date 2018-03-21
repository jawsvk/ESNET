using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class EF_exe2 : Form
    {
        DafestyEntities ctx = new DafestyEntities();
        DafestyEntities2 ctx2 = new DafestyEntities2();

        public EF_exe2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //using linq Q9
            // var q = from x in ctx.Movies where x.Rating == "R" select new { x.VideoCode, x.MovieTitle, x.RentalPrice };

            //using linq Q10
            //var q = from x in ctx.Movies group x by x.MovieType into g select new { MovieType =g.Key, TotalStock=g.Sum(x => x.TotalStock) };

            //using linq Q11
            // var q = from x in ctx2.Movies where x.VideoCode == 5 select new { x.MovieTitle, x.Rating, x.Producer.ProducerName };

            //using linq Q12
            //var q = from x in ctx2.Movies where x.Producer.ProducerID == "Walt" select new { x.Producer.ProducerName, x.MovieTitle, x.MovieType };
            //using linq Q13
            var q = from x in ctx2.Movies select new { x.MovieTitle, x.Rating, x.MovieType, x.Producer.ProducerName };
            dataGridView1.DataSource = q.ToList();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //using lambda Q9
            // dataGridView1.DataSource = ctx.Movies.Where(x => x.Rating == "R").Select(x => new { x.VideoCode, x.MovieTitle, x.RentalPrice }).ToList();

            //using lambda Q10
            //dataGridView1.DataSource = ctx.Movies.GroupBy(x => x.MovieType).Select(y => new { MovieType = y.Key, TotalStock = y.Sum(x => x.TotalStock) }).ToList();
            //using lambda Q11
            //dataGridView1.DataSource = ctx2.Movies.Where(x => x.VideoCode == 5).Select(x => new { x.MovieTitle, x.Rating, x.Producer.ProducerName }).ToList();
            //using lambda Q12
            // dataGridView1.DataSource = ctx2.Movies.Where(x => x.Producer.ProducerID == "Walt").Select(x => new { x.Producer.ProducerName, x.MovieTitle, x.MovieType }).ToList();
            //using lambda Q13
            dataGridView1.DataSource = ctx2.Movies.Select(x => new { x.MovieTitle, x.Rating, x.MovieType, x.Producer.ProducerName }).ToList();
        }
    }
}
