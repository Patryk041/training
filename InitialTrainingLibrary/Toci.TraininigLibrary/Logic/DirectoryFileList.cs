using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.TraininigLibrary.Logic
{
    public static class DirectoryFileList
    {
        public static string[] GetPathList()
        {
            return Directory.GetFiles(@"C:\Dropbox\SzkolenieBartek\InitialTrainingLibrary\Toci.TraininigLibrary\data");
        }

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
                j = 0;
                i++;
            }

            return parserList;
        }
    }
}
