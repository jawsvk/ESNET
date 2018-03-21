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
    public partial class Movie_Maintenance : Form
    {
        DafestyEntities1 ctx = new DafestyEntities1();
        

        public Movie_Maintenance()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void showData( Movie m)
        {
            vidcodeBox.Text = m.VideoCode.ToString();
            movieTitleBox.Text = m.MovieTitle.ToString();
            genreBox.Text = m.Genre.ToString();
            priceBox.Text = m.RentalCost.ToString();

        }
        private void load_btn_Click(object sender, EventArgs e)
        {
            Movie m = ctx.Movies1.First();
            showData(m);
           // int y = Convert.ToInt32(vidcodeBox.Text);
           // statusStrip1.Text = "Record " + y.ToString();
        }

        private void next_btn_Click(object sender, EventArgs e)
        {
            int y = Convert.ToInt32(vidcodeBox.Text);
            Movie lastone = ctx.Movies1.OrderByDescending(x => x.VideoCode).First();

            Movie current = ctx.Movies1.Where(x => x.VideoCode == y).First();
            if (lastone.VideoCode == current.VideoCode)
            {
               MessageBox.Show("Last Entry Reached");
            }
            else
            {
                current = ctx.Movies1.Where(x => x.VideoCode == y + 1).First();
            }
            showData(current);
            
           
             
        }

        private void prev_btn_Click(object sender, EventArgs e)
        {
            int y = Convert.ToInt32(vidcodeBox.Text);
            
            if (y != 1)
            {
                Movie m = ctx.Movies1.Where(x => x.VideoCode == y - 1).First();
                showData(m);
                statusStrip1.Text = "Record " + y.ToString();
            }
            else MessageBox.Show("First Entry Reached");
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            int y = Convert.ToInt32(vidcodeBox.Text);
            Movie m = ctx.Movies1.Where(x => x.VideoCode == y).First();
            m.VideoCode = Convert.ToInt16(vidcodeBox.Text);
            m.MovieTitle = movieTitleBox.Text;
            m.Genre = genreBox.Text;
            m.RentalCost = float.Parse(priceBox.Text);

            ctx.SaveChanges();
        }

        private void insert_btn_Click(object sender, EventArgs e)
        {
            Movie m = new Movie();
            m.VideoCode = Convert.ToInt16(vidcodeBox.Text);
            m.MovieTitle = movieTitleBox.Text;
            m.Genre = genreBox.Text;
            m.RentalCost = float.Parse(priceBox.Text);
            ctx.Movies1.Add(m);
            ctx.SaveChanges();
            showData(m);

        }

        private void del_btn_Click(object sender, EventArgs e)
        {
            int y = Convert.ToInt32(vidcodeBox.Text);
            Movie m = ctx.Movies1.Where(x => x.VideoCode == y).First();
            ctx.Movies1.Remove(m);
            ctx.SaveChanges();
        }

        private void first_btn_Click(object sender, EventArgs e)
        {
            Movie m = ctx.Movies1.First();
            showData(m);

        }

        private void last_btn_Click(object sender, EventArgs e)
        {

            Movie m = ctx.Movies1.OrderByDescending(x => x.VideoCode).First();
            showData(m);
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            int code = int.Parse(searchBox.Text);
            Movie m = ctx.Movies1.Where(x => x.VideoCode == code).First();
            showData(m);
        }
    }
}
