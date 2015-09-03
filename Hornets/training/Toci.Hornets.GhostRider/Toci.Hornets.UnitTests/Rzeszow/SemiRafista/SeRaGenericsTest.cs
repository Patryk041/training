using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Hornets.Rzeszow.SemiRafista.TrainingFour;

namespace Toci.Hornets.UnitTests.Rzeszow.SemiRafista
{
    [TestClass]
    public class SeRaGenericsTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            SeRaGenerics<string> testSeRaGenerics = new SeRaGenerics<string>();
            testSeRaGenerics.Add("jeden");
            testSeRaGenerics.Add("dwa");
            testSeRaGenerics.Add("trzy");
            testSeRaGenerics.GetAllItems();
            testSeRaGenerics.Remove("dwa");
            testSeRaGenerics.GetAllItems();
        }
    }
}
