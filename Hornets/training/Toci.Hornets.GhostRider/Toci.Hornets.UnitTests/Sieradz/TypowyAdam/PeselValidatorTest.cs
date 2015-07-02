using System;
using System.Collections.Generic;
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
            /*POTEM ZROBIE FABRYKE WALIDATORÓW :)*/
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
            TypowyAdamPeselValidator peselValidator = new TypowyAdamPeselValidator();
            
            foreach (string testPesel in validPeselList)
            {
                Assert.IsTrue(peselValidator.IsPeselValid(testPesel));
            }
            foreach (string testPesel in invalidPeselLIst)
            {
                Assert.IsFalse(peselValidator.IsPeselValid(testPesel));
            }
            foreach (var testPesel in uncommonCasesList)
            {
                Assert.IsFalse(peselValidator.IsPeselValid(testPesel));
            }
            
        }
    }
}
