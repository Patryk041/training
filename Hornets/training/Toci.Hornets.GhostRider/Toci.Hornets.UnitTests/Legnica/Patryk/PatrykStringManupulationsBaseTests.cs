using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Hornets.GhostRider.YourWork.TasksTrainingTwo;
using Toci.Hornets.Legnica.Patryk_Stulczewski.TrainingTwo.StringManipulations;


namespace Toci.Hornets.UnitTests.Legnica.Patryk
{
    [TestClass]
    public class PatrykStringManupulationsBaseTests
    {
        // true: beata; at, ata, ta, ea
        // false: beata; ae, eb, aa
        
        [TestMethod]
        public void IsStringAnagramOfStringTest()
        {
           GhostRiderStringManipulationsBase stringManipulatios= new PatrykStringManipulationsBase();
            var results = new List<StringManipulationsResults>
            {
                stringManipulatios.RunStringOperations("ayuoqln", "qnloyua"),
                stringManipulatios.RunStringOperations("kajak", "jaakk"),
                stringManipulatios.RunStringOperations("rower", "worer"),
                stringManipulatios.RunStringOperations("aa", "aaa"),
                stringManipulatios.RunStringOperations("ayuoqln", "qnlobua"),
            };

            Assert.IsTrue(results[0].IsAnagram);
            Assert.IsTrue(results[1].IsAnagram);
            Assert.IsTrue(results[2].IsAnagram);
            Assert.IsFalse(results[3].IsAnagram);
            Assert.IsFalse(results[4].IsAnagram);
                
        }

        [TestMethod]
        public void IsStringElementsInStringTest()
        {
            GhostRiderStringManipulationsBase stringManipulatios = new PatrykStringManipulationsBase();
            var results = new List<StringManipulationsResults>
            {
                stringManipulatios.RunStringOperations("kajaak", "aaaj"),
                stringManipulatios.RunStringOperations("kajaak", "kajaak"),
                stringManipulatios.RunStringOperations("kajaak", "j"),
                stringManipulatios.RunStringOperations("kajaak", "aaaa"),
                stringManipulatios.RunStringOperations("kajaak", "ebb")
            };

            Assert.IsTrue(results[0].IsStringElementsInString);
            Assert.IsTrue(results[1].IsStringElementsInString);
            Assert.IsTrue(results[2].IsStringElementsInString);
            Assert.IsFalse(results[3].IsStringElementsInString);
            Assert.IsFalse(results[4].IsStringElementsInString);
      
        }

        [TestMethod]
        public void IsStringInStringTest()
        {
            GhostRiderStringManipulationsBase stringManipulatios = new PatrykStringManipulationsBase();
            var results = new List<StringManipulationsResults>
            {
                stringManipulatios.RunStringOperations("kaaajaaaak", "aaa"),
                stringManipulatios.RunStringOperations("kaaajaaaak", "aaaak"),
                stringManipulatios.RunStringOperations("kaaajaaaak", "kaaajaaaak"),
                stringManipulatios.RunStringOperations("kaaajaaaak", "aaaaaak"),
                stringManipulatios.RunStringOperations("kaaajaaaak", "jkaaaa")
            };

            Assert.IsTrue(results[0].IsStringInString);
            Assert.IsTrue(results[1].IsStringInString);
            Assert.IsTrue(results[2].IsStringInString);
            Assert.IsFalse(results[3].IsStringInString);
            Assert.IsFalse(results[4].IsStringInString);
        }
    }
}
