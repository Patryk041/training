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
          StringManipulationClass manipulation = new StringManipulationClass();

           manipulation.RunStringOperations("domi", "do");
           manipulation.RunStringOperations("domi", "imdo");
           manipulation.RunStringOperations("domi", "ido");
           manipulation.RunStringOperations("domi", "omoi");
           manipulation.RunStringOperations("domi", "odmi");
           manipulation.RunStringOperations("domi", "mi");
        }
    }
}
