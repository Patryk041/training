using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Hornets.GhostRider.YourWork.TasksTrainingTwo;
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
        private static string assemblyName = "Toci.Hornets.Sieradz";

        private static List<object> PeselValidatorsList = new List<object>();
        private static List<List<string>> peselListsList = new List<List<string>>();
        private static Dictionary<string, Func<string, bool>> ValidatorFactory = new Dictionary<string, Func<string, bool>>();

        [TestMethod]
        public void TestMethod1()
        {
            /*
            foreach (var item in ValidatorFactory)
            {

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

            }
            */
            Stopwatch benchmark = new Stopwatch();
            benchmark.Start();
            GenerateListOfPeselList(testDirectory);
            GenerateObjectList(assemblyName);
            GenerateMethodFactory();
            benchmark.Stop();
            Debug.Print("Generating structures takes:{0}ms", benchmark.ElapsedMilliseconds);
            foreach (var isPeselValid in ValidatorFactory)
            {
                
                benchmark.Start();
                foreach (var peselLists in peselListsList)
                {
                    for(int i = 0; i<peselLists.Count-1;i++)//foreach (var pesel in peselLists)
                    {
                        Assert.AreEqual(isPeselValid.Value(peselLists[i]), (peselLists.Last() == "true"));
                    }


                }
                benchmark.Stop();
                Debug.Print("{0}: {1}ms", isPeselValid.Key, Convert.ToString(benchmark.ElapsedMilliseconds));
            }
        }

        private static void GenerateMethodFactory()
        {
            foreach (PeselValidator o in PeselValidatorsList)
            {
                ValidatorFactory.Add(o.GetNick(), o.IsPeselValid);
            }
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

        private static void GenerateObjectList(string assemblyName)
        {

            Assembly myAssembly = AppDomain.CurrentDomain.Load(assemblyName);
            foreach (var type in myAssembly.GetTypes().Where(type => type.IsClass && type.IsSubclassOf(typeof(PeselValidator))))
            {
                PeselValidatorsList.Add((PeselValidator) Activator.CreateInstance(type));
            }   
        }
    }


}
