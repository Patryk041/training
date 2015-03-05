using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Common.FileParser;
using Toci.TraininigLibrary.Common.Interfaces.FileParser;

namespace Toci.TraininigLibrary.Test.koziu
{
    public class FileGenerator : ISaveFile
    {
  
        private const string pattern = @"..\..\..\Toci.TraininigLibrary\data\transfer_{0}_{1}_{2}.txt"; 
        private Random _random = new Random();
        private string _fileName = "";
        private string _fileData = "";      
       
          

        public void Generate(Dictionary<string, List<FileEntityBase>> contents)
        {
            foreach (var content in contents)
            {       
                _fileName = String.Format(pattern, DateTime.Today.ToShortDateString(), _random.Next(100000000, 999999999), content.Key);
                using (StreamWriter sw = new StreamWriter(_fileName))
                {
                    _fileData = "";

                    foreach (var value in content.Value)
                    {
                        _fileData = value.GetLine();    
                        sw.WriteLine(_fileData);
                    }
                    sw.Close();
                }         
            }
            
        }
    }
}
