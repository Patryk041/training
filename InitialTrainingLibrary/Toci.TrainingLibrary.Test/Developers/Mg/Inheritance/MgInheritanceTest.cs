using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.TraininigLibrary.Developers.Mg.Inheritance.Common_interface_solution;
using Toci.TraininigLibrary.Developers.Mg.Inheritance.Common_interface_solution.Interfaces;
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
            
           IMgCommonDictionaryBase<string> commonDict = new MgCommonDictionary<string>()
           {
               {"abccba", "1"},
               {"rower", "2"},
               {"weror", "3"},
               {"abc234324", "4"},


           };
           IMgCommonDictionaryBase<string> commonSortedList = new MgCommonNonGenericSortedList<string>()
           {  
               {"abccba", "1"},
               {"rower", "2"},
               {"weror", "3"},
               {"abc234324", "4"},
               
           };

            var IMgDictAnagram = commonDict.GetAnagramSet("rower");
            var IMgDictPalindrom = commonDict.GetPalindromSet();
            var IMgDictWildCard = commonDict.GetWildcardSet("abc");

            var IMgSortedListAnagram = commonSortedList.GetAnagramSet("rower");
            var IMgSortedListPalindrom = commonSortedList.GetPalindromSet();
            var IMgSortedListWildCard = commonSortedList.GetWildcardSet("abc");


            for (int i = 0; i < anagramList.Count; i++)
            {
                Assert.AreEqual(IMgDictAnagram[i],anagramList[i]);
                Assert.AreEqual(IMgSortedListAnagram[i], anagramList[i]);
            }

            for (int i = 0; i < palindromList.Count; i++)
            {
                Assert.AreEqual(IMgDictPalindrom[i], palindromList[i]);
                Assert.AreEqual(IMgSortedListPalindrom[i], palindromList[i]);
            }

            
            for (int i = 0; i < wildCardList.Count; i++)
            {
                Assert.AreEqual(IMgDictWildCard[i], wildCardList[i]);
               // Assert.AreEqual(IMgSortedListWildCard[i], wildCardList[i]);
            }


      
        }
    }
}
