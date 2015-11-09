using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

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
        String t = title.Value;
        HttpPostedFile image=pic.PostedFile;
    }

}