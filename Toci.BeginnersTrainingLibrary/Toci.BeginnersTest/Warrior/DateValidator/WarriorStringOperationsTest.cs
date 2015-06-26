using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.BeginnersTrainingLibrary.TrainingOne.coousey.TextUtils;
using Toci.BeginnersTrainingLibrary.TrainingOne.denio.PalindromAnagramWildcard;
using Toci.BeginnersTrainingLibrary.TrainingOne.Excercise;
using Toci.BeginnersTrainingLibrary.TrainingOne.Matwie.TextUtils;
using Toci.BeginnersTrainingLibrary.TrainingOne.Mes.TextUtils;
using Toci.BeginnersTrainingLibrary.TrainingOne.Recha.TextOperations;
using Toci.BeginnersTrainingLibrary.TrainingOne.S2yfr4nt.Text;
using Toci.BeginnersTrainingLibrary.TrainingOne.Zielu.TextValidator;
using Toci.BeginnersTrainingLibrary.TrainingOne.Zly.TextOpeartionsSet;

namespace Toci.BeginnersTest.Warrior.DateValidator
{
    [TestClass]
    public class WarriorStringOperationsTest
    {
        [TestMethod]
        public void WarriorStringOperationsByAllTest()
        {
            var testStrings = new[] { "darad", "ad", "bc", "radad", "test" };

            List<ITextOperationsSets> textOperations = new List<ITextOperationsSets>
            {
                new CoouseyTextUtils(testStrings),
                new MatwieTextUtils(testStrings, testStrings, testStrings),
                new MesTextUtils(testStrings, testStrings, testStrings),
                new S2yfr4ntTextOpertionsSets(testStrings, testStrings, testStrings),
                //new TextOperations(),
                new TextOperationsSets(testStrings, testStrings, testStrings),
                //new ZieluTexts(),
                //new ZlyTextOperationsSets()
            };

            foreach (var textOperation in textOperations)
            {
                //textOperation.GetAnagramsSet("ddaar").Length
            }
        }
    }
}
