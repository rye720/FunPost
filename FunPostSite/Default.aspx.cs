using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Data.SqlClient;
/// <summary>
/// server side control
/// </summary>
public partial class _Default : System.Web.UI.Page
{
     /// <summary>
     /// output all the posts that are currently stored in the directory
     /// </summary>
     /// <param name="sender"></param>
     /// <param name="e"></param>
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

     /// <summary>
     /// make the new post form appear
     /// </summary>
     /// <param name="sender"></param>
     /// <param name="e"></param>
    protected void newpostbtn_click(object sender, EventArgs e)
    {
        newPost.Visible = true;
        unhide.Visible = false;
    }
     /// <summary>
     /// stored the title of the post and the picture post into local directory(name the picture file as the title of the post from the textbox
     /// </summary>
     /// <param name="sender"></param>
     /// <param name="e"></param>
    protected void submitbtn_click(object sender, EventArgs e)
    {
         
         bool validate =false;
        String t = ti.Value;
        HttpPostedFile image=pic.PostedFile;
        int s = image.FileName.IndexOf(".");
         String ext =image.FileName.Substring(s);
         switch (ext)
         {
              case ".jpg" :
                   validate = true;
                   break;
              case ".JPG":
                   validate = true;
                   break;
              case ".tif" :
                   validate = true;
                   break;
              case ".gif" :
                   validate = true;
                   break;
         }
         if (validate)
         {
              unhide.Visible = true;
              newPost.Visible = false;
              String r = image.FileName.Substring(s);
              var path = Path.Combine(Server.MapPath("~/Appdata"), t + r);
              image.SaveAs(path);
              info.InnerHtml = " ";
              Page_Load(sender, e);
         }
         else
              info.InnerHtml = "Please select an image file with the extension of jpg, gif, or tif";
              
              
    }
     
     /// <summary>
     /// unfinished comment method after comment button clicked
     /// </summary>
     /// <param name="sender"></param>
     /// <param name="e"></param>
    protected void comment_click(object sender, EventArgs e)
    {
         Button c=(Button)sender;
         ///Application.Contents;
         //HttpPostedFile image;
         ///var path = Path.Combine(Server.MapPath("~/Appdata"), t + r);
         ///image.SaveAs(path);
         
    }
     /// <summary>
     /// store files in database from website
     /// </summary>
     /// <param name="sender"></param>
     /// <param name="e"></param>
     /*
    protected void btnUpload_Click(object sender, EventArgs e)
    {
         // Read the file and convert it to Byte Array
         string filePath = pic.PostedFile.FileName;
         string filename = Path.GetFileName(filePath);
         string ext = Path.GetExtension(filename);
         string contenttype = String.Empty;

         //Set the contenttype based on File Extension
         switch (ext)
         {
              case ".doc":
                   contenttype = "application/vnd.ms-word";
                   break;
              case ".docx":
                   contenttype = "application/vnd.ms-word";
                   break;
              case ".xls":
                   contenttype = "application/vnd.ms-excel";
                   break;
              case ".xlsx":
                   contenttype = "application/vnd.ms-excel";
                   break;
              case ".jpg":
                   contenttype = "image/jpg";
                   break;
              case ".png":
                   contenttype = "image/png";
                   break;
              case ".gif":
                   contenttype = "image/gif";
                   break;
              case ".pdf":
                   contenttype = "application/pdf";
                   break;
         }
         if (contenttype != String.Empty)
         {

              Stream fs = pic.PostedFile.InputStream;
              BinaryReader br = new BinaryReader(fs);
              Byte[] bytes = br.ReadBytes((Int32)fs.Length);

              //insert the file into database
              string strQuery = "insert into tblFiles(Name, ContentType, Data)" +
                 " values (@Name, @ContentType, @Data)";
              SqlCommand cmd = new SqlCommand(strQuery);
              cmd.Parameters.Add("@Name", SqlDbType.VarChar).Value = filename;
              cmd.Parameters.Add("@ContentType", SqlDbType.VarChar).Value
                = contenttype;
              cmd.Parameters.Add("@Data", SqlDbType.Binary).Value = bytes;
              InsertUpdateData(cmd);
              lblMessage.ForeColor = System.Drawing.Color.Green;
              lblMessage.Text = "File Uploaded Successfully";
         }
         else
         {
              lblMessage.ForeColor = System.Drawing.Color.Red;
              lblMessage.Text = "File format not recognised." +
                " Upload Image/Word/PDF/Excel formats";
         }
    }
      * */


}