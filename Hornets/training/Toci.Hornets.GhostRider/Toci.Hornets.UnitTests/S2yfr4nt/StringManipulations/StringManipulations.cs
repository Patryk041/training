using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Hornets.Opole.S2yfr4nt.Homework.S2yfr4ntStringManipulations;

namespace Toci.Hornets.UnitTests.S2yfr4nt.PeselVaidator
{
    [TestClass]
    public class StringManipulations
    {
        [TestMethod]
        public void TestMethod()
        {
            S2yfr4ntStringManipulations stringManipulations = new S2yfr4ntStringManipulations();

            //IsStringElementsInString
            Assert.IsTrue(stringManipulations.RunStringOperations("beata", "eaa").IsStringElementsInString);
            Assert.IsTrue(stringManipulations.RunStringOperations("beata", "taae").IsStringElementsInString);
            Assert.IsFalse(stringManipulations.RunStringOperations("beata", "taaa").IsStringElementsInString);

            //IsStringAnagramOfString
            Assert.IsTrue(stringManipulations.RunStringOperations("beata", "eaatb").IsAnagram);
            Assert.IsFalse(stringManipulations.RunStringOperations("beata", "bartek").IsAnagram);

            //IsStringInString
            Assert.IsFalse(stringManipulations.RunStringOperations("beata", "c").IsStringInString);
            Assert.IsTrue(stringManipulations.RunStringOperations("beata", "beata").IsStringInString);
            Assert.IsTrue(stringManipulations.RunStringOperations("beata", "eat").IsStringInString);

           
        }
    }
}