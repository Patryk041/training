using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.TraininigLibrary.Developers.Robson.RobsonsDictionaryInheritance;

namespace Toci.TrainingLibrary.Test.Developers.Robson
{
    [TestClass]
    public class RobsonsInheritanceTest
    {
        [TestMethod]
        public void TestDictionary()
        {
            RobsonsDictionary dict = new RobsonsDictionary();

            dict.Add("kajak", new ExampleClass{Name = "Robson", Value = 1});
            dict.Add("lubie placki", new ExampleClass { Name = "Jan", Value = 2 });
            dict.Add("wildcard", new ExampleClass { Name = "Kowalski", Value = 3 });

            List<ExampleClass> list1 = dict.GetAnagramSet("ikcalp eibul");
            List<ExampleClass> list2 = dict.GetPalindromSet();
            List<ExampleClass> list3 = dict.GetWildcardSet("wild");
        }
    }
}
