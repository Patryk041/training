using System;
using System.IO;
using System.Text;
using iTextSharp.text.pdf.parser.clipper;

namespace Startup.TrainingOneHomeworks.Mati.GeneratorClass
{

    public class GeneratorClass : IGeneratorClass
    {

        public GeneratorClass()
        {
            CreateClass();
        }

        public void CreateClass()
        {
            StreamWriter fileOut;
            StreamReader fileIn;
            StreamReader fileBanksLists = new StreamReader(@"../../../Startup\TrainingOneHomeworks\GroupMati\Bank\Banks\GeneratorClass\BanksLists.txt");


            while (!fileBanksLists.EndOfStream)
            {
                string nameBank = fileBanksLists.ReadLine();
                fileIn = new StreamReader(@"../../../Startup\TrainingOneHomeworks\GroupMati\Bank\Banks\GeneratorClass\Generator.txt");
                fileOut = new StreamWriter(string.Format(@"../../../Startup\TrainingOneHomeworks\GroupMati\Bank\Banks\{0}BankTransaction.cs", nameBank));
                while (!fileIn.EndOfStream)
                {
                    string tmp = "";
                    tmp = fileIn.ReadLine();
                    fileOut.WriteLine(tmp.Contains("{0}") ? String.Format(tmp, nameBank) : tmp);

                }
                fileOut.Close();
                fileIn.Close();
            }

        }

    }
}