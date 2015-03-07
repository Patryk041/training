using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.TraininigLibrary.Developers.Mg.Inheritance;

namespace Toci.TrainingLibrary.Test.Developers.Mg.Inheritance
{
    [TestClass]
    public class MgInheritanceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            MgStringDictionaryInheritance<string> mgDictionary = new MgStringDictionaryInheritance<string>();

            mgDictionary.Add("abccba","1");
            mgDictionary.Add("rower", "2");
            mgDictionary.Add("weror","3");
            mgDictionary.Add("abc234324","4");

            var palindromList = mgDictionary.GetPalindromSet();
            var anagramList = mgDictionary.GetAnagramSet("roewr");
            var wildCardList = mgDictionary.GetWildcardSet("abc");

            var palindomExtensionList = mgDictionary.GetPalindromSetExtension();
            var anagramExtensionList = mgDictionary.GetAnagramSet("roewr");
            var wildCardExtensionList = mgDictionary.GetWildcardSet("abc");


        }
    }
}
