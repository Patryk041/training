using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.TraininigLibrary.Developers.Mg.Inheritance.Common_interface_solution;
using Toci.TraininigLibrary.Developers.Mg.Inheritance.Simple_Inheritance;

namespace Toci.TrainingLibrary.Test.Developers.Mg.Inheritance
{
    [TestClass]
    public class MgInheritanceTest
    {
        [TestMethod]
        public void TestMethod1()
        { 
            
            //simple inheritance
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

            //=============================common interface inheritance============================

            //dictionary
            MgCommonDictionary<string> mgCommonDictionary = new MgCommonDictionary<string>();
            mgCommonDictionary.Add("abccba", "1");
            mgCommonDictionary.Add("rower", "2");
            mgCommonDictionary.Add("weror", "3");
            mgCommonDictionary.Add("abc234324", "4");

            var commonPalindromList = mgCommonDictionary.GetPalindromSet();
            var commonAnagramList = mgCommonDictionary.GetAnagramSet("roewr");
            var commonWildCardList = mgCommonDictionary.GetWildcardSet("abc");

            //sorted list

            MgCommonNonGenericSortedList<string> mgCommonSortedList = new MgCommonNonGenericSortedList<string>();
            mgCommonSortedList.Add("abccba", "1");
            mgCommonSortedList.Add("rower", "2");
            mgCommonSortedList.Add("weror", "3");
            mgCommonSortedList.Add("abc234324", "4");

            var commonSortedPalindromList = mgCommonSortedList.GetPalindromSet();
            var commonSortedAnagramList = mgCommonSortedList.GetAnagramSet("roewr");
            //var commonSortedWildCardList = mgCommonSortedList.GetWildcardSet("abc");
      

        }
    }
}
