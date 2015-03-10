using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.TraininigLibrary.Common.Base.Inheritance;
using Toci.TraininigLibrary.Developers.Vernathic.Inheritance;

namespace Toci.TrainingLibrary.Test.Developers.Vernathic.Inheritance
{
    [TestClass]
    public class VInheritanceTest
    {

        [TestMethod]
        public void InheritanceTest()
        {
            VInheritance<string> myNewDictionary = new VInheritance<string>()
            {
                {"asdfgfdsa", "p1"},
                {"tuba", "a1"},
                {"miśkowiec", "n1"},
                {"bob", "p2"},
                {"buta", "a2"},
                {"tabu", "a3"},
                {"misiaczek", "m1"},
                {"radar", "p3"},
                {"misiowy", "m2"}
            };

            var palindromList = myNewDictionary.GetPalindromSet();
            var anagramList = myNewDictionary.GetAnagramSet("batu");
            var wildcardList = myNewDictionary.GetWildcardSet("mis");

        }
    }
}
