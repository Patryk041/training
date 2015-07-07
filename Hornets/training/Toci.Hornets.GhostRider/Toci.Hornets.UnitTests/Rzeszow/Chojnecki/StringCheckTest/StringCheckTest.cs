using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Hornets.Rzeszow.Chojnecki.TrainingTwo;

namespace Toci.Hornets.UnitTests.Rzeszow.Chojnecki.StringCheckTest
{
    [TestClass]
    public class StringCheckTest
    {
        [TestMethod]
        public void Test()
        {
            StringCheck sCheck = new StringCheck();      
            //anagramy
            Assert.IsTrue(sCheck.RunStringOperations("beata", "atabe").IsAnagram);
            Assert.IsFalse(sCheck.RunStringOperations("beata", "atabb").IsAnagram);
           
            //string w stringu
            Assert.IsTrue(sCheck.RunStringOperations("beata", "ta").IsStringInString);
            Assert.IsFalse(sCheck.RunStringOperations("beata", "ae").IsStringInString);
           
            //element stringa
            // true: beata; aat, taae, aea
            // false: beata; aaa, taaa, tta, aee
            Assert.IsTrue(sCheck.RunStringOperations("beata", "aat").IsStringElementsInString);
            Assert.IsTrue(sCheck.RunStringOperations("beata", "taae").IsStringElementsInString);
            Assert.IsFalse(sCheck.RunStringOperations("beata", "aaa").IsStringElementsInString);
            Assert.IsFalse(sCheck.RunStringOperations("beata", "tta").IsStringElementsInString);
            Assert.IsFalse(sCheck.RunStringOperations("beata", "").IsStringElementsInString);
        }
    }
}
