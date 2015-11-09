using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }



    protected void newpostbtn_click(object sender, EventArgs e)
    {
        newPost.Visible = true;
    }

    protected void submitbtn_click(object sender, EventArgs e)
    {
        newPost.Visible = false;
    }

}