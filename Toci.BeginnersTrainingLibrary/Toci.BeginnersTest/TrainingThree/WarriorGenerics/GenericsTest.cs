using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.BeginnersTrainingLibrary.TrainingThree.Generics;

namespace Toci.BeginnersTest.TrainingThree.WarriorGenerics
{
    [TestClass]
    public class GenericsTest
    {
        [TestMethod]
        public void TestGEnerics()
        {
            GenericFactory<string, ExampleClass, Func<string>> f = new GenericFactory<string, ExampleClass, Func<string>>();

            f.CreateInstance("niemaznaczenia");
        }
    }
}
