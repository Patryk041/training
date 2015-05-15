using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.BeginnersTrainingLibrary.TrainingFour.Disposables;
using Toci.BeginnersTrainingLibrary.TrainingOne.Amman.DateValidator;
using Toci.BeginnersTrainingLibrary.TrainingOne.coousey.DateValidator;
using Toci.BeginnersTrainingLibrary.TrainingOne.denio.DateValidator;
using Toci.BeginnersTrainingLibrary.TrainingOne.Doktor.DateValidator;
using Toci.BeginnersTrainingLibrary.TrainingOne.Erley.ErleyDateValidator;
using Toci.BeginnersTrainingLibrary.TrainingOne.Excercise;
using Toci.BeginnersTrainingLibrary.TrainingOne.Kielich.DateValidator;
using Toci.BeginnersTrainingLibrary.TrainingOne.Ksebal.DateValidator;
using Toci.BeginnersTrainingLibrary.TrainingOne.Matwie.DateValidator;
using Toci.BeginnersTrainingLibrary.TrainingOne.Mes.DateValidator;
using Toci.BeginnersTrainingLibrary.TrainingOne.Recha.DateValidator;
using Toci.BeginnersTrainingLibrary.TrainingOne.Rubi;
using Toci.BeginnersTrainingLibrary.TrainingOne.S2yfr4nt.DateValidator;
using Toci.BeginnersTrainingLibrary.TrainingOne.Wiosna.DataValidator;
using Toci.BeginnersTrainingLibrary.TrainingOne.Zielu.DateValidator;
using Toci.BeginnersTrainingLibrary.TrainingOne.Zly.DateValidator;

namespace Toci.BeginnersTest.Warrior.DateValidator
{
    [TestClass]
    public class WarriorDateValidationTest
    {
        class TestResultsContainer
        {
            public string Name { get; set; }

            public double TotalTime { get; set; }

            public int TotalErrors { get; set; }

            public int TotalExceptions { get; set; }

            public List<string> ErrorDates { get; set; }

            public override string ToString()
            {
                return string.Format("Nick: {0}, Time: {1}, Errs: {2}, Exc: {3}", Name, TotalTime, TotalErrors, TotalExceptions);
            }
        }

        class TestDate
        {
            public int day;
            public int month;
            public int year;
            public bool Valid;
        }

        [TestMethod]
        public void TestDateValidators()
        {
            //TestResultsContainer 
            List<IDateValidator> dateValidators = new List<IDateValidator>
            {
                new AmmanDateValidator(),
                new CoouseyDateValidator(),
                new DateValidate(),
                new DenioDateValidator(),
                new DoktorDateValidator(),
                new ErleyDateValidator(),
                new KielichDateValidator(),
                new KsebalDateValidator(),
                new MatwieDateValidator(),
                new MesDateValidator(),
                new RubiDateValidator(),
                new S2yfr4ntDateValidator(),
                new WiosnaDateValidator(),
                new ZieluDateValidator(),
                new ZlyDateValidator()
            };

            List<TestDate> testDates = new List<TestDate>
            {
                new TestDate() { day = 32, month = 12, year = 2013, Valid = false},
                new TestDate() { day = 31, month = 13, year = 2013, Valid = false},
                new TestDate() { day = 29, month = 2, year = 2013, Valid = false},
                new TestDate() { day = 28, month = 2, year = 2013, Valid = true},
                new TestDate() { day = 28, month = 2, year = -1, Valid = false},
                new TestDate() { day = 31, month = 4, year = 2013, Valid = false},
                new TestDate() { day = 31, month = 6, year = 2013, Valid = false},
                new TestDate() { day = 31, month = 9, year = 2013, Valid = false},
                new TestDate() { day = 31, month = 11, year = 2013, Valid = false},
                new TestDate() { day = 32, month = 1, year = 2013, Valid = false},
                new TestDate() { day = 32, month = 3, year = 2013, Valid = false},
                new TestDate() { day = 32, month = 5, year = 2013, Valid = false},
                new TestDate() { day = 32, month = 7, year = 2013, Valid = false},
                new TestDate() { day = 32, month = 8, year = 2013, Valid = false},
                new TestDate() { day = 32, month = 10, year = 2013, Valid = false},
                new TestDate() { day = 0, month = 10, year = 2013, Valid = false},
                new TestDate() { day = 1, month = 10, year = 2013, Valid = true},
                new TestDate() { day = 29, month = 2, year = 1984, Valid = true},
            };

            List<TestResultsContainer> testsResults = new List<TestResultsContainer>();

            foreach (var dateValidator in dateValidators)
            {
                var resContainer = new TestResultsContainer() { Name = dateValidator.GetNick()};
                resContainer.ErrorDates = new List<string>();

                foreach (var testDate in testDates)
                {
                    Stopwatch st = new Stopwatch();
                    bool res = false;
                    int err = 0;
                    try
                    {
                        st.Start();
                        res = dateValidator.CheckDate(testDate.year, testDate.month, testDate.day);

                        resContainer.TotalTime += st.ElapsedMilliseconds;

                        st.Stop();

                        err = (res ^ testDate.Valid) ? 1 : 0;
                    }
                    catch (Exception ex)
                    {
                        resContainer.TotalExceptions += 1;
                        err = 1;
                    }

                    resContainer.TotalErrors += err;

                    if (err == 1)
                    {
                        resContainer.ErrorDates.Add(string.Format("{0}-{1}-{2}", testDate.year, testDate.month, testDate.day));
                    }
                }

                testsResults.Add(resContainer);
            }

            foreach (var testsResult in testsResults)
            {
                Debug.WriteLine(testsResult.ToString());
            }
        }
    }
}