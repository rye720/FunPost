using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Class1
/// </summary>
public class FilePar
{
	public FilePar()
	{
		//
		// TODO: Add constructor logic here
		//
	}
     public static bool validate(HttpPostedFile a)
     {
          int s = a.FileName.IndexOf(".");
          String ext = a.FileName.Substring(s);
          ext = ext.ToLower();
          bool validate= false;
          //make sure the user didn't change the extension to send the picture
          if (a.ContentType.ToLower() != "image/jpg" &&
                    a.ContentType.ToLower() != "image/jpeg" &&
                    a.ContentType.ToLower() != "image/pjpeg" &&
                    a.ContentType.ToLower() != "image/gif" &&
                    a.ContentType.ToLower() != "image/x-png" &&
                    a.ContentType.ToLower() != "image/png")
          {
               return false;
          }
          switch (ext)
          {
               case ".jpg":
                    validate = true;
                    break;
               case ".jpeg":
                    validate = true;
                    break;
               case ".tif":
                    validate = true;
                    break;
               case ".gif":
                    validate = true;
                    break;
          }
          return validate;
     }
     public static void saveFile(String title, HttpPostedFile s, String serverPath)
     {
          int a = s.FileName.IndexOf(".");
          String r = s.FileName.Substring(a);
          var path =serverPath+title + r;
          s.SaveAs(path);
     }
}