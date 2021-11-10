﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MoviesEntities dc = new MoviesEntities();
            var query = from m in dc.Movie
                        where m.Genre == "0"
                        orderby m.Director
                        select m;
            GridView1.DataSource = query.ToList();
            GridView1.DataBind();
        }


    }
}