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

        [TestMethod]
        public void TestTextUtils()
        {
            string[] possiblyPalindroms = new string[]{"kajak", "aab", "aabbaa"};
            string[] palindroms = new string[]{"kajak", "aabbaa"};
            string[] possiblyAnagrams = new string[] {"kajak", "aab", "aabbaa"};
            string[] anagrams = new string[] {"aabbaa"};
            const string anagramPattern = "aaaabb";
            string[] possiblyWildcards = new string[] { "kajak", "aab", "aabbaa" };
            string[] wildcards = new string[] { "aab", "aabbaa" };
            const string wildcardPattern = "aa"; 

            MatwieTextUtils mtu = new MatwieTextUtils(possiblyPalindroms, possiblyAnagrams, possiblyWildcards);
            Assert.AreEqual(mtu.GetPalindromsSet()[0], palindroms[0]);
            Assert.AreEqual(mtu.GetPalindromsSet()[1], palindroms[1]);
            Assert.AreEqual(mtu.GetAnagramsSet(anagramPattern)[0], anagrams[0]);
            Assert.AreEqual(mtu.GetWildCardSet(wildcardPattern)[0], wildcards[0]);
            Assert.AreEqual(mtu.GetWildCardSet(wildcardPattern)[1], wildcards[1]);

        }
    }


}
