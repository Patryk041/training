using System;
using System.Collections.Generic;
using System.Linq;
using Anathema.MartaGr;
using Anathema.Terry;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.Terry
{
    [TestClass]
    public class UnitTest1
    {
        private string zmienna = "akslhdasj";


        protected List<int> IntList = new List<int>
        {
                1,
                5,
                2,
                4,
                6,
                8,
                4,
                5,
                7,
                9,
                11
        };

        protected Dictionary<int, string> TestDictionary = new Dictionary<int, string>
        {
            {1, "ala"},
            {2, "ma"},
            {3, "kota"},
            {4, "ala"},
            {5, "kota"},
        };


        [TestMethod]
        public void TestMethod1()
        {

            var resultInt = IntList.Where(number => number > 3 && number < 9).ToArray();

            List<int> test = IntList.Where(number => IsOkNumber(number)).ToList();

            var dictTesting = TestDictionary.Select(item => item.Value == "ala" ? "jest Ala" : "nie ma").ToList();


            int liczba;
            string napis;
            bool bul;

        
           

        }

        public bool IsOkNumber(int liczba)
        {
            return liczba > 3 && liczba < 9;
        }
    }
}
