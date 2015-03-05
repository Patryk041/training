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
        public static string[] GetParsersNames(string[] filesList)
        {
            string[] parserList = new string[filesList.Length];

            int i = 0, j = 0;

            foreach (var x in filesList)
            {
                var splitList = x.Split(new char[] { '_' });

                while (splitList[splitList.Length - 1][j] != '.')
                {
                    parserList[i] += splitList[splitList.Length - 1][j];
                    j++;
                }
                parserList[i] = parserList[i].ToUpper();
                j = 0;
                i++;
            }

            return parserList;
        }
    }
}
