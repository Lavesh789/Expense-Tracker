using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class usercontrol_Reg : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        UserTable ut = new UserTable();
        if (TextBox4.Text.Equals(TextBox5.Text))
        {
            ut.Insert("-1", TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text);
            Literal1.Text = "Registered Successfully";
        }
        else
        {
            Literal1.Text = "Password mismatch";
        }

    }
}