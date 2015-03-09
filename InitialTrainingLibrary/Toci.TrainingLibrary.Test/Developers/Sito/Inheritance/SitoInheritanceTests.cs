using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.TraininigLibrary.Developers.Sito.Inheritance;

namespace Toci.TrainingLibrary.Test.Developers.Sito.Inheritance
{
    [TestClass]
    public class SitoInheritanceTests
    {
        [TestMethod]
        public void SitoExtensionTests()
        {
            Dictionary<string, bool> palindroms = new Dictionary<string, bool>()
            {
                {"aaa", true},
                {"rower", false},
                {"kajak", true},
                {"ala",true},
                {"radar",true},
                {"koń",false},
            };
            Dictionary<string, bool> anagrams = new Dictionary<string, bool>()
            {
                {"anagram", true},
                {"amagraa", true},
                {"gnaaram", true},
                {"anrgaam", true},
                {"anggram", false},
                {"anagrmm", false},

            };
            Dictionary<string, bool> wildcards = new Dictionary<string, bool>()
            {
                {"anagramsdfas", true},
               {"anagramfas", true},
               {"anagramsdfsdfgsdfgas", true},
                {"anagramssfgsfdgdfas", true},
                {"angramsdfas", false},
                {"anagrmm", false},

            };

            var palindromsSet = palindroms.SitoGetPalindromSet();
            var angramsSet = anagrams.SitoGetAnagramSet("anagram");
            var wildcardsSet = wildcards.SitoGetWildcardSet("anagram");

            Assert.IsTrue(palindromsSet.All(x=>x));
            Assert.IsTrue(angramsSet.All(x => x));
            Assert.IsTrue(wildcardsSet.All(x => x));
        }
    }
}
