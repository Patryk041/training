using System;
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
            MgStringDictionary<int> abc = new MgStringDictionary<int>();

            abc.Add("abccba","1");
            abc.Add("rower", "2");
            abc.Add("weror","3");
            abc.Add("abc234324","4");
            var palindromList = abc.GetPalindromSet();
            var anagramList = abc.GetAnagramSet("roewr");
            var wildCardList = abc.GetWildcardSet("abc");

        }
    }
}
