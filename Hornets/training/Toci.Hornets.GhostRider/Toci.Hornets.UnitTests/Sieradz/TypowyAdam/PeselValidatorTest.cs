using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Hornets.Sieradz.TypowyAdam.UndergroundTasks;

namespace Toci.Hornets.UnitTests.Sieradz.TypowyAdam
{
    [TestClass]
    public class PeselValidatorTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            List<string> validPeselList = new List<string>();
            List<string> invalidPeselLIst = new List<string>();
            List<string> uncommonCasesList = new List<string>()
            {
                "93022912345",
                "asdasdasdasd",
                "asdgnbbn3434123",
                "12345678901A"
                //dodawajcie coś bo mi się nie chce 
            };
            List<bool> testList = new List<bool>();

            using (StreamReader sr = new StreamReader(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\Sieradz\TypowyAdam\validPeselList.txt")))
            {
                while (sr.Peek() >= 0)
                {
                    validPeselList.Add(sr.ReadLine());
                }
            }
            using (StreamReader sr = new StreamReader(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\Sieradz\TypowyAdam\invalidPeselList.txt")))
            {
                while (sr.Peek() >= 0)
                {
                    invalidPeselLIst.Add(sr.ReadLine());
                }
            }
         
            foreach (var item in ValidatorFactory)
            {
                foreach (string testPesel in validPeselList)
                {
                    Assert.IsTrue(item.Value(testPesel));
                }
                foreach (string testPesel in invalidPeselLIst)
                {
                    Assert.IsFalse(item.Value(testPesel));
                }
                foreach (string testPesel in uncommonCasesList)
                {
                    Assert.IsFalse(item.Value(testPesel));
                    
                }
            }

        }
        public static Dictionary<string, Func<string, bool>> ValidatorFactory = new Dictionary<string, Func<string, bool>>()
         {
             //sorki Adam że zjechałem :P
             {
                 "TypowyAdam",
                 new TypowyAdamPeselValidator().IsPeselValid
             }
         };
    }


}
