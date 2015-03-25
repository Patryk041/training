using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.TraininigLibrary.Developers.Robson.RobsonsDictionaryInheritance;
using Toci.TraininigLibrary.Developers.Robson.RobsonExtendedDictionary;

namespace Toci.TrainingLibrary.Test.Developers.Robson
{
    [TestClass]
    public class RobsonsInheritanceTest
    {
        [TestMethod]
        public void TestDictionary()
        {
            RobsonsDictionary dict = new RobsonsDictionary();

            dict.Add("kajak", new ExampleClass{Name = "Palindrom", Value = 1});
            dict.Add("lubie placki", new ExampleClass { Name = "Anagram", Value = 2 });
            dict.Add("wildcard", new ExampleClass { Name = "WildCard", Value = 3 });

            List<ExampleClass> list1 = dict.GetAnagramSet("ikcalp eibul");
            List<ExampleClass> list2 = dict.GetPalindromSet();
            List<ExampleClass> list3 = dict.GetWildcardSet("wild");
        }

        [TestMethod]
        public void TestExtensions()
        {
            RobsonsDictionary dict = new RobsonsDictionary();

            dict.Add("kajak", new ExampleClass { Name = "Palindrom", Value = 1 });
            dict.Add("lubie placki", new ExampleClass { Name = "Anagram", Value = 2 });
            dict.Add("wildcard", new ExampleClass { Name = "WildCard", Value = 3 });

            List<string> list1 = dict.GetPalindromsList();
            List<string> list2 = dict.GetAnagramList("ikcalp eibul");
            List<string> list3 = dict.GetWildcardList("wild");
        }
    }
}
