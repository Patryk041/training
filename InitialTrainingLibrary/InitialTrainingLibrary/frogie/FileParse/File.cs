using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace InitialTrainingLibrary.frogie.FileParse
{
    public class File
    {
        private const string FilePath = @"D:\praca\nowy potencjal\szkolenie\Dropbox\Szkolenie\v 2.0\code\InitialTrainingLibrary\InitialTrainingLibrary\frogie\data\dane.txt";

        public List<string> PodajDaneZPliku()
        {
            List<string> result = new List<string>();

            using (StreamReader reader = new StreamReader(FilePath))
            {
                while (!reader.EndOfStream)
                {
                    result.Add(reader.ReadLine());
                }
            }

            List<Task<string>> taski = new List<Task<string>>();

            for (int i = 0; i < 10; i++)
            {
                //taski.Add(Task.Factory.StartNew());
            }
 
            return result;
        }

        public Dictionary<string, List<string>> PodajDaneZLinii(List<string> lista)
        {
            string[] linia;
            Dictionary<string, List<string>> result = new Dictionary<string, List<string>>();

            foreach (var item in lista)
            {
                linia = item.Split(new [] {"\t"}, StringSplitOptions.None);
                result.Add(linia[0], linia.ToList());
            }

            //result.AsParallel().WithDegreeOfParallelism(10).ForAll();

            return result;
        }
    }
}
