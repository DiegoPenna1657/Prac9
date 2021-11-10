using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Linq;
using System.Xml.Linq;

namespace WebApplication1
{

    public partial class WebForm1 : System.Web.UI.Page
    {
        /*
        public class Genre
        {
            public int ID { get; set; }
            public string Name { get; set; }
        }
        public List<Genre> GetGenres()
        {
            return new List<Genre> { new Genre { ID=0, Name="Comedy" } , new Genre { ID=1, Name="Drama" } , new Genre { ID=2, Name="Action" }};
        }
        public class Movie
        {
            public string Title { get; set; }
            public string Director { get; set; }
            public int Genre
            { get; set; }
            public int RunTime { get; set; }
            public DateTime ReleaseDate { get; set; }
        }

        public class Grouping
        {
            public int Genre { get; set; }
            public int MovieCount { get; set; }
        }
        */

        protected void Page_Load(object sender, EventArgs e)
        {
            MoviesEntities dc = new MoviesEntities(); var query = from m in dc.Movie select m;
            GridView1.DataSource = query.ToList();
            GridView1.DataBind();
        }


        /*
                public List<Movie> GetMovies()
                {
                    return new List<Movie> {
                        new Movie { Title="Shrek", Director="Andrew Adamson", Genre=0, ReleaseDate=DateTime.Parse("16/5/2001"), RunTime=89 },
                        new Movie { Title="Fletch", Director="Michael Ritchie", Genre=0, ReleaseDate=DateTime.Parse("31/5/1985"), RunTime=96 },
                        new Movie { Title="Casablanca", Director="Michael Curtiz", Genre=1,ReleaseDate=DateTime.Parse("1/1/1942"), RunTime=102 },
                        new Movie { Title="Batman", Director="Tim Burton", Genre=1,ReleaseDate=DateTime.Parse("23/6/1989"), RunTime=126 }
                    };
                }


            }
            public class LastNameComparer : IComparer<string>
            {
                public int Compare(string x, string y)
                {
                    var director1LastName = x.Substring(x.LastIndexOf(' ')); var
                 director2LastName = y.Substring(y.LastIndexOf(' ')); return
                 director1LastName.CompareTo(director2LastName);
                }
        */
    }


}