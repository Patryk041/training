using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Hornets.GhostRider.YourWork.TasksTrainingTwo;
using Toci.Hornets.Wroclaw.Ayuu.TrainingTwo;


namespace Toci.Hornets.UnitTests.Wroclaw.Ayuu
{
    [TestClass]
    public class AyuuStringManipulationsTest
    {
        [TestMethod]
        public void StringManipulationsTestMethod()
        {
            AyuuStringManipulations asm = new AyuuStringManipulations();
            // true: beata; at, ata, ta, ea
            // false: beata; ae, eb, aa
            StringManipulationsResults smr1 = asm.RunStringOperations("beata", "at");
            StringManipulationsResults smr2 = asm.RunStringOperations("beata", "ata");
            StringManipulationsResults smr3 = asm.RunStringOperations("beata", "ta");
            StringManipulationsResults smr4 = asm.RunStringOperations("beata", "ea");
            StringManipulationsResults smr5 = asm.RunStringOperations("beata", "ae");
            StringManipulationsResults smr6 = asm.RunStringOperations("beata", "eb");
            StringManipulationsResults smr7 = asm.RunStringOperations("beata", "aa");
            Assert.IsTrue(smr1.IsStringInString);
            Assert.IsTrue(smr2.IsStringInString);
            Assert.IsTrue(smr3.IsStringInString);
            Assert.IsTrue(smr4.IsStringInString);
            Assert.IsFalse(smr5.IsStringInString);
            Assert.IsFalse(smr6.IsStringInString);
            Assert.IsFalse(smr7.IsStringInString);

            // true: beata; aat, taae, aea
            // false: beata; aaa, taaa, tta, aee
            //StringManipulationsResults smr8 = asm.RunStringOperations("beata", "aat");
            //StringManipulationsResults smr9 = asm.RunStringOperations("beata", "taae");
            //StringManipulationsResults smr10 = asm.RunStringOperations("beata", "aea");
            //StringManipulationsResults smr11 = asm.RunStringOperations("beata", "aaa");
            //StringManipulationsResults smr12 = asm.RunStringOperations("beata", "taaa");
            //StringManipulationsResults smr13 = asm.RunStringOperations("beata", "tta");
            //StringManipulationsResults smr14 = asm.RunStringOperations("beata", "aee");
            //Assert.IsTrue(smr8.IsStringElementsInString);
            //Assert.IsTrue(smr9.IsStringElementsInString);
            //Assert.IsTrue(smr10.IsStringElementsInString);
            //Assert.IsFalse(smr11.IsStringElementsInString);
            //Assert.IsFalse(smr12.IsStringElementsInString);
            //Assert.IsFalse(smr13.IsStringElementsInString);
            //Assert.IsFalse(smr14.IsStringElementsInString);

            StringManipulationsResults smr15 = asm.RunStringOperations("beata", "eabat");
            StringManipulationsResults smr16 = asm.RunStringOperations("beata", "aetabf");
            StringManipulationsResults smr17 = asm.RunStringOperations("beata", "eeabat");

            Assert.IsTrue(smr15.IsAnagram);
            Assert.IsFalse(smr16.IsAnagram);
            Assert.IsFalse(smr17.IsAnagram);

        } 
    }
}