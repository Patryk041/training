//using MeOCRLib;
using Puma.Net;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tessnet2;


namespace Toci.TraininigLibrary.Developers.Koziu.OCR.ImageOCR
{
    public static class ImageOCR
    {
        static string resultText;
        const string fileName = @"..\..\..\Toci.TraininigLibrary\Developers\Koziu\OCR\img\ex1.jpg";     
        static Bitmap image = new Bitmap(fileName);
        public static void Test()
        {

            var pumaPage = new PumaPage(fileName);
            // pumaPage.LoadImage(fileName);
            using (pumaPage)
            {
                pumaPage.Language = PumaLanguage.Polish;
                pumaPage.FileFormat = PumaFileFormat.TxtAscii;
                pumaPage.EnableSpeller = false;
                // pumaPage.RecognizeToFile("result1.txt");                 
                resultText = pumaPage.RecognizeToString();
                pumaPage.Dispose();
            }
        }
        public static void Test2()
        {  
            tessnet2.Tesseract ocr = new tessnet2.Tesseract();
            ocr.SetVariable("tessedit_char_whitelist", "0123456789"); // If digit only
            ocr.Init(@"c:\temp", "eng", false); // To use correct tessdata
            List<tessnet2.Word> result = ocr.DoOCR(image, Rectangle.Empty);  
        } 
        //public static void Test3()
        //{               
        //    var orc = new Puma();
        //    orc.Init();
        //    orc.Language = 11;
        //    orc.OutputFormat = 0;
        //    resultText = orc.Recognize(image);
        //    orc.Close();  
        //}
    }
}
