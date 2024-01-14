using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Policy : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Image1.Visible = false;
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Literal2.Text = "";
        double  income = double.Parse(TextBox1.Text);
        if (income < 500000)
        {
            Literal2.Text = "Not applicable any tax";
        }
        else if (income >= 500000 && income < 1000000)
        {
            Image1.Visible = true ;
        }
        else if (income >= 1000000 && income < 1500000)
        {
            Image1.Visible = true ;
        }
        else
        {
            Image1.Visible = true ;
        }
    }
}