using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Hornets.Bytom.Coffee13.TaskTrainingTree;

namespace Toci.Hornets.UnitTests.Bytom.Coffee13
{
    [TestClass]
    public class CoffeeFileOperationTest
    {
        [TestMethod]
        public void TestMethod1()
        {

            //path do refaktoryzacji 
            var path = @"..\..\Bytom\Coffee13\Transfers.xml";
            

            var test = new CoffeeFileOperation();

            Assert.AreEqual(test.GetFileContent(path), "Dane testowe");

        }
    }
}
