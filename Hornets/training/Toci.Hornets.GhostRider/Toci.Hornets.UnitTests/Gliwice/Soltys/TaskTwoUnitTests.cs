using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Hornets.GhostRider.YourWork.TasksTrainingTwo;
using Toci.Hornets.Gliwice.Soltys.TasksTrainingTwo;

namespace Toci.Hornets.UnitTests.Gliwice.Soltys
{
    [TestClass]
    public class TaskTwoUnitTests
    {
        [TestMethod]
        public void Is_String_Manipulator_Class_Work_Properly()
        {
            var testSubject = "roman";

            var testSeekStrings = new string[]
            {
                "oa",
                "rao",
                "oma",
                "nam",
                "namor",
                "abcdf",
                "morna",
                "romanus"
            };

            var target = new StringManipulator();

            var results = new List<StringManipulationsResults>();

            foreach (var testSeekString in testSeekStrings)
            {
                results.Add(target.RunStringOperations(testSubject, testSeekString));
            }

            // subject: roman, seek: oa
            Assert.IsTrue(results[0].IsStringElementsInString);
            Assert.IsFalse(results[0].IsStringInString);
            Assert.IsFalse(results[0].IsAnagram);

            // subject: roman, seek: rao
            Assert.IsTrue(results[1].IsStringElementsInString);
            Assert.IsFalse(results[1].IsStringInString);
            Assert.IsFalse(results[1].IsAnagram);

            // subject: roman, seek: oma
            Assert.IsTrue(results[2].IsStringElementsInString);
            Assert.IsTrue(results[2].IsStringInString);
            Assert.IsFalse(results[2].IsAnagram);

            // subject: roman, seek: nam
            Assert.IsTrue(results[3].IsStringElementsInString);
            Assert.IsFalse(results[3].IsStringInString);
            Assert.IsFalse(results[3].IsAnagram);

            // subject: roman, seek: namor
            Assert.IsTrue(results[4].IsStringElementsInString);
            Assert.IsFalse(results[4].IsStringInString);
            Assert.IsTrue(results[4].IsAnagram);

            // subject: roman, seek: abcdf
            Assert.IsFalse(results[5].IsStringElementsInString);
            Assert.IsFalse(results[5].IsStringInString);
            Assert.IsFalse(results[5].IsAnagram);

            // subject: roman, seek: morna
            Assert.IsTrue(results[6].IsStringElementsInString);
            Assert.IsFalse(results[6].IsStringInString);
            Assert.IsTrue(results[6].IsAnagram);

            // subject: roman, seek: romanus
            Assert.IsFalse(results[7].IsStringElementsInString);
            Assert.IsFalse(results[7].IsStringInString);
            Assert.IsFalse(results[7].IsAnagram);

            foreach (var result in results)
            {
                Assert.AreEqual("Sołtys", result.Nick);
            }
        }
    }
}
