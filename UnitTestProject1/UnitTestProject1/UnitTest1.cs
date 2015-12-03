//using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using FileNS;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
         /*
        [TestMethod]
        public void Testvalidate()
        {
             byte[] file = File.ReadAllBytes(@"~\face.JPG");
             Assert.IsTrue(FilePar.validate(file));
             byte[] f = File.ReadAllBytes(@"~\wod.docx");
             Assert.IsFalse(FilePar.validate(f));
        }
          */
         [TestMethod]
        public void FileSave()
        {
             string s = "hi";
              byte[] a = new byte[120];
              string path= "b";
              Assert.IsFalse(FilePar.saveFile(s,a,path));
        }
    }
}
