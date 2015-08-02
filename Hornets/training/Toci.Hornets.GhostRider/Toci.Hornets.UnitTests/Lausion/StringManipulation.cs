using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Hornets.Opole.Lausion.TasksTraningTwo.StringManipulation;

namespace Toci.Hornets.UnitTests.Lausion
{
    [TestClass]
    public class StringManipulation
    {
        [TestMethod]
        public void TestMethod()
        {
            LausionStringManipulation ss=new LausionStringManipulation();
            //IsAnagram
            Assert.IsTrue(ss.RunStringOperations("beata", "eaatb").IsAnagram);
            Assert.IsFalse(ss.RunStringOperations("beata", "bartek").IsAnagram);

            //IsStringInString
            Assert.IsFalse(ss.RunStringOperations("beata", "c").IsStringInString);
            Assert.IsTrue(ss.RunStringOperations("beata", "eat").IsStringInString);
            
        }
    }
}