using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.TraininigLibrary.Logic
{
    public static class DirectoryFileList
    {  /// <summary>
        /// Zwraca ścieżki plików w katalogu. Domyślnie "~\Toci.TrainingLibrary\data"
        /// </summary>
        /// <param name="path">Ścieżka katalogu, default = ~\Toci.TrainingLibrary\data</param>
        public static string[] GetPathList(string path="")
        {

            path = path == "" ? new StringBuilder(Directory.GetParent(
              Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).ToString()).ToString())
              .ToString()).Append(@"\Toci.TraininigLibrary\data").ToString() : path;
           
     
            return Directory.GetFiles(path);
        }

        /// <summary>
        /// Zwraca nazwy parserów zapisane dużymi literami (.ToUpper())
        /// </summary>
        /// <param name="filesList">Tablica strimmg[] listy plików</param>
        public static string GetParserName(string fileName)
        {
            int j = 0;
            string result = "";

            var splitList = fileName.Split(new char[] { '_' });

            while (splitList[splitList.Length - 1][j] != '.')
            {
                result += splitList[splitList.Length - 1][j];
                j++;
            }

            return result;
        }
    }
}
