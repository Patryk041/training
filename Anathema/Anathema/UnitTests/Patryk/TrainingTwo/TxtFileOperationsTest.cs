using System.IO;
using Anathema.Patryk.TrainingTwo;
using Anathema.Patryk.TrainingTwo.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.Patryk.TrainingTwo
{
    [TestClass]
    public class TxtFileOperationsTest
    {
        [TestMethod]
        public void ReadFromFileTest()
        {
            string path = @"..//..//Patryk//TrainingTwo//Files//SomeText.txt";

            FileOperations fileOperations = new FileOperations();

            string result = fileOperations.ReadAllContent(path);


            fileOperations.AppendTextToFile("jakis przykladowy tekst",path);



        }
    }
}