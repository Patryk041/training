using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Hornets.Gliwice.Didi.StringManiupulation;

namespace Toci.Hornets.UnitTests.Gliwice.Didi.StringManipulation
{
    [TestClass]
   public class StringManipulationTest
    {
       [TestMethod]
        public void TestString()
        {
          string subject = "beata";
          string seek = "ata";
          StringManipulationClass stringManipulation = new StringManipulationClass();

          var result = stringManipulation.RunStringOperations(subject, seek);

          Assert.IsTrue(result.IsStringInString);
          Assert.IsTrue(result.IsStringElementsInString);
          Assert.IsFalse(result.IsAnagram);

          subject = "beata";
          seek = "aat";
          result = stringManipulation.RunStringOperations(subject, seek);

          Assert.IsFalse(result.IsStringInString);
          Assert.IsTrue(result.IsStringElementsInString);
          Assert.IsFalse(result.IsAnagram);

          subject = "beata";
          seek = "tbaea";
          result = stringManipulation.RunStringOperations(subject, seek);

          Assert.IsFalse(result.IsStringInString);
          Assert.IsTrue(result.IsStringElementsInString);
          Assert.IsTrue(result.IsAnagram);

          subject = "beata";
          seek = "beata";
          result = stringManipulation.RunStringOperations(subject, seek);

          Assert.IsTrue(result.IsStringInString);
          Assert.IsTrue(result.IsStringElementsInString);
          Assert.IsTrue(result.IsAnagram);

          subject = null;
          seek = null;
          result = stringManipulation.RunStringOperations(subject, seek);

          Assert.IsFalse(result.IsStringInString);
          Assert.IsFalse(result.IsStringElementsInString);
          Assert.IsFalse(result.IsAnagram);

          subject = "domi";
          seek = "odi";
          result = stringManipulation.RunStringOperations(subject, seek);

          Assert.IsFalse(result.IsStringInString);
          Assert.IsTrue(result.IsStringElementsInString);
          Assert.IsFalse(result.IsAnagram);

          subject = "didi";
          seek = "didi";
          result = stringManipulation.RunStringOperations(subject, seek);

          Assert.IsTrue(result.IsStringInString);
          Assert.IsTrue(result.IsStringElementsInString);
          Assert.IsTrue(result.IsAnagram);
         
        }
    }
}
