﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Donations : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(Session["userKey"]==null)
        {
            Response.Redirect("Default.aspx");

            Community_AssistEntities cae = new Community_AssistEntities();
            var dons = from d in cae.Donations where d.PersonKey == (int)Session["userKey"] select d;
            GridView1.DataSource = dons.ToList();
            GridView1.DataBind();

        }
    }
}