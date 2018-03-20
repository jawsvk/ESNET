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
    public partial class EF_exe : Form
    {
        public EF_exe()
        {
            InitializeComponent();
        }
        private void DisplayAll()
        {
            DafestyEntities context = new DafestyEntities();

            //using QueEx-display all
            //var q = from x in context.Movies select x;
            //datagrid.DataSource = q.ToList();

            //using lambda - display all
            //List<Movy> clist = context.Movies.ToList();
            //datagrid.DataSource = clist;
        }

        private void InAscending()
        {
            DafestyEntities context = new DafestyEntities();
            //using QueEx display all in movie title order
            //var q = from x in context.Movies orderby x.MovieTitle select x;
            //datagrid.DataSource = q.ToList();

            //using lambda
            List<Movy> clist = context.Movies.OrderBy(x => x.MovieTitle).ToList();
            datagrid.DataSource = clist;
            //if descending use OrderByDescending
        }

        private void DescendingRental()
        {
            DafestyEntities context = new DafestyEntities();

            //using QueEx 
            //var q = from x in context.Movies orderby x.RentalPrice descending select x;
            //datagrid.DataSource = q.ToList();

            //using lambda
            List<Movy> clist = context.Movies.OrderByDescending(x => x.RentalPrice).ToList();
            datagrid.DataSource = clist;
        }

        private void DisplayRRated()
        {
            DafestyEntities context = new DafestyEntities();
            //using QueEx-display R rated
            //var q = from x in context.Movies where x.Rating == "R" select x;
            //datagrid.DataSource = q.ToList();

            //using lambda - display R rated
            List<Movy> clist = context.Movies.Where(x => x.Rating == "R").ToList();
            datagrid.DataSource = clist;
        }

        private void WarnerSciFi()
        {
            DafestyEntities context = new DafestyEntities();
            //using QueEx
            //var q = from x in context.Movies where x.MovieType == "Sci-fi" && x.ProducerID == "Warner" select x;
            //datagrid.DataSource = q.ToList();

            //using lambda
            //List<Movy> clist = context.Movies.Where(x => x.ProducerID == "Warner" && x.MovieType == "Sci-fi").ToList();
            //datagrid.DataSource = clist;
        }

        private void ActionMovieCount()
        {
            int count;
            DafestyEntities context = new DafestyEntities();
            //using QueEx
            //var q = from x in context.Movies where x.MovieType == "Action" select x;
            //count = q.Count();

            //datagrid.DataSource = q.ToList();

            //using lambda
            count = context.Movies.Where(x => x.MovieType == "Action").Count();

            label1.Text = count.ToString();

        }

        private void SumActionMovieCopies()
        {
            int? sum;
            DafestyEntities context = new DafestyEntities();
            //using QueEx
           var q = from x in context.Movies where x.MovieType == "Action" select x.TotalStock;
           sum = q.Sum(y=>y.Value);

            //datagrid.DataSource = q.ToList();

            //using lambda
            //sum = context.Movies.Where(x => x.MovieType == "Action").Sum(y => y.TotalStock);

          label1.Text = sum.ToString();
        }

        private void AvgPrice_Comedy()
        {
            float? avg;
            DafestyEntities context = new DafestyEntities();
            //using QueEx
            //var q = from x in context.Movies where x.MovieType == "Comedy" select x.RentalPrice;
            //avg = q.Average(x=>x.Value);

            avg = context.Movies.Where(x => x.MovieType == "Comedy").Average(y => y.RentalPrice);

            label1.Text = avg.ToString();

        }
        private void query_btn_Click(object sender, EventArgs e)
        {
            //DisplayAll()
            //InAscending()
            // DescendingRental();
            //DisplayRRated();
            //WarnerSciFi();
            //ActionMovieCount();
            //SumActionMovieCopies();
            AvgPrice_Comedy();
        }
    }
}
