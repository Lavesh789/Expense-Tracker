using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class usercontrol_Login : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        UserTable ut = new UserTable();
        if(ut.checkValue("EmailId",TextBox1.Text ))
        {
            string[] data = ut.GetValues("EmailId", TextBox1.Text, 5);
            if(TextBox2.Text.Equals (data[4]))
            {
                Session["uid"] = data[0];
                Session["uname"] = data[1];
                Response.Redirect("Home.aspx");
            }
            else
            {
                Literal1.Text = "Invalid Id or password";
            }
        }
        else
        {
            Literal1.Text = "Invalid Id or password";
        }
    }
}