using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Hornets.Sieradz.UCantTouchThis.ExtensionMethods;
using Toci.Hornets.Sieradz.UCantTouchThis.TasksTrainingTwo;

namespace Toci.Hornets.UnitTests.Sieradz.UCantTouchThis
{
    [TestClass]
    public class StringManipulationsTests
    {
        private const string Subject = "beata";

        private static readonly List<string> TrueForIsStringInString = new List<string>
        { "at", "ata", "ta", "ea" };

        private static readonly List<string> FalseForIsStringInString = new List<string>
        { "ae", "eb", "aa" };

        private static readonly List<string> TrueForIsStringElementsInString = new List<string>
        { "aat", "taae", "aea" };

        private static readonly List<string> FalseForIsStringElementsInString = new List<string>
        { "aaa", "taaa", "tta", "aee" };

        private static readonly List<string> TrueForIsStringAnagramOfString = new List<string>
        { "ataeb","aateb","tbaea" };

        private static readonly List<string> FalseForIsStringAnagramOfString = new List<string>
        { "aaateb", "fdwgdw" };

        private readonly UCantTouchThisStringManipulations _manipulator = new UCantTouchThisStringManipulations();

        // first time with Tuples, testing them
        private readonly List<Tuple<List<string>, string, bool>> _testSequences = new List<Tuple<List<string>, string, bool>>
        {
            Tuple.Create(TrueForIsStringInString, "IsStringInString", true),
            Tuple.Create(FalseForIsStringInString, "IsStringInString", false),
            Tuple.Create(TrueForIsStringElementsInString, "IsStringElementsInString", true),
            Tuple.Create(FalseForIsStringElementsInString, "IsStringElementsInString", false),
            Tuple.Create(TrueForIsStringAnagramOfString, "IsAnagram", true),
            Tuple.Create(FalseForIsStringAnagramOfString, "IsAnagram", false)      
        };
        
        
        [TestMethod]
        public void UCTT_StringManipulationsTest()
        {
            foreach (var testSequence in _testSequences)
                TestElement(testSequence.Item1,testSequence.Item2,testSequence.Item3);
            
        }

        private void TestElement(List<string> seekList, string propertyName, bool condition)
        {
            foreach (var item in seekList)
                Assert.AreEqual(condition, _manipulator.RunStringOperations(Subject,item)
                    .GetPublicPropertyValue(propertyName));
        }
    }
}