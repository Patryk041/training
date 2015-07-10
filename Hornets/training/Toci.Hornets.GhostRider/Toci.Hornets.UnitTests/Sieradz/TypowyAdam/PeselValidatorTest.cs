using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Hornets.Sieradz.Duch.Homework_2.PeselValidator;
using Toci.Hornets.Sieradz.Quicksilver.TasksTrainingTwoQs;
using Toci.Hornets.Sieradz.TypowyAdam.UndergroundTasks;
using Toci.Hornets.Sieradz.UCantTouchThis.TasksTrainingTwo;
using Toci.Hornets.Sieradz.UCantTouchThis.UndergroundTasks.PeselValidator;

namespace Toci.Hornets.UnitTests.Sieradz.TypowyAdam
{
    [TestClass]
    public class PeselValidatorTest
    {
        private static string testDirectory = @"..\..\Sieradz\TypowyAdam\";

        [TestMethod]
        public void TestMethod1()
        {
            /*List<string> validPeselList = new List<string>();
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
            */
            GenerateListOfPeselList(testDirectory);
        }


        private static void GenerateListOfPeselList(string initialDirectory)
        {
            List<string> fileNames = new List<string>(Directory.GetFiles(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @initialDirectory)));
            fileNames= fileNames.Where(s => s.Contains(".txt")).Where(s => s.Contains("Pesel")).ToList();
            foreach (var fileName in fileNames)
            {
                peselListsList.Add(GeneratePeselList(fileName));
            }
        }
        private static List<string> GeneratePeselList(string patch)
        {
            List<string> peselList = new List<string>();

            using (StreamReader txtReader = new StreamReader(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @patch)))
            {
                while (txtReader.Peek() >= 0)
                {
                    peselList.Add(txtReader.ReadLine());
                }
            }
            return peselList;
        }

        private static List<List<string>> peselListsList = new List<List<string>>();
        private static Dictionary<string, Func<string, bool>> ValidatorFactory = new Dictionary<string, Func<string, bool>>()
         {
             //sorki Adam że zjechałem :P


             // "Nie bądź jak leń co śmierdzący jest!"
             //                                 UCTT

             { "TypowyAdam", new TypowyAdamPeselValidator().IsPeselValid },
             { "TypowyAdam4GhostWarrior", new TypowyAdamPeselValidator().IsPeselValid },
             { "UCantTouchThisAutism", new UCantTouchThisAutismPeselValisator().IsPeselValid },
             { "UCantTouchThis", new UCantTouchThisPeselValidator().IsPeselValid },
             { "Quicksilver", new QuicksilverPeselValidator().IsPeselValid },
             { "DuchGottaGoFast", new DuchPeselValidator().IsPeselValid }
         };
    }


}
