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
          String done="";
          foreach (FileInfo d in directories)
          {
               done+="<h1>"+d.Name.Substring(0,d.Name.IndexOf("."))+"</h1>";
               done += "<hr>";
               done += "<img src=\"../Appdata/"+ d.Name + "\">";
               //done+="<asp:PlaceHolder runat=\"server\" ID=\"" + d.Name + "\" Visible =\"false\">";
               //done+="<input type=\"file\" runat=\"server\" id=\""+d.Name+"\" accept=\".gif,.jpg,.tif\"/>";
               //done +="<asp:button runat=\"server\" ID=\""+d.Name +"Text=\"submit\" onclick=\"comment_click\" />";
               //done +="</asp:PlaceHolder>";
               done += "<hr size=\"15\">";
          }
          post.InnerHtml = done;
    }


    protected void newpostbtn_click(object sender, EventArgs e)
    {
        newPost.Visible = true;
        unhide.Visible = false;
    }
    protected void submitbtn_click(object sender, EventArgs e)
    {
         unhide.Visible = true;
        newPost.Visible = false;
        String t = title.Value;
        HttpPostedFile image=pic.PostedFile;
        int s=image.FileName.IndexOf(".");
        String r = image.FileName.Substring(s);
        var path = Path.Combine(Server.MapPath("~/Appdata"), t+r);
        image.SaveAs(path);
        Page_Load(sender, e);
    }
     /*
    protected void comment_click(object sender, EventArgs e)
    {
         Button c=(Button)sender;
         Application.Contents;
         HttpPostedFile image =
         var path = Path.Combine(Server.MapPath("~/Appdata"), t + r);
         image.SaveAs(path);
         
    }
      * */

}