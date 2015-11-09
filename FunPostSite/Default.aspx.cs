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

    //StringBuilder sb = new StringBuilder();
    //sb.Append(@"<table>
    // <tr>
    //     <td>
    //      some text written in 1st td
    //                            </td>
    //                            <td>
    //                                some text written in 2nd td
    //                            </td>
    //                        </tr>
    //                        <tr>
    //                            <td>
    //                                <input id='btn' type='button' value='click me' />
    //                            </td>
    //                            <td>
    //                                <input id='txt' type='text' value='enter in me' />
    //                            </td>
    //                        </tr>
    //                    </table>"
    //                );
    //            Response.Write(sb.ToString());


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