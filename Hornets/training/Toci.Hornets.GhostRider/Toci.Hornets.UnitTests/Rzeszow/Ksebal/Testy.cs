using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Hornets.GhostRider.YourWork.TasksTrainingTwo;
using Toci.Hornets.Rzeszow.KSebal.traning2Homework;

namespace Toci.Hornets.UnitTests.Rzeszow.Ksebal
{
    [TestClass]
   public  class Testy
    {

          [TestMethod]

           public void AnagramTest()
           {
               KsebalStringManipulationClass Ksebal= new KsebalStringManipulationClass();
              StringManipulationsResults results = Ksebal.RunStringOperations("EMIN", "mN");
              //StringManipulationsResults result;

             ///Assert.IsTrue(Ksebal.test("Karolina", "Karo"));
             Assert.IsFalse(results.IsStringInString);
             //Assert.IsTrue(Ksebal.test("Karolina", "Kla"));
             Assert.IsFalse(results.IsAnagram);
             Assert.IsTrue(results.IsStringElementsInString);

             results=Ksebal.RunStringOperations("ZaqWsx", "XsWaZq");
             Assert.IsFalse(results.IsStringInString);
             //Assert.IsTrue(Ksebal.test("Karolina", "Kla"));
             Assert.IsTrue(results.IsAnagram);
             Assert.IsTrue(results.IsStringElementsInString);



           }
       
    }
}
