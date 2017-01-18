using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    

 String[,] holiday = new String[6, 2];


    protected void Page_Load(Object sender, EventArgs e)
    {

        holiday[0, 0] = "New Years";
        holiday[0, 1] = "1/1/2017";
        holiday[1, 0] = "Christmas";
        holiday[1, 1] = "12/5/2017";
        holiday[2, 0] = "Valentines Day";
        holiday[2, 1] = "2/14/2017";
        holiday[3, 0] = "Fourth of July";
        holiday[3, 1] = "7/4/2017";
        holiday[4, 0] = "Halloween";
        holiday[4, 1] = "10/31/2017";
        holiday[5, 0] = "Birthday";
        holiday[5, 1] = "10/31/2017";




      



    }

    protected void Calendar1_SelectionChanged(Object sender, EventArgs e)
    {

       // String holiday[0, 1] = DateTime.Parse("01/01/17");
        Label1.Text = Calendar1.SelectedDate.ToShortDateString();
        for (int i = 0; i < 6; i++)
        {


            if(Calendar1.SelectedDate.ToShortDateString() == holiday[i,1])
        {
                Label1.Text += "<br/>" + holiday[i,0] +"<br/>" ;
            }
        }
    }

   
}