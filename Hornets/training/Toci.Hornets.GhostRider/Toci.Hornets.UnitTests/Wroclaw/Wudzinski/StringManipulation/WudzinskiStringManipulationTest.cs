using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Hornets.Wroclaw.Wudzinski.Homework2;

namespace Toci.Hornets.UnitTests.Wroclaw.Wudzinski.StringManipulation
{
    [TestClass]
    public class WudzinskiStringManipulationTest
    {

        [TestMethod]
        public void IsStringInStringTest ()
        {
            var StringManipulations = new WudzinskiStringManipulations();
            string subject = "beata";

            string seek = "at";
            var result = StringManipulations.RunStringOperations(subject, seek);
            Assert.IsTrue(result.IsStringInString);

            seek = "ata";
            result = StringManipulations.RunStringOperations(subject, seek);
            Assert.IsTrue(result.IsStringInString);

            seek = "ta";
            result = StringManipulations.RunStringOperations(subject, seek);
            Assert.IsTrue(result.IsStringInString);

            seek = "ea";
            result = StringManipulations.RunStringOperations(subject, seek);
            Assert.IsTrue(result.IsStringInString);

            seek = "ae";
            result = StringManipulations.RunStringOperations(subject, seek);
            Assert.IsFalse(result.IsStringInString);

            seek = "eb";
            result = StringManipulations.RunStringOperations(subject, seek);
            Assert.IsFalse(result.IsStringInString);

            seek = "aa";
            result = StringManipulations.RunStringOperations(subject, seek);
            Assert.IsFalse(result.IsStringInString);

            seek = null;
            result = StringManipulations.RunStringOperations(subject, seek);
            Assert.IsFalse(result.IsStringInString);

            seek = null;
            subject = null;
            result = StringManipulations.RunStringOperations(subject, seek);
            Assert.IsFalse(result.IsStringInString);

            seek = "aaa";
            result = StringManipulations.RunStringOperations(subject, seek);
            Assert.IsFalse(result.IsStringInString);

            seek = "siemaneczko";
            subject = "siema";
            result = StringManipulations.RunStringOperations(subject, seek);
            Assert.IsFalse(result.IsStringInString);
        }

        [TestMethod]
        public void IsStringAnagramOfStringTest()
        {
            var StringManipulations = new WudzinskiStringManipulations();
            string subject = "beata";

            string seek = "ataeb";
            var result = StringManipulations.RunStringOperations(subject, seek);
            Assert.IsTrue(result.IsAnagram);

            seek = "aa";
            result = StringManipulations.RunStringOperations(subject, seek);
            Assert.IsFalse(result.IsAnagram);

            seek = "attae";
            result = StringManipulations.RunStringOperations(subject, seek);
            Assert.IsFalse(result.IsAnagram);

            seek = "";
            result = StringManipulations.RunStringOperations(subject, seek);
            Assert.IsFalse(result.IsAnagram);

            seek = null;
            result = StringManipulations.RunStringOperations(subject, seek);
            Assert.IsFalse(result.IsAnagram);

        }

        [TestMethod]
        public void IsStringElementsInStringTest()
        {
            var StringManipulations = new WudzinskiStringManipulations();
            string subject = "beata";

            string seek = "ae";
            var result = StringManipulations.RunStringOperations(subject, seek);
            Assert.IsTrue(result.IsStringElementsInString);

            seek = "taae";
            result = StringManipulations.RunStringOperations(subject, seek);
            Assert.IsTrue(result.IsStringElementsInString);

            seek = "z";
            result = StringManipulations.RunStringOperations(subject, seek);
            Assert.IsFalse(result.IsStringElementsInString);

            seek = "aez";
            result = StringManipulations.RunStringOperations(subject, seek);
            Assert.IsFalse(result.IsStringElementsInString);

            seek = "aaa";
            result = StringManipulations.RunStringOperations(subject, seek);
            Assert.IsFalse(result.IsStringElementsInString);

            seek = "taaa";
            result = StringManipulations.RunStringOperations(subject, seek);
            Assert.IsFalse(result.IsStringElementsInString);

            seek = "tta";
            result = StringManipulations.RunStringOperations(subject, seek);
            Assert.IsFalse(result.IsStringElementsInString);

            subject = "";
            result = StringManipulations.RunStringOperations(subject, seek);
            Assert.IsFalse(result.IsStringElementsInString);
        }
    }
}
