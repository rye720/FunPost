using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Drawing;
/// <summary>
/// Summary description for Class1
/// </summary>
namespace FileNS
{
    public class FilePar
    {
        public FilePar()
        {
        }
         /*
        public static bool validate(byte[] a)
        {
             try
             {
                  using (MemoryStream ms = new MemoryStream(a))
                       Image.FromStream(ms);
             }
             catch (ArgumentException)
             {
                  return false;
             }
             return true; 
        }
          */

        public static bool saveFile(String title, byte[] s, String serverPath)
        {
             try
             {
                  var path = serverPath + title + ".jpeg";
                  File.WriteAllBytes(path, s);
                  return true;
             }
             catch (Exception)
             {
                  return false;
             }
        }
    }
}