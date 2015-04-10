using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.S2yfr4nt.omr
{
    public class BookShop
    {

        public static string bookShopName;

        public BookShop(string _BookShopName)
        {
            bookShopName = _BookShopName;
        }
        public  void PrintBill(string path, BookShopFeatures bookShopFeatures)
        {
            FileStream fileStream;
            fileStream = new FileStream(path, FileMode.Truncate);
            StreamWriter streamWriter = new StreamWriter(fileStream);

            string[] feature = bookShopFeatures.BillInformation();

            streamWriter.WriteLine(bookShopName);
            for (int i = 0; i < feature.Length; i++)
            {
                streamWriter.WriteLine(feature[i]);
            }

            streamWriter.Close();
        }
    }
}
