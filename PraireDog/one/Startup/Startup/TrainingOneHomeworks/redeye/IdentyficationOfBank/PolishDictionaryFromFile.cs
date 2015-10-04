using System.Collections.Generic;
using System.IO;
using System.Text;
using Startup.TrainingOneHomeworks.redeye.IdentyficationOfBank.Interfaces;

namespace Startup.TrainingOneHomeworks.redeye.IdentyficationOfBank
{
    public class PolishDictionaryFromFile : IMakeDictionaryFromFile
    {

        public System.Collections.Generic.Dictionary<string, string> MakeDictionary(string path, Encoding en)
        {
            Dictionary<string,string> polishDictionary = new Dictionary<string, string>();

            IGetFile fwd = new FileWidthData();
            FileInfo fileDictionary = fwd.GetFile(@"http://www.nbp.pl/banki_w_polsce/ewidencja/dz_bank_jorg.txt");

            using (StreamReader sr = new StreamReader(fileDictionary.OpenRead(), en))
            {
                string text;
                string[] arrayStrings;
                while ((text = sr.ReadLine()) != null)
                {
                    arrayStrings = text.Split(new char[] {'\t'},3 );
                    string kod = arrayStrings[0].Trim();

                    if (!polishDictionary.ContainsKey(kod))
                    {
                        polishDictionary.Add(kod,arrayStrings[1].Trim());
                    }

                }
            }
            

            return polishDictionary;
        }
    }
}