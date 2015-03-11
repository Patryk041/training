using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.TraininigLibrary.Developers.Dysq.Inheritance;

namespace Toci.TrainingLibrary.Test.Developers.Dysq.Inheritance
{
    [TestClass]
    public class DysqTest
    {
        private DysqCommonDictionary<string> dysqCreateDictionary()
        {
             DysqCommonDictionary<string> dysqDictionaryTest = new DysqCommonDictionary<string>();
           
            dysqDictionaryTest.Add("abba","1");
            dysqDictionaryTest.Add("yey","2");
            dysqDictionaryTest.Add("dysq","3");
            dysqDictionaryTest.Add("dysqmasa","4");
            dysqDictionaryTest.Add("rara","5");
            dysqDictionaryTest.Add("arar","6");
            dysqDictionaryTest.Add("narty","7");

            return dysqDictionaryTest;
        }

        [TestMethod]
        public void DysqInheritanceTest()
        {
            var dysqDictionaryTest = dysqCreateDictionary();

            var dysqAnagram = dysqDictionaryTest.GetAnagramSet("tyran");

            var dysqPalindrom = dysqDictionaryTest.GetPalindromSet();

            var dysqWildrCard = dysqDictionaryTest.GetWildcardSet("dysq");

          

           var dysqAnagramExt= dysqDictionaryTest.IsDysqAnagram("tyran");
           var dysqPalindromExt= dysqDictionaryTest.IsDysqPalindrom();
           var dysqWildCardExt= dysqDictionaryTest.IsDysqWildcard("dysq");
         
        }
    }
}
