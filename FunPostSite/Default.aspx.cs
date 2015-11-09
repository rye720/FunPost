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
          DirectoryInfo di = new DirectoryInfo(Server.MapPath("~/Appdata"));
          var directories = di.GetFiles("*", SearchOption.AllDirectories);
          foreach (FileInfo d in directories)
          {
               Post.
          }
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
        int s=image.FileName.IndexOf(".");
        String r = image.FileName.Substring(s);
        var path = Path.Combine(Server.MapPath("~/Appdata"), t+r);
        image.SaveAs(path);
    }

}