using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.BeginnersTrainingLibrary.TrainingOne.Matwie.DateValidator;
using Toci.BeginnersTrainingLibrary.TrainingOne.Matwie.TextUtils;

namespace Toci.BeginnersTest.TrainingOne.MatwieUnitTests
{
    [TestClass]
    public class MatwieTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            MatwieDateValidator validator = new MatwieDateValidator();
            Assert.IsTrue(validator.CheckDate(1993, 7, 7));
            Assert.IsTrue(validator.CheckDate(2015, 8, 4));
            Assert.IsTrue(validator.CheckDate(2012, 2, 29));
            Assert.IsFalse(validator.CheckDate(2000000, 0, 0));
            Assert.IsFalse(validator.CheckDate(2000, 10, 0));
            Assert.IsFalse(validator.CheckDate(2013, 2, 29));
            Assert.IsFalse(validator.CheckDate(-2000, 5, 18));
            Assert.IsFalse(validator.CheckDate(2000, -5, 18));
            Assert.IsFalse(validator.CheckDate(2000, 5, -18));
        }

        /*       [TestMethod]
               public void TestPalindrom()
               {
                   Palindroms pal = new Palindroms();
                   Assert.IsTrue(pal.isPalindrom("kajak"));
                   Assert.IsFalse(pal.isPalindrom("zadasda"));
                   Assert.IsTrue(pal.isPalindrom("abccba"));
            
               }*/

      /*  [TestMethod]
        public void TestAnagrams()
        {
            string[] s = new string[]{"test"};
            Anagrams a = new Anagrams(s);
            Assert.IsTrue(a.MatchToExpression("test", "estt"));
            Assert.IsFalse(a.MatchToExpression("test", "ettt"));
    
        }*/
    }
}
