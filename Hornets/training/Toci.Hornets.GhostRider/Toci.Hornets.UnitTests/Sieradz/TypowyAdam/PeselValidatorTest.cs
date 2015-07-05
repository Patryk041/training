using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Hornets.Sieradz.TypowyAdam.UndergroundTasks;
using Toci.Hornets.Sieradz.UCantTouchThis.TasksTrainingTwo;
using Toci.Hornets.Sieradz.UCantTouchThis.UndergroundTasks.PeselValidator;

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
            List<string> uncommonCasesList = new List<string>
            {
                "93022912345",
                "asdasdasdasd",
                "asdgnbbn3434123",
                "12345678901A"
                //dodawajcie coś bo mi się nie chce 
            };

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
                Stopwatch benchmark = new Stopwatch();
                benchmark.Start();
                for (int i = 0; i < 100; i++) //bez tego wykonuje się w 10ms co jest trochę za krótkie
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
                benchmark.Stop();
                Debug.Print("{0}: {1}ms", item.Key, Convert.ToString(benchmark.ElapsedMilliseconds));
            }

        }
        public static Dictionary<string, Func<string, bool>> ValidatorFactory = new Dictionary<string, Func<string, bool>>()
         {
             //sorki Adam że zjechałem :P


             // "Nie bądź jak leń co śmierdzący jest!"
             //                                 UCCT

             { "TypowyAdam", new TypowyAdamPeselValidator().IsPeselValid },
             { "UCantTouchThisAutism", new UCantTouchThisAutismPeselValisator().IsPeselValid },
             { "UCantTouchThis", new UCantTouchThisPeselValidator().IsPeselValid }
         };
    }


}
