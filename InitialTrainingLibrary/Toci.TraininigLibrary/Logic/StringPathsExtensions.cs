using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.TraininigLibrary.Logic
{
    public static class StringPathsExtensions

    {

        /// <summary>
        /// Zwraca ścieżki plików w katalogu. Dla paramteru "" domyślnie "~\Toci.TrainingLibrary\data"
        /// </summary>
        /// <param name="path">Ścieżka katalogu, default = ~\Toci.TrainingLibrary\data</param>
        public static string[] GetDirectoryFileList(this string path)
        {

            path = path == "defaultPath" ? new StringBuilder(Directory.GetParent(
                 Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).ToString()).ToString())
                 .ToString()).Append(@"\Toci.TraininigLibrary\data").ToString() : path;

            return Directory.GetFiles(path);

        }
        
        /// <summary>
        /// Zwraca nazwy parserów zapisane dużymi literami (.ToUpper())
        /// </summary>
        /// <param name="filesList">Tablica strimmg[] listy plików</param>
        public static string GetName(this string filePath)
        {
      
            string name = "";
         
                var splitList = filePath.Split(new char[] { '_' });

                int j = 0;
                while (splitList[splitList.Length - 1][j] != '.')
                {
                    name += splitList[splitList.Length - 1][j];
                    j++;
                }
           

            return name.ToUpper();

        }

      
    }
}
