using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Hornets.Gliwice.PracaZespolowa.PrzelewyBankowe;

namespace Toci.Hornets.UnitTests.Gliwice.Rudi
{
    [TestClass]
    public class GliwiceFileOperationTest
    {
        [TestMethod]
        public void FileReadTest()
        {
            GliwiceFileOperation fileReader = new GliwiceFileOperation();
            String wczytaneZPliku=fileReader.GetFileContent("..\\..\\Gliwice\\Rudi\\testFileToRead.txt");
            Console.Write(wczytaneZPliku);

            Assert.IsTrue(wczytaneZPliku==
@"to
jest
testowy
plik
to
odczytu");

        }
    }
}
